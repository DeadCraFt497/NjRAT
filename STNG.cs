using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x02000026 RID: 38
	[DesignerGenerated]
	public partial class STNG : Form
	{
		// Token: 0x06000512 RID: 1298 RVA: 0x001732D4 File Offset: 0x001716D4
		[DebuggerNonUserCode]
		public STNG()
		{
			base.Load += this.STNG_Load;
			STNG.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00173300 File Offset: 0x00171700
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = STNG.__ENCList;
			lock (_ENCList)
			{
				bool flag = STNG.__ENCList.Count == STNG.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = STNG.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = STNG.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								STNG.__ENCList[num] = STNG.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					STNG.__ENCList.RemoveRange(num, STNG.__ENCList.Count - num);
					STNG.__ENCList.Capacity = STNG.__ENCList.Count;
				}
				STNG.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00174978 File Offset: 0x00172D78
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00174990 File Offset: 0x00172D90
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

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0017499C File Offset: 0x00172D9C
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x001749B4 File Offset: 0x00172DB4
		internal virtual CheckBox ShowAlert
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShowAlert;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ShowAlert = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x001749C0 File Offset: 0x00172DC0
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x001749D8 File Offset: 0x00172DD8
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

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x001749E4 File Offset: 0x00172DE4
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x001749FC File Offset: 0x00172DFC
		internal virtual CheckBox LOGMSGS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LOGMSGS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LOGMSGS = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00174A08 File Offset: 0x00172E08
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00174A20 File Offset: 0x00172E20
		internal virtual CheckBox LOGRERR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LOGRERR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LOGRERR = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00174A2C File Offset: 0x00172E2C
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00174A44 File Offset: 0x00172E44
		internal virtual CheckBox LOGCONNECTIONS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LOGCONNECTIONS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LOGCONNECTIONS = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00174A50 File Offset: 0x00172E50
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00174A68 File Offset: 0x00172E68
		internal virtual CheckBox LOGLERR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LOGLERR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LOGLERR = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00174A74 File Offset: 0x00172E74
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00174A8C File Offset: 0x00172E8C
		internal virtual CheckBox LOGLOGIN
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LOGLOGIN;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LOGLOGIN = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00174A98 File Offset: 0x00172E98
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00174AB0 File Offset: 0x00172EB0
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

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00174ABC File Offset: 0x00172EBC
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00174AD4 File Offset: 0x00172ED4
		internal virtual CheckBox SCAUT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SCAUT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SCAUT = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00174AE0 File Offset: 0x00172EE0
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00174AF8 File Offset: 0x00172EF8
		internal virtual ComboBox SCI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SCI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SCI = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00174B04 File Offset: 0x00172F04
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00174B1C File Offset: 0x00172F1C
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00174B28 File Offset: 0x00172F28
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00174B40 File Offset: 0x00172F40
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

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00174B4C File Offset: 0x00172F4C
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00174B64 File Offset: 0x00172F64
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

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00174B70 File Offset: 0x00172F70
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00174B88 File Offset: 0x00172F88
		internal virtual ComboBox CAMI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CAMI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CAMI = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00174B94 File Offset: 0x00172F94
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00174BAC File Offset: 0x00172FAC
		internal virtual CheckBox CAMAUT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CAMAUT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CAMAUT = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00174BB8 File Offset: 0x00172FB8
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00174BD0 File Offset: 0x00172FD0
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

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00174BDC File Offset: 0x00172FDC
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00174BF4 File Offset: 0x00172FF4
		internal virtual ComboBox MICI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MICI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MICI = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00174C00 File Offset: 0x00173000
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00174C18 File Offset: 0x00173018
		internal virtual CheckBox MICAUT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MICAUT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MICAUT = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00174C24 File Offset: 0x00173024
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00174C3C File Offset: 0x0017303C
		internal virtual GroupBox GroupBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox6 = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00174C48 File Offset: 0x00173048
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00174C60 File Offset: 0x00173060
		internal virtual ComboBox scrI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._scrI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._scrI = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00174C6C File Offset: 0x0017306C
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00174C84 File Offset: 0x00173084
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

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00174CE4 File Offset: 0x001730E4
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00174CFC File Offset: 0x001730FC
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

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00174D08 File Offset: 0x00173108
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00174D20 File Offset: 0x00173120
		internal virtual CheckBox Snd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Snd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Snd = value;
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00174D2C File Offset: 0x0017312C
		private void STNG_Load(object sender, EventArgs e)
		{
			this.SCAUT.Checked = Class7.class8_0.bool_6;
			this.SCI.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0);
			this.CAMAUT.Checked = Class7.class8_0.bool_7;
			this.CAMI.SelectedIndex = Class7.class8_0.int_0;
			this.MICAUT.Checked = Class7.class8_0.bool_8;
			this.LOGCONNECTIONS.Checked = Class7.class8_0.bool_2;
			this.LOGLERR.Checked = Class7.class8_0.bool_3;
			this.LOGRERR.Checked = Class7.class8_0.bool_4;
			this.LOGMSGS.Checked = Class7.class8_0.bool_5;
			this.LOGLOGIN.Checked = Class7.class8_0.bool_1;
			this.Snd.Checked = Class7.class8_0.bool_9;
			this.ShowAlert.Checked = Class7.class8_0.bool_0;
			this.MICI.SelectedIndex = Class7.class8_0.int_1;
			this.scrI.SelectedIndex = Class7.class8_0.int_2;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00174E74 File Offset: 0x00173274
		private void Button1_Click(object sender, EventArgs e)
		{
			Class7.class8_0.bool_6 = this.SCAUT.Checked;
			Class7.class8_0.string_0 = Conversions.ToString(this.SCI.SelectedIndex);
			Class7.class8_0.bool_7 = this.CAMAUT.Checked;
			Class7.class8_0.int_0 = this.CAMI.SelectedIndex;
			Class7.class8_0.bool_8 = this.MICAUT.Checked;
			Class7.class8_0.bool_2 = this.LOGCONNECTIONS.Checked;
			Class7.class8_0.bool_3 = this.LOGLERR.Checked;
			Class7.class8_0.bool_4 = this.LOGRERR.Checked;
			Class7.class8_0.bool_5 = this.LOGMSGS.Checked;
			Class7.class8_0.bool_1 = this.LOGLOGIN.Checked;
			Class7.class8_0.bool_9 = this.Snd.Checked;
			Class7.class8_0.bool_0 = this.ShowAlert.Checked;
			Class7.class8_0.int_1 = this.MICI.SelectedIndex;
			Class7.class8_0.int_2 = this.scrI.SelectedIndex;
			Class7.class8_0.method_1();
			this.Hide();
		}

		// Token: 0x0400025F RID: 607
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000261 RID: 609
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000262 RID: 610
		[AccessedThroughProperty("ShowAlert")]
		private CheckBox _ShowAlert;

		// Token: 0x04000263 RID: 611
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000264 RID: 612
		[AccessedThroughProperty("LOGMSGS")]
		private CheckBox _LOGMSGS;

		// Token: 0x04000265 RID: 613
		[AccessedThroughProperty("LOGRERR")]
		private CheckBox _LOGRERR;

		// Token: 0x04000266 RID: 614
		[AccessedThroughProperty("LOGCONNECTIONS")]
		private CheckBox _LOGCONNECTIONS;

		// Token: 0x04000267 RID: 615
		[AccessedThroughProperty("LOGLERR")]
		private CheckBox _LOGLERR;

		// Token: 0x04000268 RID: 616
		[AccessedThroughProperty("LOGLOGIN")]
		private CheckBox _LOGLOGIN;

		// Token: 0x04000269 RID: 617
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x0400026A RID: 618
		[AccessedThroughProperty("SCAUT")]
		private CheckBox _SCAUT;

		// Token: 0x0400026B RID: 619
		[AccessedThroughProperty("SCI")]
		private ComboBox _SCI;

		// Token: 0x0400026C RID: 620
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400026D RID: 621
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x0400026E RID: 622
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400026F RID: 623
		[AccessedThroughProperty("CAMI")]
		private ComboBox _CAMI;

		// Token: 0x04000270 RID: 624
		[AccessedThroughProperty("CAMAUT")]
		private CheckBox _CAMAUT;

		// Token: 0x04000271 RID: 625
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x04000272 RID: 626
		[AccessedThroughProperty("MICI")]
		private ComboBox _MICI;

		// Token: 0x04000273 RID: 627
		[AccessedThroughProperty("MICAUT")]
		private CheckBox _MICAUT;

		// Token: 0x04000274 RID: 628
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x04000275 RID: 629
		[AccessedThroughProperty("scrI")]
		private ComboBox _scrI;

		// Token: 0x04000276 RID: 630
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000277 RID: 631
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000278 RID: 632
		[AccessedThroughProperty("Snd")]
		private CheckBox _Snd;
	}
}
