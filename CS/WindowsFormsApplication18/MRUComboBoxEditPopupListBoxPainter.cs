using System.Drawing;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace MRUComboBox
{
	public class MRUComboBoxEditPopupListBoxPainter : BaseListBoxPainter
	{
		public MRUComboBoxEditPopupListBoxPainter()
		{
		}

		protected override void DrawItemCore(ControlGraphicsInfoArgs info, BaseListBoxViewInfo.ItemInfo itemInfo, ListBoxDrawItemEventArgs e)
		{
			base.DrawItemCore(info, itemInfo, e);

			MRUComboBoxEditPopupListBoxViewInfo viewInfo = info.ViewInfo as MRUComboBoxEditPopupListBoxViewInfo;
			if ( viewInfo == null )
				return;

			MRUComboBoxEditPopupListBox popupListBox = viewInfo.Owner as MRUComboBoxEditPopupListBox;
			if ( popupListBox == null )
				return;

			MRUComboBoxEdit comboBox = popupListBox.OwnerEdit as MRUComboBoxEdit;
			if ( comboBox == null )
				return;

			if ( itemInfo.Index == comboBox.Properties.LineItemIndex )
			{
				Color borderColor = NativeVista.IsVista ? SystemColors.ControlDark : SystemColors.InactiveBorder;

				using ( Pen pen = new Pen(borderColor) )
				{
					e.Graphics.DrawLine(pen, new Point(e.Bounds.Left, e.Bounds.Bottom - 2), new Point(e.Bounds.Right, e.Bounds.Bottom - 2));
					e.Graphics.DrawLine(pen, new Point(e.Bounds.Left, e.Bounds.Bottom), new Point(e.Bounds.Right, e.Bounds.Bottom));
				}
			}
		}
	}
}
