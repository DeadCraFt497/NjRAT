using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x02000030 RID: 48
	public sealed class GClass3
	{
		// Token: 0x06000594 RID: 1428 RVA: 0x00143FFC File Offset: 0x001423FC
		public GClass3(string string_3)
			: this(string_3, GClass3.int_20)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00144010 File Offset: 0x00142410
		public GClass3(string string_3, int int_26)
		{
			this.fileStream_0 = null;
			this.gclass5_0 = null;
			this.object_0 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(new object())));
			this.byte_0 = Convert.ToByte(GClass5.int_0);
			this.int_3 = 0;
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
				object obj = objectValue;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				lock (obj)
				{
					this.fileStream_0 = new FileStream(string_3, FileMode.Open, FileAccess.Read);
				}
				this.int_2 = int_26;
				this.method_0();
			}
			catch (SystemException ex)
			{
				Console.Write("cannot open file " + string_3 + "\n");
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0014410C File Offset: 0x0014250C
		private void method_0()
		{
			byte[] array = new byte[3];
			byte[] array2 = new byte[GClass3.int_9 - 1 + 1 - 1 + 1];
			this.byte_0 = (byte)GClass5.int_0;
			this.int_1 = GClass3.int_10;
			object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
			ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
			object obj = objectValue;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			lock (obj)
			{
				this.fileStream_0.Seek(-3L, SeekOrigin.End);
				int num = GClass3.int_6 - 1;
				bool flag;
				for (int i = 0; i <= num; i++)
				{
					this.fileStream_0.Read(array, 0, 3);
					flag = array[0] == byte.MaxValue && array[1] == byte.MaxValue && array[2] == byte.MaxValue;
					if (flag)
					{
						this.byte_0 = Convert.ToByte(this.fileStream_0.ReadByte());
						flag = this.byte_0 >= 106;
						if (flag)
						{
							this.byte_0 -= 105;
						}
						flag = (int)this.byte_0 == GClass5.int_1;
						if (flag)
						{
							this.int_0 = new int[] { GClass3.int_15 };
							this.int_1 = GClass3.int_10;
						}
						else
						{
							flag = (int)this.byte_0 == GClass5.int_2;
							if (flag)
							{
								this.int_0 = new int[] { GClass3.int_16 };
								this.int_1 = GClass3.int_10;
							}
							else
							{
								bool flag2;
								if ((int)this.byte_0 != GClass5.int_3 && (int)this.byte_0 != GClass5.int_4)
								{
									if ((int)this.byte_0 != GClass5.int_5 && (int)this.byte_0 != GClass5.int_14)
									{
										if ((int)this.byte_0 != GClass5.int_6 && (int)this.byte_0 != GClass5.int_13)
										{
											if ((int)this.byte_0 != GClass5.int_8 && (int)this.byte_0 != GClass5.int_12)
											{
												if ((int)this.byte_0 != GClass5.int_18 && (int)this.byte_0 != GClass5.int_19)
												{
													if ((int)this.byte_0 != GClass5.int_17 && (int)this.byte_0 != GClass5.int_16)
													{
														flag2 = false;
														goto IL_215;
													}
												}
											}
										}
									}
								}
								flag2 = true;
								IL_215:
								flag = flag2;
								if (flag)
								{
									this.int_0 = new int[] { 0 };
									bool flag3;
									if ((int)this.byte_0 != GClass5.int_3 && (int)this.byte_0 != GClass5.int_4)
									{
										if ((int)this.byte_0 != GClass5.int_12 && (int)this.byte_0 != GClass5.int_18)
										{
											if ((int)this.byte_0 != GClass5.int_19 && (int)this.byte_0 != GClass5.int_17)
											{
												if ((int)this.byte_0 != GClass5.int_16 && (int)this.byte_0 != GClass5.int_8)
												{
													flag3 = false;
													goto IL_2A5;
												}
											}
										}
									}
									flag3 = true;
									IL_2A5:
									flag = flag3;
									if (flag)
									{
										this.int_1 = GClass3.int_10;
									}
									else
									{
										this.int_1 = GClass3.int_11;
									}
									this.fileStream_0.Read(array2, 0, GClass3.int_9);
									int num2 = GClass3.int_9 - 1;
									for (int j = 0; j <= num2; j++)
									{
										int num3 = 0;
										this.int_0[num3] = this.int_0[num3] + (GClass3.smethod_2(array2[j]) << j * 8);
									}
								}
							}
						}
						break;
					}
					this.fileStream_0.Seek(-4L, SeekOrigin.Current);
				}
				bool flag4;
				if ((int)this.byte_0 != GClass5.int_0 && (int)this.byte_0 != GClass5.int_11)
				{
					if ((int)this.byte_0 != GClass5.int_7 && (int)this.byte_0 != GClass5.int_9)
					{
						flag4 = false;
						goto IL_388;
					}
				}
				flag4 = true;
				IL_388:
				flag = flag4;
				if (flag)
				{
					this.int_0 = new int[] { GClass3.int_4 };
					this.int_1 = GClass3.int_10;
				}
				flag = (this.int_2 & GClass3.int_21) == 1;
				if (flag)
				{
					int num4 = (int)this.fileStream_0.Length;
					this.byte_1 = new byte[num4 - 1 + 1 - 1 + 1];
					this.fileStream_0.Seek(0L, SeekOrigin.Begin);
					this.fileStream_0.Read(this.byte_1, 0, num4);
				}
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00144554 File Offset: 0x00142954
		public void method_1()
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
				object obj = objectValue;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				lock (obj)
				{
					this.fileStream_0.Close();
				}
				this.fileStream_0 = null;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x001445EC File Offset: 0x001429EC
		public GClass5 method_10()
		{
			bool flag = this.gclass5_0 != null;
			GClass5 gclass;
			if (flag)
			{
				gclass = this.gclass5_0;
			}
			else
			{
				try
				{
					object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
					object obj = objectValue;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						bool flag2 = false;
						byte[] array = new byte[3];
						this.fileStream_0.Seek(-3L, SeekOrigin.End);
						int num = GClass3.int_6 - 1;
						for (int i = 0; i <= num; i++)
						{
							this.fileStream_0.Read(array, 0, 3);
							flag = array[0] == byte.MaxValue && array[1] == byte.MaxValue && array[2] == byte.MaxValue;
							if (flag)
							{
								flag2 = true;
								break;
							}
							this.fileStream_0.Seek(-4L, SeekOrigin.Current);
						}
						flag = flag2;
						if (flag)
						{
							this.fileStream_0.Seek(-6L, SeekOrigin.Current);
						}
						else
						{
							this.fileStream_0.Seek(-3L, SeekOrigin.End);
						}
						int num2 = GClass3.int_7 - 1;
						for (int j = 0; j <= num2; j++)
						{
							this.fileStream_0.Read(array, 0, 3);
							flag = array[0] == 0 && array[1] == 0 && array[2] == 0;
							if (flag)
							{
								byte[] array2 = new byte[j - 1 + 1 - 1 + 1];
								char[] array3 = new char[j - 1 + 1 - 1 + 1];
								this.fileStream_0.Read(array2, 0, j);
								int num3 = j - 1;
								for (int k = 0; k <= num3; k++)
								{
									array3[k] = Convert.ToChar(array2[k]);
								}
								this.gclass5_0 = new GClass5(new string(array3));
								return this.gclass5_0;
							}
							this.fileStream_0.Seek(-4L, SeekOrigin.Current);
						}
					}
				}
				catch (Exception ex)
				{
					Exception ex2 = ex;
					Console.Write(ex2.Message);
				}
				gclass = new GClass5(string.Empty);
			}
			return gclass;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00144860 File Offset: 0x00142C60
		public GClass6 method_11(IPAddress ipaddress_0)
		{
			return this.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress_0.GetAddressBytes())));
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00144888 File Offset: 0x00142C88
		public GClass6 method_12(string string_3)
		{
			IPAddress ipaddress;
			try
			{
				ipaddress = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return null;
			}
			return this.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress.GetAddressBytes())));
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00144900 File Offset: 0x00142D00
		public string method_13(IPAddress ipaddress_0)
		{
			return this.method_17(GClass3.smethod_1(ipaddress_0.GetAddressBytes()));
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00144924 File Offset: 0x00142D24
		public string method_14(string string_3)
		{
			IPAddress ipaddress;
			try
			{
				ipaddress = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return null;
			}
			return this.method_16(ipaddress);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0014498C File Offset: 0x00142D8C
		public string method_15(string string_3)
		{
			IPAddress ipaddress;
			try
			{
				ipaddress = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return null;
			}
			return this.method_17(GClass3.smethod_1(ipaddress.GetAddressBytes()));
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00144A00 File Offset: 0x00142E00
		[MethodImpl(MethodImplOptions.Synchronized)]
		public string method_16(IPAddress ipaddress_0)
		{
			int num = 0;
			byte[] array = new byte[GClass3.int_13 - 1 + 1 - 1 + 1];
			char[] array2 = new char[GClass3.int_13 - 1 + 1 - 1 + 1];
			string text;
			try
			{
				int num2 = this.method_18(ipaddress_0);
				bool flag = num2 == this.int_0[0];
				if (flag)
				{
					return null;
				}
				int num3 = num2 + (2 * this.int_1 - 1) * this.int_0[0];
				flag = (this.int_2 & GClass3.int_21) == 1;
				if (flag)
				{
					Array.Copy(this.byte_1, num3, array, 0, Math.Min(this.byte_1.Length - num3, GClass3.int_13));
				}
				else
				{
					object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
					object obj = objectValue;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						this.fileStream_0.Seek((long)num3, SeekOrigin.Begin);
						this.fileStream_0.Read(array, 0, GClass3.int_13);
					}
				}
				while (array[num] != 0)
				{
					array2[num] = Convert.ToChar(array[num]);
					num++;
				}
				array2[num] = '\0';
				text = new string(array2, 0, num);
			}
			catch (IOException ex)
			{
				Console.Write("IO Exception");
				text = null;
			}
			return text;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00144BAC File Offset: 0x00142FAC
		[MethodImpl(MethodImplOptions.Synchronized)]
		public string method_17(long long_0)
		{
			int num = 0;
			byte[] array = new byte[GClass3.int_13 - 1 + 1 - 1 + 1];
			char[] array2 = new char[GClass3.int_13 - 1 + 1 - 1 + 1];
			string text;
			try
			{
				int num2 = this.method_19(long_0);
				bool flag = num2 == this.int_0[0];
				if (flag)
				{
					return null;
				}
				int num3 = num2 + (2 * this.int_1 - 1) * this.int_0[0];
				flag = (this.int_2 & GClass3.int_21) == 1;
				if (flag)
				{
					Array.Copy(this.byte_1, num3, array, 0, Math.Min(this.byte_1.Length - num3, GClass3.int_13));
				}
				else
				{
					object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
					object obj = objectValue;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						this.fileStream_0.Seek((long)num3, SeekOrigin.Begin);
						this.fileStream_0.Read(array, 0, GClass3.int_13);
					}
				}
				while (array[num] != 0)
				{
					array2[num] = Convert.ToChar(array[num]);
					num++;
				}
				array2[num] = '\0';
				text = new string(array2, 0, num);
			}
			catch (IOException ex)
			{
				Console.Write("IO Exception");
				text = null;
			}
			return text;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00144D58 File Offset: 0x00143158
		[MethodImpl(MethodImplOptions.Synchronized)]
		private int method_18(IPAddress ipaddress_0)
		{
			byte[] addressBytes = ipaddress_0.GetAddressBytes();
			byte[] array = new byte[2 * GClass3.int_12 - 1 + 1 - 1 + 1];
			int[] array2 = new int[2];
			int num = 0;
			int num2 = 127;
			for (;;)
			{
				bool flag;
				try
				{
					flag = (this.int_2 & GClass3.int_21) == 1;
					if (flag)
					{
						int num3 = 2 * GClass3.int_12 - 1;
						for (int i = 0; i <= num3; i++)
						{
							array[i] = this.byte_1[i + 2 * this.int_1 * num];
						}
					}
					else
					{
						object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
						object obj = objectValue;
						ObjectFlowControl.CheckForSyncLockOnValueType(obj);
						lock (obj)
						{
							this.fileStream_0.Seek((long)(2 * this.int_1 * num), SeekOrigin.Begin);
							this.fileStream_0.Read(array, 0, 2 * GClass3.int_12);
						}
					}
				}
				catch (IOException ex)
				{
					Console.Write("IO Exception");
				}
				int num4 = 0;
				do
				{
					array2[num4] = 0;
					int num5 = this.int_1 - 1;
					for (int j = 0; j <= num5; j++)
					{
						int num6 = (int)array[num4 * this.int_1 + j];
						flag = num6 < 0;
						if (flag)
						{
							num6 += 256;
						}
						int num7 = num4;
						array2[num7] += num6 << j * 8;
					}
					num4++;
				}
				while (num4 <= 1);
				int num8 = 127 - num2;
				int num9 = num8 >> 3;
				int num10 = 1 << ((num8 & 7) ^ 7);
				flag = ((int)addressBytes[num9] & num10) > 0;
				if (flag)
				{
					bool flag2 = array2[1] >= this.int_0[0];
					if (flag2)
					{
						break;
					}
					num = array2[1];
				}
				else
				{
					bool flag2 = array2[0] >= this.int_0[0];
					if (flag2)
					{
						goto Block_7;
					}
					num = array2[0];
				}
				num2 += -1;
				if (num2 < 0)
				{
					goto Block_8;
				}
			}
			return array2[1];
			Block_7:
			return array2[0];
			Block_8:
			Console.Write("Error Seeking country while Seeking " + Convert.ToString(ipaddress_0));
			return 0;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00144FC8 File Offset: 0x001433C8
		[MethodImpl(MethodImplOptions.Synchronized)]
		private int method_19(long long_0)
		{
			byte[] array = new byte[2 * GClass3.int_12 - 1 + 1 - 1 + 1];
			int[] array2 = new int[2];
			int num = 0;
			int num2 = 31;
			for (;;)
			{
				bool flag;
				try
				{
					flag = (this.int_2 & GClass3.int_21) == 1;
					if (flag)
					{
						int num3 = 2 * GClass3.int_12 - 1;
						for (int i = 0; i <= num3; i++)
						{
							array[i] = this.byte_1[i + 2 * this.int_1 * num];
						}
					}
					else
					{
						object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
						object obj = objectValue;
						ObjectFlowControl.CheckForSyncLockOnValueType(obj);
						lock (obj)
						{
							this.fileStream_0.Seek((long)(2 * this.int_1 * num), SeekOrigin.Begin);
							this.fileStream_0.Read(array, 0, 2 * GClass3.int_12);
						}
					}
				}
				catch (IOException ex)
				{
					Console.Write("IO Exception");
				}
				int num4 = 0;
				do
				{
					array2[num4] = 0;
					int num5 = this.int_1 - 1;
					for (int j = 0; j <= num5; j++)
					{
						int num6 = (int)array[num4 * this.int_1 + j];
						flag = num6 < 0;
						if (flag)
						{
							num6 += 256;
						}
						int num7 = num4;
						array2[num7] += num6 << j * 8;
					}
					num4++;
				}
				while (num4 <= 1);
				flag = (long_0 & (1L << (num2 & 31))) > 0L;
				if (flag)
				{
					bool flag2 = array2[1] >= this.int_0[0];
					if (flag2)
					{
						break;
					}
					num = array2[1];
				}
				else
				{
					bool flag2 = array2[0] >= this.int_0[0];
					if (flag2)
					{
						goto Block_7;
					}
					num = array2[0];
				}
				num2 += -1;
				if (num2 < 0)
				{
					goto Block_8;
				}
			}
			return array2[1];
			Block_7:
			return array2[0];
			Block_8:
			Console.Write("Error Seeking country while Seeking " + Conversions.ToString(long_0));
			return 0;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00145218 File Offset: 0x00143618
		public GClass4 method_2(IPAddress ipaddress_0)
		{
			return this.method_6(GClass3.smethod_1(ipaddress_0.GetAddressBytes()));
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0014523C File Offset: 0x0014363C
		public GClass4 method_3(string string_3)
		{
			IPAddress ipaddress;
			try
			{
				ipaddress = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return GClass3.gclass4_0;
			}
			return this.method_5(ipaddress);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x001452AC File Offset: 0x001436AC
		public GClass4 method_4(string string_3)
		{
			IPAddress ipaddress;
			try
			{
				ipaddress = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return GClass3.gclass4_0;
			}
			return this.method_6(GClass3.smethod_1(ipaddress.GetAddressBytes()));
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00145328 File Offset: 0x00143728
		public GClass4 method_5(IPAddress ipaddress_0)
		{
			bool flag = this.fileStream_0 == null;
			if (flag)
			{
				throw new Exception("Database has been closed.");
			}
			flag = ((int)this.byte_0 == GClass5.int_4) | ((int)this.byte_0 == GClass5.int_3);
			GClass4 gclass2;
			if (flag)
			{
				GClass6 gclass = this.method_11(ipaddress_0);
				flag = gclass == null;
				if (flag)
				{
					gclass2 = GClass3.gclass4_0;
				}
				else
				{
					gclass2 = new GClass4(gclass.string_0, gclass.string_1);
				}
			}
			else
			{
				int num = this.method_18(ipaddress_0) - GClass3.int_4;
				flag = num == 0;
				if (flag)
				{
					gclass2 = GClass3.gclass4_0;
				}
				else
				{
					gclass2 = new GClass4(GClass3.string_1[num], GClass3.string_2[num]);
				}
			}
			return gclass2;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x001453D4 File Offset: 0x001437D4
		public GClass4 method_6(long long_0)
		{
			bool flag = this.fileStream_0 == null;
			if (flag)
			{
				throw new Exception("Database has been closed.");
			}
			flag = ((int)this.byte_0 == GClass5.int_4) | ((int)this.byte_0 == GClass5.int_3);
			GClass4 gclass2;
			if (flag)
			{
				GClass6 gclass = this.method_12(Conversions.ToString(long_0));
				flag = gclass == null;
				if (flag)
				{
					gclass2 = GClass3.gclass4_0;
				}
				else
				{
					gclass2 = new GClass4(gclass.string_0, gclass.string_1);
				}
			}
			else
			{
				int num = this.method_19(long_0) - GClass3.int_4;
				flag = num == 0;
				if (flag)
				{
					gclass2 = GClass3.gclass4_0;
				}
				else
				{
					gclass2 = new GClass4(GClass3.string_1[num], GClass3.string_2[num]);
				}
			}
			return gclass2;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00145484 File Offset: 0x00143884
		public int method_7(string string_3)
		{
			IPAddress ipaddress;
			try
			{
				ipaddress = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return 0;
			}
			return this.method_9(GClass3.smethod_1(ipaddress.GetAddressBytes()));
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x001454F8 File Offset: 0x001438F8
		public int method_8(IPAddress ipaddress_0)
		{
			return this.method_9(GClass3.smethod_1(ipaddress_0.GetAddressBytes()));
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0014551C File Offset: 0x0014391C
		public int method_9(long long_0)
		{
			bool flag = this.fileStream_0 == null;
			if (flag)
			{
				throw new Exception("Database has been closed.");
			}
			return this.method_19(long_0) - this.int_0[0];
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00145558 File Offset: 0x00143958
		private static long smethod_0(long long_0)
		{
			return (((long_0 >> 0) & 255L) << 24) | (((long_0 >> 8) & 255L) << 16) | (((long_0 >> 16) & 255L) << 8) | (((long_0 >> 24) & 255L) << 0);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x001455A4 File Offset: 0x001439A4
		private static long smethod_1(byte[] byte_2)
		{
			long num = 0L;
			int num2 = 0;
			do
			{
				long num3 = (long)((ulong)byte_2[num2]);
				bool flag = num3 < 0L;
				if (flag)
				{
					num3 += 256L;
				}
				num += num3 << (3 - num2) * 8;
				num2++;
			}
			while (num2 <= 3);
			return num;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x001455F8 File Offset: 0x001439F8
		private static int smethod_2(byte byte_2)
		{
			return (int)(byte_2 & byte.MaxValue);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00145614 File Offset: 0x00143A14
		private static T smethod_3<T>(ref T gparam_0, T gparam_1)
		{
			gparam_0 = gparam_1;
			return gparam_1;
		}

		// Token: 0x040002D5 RID: 725
		private byte byte_0;

		// Token: 0x040002D6 RID: 726
		private byte[] byte_1;

		// Token: 0x040002D7 RID: 727
		private FileStream fileStream_0;

		// Token: 0x040002D8 RID: 728
		private static GClass4 gclass4_0 = new GClass4("--", "N/A");

		// Token: 0x040002D9 RID: 729
		private GClass5 gclass5_0;

		// Token: 0x040002DA RID: 730
		private int[] int_0;

		// Token: 0x040002DB RID: 731
		private int int_1;

		// Token: 0x040002DC RID: 732
		private static int int_10 = 3;

		// Token: 0x040002DD RID: 733
		private static int int_11 = 4;

		// Token: 0x040002DE RID: 734
		private static int int_12 = 4;

		// Token: 0x040002DF RID: 735
		private static int int_13 = 1000;

		// Token: 0x040002E0 RID: 736
		private static int int_14 = 360;

		// Token: 0x040002E1 RID: 737
		private static int int_15 = 16700000;

		// Token: 0x040002E2 RID: 738
		private static int int_16 = 16000000;

		// Token: 0x040002E3 RID: 739
		private static int int_17 = 1;

		// Token: 0x040002E4 RID: 740
		private static int int_18 = 677;

		// Token: 0x040002E5 RID: 741
		private static int int_19 = 1353;

		// Token: 0x040002E6 RID: 742
		private int int_2;

		// Token: 0x040002E7 RID: 743
		public static int int_20 = 0;

		// Token: 0x040002E8 RID: 744
		public static int int_21 = 1;

		// Token: 0x040002E9 RID: 745
		public static int int_22 = 0;

		// Token: 0x040002EA RID: 746
		public static int int_23 = 1;

		// Token: 0x040002EB RID: 747
		public static int int_24 = 2;

		// Token: 0x040002EC RID: 748
		public static int int_25 = 3;

		// Token: 0x040002ED RID: 749
		private int int_3;

		// Token: 0x040002EE RID: 750
		private static int int_4 = 16776960;

		// Token: 0x040002EF RID: 751
		private static int int_5 = 16700000;

		// Token: 0x040002F0 RID: 752
		private static int int_6 = 20;

		// Token: 0x040002F1 RID: 753
		private static int int_7 = 100;

		// Token: 0x040002F2 RID: 754
		private static int int_8 = 100;

		// Token: 0x040002F3 RID: 755
		private static int int_9 = 3;

		// Token: 0x040002F4 RID: 756
		private object object_0;

		// Token: 0x040002F5 RID: 757
		private string string_0;

		// Token: 0x040002F6 RID: 758
		public static string[] string_1 = new string[]
		{
			"--", "AP", "EU", "AD", "AE", "AF", "AG", "AI", "AL", "AM",
			"CW", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA",
			"BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN",
			"BO", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC",
			"CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO",
			"CR", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM",
			"DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI",
			"FJ", "FK", "FM", "FO", "FR", "SX", "GA", "GB", "GD", "GE",
			"GF", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS",
			"GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU",
			"ID", "IE", "IL", "IN", "IO", "IQ", "IR", "IS", "IT", "JM",
			"JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR",
			"KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS",
			"LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MH", "MK",
			"ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU",
			"MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG",
			"NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE",
			"PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT",
			"PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC",
			"SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN",
			"SO", "SR", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG",
			"TH", "TJ", "TK", "TM", "TN", "TO", "TL", "TR", "TT", "TV",
			"TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC",
			"VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "RS",
			"ZA", "ZM", "ME", "ZW", "A1", "A2", "O1", "AX", "GG", "IM",
			"JE", "BL", "MF", "BQ", "SS", "O1"
		};

		// Token: 0x040002F7 RID: 759
		private static string[] string_2 = new string[]
		{
			"N/A", "Asia/Pacific Region", "Europe", "Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia",
			"Curacao", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Azerbaijan", "Bosnia and Herzegovina",
			"Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Bermuda", "Brunei Darussalam",
			"Bolivia", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos (Keeling) Islands",
			"Congo, The Democratic Republic of the", "Central African Republic", "Congo", "Switzerland", "Cote D'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia",
			"Costa Rica", "Cuba", "Cape Verde", "Christmas Island", "Cyprus", "Czech Republic", "Germany", "Djibouti", "Denmark", "Dominica",
			"Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland",
			"Fiji", "Falkland Islands (Malvinas)", "Micronesia, Federated States of", "Faroe Islands", "France", "Sint Maarten (Dutch part)", "Gabon", "United Kingdom", "Grenada", "Georgia",
			"French Guiana", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands",
			"Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary",
			"Indonesia", "Ireland", "Israel", "India", "British Indian Ocean Territory", "Iraq", "Iran, Islamic Republic of", "Iceland", "Italy", "Jamaica",
			"Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts and Nevis", "Korea, Democratic People's Republic of", "Korea, Republic of",
			"Kuwait", "Cayman Islands", "Kazakhstan", "Lao People's Democratic Republic", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho",
			"Lithuania", "Luxembourg", "Latvia", "Libya", "Morocco", "Monaco", "Moldova, Republic of", "Madagascar", "Marshall Islands", "Macedonia",
			"Mali", "Myanmar", "Mongolia", "Macau", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius",
			"Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria",
			"Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru",
			"French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn Islands", "Puerto Rico", "Palestinian Territory", "Portugal",
			"Palau", "Paraguay", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles",
			"Sudan", "Sweden", "Singapore", "Saint Helena", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal",
			"Somalia", "Suriname", "Sao Tome and Principe", "El Salvador", "Syrian Arab Republic", "Swaziland", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo",
			"Thailand", "Tajikistan", "Tokelau", "Turkmenistan", "Tunisia", "Tonga", "Timor-Leste", "Turkey", "Trinidad and Tobago", "Tuvalu",
			"Taiwan", "Tanzania, United Republic of", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States", "Uruguay", "Uzbekistan", "Holy See (Vatican City State)", "Saint Vincent and the Grenadines",
			"Venezuela", "Virgin Islands, British", "Virgin Islands, U.S.", "Vietnam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "Serbia",
			"South Africa", "Zambia", "Montenegro", "Zimbabwe", "Anonymous Proxy", "Satellite Provider", "Other", "Aland Islands", "Guernsey", "Isle of Man",
			"Jersey", "Saint Barthelemy", "Saint Martin", "Bonaire, Saint Eustatius and Saba", "South Sudan", "Other"
		};
	}
}
