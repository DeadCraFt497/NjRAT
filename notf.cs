using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My;

namespace NJRAT
{
	// Token: 0x0200001D RID: 29
	[DesignerGenerated]
	public partial class notf : Form
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x0016C060 File Offset: 0x0016A460
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = notf.__ENCList;
			lock (_ENCList)
			{
				bool flag = notf.__ENCList.Count == notf.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = notf.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = notf.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								notf.__ENCList[num] = notf.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					notf.__ENCList.RemoveRange(num, notf.__ENCList.Count - num);
					notf.__ENCList.Capacity = notf.__ENCList.Count;
				}
				notf.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0016C320 File Offset: 0x0016A720
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0016C338 File Offset: 0x0016A738
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
				EventHandler eventHandler = new EventHandler(this.p_Click);
				bool flag = this._p != null;
				if (flag)
				{
					this._p.Click -= eventHandler;
				}
				this._p = value;
				flag = this._p != null;
				if (flag)
				{
					this._p.Click += eventHandler;
				}
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0016C398 File Offset: 0x0016A798
		public notf()
		{
			base.Load += this.notf_Load;
			notf.__ENCAddToList(this);
			base.Load += this.notf_Load;
			this.bool_0 = true;
			this.Items = new List<notf.GClass15>();
			this.InitializeComponent();
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0016C3F8 File Offset: 0x0016A7F8
		public void AddItem(Bitmap img, string Text)
		{
			bool flag = !Class7.class8_0.bool_9;
			if (!flag)
			{
				MyProject.Computer.Audio.Play("Sound/Sound.wav", AudioPlayMode.Background);
			}
			List<notf.GClass15> items = this.Items;
			List<notf.GClass15> list = items;
			lock (list)
			{
				flag = this.Items.Count > 50;
				if (flag)
				{
					this.Items.RemoveAt(0);
				}
				notf.GClass15 gclass = new notf.GClass15
				{
					bitmap_0 = (Bitmap)img.Clone(),
					string_0 = Text
				};
				this.Items.Add(gclass);
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0016C4B4 File Offset: 0x0016A8B4
		public void back()
		{
			this.bool_0 = true;
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			this.Left = workingArea.Width - this.Width - 5;
			this.Top = workingArea.Height - this.Height - 5;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0016C504 File Offset: 0x0016A904
		public void go()
		{
			this.bool_0 = false;
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			this.Left = workingArea.Width;
			this.Top = workingArea.Height;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0016C544 File Offset: 0x0016A944
		private void p_Click(object sender, EventArgs e)
		{
			List<notf.GClass15> items = this.Items;
			List<notf.GClass15> list = items;
			lock (list)
			{
				this.Items.Clear();
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0016C58C File Offset: 0x0016A98C
		private void notf_Load(object sender, EventArgs e)
		{
			this.p.BackColor = Color.Pink;
			this.TransparencyKey = Color.Pink;
			this.back();
			Control.CheckForIllegalCrossThreadCalls = false;
			Thread thread = new Thread(new ThreadStart(this.wrk));
			thread.Start();
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0016C5E0 File Offset: 0x0016A9E0
		public void wrk()
		{
			for (;;)
			{
				Thread.Sleep(80);
				bool flag = this.Items.Count == 0;
				if (flag)
				{
					this.go();
				}
				else
				{
					try
					{
						Bitmap bitmap = new Bitmap(this.p.Width, this.p.Height);
						Graphics graphics = Graphics.FromImage(bitmap);
						graphics.Clear(this.p.BackColor);
						List<notf.GClass15> items = this.Items;
						List<notf.GClass15> list = items;
						lock (list)
						{
							try
							{
								foreach (notf.GClass15 gclass in this.Items)
								{
									flag = gclass.int_0 <= 2;
									if (flag)
									{
										gclass.int_0 = 2;
										notf.GClass15 gclass2 = gclass;
										notf.GClass15 gclass3 = gclass2;
										gclass3.int_1++;
									}
									else
									{
										int count = this.Items.Count;
										flag = count > 30;
										if (flag)
										{
											gclass.int_0 = 2;
										}
										else
										{
											flag = count > 20;
											if (flag)
											{
												notf.GClass15 gclass2 = gclass;
												gclass2.int_0 += -20;
											}
											else
											{
												flag = count > 10;
												if (flag)
												{
													notf.GClass15 gclass2 = gclass;
													gclass2.int_0 += -10;
												}
												else
												{
													notf.GClass15 gclass2 = gclass;
													gclass2.int_0 += -2;
												}
											}
										}
										flag = gclass.int_0 < 2;
										if (flag)
										{
											gclass.int_0 = 2;
										}
									}
									Size size = TextRenderer.MeasureText(gclass.string_0, this.Font);
									size.Width = bitmap.Width;
									size.Height += 5;
									Rectangle rectangle = new Rectangle(0, gclass.int_0 - 2, this.Width, size.Height);
									graphics.FillRectangle(Brushes.Black, rectangle);
									rectangle = new Rectangle(0, gclass.int_0 - 2, this.Width, size.Height);
									ControlPaint.DrawLockedFrame(graphics, rectangle, false);
									object[] array = new object[2];
									array[0] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(gclass.bitmap_0.Clone())));
									Point point = new Point(5, gclass.int_0 - 2);
									array[1] = point;
									NewLateBinding.LateCall(graphics, null, "DrawImage", array, null, null, null, true);
									graphics.DrawString(gclass.string_0, this.Font, Brushes.LimeGreen, 5f, (float)gclass.int_0);
									flag = gclass.int_0 > this.Height - 50;
									if (flag)
									{
										break;
									}
								}
							}
							finally
							{
							
							}
							for (;;)
							{
								IL_29E:
								try
								{
									foreach (notf.GClass15 gclass4 in this.Items)
									{
										flag = gclass4.int_1 == 40;
										if (flag)
										{
											this.Items.Remove(gclass4);
											goto IL_29E;
										}
									}
								}
								finally
								{
									
								}
								break;
							}
							flag = (this.Items.Count == 0) & this.bool_0;
							if (flag)
							{
								this.go();
							}
							flag = (this.Items.Count > 0) & !this.bool_0;
							if (flag)
							{
								this.back();
							}
						}
						graphics.Flush(FlushIntention.Sync);
						graphics.Dispose();
						this.p.Image = bitmap;
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x040001F2 RID: 498
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040001F4 RID: 500
		[AccessedThroughProperty("p")]
		private PictureBox _p;

		// Token: 0x040001F5 RID: 501
		public bool su;

		// Token: 0x040001F6 RID: 502
		private bool bool_0;

		// Token: 0x040001F7 RID: 503
		public List<notf.GClass15> Items;

		// Token: 0x0200001E RID: 30
		public sealed class GClass15
		{
			// Token: 0x06000443 RID: 1091 RVA: 0x0016C9F0 File Offset: 0x0016ADF0
			public GClass15()
			{
				this.int_0 = MyProject.Forms.notf.Height;
				this.int_1 = 0;
			}

			// Token: 0x040001F8 RID: 504
			public Bitmap bitmap_0;

			// Token: 0x040001F9 RID: 505
			public int int_0;

			// Token: 0x040001FA RID: 506
			public int int_1;

			// Token: 0x040001FB RID: 507
			public string string_0;
		}
	}
}
