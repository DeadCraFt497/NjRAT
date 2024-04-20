using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My.Resources;

namespace NJRAT
{
	// Token: 0x02000022 RID: 34
	[DesignerGenerated]
	public partial class port : Form
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x0016F998 File Offset: 0x0016DD98
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = __ENCList;
			lock (_ENCList)
			{
				bool flag = __ENCList.Count == __ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = __ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								__ENCList[num] = __ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0016FED8 File Offset: 0x0016E2D8
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x0016FEF0 File Offset: 0x0016E2F0
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
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
				bool flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextChanged -= eventHandler;
				}
				this._TextBox1 = value;
				flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x0016FF50 File Offset: 0x0016E350
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x0016FF68 File Offset: 0x0016E368
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

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x0016FFC8 File Offset: 0x0016E3C8
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x0016FFE0 File Offset: 0x0016E3E0
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

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0016FFEC File Offset: 0x0016E3EC
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00170004 File Offset: 0x0016E404
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

		// Token: 0x060004B5 RID: 1205 RVA: 0x00170064 File Offset: 0x0016E464
		public port()
		{
			base.Activated += this.port_Activated;
			base.KeyDown += this.port_KeyDown;
			base.Load += this.port_Load;
			__ENCAddToList(this);
			this.portVal = -1;
			this.InitializeComponent();
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x001700CC File Offset: 0x0016E4CC
		private void port_Activated(object sender, EventArgs e)
		{
			this.TextBox1.Focus();
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x001700DC File Offset: 0x0016E4DC
		private void port_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				e.SuppressKeyPress = true;
				flag = this.Button1.Enabled;
				if (flag)
				{
					this.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), new EventArgs());
				}
			}
			else
			{
				flag = e.KeyCode == Keys.Escape;
				if (flag)
				{
					this.portVal = -1;
					this.Close();
				}
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0017014C File Offset: 0x0016E54C
		private void Button1_Click(object sender, EventArgs e)
		{
			this.portVal = Conversions.ToInteger(this.TextBox1.Text);
			this.Close();
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00170170 File Offset: 0x0016E570
		private void Button2_Click(object sender, EventArgs e)
		{
			this.portVal = -1;
			this.Close();
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00170184 File Offset: 0x0016E584
		private void port_Load(object sender, EventArgs e)
		{
			this.Icon = NJRAT_Resources.icon;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00170194 File Offset: 0x0016E594
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int num = Conversions.ToInteger(this.TextBox1.Text);
				bool flag = (Conversions.ToInteger(this.TextBox1.Text) > 65534) | (Conversions.ToInteger(this.TextBox1.Text) < 1);
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

		// Token: 0x04000227 RID: 551
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000229 RID: 553
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x0400022A RID: 554
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400022B RID: 555
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400022C RID: 556
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x0400022D RID: 557
		public int portVal;
	}
}
