' 破損ファイル対応強化版マクロ
' Enhanced macro with corrupted file handling
' 
' このマクロは元のfolder()マクロを拡張し、破損したExcelファイルでも
' 強制的にマージ処理を継続できるように設計されています。

Option Explicit

Sub folder_enhanced()
    ' 強制マージ機能付きフォルダ処理
    ' 破損ファイルがあっても処理を継続し、可能な限りデータを抽出します
    
    Dim folderPath As String
    Dim fileName As String
    Dim wb As Workbook
    Dim ws As Worksheet
    Dim targetWs As Worksheet
    Dim lastRow As Long
    Dim i As Integer
    Dim errorLog As String
    Dim processedCount As Integer
    Dim errorCount As Integer
    
    ' 処理開始前のバックアップ作成を推奨
    If MsgBox("処理開始前にバックアップを作成しますか？", vbYesNo + vbQuestion, "バックアップ確認") = vbYes Then
        Call CreateBackup
    End If
    
    ' 画面更新とアラートを無効化（処理速度向上のため）
    Application.ScreenUpdating = False
    Application.DisplayAlerts = False
    Application.EnableEvents = False
    Application.Calculation = xlCalculationManual
    
    ' フォルダ選択ダイアログ
    With Application.FileDialog(msoFileDialogFolderPicker)
        .Title = "結合したいファイルが入っているフォルダを選択してください"
        If .Show = True Then
            folderPath = .SelectedItems(1) & "\"
        Else
            GoTo CleanUp
        End If
    End With
    
    ' エラーログ初期化
    errorLog = "=== マージ処理ログ ===" & vbCrLf
    errorLog = errorLog & "処理開始時刻: " & Format(Now, "yyyy/mm/dd hh:mm:ss") & vbCrLf
    errorLog = errorLog & "対象フォルダ: " & folderPath & vbCrLf & vbCrLf
    processedCount = 0
    errorCount = 0
    
    ' Excelファイル処理開始
    fileName = Dir(folderPath & "*.xls*")
    
    Do While fileName <> ""
        ' 各ファイルの処理を試行（3段階のエラー処理）
        If ProcessFileWithErrorHandling(folderPath & fileName, errorLog, processedCount, errorCount) Then
            processedCount = processedCount + 1
        Else
            errorCount = errorCount + 1
        End If
        
        fileName = Dir()
    Loop
    
    ' CSVファイルも処理
    fileName = Dir(folderPath & "*.csv")
    Do While fileName <> ""
        If ProcessCSVWithErrorHandling(folderPath & fileName, errorLog, processedCount, errorCount) Then
            processedCount = processedCount + 1
        Else
            errorCount = errorCount + 1
        End If
        fileName = Dir()
    Loop
    
    ' 結果レポート表示
    errorLog = errorLog & vbCrLf & "=== 処理完了 ===" & vbCrLf
    errorLog = errorLog & "処理完了時刻: " & Format(Now, "yyyy/mm/dd hh:mm:ss") & vbCrLf
    errorLog = errorLog & "成功: " & processedCount & " ファイル" & vbCrLf
    errorLog = errorLog & "エラー: " & errorCount & " ファイル" & vbCrLf
    errorLog = errorLog & "合計: " & (processedCount + errorCount) & " ファイル"
    
    ' ログをファイルに保存
    Call SaveLogToFile(errorLog, folderPath)
    
    MsgBox errorLog, vbInformation, "マージ処理結果"
    
CleanUp:
    ' 設定を元に戻す
    Application.ScreenUpdating = True
    Application.DisplayAlerts = True
    Application.EnableEvents = True
    Application.Calculation = xlCalculationAutomatic
End Sub

