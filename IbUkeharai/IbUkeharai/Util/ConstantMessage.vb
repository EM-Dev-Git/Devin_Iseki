Imports System

Namespace IbUkeharai.Util

	Public Class ConstantMessage

		Public Const MSG_E11001 As String = "SQL実行中にエラーが発生しました。"

		Public Const MSG_E11002 As String = "取引先コードが存在しません。[{0}]"

		Public Const MSG_E11003 As String = "取引先に対する部品が存在しません。[{0}]"

		Public Const MSG_E12001 As String = "SQL実行中にエラーが発生しました。"

		Public Const MSG_E12002 As String = "取引先コードが存在しません。[{0}]"

		Public Const MSG_E12003 As String = "取引先に対する部品が存在しません。[{0}]"

		Public Const MSG_E12004 As String = "単価マスタが存在しません。"

		Public Const MSG_E15001 As String = "取引先コードが存在しません。[{0}]"

		Public Const MSG_E15002 As String = "グリッド表示中にエラーが発生しました。"

		Public Const MSG_E15003 As String = "SQL実行中にエラーが発生しました。"

		Public Const MSG_E16001 As String = "部品コードが存在しません。[{0}]"

		Public Const MSG_E16002 As String = "グリッド表示中にエラーが発生しました。"

		Public Const MSG_E16003 As String = "SQL実行中にエラーが発生しました。"

		Public Const MSG_E16004 As String = "納入先コードが存在しません。[{0}]"

		Public Const MSG_E16005 As String = "取引先コードを指定してください。"

		Public Const MSG_N17001 As String = "請求書を削除します。よろしいですか？"

		Public Const MSG_E17001 As String = "取引先コードを指定してください。"

		Public Const MSG_E17002 As String = "請求年月を指定してください。"

		Public Const MSG_E17003 As String = "グリッド表示中にエラーが発生しました。"

		Public Const MSG_E17004 As String = "SQL実行中にエラーが発生しました。"

		Public Const MSG_E17005 As String = "納入先コードが存在しません。[{0}]"

		Public Const MSG_E17006 As String = "請求マスター登録中にエラーが発生しました。"

		Public Const MSG_E10002 As String = "変更中のデータがあります。更新しないで戻りますか？"

		Public Const MSG_E10003 As String = "更新データありません。"

		Public Const MSG_N19001 As String = "変更項目がありませんでした。"

		Public Const MSG_N19002 As String = "正常に更新されました。"

		Public Const MSG_E19001 As String = "SQL実行中にエラーが発生しました。"

		Public Const MSG_W21001 As String = "部品コードを入力してください。"

		Public Const MSG_W21002 As String = "部品マスタに該当データがありませんでした。"

		Public Const MSG_W21003 As String = "受払実績テーブルに該当データがありませんでした。"

		Public Const MSG_W21004 As String = "この部品コードには複数の取引先が存在します。" & vbCrLf & "取引先を選択して再検索してください。"

		Public Const MSG_W21005 As String = "取引先マスタに該当データがありませんでした。"

		' Token: 0x04000588 RID: 1416
		Public Const MSG_W21006 As String = "指定年月を指定してください。"

		Public Const MSG_W21007 As String = "次部品データがありません。"

		Public Const MSG_E21001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_N40001 As String = "受入データ書き込み処理が完了しました。"

		Public Const MSG_W40001 As String = "受入データ書き込みに必要な項目が有りません。" & vbCrLf & "入力ファイルのフォーマットに誤りが有ります。"

		Public Const MSG_W40002 As String = "取込み可能なデータ行が存在しません。" & vbCrLf & "入力ファイルを確認してください。"

		Public Const MSG_E40001 As String = "受入データ書き込み処理を中断します。"

		Public Const MSG_E40002 As String = "OKファイルの出力に失敗しました。"

		Public Const MSG_E40003 As String = "ERRファイルの出力に失敗しました。"

		Public Const MSG_N41000 As String = "FTPサーバからデータを受信します。よろしいですか？"

		Public Const MSG_N41001 As String = "ホストデータ受信処理が完了しました。"

		Public Const MSG_N41002 As String = "払出データ書き込み処理が完了しました。"

		Public Const MSG_N41003 As String = "FTPサーバから欠品データを受信します。よろしいですか？"

		Public Const MSG_N41004 As String = "部品進度データ受信処理が完了しました。"

		Public Const MSG_N41005 As String = "部品進度データ書き込み処理が完了しました。"

		Public Const MSG_N41006 As String = "試算表データ受信処理が完了しました。"

		Public Const MSG_N41007 As String = "試算表データ書き込み処理が完了しました。"

		Public Const MSG_E41001 As String = "ホストデータ受信処理を中断します。"

		Public Const MSG_E41002 As String = "払出データ書き込み処理を中断します。"

		Public Const MSG_E41003 As String = "ファイルのダウンロードに失敗しました。"

		Public Const MSG_E41004 As String = "バックアップフォルダの作成に失敗しました。"

		Public Const MSG_E41005 As String = "受信データのバックアップに失敗しました。"

		Public Const MSG_E41006 As String = "受信データの初期化に失敗しました。"

		Public Const MSG_E41007 As String = "受信データチェックに失敗しました。"

		Public Const MSG_E41008 As String = "受信データに書き込み可能なデータが有りません。"

		Public Const MSG_E41009 As String = "データファイルが存在しません。" & vbCrLf & "または、ファイルを開くことができません。"

		Public Const MSG_E41010 As String = "ホストデータ受信設定に不備が有ります。"

		Public Const MSG_E41011 As String = "設定情報に不備が有ります。"

		Public Const MSG_E41012 As String = "有効な書き込みデータが存在しません。" & vbCrLf & "または、ファイルデータの並びが不正です。"

		Public Const MSG_E41013 As String = "コンフィグファイル(FTP)の設定に不備があります。"

		Public Const MSG_E41014 As String = "FTP設定のTestModeの値が不明です。"

		Public Const MSG_E41015 As String = "部品進度データ受信処理を中断します。"

		Public Const MSG_E41016 As String = "部品進度データ書き込み処理を中断します。"

		Public Const MSG_E41017 As String = "試算表データ受信処理を中断します。"

		Public Const MSG_E41018 As String = "試算表データ書き込み処理を中断します。"

		Public Const MSG_N42000 As String = "月次処理を実行します。よろしいですか？"

		Public Const MSG_N42001 As String = "月次処理が完了しました。"

		Public Const MSG_N42002 As String = "月次処理をキャンセルしました。"

		Public Const MSG_W42001 As String = "月次処理の可能な月ではありません。"

		Public Const MSG_W42002 As String = "パスワードを入力してください。"

		Public Const MSG_W42003 As String = "パスワードが違います。"

		Public Const MSG_E42001 As String = "月次処理を中断しました。"

		Public Const MSG_E42002 As String = "月次更新情報を取得に失敗しました。"

		Public Const MSG_E42003 As String = "受払実績情報の更新に失敗しました。"

		Public Const MSG_E42004 As String = "受払実績情報の更新中に異常が発生しました。"

		Public Const MSG_E42005 As String = "日付テーブルの年月更新に失敗しました。"

		Public Const MSG_N44000 As String = "年次処理を実行します。よろしいですか？"

		Public Const MSG_N44001 As String = "年次処理が完了しました。"

		Public Const MSG_N44002 As String = "年次処理をキャンセルしました。"

		Public Const MSG_W44001 As String = "年次処理の可能な月ではありません。"

		Public Const MSG_W44002 As String = "パスワードを入力してください。"

		Public Const MSG_W44003 As String = "パスワードが違います。"

		Public Const MSG_E44001 As String = "年次処理を中断しました。"

		Public Const MSG_E44002 As String = "年次更新情報を取得に失敗しました。"

		Public Const MSG_E44003 As String = "受払実績情報の更新中に異常が発生しました。"

		Public Const MSG_N45001 As String = "払出データ書き込み処理が完了しました。"

		Public Const MSG_W45001 As String = "払出データ書き込みに必要な項目が有りません。" & vbCrLf & "入力ファイルのフォーマットに誤りが有ります。"

		Public Const MSG_W45002 As String = "取込み可能なデータ行が存在しません。" & vbCrLf & "入力ファイルを確認してください。"

		Public Const MSG_E45001 As String = "払出データ書き込み処理を中断します。"

		Public Const MSG_E45002 As String = "OKファイルの出力に失敗しました。"

		Public Const MSG_E45003 As String = "ERRファイルの出力に失敗しました。"

		Public Const MSG_N50001 As String = "CSVファイルを出力します。よろしいですか？"

		Public Const MSG_N50002 As String = "CSV出力が完了しました。"

		Public Const MSG_W50001 As String = "該当データがありませんでした。"

		Public Const MSG_W50002 As String = "取引先コードを選択してださい。"

		Public Const MSG_E50001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_E50002 As String = "別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。"

		Public Const MSG_N51001 As String = "CSVファイルを出力します。よろしいですか？"

		Public Const MSG_N51002 As String = "CSV出力が完了しました。"

		Public Const MSG_W51001 As String = "該当データがありませんでした。"

		Public Const MSG_W51002 As String = "取引先コードを選択してださい。"

		Public Const MSG_E51001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_E51002 As String = "別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。"

		Public Const MSG_N52001 As String = "CSVファイルを出力します。よろしいですか？"

		Public Const MSG_N52002 As String = "CSV出力が完了しました。"

		Public Const MSG_W52001 As String = "該当データがありませんでした。"

		Public Const MSG_W52002 As String = "取引先コードを選択してださい。"

		Public Const MSG_E52001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_E52002 As String = "別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。"

		Public Const MSG_N53001 As String = "CSVファイルを出力します。よろしいですか？"

		Public Const MSG_N53002 As String = "CSV出力が完了しました。"

		Public Const MSG_W53001 As String = "該当データがありませんでした。"

		Public Const MSG_W53002 As String = "取引先コードを選択してださい。"

		Public Const MSG_W53003 As String = "取引先が１つも選択されていません。"

		Public Const MSG_E53001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_E53002 As String = "別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。" & vbCrLf & vbCrLf & "[ファイル名]" & vbCrLf & "{0}"

		Public Const MSG_W5x001 As String = "指定年を指定してください。"

		Public Const MSG_W5x002 As String = "指定年月を指定してください。"

		Public Const MSG_W5x003 As String = "指定年月日を指定してください。"

		Public Const MSG_N54001 As String = "CSVファイルを出力します。よろしいですか？"

		Public Const MSG_N54002 As String = "CSV出力が完了しました。"

		Public Const MSG_W54001 As String = "該当データがありませんでした。"

		Public Const MSG_W54002 As String = "取引先コードを選択してださい。"

		Public Const MSG_E54001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_E54002 As String = "別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。" & vbCrLf & vbCrLf & "[ファイル名]" & vbCrLf & "{0}"

		Public Const MSG_N55001 As String = "CSVファイルを出力します。よろしいですか？"

		Public Const MSG_N55002 As String = "CSV出力が完了しました。"

		Public Const MSG_W55001 As String = "該当データがありませんでした。"

		Public Const MSG_W55002 As String = "取引先コードを選択してださい。"

		Public Const MSG_E55001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_E55002 As String = "別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。" & vbCrLf & vbCrLf & "[ファイル名]" & vbCrLf & "{0}"

		Public Const MSG_N56001 As String = "CSVファイルを出力します。よろしいですか？"

		Public Const MSG_N56002 As String = "CSV出力が完了しました。"

		Public Const MSG_E56001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_E56002 As String = "別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。"

		Public Const MSG_N57001 As String = "CSVファイルを出力します。よろしいですか？"

		Public Const MSG_N57002 As String = "CSV出力が完了しました。"

		Public Const MSG_W57001 As String = "該当データがありませんでした。"

		Public Const MSG_W57002 As String = "取引先コードを選択してださい。"

		Public Const MSG_E57001 As String = "CSV出力を中断しました。"

		Public Const MSG_E57002 As String = "CSV出力フォルダが存在しません。"

		Public Const MSG_E57003 As String = "注残ファイルを読み込むことができません。" & vbCrLf & "または、有効なデータが存在しません。"

		Public Const MSG_E57004 As String = "CSVファイルの出力に失敗しました。" & vbCrLf & "[ファイル名]" & vbCrLf & "{0}"

		Public Const MSG_E57005 As String = "CSV出力できませんでした。"

		Public Const MSG_N58001 As String = "CSVファイルを出力します。よろしいですか？"

		Public Const MSG_N58002 As String = "CSV出力が完了しました。"

		Public Const MSG_W58001 As String = "取引先コードを選択してださい。"

		Public Const MSG_W58002 As String = "該当データがありませんでした。"

		Public Const MSG_E58001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_E58002 As String = "別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。"

		Public Const MSG_N59001 As String = "CSVファイルを出力します。よろしいですか？"

		Public Const MSG_N59002 As String = "CSV出力が完了しました。"

		Public Const MSG_E59001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_E59002 As String = "別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。"

		Public Const MSG_N61001 As String = "CSVファイルを出力します。よろしいですか？"

		Public Const MSG_N61002 As String = "CSV出力が完了しました。"

		Public Const MSG_W61001 As String = "該当データがありませんでした。"

		Public Const MSG_W61002 As String = "取引先コードを選択してださい。"

		Public Const MSG_W61003 As String = "指定年月を指定してください。"

		Public Const MSG_E61001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_E61002 As String = "別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。" & vbCrLf & vbCrLf & "[ファイル名]" & vbCrLf & "{0}"

		Public Const MSG_N62001 As String = "印刷が完了しました。"

		Public Const MSG_N62002 As String = "{0}を印刷します。よろしいですか？"

		Public Const MSG_W62001 As String = "取引先コードを選択してださい。"

		Public Const MSG_E62001 As String = "データベースに接続できない、またはテーブル構成が不正です。"

		Public Const MSG_E62002 As String = "該当する請求書データが存在しません。"

		Public Const MSG_E62003 As String = "該当する請求書明細データが存在しません。"

		Public Const MSG_E62004 As String = "印刷領域を確保できませんでした。"

		Public Const MSG_E62005 As String = "標準プリンターが見つかりませんでした。"
	End Class
End Namespace
