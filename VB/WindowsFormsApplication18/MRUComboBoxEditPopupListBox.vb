Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors.ViewInfo

Namespace MRUComboBox
	Public Class MRUComboBoxEditPopupListBox
		Inherits PopupListBox
		Public Sub New(ByVal ownerForm As PopupListBoxForm)
			MyBase.New(ownerForm)
		End Sub

		Protected Overrides Function CreatePainter() As BaseControlPainter
			Return New MRUComboBoxEditPopupListBoxPainter()
		End Function

		Protected Overrides Function CreateViewInfo() As BaseStyleControlViewInfo
			Return New MRUComboBoxEditPopupListBoxViewInfo(Me)
		End Function

		Public Shadows ReadOnly Property ViewInfo() As MRUComboBoxEditPopupListBoxViewInfo
			Get
				Return TryCast(MyBase.ViewInfo, MRUComboBoxEditPopupListBoxViewInfo)
			End Get
		End Property
	End Class
End Namespace