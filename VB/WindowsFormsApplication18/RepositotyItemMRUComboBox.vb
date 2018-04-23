Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace MRUComboBox
	Public Class RepositoryItemMRUComboBox
		Inherits RepositoryItemComboBox
		Friend Const EditorName As String = "MRUComboBoxEdit"

		Private recentItems As New List(Of Object)()
		Private lineItemIndex_Renamed As Integer = -1

		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
			MRUItemsCount = 5
		End Sub

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MRUComboBoxEdit), GetType(RepositoryItemMRUComboBox), GetType(ComboBoxViewInfo), New ButtonEditPainter(), True))
		End Sub

		Public Sub StoreRecentItem(ByVal item As Object)
			If item Is Nothing OrElse MRUItemsCount = 0 Then
				Return
			End If

			If (Not recentItems.Contains(item)) Then
				Dim lastItem As Object = If(recentItems.Count > 0, recentItems(0), Nothing)
				Dim lastItemIndex As Integer = Items.IndexOf(lastItem)

				If recentItems.Count + 1 > MRUItemsCount Then
					Items.RemoveAt(lastItemIndex)
					recentItems.Remove(lastItem)
				End If

				recentItems.Add(item)
				Items.Insert(0, item)

				If lastItemIndex = -1 Then
					lineItemIndex_Renamed = 0
				ElseIf recentItems.Count = MRUItemsCount Then
					lineItemIndex_Renamed = MRUItemsCount - 1
				Else
					lineItemIndex_Renamed = lastItemIndex + 1
				End If
			End If
		End Sub

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				If Not(TypeOf item Is RepositoryItemMRUComboBox) Then
					Return
				End If

				Dim source As RepositoryItemMRUComboBox = CType(item, RepositoryItemMRUComboBox)

				MyBase.Assign(item)
				Me.MRUItemsCount = source.MRUItemsCount
				Me.lineItemIndex_Renamed = source.lineItemIndex
				Me.recentItems.Clear()
				Me.recentItems.AddRange(source.recentItems)
			Finally
				EndUpdate()
			End Try
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

		Private privateMRUItemsCount As Integer
		Public Property MRUItemsCount() As Integer
			Get
				Return privateMRUItemsCount
			End Get
			Set(ByVal value As Integer)
				privateMRUItemsCount = value
			End Set
		End Property

		Friend ReadOnly Property LineItemIndex() As Integer
			Get
				Return lineItemIndex_Renamed
			End Get
		End Property
	End Class
End Namespace
