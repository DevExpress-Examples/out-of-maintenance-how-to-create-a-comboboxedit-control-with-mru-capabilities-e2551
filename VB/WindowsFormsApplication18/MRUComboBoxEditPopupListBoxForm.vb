Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup

Namespace MRUComboBox
	Public Class MRUComboBoxEditPopupListBoxForm
		Inherits PopupListBoxForm
		Public Sub New(ByVal ownerEdit As ComboBoxEdit)
			MyBase.New(ownerEdit)
		End Sub

		Protected Overrides Function CreateListBox() As PopupListBox
			Return New MRUComboBoxEditPopupListBox(Me)
		End Function
	End Class
End Namespace
