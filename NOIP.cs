using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x0200001B RID: 27
	[DesignerGenerated]
	public partial class NOIP : Form
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x0016ACAC File Offset: 0x001690AC
		[DebuggerNonUserCode]
		public NOIP()
		{
			NOIP.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0016ACC4 File Offset: 0x001690C4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = NOIP.__ENCList;
			lock (_ENCList)
			{
				bool flag = NOIP.__ENCList.Count == NOIP.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = NOIP.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = NOIP.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								NOIP.__ENCList[num] = NOIP.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					NOIP.__ENCList.RemoveRange(num, NOIP.__ENCList.Count - num);
					NOIP.__ENCList.Capacity = NOIP.__ENCList.Count;
				}
				NOIP.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0016B52C File Offset: 0x0016992C
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0016B544 File Offset: 0x00169944
		internal virtual LinkLabel LinkLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
				bool flag = this._LinkLabel1 != null;
				if (flag)
				{
					this._LinkLabel1.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel1 = value;
				flag = this._LinkLabel1 != null;
				if (flag)
				{
					this._LinkLabel1.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0016B5A4 File Offset: 0x001699A4
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x0016B5BC File Offset: 0x001699BC
		internal virtual RichTextBox RichTextBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RichTextBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RichTextBox2 = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0016B5C8 File Offset: 0x001699C8
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x0016B5E0 File Offset: 0x001699E0
		internal virtual RichTextBox RichTextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RichTextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RichTextBox1 = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0016B5EC File Offset: 0x001699EC
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0016B604 File Offset: 0x00169A04
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0016B664 File Offset: 0x00169A64
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0016B67C File Offset: 0x00169A7C
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

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0016B688 File Offset: 0x00169A88
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x0016B6A0 File Offset: 0x00169AA0
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0016B6AC File Offset: 0x00169AAC
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x0016B6C4 File Offset: 0x00169AC4
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

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0016B6D0 File Offset: 0x00169AD0
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x0016B6E8 File Offset: 0x00169AE8
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

		// Token: 0x06000427 RID: 1063 RVA: 0x0016B6F4 File Offset: 0x00169AF4
		private void Button1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			UTF8Encoding utf8Encoding = new UTF8Encoding();
			string @string = utf8Encoding.GetString(webClient.DownloadData(string.Concat(new string[]
			{
				"http://dynupdate.no-ip.com/dns?username=",
				this.TextBox1.Text,
				"&password=",
				this.TextBox2.Text,
				"&hostname=",
				this.TextBox3.Text
			})));
			string[] array = @string.Split(new char[] { ':' });
			this.RichTextBox1.Text = array[1];
			bool flag = array[1].Contains("0");
			if (flag)
			{
				this.RichTextBox2.Text = "Success - IP address is current, no update performed";
			}
			flag = array[1].Contains("1");
			if (flag)
			{
				this.RichTextBox2.Text = "Success - DNS hostname update successful";
			}
			flag = array[1].Contains("2");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - Hostname supplied does not exist";
			}
			flag = array[1].Contains("3");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - Invalid username";
			}
			flag = array[1].Contains("4");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - Invalid password";
			}
			flag = array[1].Contains("5");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - Too many updates sent. Updates are blocked   until 1 hour passes since last status of 5 returned.";
			}
			flag = array[1].Contains("6");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - Account disabled due to violation of No-IP   terms of service. Our terms of service can be viewed at   http://www.no-ip.com/legal/tos";
			}
			flag = array[1].Contains("7");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - Invalid IP. Invalid IP submitted is   improperly formated, is a private LAN RFC 1918 address, or an abuse   blacklisted address.";
			}
			flag = array[1].Contains("8");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - Disabled / Locked hostname";
			}
			flag = array[1].Contains("9");
			if (flag)
			{
				this.RichTextBox2.Text = "Host updated is configured as a web redirect and no update was performed.";
			}
			flag = array[1].Contains("10");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - Group supplied does not exist";
			}
			flag = array[1].Contains("11");
			if (flag)
			{
				this.RichTextBox2.Text = "Success - DNS group update is successful";
			}
			flag = array[1].Contains("12");
			if (flag)
			{
				this.RichTextBox2.Text = "Success - DNS group is current, no update performed.";
			}
			flag = array[1].Contains("13");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - Update client support not available for supplied hostname or group";
			}
			flag = array[1].Contains("14");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - Hostname supplied does not have offline   settings configured. Returned if sending offline=YES on a host that  does  not have any offline actions configured.";
			}
			flag = array[1].Contains("99");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - Client disabled. Client should exit and not   perform any more updates without user intervention.";
			}
			flag = array[1].Contains("100");
			if (flag)
			{
				this.RichTextBox2.Text = "Error - User input error usually returned if missing required request parameters";
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0016BA14 File Offset: 0x00169E14
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.noip.com");
		}

		// Token: 0x040001E1 RID: 481
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040001E3 RID: 483
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		// Token: 0x040001E4 RID: 484
		[AccessedThroughProperty("RichTextBox2")]
		private RichTextBox _RichTextBox2;

		// Token: 0x040001E5 RID: 485
		[AccessedThroughProperty("RichTextBox1")]
		private RichTextBox _RichTextBox1;

		// Token: 0x040001E6 RID: 486
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040001E7 RID: 487
		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		// Token: 0x040001E8 RID: 488
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x040001E9 RID: 489
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040001EA RID: 490
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;
	}
}
