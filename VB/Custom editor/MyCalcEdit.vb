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

Namespace WindowsApplication1
	''' <summary>
	''' MyCalcEdit is a descendant from CalcEdit.
	''' It displays a dialog form below the text box when the edit button is clicked.
	''' </summary>
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyCalcEdit
		Inherits CalcEdit
		Shared Sub New()
			RepositoryItemMyCalcEdit.Register()
		End Sub
		Public Sub New()

		End Sub

		Private _lastClickedButton As Integer

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyCalcEdit.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyCalcEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyCalcEdit)
			End Get
		End Property

		Protected Overrides Sub OnPressButton(ByVal buttonInfo As EditorButtonObjectInfoArgs)
			If (Not buttonInfo.Button.Index.Equals(_lastClickedButton)) Then
				DestroyPopupForm()
			End If
			_lastClickedButton = buttonInfo.Button.Index
			MyBase.OnPressButton(buttonInfo)
		End Sub

		Protected Overrides Function IsActionButton(ByVal buttonInfo As EditorButtonObjectInfoArgs) As Boolean
			Return MyBase.IsActionButton(buttonInfo) OrElse buttonInfo.Button.Index = Properties.SecondActionButtonIndex
		End Function



		Protected Overrides Function CreatePopupForm() As DevExpress.XtraEditors.Popup.PopupBaseForm
			If _lastClickedButton = Properties.ActionButtonIndex Then
				Return MyBase.CreatePopupForm()
			End If
			If _lastClickedButton= Properties.SecondActionButtonIndex Then
				Return New MyCustomForm(Me)
			End If
			Return Nothing
		End Function
	End Class
End Namespace