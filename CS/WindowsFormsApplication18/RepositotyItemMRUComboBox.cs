using System.Collections.Generic;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace MRUComboBox
{
	public class RepositoryItemMRUComboBox : RepositoryItemComboBox
	{
		internal const string EditorName = "MRUComboBoxEdit";

		private List<object> recentItems = new List<object>();
		private int lineItemIndex = -1;

		static RepositoryItemMRUComboBox()
		{
			Register();
		}
		public RepositoryItemMRUComboBox()
		{
			MRUItemsCount = 5;
		}

		public static void Register()
		{
			EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MRUComboBoxEdit),
				typeof(RepositoryItemMRUComboBox), typeof(ComboBoxViewInfo),
					new ButtonEditPainter(), true, null));
		}

		public void StoreRecentItem(object item)
		{
			if ( item == null || MRUItemsCount == 0 )
				return;

			if ( !recentItems.Contains(item) )
			{
				object lastItem = recentItems.Count > 0 ? recentItems[0] : null;
				int lastItemIndex = Items.IndexOf(lastItem);

				if ( recentItems.Count + 1 > MRUItemsCount )
				{
					Items.RemoveAt(lastItemIndex);
					recentItems.Remove(lastItem);
				}

				recentItems.Add(item);
				Items.Insert(0, item);

				if ( lastItemIndex == -1 )
					lineItemIndex = 0;
				else if ( recentItems.Count == MRUItemsCount )
					lineItemIndex = MRUItemsCount - 1;
				else
					lineItemIndex = lastItemIndex + 1;
			}
		}

		public override void Assign(RepositoryItem item)
		{
			BeginUpdate();
			try
			{
				if ( !(item is RepositoryItemMRUComboBox) )
					return;

				RepositoryItemMRUComboBox source = (RepositoryItemMRUComboBox)item;

				base.Assign(item);
				this.MRUItemsCount = source.MRUItemsCount;
				this.lineItemIndex = source.lineItemIndex;
				this.recentItems.Clear();
				this.recentItems.AddRange(source.recentItems);
			}
			finally
			{
				EndUpdate();
			}
		}

		public override string EditorTypeName
		{
			get
			{
				return EditorName;
			}
		}

		public int MRUItemsCount
		{
			get;
			set;
		}

		internal int LineItemIndex
		{
			get
			{
				return lineItemIndex;
			}
		}
	}
}
