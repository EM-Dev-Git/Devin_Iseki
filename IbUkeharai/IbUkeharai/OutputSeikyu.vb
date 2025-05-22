Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<XmlRoot("OutputSeikyu")>
	<ToolboxItem(True)>
	<DesignerCategory("code")>
	<XmlSchemaProvider("GetTypedDataSetSchema")>
	<HelpKeyword("vs.data.DataSet")>
	<Serializable()>
	Public Class OutputSeikyu
		Inherits DataSet

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Public Sub New()
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.BeginInit()
			Me.InitClass()
			Dim value As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
			AddHandler MyBase.Tables.CollectionChanged, value
			AddHandler MyBase.Relations.CollectionChanged, value
			Me.EndInit()
		End Sub

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context, False)
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			If Me.IsBinarySerialized(info, context) Then
				Me.InitVars(False)
				Dim value As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
				AddHandler Me.Tables.CollectionChanged, value
				AddHandler Me.Relations.CollectionChanged, value
				Return
			End If
			Dim s As String = Conversions.ToString(info.GetValue("XmlSchema", GetType(String)))
			If Me.DetermineSchemaSerializationMode(info, context) = SchemaSerializationMode.IncludeSchema Then
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXmlSchema(New XmlTextReader(New StringReader(s)))
				If dataSet.Tables("SeikyuTable") IsNot Nothing Then
					MyBase.Tables.Add(New OutputSeikyu.SeikyuTableDataTable(dataSet.Tables("SeikyuTable")))
				End If
				If dataSet.Tables("M_JOSU") IsNot Nothing Then
					MyBase.Tables.Add(New OutputSeikyu.M_JOSUDataTable(dataSet.Tables("M_JOSU")))
				End If
				If dataSet.Tables("UchiwakeTable") IsNot Nothing Then
					MyBase.Tables.Add(New OutputSeikyu.UchiwakeTableDataTable(dataSet.Tables("UchiwakeTable")))
				End If
				Me.DataSetName = dataSet.DataSetName
				Me.Prefix = dataSet.Prefix
				Me.[Namespace] = dataSet.[Namespace]
				Me.Locale = dataSet.Locale
				Me.CaseSensitive = dataSet.CaseSensitive
				Me.EnforceConstraints = dataSet.EnforceConstraints
				Me.Merge(dataSet, False, MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXmlSchema(New XmlTextReader(New StringReader(s)))
			End If
			Me.GetSerializationData(info, context)
			Dim value2 As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
			AddHandler MyBase.Tables.CollectionChanged, value2
			AddHandler Me.Relations.CollectionChanged, value2
		End Sub

		<Browsable(False)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public ReadOnly Property SeikyuTable As OutputSeikyu.SeikyuTableDataTable
			Get
				Return Me.tableSeikyuTable
			End Get
		End Property

		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public ReadOnly Property M_JOSU As OutputSeikyu.M_JOSUDataTable
			Get
				Return Me.tableM_JOSU
			End Get
		End Property

		<Browsable(False)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public ReadOnly Property UchiwakeTable As OutputSeikyu.UchiwakeTableDataTable
			Get
				Return Me.tableUchiwakeTable
			End Get
		End Property

		<Browsable(True)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
		<DebuggerNonUserCode()>
		Public Overrides Property SchemaSerializationMode As SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(value As SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<DebuggerNonUserCode()>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Overloads ReadOnly Property Tables As DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		<DebuggerNonUserCode()>
		Public Overloads ReadOnly Property Relations As DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Protected Overrides Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Public Overrides Function Clone() As DataSet
			Dim outputSeikyu As OutputSeikyu = CType(MyBase.Clone(), OutputSeikyu)
			outputSeikyu.InitVars()
			outputSeikyu.SchemaSerializationMode = Me.SchemaSerializationMode
			Return outputSeikyu
		End Function

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Overrides Sub ReadXmlSerializable(reader As XmlReader)
			If Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema Then
				Me.Reset()
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(reader)
				If dataSet.Tables("SeikyuTable") IsNot Nothing Then
					MyBase.Tables.Add(New OutputSeikyu.SeikyuTableDataTable(dataSet.Tables("SeikyuTable")))
				End If
				If dataSet.Tables("M_JOSU") IsNot Nothing Then
					MyBase.Tables.Add(New OutputSeikyu.M_JOSUDataTable(dataSet.Tables("M_JOSU")))
				End If
				If dataSet.Tables("UchiwakeTable") IsNot Nothing Then
					MyBase.Tables.Add(New OutputSeikyu.UchiwakeTableDataTable(dataSet.Tables("UchiwakeTable")))
				End If
				Me.DataSetName = dataSet.DataSetName
				Me.Prefix = dataSet.Prefix
				Me.[Namespace] = dataSet.[Namespace]
				Me.Locale = dataSet.Locale
				Me.CaseSensitive = dataSet.CaseSensitive
				Me.EnforceConstraints = dataSet.EnforceConstraints
				Me.Merge(dataSet, False, MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXml(reader)
				Me.InitVars()
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Protected Overrides Function GetSchemaSerializable() As XmlSchema
			Dim memoryStream As MemoryStream = New MemoryStream()
			Me.WriteXmlSchema(New XmlTextWriter(memoryStream, Nothing))
			memoryStream.Position = 0L
			Return XmlSchema.Read(New XmlTextReader(memoryStream), Nothing)
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Friend Sub InitVars(initTable As Boolean)
			Me.tableSeikyuTable = CType(MyBase.Tables("SeikyuTable"), OutputSeikyu.SeikyuTableDataTable)
			If initTable AndAlso Me.tableSeikyuTable IsNot Nothing Then
				Me.tableSeikyuTable.InitVars()
			End If
			Me.tableM_JOSU = CType(MyBase.Tables("M_JOSU"), OutputSeikyu.M_JOSUDataTable)
			If initTable AndAlso Me.tableM_JOSU IsNot Nothing Then
				Me.tableM_JOSU.InitVars()
			End If
			Me.tableUchiwakeTable = CType(MyBase.Tables("UchiwakeTable"), OutputSeikyu.UchiwakeTableDataTable)
			If initTable AndAlso Me.tableUchiwakeTable IsNot Nothing Then
				Me.tableUchiwakeTable.InitVars()
			End If
		End Sub

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Sub InitClass()
			Me.DataSetName = "OutputSeikyu"
			Me.Prefix = ""
			Me.[Namespace] = "http://tempuri.org/OutputSeikyu.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.tableSeikyuTable = New OutputSeikyu.SeikyuTableDataTable()
			MyBase.Tables.Add(Me.tableSeikyuTable)
			Me.tableM_JOSU = New OutputSeikyu.M_JOSUDataTable()
			MyBase.Tables.Add(Me.tableM_JOSU)
			Me.tableUchiwakeTable = New OutputSeikyu.UchiwakeTableDataTable()
			MyBase.Tables.Add(Me.tableUchiwakeTable)
		End Sub

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Function ShouldSerializeSeikyuTable() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Private Function ShouldSerializeM_JOSU() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Function ShouldSerializeUchiwakeTable() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Private Sub SchemaChanged(sender As Object, e As CollectionChangeEventArgs)
			If e.Action = CollectionChangeAction.Remove Then
				Me.InitVars()
			End If
		End Sub

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Shared Function GetTypedDataSetSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
			Dim outputSeikyu As OutputSeikyu = New OutputSeikyu()
			Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
			Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
			Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
			xmlSchemaAny.[Namespace] = outputSeikyu.[Namespace]
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType.Particle = xmlSchemaSequence
			Dim schemaSerializable As XmlSchema = outputSeikyu.GetSchemaSerializable()
			If xs.Contains(schemaSerializable.TargetNamespace) Then
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim memoryStream2 As MemoryStream = New MemoryStream()
				Try
					schemaSerializable.Write(memoryStream)
					For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
						Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
						memoryStream2.SetLength(0L)
						xmlSchema.Write(memoryStream2)
						If memoryStream.Length = memoryStream2.Length Then
							memoryStream.Position = 0L
							memoryStream2.Position = 0L
							While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
							End While
							If memoryStream.Position = memoryStream.Length Then
								Return xmlSchemaComplexType
							End If
						End If
					Next
				Finally
					If memoryStream IsNot Nothing Then
						memoryStream.Close()
					End If
					If memoryStream2 IsNot Nothing Then
						memoryStream2.Close()
					End If
				End Try
			End If
			xs.Add(schemaSerializable)
			Return xmlSchemaComplexType
		End Function

		Private tableSeikyuTable As OutputSeikyu.SeikyuTableDataTable

		Private tableM_JOSU As OutputSeikyu.M_JOSUDataTable

		Private tableUchiwakeTable As OutputSeikyu.UchiwakeTableDataTable

		Private _schemaSerializationMode As SchemaSerializationMode

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub SeikyuTableRowChangeEventHandler(sender As Object, e As OutputSeikyu.SeikyuTableRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub M_JOSURowChangeEventHandler(sender As Object, e As OutputSeikyu.M_JOSURowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub UchiwakeTableRowChangeEventHandler(sender As Object, e As OutputSeikyu.UchiwakeTableRowChangeEvent)

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class SeikyuTableDataTable
			Inherits TypedTableBase(Of OutputSeikyu.SeikyuTableRow)

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub New()
				Me.TableName = "SeikyuTable"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				Me.TableName = table.TableName
				If table.CaseSensitive <> table.DataSet.CaseSensitive Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0 Then
					Me.Locale = table.Locale
				End If
				If Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0 Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property TORI_CDColumn As DataColumn
				Get
					Return Me.columnTORI_CD
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property SEIKYU_YYYYMMColumn As DataColumn
				Get
					Return Me.columnSEIKYU_YYYYMM
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property SEIKYU_TYPEColumn As DataColumn
				Get
					Return Me.columnSEIKYU_TYPE
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property SEIKYU_NOColumn As DataColumn
				Get
					Return Me.columnSEIKYU_NO
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property KAZEIColumn As DataColumn
				Get
					Return Me.columnKAZEI
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property HIKAZEIColumn As DataColumn
				Get
					Return Me.columnHIKAZEI
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property SYOHIZEIColumn As DataColumn
				Get
					Return Me.columnSYOHIZEI
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property GOUKEIColumn As DataColumn
				Get
					Return Me.columnGOUKEI
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property SEIKYU_SQNOColumn As DataColumn
				Get
					Return Me.columnSEIKYU_SQNO
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property SAKU_KBNColumn As DataColumn
				Get
					Return Me.columnSAKU_KBN
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property UCHIWAKEColumn As DataColumn
				Get
					Return Me.columnUCHIWAKE
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property SURYOColumn As DataColumn
				Get
					Return Me.columnSURYO
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property TANIColumn As DataColumn
				Get
					Return Me.columnTANI
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property TANKAColumn As DataColumn
				Get
					Return Me.columnTANKA
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property KINGAKUColumn As DataColumn
				Get
					Return Me.columnKINGAKU
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property MEISAI_UMUColumn As DataColumn
				Get
					Return Me.columnMEISAI_UMU
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property SAKI_CDColumn As DataColumn
				Get
					Return Me.columnSAKI_CD
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property TEKIYOColumn As DataColumn
				Get
					Return Me.columnTEKIYO
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property TORI_NAMEColumn As DataColumn
				Get
					Return Me.columnTORI_NAME
				End Get
			End Property

			<DebuggerNonUserCode()>
			<Browsable(False)>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Default Public ReadOnly Property Item(index As Integer) As OutputSeikyu.SeikyuTableRow
				Get
					Return CType(Me.Rows(index), OutputSeikyu.SeikyuTableRow)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event SeikyuTableRowChanging As OutputSeikyu.SeikyuTableRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event SeikyuTableRowChanged As OutputSeikyu.SeikyuTableRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event SeikyuTableRowDeleting As OutputSeikyu.SeikyuTableRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event SeikyuTableRowDeleted As OutputSeikyu.SeikyuTableRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub AddSeikyuTableRow(row As OutputSeikyu.SeikyuTableRow)
				Me.Rows.Add(row)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function AddSeikyuTableRow(TORI_CD As String, SEIKYU_YYYYMM As String, SEIKYU_TYPE As String, SEIKYU_NO As String, KAZEI As String, HIKAZEI As String, SYOHIZEI As String, GOUKEI As String, SEIKYU_SQNO As String, SAKU_KBN As String, UCHIWAKE As String, SURYO As String, TANI As String, TANKA As String, KINGAKU As String, MEISAI_UMU As String, SAKI_CD As String, TEKIYO As String, TORI_NAME As String) As OutputSeikyu.SeikyuTableRow
				Dim seikyuTableRow As OutputSeikyu.SeikyuTableRow = CType(Me.NewRow(), OutputSeikyu.SeikyuTableRow)
				Dim itemArray As Object() = New Object() {TORI_CD, SEIKYU_YYYYMM, SEIKYU_TYPE, SEIKYU_NO, KAZEI, HIKAZEI, SYOHIZEI, GOUKEI, SEIKYU_SQNO, SAKU_KBN, UCHIWAKE, SURYO, TANI, TANKA, KINGAKU, MEISAI_UMU, SAKI_CD, TEKIYO, TORI_NAME}
				seikyuTableRow.ItemArray = itemArray
				Me.Rows.Add(seikyuTableRow)
				Return seikyuTableRow
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim seikyuTableDataTable As OutputSeikyu.SeikyuTableDataTable = CType(MyBase.Clone(), OutputSeikyu.SeikyuTableDataTable)
				seikyuTableDataTable.InitVars()
				Return seikyuTableDataTable
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Function CreateInstance() As DataTable
				Return New OutputSeikyu.SeikyuTableDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnTORI_CD = MyBase.Columns("TORI_CD")
				Me.columnSEIKYU_YYYYMM = MyBase.Columns("SEIKYU_YYYYMM")
				Me.columnSEIKYU_TYPE = MyBase.Columns("SEIKYU_TYPE")
				Me.columnSEIKYU_NO = MyBase.Columns("SEIKYU_NO")
				Me.columnKAZEI = MyBase.Columns("KAZEI")
				Me.columnHIKAZEI = MyBase.Columns("HIKAZEI")
				Me.columnSYOHIZEI = MyBase.Columns("SYOHIZEI")
				Me.columnGOUKEI = MyBase.Columns("GOUKEI")
				Me.columnSEIKYU_SQNO = MyBase.Columns("SEIKYU_SQNO")
				Me.columnSAKU_KBN = MyBase.Columns("SAKU_KBN")
				Me.columnUCHIWAKE = MyBase.Columns("UCHIWAKE")
				Me.columnSURYO = MyBase.Columns("SURYO")
				Me.columnTANI = MyBase.Columns("TANI")
				Me.columnTANKA = MyBase.Columns("TANKA")
				Me.columnKINGAKU = MyBase.Columns("KINGAKU")
				Me.columnMEISAI_UMU = MyBase.Columns("MEISAI_UMU")
				Me.columnSAKI_CD = MyBase.Columns("SAKI_CD")
				Me.columnTEKIYO = MyBase.Columns("TEKIYO")
				Me.columnTORI_NAME = MyBase.Columns("TORI_NAME")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnTORI_CD = New DataColumn("TORI_CD", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTORI_CD)
				Me.columnSEIKYU_YYYYMM = New DataColumn("SEIKYU_YYYYMM", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSEIKYU_YYYYMM)
				Me.columnSEIKYU_TYPE = New DataColumn("SEIKYU_TYPE", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSEIKYU_TYPE)
				Me.columnSEIKYU_NO = New DataColumn("SEIKYU_NO", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSEIKYU_NO)
				Me.columnKAZEI = New DataColumn("KAZEI", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnKAZEI)
				Me.columnHIKAZEI = New DataColumn("HIKAZEI", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnHIKAZEI)
				Me.columnSYOHIZEI = New DataColumn("SYOHIZEI", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSYOHIZEI)
				Me.columnGOUKEI = New DataColumn("GOUKEI", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnGOUKEI)
				Me.columnSEIKYU_SQNO = New DataColumn("SEIKYU_SQNO", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSEIKYU_SQNO)
				Me.columnSAKU_KBN = New DataColumn("SAKU_KBN", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSAKU_KBN)
				Me.columnUCHIWAKE = New DataColumn("UCHIWAKE", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnUCHIWAKE)
				Me.columnSURYO = New DataColumn("SURYO", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSURYO)
				Me.columnTANI = New DataColumn("TANI", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTANI)
				Me.columnTANKA = New DataColumn("TANKA", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTANKA)
				Me.columnKINGAKU = New DataColumn("KINGAKU", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnKINGAKU)
				Me.columnMEISAI_UMU = New DataColumn("MEISAI_UMU", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnMEISAI_UMU)
				Me.columnSAKI_CD = New DataColumn("SAKI_CD", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSAKI_CD)
				Me.columnTEKIYO = New DataColumn("TEKIYO", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTEKIYO)
				Me.columnTORI_NAME = New DataColumn("TORI_NAME", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTORI_NAME)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function NewSeikyuTableRow() As OutputSeikyu.SeikyuTableRow
				Return CType(Me.NewRow(), OutputSeikyu.SeikyuTableRow)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New OutputSeikyu.SeikyuTableRow(builder)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(OutputSeikyu.SeikyuTableRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If Me.SeikyuTableRowChangedEvent IsNot Nothing Then
					Dim seikyuTableRowChangedEvent As OutputSeikyu.SeikyuTableRowChangeEventHandler = Me.SeikyuTableRowChangedEvent
					If seikyuTableRowChangedEvent IsNot Nothing Then
						seikyuTableRowChangedEvent(Me, New OutputSeikyu.SeikyuTableRowChangeEvent(CType(e.Row, OutputSeikyu.SeikyuTableRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If Me.SeikyuTableRowChangingEvent IsNot Nothing Then
					Dim seikyuTableRowChangingEvent As OutputSeikyu.SeikyuTableRowChangeEventHandler = Me.SeikyuTableRowChangingEvent
					If seikyuTableRowChangingEvent IsNot Nothing Then
						seikyuTableRowChangingEvent(Me, New OutputSeikyu.SeikyuTableRowChangeEvent(CType(e.Row, OutputSeikyu.SeikyuTableRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If Me.SeikyuTableRowDeletedEvent IsNot Nothing Then
					Dim seikyuTableRowDeletedEvent As OutputSeikyu.SeikyuTableRowChangeEventHandler = Me.SeikyuTableRowDeletedEvent
					If seikyuTableRowDeletedEvent IsNot Nothing Then
						seikyuTableRowDeletedEvent(Me, New OutputSeikyu.SeikyuTableRowChangeEvent(CType(e.Row, OutputSeikyu.SeikyuTableRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If Me.SeikyuTableRowDeletingEvent IsNot Nothing Then
					Dim seikyuTableRowDeletingEvent As OutputSeikyu.SeikyuTableRowChangeEventHandler = Me.SeikyuTableRowDeletingEvent
					If seikyuTableRowDeletingEvent IsNot Nothing Then
						seikyuTableRowDeletingEvent(Me, New OutputSeikyu.SeikyuTableRowChangeEvent(CType(e.Row, OutputSeikyu.SeikyuTableRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub RemoveSeikyuTableRow(row As OutputSeikyu.SeikyuTableRow)
				Me.Rows.Remove(row)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim outputSeikyu As OutputSeikyu = New OutputSeikyu()
				Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim xmlSchemaParticle As XmlSchemaParticle = xmlSchemaAny
				Dim minOccurs As Decimal = 0D
				xmlSchemaParticle.MinOccurs = minOccurs
				xmlSchemaAny.MaxOccurs = Decimal.MaxValue
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny2 As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim xmlSchemaParticle2 As XmlSchemaParticle = xmlSchemaAny2
				minOccurs = 1D
				xmlSchemaParticle2.MinOccurs = minOccurs
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny2)
				Dim xmlSchemaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute.Name = "namespace"
				xmlSchemaAttribute.FixedValue = outputSeikyu.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "SeikyuTableDataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = outputSeikyu.GetSchemaSerializable()
				If xs.Contains(schemaSerializable.TargetNamespace) Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = New MemoryStream()
					Try
						schemaSerializable.Write(memoryStream)
						For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
							Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
							memoryStream2.SetLength(0L)
							xmlSchema.Write(memoryStream2)
							If memoryStream.Length = memoryStream2.Length Then
								memoryStream.Position = 0L
								memoryStream2.Position = 0L
								While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
								End While
								If memoryStream.Position = memoryStream.Length Then
									Return xmlSchemaComplexType
								End If
							End If
						Next
					Finally
						If memoryStream IsNot Nothing Then
							memoryStream.Close()
						End If
						If memoryStream2 IsNot Nothing Then
							memoryStream2.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				Return xmlSchemaComplexType
			End Function

			Private columnTORI_CD As DataColumn

			Private columnSEIKYU_YYYYMM As DataColumn

			Private columnSEIKYU_TYPE As DataColumn

			Private columnSEIKYU_NO As DataColumn

			Private columnKAZEI As DataColumn

			Private columnHIKAZEI As DataColumn

			Private columnSYOHIZEI As DataColumn

			Private columnGOUKEI As DataColumn

			Private columnSEIKYU_SQNO As DataColumn

			Private columnSAKU_KBN As DataColumn

			Private columnUCHIWAKE As DataColumn

			Private columnSURYO As DataColumn

			Private columnTANI As DataColumn

			Private columnTANKA As DataColumn

			Private columnKINGAKU As DataColumn

			Private columnMEISAI_UMU As DataColumn

			Private columnSAKI_CD As DataColumn

			Private columnTEKIYO As DataColumn

			Private columnTORI_NAME As DataColumn
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class M_JOSUDataTable
			Inherits TypedTableBase(Of OutputSeikyu.M_JOSURow)

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub New()
				Me.TableName = "M_JOSU"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub New(table As DataTable)
				Me.TableName = table.TableName
				If table.CaseSensitive <> table.DataSet.CaseSensitive Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0 Then
					Me.Locale = table.Locale
				End If
				If Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0 Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property JOSU_CDColumn As DataColumn
				Get
					Return Me.columnJOSU_CD
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property KAISYAColumn As DataColumn
				Get
					Return Me.columnKAISYA
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property JIGYOSYOColumn As DataColumn
				Get
					Return Me.columnJIGYOSYO
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property JUSYO1Column As DataColumn
				Get
					Return Me.columnJUSYO1
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property JUSYO2Column As DataColumn
				Get
					Return Me.columnJUSYO2
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property JUSYO3Column As DataColumn
				Get
					Return Me.columnJUSYO3
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property GREETING1Column As DataColumn
				Get
					Return Me.columnGREETING1
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property GREETING2Column As DataColumn
				Get
					Return Me.columnGREETING2
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property KOZA_GUIDANCEColumn As DataColumn
				Get
					Return Me.columnKOZA_GUIDANCE
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property KOZA1Column As DataColumn
				Get
					Return Me.columnKOZA1
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property KOZA2Column As DataColumn
				Get
					Return Me.columnKOZA2
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property CHIKU_NAMEColumn As DataColumn
				Get
					Return Me.columnCHIKU_NAME
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property ZEIRITUColumn As DataColumn
				Get
					Return Me.columnZEIRITU
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property PREFIXColumn As DataColumn
				Get
					Return Me.columnPREFIX
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property SEQNUMColumn As DataColumn
				Get
					Return Me.columnSEQNUM
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<Browsable(False)>
			<DebuggerNonUserCode()>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Default Public ReadOnly Property Item(index As Integer) As OutputSeikyu.M_JOSURow
				Get
					Return CType(Me.Rows(index), OutputSeikyu.M_JOSURow)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event M_JOSURowChanging As OutputSeikyu.M_JOSURowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event M_JOSURowChanged As OutputSeikyu.M_JOSURowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event M_JOSURowDeleting As OutputSeikyu.M_JOSURowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event M_JOSURowDeleted As OutputSeikyu.M_JOSURowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub AddM_JOSURow(row As OutputSeikyu.M_JOSURow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function AddM_JOSURow(JOSU_CD As String, KAISYA As String, JIGYOSYO As String, JUSYO1 As String, JUSYO2 As String, JUSYO3 As String, GREETING1 As String, GREETING2 As String, KOZA_GUIDANCE As String, KOZA1 As String, KOZA2 As String, CHIKU_NAME As String, ZEIRITU As String, PREFIX As String, SEQNUM As String) As OutputSeikyu.M_JOSURow
				Dim m_JOSURow As OutputSeikyu.M_JOSURow = CType(Me.NewRow(), OutputSeikyu.M_JOSURow)
				Dim itemArray As Object() = New Object() {JOSU_CD, KAISYA, JIGYOSYO, JUSYO1, JUSYO2, JUSYO3, GREETING1, GREETING2, KOZA_GUIDANCE, KOZA1, KOZA2, CHIKU_NAME, ZEIRITU, PREFIX, SEQNUM}
				m_JOSURow.ItemArray = itemArray
				Me.Rows.Add(m_JOSURow)
				Return m_JOSURow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Overrides Function Clone() As DataTable
				Dim m_JOSUDataTable As OutputSeikyu.M_JOSUDataTable = CType(MyBase.Clone(), OutputSeikyu.M_JOSUDataTable)
				m_JOSUDataTable.InitVars()
				Return m_JOSUDataTable
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Function CreateInstance() As DataTable
				Return New OutputSeikyu.M_JOSUDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnJOSU_CD = MyBase.Columns("JOSU_CD")
				Me.columnKAISYA = MyBase.Columns("KAISYA")
				Me.columnJIGYOSYO = MyBase.Columns("JIGYOSYO")
				Me.columnJUSYO1 = MyBase.Columns("JUSYO1")
				Me.columnJUSYO2 = MyBase.Columns("JUSYO2")
				Me.columnJUSYO3 = MyBase.Columns("JUSYO3")
				Me.columnGREETING1 = MyBase.Columns("GREETING1")
				Me.columnGREETING2 = MyBase.Columns("GREETING2")
				Me.columnKOZA_GUIDANCE = MyBase.Columns("KOZA_GUIDANCE")
				Me.columnKOZA1 = MyBase.Columns("KOZA1")
				Me.columnKOZA2 = MyBase.Columns("KOZA2")
				Me.columnCHIKU_NAME = MyBase.Columns("CHIKU_NAME")
				Me.columnZEIRITU = MyBase.Columns("ZEIRITU")
				Me.columnPREFIX = MyBase.Columns("PREFIX")
				Me.columnSEQNUM = MyBase.Columns("SEQNUM")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnJOSU_CD = New DataColumn("JOSU_CD", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnJOSU_CD)
				Me.columnKAISYA = New DataColumn("KAISYA", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnKAISYA)
				Me.columnJIGYOSYO = New DataColumn("JIGYOSYO", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnJIGYOSYO)
				Me.columnJUSYO1 = New DataColumn("JUSYO1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnJUSYO1)
				Me.columnJUSYO2 = New DataColumn("JUSYO2", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnJUSYO2)
				Me.columnJUSYO3 = New DataColumn("JUSYO3", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnJUSYO3)
				Me.columnGREETING1 = New DataColumn("GREETING1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnGREETING1)
				Me.columnGREETING2 = New DataColumn("GREETING2", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnGREETING2)
				Me.columnKOZA_GUIDANCE = New DataColumn("KOZA_GUIDANCE", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnKOZA_GUIDANCE)
				Me.columnKOZA1 = New DataColumn("KOZA1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnKOZA1)
				Me.columnKOZA2 = New DataColumn("KOZA2", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnKOZA2)
				Me.columnCHIKU_NAME = New DataColumn("CHIKU_NAME", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnCHIKU_NAME)
				Me.columnZEIRITU = New DataColumn("ZEIRITU", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnZEIRITU)
				Me.columnPREFIX = New DataColumn("PREFIX", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPREFIX)
				Me.columnSEQNUM = New DataColumn("SEQNUM", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSEQNUM)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function NewM_JOSURow() As OutputSeikyu.M_JOSURow
				Return CType(Me.NewRow(), OutputSeikyu.M_JOSURow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New OutputSeikyu.M_JOSURow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Function GetRowType() As Type
				Return GetType(OutputSeikyu.M_JOSURow)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If Me.M_JOSURowChangedEvent IsNot Nothing Then
					Dim m_JOSURowChangedEvent As OutputSeikyu.M_JOSURowChangeEventHandler = Me.M_JOSURowChangedEvent
					If m_JOSURowChangedEvent IsNot Nothing Then
						m_JOSURowChangedEvent(Me, New OutputSeikyu.M_JOSURowChangeEvent(CType(e.Row, OutputSeikyu.M_JOSURow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If Me.M_JOSURowChangingEvent IsNot Nothing Then
					Dim m_JOSURowChangingEvent As OutputSeikyu.M_JOSURowChangeEventHandler = Me.M_JOSURowChangingEvent
					If m_JOSURowChangingEvent IsNot Nothing Then
						m_JOSURowChangingEvent(Me, New OutputSeikyu.M_JOSURowChangeEvent(CType(e.Row, OutputSeikyu.M_JOSURow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If Me.M_JOSURowDeletedEvent IsNot Nothing Then
					Dim m_JOSURowDeletedEvent As OutputSeikyu.M_JOSURowChangeEventHandler = Me.M_JOSURowDeletedEvent
					If m_JOSURowDeletedEvent IsNot Nothing Then
						m_JOSURowDeletedEvent(Me, New OutputSeikyu.M_JOSURowChangeEvent(CType(e.Row, OutputSeikyu.M_JOSURow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If Me.M_JOSURowDeletingEvent IsNot Nothing Then
					Dim m_JOSURowDeletingEvent As OutputSeikyu.M_JOSURowChangeEventHandler = Me.M_JOSURowDeletingEvent
					If m_JOSURowDeletingEvent IsNot Nothing Then
						m_JOSURowDeletingEvent(Me, New OutputSeikyu.M_JOSURowChangeEvent(CType(e.Row, OutputSeikyu.M_JOSURow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub RemoveM_JOSURow(row As OutputSeikyu.M_JOSURow)
				Me.Rows.Remove(row)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim outputSeikyu As OutputSeikyu = New OutputSeikyu()
				Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim xmlSchemaParticle As XmlSchemaParticle = xmlSchemaAny
				Dim minOccurs As Decimal = 0D
				xmlSchemaParticle.MinOccurs = minOccurs
				xmlSchemaAny.MaxOccurs = Decimal.MaxValue
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny2 As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim xmlSchemaParticle2 As XmlSchemaParticle = xmlSchemaAny2
				minOccurs = 1D
				xmlSchemaParticle2.MinOccurs = minOccurs
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny2)
				Dim xmlSchemaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute.Name = "namespace"
				xmlSchemaAttribute.FixedValue = outputSeikyu.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "M_JOSUDataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = outputSeikyu.GetSchemaSerializable()
				If xs.Contains(schemaSerializable.TargetNamespace) Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = New MemoryStream()
					Try
						schemaSerializable.Write(memoryStream)
						For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
							Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
							memoryStream2.SetLength(0L)
							xmlSchema.Write(memoryStream2)
							If memoryStream.Length = memoryStream2.Length Then
								memoryStream.Position = 0L
								memoryStream2.Position = 0L
								While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
								End While
								If memoryStream.Position = memoryStream.Length Then
									Return xmlSchemaComplexType
								End If
							End If
						Next
					Finally
						If memoryStream IsNot Nothing Then
							memoryStream.Close()
						End If
						If memoryStream2 IsNot Nothing Then
							memoryStream2.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				Return xmlSchemaComplexType
			End Function

			Private columnJOSU_CD As DataColumn

			Private columnKAISYA As DataColumn

			Private columnJIGYOSYO As DataColumn

			Private columnJUSYO1 As DataColumn

			Private columnJUSYO2 As DataColumn

			Private columnJUSYO3 As DataColumn

			Private columnGREETING1 As DataColumn

			Private columnGREETING2 As DataColumn

			Private columnKOZA_GUIDANCE As DataColumn

			Private columnKOZA1 As DataColumn

			Private columnKOZA2 As DataColumn

			Private columnCHIKU_NAME As DataColumn

			Private columnZEIRITU As DataColumn

			Private columnPREFIX As DataColumn

			Private columnSEQNUM As DataColumn
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class UchiwakeTableDataTable
			Inherits TypedTableBase(Of OutputSeikyu.UchiwakeTableRow)

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub New()
				Me.TableName = "UchiwakeTable"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				Me.TableName = table.TableName
				If table.CaseSensitive <> table.DataSet.CaseSensitive Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0 Then
					Me.Locale = table.Locale
				End If
				If Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0 Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property ROWCNTColumn As DataColumn
				Get
					Return Me.columnROWCNT
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property TORI_CDColumn As DataColumn
				Get
					Return Me.columnTORI_CD
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property KINGAKUColumn As DataColumn
				Get
					Return Me.columnKINGAKU
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property TORI_NAMEColumn As DataColumn
				Get
					Return Me.columnTORI_NAME
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property BUHIN_CDColumn As DataColumn
				Get
					Return Me.columnBUHIN_CD
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property SAKI_NAMEColumn As DataColumn
				Get
					Return Me.columnSAKI_NAME
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property BUHIN_NAMEColumn As DataColumn
				Get
					Return Me.columnBUHIN_NAME
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property KOSUColumn As DataColumn
				Get
					Return Me.columnKOSU
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property TESUColumn As DataColumn
				Get
					Return Me.columnTESU
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property REMARKS1Column As DataColumn
				Get
					Return Me.columnREMARKS1
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property REMARKS2Column As DataColumn
				Get
					Return Me.columnREMARKS2
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property REMARKS3Column As DataColumn
				Get
					Return Me.columnREMARKS3
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property UKEHARA_YYYYMMDDColumn As DataColumn
				Get
					Return Me.columnUKEHARA_YYYYMMDD
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DEN_NOColumn As DataColumn
				Get
					Return Me.columnDEN_NO
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property UKEHARAI_KBNColumn As DataColumn
				Get
					Return Me.columnUKEHARAI_KBN
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property SAKI_CDColumn As DataColumn
				Get
					Return Me.columnSAKI_CD
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property SAKI_ABBREVIATIONColumn As DataColumn
				Get
					Return Me.columnSAKI_ABBREVIATION
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property KIKAKUColumn As DataColumn
				Get
					Return Me.columnKIKAKU
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property SEIKYU_NOColumn As DataColumn
				Get
					Return Me.columnSEIKYU_NO
				End Get
			End Property

			<Browsable(False)>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Default Public ReadOnly Property Item(index As Integer) As OutputSeikyu.UchiwakeTableRow
				Get
					Return CType(Me.Rows(index), OutputSeikyu.UchiwakeTableRow)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event UchiwakeTableRowChanging As OutputSeikyu.UchiwakeTableRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event UchiwakeTableRowChanged As OutputSeikyu.UchiwakeTableRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event UchiwakeTableRowDeleting As OutputSeikyu.UchiwakeTableRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event UchiwakeTableRowDeleted As OutputSeikyu.UchiwakeTableRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub AddUchiwakeTableRow(row As OutputSeikyu.UchiwakeTableRow)
				Me.Rows.Add(row)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function AddUchiwakeTableRow(ROWCNT As String, TORI_CD As String, KINGAKU As String, TORI_NAME As String, BUHIN_CD As String, SAKI_NAME As String, BUHIN_NAME As String, KOSU As String, TESU As String, REMARKS1 As String, REMARKS2 As String, REMARKS3 As String, UKEHARA_YYYYMMDD As String, DEN_NO As String, UKEHARAI_KBN As String, SAKI_CD As String, SAKI_ABBREVIATION As String, KIKAKU As String, SEIKYU_NO As String) As OutputSeikyu.UchiwakeTableRow
				Dim uchiwakeTableRow As OutputSeikyu.UchiwakeTableRow = CType(Me.NewRow(), OutputSeikyu.UchiwakeTableRow)
				Dim itemArray As Object() = New Object() {ROWCNT, TORI_CD, KINGAKU, TORI_NAME, BUHIN_CD, SAKI_NAME, BUHIN_NAME, KOSU, TESU, REMARKS1, REMARKS2, REMARKS3, UKEHARA_YYYYMMDD, DEN_NO, UKEHARAI_KBN, SAKI_CD, SAKI_ABBREVIATION, KIKAKU, SEIKYU_NO}
				uchiwakeTableRow.ItemArray = itemArray
				Me.Rows.Add(uchiwakeTableRow)
				Return uchiwakeTableRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Overrides Function Clone() As DataTable
				Dim uchiwakeTableDataTable As OutputSeikyu.UchiwakeTableDataTable = CType(MyBase.Clone(), OutputSeikyu.UchiwakeTableDataTable)
				uchiwakeTableDataTable.InitVars()
				Return uchiwakeTableDataTable
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New OutputSeikyu.UchiwakeTableDataTable()
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub InitVars()
				Me.columnROWCNT = MyBase.Columns("ROWCNT")
				Me.columnTORI_CD = MyBase.Columns("TORI_CD")
				Me.columnKINGAKU = MyBase.Columns("KINGAKU")
				Me.columnTORI_NAME = MyBase.Columns("TORI_NAME")
				Me.columnBUHIN_CD = MyBase.Columns("BUHIN_CD")
				Me.columnSAKI_NAME = MyBase.Columns("SAKI_NAME")
				Me.columnBUHIN_NAME = MyBase.Columns("BUHIN_NAME")
				Me.columnKOSU = MyBase.Columns("KOSU")
				Me.columnTESU = MyBase.Columns("TESU")
				Me.columnREMARKS1 = MyBase.Columns("REMARKS1")
				Me.columnREMARKS2 = MyBase.Columns("REMARKS2")
				Me.columnREMARKS3 = MyBase.Columns("REMARKS3")
				Me.columnUKEHARA_YYYYMMDD = MyBase.Columns("UKEHARA_YYYYMMDD")
				Me.columnDEN_NO = MyBase.Columns("DEN_NO")
				Me.columnUKEHARAI_KBN = MyBase.Columns("UKEHARAI_KBN")
				Me.columnSAKI_CD = MyBase.Columns("SAKI_CD")
				Me.columnSAKI_ABBREVIATION = MyBase.Columns("SAKI_ABBREVIATION")
				Me.columnKIKAKU = MyBase.Columns("KIKAKU")
				Me.columnSEIKYU_NO = MyBase.Columns("SEIKYU_NO")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnROWCNT = New DataColumn("ROWCNT", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnROWCNT)
				Me.columnTORI_CD = New DataColumn("TORI_CD", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTORI_CD)
				Me.columnKINGAKU = New DataColumn("KINGAKU", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnKINGAKU)
				Me.columnTORI_NAME = New DataColumn("TORI_NAME", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTORI_NAME)
				Me.columnBUHIN_CD = New DataColumn("BUHIN_CD", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBUHIN_CD)
				Me.columnSAKI_NAME = New DataColumn("SAKI_NAME", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSAKI_NAME)
				Me.columnBUHIN_NAME = New DataColumn("BUHIN_NAME", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBUHIN_NAME)
				Me.columnKOSU = New DataColumn("KOSU", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnKOSU)
				Me.columnTESU = New DataColumn("TESU", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTESU)
				Me.columnREMARKS1 = New DataColumn("REMARKS1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnREMARKS1)
				Me.columnREMARKS2 = New DataColumn("REMARKS2", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnREMARKS2)
				Me.columnREMARKS3 = New DataColumn("REMARKS3", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnREMARKS3)
				Me.columnUKEHARA_YYYYMMDD = New DataColumn("UKEHARA_YYYYMMDD", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnUKEHARA_YYYYMMDD)
				Me.columnDEN_NO = New DataColumn("DEN_NO", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDEN_NO)
				Me.columnUKEHARAI_KBN = New DataColumn("UKEHARAI_KBN", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnUKEHARAI_KBN)
				Me.columnSAKI_CD = New DataColumn("SAKI_CD", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSAKI_CD)
				Me.columnSAKI_ABBREVIATION = New DataColumn("SAKI_ABBREVIATION", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSAKI_ABBREVIATION)
				Me.columnKIKAKU = New DataColumn("KIKAKU", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnKIKAKU)
				Me.columnSEIKYU_NO = New DataColumn("SEIKYU_NO", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSEIKYU_NO)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function NewUchiwakeTableRow() As OutputSeikyu.UchiwakeTableRow
				Return CType(Me.NewRow(), OutputSeikyu.UchiwakeTableRow)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New OutputSeikyu.UchiwakeTableRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Function GetRowType() As Type
				Return GetType(OutputSeikyu.UchiwakeTableRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If Me.UchiwakeTableRowChangedEvent IsNot Nothing Then
					Dim uchiwakeTableRowChangedEvent As OutputSeikyu.UchiwakeTableRowChangeEventHandler = Me.UchiwakeTableRowChangedEvent
					If uchiwakeTableRowChangedEvent IsNot Nothing Then
						uchiwakeTableRowChangedEvent(Me, New OutputSeikyu.UchiwakeTableRowChangeEvent(CType(e.Row, OutputSeikyu.UchiwakeTableRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If Me.UchiwakeTableRowChangingEvent IsNot Nothing Then
					Dim uchiwakeTableRowChangingEvent As OutputSeikyu.UchiwakeTableRowChangeEventHandler = Me.UchiwakeTableRowChangingEvent
					If uchiwakeTableRowChangingEvent IsNot Nothing Then
						uchiwakeTableRowChangingEvent(Me, New OutputSeikyu.UchiwakeTableRowChangeEvent(CType(e.Row, OutputSeikyu.UchiwakeTableRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If Me.UchiwakeTableRowDeletedEvent IsNot Nothing Then
					Dim uchiwakeTableRowDeletedEvent As OutputSeikyu.UchiwakeTableRowChangeEventHandler = Me.UchiwakeTableRowDeletedEvent
					If uchiwakeTableRowDeletedEvent IsNot Nothing Then
						uchiwakeTableRowDeletedEvent(Me, New OutputSeikyu.UchiwakeTableRowChangeEvent(CType(e.Row, OutputSeikyu.UchiwakeTableRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If Me.UchiwakeTableRowDeletingEvent IsNot Nothing Then
					Dim uchiwakeTableRowDeletingEvent As OutputSeikyu.UchiwakeTableRowChangeEventHandler = Me.UchiwakeTableRowDeletingEvent
					If uchiwakeTableRowDeletingEvent IsNot Nothing Then
						uchiwakeTableRowDeletingEvent(Me, New OutputSeikyu.UchiwakeTableRowChangeEvent(CType(e.Row, OutputSeikyu.UchiwakeTableRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub RemoveUchiwakeTableRow(row As OutputSeikyu.UchiwakeTableRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim outputSeikyu As OutputSeikyu = New OutputSeikyu()
				Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim xmlSchemaParticle As XmlSchemaParticle = xmlSchemaAny
				Dim minOccurs As Decimal = 0D
				xmlSchemaParticle.MinOccurs = minOccurs
				xmlSchemaAny.MaxOccurs = Decimal.MaxValue
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny2 As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim xmlSchemaParticle2 As XmlSchemaParticle = xmlSchemaAny2
				minOccurs = 1D
				xmlSchemaParticle2.MinOccurs = minOccurs
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny2)
				Dim xmlSchemaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute.Name = "namespace"
				xmlSchemaAttribute.FixedValue = outputSeikyu.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "UchiwakeTableDataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = outputSeikyu.GetSchemaSerializable()
				If xs.Contains(schemaSerializable.TargetNamespace) Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = New MemoryStream()
					Try
						schemaSerializable.Write(memoryStream)
						For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
							Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
							memoryStream2.SetLength(0L)
							xmlSchema.Write(memoryStream2)
							If memoryStream.Length = memoryStream2.Length Then
								memoryStream.Position = 0L
								memoryStream2.Position = 0L
								While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
								End While
								If memoryStream.Position = memoryStream.Length Then
									Return xmlSchemaComplexType
								End If
							End If
						Next
					Finally
						If memoryStream IsNot Nothing Then
							memoryStream.Close()
						End If
						If memoryStream2 IsNot Nothing Then
							memoryStream2.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				Return xmlSchemaComplexType
			End Function

			Private columnROWCNT As DataColumn

			Private columnTORI_CD As DataColumn

			Private columnKINGAKU As DataColumn

			Private columnTORI_NAME As DataColumn

			Private columnBUHIN_CD As DataColumn

			Private columnSAKI_NAME As DataColumn

			Private columnBUHIN_NAME As DataColumn

			Private columnKOSU As DataColumn

			Private columnTESU As DataColumn

			Private columnREMARKS1 As DataColumn

			Private columnREMARKS2 As DataColumn

			Private columnREMARKS3 As DataColumn

			Private columnUKEHARA_YYYYMMDD As DataColumn

			Private columnDEN_NO As DataColumn

			Private columnUKEHARAI_KBN As DataColumn

			Private columnSAKI_CD As DataColumn

			Private columnSAKI_ABBREVIATION As DataColumn

			Private columnKIKAKU As DataColumn

			Private columnSEIKYU_NO As DataColumn
		End Class

		Public Class SeikyuTableRow
			Inherits DataRow

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableSeikyuTable = CType(Me.Table, OutputSeikyu.SeikyuTableDataTable)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property TORI_CD As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.TORI_CDColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'TORI_CD' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.TORI_CDColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property SEIKYU_YYYYMM As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.SEIKYU_YYYYMMColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'SEIKYU_YYYYMM' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.SEIKYU_YYYYMMColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property SEIKYU_TYPE As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.SEIKYU_TYPEColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'SEIKYU_TYPE' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.SEIKYU_TYPEColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property SEIKYU_NO As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.SEIKYU_NOColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'SEIKYU_NO' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.SEIKYU_NOColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property KAZEI As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.KAZEIColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'KAZEI' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.KAZEIColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property HIKAZEI As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.HIKAZEIColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'HIKAZEI' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.HIKAZEIColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property SYOHIZEI As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.SYOHIZEIColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'SYOHIZEI' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.SYOHIZEIColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property GOUKEI As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.GOUKEIColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'GOUKEI' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.GOUKEIColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property SEIKYU_SQNO As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.SEIKYU_SQNOColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'SEIKYU_SQNO' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.SEIKYU_SQNOColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property SAKU_KBN As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.SAKU_KBNColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'SAKU_KBN' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.SAKU_KBNColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property UCHIWAKE As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.UCHIWAKEColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'UCHIWAKE' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.UCHIWAKEColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property SURYO As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.SURYOColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'SURYO' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.SURYOColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property TANI As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.TANIColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'TANI' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.TANIColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property TANKA As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.TANKAColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'TANKA' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.TANKAColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property KINGAKU As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.KINGAKUColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'KINGAKU' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.KINGAKUColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property MEISAI_UMU As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.MEISAI_UMUColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'MEISAI_UMU' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.MEISAI_UMUColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property SAKI_CD As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.SAKI_CDColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'SAKI_CD' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.SAKI_CDColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property TEKIYO As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.TEKIYOColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'TEKIYO' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.TEKIYOColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property TORI_NAME As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableSeikyuTable.TORI_NAMEColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'SeikyuTable' にある列 'TORI_NAME' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableSeikyuTable.TORI_NAMEColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsTORI_CDNull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.TORI_CDColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetTORI_CDNull()
				Me(Me.tableSeikyuTable.TORI_CDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsSEIKYU_YYYYMMNull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.SEIKYU_YYYYMMColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetSEIKYU_YYYYMMNull()
				Me(Me.tableSeikyuTable.SEIKYU_YYYYMMColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsSEIKYU_TYPENull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.SEIKYU_TYPEColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetSEIKYU_TYPENull()
				Me(Me.tableSeikyuTable.SEIKYU_TYPEColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsSEIKYU_NONull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.SEIKYU_NOColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetSEIKYU_NONull()
				Me(Me.tableSeikyuTable.SEIKYU_NOColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsKAZEINull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.KAZEIColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetKAZEINull()
				Me(Me.tableSeikyuTable.KAZEIColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsHIKAZEINull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.HIKAZEIColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetHIKAZEINull()
				Me(Me.tableSeikyuTable.HIKAZEIColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsSYOHIZEINull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.SYOHIZEIColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetSYOHIZEINull()
				Me(Me.tableSeikyuTable.SYOHIZEIColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsGOUKEINull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.GOUKEIColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetGOUKEINull()
				Me(Me.tableSeikyuTable.GOUKEIColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsSEIKYU_SQNONull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.SEIKYU_SQNOColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetSEIKYU_SQNONull()
				Me(Me.tableSeikyuTable.SEIKYU_SQNOColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsSAKU_KBNNull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.SAKU_KBNColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetSAKU_KBNNull()
				Me(Me.tableSeikyuTable.SAKU_KBNColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsUCHIWAKENull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.UCHIWAKEColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetUCHIWAKENull()
				Me(Me.tableSeikyuTable.UCHIWAKEColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsSURYONull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.SURYOColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetSURYONull()
				Me(Me.tableSeikyuTable.SURYOColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsTANINull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.TANIColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetTANINull()
				Me(Me.tableSeikyuTable.TANIColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsTANKANull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.TANKAColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetTANKANull()
				Me(Me.tableSeikyuTable.TANKAColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsKINGAKUNull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.KINGAKUColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetKINGAKUNull()
				Me(Me.tableSeikyuTable.KINGAKUColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsMEISAI_UMUNull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.MEISAI_UMUColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetMEISAI_UMUNull()
				Me(Me.tableSeikyuTable.MEISAI_UMUColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsSAKI_CDNull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.SAKI_CDColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetSAKI_CDNull()
				Me(Me.tableSeikyuTable.SAKI_CDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsTEKIYONull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.TEKIYOColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetTEKIYONull()
				Me(Me.tableSeikyuTable.TEKIYOColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsTORI_NAMENull() As Boolean
				Return Me.IsNull(Me.tableSeikyuTable.TORI_NAMEColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetTORI_NAMENull()
				Me(Me.tableSeikyuTable.TORI_NAMEColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			Private tableSeikyuTable As OutputSeikyu.SeikyuTableDataTable
		End Class

		Public Class M_JOSURow
			Inherits DataRow

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableM_JOSU = CType(Me.Table, OutputSeikyu.M_JOSUDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property JOSU_CD As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.JOSU_CDColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'JOSU_CD' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.JOSU_CDColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property KAISYA As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.KAISYAColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'KAISYA' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.KAISYAColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property JIGYOSYO As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.JIGYOSYOColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'JIGYOSYO' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.JIGYOSYOColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property JUSYO1 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.JUSYO1Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'JUSYO1' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.JUSYO1Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property JUSYO2 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.JUSYO2Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'JUSYO2' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.JUSYO2Column) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property JUSYO3 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.JUSYO3Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'JUSYO3' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.JUSYO3Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property GREETING1 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.GREETING1Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'GREETING1' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.GREETING1Column) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property GREETING2 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.GREETING2Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'GREETING2' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.GREETING2Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property KOZA_GUIDANCE As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.KOZA_GUIDANCEColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'KOZA_GUIDANCE' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.KOZA_GUIDANCEColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property KOZA1 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.KOZA1Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'KOZA1' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.KOZA1Column) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property KOZA2 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.KOZA2Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'KOZA2' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.KOZA2Column) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property CHIKU_NAME As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.CHIKU_NAMEColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'CHIKU_NAME' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.CHIKU_NAMEColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property ZEIRITU As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.ZEIRITUColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'ZEIRITU' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.ZEIRITUColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property PREFIX As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.PREFIXColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'PREFIX' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.PREFIXColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property SEQNUM As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableM_JOSU.SEQNUMColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'M_JOSU' にある列 'SEQNUM' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableM_JOSU.SEQNUMColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsJOSU_CDNull() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.JOSU_CDColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetJOSU_CDNull()
				Me(Me.tableM_JOSU.JOSU_CDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsKAISYANull() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.KAISYAColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetKAISYANull()
				Me(Me.tableM_JOSU.KAISYAColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsJIGYOSYONull() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.JIGYOSYOColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetJIGYOSYONull()
				Me(Me.tableM_JOSU.JIGYOSYOColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsJUSYO1Null() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.JUSYO1Column)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetJUSYO1Null()
				Me(Me.tableM_JOSU.JUSYO1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsJUSYO2Null() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.JUSYO2Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetJUSYO2Null()
				Me(Me.tableM_JOSU.JUSYO2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsJUSYO3Null() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.JUSYO3Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetJUSYO3Null()
				Me(Me.tableM_JOSU.JUSYO3Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsGREETING1Null() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.GREETING1Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetGREETING1Null()
				Me(Me.tableM_JOSU.GREETING1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsGREETING2Null() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.GREETING2Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetGREETING2Null()
				Me(Me.tableM_JOSU.GREETING2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsKOZA_GUIDANCENull() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.KOZA_GUIDANCEColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetKOZA_GUIDANCENull()
				Me(Me.tableM_JOSU.KOZA_GUIDANCEColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsKOZA1Null() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.KOZA1Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetKOZA1Null()
				Me(Me.tableM_JOSU.KOZA1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsKOZA2Null() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.KOZA2Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetKOZA2Null()
				Me(Me.tableM_JOSU.KOZA2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsCHIKU_NAMENull() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.CHIKU_NAMEColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetCHIKU_NAMENull()
				Me(Me.tableM_JOSU.CHIKU_NAMEColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsZEIRITUNull() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.ZEIRITUColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetZEIRITUNull()
				Me(Me.tableM_JOSU.ZEIRITUColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsPREFIXNull() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.PREFIXColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetPREFIXNull()
				Me(Me.tableM_JOSU.PREFIXColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsSEQNUMNull() As Boolean
				Return Me.IsNull(Me.tableM_JOSU.SEQNUMColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetSEQNUMNull()
				Me(Me.tableM_JOSU.SEQNUMColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			Private tableM_JOSU As OutputSeikyu.M_JOSUDataTable
		End Class

		Public Class UchiwakeTableRow
			Inherits DataRow

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableUchiwakeTable = CType(Me.Table, OutputSeikyu.UchiwakeTableDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property ROWCNT As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.ROWCNTColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'ROWCNT' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.ROWCNTColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property TORI_CD As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.TORI_CDColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'TORI_CD' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.TORI_CDColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property KINGAKU As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.KINGAKUColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'KINGAKU' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.KINGAKUColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property TORI_NAME As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.TORI_NAMEColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'TORI_NAME' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.TORI_NAMEColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property BUHIN_CD As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.BUHIN_CDColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'BUHIN_CD' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.BUHIN_CDColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property SAKI_NAME As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.SAKI_NAMEColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'SAKI_NAME' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.SAKI_NAMEColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property BUHIN_NAME As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.BUHIN_NAMEColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'BUHIN_NAME' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.BUHIN_NAMEColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property KOSU As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.KOSUColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'KOSU' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.KOSUColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property TESU As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.TESUColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'TESU' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.TESUColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property REMARKS1 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.REMARKS1Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'REMARKS1' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.REMARKS1Column) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property REMARKS2 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.REMARKS2Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'REMARKS2' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.REMARKS2Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property REMARKS3 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.REMARKS3Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'REMARKS3' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.REMARKS3Column) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property UKEHARA_YYYYMMDD As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.UKEHARA_YYYYMMDDColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'UKEHARA_YYYYMMDD' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.UKEHARA_YYYYMMDDColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property DEN_NO As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.DEN_NOColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'DEN_NO' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.DEN_NOColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property UKEHARAI_KBN As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.UKEHARAI_KBNColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'UKEHARAI_KBN' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.UKEHARAI_KBNColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property SAKI_CD As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.SAKI_CDColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'SAKI_CD' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.SAKI_CDColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property SAKI_ABBREVIATION As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.SAKI_ABBREVIATIONColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'SAKI_ABBREVIATION' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.SAKI_ABBREVIATIONColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property KIKAKU As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.KIKAKUColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'KIKAKU' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.KIKAKUColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property SEIKYU_NO As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableUchiwakeTable.SEIKYU_NOColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'UchiwakeTable' にある列 'SEIKYU_NO' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableUchiwakeTable.SEIKYU_NOColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsROWCNTNull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.ROWCNTColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetROWCNTNull()
				Me(Me.tableUchiwakeTable.ROWCNTColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsTORI_CDNull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.TORI_CDColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetTORI_CDNull()
				Me(Me.tableUchiwakeTable.TORI_CDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsKINGAKUNull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.KINGAKUColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetKINGAKUNull()
				Me(Me.tableUchiwakeTable.KINGAKUColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsTORI_NAMENull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.TORI_NAMEColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetTORI_NAMENull()
				Me(Me.tableUchiwakeTable.TORI_NAMEColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsBUHIN_CDNull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.BUHIN_CDColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetBUHIN_CDNull()
				Me(Me.tableUchiwakeTable.BUHIN_CDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsSAKI_NAMENull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.SAKI_NAMEColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetSAKI_NAMENull()
				Me(Me.tableUchiwakeTable.SAKI_NAMEColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function IsBUHIN_NAMENull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.BUHIN_NAMEColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetBUHIN_NAMENull()
				Me(Me.tableUchiwakeTable.BUHIN_NAMEColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsKOSUNull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.KOSUColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetKOSUNull()
				Me(Me.tableUchiwakeTable.KOSUColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsTESUNull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.TESUColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetTESUNull()
				Me(Me.tableUchiwakeTable.TESUColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsREMARKS1Null() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.REMARKS1Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetREMARKS1Null()
				Me(Me.tableUchiwakeTable.REMARKS1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsREMARKS2Null() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.REMARKS2Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetREMARKS2Null()
				Me(Me.tableUchiwakeTable.REMARKS2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsREMARKS3Null() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.REMARKS3Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetREMARKS3Null()
				Me(Me.tableUchiwakeTable.REMARKS3Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsUKEHARA_YYYYMMDDNull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.UKEHARA_YYYYMMDDColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetUKEHARA_YYYYMMDDNull()
				Me(Me.tableUchiwakeTable.UKEHARA_YYYYMMDDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsDEN_NONull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.DEN_NOColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetDEN_NONull()
				Me(Me.tableUchiwakeTable.DEN_NOColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsUKEHARAI_KBNNull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.UKEHARAI_KBNColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetUKEHARAI_KBNNull()
				Me(Me.tableUchiwakeTable.UKEHARAI_KBNColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsSAKI_CDNull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.SAKI_CDColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetSAKI_CDNull()
				Me(Me.tableUchiwakeTable.SAKI_CDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsSAKI_ABBREVIATIONNull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.SAKI_ABBREVIATIONColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetSAKI_ABBREVIATIONNull()
				Me(Me.tableUchiwakeTable.SAKI_ABBREVIATIONColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsKIKAKUNull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.KIKAKUColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub SetKIKAKUNull()
				Me(Me.tableUchiwakeTable.KIKAKUColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsSEIKYU_NONull() As Boolean
				Return Me.IsNull(Me.tableUchiwakeTable.SEIKYU_NOColumn)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetSEIKYU_NONull()
				Me(Me.tableUchiwakeTable.SEIKYU_NOColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			Private tableUchiwakeTable As OutputSeikyu.UchiwakeTableDataTable
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class SeikyuTableRowChangeEvent
			Inherits EventArgs

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub New(row As OutputSeikyu.SeikyuTableRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property Row As OutputSeikyu.SeikyuTableRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			Private eventRow As OutputSeikyu.SeikyuTableRow

			Private eventAction As DataRowAction
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class M_JOSURowChangeEvent
			Inherits EventArgs

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub New(row As OutputSeikyu.M_JOSURow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Row As OutputSeikyu.M_JOSURow
				Get
					Return Me.eventRow
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			Private eventRow As OutputSeikyu.M_JOSURow

			Private eventAction As DataRowAction
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class UchiwakeTableRowChangeEvent
			Inherits EventArgs

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub New(row As OutputSeikyu.UchiwakeTableRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Row As OutputSeikyu.UchiwakeTableRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			Private eventRow As OutputSeikyu.UchiwakeTableRow

			Private eventAction As DataRowAction
		End Class
	End Class
End Namespace
