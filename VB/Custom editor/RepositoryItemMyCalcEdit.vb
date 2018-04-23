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
	<System.ComponentModel.DesignerCategory(""), UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyCalcEdit
		Inherits RepositoryItemCalcEdit
		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
		End Sub

		Friend Const EditorName As String = "MyCalcEdit"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyCalcEdit), GetType(RepositoryItemMyCalcEdit), GetType(DevExpress.XtraEditors.ViewInfo.CalcEditViewInfo), New ButtonEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

		Private _SecondActionButtonIndex As Integer
		Public Property SecondActionButtonIndex() As Integer
			Get
				Return _SecondActionButtonIndex
			End Get
			Set(ByVal value As Integer)
				_SecondActionButtonIndex = value
			End Set
		End Property
	End Class
End Namespace
