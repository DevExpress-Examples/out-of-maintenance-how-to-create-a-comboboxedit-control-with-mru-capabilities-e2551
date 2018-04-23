Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace MRUComboBox
	Public Class MRUComboBoxEditPopupListBoxPainter
		Inherits BaseListBoxPainter
		Public Sub New()
		End Sub

		Protected Overrides Sub DrawItemCore(ByVal info As ControlGraphicsInfoArgs, ByVal itemInfo As BaseListBoxViewInfo.ItemInfo, ByVal e As ListBoxDrawItemEventArgs)
			MyBase.DrawItemCore(info, itemInfo, e)

			Dim viewInfo As MRUComboBoxEditPopupListBoxViewInfo = TryCast(info.ViewInfo, MRUComboBoxEditPopupListBoxViewInfo)
			If viewInfo Is Nothing Then
				Return
			End If

			Dim popupListBox As MRUComboBoxEditPopupListBox = TryCast(viewInfo.Owner, MRUComboBoxEditPopupListBox)
			If popupListBox Is Nothing Then
				Return
			End If

			Dim comboBox As MRUComboBoxEdit = TryCast(popupListBox.OwnerEdit, MRUComboBoxEdit)
			If comboBox Is Nothing Then
				Return
			End If

			If itemInfo.Index = comboBox.Properties.LineItemIndex Then
				Dim borderColor As Color = If(NativeVista.IsVista, SystemColors.ControlDark, SystemColors.InactiveBorder)

				Using pen As New Pen(borderColor)
					e.Graphics.DrawLine(pen, New Point(e.Bounds.Left, e.Bounds.Bottom - 2), New Point(e.Bounds.Right, e.Bounds.Bottom - 2))
					e.Graphics.DrawLine(pen, New Point(e.Bounds.Left, e.Bounds.Bottom), New Point(e.Bounds.Right, e.Bounds.Bottom))
				End Using
			End If
		End Sub
	End Class
End Namespace
