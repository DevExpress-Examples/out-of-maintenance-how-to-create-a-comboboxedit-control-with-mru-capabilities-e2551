using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.ViewInfo;

namespace MRUComboBox
{
	public class MRUComboBoxEditPopupListBox : PopupListBox
	{
		public MRUComboBoxEditPopupListBox(PopupListBoxForm ownerForm)
			: base(ownerForm)
		{
		}

		protected override BaseControlPainter CreatePainter()
		{
			return new MRUComboBoxEditPopupListBoxPainter();
		}

		protected override BaseStyleControlViewInfo CreateViewInfo()
		{
			return new MRUComboBoxEditPopupListBoxViewInfo(this);
		}

		public new MRUComboBoxEditPopupListBoxViewInfo ViewInfo
		{
			get
			{
				return base.ViewInfo as MRUComboBoxEditPopupListBoxViewInfo;
			}
		}
	}
}