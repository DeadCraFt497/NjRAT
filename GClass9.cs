using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x02000037 RID: 55
	[DesignerGenerated]
	public sealed class GClass9 : ListView
	{
		// Token: 0x060005C6 RID: 1478 RVA: 0x00145F64 File Offset: 0x00144364
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = GClass9.__ENCList;
			lock (_ENCList)
			{
				bool flag = GClass9.__ENCList.Count == GClass9.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = GClass9.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = GClass9.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								GClass9.__ENCList[num] = GClass9.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					GClass9.__ENCList.RemoveRange(num, GClass9.__ENCList.Count - num);
					GClass9.__ENCList.Capacity = GClass9.__ENCList.Count;
				}
				GClass9.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00146068 File Offset: 0x00144468
		public GClass9()
		{
			GClass9.__ENCAddToList(this);
			base.ParentChanged += this.GClass9_ParentChanged;
			base.MouseMove += this.GClass9_MouseMove;
			base.MouseUp += this.GClass9_MouseUp;
			base.ColumnClick += this.GClass9_ColumnClick;
			base.KeyDown += this.GClass9_KeyDown;
			base.MouseDown += this.GClass9_MouseDown;
			this.listViewItem_0 = null;
			this.point_0 = Point.Empty;
			this.point_1 = Point.Empty;
			this.AllowDrop = false;
			this.Font = new Font("arial", 8f, FontStyle.Bold);
			this.Dock = DockStyle.Fill;
			this.FullRowSelect = true;
			this.View = View.Details;
			this.OwnerDraw = true;
			this.SetStyle(ControlStyles.UserPaint, false);
			this.DoubleBuffered = true;
			this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.SetStyle(ControlStyles.EnableNotifyMessage, true);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00146184 File Offset: 0x00144584
		[CompilerGenerated]
		[DebuggerStepThrough]
		private void lam__3(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00146190 File Offset: 0x00144590
		[CompilerGenerated]
		[DebuggerStepThrough]
		private void lam__4(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0014619C File Offset: 0x0014459C
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.icontainer_0 != null;
				if (flag)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x001461EC File Offset: 0x001445EC
		public void GClass9_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			lock (this)
			{
				bool flag = e.Column != -1;
				if (flag)
				{
					try
					{
						ColumnHeader columnHeader = (ColumnHeader)NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(sender), null, "Columns", new object[] { e.Column }, null, null, null);
						flag = this.columnHeader_0 == null;
						SortOrder sortOrder;
						bool flag2;
						if (flag)
						{
							sortOrder = SortOrder.Ascending;
							columnHeader.Tag = "+";
						}
						else
						{
							flag = columnHeader.Equals(this.columnHeader_0);
							if (flag)
							{
								flag2 = Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(this.columnHeader_0.Tag), "+", false);
								if (flag2)
								{
									sortOrder = SortOrder.Descending;
									this.columnHeader_0.Tag = "-";
								}
								else
								{
									this.columnHeader_0.Tag = "+";
									sortOrder = SortOrder.Ascending;
								}
							}
							else
							{
								sortOrder = SortOrder.Ascending;
							}
						}
						this.columnHeader_0 = columnHeader;
						flag2 = this.columnHeader_0.Tag == null;
						if (flag2)
						{
							this.columnHeader_0.Tag = "+";
						}
						flag2 = sender != null;
						if (flag2)
						{
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), null, "ListViewItemSorter", new object[]
							{
								new GClass9.GClass10(e.Column, sortOrder)
							}, null, null);
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(sender), null, "Sort", new object[0], null, null, null, true);
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), null, "ListViewItemSorter", new object[] { null }, null, null);
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x001463E0 File Offset: 0x001447E0
		private void GClass9_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Space;
			if (flag)
			{
				this.method_3();
			}
			flag = (e.KeyCode == Keys.A) & e.Control;
			if (flag)
			{
				try
				{
					foreach (object obj in this.Items)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						listViewItem.Selected = true;
					}
				}
				finally
				{
					
				}
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00146478 File Offset: 0x00144878
		private void GClass9_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				this.listViewItem_0 = this.GetItemAt(e.X, e.Y);
				this.point_0 = e.Location;
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x001464C0 File Offset: 0x001448C0
		private void GClass9_MouseMove(object sender, MouseEventArgs e)
		{
			this.point_1 = e.Location;
			bool flag = this.point_0 != Point.Empty;
			if (flag)
			{
				bool flag2 = this.listViewItem_0 != null && this.listViewItem_0.Index == -1;
				if (flag2)
				{
					this.listViewItem_0 = null;
				}
				flag2 = ((e.Button == MouseButtons.Left) & (this.listViewItem_0 != null)) && this.listViewItem_0 != null;
				if (flag2)
				{
					ListViewItem itemAt = this.GetItemAt(e.X, e.Y);
					flag2 = itemAt != null;
					if (flag2)
					{
						flag = itemAt.Index > this.listViewItem_0.Index;
						if (flag)
						{
							int index = itemAt.Index;
							for (int i = this.listViewItem_0.Index; i <= index; i++)
							{
								flag2 = !this.SelectedIndices.Contains(i);
								if (flag2)
								{
									this.SelectedIndices.Add(i);
								}
							}
							try
							{
								foreach (object obj in this.SelectedIndices)
								{
									object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj)));
									flag2 = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue), this.listViewItem_0.Index, false)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue), itemAt.Index, false)))));
									if (flag2)
									{
										this.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue)));
									}
								}
								return;
							}
							finally
							{
								
							}
						}
						int index2 = this.listViewItem_0.Index;
						for (int j = itemAt.Index; j <= index2; j++)
						{
							flag2 = !this.SelectedIndices.Contains(j);
							if (flag2)
							{
								this.SelectedIndices.Add(j);
							}
						}
						try
						{
							foreach (object obj2 in this.SelectedIndices)
							{
								object objectValue2 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj2)));
								flag2 = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue2), itemAt.Index, false)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue2), this.listViewItem_0.Index, false)))));
								if (flag2)
								{
									this.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue2)));
								}
							}
						}
						finally
						{
							
						}
					}
				}
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x001467E4 File Offset: 0x00144BE4
		private void GClass9_MouseUp(object sender, MouseEventArgs e)
		{
			this.listViewItem_0 = null;
			this.point_0 = Point.Empty;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x001467FC File Offset: 0x00144BFC
		private void GClass9_ParentChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.Parent != null;
				if (flag)
				{
					this.Parent.Resize -= this.lam__3;
				}
				this.Parent.Resize += this.lam__4;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00146880 File Offset: 0x00144C80
		[DebuggerStepThrough]
		private void method_0()
		{
			this.icontainer_0 = new Container();
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00146890 File Offset: 0x00144C90
		public void method_1()
		{
			this.method_3();
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0014689C File Offset: 0x00144C9C
		public ListViewItem[] method_2()
		{
			ListViewItem[] array;
			lock (this)
			{
				List<ListViewItem> list = new List<ListViewItem>();
				bool flag = this.Items.Count == 0;
				if (flag)
				{
					return list.ToArray();
				}
				try
				{
					ListViewItem listViewItem = this.TopItem;
					list.Add(listViewItem);
					int num = this.Items.Count - 1;
					for (int i = listViewItem.Index + 1; i <= num; i++)
					{
						try
						{
							listViewItem = this.Items[i];
							flag = this.Bounds.IntersectsWith(this.Items[i].Bounds);
							if (!flag)
							{
								break;
							}
							list.Add(listViewItem);
						}
						catch (Exception ex)
						{
							break;
						}
					}
				}
				catch (Exception ex2)
				{
				}
				array = list.ToArray();
			}
			return array;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00146A20 File Offset: 0x00144E20
		public void method_3()
		{
			try
			{
				bool flag = this.Columns.Count != 0;
				if (flag)
				{
					bool flag2 = this.Items.Count == 0;
					if (flag2)
					{
						this.Columns[this.Columns.Count - 1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
					}
					else
					{
						int num = this.Columns.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							this.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00146AE4 File Offset: 0x00144EE4
		protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs drawListViewColumnHeaderEventArgs_0)
		{
			try
			{
				StringFormat stringFormat = new StringFormat
				{
					FormatFlags = StringFormatFlags.NoWrap,
					Trimming = StringTrimming.EllipsisCharacter,
					Alignment = StringAlignment.Near,
					LineAlignment = StringAlignment.Near
				};
				Rectangle rectangle = new Rectangle(drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.Width, drawListViewColumnHeaderEventArgs_0.Bounds.Height);
				drawListViewColumnHeaderEventArgs_0.Graphics.FillRectangle(new Pen(ControlPaint.Light(this.BackColor, 0.1f)).Brush, rectangle);
				drawListViewColumnHeaderEventArgs_0.Graphics.DrawString(drawListViewColumnHeaderEventArgs_0.Header.Text, this.Font, new Pen(this.ForeColor).Brush, drawListViewColumnHeaderEventArgs_0.Bounds, stringFormat);
				drawListViewColumnHeaderEventArgs_0.Graphics.DrawLine(new Pen(this.ForeColor), drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y + drawListViewColumnHeaderEventArgs_0.Bounds.Height);
				drawListViewColumnHeaderEventArgs_0.DrawDefault = false;
			}
			catch (Exception ex)
			{
			}
			base.OnDrawColumnHeader(drawListViewColumnHeaderEventArgs_0);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00146C74 File Offset: 0x00145074
		protected override void OnDrawItem(DrawListViewItemEventArgs drawListViewItemEventArgs_0)
		{
			drawListViewItemEventArgs_0.DrawDefault = true;
			base.OnDrawItem(drawListViewItemEventArgs_0);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00146C88 File Offset: 0x00145088
		protected override void OnDrawSubItem(DrawListViewSubItemEventArgs drawListViewSubItemEventArgs_0)
		{
			drawListViewSubItemEventArgs_0.DrawDefault = true;
			base.OnDrawSubItem(drawListViewSubItemEventArgs_0);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00146C9C File Offset: 0x0014509C
		protected override void OnNotifyMessage(Message message_0)
		{
			bool flag = message_0.Msg != 20;
			if (flag)
			{
				base.OnNotifyMessage(message_0);
			}
		}

		// Token: 0x04000324 RID: 804
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000325 RID: 805
		public ColumnHeader columnHeader_0;

		// Token: 0x04000326 RID: 806
		private IContainer icontainer_0;

		// Token: 0x04000327 RID: 807
		private ListViewItem listViewItem_0;

		// Token: 0x04000328 RID: 808
		private Point point_0;

		// Token: 0x04000329 RID: 809
		private Point point_1;

		// Token: 0x02000038 RID: 56
		public sealed class GClass10 : IComparer
		{
			// Token: 0x060005D9 RID: 1497 RVA: 0x00146CC8 File Offset: 0x001450C8
			public GClass10(int int_1, SortOrder sortOrder_1)
			{
				this.int_0 = int_1;
				this.sortOrder_0 = sortOrder_1;
			}

			// Token: 0x060005DA RID: 1498 RVA: 0x00146CE4 File Offset: 0x001450E4
			public int Compare(object object_0, object object_1)
			{
				ListViewItem listViewItem = (ListViewItem)object_0;
				ListViewItem listViewItem2 = (ListViewItem)object_1;
				bool flag = listViewItem.SubItems.Count <= this.int_0;
				string text;
				if (flag)
				{
					text = string.Empty;
				}
				else
				{
					text = listViewItem.SubItems[this.int_0].Text;
				}
				flag = listViewItem2.SubItems.Count <= this.int_0;
				string text2;
				if (flag)
				{
					text2 = string.Empty;
				}
				else
				{
					text2 = listViewItem2.SubItems[this.int_0].Text;
				}
				flag = this.sortOrder_0 == SortOrder.Ascending;
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

			// Token: 0x060005DB RID: 1499 RVA: 0x00146E60 File Offset: 0x00145260
			public int Compare1(object x, object y)
			{
				int num = 0;
				return num;
			}

			// Token: 0x0400032A RID: 810
			private int int_0;

			// Token: 0x0400032B RID: 811
			private SortOrder sortOrder_0;
		}
	}
}
