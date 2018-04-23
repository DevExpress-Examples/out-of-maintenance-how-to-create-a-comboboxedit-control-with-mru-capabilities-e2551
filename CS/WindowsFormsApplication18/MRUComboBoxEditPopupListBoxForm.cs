using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;

namespace MRUComboBox
{
	public class MRUComboBoxEditPopupListBoxForm : PopupListBoxForm
	{
		public MRUComboBoxEditPopupListBoxForm(ComboBoxEdit ownerEdit)
			: base(ownerEdit)
		{
		}

		protected override PopupListBox CreateListBox()
		{
			return new MRUComboBoxEditPopupListBox(this);
		}
	}
}
