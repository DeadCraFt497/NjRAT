using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class DDoS : Form
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00149A80 File Offset: 0x00147E80
		public DDoS()
		{
			DDoS.__ENCAddToList(this);
			this.th = "1";
			this.InitializeComponent();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00149AA4 File Offset: 0x00147EA4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = DDoS.__ENCList;
			lock (_ENCList)
			{
				bool flag = DDoS.__ENCList.Count == DDoS.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = DDoS.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = DDoS.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								DDoS.__ENCList[num] = DDoS.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					DDoS.__ENCList.RemoveRange(num, DDoS.__ENCList.Count - num);
					DDoS.__ENCList.Capacity = DDoS.__ENCList.Count;
				}
				DDoS.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0014ADB4 File Offset: 0x001491B4
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0014ADCC File Offset: 0x001491CC
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0014AE2C File Offset: 0x0014922C
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0014AE44 File Offset: 0x00149244
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0014AE50 File Offset: 0x00149250
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0014AE68 File Offset: 0x00149268
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0014AE74 File Offset: 0x00149274
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0014AE8C File Offset: 0x0014928C
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0014AE98 File Offset: 0x00149298
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0014AEB0 File Offset: 0x001492B0
		internal virtual TrackBar TrackBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TrackBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TrackBar1_Scroll);
				bool flag = this._TrackBar1 != null;
				if (flag)
				{
					this._TrackBar1.Scroll -= eventHandler;
				}
				this._TrackBar1 = value;
				flag = this._TrackBar1 != null;
				if (flag)
				{
					this._TrackBar1.Scroll += eventHandler;
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0014AF10 File Offset: 0x00149310
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0014AF28 File Offset: 0x00149328
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0014AF34 File Offset: 0x00149334
		// (set) Token: 0x0600006B RID: 107 RVA: 0x0014AF4C File Offset: 0x0014934C
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

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0014AF58 File Offset: 0x00149358
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0014AF70 File Offset: 0x00149370
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0014AF7C File Offset: 0x0014937C
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0014AF94 File Offset: 0x00149394
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

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0014AFA0 File Offset: 0x001493A0
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0014AFB8 File Offset: 0x001493B8
		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0014AFC4 File Offset: 0x001493C4
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0014AFDC File Offset: 0x001493DC
		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0014AFE8 File Offset: 0x001493E8
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0014B000 File Offset: 0x00149400
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

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0014B00C File Offset: 0x0014940C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0014B024 File Offset: 0x00149424
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0014B084 File Offset: 0x00149484
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0014B09C File Offset: 0x0014949C
		internal virtual TextBox TextBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox5 = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0014B0A8 File Offset: 0x001494A8
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0014B0C0 File Offset: 0x001494C0
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

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0014B0CC File Offset: 0x001494CC
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0014B0E4 File Offset: 0x001494E4
		internal virtual Button Button3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				bool flag = this._Button3 != null;
				if (flag)
				{
					this._Button3.Click -= eventHandler;
				}
				this._Button3 = value;
				flag = this._Button3 != null;
				if (flag)
				{
					this._Button3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0014B144 File Offset: 0x00149544
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0014B15C File Offset: 0x0014955C
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

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0014B1BC File Offset: 0x001495BC
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0014B1D4 File Offset: 0x001495D4
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0014B1E0 File Offset: 0x001495E0
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0014B1F8 File Offset: 0x001495F8
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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0014B204 File Offset: 0x00149604
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0014B21C File Offset: 0x0014961C
		internal virtual GroupBox GroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0014B228 File Offset: 0x00149628
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0014B240 File Offset: 0x00149640
		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0014B24C File Offset: 0x0014964C
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0014B264 File Offset: 0x00149664
		internal virtual GroupBox GroupBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox5 = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0014B270 File Offset: 0x00149670
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0014B288 File Offset: 0x00149688
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0014B294 File Offset: 0x00149694
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0014B2AC File Offset: 0x001496AC
		internal virtual TextBox TextBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox4 = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0014B2B8 File Offset: 0x001496B8
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0014B2D0 File Offset: 0x001496D0
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0014B2DC File Offset: 0x001496DC
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0014B2F4 File Offset: 0x001496F4
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0014B300 File Offset: 0x00149700
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0014B304 File Offset: 0x00149704
		private void TrackBar1_Scroll(object sender, EventArgs e)
		{
			bool flag = this.TrackBar1.Value == 1;
			if (flag)
			{
				this.th = "1";
			}
			else
			{
				flag = this.TrackBar1.Value == 2;
				if (flag)
				{
					this.th = "10";
				}
				else
				{
					flag = this.TrackBar1.Value == 3;
					if (flag)
					{
						this.th = "30";
					}
					else
					{
						flag = this.TrackBar1.Value == 4;
						if (flag)
						{
							this.th = "50";
						}
						else
						{
							flag = this.TrackBar1.Value == 5;
							if (flag)
							{
								this.th = "70";
							}
							else
							{
								flag = this.TrackBar1.Value == 6;
								if (flag)
								{
									this.th = "100";
								}
								else
								{
									flag = this.TrackBar1.Value == 7;
									if (flag)
									{
										this.th = "150";
									}
									else
									{
										flag = this.TrackBar1.Value == 8;
										if (flag)
										{
											this.th = "250";
										}
										else
										{
											flag = this.TrackBar1.Value == 9;
											if (flag)
											{
												this.th = "400";
											}
											else
											{
												flag = this.TrackBar1.Value == 10;
												if (flag)
												{
													this.th = "500";
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0014B45C File Offset: 0x0014985C
		private void Timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0014B460 File Offset: 0x00149860
		private void Button3_Click(object sender, EventArgs e)
		{
			this.TextBox5.Text = this.TextBox1.Text;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0014B47C File Offset: 0x0014987C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				string text = ((IPAddress)Dns.GetHostByName(this.TextBox3.Text).AddressList.GetValue(0)).ToString();
				this.TextBox5.Text = text;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Error", MsgBoxStyle.Information, null);
			}
		}

		// Token: 0x04000028 RID: 40
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400002A RID: 42
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400002B RID: 43
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x0400002C RID: 44
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x0400002D RID: 45
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x0400002E RID: 46
		[AccessedThroughProperty("TrackBar1")]
		private TrackBar _TrackBar1;

		// Token: 0x0400002F RID: 47
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000030 RID: 48
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000031 RID: 49
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000032 RID: 50
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000033 RID: 51
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000034 RID: 52
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x04000036 RID: 54
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000037 RID: 55
		[AccessedThroughProperty("TextBox5")]
		private TextBox _TextBox5;

		// Token: 0x04000038 RID: 56
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000039 RID: 57
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x0400003A RID: 58
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x0400003B RID: 59
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400003C RID: 60
		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		// Token: 0x0400003D RID: 61
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x0400003E RID: 62
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x0400003F RID: 63
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x04000040 RID: 64
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000041 RID: 65
		[AccessedThroughProperty("TextBox4")]
		private TextBox _TextBox4;

		// Token: 0x04000042 RID: 66
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000043 RID: 67
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000044 RID: 68
		public int sock;

		// Token: 0x04000045 RID: 69
		private string th;

		// Token: 0x04000046 RID: 70
		public object pcat;
	}
}
