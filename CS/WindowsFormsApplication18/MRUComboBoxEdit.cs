using System.ComponentModel;
using DevExpress.XtraEditors;

namespace MRUComboBox
{
	public class MRUComboBoxEdit : ComboBoxEdit
	{
		static MRUComboBoxEdit()
		{
			RepositoryItemMRUComboBox.Register();
		}
		public MRUComboBoxEdit()
		{
		}

		protected override void OnPopupClosed(PopupCloseMode closeMode)
		{
			base.OnPopupClosed(closeMode);
			Properties.StoreRecentItem(this.SelectedItem);
		}

		protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm()
		{
			return new MRUComboBoxEditPopupListBoxForm(this);
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new RepositoryItemMRUComboBox Properties
		{
			get
			{
				return base.Properties as RepositoryItemMRUComboBox;
			}
		}

		public override string EditorTypeName
		{
			get
			{
				return RepositoryItemMRUComboBox.EditorName;
			}
		}
	}
}
