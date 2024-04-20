using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x02000025 RID: 37
	[DesignerGenerated]
	public partial class script : Form
	{
		// Token: 0x06000504 RID: 1284 RVA: 0x00172C18 File Offset: 0x00171018
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = script.__ENCList;
			lock (_ENCList)
			{
				bool flag = script.__ENCList.Count == script.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = script.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = script.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								script.__ENCList[num] = script.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					script.__ENCList.RemoveRange(num, script.__ENCList.Count - num);
					script.__ENCList.Capacity = script.__ENCList.Count;
				}
				script.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00173180 File Offset: 0x00171580
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00173198 File Offset: 0x00171598
		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x001731A4 File Offset: 0x001715A4
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x001731BC File Offset: 0x001715BC
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
				this._TextBox1 = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x001731C8 File Offset: 0x001715C8
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x001731E0 File Offset: 0x001715E0
		internal virtual ComboBox ComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox1 = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x001731EC File Offset: 0x001715EC
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00173204 File Offset: 0x00171604
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= eventHandler;
				}
				this._Button1 = value;
				flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click += eventHandler;
				}
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00173264 File Offset: 0x00171664
		public script()
		{
			script.__ENCAddToList(this);
			this.RunAs = "vbs";
			this.Code = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00173294 File Offset: 0x00171694
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Code = this.TextBox1.Text;
			this.RunAs = this.ComboBox1.Text;
			this.Close();
		}

		// Token: 0x04000256 RID: 598
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000258 RID: 600
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000259 RID: 601
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x0400025A RID: 602
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x0400025B RID: 603
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400025C RID: 604
		public string Code;

		// Token: 0x0400025D RID: 605
		public Form1 F;

		// Token: 0x0400025E RID: 606
		public string RunAs;
	}
}
