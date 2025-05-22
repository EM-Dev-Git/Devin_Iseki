Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.My

	<HideModuleName()>
	<GeneratedCode("MyTemplate", "10.0.0.0")>
	Friend Module MyProject

		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyForms

			Public Property BaseMenuForm As BaseMenuForm
				Get
					Me.m_BaseMenuForm = MyProject.MyForms.Create__Instance__(Of BaseMenuForm)(Me.m_BaseMenuForm)
					Return Me.m_BaseMenuForm
				End Get
				Set(value As BaseMenuForm)
					If value Is Me.m_BaseMenuForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of BaseMenuForm)(Me.m_BaseMenuForm)
				End Set
			End Property

			Public Property BatchHaraiDataWritForm As BatchHaraiDataWritForm
				Get
					Me.m_BatchHaraiDataWritForm = MyProject.MyForms.Create__Instance__(Of BatchHaraiDataWritForm)(Me.m_BatchHaraiDataWritForm)
					Return Me.m_BatchHaraiDataWritForm
				End Get
				Set(value As BatchHaraiDataWritForm)
					If value Is Me.m_BatchHaraiDataWritForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of BatchHaraiDataWritForm)(Me.m_BatchHaraiDataWritForm)
				End Set
			End Property

			Public Property BatchHaraiHostDataWritForm As BatchHaraiHostDataWritForm
				Get
					Me.m_BatchHaraiHostDataWritForm = MyProject.MyForms.Create__Instance__(Of BatchHaraiHostDataWritForm)(Me.m_BatchHaraiHostDataWritForm)
					Return Me.m_BatchHaraiHostDataWritForm
				End Get
				Set(value As BatchHaraiHostDataWritForm)
					If value Is Me.m_BatchHaraiHostDataWritForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of BatchHaraiHostDataWritForm)(Me.m_BatchHaraiHostDataWritForm)
				End Set
			End Property

			Public Property BatchJissekiForm As BatchJissekiForm
				Get
					Me.m_BatchJissekiForm = MyProject.MyForms.Create__Instance__(Of BatchJissekiForm)(Me.m_BatchJissekiForm)
					Return Me.m_BatchJissekiForm
				End Get
				Set(value As BatchJissekiForm)
					If value Is Me.m_BatchJissekiForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of BatchJissekiForm)(Me.m_BatchJissekiForm)
				End Set
			End Property

			Public Property BatchMenuForm As BatchMenuForm
				Get
					Me.m_BatchMenuForm = MyProject.MyForms.Create__Instance__(Of BatchMenuForm)(Me.m_BatchMenuForm)
					Return Me.m_BatchMenuForm
				End Get
				Set(value As BatchMenuForm)
					If value Is Me.m_BatchMenuForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of BatchMenuForm)(Me.m_BatchMenuForm)
				End Set
			End Property

			Public Property BatchMonthlyDataForm As BatchMonthlyDataForm
				Get
					Me.m_BatchMonthlyDataForm = MyProject.MyForms.Create__Instance__(Of BatchMonthlyDataForm)(Me.m_BatchMonthlyDataForm)
					Return Me.m_BatchMonthlyDataForm
				End Get
				Set(value As BatchMonthlyDataForm)
					If value Is Me.m_BatchMonthlyDataForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of BatchMonthlyDataForm)(Me.m_BatchMonthlyDataForm)
				End Set
			End Property

			Public Property BatchUkeireDataWritForm As BatchUkeireDataWritForm
				Get
					Me.m_BatchUkeireDataWritForm = MyProject.MyForms.Create__Instance__(Of BatchUkeireDataWritForm)(Me.m_BatchUkeireDataWritForm)
					Return Me.m_BatchUkeireDataWritForm
				End Get
				Set(value As BatchUkeireDataWritForm)
					If value Is Me.m_BatchUkeireDataWritForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of BatchUkeireDataWritForm)(Me.m_BatchUkeireDataWritForm)
				End Set
			End Property

			Public Property BatchYearlyDataForm As BatchYearlyDataForm
				Get
					Me.m_BatchYearlyDataForm = MyProject.MyForms.Create__Instance__(Of BatchYearlyDataForm)(Me.m_BatchYearlyDataForm)
					Return Me.m_BatchYearlyDataForm
				End Get
				Set(value As BatchYearlyDataForm)
					If value Is Me.m_BatchYearlyDataForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of BatchYearlyDataForm)(Me.m_BatchYearlyDataForm)
				End Set
			End Property

			Public Property CreatDataMenuForm As CreatDataMenuForm
				Get
					Me.m_CreatDataMenuForm = MyProject.MyForms.Create__Instance__(Of CreatDataMenuForm)(Me.m_CreatDataMenuForm)
					Return Me.m_CreatDataMenuForm
				End Get
				Set(value As CreatDataMenuForm)
					If value Is Me.m_CreatDataMenuForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of CreatDataMenuForm)(Me.m_CreatDataMenuForm)
				End Set
			End Property

			Public Property CreateDataBuhinMasterForm As CreateDataBuhinMasterForm
				Get
					Me.m_CreateDataBuhinMasterForm = MyProject.MyForms.Create__Instance__(Of CreateDataBuhinMasterForm)(Me.m_CreateDataBuhinMasterForm)
					Return Me.m_CreateDataBuhinMasterForm
				End Get
				Set(value As CreateDataBuhinMasterForm)
					If value Is Me.m_CreateDataBuhinMasterForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of CreateDataBuhinMasterForm)(Me.m_CreateDataBuhinMasterForm)
				End Set
			End Property

			Public Property CreateDataGekkanUkeharaiDayDeployForm As CreateDataGekkanUkeharaiDayDeployForm
				Get
					Me.m_CreateDataGekkanUkeharaiDayDeployForm = MyProject.MyForms.Create__Instance__(Of CreateDataGekkanUkeharaiDayDeployForm)(Me.m_CreateDataGekkanUkeharaiDayDeployForm)
					Return Me.m_CreateDataGekkanUkeharaiDayDeployForm
				End Get
				Set(value As CreateDataGekkanUkeharaiDayDeployForm)
					If value Is Me.m_CreateDataGekkanUkeharaiDayDeployForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of CreateDataGekkanUkeharaiDayDeployForm)(Me.m_CreateDataGekkanUkeharaiDayDeployForm)
				End Set
			End Property

			Public Property CreateDataNounyuMasterForm As CreateDataNounyuMasterForm
				Get
					Me.m_CreateDataNounyuMasterForm = MyProject.MyForms.Create__Instance__(Of CreateDataNounyuMasterForm)(Me.m_CreateDataNounyuMasterForm)
					Return Me.m_CreateDataNounyuMasterForm
				End Get
				Set(value As CreateDataNounyuMasterForm)
					If value Is Me.m_CreateDataNounyuMasterForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of CreateDataNounyuMasterForm)(Me.m_CreateDataNounyuMasterForm)
				End Set
			End Property

			Public Property CreateDataTorihikiMasterForm As CreateDataTorihikiMasterForm
				Get
					Me.m_CreateDataTorihikiMasterForm = MyProject.MyForms.Create__Instance__(Of CreateDataTorihikiMasterForm)(Me.m_CreateDataTorihikiMasterForm)
					Return Me.m_CreateDataTorihikiMasterForm
				End Get
				Set(value As CreateDataTorihikiMasterForm)
					If value Is Me.m_CreateDataTorihikiMasterForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of CreateDataTorihikiMasterForm)(Me.m_CreateDataTorihikiMasterForm)
				End Set
			End Property

			Public Property CreateDataTorihikiUkeharaiDailyForm As CreateDataTorihikiUkeharaiDailyForm
				Get
					Me.m_CreateDataTorihikiUkeharaiDailyForm = MyProject.MyForms.Create__Instance__(Of CreateDataTorihikiUkeharaiDailyForm)(Me.m_CreateDataTorihikiUkeharaiDailyForm)
					Return Me.m_CreateDataTorihikiUkeharaiDailyForm
				End Get
				Set(value As CreateDataTorihikiUkeharaiDailyForm)
					If value Is Me.m_CreateDataTorihikiUkeharaiDailyForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of CreateDataTorihikiUkeharaiDailyForm)(Me.m_CreateDataTorihikiUkeharaiDailyForm)
				End Set
			End Property

			Public Property CreateDataTorihikiUkeharaiMonthlyForm As CreateDataTorihikiUkeharaiMonthlyForm
				Get
					Me.m_CreateDataTorihikiUkeharaiMonthlyForm = MyProject.MyForms.Create__Instance__(Of CreateDataTorihikiUkeharaiMonthlyForm)(Me.m_CreateDataTorihikiUkeharaiMonthlyForm)
					Return Me.m_CreateDataTorihikiUkeharaiMonthlyForm
				End Get
				Set(value As CreateDataTorihikiUkeharaiMonthlyForm)
					If value Is Me.m_CreateDataTorihikiUkeharaiMonthlyForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of CreateDataTorihikiUkeharaiMonthlyForm)(Me.m_CreateDataTorihikiUkeharaiMonthlyForm)
				End Set
			End Property

			Public Property frmLogo As frmLogo
				Get
					Me.m_frmLogo = MyProject.MyForms.Create__Instance__(Of frmLogo)(Me.m_frmLogo)
					Return Me.m_frmLogo
				End Get
				Set(value As frmLogo)
					If value Is Me.m_frmLogo Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of frmLogo)(Me.m_frmLogo)
				End Set
			End Property

			Public Property InquiryKeppinBuhinForm As InquiryKeppinBuhinForm
				Get
					Me.m_InquiryKeppinBuhinForm = MyProject.MyForms.Create__Instance__(Of InquiryKeppinBuhinForm)(Me.m_InquiryKeppinBuhinForm)
					Return Me.m_InquiryKeppinBuhinForm
				End Get
				Set(value As InquiryKeppinBuhinForm)
					If value Is Me.m_InquiryKeppinBuhinForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of InquiryKeppinBuhinForm)(Me.m_InquiryKeppinBuhinForm)
				End Set
			End Property

			Public Property InquiryMenuForm As InquiryMenuForm
				Get
					Me.m_InquiryMenuForm = MyProject.MyForms.Create__Instance__(Of InquiryMenuForm)(Me.m_InquiryMenuForm)
					Return Me.m_InquiryMenuForm
				End Get
				Set(value As InquiryMenuForm)
					If value Is Me.m_InquiryMenuForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of InquiryMenuForm)(Me.m_InquiryMenuForm)
				End Set
			End Property

			Public Property InquiryUkeharaiZissekiForm As InquiryUkeharaiZissekiForm
				Get
					Me.m_InquiryUkeharaiZissekiForm = MyProject.MyForms.Create__Instance__(Of InquiryUkeharaiZissekiForm)(Me.m_InquiryUkeharaiZissekiForm)
					Return Me.m_InquiryUkeharaiZissekiForm
				End Get
				Set(value As InquiryUkeharaiZissekiForm)
					If value Is Me.m_InquiryUkeharaiZissekiForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of InquiryUkeharaiZissekiForm)(Me.m_InquiryUkeharaiZissekiForm)
				End Set
			End Property

			Public Property ListBuhinForm As ListBuhinForm
				Get
					Me.m_ListBuhinForm = MyProject.MyForms.Create__Instance__(Of ListBuhinForm)(Me.m_ListBuhinForm)
					Return Me.m_ListBuhinForm
				End Get
				Set(value As ListBuhinForm)
					If value Is Me.m_ListBuhinForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of ListBuhinForm)(Me.m_ListBuhinForm)
				End Set
			End Property

			Public Property ListUkeharaiConfirmationLetterForm As ListUkeharaiConfirmationLetterForm
				Get
					Me.m_ListUkeharaiConfirmationLetterForm = MyProject.MyForms.Create__Instance__(Of ListUkeharaiConfirmationLetterForm)(Me.m_ListUkeharaiConfirmationLetterForm)
					Return Me.m_ListUkeharaiConfirmationLetterForm
				End Get
				Set(value As ListUkeharaiConfirmationLetterForm)
					If value Is Me.m_ListUkeharaiConfirmationLetterForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of ListUkeharaiConfirmationLetterForm)(Me.m_ListUkeharaiConfirmationLetterForm)
				End Set
			End Property

			Public Property ListUkeharaiReporForm As ListUkeharaiReporForm
				Get
					Me.m_ListUkeharaiReporForm = MyProject.MyForms.Create__Instance__(Of ListUkeharaiReporForm)(Me.m_ListUkeharaiReporForm)
					Return Me.m_ListUkeharaiReporForm
				End Get
				Set(value As ListUkeharaiReporForm)
					If value Is Me.m_ListUkeharaiReporForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of ListUkeharaiReporForm)(Me.m_ListUkeharaiReporForm)
				End Set
			End Property

			Public Property ListZaikoDailyAndMonthlyForm As ListZaikoDailyAndMonthlyForm
				Get
					Me.m_ListZaikoDailyAndMonthlyForm = MyProject.MyForms.Create__Instance__(Of ListZaikoDailyAndMonthlyForm)(Me.m_ListZaikoDailyAndMonthlyForm)
					Return Me.m_ListZaikoDailyAndMonthlyForm
				End Get
				Set(value As ListZaikoDailyAndMonthlyForm)
					If value Is Me.m_ListZaikoDailyAndMonthlyForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of ListZaikoDailyAndMonthlyForm)(Me.m_ListZaikoDailyAndMonthlyForm)
				End Set
			End Property

			Public Property MainForm As MainForm
				Get
					Me.m_MainForm = MyProject.MyForms.Create__Instance__(Of MainForm)(Me.m_MainForm)
					Return Me.m_MainForm
				End Get
				Set(value As MainForm)
					If value Is Me.m_MainForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of MainForm)(Me.m_MainForm)
				End Set
			End Property

			Public Property OutPutSeikyuForm As OutPutSeikyuForm
				Get
					Me.m_OutPutSeikyuForm = MyProject.MyForms.Create__Instance__(Of OutPutSeikyuForm)(Me.m_OutPutSeikyuForm)
					Return Me.m_OutPutSeikyuForm
				End Get
				Set(value As OutPutSeikyuForm)
					If value Is Me.m_OutPutSeikyuForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of OutPutSeikyuForm)(Me.m_OutPutSeikyuForm)
				End Set
			End Property

			Public Property OutPutSeikyuFormReportViewSeikyu As OutPutSeikyuFormReportViewSeikyu
				Get
					Me.m_OutPutSeikyuFormReportViewSeikyu = MyProject.MyForms.Create__Instance__(Of OutPutSeikyuFormReportViewSeikyu)(Me.m_OutPutSeikyuFormReportViewSeikyu)
					Return Me.m_OutPutSeikyuFormReportViewSeikyu
				End Get
				Set(value As OutPutSeikyuFormReportViewSeikyu)
					If value Is Me.m_OutPutSeikyuFormReportViewSeikyu Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of OutPutSeikyuFormReportViewSeikyu)(Me.m_OutPutSeikyuFormReportViewSeikyu)
				End Set
			End Property

			Public Property OutPutSeikyuFormReportViewUchiwake As OutPutSeikyuFormReportViewUchiwake
				Get
					Me.m_OutPutSeikyuFormReportViewUchiwake = MyProject.MyForms.Create__Instance__(Of OutPutSeikyuFormReportViewUchiwake)(Me.m_OutPutSeikyuFormReportViewUchiwake)
					Return Me.m_OutPutSeikyuFormReportViewUchiwake
				End Get
				Set(value As OutPutSeikyuFormReportViewUchiwake)
					If value Is Me.m_OutPutSeikyuFormReportViewUchiwake Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of OutPutSeikyuFormReportViewUchiwake)(Me.m_OutPutSeikyuFormReportViewUchiwake)
				End Set
			End Property

			Public Property OutPutZissekiTableForm As OutPutZissekiTableForm
				Get
					Me.m_OutPutZissekiTableForm = MyProject.MyForms.Create__Instance__(Of OutPutZissekiTableForm)(Me.m_OutPutZissekiTableForm)
					Return Me.m_OutPutZissekiTableForm
				End Get
				Set(value As OutPutZissekiTableForm)
					If value Is Me.m_OutPutZissekiTableForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of OutPutZissekiTableForm)(Me.m_OutPutZissekiTableForm)
				End Set
			End Property

			Public Property RegisterBaseForm As RegisterBaseForm
				Get
					Me.m_RegisterBaseForm = MyProject.MyForms.Create__Instance__(Of RegisterBaseForm)(Me.m_RegisterBaseForm)
					Return Me.m_RegisterBaseForm
				End Get
				Set(value As RegisterBaseForm)
					If value Is Me.m_RegisterBaseForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RegisterBaseForm)(Me.m_RegisterBaseForm)
				End Set
			End Property

			Public Property RegisterBuhinMasterForm As RegisterBuhinMasterForm
				Get
					Me.m_RegisterBuhinMasterForm = MyProject.MyForms.Create__Instance__(Of RegisterBuhinMasterForm)(Me.m_RegisterBuhinMasterForm)
					Return Me.m_RegisterBuhinMasterForm
				End Get
				Set(value As RegisterBuhinMasterForm)
					If value Is Me.m_RegisterBuhinMasterForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RegisterBuhinMasterForm)(Me.m_RegisterBuhinMasterForm)
				End Set
			End Property

			Public Property RegisterHaraiZIssekiForm As RegisterHaraiZIssekiForm
				Get
					Me.m_RegisterHaraiZIssekiForm = MyProject.MyForms.Create__Instance__(Of RegisterHaraiZIssekiForm)(Me.m_RegisterHaraiZIssekiForm)
					Return Me.m_RegisterHaraiZIssekiForm
				End Get
				Set(value As RegisterHaraiZIssekiForm)
					If value Is Me.m_RegisterHaraiZIssekiForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RegisterHaraiZIssekiForm)(Me.m_RegisterHaraiZIssekiForm)
				End Set
			End Property

			Public Property RegisterJosuMasterForm As RegisterJosuMasterForm
				Get
					Me.m_RegisterJosuMasterForm = MyProject.MyForms.Create__Instance__(Of RegisterJosuMasterForm)(Me.m_RegisterJosuMasterForm)
					Return Me.m_RegisterJosuMasterForm
				End Get
				Set(value As RegisterJosuMasterForm)
					If value Is Me.m_RegisterJosuMasterForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RegisterJosuMasterForm)(Me.m_RegisterJosuMasterForm)
				End Set
			End Property

			Public Property RegisterMenuForm As RegisterMenuForm
				Get
					Me.m_RegisterMenuForm = MyProject.MyForms.Create__Instance__(Of RegisterMenuForm)(Me.m_RegisterMenuForm)
					Return Me.m_RegisterMenuForm
				End Get
				Set(value As RegisterMenuForm)
					If value Is Me.m_RegisterMenuForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RegisterMenuForm)(Me.m_RegisterMenuForm)
				End Set
			End Property

			Public Property RegisterNounyuMasterForm As RegisterNounyuMasterForm
				Get
					Me.m_RegisterNounyuMasterForm = MyProject.MyForms.Create__Instance__(Of RegisterNounyuMasterForm)(Me.m_RegisterNounyuMasterForm)
					Return Me.m_RegisterNounyuMasterForm
				End Get
				Set(value As RegisterNounyuMasterForm)
					If value Is Me.m_RegisterNounyuMasterForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RegisterNounyuMasterForm)(Me.m_RegisterNounyuMasterForm)
				End Set
			End Property

			Public Property RegisterSeikyuMasterForm As RegisterSeikyuMasterForm
				Get
					Me.m_RegisterSeikyuMasterForm = MyProject.MyForms.Create__Instance__(Of RegisterSeikyuMasterForm)(Me.m_RegisterSeikyuMasterForm)
					Return Me.m_RegisterSeikyuMasterForm
				End Get
				Set(value As RegisterSeikyuMasterForm)
					If value Is Me.m_RegisterSeikyuMasterForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RegisterSeikyuMasterForm)(Me.m_RegisterSeikyuMasterForm)
				End Set
			End Property

			Public Property RegisterTankaMasterForm As RegisterTankaMasterForm
				Get
					Me.m_RegisterTankaMasterForm = MyProject.MyForms.Create__Instance__(Of RegisterTankaMasterForm)(Me.m_RegisterTankaMasterForm)
					Return Me.m_RegisterTankaMasterForm
				End Get
				Set(value As RegisterTankaMasterForm)
					If value Is Me.m_RegisterTankaMasterForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RegisterTankaMasterForm)(Me.m_RegisterTankaMasterForm)
				End Set
			End Property

			Public Property RegisterTorihikiMasterForm As RegisterTorihikiMasterForm
				Get
					Me.m_RegisterTorihikiMasterForm = MyProject.MyForms.Create__Instance__(Of RegisterTorihikiMasterForm)(Me.m_RegisterTorihikiMasterForm)
					Return Me.m_RegisterTorihikiMasterForm
				End Get
				Set(value As RegisterTorihikiMasterForm)
					If value Is Me.m_RegisterTorihikiMasterForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RegisterTorihikiMasterForm)(Me.m_RegisterTorihikiMasterForm)
				End Set
			End Property

			Public Property RegisterUkeireZissekiForm As RegisterUkeireZissekiForm
				Get
					Me.m_RegisterUkeireZissekiForm = MyProject.MyForms.Create__Instance__(Of RegisterUkeireZissekiForm)(Me.m_RegisterUkeireZissekiForm)
					Return Me.m_RegisterUkeireZissekiForm
				End Get
				Set(value As RegisterUkeireZissekiForm)
					If value Is Me.m_RegisterUkeireZissekiForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RegisterUkeireZissekiForm)(Me.m_RegisterUkeireZissekiForm)
				End Set
			End Property

			Public Property SeikyuMenuForm As SeikyuMenuForm
				Get
					Me.m_SeikyuMenuForm = MyProject.MyForms.Create__Instance__(Of SeikyuMenuForm)(Me.m_SeikyuMenuForm)
					Return Me.m_SeikyuMenuForm
				End Get
				Set(value As SeikyuMenuForm)
					If value Is Me.m_SeikyuMenuForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of SeikyuMenuForm)(Me.m_SeikyuMenuForm)
				End Set
			End Property

			Public Property TopForm As TopForm
				Get
					Me.m_TopForm = MyProject.MyForms.Create__Instance__(Of TopForm)(Me.m_TopForm)
					Return Me.m_TopForm
				End Get
				Set(value As TopForm)
					If value Is Me.m_TopForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of TopForm)(Me.m_TopForm)
				End Set
			End Property

			Public Property VersionForm As VersionForm
				Get
					Me.m_VersionForm = MyProject.MyForms.Create__Instance__(Of VersionForm)(Me.m_VersionForm)
					Return Me.m_VersionForm
				End Get
				Set(value As VersionForm)
					If value Is Me.m_VersionForm Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of VersionForm)(Me.m_VersionForm)
				End Set
			End Property

			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As {Form, New})(Instance As T) As T
				If Instance Is Nothing OrElse Instance.IsDisposed Then
					If MyProject.MyForms.m_FormBeingCreated IsNot Nothing Then
						If MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() {ex.InnerException.Message})
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
					Return Instance
				End If
				Return Instance
			End Function

			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Overloads Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			Public m_BaseMenuForm As BaseMenuForm

			Public m_BatchHaraiDataWritForm As BatchHaraiDataWritForm

			Public m_BatchHaraiHostDataWritForm As BatchHaraiHostDataWritForm

			Public m_BatchJissekiForm As BatchJissekiForm

			Public m_BatchMenuForm As BatchMenuForm

			Public m_BatchMonthlyDataForm As BatchMonthlyDataForm

			Public m_BatchUkeireDataWritForm As BatchUkeireDataWritForm

			Public m_BatchYearlyDataForm As BatchYearlyDataForm

			Public m_CreatDataMenuForm As CreatDataMenuForm

			Public m_CreateDataBuhinMasterForm As CreateDataBuhinMasterForm

			Public m_CreateDataGekkanUkeharaiDayDeployForm As CreateDataGekkanUkeharaiDayDeployForm

			Public m_CreateDataNounyuMasterForm As CreateDataNounyuMasterForm

			Public m_CreateDataTorihikiMasterForm As CreateDataTorihikiMasterForm

			Public m_CreateDataTorihikiUkeharaiDailyForm As CreateDataTorihikiUkeharaiDailyForm

			Public m_CreateDataTorihikiUkeharaiMonthlyForm As CreateDataTorihikiUkeharaiMonthlyForm

			Public m_frmLogo As frmLogo

			Public m_InquiryKeppinBuhinForm As InquiryKeppinBuhinForm

			Public m_InquiryMenuForm As InquiryMenuForm

			Public m_InquiryUkeharaiZissekiForm As InquiryUkeharaiZissekiForm

			Public m_ListBuhinForm As ListBuhinForm

			Public m_ListUkeharaiConfirmationLetterForm As ListUkeharaiConfirmationLetterForm

			Public m_ListUkeharaiReporForm As ListUkeharaiReporForm

			Public m_ListZaikoDailyAndMonthlyForm As ListZaikoDailyAndMonthlyForm

			Public m_MainForm As MainForm

			Public m_OutPutSeikyuForm As OutPutSeikyuForm

			Public m_OutPutSeikyuFormReportViewSeikyu As OutPutSeikyuFormReportViewSeikyu

			Public m_OutPutSeikyuFormReportViewUchiwake As OutPutSeikyuFormReportViewUchiwake

			Public m_OutPutZissekiTableForm As OutPutZissekiTableForm

			Public m_RegisterBaseForm As RegisterBaseForm

			Public m_RegisterBuhinMasterForm As RegisterBuhinMasterForm

			Public m_RegisterHaraiZIssekiForm As RegisterHaraiZIssekiForm

			Public m_RegisterJosuMasterForm As RegisterJosuMasterForm

			Public m_RegisterMenuForm As RegisterMenuForm

			Public m_RegisterNounyuMasterForm As RegisterNounyuMasterForm

			Public m_RegisterSeikyuMasterForm As RegisterSeikyuMasterForm

			Public m_RegisterTankaMasterForm As RegisterTankaMasterForm

			Public m_RegisterTorihikiMasterForm As RegisterTorihikiMasterForm

			Public m_RegisterUkeireZissekiForm As RegisterUkeireZissekiForm

			Public m_SeikyuMenuForm As SeikyuMenuForm

			Public m_TopForm As TopForm

			Public m_VersionForm As VersionForm

			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable
		End Class

		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyWebServices

			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Overloads Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				If instance Is Nothing Then
					Return Activator.CreateInstance(Of T)()
				End If
				Return instance
			End Function

			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub
		End Class

		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)

			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					If MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
