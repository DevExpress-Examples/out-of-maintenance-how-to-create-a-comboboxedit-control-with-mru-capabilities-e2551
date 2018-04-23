using DevExpress.XtraEditors.Popup;

namespace MRUComboBox
{
	public class MRUComboBoxEditPopupListBoxViewInfo : PopupListBoxViewInfo
	{
		public MRUComboBoxEditPopupListBoxViewInfo(PopupListBox owner)
			: base(owner)
		{
		}

		public new object Owner
		{
			get
			{
				return base.Owner;
			}
		}
	}
}
