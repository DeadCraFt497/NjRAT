using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x02000036 RID: 54
	public sealed class GClass8 : PictureBox
	{
		// Token: 0x060005BE RID: 1470 RVA: 0x001459F0 File Offset: 0x00143DF0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = GClass8.__ENCList;
			lock (_ENCList)
			{
				bool flag = GClass8.__ENCList.Count == GClass8.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = GClass8.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = GClass8.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								GClass8.__ENCList[num] = GClass8.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					GClass8.__ENCList.RemoveRange(num, GClass8.__ENCList.Count - num);
					GClass8.__ENCList.Capacity = GClass8.__ENCList.Count;
				}
				GClass8.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00145AF4 File Offset: 0x00143EF4
		public GClass8()
		{
			GClass8.__ENCAddToList(this);
			this.fonty = new Font("arial", 8f, FontStyle.Bold);
			this.Lines = new List<object[]>();
			Timer timer = new Timer
			{
				Interval = 50,
				Enabled = false
			};
			this.T = timer;
			this.SizeMode = PictureBoxSizeMode.Normal;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00145B5C File Offset: 0x00143F5C
		[DebuggerStepThrough]
		[CompilerGenerated]
		private void lam__4(object a0, EventArgs a1)
		{
			try
			{
				this.wrk();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00145B98 File Offset: 0x00143F98
		public void wrk()
		{
			try
			{
				this.T.Enabled = false;
				lock (this)
				{
					Bitmap bitmap = new Bitmap(this.Width, this.Height);
					this.G = Graphics.FromImage(bitmap);
					this.G.Clear(Color.Black);
					int num = 3;
					int height = TextRenderer.MeasureText("test", this.Font).Height;
					Color color = Color.White;
					for (int i = this.Lines.Count - 1; i >= 0; i += -1)
					{
						int num2 = 3;
						object[] array = this.Lines[i];
						int num3 = array.Length - 1;
						for (int j = 0; j <= num3; j++)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[j])))))));
							string text = objectValue.GetType().ToString();
							bool flag = Operators.CompareString(text, typeof(Bitmap).ToString(), false) == 0;
							if (flag)
							{
								Bitmap bitmap2 = (Bitmap)objectValue;
								flag = bitmap2.Height > height;
								if (flag)
								{
									IntPtr intPtr = IntPtr.Zero;
									bitmap2 = (Bitmap)bitmap2.GetThumbnailImage(height, height, null, intPtr);
								}
								this.G.DrawImage(bitmap2, num2, num);
								num2 += bitmap2.Width + 3;
							}
							else
							{
								flag = Operators.CompareString(text, typeof(string).ToString(), false) == 0;
								if (flag)
								{
									string text2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))));
									Size size = TextRenderer.MeasureText(text2, this.Font);
									this.G.DrawString(text2, this.Font, new Pen(color).Brush, (float)num2, (float)num);
									flag = size.Height - height > 0;
									if (flag)
									{
										num += size.Height - height;
										num2 = 3;
									}
									else
									{
										num2 += size.Width + 3;
									}
								}
								else
								{
									flag = Operators.CompareString(text, typeof(Color).ToString(), false) == 0;
									if (flag)
									{
										color = (Color)objectValue;
									}
								}
							}
						}
						num += height;
					}
					this.G.Dispose();
					this.Image = bitmap;
				}
				this.T.Enabled = true;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00145E74 File Offset: 0x00144274
		public void WRT(params object[] A)
		{
			lock (this)
			{
				this.Lines.Add(A);
				bool flag = this.Lines.Count == 100;
				if (flag)
				{
					this.Lines.RemoveAt(0);
				}
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00145EDC File Offset: 0x001442DC
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00145EF4 File Offset: 0x001442F4
		public Timer T
		{
			get
			{
				return this._T;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lam__4);
				bool flag = this._T != null;
				if (flag)
				{
					this._T.Tick -= eventHandler;
				}
				this._T = value;
				flag = this._T != null;
				if (flag)
				{
					this._T.Tick += eventHandler;
				}
			}
		}

		// Token: 0x0400031F RID: 799
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000320 RID: 800
		private Timer _T;

		// Token: 0x04000321 RID: 801
		public Font fonty;

		// Token: 0x04000322 RID: 802
		public Graphics G;

		// Token: 0x04000323 RID: 803
		public List<object[]> Lines;
	}
}
