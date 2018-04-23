Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Linq
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization

Namespace NewProject
	Partial Public Class Form1
		Inherits XtraForm

		Private _r As New Random()

		Public Sub New()
			InitializeComponent()
			simpleButton1.BringToFront()
			simpleButton2.BringToFront()
		End Sub

		Private Sub tabbedView1_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs) Handles tabbedView1.QueryControl
			e.Control = New Control() With {.BackColor = Color.FromArgb(_r.Next(255), _r.Next(255), _r.Next(255))}
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim files As List(Of MyFile) = GetLayouts()
			File.Delete("Test.xml")
			Using stream As Stream = New FileStream("Test.xml", FileMode.CreateNew, FileAccess.ReadWrite)
				' Serialise
				Dim formatter As New XmlSerializer(GetType(List(Of MyFile)))
				formatter.Serialize(stream, files)
			End Using
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			Using stream As Stream = New FileStream("Test.xml", FileMode.Open, FileAccess.Read)
				' Deserailise
				Dim formatter As New XmlSerializer(GetType(List(Of MyFile)))
				Dim deserialisedFiles As List(Of MyFile) = CType(formatter.Deserialize(stream), List(Of MyFile))
				RestoreLayouts(deserialisedFiles)
			End Using

		End Sub
		Private Function GetLayouts() As List(Of MyFile)
			Dim ms1 As New MemoryStream()
			dockManager1.SaveLayoutToStream(ms1)
			Dim ms2 As New MemoryStream()
			tabbedView1.SaveLayoutToStream(ms2)
			Return New List(Of MyFile)(New MyFile() {New MyFile() With {.FileName = "DockManagerLayout", .Data = ms1.ToArray()}, New MyFile() With {.FileName = "TabbedViewLayout", .Data = ms2.ToArray()}})
		End Function
		Private Sub RestoreLayouts(ByVal deserialisedFiles As List(Of MyFile))
			Dim dockManagerLayout As MyFile = deserialisedFiles.OfType(Of MyFile)().First(Function(mf) mf.FileName = "DockManagerLayout")
			Dim tabbedViewLayout As MyFile = deserialisedFiles.OfType(Of MyFile)().First(Function(mf) mf.FileName = "TabbedViewLayout")

			dockManager1.RestoreLayoutFromStream(New MemoryStream(dockManagerLayout.Data))
			tabbedView1.RestoreLayoutFromStream(New MemoryStream(tabbedViewLayout.Data))
		End Sub
	End Class
	<Serializable()> _
	Public Class MyFile
		Public Data() As Byte
		Public FileName As String
	End Class

End Namespace
