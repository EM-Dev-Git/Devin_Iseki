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

	<XmlSchemaProvider("GetTypedDataSetSchema")>
	<HelpKeyword("vs.data.DataSet")>
	<XmlRoot("OutPutZissekiTableFormDataSet")>
	<ToolboxItem(True)>
	<DesignerCategory("code")>
	<Serializable()>
	Public Class OutPutZissekiTableFormDataSet
		Inherits DataSet

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Sub New()
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.BeginInit()
			Me.InitClass()
			Dim value As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
			AddHandler MyBase.Tables.CollectionChanged, value
			AddHandler MyBase.Relations.CollectionChanged, value
			Me.EndInit()
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
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
				If dataSet.Tables("HEADER") IsNot Nothing Then
					MyBase.Tables.Add(New OutPutZissekiTableFormDataSet.HEADERDataTable(dataSet.Tables("HEADER")))
				End If
				If dataSet.Tables("BODY") IsNot Nothing Then
					MyBase.Tables.Add(New OutPutZissekiTableFormDataSet.BODYDataTable(dataSet.Tables("BODY")))
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

		<DebuggerNonUserCode()>
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public ReadOnly Property HEADER As OutPutZissekiTableFormDataSet.HEADERDataTable
			Get
				Return Me.tableHEADER
			End Get
		End Property

		<Browsable(False)>
		<DebuggerNonUserCode()>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public ReadOnly Property BODY As OutPutZissekiTableFormDataSet.BODYDataTable
			Get
				Return Me.tableBODY
			End Get
		End Property

		<Browsable(True)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
		Public Overrides Property SchemaSerializationMode As SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(value As SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Overloads ReadOnly Property Tables As DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<DebuggerNonUserCode()>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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
			Dim outPutZissekiTableFormDataSet As OutPutZissekiTableFormDataSet = CType(MyBase.Clone(), OutPutZissekiTableFormDataSet)
			outPutZissekiTableFormDataSet.InitVars()
			outPutZissekiTableFormDataSet.SchemaSerializationMode = Me.SchemaSerializationMode
			Return outPutZissekiTableFormDataSet
		End Function

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
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
				If dataSet.Tables("HEADER") IsNot Nothing Then
					MyBase.Tables.Add(New OutPutZissekiTableFormDataSet.HEADERDataTable(dataSet.Tables("HEADER")))
				End If
				If dataSet.Tables("BODY") IsNot Nothing Then
					MyBase.Tables.Add(New OutPutZissekiTableFormDataSet.BODYDataTable(dataSet.Tables("BODY")))
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

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Friend Sub InitVars(initTable As Boolean)
			Me.tableHEADER = CType(MyBase.Tables("HEADER"), OutPutZissekiTableFormDataSet.HEADERDataTable)
			If initTable AndAlso Me.tableHEADER IsNot Nothing Then
				Me.tableHEADER.InitVars()
			End If
			Me.tableBODY = CType(MyBase.Tables("BODY"), OutPutZissekiTableFormDataSet.BODYDataTable)
			If initTable AndAlso Me.tableBODY IsNot Nothing Then
				Me.tableBODY.InitVars()
			End If
		End Sub

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Sub InitClass()
			Me.DataSetName = "OutPutZissekiTableFormDataSet"
			Me.Prefix = ""
			Me.[Namespace] = "http://tempuri.org/OutPutZissekiTableFormDataSet.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.tableHEADER = New OutPutZissekiTableFormDataSet.HEADERDataTable()
			MyBase.Tables.Add(Me.tableHEADER)
			Me.tableBODY = New OutPutZissekiTableFormDataSet.BODYDataTable()
			MyBase.Tables.Add(Me.tableBODY)
		End Sub

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Function ShouldSerializeHEADER() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Private Function ShouldSerializeBODY() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Sub SchemaChanged(sender As Object, e As CollectionChangeEventArgs)
			If e.Action = CollectionChangeAction.Remove Then
				Me.InitVars()
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Public Shared Function GetTypedDataSetSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
			Dim outPutZissekiTableFormDataSet As OutPutZissekiTableFormDataSet = New OutPutZissekiTableFormDataSet()
			Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
			Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
			Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
			xmlSchemaAny.[Namespace] = outPutZissekiTableFormDataSet.[Namespace]
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType.Particle = xmlSchemaSequence
			Dim schemaSerializable As XmlSchema = outPutZissekiTableFormDataSet.GetSchemaSerializable()
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

		Private tableHEADER As OutPutZissekiTableFormDataSet.HEADERDataTable

		Private tableBODY As OutPutZissekiTableFormDataSet.BODYDataTable

		Private _schemaSerializationMode As SchemaSerializationMode

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub HEADERRowChangeEventHandler(sender As Object, e As OutPutZissekiTableFormDataSet.HEADERRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub BODYRowChangeEventHandler(sender As Object, e As OutPutZissekiTableFormDataSet.BODYRowChangeEvent)

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class HEADERDataTable
			Inherits TypedTableBase(Of OutPutZissekiTableFormDataSet.HEADERRow)

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub New()
				Me.TableName = "HEADER"
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
			Public ReadOnly Property 会社名Column As DataColumn
				Get
					Return Me.column会社名
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property 部署Column As DataColumn
				Get
					Return Me.column部署
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property 地区Column As DataColumn
				Get
					Return Me.column地区
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property 出力年月_開始日Column As DataColumn
				Get
					Return Me.column出力年月_開始日
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property 出力年月_終了日Column As DataColumn
				Get
					Return Me.column出力年月_終了日
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
			Default Public ReadOnly Property Item(index As Integer) As OutPutZissekiTableFormDataSet.HEADERRow
				Get
					Return CType(Me.Rows(index), OutPutZissekiTableFormDataSet.HEADERRow)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event HEADERRowChanging As OutPutZissekiTableFormDataSet.HEADERRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event HEADERRowChanged As OutPutZissekiTableFormDataSet.HEADERRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event HEADERRowDeleting As OutPutZissekiTableFormDataSet.HEADERRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event HEADERRowDeleted As OutPutZissekiTableFormDataSet.HEADERRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub AddHEADERRow(row As OutPutZissekiTableFormDataSet.HEADERRow)
				Me.Rows.Add(row)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function AddHEADERRow(会社名 As String, 部署 As String, 地区 As String, 出力年月_開始日 As String, 出力年月_終了日 As String) As OutPutZissekiTableFormDataSet.HEADERRow
				Dim headerrow As OutPutZissekiTableFormDataSet.HEADERRow = CType(Me.NewRow(), OutPutZissekiTableFormDataSet.HEADERRow)
				Dim itemArray As Object() = New Object() {会社名, 部署, 地区, 出力年月_開始日, 出力年月_終了日}
				headerrow.ItemArray = itemArray
				Me.Rows.Add(headerrow)
				Return headerrow
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim headerdataTable As OutPutZissekiTableFormDataSet.HEADERDataTable = CType(MyBase.Clone(), OutPutZissekiTableFormDataSet.HEADERDataTable)
				headerdataTable.InitVars()
				Return headerdataTable
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New OutPutZissekiTableFormDataSet.HEADERDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.column会社名 = MyBase.Columns("会社名")
				Me.column部署 = MyBase.Columns("部署")
				Me.column地区 = MyBase.Columns("地区")
				Me.column出力年月_開始日 = MyBase.Columns("出力年月_開始日")
				Me.column出力年月_終了日 = MyBase.Columns("出力年月_終了日")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.column会社名 = New DataColumn("会社名", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.column会社名)
				Me.column部署 = New DataColumn("部署", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.column部署)
				Me.column地区 = New DataColumn("地区", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.column地区)
				Me.column出力年月_開始日 = New DataColumn("出力年月_開始日", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.column出力年月_開始日)
				Me.column出力年月_終了日 = New DataColumn("出力年月_終了日", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.column出力年月_終了日)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function NewHEADERRow() As OutPutZissekiTableFormDataSet.HEADERRow
				Return CType(Me.NewRow(), OutPutZissekiTableFormDataSet.HEADERRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New OutPutZissekiTableFormDataSet.HEADERRow(builder)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(OutPutZissekiTableFormDataSet.HEADERRow)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If Me.HEADERRowChangedEvent IsNot Nothing Then
					Dim headerrowChangedEvent As OutPutZissekiTableFormDataSet.HEADERRowChangeEventHandler = Me.HEADERRowChangedEvent
					If headerrowChangedEvent IsNot Nothing Then
						headerrowChangedEvent(Me, New OutPutZissekiTableFormDataSet.HEADERRowChangeEvent(CType(e.Row, OutPutZissekiTableFormDataSet.HEADERRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If Me.HEADERRowChangingEvent IsNot Nothing Then
					Dim headerrowChangingEvent As OutPutZissekiTableFormDataSet.HEADERRowChangeEventHandler = Me.HEADERRowChangingEvent
					If headerrowChangingEvent IsNot Nothing Then
						headerrowChangingEvent(Me, New OutPutZissekiTableFormDataSet.HEADERRowChangeEvent(CType(e.Row, OutPutZissekiTableFormDataSet.HEADERRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If Me.HEADERRowDeletedEvent IsNot Nothing Then
					Dim headerrowDeletedEvent As OutPutZissekiTableFormDataSet.HEADERRowChangeEventHandler = Me.HEADERRowDeletedEvent
					If headerrowDeletedEvent IsNot Nothing Then
						headerrowDeletedEvent(Me, New OutPutZissekiTableFormDataSet.HEADERRowChangeEvent(CType(e.Row, OutPutZissekiTableFormDataSet.HEADERRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If Me.HEADERRowDeletingEvent IsNot Nothing Then
					Dim headerrowDeletingEvent As OutPutZissekiTableFormDataSet.HEADERRowChangeEventHandler = Me.HEADERRowDeletingEvent
					If headerrowDeletingEvent IsNot Nothing Then
						headerrowDeletingEvent(Me, New OutPutZissekiTableFormDataSet.HEADERRowChangeEvent(CType(e.Row, OutPutZissekiTableFormDataSet.HEADERRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub RemoveHEADERRow(row As OutPutZissekiTableFormDataSet.HEADERRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim outPutZissekiTableFormDataSet As OutPutZissekiTableFormDataSet = New OutPutZissekiTableFormDataSet()
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
				xmlSchemaAttribute.FixedValue = outPutZissekiTableFormDataSet.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "HEADERDataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = outPutZissekiTableFormDataSet.GetSchemaSerializable()
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

			Private column会社名 As DataColumn

			Private column部署 As DataColumn

			Private column地区 As DataColumn

			Private column出力年月_開始日 As DataColumn

			Private column出力年月_終了日 As DataColumn
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class BODYDataTable
			Inherits TypedTableBase(Of OutPutZissekiTableFormDataSet.BODYRow)

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub New()
				Me.TableName = "BODY"
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

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property 請求先Column As DataColumn
				Get
					Return Me.column請求先
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property 請求形態Column As DataColumn
				Get
					Return Me.column請求形態
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property 請求内訳Column As DataColumn
				Get
					Return Me.column請求内訳
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property 率Column As DataColumn
				Get
					Return Me.column率
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property 検収額Column As DataColumn
				Get
					Return Me.column検収額
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property 請求金額Column As DataColumn
				Get
					Return Me.column請求金額
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<Browsable(False)>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Default Public ReadOnly Property Item(index As Integer) As OutPutZissekiTableFormDataSet.BODYRow
				Get
					Return CType(Me.Rows(index), OutPutZissekiTableFormDataSet.BODYRow)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event BODYRowChanging As OutPutZissekiTableFormDataSet.BODYRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event BODYRowChanged As OutPutZissekiTableFormDataSet.BODYRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event BODYRowDeleting As OutPutZissekiTableFormDataSet.BODYRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event BODYRowDeleted As OutPutZissekiTableFormDataSet.BODYRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub AddBODYRow(row As OutPutZissekiTableFormDataSet.BODYRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function AddBODYRow(請求先 As String, 請求形態 As String, 請求内訳 As String, 率 As String, 検収額 As String, 請求金額 As String) As OutPutZissekiTableFormDataSet.BODYRow
				Dim bodyrow As OutPutZissekiTableFormDataSet.BODYRow = CType(Me.NewRow(), OutPutZissekiTableFormDataSet.BODYRow)
				Dim itemArray As Object() = New Object() {請求先, 請求形態, 請求内訳, 率, 検収額, 請求金額}
				bodyrow.ItemArray = itemArray
				Me.Rows.Add(bodyrow)
				Return bodyrow
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim bodydataTable As OutPutZissekiTableFormDataSet.BODYDataTable = CType(MyBase.Clone(), OutPutZissekiTableFormDataSet.BODYDataTable)
				bodydataTable.InitVars()
				Return bodydataTable
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New OutPutZissekiTableFormDataSet.BODYDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.column請求先 = MyBase.Columns("請求先")
				Me.column請求形態 = MyBase.Columns("請求形態")
				Me.column請求内訳 = MyBase.Columns("請求内訳")
				Me.column率 = MyBase.Columns("率")
				Me.column検収額 = MyBase.Columns("検収額")
				Me.column請求金額 = MyBase.Columns("請求金額")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.column請求先 = New DataColumn("請求先", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.column請求先)
				Me.column請求形態 = New DataColumn("請求形態", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.column請求形態)
				Me.column請求内訳 = New DataColumn("請求内訳", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.column請求内訳)
				Me.column率 = New DataColumn("率", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.column率)
				Me.column検収額 = New DataColumn("検収額", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.column検収額)
				Me.column請求金額 = New DataColumn("請求金額", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.column請求金額)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function NewBODYRow() As OutPutZissekiTableFormDataSet.BODYRow
				Return CType(Me.NewRow(), OutPutZissekiTableFormDataSet.BODYRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New OutPutZissekiTableFormDataSet.BODYRow(builder)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(OutPutZissekiTableFormDataSet.BODYRow)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If Me.BODYRowChangedEvent IsNot Nothing Then
					Dim bodyrowChangedEvent As OutPutZissekiTableFormDataSet.BODYRowChangeEventHandler = Me.BODYRowChangedEvent
					If bodyrowChangedEvent IsNot Nothing Then
						bodyrowChangedEvent(Me, New OutPutZissekiTableFormDataSet.BODYRowChangeEvent(CType(e.Row, OutPutZissekiTableFormDataSet.BODYRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If Me.BODYRowChangingEvent IsNot Nothing Then
					Dim bodyrowChangingEvent As OutPutZissekiTableFormDataSet.BODYRowChangeEventHandler = Me.BODYRowChangingEvent
					If bodyrowChangingEvent IsNot Nothing Then
						bodyrowChangingEvent(Me, New OutPutZissekiTableFormDataSet.BODYRowChangeEvent(CType(e.Row, OutPutZissekiTableFormDataSet.BODYRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If Me.BODYRowDeletedEvent IsNot Nothing Then
					Dim bodyrowDeletedEvent As OutPutZissekiTableFormDataSet.BODYRowChangeEventHandler = Me.BODYRowDeletedEvent
					If bodyrowDeletedEvent IsNot Nothing Then
						bodyrowDeletedEvent(Me, New OutPutZissekiTableFormDataSet.BODYRowChangeEvent(CType(e.Row, OutPutZissekiTableFormDataSet.BODYRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If Me.BODYRowDeletingEvent IsNot Nothing Then
					Dim bodyrowDeletingEvent As OutPutZissekiTableFormDataSet.BODYRowChangeEventHandler = Me.BODYRowDeletingEvent
					If bodyrowDeletingEvent IsNot Nothing Then
						bodyrowDeletingEvent(Me, New OutPutZissekiTableFormDataSet.BODYRowChangeEvent(CType(e.Row, OutPutZissekiTableFormDataSet.BODYRow), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub RemoveBODYRow(row As OutPutZissekiTableFormDataSet.BODYRow)
				Me.Rows.Remove(row)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim outPutZissekiTableFormDataSet As OutPutZissekiTableFormDataSet = New OutPutZissekiTableFormDataSet()
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
				xmlSchemaAttribute.FixedValue = outPutZissekiTableFormDataSet.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "BODYDataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = outPutZissekiTableFormDataSet.GetSchemaSerializable()
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

			Private column請求先 As DataColumn

			Private column請求形態 As DataColumn

			Private column請求内訳 As DataColumn

			Private column率 As DataColumn

			Private column検収額 As DataColumn

			Private column請求金額 As DataColumn
		End Class

		Public Class HEADERRow
			Inherits DataRow

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableHEADER = CType(Me.Table, OutPutZissekiTableFormDataSet.HEADERDataTable)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property 会社名 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableHEADER.会社名Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'HEADER' にある列 '会社名' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableHEADER.会社名Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property 部署 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableHEADER.部署Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'HEADER' にある列 '部署' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableHEADER.部署Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property 地区 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableHEADER.地区Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'HEADER' にある列 '地区' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableHEADER.地区Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property 出力年月_開始日 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableHEADER.出力年月_開始日Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'HEADER' にある列 '出力年月_開始日' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableHEADER.出力年月_開始日Column) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property 出力年月_終了日 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableHEADER.出力年月_終了日Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'HEADER' にある列 '出力年月_終了日' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableHEADER.出力年月_終了日Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function Is会社名Null() As Boolean
				Return Me.IsNull(Me.tableHEADER.会社名Column)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub Set会社名Null()
				Me(Me.tableHEADER.会社名Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function Is部署Null() As Boolean
				Return Me.IsNull(Me.tableHEADER.部署Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub Set部署Null()
				Me(Me.tableHEADER.部署Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function Is地区Null() As Boolean
				Return Me.IsNull(Me.tableHEADER.地区Column)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub Set地区Null()
				Me(Me.tableHEADER.地区Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function Is出力年月_開始日Null() As Boolean
				Return Me.IsNull(Me.tableHEADER.出力年月_開始日Column)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub Set出力年月_開始日Null()
				Me(Me.tableHEADER.出力年月_開始日Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function Is出力年月_終了日Null() As Boolean
				Return Me.IsNull(Me.tableHEADER.出力年月_終了日Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub Set出力年月_終了日Null()
				Me(Me.tableHEADER.出力年月_終了日Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			Private tableHEADER As OutPutZissekiTableFormDataSet.HEADERDataTable
		End Class

		Public Class BODYRow
			Inherits DataRow

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableBODY = CType(Me.Table, OutPutZissekiTableFormDataSet.BODYDataTable)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property 請求先 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableBODY.請求先Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'BODY' にある列 '請求先' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableBODY.請求先Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property 請求形態 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableBODY.請求形態Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'BODY' にある列 '請求形態' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableBODY.請求形態Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property 請求内訳 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableBODY.請求内訳Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'BODY' にある列 '請求内訳' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableBODY.請求内訳Column) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property 率 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableBODY.率Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'BODY' にある列 '率' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableBODY.率Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Property 検収額 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableBODY.検収額Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'BODY' にある列 '検収額' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableBODY.検収額Column) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property 請求金額 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableBODY.請求金額Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("テーブル 'BODY' にある列 '請求金額' の値は DBNull です。", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableBODY.請求金額Column) = value
				End Set
			End Property

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function Is請求先Null() As Boolean
				Return Me.IsNull(Me.tableBODY.請求先Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub Set請求先Null()
				Me(Me.tableBODY.請求先Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function Is請求形態Null() As Boolean
				Return Me.IsNull(Me.tableBODY.請求形態Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub Set請求形態Null()
				Me(Me.tableBODY.請求形態Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function Is請求内訳Null() As Boolean
				Return Me.IsNull(Me.tableBODY.請求内訳Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub Set請求内訳Null()
				Me(Me.tableBODY.請求内訳Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function Is率Null() As Boolean
				Return Me.IsNull(Me.tableBODY.率Column)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub Set率Null()
				Me(Me.tableBODY.率Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function Is検収額Null() As Boolean
				Return Me.IsNull(Me.tableBODY.検収額Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub Set検収額Null()
				Me(Me.tableBODY.検収額Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function Is請求金額Null() As Boolean
				Return Me.IsNull(Me.tableBODY.請求金額Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub Set請求金額Null()
				Me(Me.tableBODY.請求金額Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			Private tableBODY As OutPutZissekiTableFormDataSet.BODYDataTable
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class HEADERRowChangeEvent
			Inherits EventArgs

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub New(row As OutPutZissekiTableFormDataSet.HEADERRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Row As OutPutZissekiTableFormDataSet.HEADERRow
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

			Private eventRow As OutPutZissekiTableFormDataSet.HEADERRow

			Private eventAction As DataRowAction
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class BODYRowChangeEvent
			Inherits EventArgs

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub New(row As OutPutZissekiTableFormDataSet.BODYRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public ReadOnly Property Row As OutPutZissekiTableFormDataSet.BODYRow
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

			Private eventRow As OutPutZissekiTableFormDataSet.BODYRow

			Private eventAction As DataRowAction
		End Class
	End Class
End Namespace
