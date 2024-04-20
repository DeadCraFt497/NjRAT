using System;
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
	// Token: 0x02000012 RID: 18
	[DesignerGenerated]
	public partial class FromLink : Form
	{
		// Token: 0x060001EC RID: 492 RVA: 0x00159184 File Offset: 0x00157584
		[DebuggerNonUserCode]
		public FromLink()
		{
			FromLink.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0015919C File Offset: 0x0015759C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = FromLink.__ENCList;
			lock (_ENCList)
			{
				bool flag = FromLink.__ENCList.Count == FromLink.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = FromLink.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = FromLink.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								FromLink.__ENCList[num] = FromLink.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					FromLink.__ENCList.RemoveRange(num, FromLink.__ENCList.Count - num);
					FromLink.__ENCList.Capacity = FromLink.__ENCList.Count;
				}
				FromLink.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x001597A4 File Offset: 0x00157BA4
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x001597BC File Offset: 0x00157BBC
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0015981C File Offset: 0x00157C1C
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00159834 File Offset: 0x00157C34
		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				bool flag = this._Button2 != null;
				if (flag)
				{
					this._Button2.Click -= eventHandler;
				}
				this._Button2 = value;
				flag = this._Button2 != null;
				if (flag)
				{
					this._Button2.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00159894 File Offset: 0x00157C94
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x001598AC File Offset: 0x00157CAC
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
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextAlignChanged);
				bool flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextAlignChanged -= eventHandler;
				}
				this._TextBox1 = value;
				flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextAlignChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0015990C File Offset: 0x00157D0C
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00159924 File Offset: 0x00157D24
		internal virtual TextBox TextBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00159930 File Offset: 0x00157D30
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00159948 File Offset: 0x00157D48
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00159954 File Offset: 0x00157D54
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0015996C File Offset: 0x00157D6C
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00159978 File Offset: 0x00157D78
		private void Button1_Click(object sender, EventArgs e)
		{
			this.IsOK = true;
			this.Close();
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0015998C File Offset: 0x00157D8C
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00159998 File Offset: 0x00157D98
		private void TextBox1_TextAlignChanged(object sender, EventArgs e)
		{
			try
			{
				this.TextBox2.Text = Strings.Split(this.TextBox1.Text, "\\", -1, CompareMethod.Binary)[Strings.Split(this.TextBox1.Text, "\\", -1, CompareMethod.Binary).Length - 1];
			}
			catch (Exception ex)
			{
				this.TextBox2.Text = "File.txt";
			}
		}

		// Token: 0x040000E3 RID: 227
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000E5 RID: 229
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040000E6 RID: 230
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040000E7 RID: 231
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040000E8 RID: 232
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x040000E9 RID: 233
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040000EA RID: 234
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040000EB RID: 235
		public bool IsOK;
	}
}
