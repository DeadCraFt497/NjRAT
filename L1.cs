using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x02000040 RID: 64
	public sealed class L1 : DataGridView
	{
		// Token: 0x060005E9 RID: 1513 RVA: 0x001472D8 File Offset: 0x001456D8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = L1.__ENCList;
			lock (_ENCList)
			{
				bool flag = L1.__ENCList.Count == L1.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = L1.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = L1.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								L1.__ENCList[num] = L1.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					L1.__ENCList.RemoveRange(num, L1.__ENCList.Count - num);
					L1.__ENCList.Capacity = L1.__ENCList.Count;
				}
				L1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x001473DC File Offset: 0x001457DC
		public L1()
		{
			L1.__ENCAddToList(this);
			this.collection_0 = new Collection();
			this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.RowHeadersVisible = false;
			this.DoubleBuffered = true;
			this.ShowCellErrors = true;
			this.ShowEditingIcon = true;
			this.ShowRowErrors = true;
			this.Font = new Font("arial", 8f, FontStyle.Bold);
			this.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.EnableNotifyMessage | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00147470 File Offset: 0x00145870
		public DataGridViewRow method_0(int int_0)
		{
			return (DataGridViewRow)this.collection_0[int_0 + 1];
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00147498 File Offset: 0x00145898
		public DataGridViewRow method_1(string string_0)
		{
			return (DataGridViewRow)this.collection_0[string_0];
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x001474BC File Offset: 0x001458BC
		public void method_10(int int_0)
		{
			bool invokeRequired = this.InvokeRequired;
			if (invokeRequired)
			{
				Collection collection = this.collection_0;
				Collection collection2 = collection;
				lock (collection2)
				{
					this.Invoke(new L1.Delegate4(this.method_10), new object[] { int_0 });
					return;
				}
			}
			this.Rows.RemoveAt(int_0);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0014753C File Offset: 0x0014593C
		public void method_11(string string_0, L1.GEnum0 genum0_0, DataGridViewAutoSizeColumnMode dataGridViewAutoSizeColumnMode_0)
		{
			Collection collection = this.collection_0;
			Collection collection2 = collection;
			lock (collection2)
			{
				DataGridViewColumn dataGridViewColumn = null;
				switch (genum0_0)
				{
				case L1.GEnum0.Text:
					dataGridViewColumn = new DataGridViewTextBoxColumn();
					break;
				case L1.GEnum0.Link:
					dataGridViewColumn = new DataGridViewLinkColumn();
					break;
				case L1.GEnum0.Image:
				{
					DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn
					{
						ImageLayout = DataGridViewImageCellLayout.Zoom
					};
					dataGridViewColumn = dataGridViewImageColumn;
					break;
				}
				case L1.GEnum0.StretchImage:
				{
					DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn
					{
						ImageLayout = DataGridViewImageCellLayout.Stretch
					};
					dataGridViewColumn = dataGridViewImageColumn;
					break;
				}
				}
				dataGridViewColumn.AutoSizeMode = dataGridViewAutoSizeColumnMode_0;
				dataGridViewColumn.Tag = genum0_0;
				dataGridViewColumn.HeaderText = string_0;
				this.Columns.Add(dataGridViewColumn);
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00147610 File Offset: 0x00145A10
		public bool method_2(string string_0)
		{
			return this.collection_0.Contains(string_0);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00147630 File Offset: 0x00145A30
		public DataGridViewRow[] method_3()
		{
			List<DataGridViewRow> list = new List<DataGridViewRow>();
			bool flag = this.RowCount == 0;
			DataGridViewRow[] array;
			if (flag)
			{
				array = list.ToArray();
			}
			else
			{
				try
				{
					int num = this.FirstDisplayedScrollingRowIndex + this.DisplayedRowCount(false);
					for (int i = this.FirstDisplayedScrollingRowIndex; i <= num; i++)
					{
						flag = i > this.RowCount - 1;
						if (flag)
						{
							break;
						}
						try
						{
							list.Add(this.Rows[i]);
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

		// Token: 0x060005F1 RID: 1521 RVA: 0x00147728 File Offset: 0x00145B28
		public void method_4()
		{
			Collection collection = this.collection_0;
			Collection collection2 = collection;
			lock (collection2)
			{
				this.Rows.Clear();
				this.collection_0.Clear();
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0014777C File Offset: 0x00145B7C
		public DataGridViewRow method_5(object[] object_0)
		{
			bool invokeRequired = this.InvokeRequired;
			if (invokeRequired)
			{
				Collection collection = this.collection_0;
				Collection collection2 = collection;
				lock (collection2)
				{
					return (DataGridViewRow)this.Invoke(new L1.Delegate1(this.method_5), object_0);
				}
			}
			DataGridViewRow dataGridViewRow = new DataGridViewRow();
			int num = this.ColumnCount - 1;
			for (int i = 0; i <= num; i++)
			{
				switch (Conversions.ToInteger(RuntimeHelpers.GetObjectValue(this.Columns[i].Tag)))
				{
				case 0:
				{
					DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])))
					};
					dataGridViewRow.Cells.Add(dataGridViewTextBoxCell);
					break;
				}
				case 1:
				{
					DataGridViewLinkCell dataGridViewLinkCell = new DataGridViewLinkCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])))
					};
					dataGridViewRow.Cells.Add(dataGridViewLinkCell);
					break;
				}
				case 2:
				{
					DataGridViewImageCell dataGridViewImageCell = new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))),
						ImageLayout = DataGridViewImageCellLayout.Normal
					};
					dataGridViewRow.Cells.Add(dataGridViewImageCell);
					break;
				}
				case 3:
				{
					DataGridViewImageCell dataGridViewImageCell = new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))),
						ImageLayout = DataGridViewImageCellLayout.Stretch
					};
					dataGridViewRow.Cells.Add(dataGridViewImageCell);
					break;
				}
				}
			}
			dataGridViewRow.Resizable = DataGridViewTriState.False;
			this.collection_0.Add(dataGridViewRow, null, null, null);
			this.Rows.Add(dataGridViewRow);
			return dataGridViewRow;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00147978 File Offset: 0x00145D78
		public int method_6()
		{
			return this.RowTemplate.Height;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00147998 File Offset: 0x00145D98
		public void method_7(int int_0)
		{
			this.RowTemplate.Height = int_0;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x001479AC File Offset: 0x00145DAC
		public DataGridViewRow method_8(string string_0, object[] object_0)
		{
			bool invokeRequired = this.InvokeRequired;
			if (invokeRequired)
			{
				Collection collection = this.collection_0;
				Collection collection2 = collection;
				lock (collection2)
				{
					return (DataGridViewRow)this.Invoke(new L1.Delegate2(this.method_8), new object[] { string_0, object_0 });
				}
			}
			DataGridViewRow dataGridViewRow = new DataGridViewRow
			{
				Height = this.method_6()
			};
			int num = this.ColumnCount - 1;
			for (int i = 0; i <= num; i++)
			{
				switch (Conversions.ToInteger(RuntimeHelpers.GetObjectValue(this.Columns[i].Tag)))
				{
				case 0:
				{
					DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])))
					};
					dataGridViewRow.Cells.Add(dataGridViewTextBoxCell);
					break;
				}
				case 1:
				{
					DataGridViewLinkCell dataGridViewLinkCell = new DataGridViewLinkCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])))
					};
					dataGridViewRow.Cells.Add(dataGridViewLinkCell);
					break;
				}
				case 2:
				{
					DataGridViewImageCell dataGridViewImageCell = new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))),
						ImageLayout = DataGridViewImageCellLayout.Zoom
					};
					dataGridViewRow.Cells.Add(dataGridViewImageCell);
					break;
				}
				case 3:
				{
					DataGridViewImageCell dataGridViewImageCell = new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))),
						ImageLayout = DataGridViewImageCellLayout.Stretch
					};
					dataGridViewRow.Cells.Add(dataGridViewImageCell);
					break;
				}
				}
			}
			dataGridViewRow.Resizable = DataGridViewTriState.False;
			this.collection_0.Add(dataGridViewRow, string_0, null, null);
			this.Rows.Add(dataGridViewRow);
			return dataGridViewRow;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00147BD0 File Offset: 0x00145FD0
		public void method_9(DataGridViewRow dataGridViewRow_0)
		{
			bool invokeRequired = this.InvokeRequired;
			if (invokeRequired)
			{
				Collection collection = this.collection_0;
				Collection collection2 = collection;
				lock (collection2)
				{
					this.Invoke(new L1.Delegate3(this.method_9), new object[] { dataGridViewRow_0 });
					return;
				}
			}
			this.Rows.Remove(dataGridViewRow_0);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00147C48 File Offset: 0x00146048
		protected override void OnMouseUp(MouseEventArgs mouseEventArgs_0)
		{
			bool flag = mouseEventArgs_0.Button == MouseButtons.Right;
			if (flag)
			{
				try
				{
					DataGridView.HitTestInfo hitTestInfo = this.HitTest(mouseEventArgs_0.X, mouseEventArgs_0.Y);
					flag = hitTestInfo.RowIndex != -1;
					if (flag)
					{
						DataGridViewRow dataGridViewRow = this.Rows[hitTestInfo.RowIndex];
						flag = !dataGridViewRow.Selected;
						if (flag)
						{
							this.ClearSelection();
							dataGridViewRow.Selected = true;
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
			base.OnMouseUp(mouseEventArgs_0);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00147CF4 File Offset: 0x001460F4
		protected override void OnMouseWheel(MouseEventArgs mouseEventArgs_0)
		{
			base.OnMouseWheel(mouseEventArgs_0);
			try
			{
				int delta = mouseEventArgs_0.Delta;
				bool flag = delta == 120;
				if (flag)
				{
					this.FirstDisplayedScrollingRowIndex = Math.Max(0, this.FirstDisplayedScrollingRowIndex - SystemInformation.MouseWheelScrollLines);
				}
				else
				{
					flag = delta == -120;
					if (flag)
					{
						this.FirstDisplayedScrollingRowIndex += SystemInformation.MouseWheelScrollLines;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00147D8C File Offset: 0x0014618C
		protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs dataGridViewRowPostPaintEventArgs_0)
		{
			try
			{
				DataGridViewRow dataGridViewRow = this.Rows[dataGridViewRowPostPaintEventArgs_0.RowIndex];
				bool flag = dataGridViewRow.Height != this.method_6();
				if (flag)
				{
					dataGridViewRow.Height = this.method_6();
				}
			}
			catch (Exception ex)
			{
			}
			base.OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0);
		}

		// Token: 0x0400034D RID: 845
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400034E RID: 846
		private Collection collection_0;

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060005FD RID: 1533
		private delegate DataGridViewRow Delegate1(object[] object_0);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000601 RID: 1537
		private delegate DataGridViewRow Delegate2(string string_0, object[] object_0);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000605 RID: 1541
		private delegate void Delegate3(DataGridViewRow dataGridViewRow_0);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000609 RID: 1545
		private delegate void Delegate4(int int_0);

		// Token: 0x02000045 RID: 69
		public enum GEnum0
		{
			// Token: 0x04000350 RID: 848
			Image = 2,
			// Token: 0x04000351 RID: 849
			Link = 1,
			// Token: 0x04000352 RID: 850
			StretchImage = 3,
			// Token: 0x04000353 RID: 851
			Text = 0
		}
	}
}