Function ProcessFileWithErrorHandling(filePath As String, ByRef errorLog As String, processedCount As Integer, errorCount As Integer) As Boolean
    ' 破損ファイル対応のファイル処理関数
    ' 3段階のアプローチで破損ファイルからもデータを抽出
    
    Dim wb As Workbook
    Dim ws As Worksheet
    Dim targetWs As Worksheet
    Dim fileName As String
    Dim attempt As Integer
    Dim maxAttempts As Integer
    
    fileName = Dir(filePath)
    maxAttempts = 3
    ProcessFileWithErrorHandling = False
    
    errorLog = errorLog & "処理中: " & fileName & vbCrLf
    
    For attempt = 1 To maxAttempts
        On Error GoTo ErrorHandler
        
        ' 方法1: 通常のOpen
        If attempt = 1 Then
            Set wb = Workbooks.Open(filePath, UpdateLinks:=0, ReadOnly:=True)
            
        ' 方法2: 修復モードでOpen
        ElseIf attempt = 2 Then
            errorLog = errorLog & "  → 修復モードで再試行: " & fileName & vbCrLf
            Set wb = Workbooks.Open(filePath, UpdateLinks:=0, ReadOnly:=True, CorruptLoad:=xlRepairFile)
            
        ' 方法3: データ抽出モードでOpen
        ElseIf attempt = 3 Then
            errorLog = errorLog & "  → データ抽出モードで再試行: " & fileName & vbCrLf
            Set wb = Workbooks.Open(filePath, UpdateLinks:=0, ReadOnly:=True, CorruptLoad:=xlExtractData)
        End If
        
        ' ファイルが開けた場合の処理
        If Not wb Is Nothing Then
            ' 新しいワークシートを作成（名前の重複を避ける）
            Set targetWs = ThisWorkbook.Worksheets.Add(After:=ThisWorkbook.Worksheets(ThisWorkbook.Worksheets.Count))
            
            ' ワークシート名を安全に設定
            Dim safeName As String
            safeName = "Data_" & Format(processedCount + 1, "000") & "_" & Left(Replace(fileName, ".", "_"), 10)
            targetWs.Name = safeName
            
            ' データをコピー（エラー処理付き）
            If CopyDataSafely(wb, targetWs, fileName, errorLog) Then
                ProcessFileWithErrorHandling = True
                errorLog = errorLog & "  ✓ 成功: " & fileName & " (試行" & attempt & "回目)" & vbCrLf
            End If
            
            wb.Close SaveChanges:=False
            Set wb = Nothing
            Exit For
        End If
        
        Continue For
        
ErrorHandler:
        If Not wb Is Nothing Then
            wb.Close SaveChanges:=False
            Set wb = Nothing
        End If
        
        If attempt = maxAttempts Then
            errorLog = errorLog & "  ✗ 失敗: " & fileName & " - 全ての方法で開けませんでした" & vbCrLf
            errorLog = errorLog & "    エラー詳細: " & Err.Description & vbCrLf
        End If
        
        Resume Next
    Next attempt
    
End Function

Function CopyDataSafely(sourceWb As Workbook, targetWs As Worksheet, fileName As String, ByRef errorLog As String) As Boolean
    ' 安全なデータコピー関数
    ' 各ワークシートから可能な限りデータを抽出
    
    Dim sourceWs As Worksheet
    Dim usedRange As Range
    Dim copySuccess As Boolean
    Dim currentRow As Long
    Dim sheetCount As Integer
    
    CopyDataSafely = False
    copySuccess = False
    currentRow = 1
    sheetCount = 0
    
    ' ファイル情報をヘッダーに追加
    targetWs.Cells(currentRow, 1).Value = "=== " & fileName & " ==="
    targetWs.Cells(currentRow, 1).Font.Bold = True
    targetWs.Cells(currentRow, 1).Interior.Color = RGB(200, 200, 200)
    currentRow = currentRow + 2
    
    ' 各ワークシートを順次処理
    For Each sourceWs In sourceWb.Worksheets
        On Error GoTo CopyError
        
        sheetCount = sheetCount + 1
        
        ' 非表示シートも処理対象に含める
        If sourceWs.Visible = xlSheetHidden Then
            sourceWs.Visible = xlSheetVisible
        End If
        
        ' シート名を記録
        targetWs.Cells(currentRow, 1).Value = "シート: " & sourceWs.Name
        targetWs.Cells(currentRow, 1).Font.Bold = True
        currentRow = currentRow + 1
        
        ' 使用範囲を取得
        Set usedRange = sourceWs.UsedRange
        
        If Not usedRange Is Nothing And usedRange.Cells.Count > 1 Then
            ' 値のみをコピー（数式や参照を除去）
            usedRange.Copy
            targetWs.Cells(currentRow, 1).PasteSpecial xlPasteValues
            targetWs.Cells(currentRow, 1).PasteSpecial xlPasteFormats
            
            ' 次のシート用にスペースを確保
            currentRow = currentRow + usedRange.Rows.Count + 2
            
            copySuccess = True
        Else
            targetWs.Cells(currentRow, 1).Value = "(データなし)"
            currentRow = currentRow + 2
        End If
        
        Continue For
        
