Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.Persistent.AuditTrail
Imports System.Reflection
Imports System.Security.Principal
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo

Namespace WinExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			XpoDefault.DataLayer = XpoDefault.GetDataLayer("XpoProvider=InMemoryDataStore", DB.AutoCreateOption.DatabaseAndSchema)
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			AddHandler AuditTrailService.Instance.QueryCurrentUserName, AddressOf Instance_QueryCurrentUserName
			session1.Dictionary.GetDataStoreSchema(GetType(PersistentObject1).Assembly)
			AuditTrailService.Instance.SetXPDictionary(session1.Dictionary)
			AuditTrailService.Instance.AuditDataStore = New AuditDataStore(Of AuditDataItemPersistent, AuditedObjectWeakReference)()
			AuditTrailService.Instance.BeginSessionAudit(session1, AuditTrailStrategy.OnObjectChanged, ObjectAuditingMode.Full)
		End Sub
		Private Sub Instance_QueryCurrentUserName(ByVal sender As Object, ByVal e As QueryCurrentUserNameEventArgs)
			e.CurrentUserName = WindowsIdentity.GetCurrent().Name
		End Sub
		Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
			AuditTrailService.Instance.SaveAuditData(session1)
		End Sub
	End Class
End Namespace
