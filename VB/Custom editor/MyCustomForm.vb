Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Popup
Imports WindowsApplication1.Custom_editor

Namespace WindowsApplication1
	Public Class MyCustomForm
		Inherits CustomBlobPopupForm
		Public Sub New(ByVal ownerEdit As PopupBaseEdit)
			MyBase.New(ownerEdit)
			CreateControls()
		End Sub
		Private Sub CreateControls()
			Dim uc As New CustomFormDesigner()
			uc.Dock = DockStyle.Fill
			Controls.Add(uc)
		End Sub

	End Class
End Namespace