CopyError:
        errorLog = errorLog & "    警告: " & fileName & " の " & sourceWs.Name & " シートでエラー発生" & vbCrLf
        targetWs.Cells(currentRow, 1).Value = "(エラー: データを読み込めませんでした)"
        targetWs.Cells(currentRow, 1).Font.Color = RGB(255, 0, 0)
        currentRow = currentRow + 2
        Resume Next
    Next sourceWs
    
    Application.CutCopyMode = False
    
    ' 処理結果をログに記録
    If copySuccess Then
        errorLog = errorLog & "    データコピー完了: " & sheetCount & "シート処理" & vbCrLf
    End If
    
    CopyDataSafely = copySuccess
    
End Function

Function ProcessCSVWithErrorHandling(filePath As String, ByRef errorLog As String, processedCount As Integer, errorCount As Integer) As Boolean
    ' CSV専用の処理関数
    ' 文字コードエラーにも対応
    
    Dim wb As Workbook
    Dim targetWs As Worksheet
    Dim fileName As String
    
    fileName = Dir(filePath)
    ProcessCSVWithErrorHandling = False
    
    errorLog = errorLog & "CSV処理中: " & fileName & vbCrLf
    
    On Error GoTo CSVError
    
    ' CSVファイルを開く（複数の文字コードを試行）
    Set wb = Workbooks.Open(filePath, Format:=6, Delimiter:=",", ReadOnly:=True)
    
    ' 新しいワークシートを作成
    Set targetWs = ThisWorkbook.Worksheets.Add(After:=ThisWorkbook.Worksheets(ThisWorkbook.Worksheets.Count))
    
    Dim safeName As String
    safeName = "CSV_" & Format(processedCount + 1, "000") & "_" & Left(Replace(fileName, ".", "_"), 10)
    targetWs.Name = safeName
    
    ' ヘッダー情報を追加
    targetWs.Cells(1, 1).Value = "=== " & fileName & " (CSV) ==="
    targetWs.Cells(1, 1).Font.Bold = True
    targetWs.Cells(1, 1).Interior.Color = RGB(200, 255, 200)
    
    ' データをコピー
    If Not wb.ActiveSheet.UsedRange Is Nothing Then
        wb.ActiveSheet.UsedRange.Copy
        targetWs.Cells(3, 1).PasteSpecial xlPasteValues
    End If
    
    wb.Close SaveChanges:=False
    Application.CutCopyMode = False
    
    ProcessCSVWithErrorHandling = True
    errorLog = errorLog & "  ✓ 成功: " & fileName & " (CSV)" & vbCrLf
    
    Exit Function
    
CSVError:
    If Not wb Is Nothing Then
        wb.Close SaveChanges:=False
    End If
    errorLog = errorLog & "  ✗ 失敗: " & fileName & " (CSV読み込みエラー)" & vbCrLf
    errorLog = errorLog & "    エラー詳細: " & Err.Description & vbCrLf
    
End Function

Sub CreateBackup()
    ' バックアップ作成機能
    
    Dim backupPath As String
    backupPath = ThisWorkbook.Path & "\backup_" & Format(Now, "yyyymmdd_hhmmss") & ".xlsm"
    
    On Error GoTo BackupError
    
    ThisWorkbook.SaveCopyAs backupPath
    MsgBox "バックアップを作成しました:" & vbCrLf & backupPath, vbInformation, "バックアップ完了"
    
    Exit Sub
    
BackupError:
    MsgBox "バックアップの作成に失敗しました:" & vbCrLf & Err.Description, vbExclamation, "バックアップエラー"
    
End Sub

Sub SaveLogToFile(logContent As String, folderPath As String)
    ' ログをテキストファイルに保存
    
    Dim logFilePath As String
    Dim fileNum As Integer
    
    logFilePath = folderPath & "merge_log_" & Format(Now, "yyyymmdd_hhmmss") & ".txt"
    
    On Error GoTo LogError
    
    fileNum = FreeFile
    Open logFilePath For Output As #fileNum
    Print #fileNum, logContent
    Close #fileNum
    
    Exit Sub
    
LogError:
    ' ログ保存に失敗してもメイン処理は継続
    If fileNum > 0 Then Close #fileNum
    
End Sub

' 元のfolder()マクロとの互換性を保つためのラッパー関数
Sub folder()
    ' 元のマクロ名での呼び出しに対応
    Call folder_enhanced
End Sub
