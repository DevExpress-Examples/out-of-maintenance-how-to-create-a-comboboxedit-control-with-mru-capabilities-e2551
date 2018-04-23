Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports MRUComboBox

Namespace WindowsFormsApplication18
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub barEditItem1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barEditItem1.EditValueChanged
			If repositoryItemMRUComboBox1.Items.Contains(barEditItem1.EditValue) Then
				repositoryItemMRUComboBox1.StoreRecentItem(barEditItem1.EditValue)
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            'TODO: This line of code loads data into the 'CarsDBDataSet.Cars' table. You can move, or remove it, as needed.
            Me.CarsTableAdapter.Fill(Me.CarsDBDataSet.Cars)
        End Sub

		Private Sub gridView1_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles gridView1.CellValueChanged
			If TypeOf e.Column.ColumnEdit Is RepositoryItemMRUComboBox Then
				Dim columnEdit As RepositoryItemMRUComboBox = CType(e.Column.ColumnEdit, RepositoryItemMRUComboBox)
				If columnEdit.Items.Contains(e.Value) Then
					columnEdit.StoreRecentItem(e.Value)
				End If
			End If
		End Sub
	End Class
End Namespace