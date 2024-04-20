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
	// Token: 0x02000014 RID: 20
	[DesignerGenerated]
	public partial class FURL : Form
	{
		// Token: 0x060002DA RID: 730 RVA: 0x00160050 File Offset: 0x0015E450
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = FURL.__ENCList;
			lock (_ENCList)
			{
				bool flag = FURL.__ENCList.Count == FURL.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = FURL.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = FURL.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								FURL.__ENCList[num] = FURL.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					FURL.__ENCList.RemoveRange(num, FURL.__ENCList.Count - num);
					FURL.__ENCList.Capacity = FURL.__ENCList.Count;
				}
				FURL.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00160648 File Offset: 0x0015EA48
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00160660 File Offset: 0x0015EA60
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0016066C File Offset: 0x0015EA6C
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00160684 File Offset: 0x0015EA84
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00160690 File Offset: 0x0015EA90
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x001606A8 File Offset: 0x0015EAA8
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x001606B4 File Offset: 0x0015EAB4
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x001606CC File Offset: 0x0015EACC
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
				EventHandler eventHandler2 = new EventHandler(this.TextBox1_TextChanged);
				bool flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextAlignChanged -= eventHandler;
					this._TextBox1.TextChanged -= eventHandler2;
				}
				this._TextBox1 = value;
				flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextAlignChanged += eventHandler;
					this._TextBox1.TextChanged += eventHandler2;
				}
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00160754 File Offset: 0x0015EB54
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0016076C File Offset: 0x0015EB6C
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x001607CC File Offset: 0x0015EBCC
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x001607E4 File Offset: 0x0015EBE4
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

		// Token: 0x060002E9 RID: 745 RVA: 0x00160844 File Offset: 0x0015EC44
		public FURL()
		{
			base.KeyDown += this.FURL_KeyDown;
			FURL.__ENCAddToList(this);
			this.IsOK = false;
			this.InitializeComponent();
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00160878 File Offset: 0x0015EC78
		private void FURL_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x001608B0 File Offset: 0x0015ECB0
		private void TextBox1_TextAlignChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x001608B4 File Offset: 0x0015ECB4
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = (this.TextBox1.Text.Length > 0) & this.TextBox1.Text.ToLower().StartsWith("http") & (this.TextBox2.TextLength > 0);
			if (flag)
			{
				this.IsOK = true;
				this.Close();
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00160914 File Offset: 0x0015ED14
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00160920 File Offset: 0x0015ED20
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.TextBox2.Text = Strings.Split(this.TextBox1.Text, ".", -1, CompareMethod.Binary)[Strings.Split(this.TextBox1.Text, ".", -1, CompareMethod.Binary).Length - 1];
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000142 RID: 322
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000144 RID: 324
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000145 RID: 325
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000146 RID: 326
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x04000147 RID: 327
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000148 RID: 328
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000149 RID: 329
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400014A RID: 330
		public bool IsOK;
	}
}
