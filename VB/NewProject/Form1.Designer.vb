Imports Microsoft.VisualBasic
Imports System
Namespace NewProject
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
			Me.components = New System.ComponentModel.Container()
			Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
			Me.documentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
			Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.dockPanel2Document = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.documentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dockPanel2Document, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' documentManager1
			' 
			Me.documentManager1.ContainerControl = Me
			Me.documentManager1.View = Me.tabbedView1
			Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.tabbedView1})
			' 
			' tabbedView1
			' 
			Me.tabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() { Me.documentGroup1})
			Me.tabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.document1, Me.document2, Me.document3, Me.dockPanel2Document})
'			Me.tabbedView1.QueryControl += New DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(Me.tabbedView1_QueryControl);
			' 
			' documentGroup1
			' 
			Me.documentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() { Me.document1, Me.document2, Me.document3, Me.dockPanel2Document})
			' 
			' document1
			' 
			Me.document1.Caption = "document1"
			Me.document1.ControlName = "document1"
			' 
			' document2
			' 
			Me.document2.Caption = "document2"
			Me.document2.ControlName = "document2"
			' 
			' document3
			' 
			Me.document3.Caption = "document3"
			Me.document3.ControlName = "document3"
			' 
			' dockPanel2Document
			' 
			Me.dockPanel2Document.Caption = "dockPanel2"
			Me.dockPanel2Document.ControlName = "dockPanel2"
			Me.dockPanel2Document.FloatLocation = New System.Drawing.Point(0, 0)
			Me.dockPanel2Document.FloatSize = New System.Drawing.Size(200, 200)
			Me.dockPanel2Document.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.True
			Me.dockPanel2Document.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.True
			Me.dockPanel2Document.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dockPanel1, Me.dockPanel2})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
			Me.dockPanel1.FloatLocation = New System.Drawing.Point(766, 121)
			Me.dockPanel1.ID = New System.Guid("8b1ac80e-bf1d-41a0-919d-d622dbb69548")
			Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
			Me.dockPanel1.Size = New System.Drawing.Size(200, 200)
			Me.dockPanel1.Text = "dockPanel1"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 22)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(194, 175)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' dockPanel2
			' 
			Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
			Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
			Me.dockPanel2.DockedAsTabbedDocument = True
			Me.dockPanel2.ID = New System.Guid("1727ce64-cbc9-408e-9a9b-53beef18a8a8")
			Me.dockPanel2.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel2.Name = "dockPanel2"
			Me.dockPanel2.OriginalSize = New System.Drawing.Size(300, 300)
			Me.dockPanel2.Size = New System.Drawing.Size(300, 300)
			Me.dockPanel2.Text = "dockPanel2"
			' 
			' dockPanel2_Container
			' 
			Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel2_Container.Name = "dockPanel2_Container"
			Me.dockPanel2_Container.Size = New System.Drawing.Size(300, 300)
			Me.dockPanel2_Container.TabIndex = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(12, 455)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Save layout"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(93, 455)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton2.TabIndex = 2
			Me.simpleButton2.Text = "Load layout"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(662, 490)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.documentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dockPanel2Document, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
		Private WithEvents tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
		Private documentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
		Private document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document2 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document3 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private dockPanel2Document As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton






	End Class
End Namespace

