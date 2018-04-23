using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using MRUComboBox;

namespace WindowsFormsApplication18
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void barEditItem1_EditValueChanged(object sender, EventArgs e)
		{
			if ( repositoryItemMRUComboBox1.Items.Contains(barEditItem1.EditValue) )
				repositoryItemMRUComboBox1.StoreRecentItem(barEditItem1.EditValue);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
		}

		private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
		{
			if ( e.Column.ColumnEdit is RepositoryItemMRUComboBox )
			{
				RepositoryItemMRUComboBox columnEdit = (RepositoryItemMRUComboBox)e.Column.ColumnEdit;
				if ( columnEdit.Items.Contains(e.Value) )
					columnEdit.StoreRecentItem(e.Value);
			}
		}
	}
}