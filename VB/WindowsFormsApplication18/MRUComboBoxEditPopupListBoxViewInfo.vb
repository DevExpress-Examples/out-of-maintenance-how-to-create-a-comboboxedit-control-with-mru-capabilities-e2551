Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Popup

Namespace MRUComboBox
	Public Class MRUComboBoxEditPopupListBoxViewInfo
		Inherits PopupListBoxViewInfo
		Public Sub New(ByVal owner As PopupListBox)
			MyBase.New(owner)
		End Sub

		Public Shadows ReadOnly Property Owner() As Object
			Get
				Return MyBase.Owner
			End Get
		End Property
	End Class
End Namespace
