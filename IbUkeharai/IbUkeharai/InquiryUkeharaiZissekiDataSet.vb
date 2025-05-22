Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<XmlRoot("InquiryUkeharaiZissekiDataSet")>
	<XmlSchemaProvider("GetTypedDataSetSchema")>
	<ToolboxItem(True)>
	<HelpKeyword("vs.data.DataSet")>
	<DesignerCategory("code")>
	<Serializable()>
	Public Class InquiryUkeharaiZissekiDataSet
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
				If dataSet.Tables("DataTable1") IsNot Nothing Then
					MyBase.Tables.Add(New InquiryUkeharaiZissekiDataSet.DataTable1DataTable(dataSet.Tables("DataTable1")))
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
		Public ReadOnly Property DataTable1 As InquiryUkeharaiZissekiDataSet.DataTable1DataTable
			Get
				Return Me.tableDataTable1
			End Get
		End Property

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
		<Browsable(True)>
		Public Overrides Property SchemaSerializationMode As SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(value As SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Public Overloads ReadOnly Property Tables As DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Public Overloads ReadOnly Property Relations As DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Overrides Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Overrides Function Clone() As DataSet
			Dim inquiryUkeharaiZissekiDataSet As InquiryUkeharaiZissekiDataSet = CType(MyBase.Clone(), InquiryUkeharaiZissekiDataSet)
			inquiryUkeharaiZissekiDataSet.InitVars()
			inquiryUkeharaiZissekiDataSet.SchemaSerializationMode = Me.SchemaSerializationMode
			Return inquiryUkeharaiZissekiDataSet
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

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Protected Overrides Sub ReadXmlSerializable(reader As XmlReader)
			If Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema Then
				Me.Reset()
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(reader)
				If dataSet.Tables("DataTable1") IsNot Nothing Then
					MyBase.Tables.Add(New InquiryUkeharaiZissekiDataSet.DataTable1DataTable(dataSet.Tables("DataTable1")))
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

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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
			Me.tableDataTable1 = CType(MyBase.Tables("DataTable1"), InquiryUkeharaiZissekiDataSet.DataTable1DataTable)
			If initTable AndAlso Me.tableDataTable1 IsNot Nothing Then
				Me.tableDataTable1.InitVars()
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		<DebuggerNonUserCode()>
		Private Sub InitClass()
			Me.DataSetName = "InquiryUkeharaiZissekiDataSet"
			Me.Prefix = ""
			Me.[Namespace] = "http://tempuri.org/InquiryUkeharaiZissekiDataSet.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.tableDataTable1 = New InquiryUkeharaiZissekiDataSet.DataTable1DataTable()
			MyBase.Tables.Add(Me.tableDataTable1)
		End Sub

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Function ShouldSerializeDataTable1() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Sub SchemaChanged(sender As Object, e As CollectionChangeEventArgs)
			If e.Action = CollectionChangeAction.Remove Then
				Me.InitVars()
			End If
		End Sub

		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Shared Function GetTypedDataSetSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
			Dim inquiryUkeharaiZissekiDataSet As InquiryUkeharaiZissekiDataSet = New InquiryUkeharaiZissekiDataSet()
			Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
			Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
			Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
			xmlSchemaAny.[Namespace] = inquiryUkeharaiZissekiDataSet.[Namespace]
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType.Particle = xmlSchemaSequence
			Dim schemaSerializable As XmlSchema = inquiryUkeharaiZissekiDataSet.GetSchemaSerializable()
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

		Private tableDataTable1 As DataTable1DataTable

		Private _schemaSerializationMode As SchemaSerializationMode

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub DataTable1RowChangeEventHandler(sender As Object, e As InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEvent)

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class DataTable1DataTable
			Inherits TypedTableBase(Of DataTable1Row)

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub New()
				Me.TableName = "DataTable1"
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

			<Browsable(False)>
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Default Public ReadOnly Property Item(index As Integer) As InquiryUkeharaiZissekiDataSet.DataTable1Row
				Get
					Return CType(Me.Rows(index), InquiryUkeharaiZissekiDataSet.DataTable1Row)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanging As InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanged As InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleting As InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleted As InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Sub AddDataTable1Row(row As InquiryUkeharaiZissekiDataSet.DataTable1Row)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function AddDataTable1Row() As InquiryUkeharaiZissekiDataSet.DataTable1Row
				Dim dataTable1Row As InquiryUkeharaiZissekiDataSet.DataTable1Row = CType(Me.NewRow(), InquiryUkeharaiZissekiDataSet.DataTable1Row)
				Dim itemArray As Object() = New Object(-1) {}
				dataTable1Row.ItemArray = itemArray
				Me.Rows.Add(dataTable1Row)
				Return dataTable1Row
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Overrides Function Clone() As DataTable
				Dim dataTable1DataTable As InquiryUkeharaiZissekiDataSet.DataTable1DataTable = CType(MyBase.Clone(), InquiryUkeharaiZissekiDataSet.DataTable1DataTable)
				dataTable1DataTable.InitVars()
				Return dataTable1DataTable
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Function CreateInstance() As DataTable
				Return New InquiryUkeharaiZissekiDataSet.DataTable1DataTable()
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub InitVars()
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Private Sub InitClass()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Public Function NewDataTable1Row() As InquiryUkeharaiZissekiDataSet.DataTable1Row
				Return CType(Me.NewRow(), InquiryUkeharaiZissekiDataSet.DataTable1Row)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New InquiryUkeharaiZissekiDataSet.DataTable1Row(builder)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(InquiryUkeharaiZissekiDataSet.DataTable1Row)
			End Function

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If Me.DataTable1RowChangedEvent IsNot Nothing Then
					Dim dataTable1RowChangedEvent As InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEventHandler = Me.DataTable1RowChangedEvent
					If dataTable1RowChangedEvent IsNot Nothing Then
						dataTable1RowChangedEvent(Me, New InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEvent(CType(e.Row, InquiryUkeharaiZissekiDataSet.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If Me.DataTable1RowChangingEvent IsNot Nothing Then
					Dim dataTable1RowChangingEvent As InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEventHandler = Me.DataTable1RowChangingEvent
					If dataTable1RowChangingEvent IsNot Nothing Then
						dataTable1RowChangingEvent(Me, New InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEvent(CType(e.Row, InquiryUkeharaiZissekiDataSet.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If Me.DataTable1RowDeletedEvent IsNot Nothing Then
					Dim dataTable1RowDeletedEvent As InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletedEvent
					If dataTable1RowDeletedEvent IsNot Nothing Then
						dataTable1RowDeletedEvent(Me, New InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEvent(CType(e.Row, InquiryUkeharaiZissekiDataSet.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If Me.DataTable1RowDeletingEvent IsNot Nothing Then
					Dim dataTable1RowDeletingEvent As InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletingEvent
					If dataTable1RowDeletingEvent IsNot Nothing Then
						dataTable1RowDeletingEvent(Me, New InquiryUkeharaiZissekiDataSet.DataTable1RowChangeEvent(CType(e.Row, InquiryUkeharaiZissekiDataSet.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub RemoveDataTable1Row(row As InquiryUkeharaiZissekiDataSet.DataTable1Row)
				Me.Rows.Remove(row)
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim inquiryUkeharaiZissekiDataSet As InquiryUkeharaiZissekiDataSet = New InquiryUkeharaiZissekiDataSet()
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
				xmlSchemaAttribute.FixedValue = inquiryUkeharaiZissekiDataSet.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "DataTable1DataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = inquiryUkeharaiZissekiDataSet.GetSchemaSerializable()
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
		End Class

		Public Class DataTable1Row
			Inherits DataRow

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableDataTable1 = CType(Me.Table, InquiryUkeharaiZissekiDataSet.DataTable1DataTable)
			End Sub

			Private tableDataTable1 As InquiryUkeharaiZissekiDataSet.DataTable1DataTable
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class DataTable1RowChangeEvent
			Inherits EventArgs

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub New(row As InquiryUkeharaiZissekiDataSet.DataTable1Row, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Row As InquiryUkeharaiZissekiDataSet.DataTable1Row
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

			Private eventRow As InquiryUkeharaiZissekiDataSet.DataTable1Row

			Private eventAction As DataRowAction
		End Class
	End Class
End Namespace
