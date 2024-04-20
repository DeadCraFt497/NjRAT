using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My.Resources;

namespace NJRAT
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class About : Form
	{
		// Token: 0x06000098 RID: 152 RVA: 0x0014B500 File Offset: 0x00149900
		[DebuggerNonUserCode]
		public About()
		{
			base.Load += this.About_Load;
			About.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0014B52C File Offset: 0x0014992C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = About.__ENCList;
			lock (_ENCList)
			{
				bool flag = About.__ENCList.Count == About.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = About.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = About.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								About.__ENCList[num] = About.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					About.__ENCList.RemoveRange(num, About.__ENCList.Count - num);
					About.__ENCList.Capacity = About.__ENCList.Count;
				}
				About.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0014B8D0 File Offset: 0x00149CD0
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0014B8E8 File Offset: 0x00149CE8
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0014B8F4 File Offset: 0x00149CF4
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0014B90C File Offset: 0x00149D0C
		internal virtual RichTextBox RichTextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RichTextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RichTextBox1 = value;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0014B918 File Offset: 0x00149D18
		private void About_Load(object sender, EventArgs e)
		{
			this.RichTextBox1.Text = NJRAT_Resources.RichTextBox1;
		}

		// Token: 0x04000047 RID: 71
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000049 RID: 73
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400004A RID: 74
		[AccessedThroughProperty("RichTextBox1")]
		private RichTextBox _RichTextBox1;
	}
}
