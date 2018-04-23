Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace MRUComboBox
	Public Class MRUComboBoxEdit
		Inherits ComboBoxEdit
		Shared Sub New()
			RepositoryItemMRUComboBox.Register()
		End Sub
		Public Sub New()
		End Sub

		Protected Overrides Sub OnPopupClosed(ByVal closeMode As PopupCloseMode)
			MyBase.OnPopupClosed(closeMode)
			Properties.StoreRecentItem(Me.SelectedItem)
		End Sub

		Protected Overrides Function CreatePopupForm() As DevExpress.XtraEditors.Popup.PopupBaseForm
			Return New MRUComboBoxEditPopupListBoxForm(Me)
		End Function

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMRUComboBox
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMRUComboBox)
			End Get
		End Property

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMRUComboBox.EditorName
			End Get
		End Property
	End Class
End Namespace
