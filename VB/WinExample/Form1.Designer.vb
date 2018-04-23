Imports Microsoft.VisualBasic
Imports System
Namespace WinExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.xpCollection1 = New DevExpress.Xpo.XPCollection()
			Me.session1 = New DevExpress.Xpo.Session()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProperty1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProperty2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOid2 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xpCollection1
			' 
			Me.xpCollection1.ObjectType = GetType(WinExample.PersistentObject1)
			Me.xpCollection1.Session = Me.session1
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOid, Me.colProperty1, Me.colProperty2})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colOid
			' 
			Me.colOid.FieldName = "Oid"
			Me.colOid.Name = "colOid"
			Me.colOid.Visible = True
			Me.colOid.VisibleIndex = 0
			' 
			' colProperty1
			' 
			Me.colProperty1.FieldName = "Property1"
			Me.colProperty1.Name = "colProperty1"
			Me.colProperty1.Visible = True
			Me.colProperty1.VisibleIndex = 1
			' 
			' colProperty2
			' 
			Me.colProperty2.FieldName = "Property2"
			Me.colProperty2.Name = "colProperty2"
			Me.colProperty2.Visible = True
			Me.colProperty2.VisibleIndex = 2
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xpCollection1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(509, 250)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.UseEmbeddedNavigator = True
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView3})
			' 
			' gridView3
			' 
			Me.gridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOid2, Me.colProperty1, Me.colProperty2})
			Me.gridView3.GridControl = Me.gridControl1
			Me.gridView3.Name = "gridView3"
			' 
			' colOid2
			' 
			Me.colOid2.FieldName = "Oid"
			Me.colOid2.Name = "colOid2"
			Me.colOid2.Visible = True
			Me.colOid2.VisibleIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(509, 250)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
'			Me.FormClosed += New System.Windows.Forms.FormClosedEventHandler(Me.Form1_FormClosed);
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xpCollection1 As DevExpress.Xpo.XPCollection
		Private session1 As DevExpress.Xpo.Session
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colOid As DevExpress.XtraGrid.Columns.GridColumn
		Private colProperty1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colProperty2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colOid2 As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

