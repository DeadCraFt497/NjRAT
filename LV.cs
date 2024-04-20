using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x02000008 RID: 8
	public class LV : ListView
	{
		// Token: 0x06000052 RID: 82 RVA: 0x0013A330 File Offset: 0x00138730
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = LV.__ENCList;
			lock (_ENCList)
			{
				bool flag = LV.__ENCList.Count == LV.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = LV.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = LV.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								LV.__ENCList[num] = LV.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					LV.__ENCList.RemoveRange(num, LV.__ENCList.Count - num);
					LV.__ENCList.Capacity = LV.__ENCList.Count;
				}
				LV.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0013A434 File Offset: 0x00138834
		public LV()
		{
			base.ColumnClick += this.ColumnClick;
			LV.__ENCAddToList(this);
			this.AllowDrop = false;
			this.Font = new Font("arial", 8f, FontStyle.Bold);
			this.Dock = DockStyle.Fill;
			this.FullRowSelect = true;
			this.View = View.Details;
			this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.SetStyle(ControlStyles.EnableNotifyMessage, true);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0013A4B8 File Offset: 0x001388B8
		public void FX()
		{
			this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0013A4C4 File Offset: 0x001388C4
		protected override void OnNotifyMessage(Message m)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0013A4F4 File Offset: 0x001388F4
		public new void ColumnClick(object sender, ColumnClickEventArgs e)
		{
			ColumnHeader columnHeader = (ColumnHeader)NewLateBinding.LateGet(sender, null, "Columns", new object[] { e.Column }, null, null, null);
			bool flag = this.m_SortingColumn == null;
			SortOrder sortOrder;
			bool flag2;
			if (flag)
			{
				sortOrder = SortOrder.Ascending;
			}
			else
			{
				flag = columnHeader.Equals(this.m_SortingColumn);
				if (flag)
				{
					flag2 = this.m_SortingColumn.Text.StartsWith("+");
					if (flag2)
					{
						sortOrder = SortOrder.Descending;
					}
					else
					{
						sortOrder = SortOrder.Ascending;
					}
				}
				else
				{
					sortOrder = SortOrder.Ascending;
				}
				this.m_SortingColumn.Text = this.m_SortingColumn.Text.Substring(1);
			}
			this.m_SortingColumn = columnHeader;
			flag2 = sortOrder == SortOrder.Ascending;
			if (flag2)
			{
				this.m_SortingColumn.Text = "+" + this.m_SortingColumn.Text;
			}
			else
			{
				this.m_SortingColumn.Text = "-" + this.m_SortingColumn.Text;
			}
			flag2 = sender == null;
			if (!flag2)
			{
				NewLateBinding.LateSet(sender, null, "ListViewItemSorter", new object[]
				{
					new LV.clsListviewSorter(e.Column, sortOrder)
				}, null, null);
				NewLateBinding.LateCall(sender, null, "Sort", new object[0], null, null, null, true);
				NewLateBinding.LateSet(sender, null, "ListViewItemSorter", new object[] { null }, null, null);
			}
		}

		// Token: 0x04000023 RID: 35
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000024 RID: 36
		internal object Selected;

		// Token: 0x04000025 RID: 37
		private ColumnHeader m_SortingColumn;

		// Token: 0x02000009 RID: 9
		public class clsListviewSorter : IComparer
		{
			// Token: 0x06000057 RID: 87 RVA: 0x0013A658 File Offset: 0x00138A58
			public clsListviewSorter(int column_number, SortOrder sort_order)
			{
				this.m_ColumnNumber = column_number;
				this.m_SortOrder = sort_order;
			}

			// Token: 0x06000058 RID: 88 RVA: 0x0013A674 File Offset: 0x00138A74
			public int Compare(object x, object y)
			{
				ListViewItem listViewItem = (ListViewItem)x;
				ListViewItem listViewItem2 = (ListViewItem)y;
				bool flag = listViewItem.SubItems.Count <= this.m_ColumnNumber;
				string text;
				if (flag)
				{
					text = "";
				}
				else
				{
					text = listViewItem.SubItems[this.m_ColumnNumber].Text;
				}
				flag = listViewItem2.SubItems.Count <= this.m_ColumnNumber;
				string text2;
				if (flag)
				{
					text2 = "";
				}
				else
				{
					text2 = listViewItem2.SubItems[this.m_ColumnNumber].Text;
				}
				flag = this.m_SortOrder == SortOrder.Ascending;
				int num = 0;
				if (flag)
				{
					bool flag2 = Versioned.IsNumeric(text) & Versioned.IsNumeric(text2);
					if (flag2)
					{
						num = Conversion.Val(text).CompareTo(Conversion.Val(text2));
					}
					else
					{
						flag2 = Information.IsDate(text) & Information.IsDate(text2);
						if (flag2)
						{
							num = DateTime.Parse(text).CompareTo(DateTime.Parse(text2));
						}
						else
						{
							num = string.Compare(text, text2);
						}
					}
				}
				else
				{
					bool flag2 = Versioned.IsNumeric(text) & Versioned.IsNumeric(text2);
					if (flag2)
					{
						num = Conversion.Val(text2).CompareTo(Conversion.Val(text));
					}
					else
					{
						flag2 = Information.IsDate(text) & Information.IsDate(text2);
						if (flag2)
						{
							num = DateTime.Parse(text2).CompareTo(DateTime.Parse(text));
						}
						else
						{
							num = string.Compare(text2, text);
						}
					}
				}
				return num;
			}

			// Token: 0x04000026 RID: 38
			private int m_ColumnNumber;

			// Token: 0x04000027 RID: 39
			private SortOrder m_SortOrder;
		}
	}
}
