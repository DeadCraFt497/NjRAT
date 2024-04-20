using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x02000046 RID: 70
	public sealed class Pp1 : PictureBox
	{
		// Token: 0x0600060B RID: 1547 RVA: 0x00147E18 File Offset: 0x00146218
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Pp1.__ENCList;
			lock (_ENCList)
			{
				bool flag = Pp1.__ENCList.Count == Pp1.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Pp1.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Pp1.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Pp1.__ENCList[num] = Pp1.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Pp1.__ENCList.RemoveRange(num, Pp1.__ENCList.Count - num);
					Pp1.__ENCList.Capacity = Pp1.__ENCList.Count;
				}
				Pp1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00147F1C File Offset: 0x0014631C
		public Pp1()
		{
			Pp1.__ENCAddToList(this);
			this.font = new Font("arial", 8f, FontStyle.Bold);
			this.Lines = new List<object[]>();
			Timer timer = new Timer
			{
				Interval = 50,
				Enabled = false
			};
			this.T = timer;
			this.SizeMode = PictureBoxSizeMode.Normal;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00147F84 File Offset: 0x00146384
		[CompilerGenerated]
		[DebuggerStepThrough]
		private void ksh__4(object a0, EventArgs a1)
		{
			try
			{
				this.wrk();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00147FC0 File Offset: 0x001463C0
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
					int height = TextRenderer.MeasureText("test", this.font).Height;
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
									Size size = TextRenderer.MeasureText(text2, this.font);
									this.G.DrawString(text2, this.font, new Pen(color).Brush, (float)num2, (float)num);
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

		// Token: 0x0600060F RID: 1551 RVA: 0x0014829C File Offset: 0x0014669C
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

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00148304 File Offset: 0x00146704
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x0014831C File Offset: 0x0014671C
		public Timer T
		{
			get
			{
				return this._T;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ksh__4);
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

		// Token: 0x04000354 RID: 852
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000355 RID: 853
		private Timer _T;

		// Token: 0x04000356 RID: 854
		public Font font;

		// Token: 0x04000357 RID: 855
		public Graphics G;

		// Token: 0x04000358 RID: 856
		public List<object[]> Lines;
	}
}
