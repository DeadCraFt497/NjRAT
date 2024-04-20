using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.My;

namespace NJRAT
{
	// Token: 0x02000028 RID: 40
	internal sealed class Class6
	{
		// Token: 0x0600055E RID: 1374 RVA: 0x0013A808 File Offset: 0x00138C08
		[DebuggerNonUserCode]
		public Class6()
		{
		}

		// Token: 0x0600055F RID: 1375
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr memcpy(IntPtr intptr_0, IntPtr intptr_1, int int_0);

		// Token: 0x06000560 RID: 1376 RVA: 0x0013A814 File Offset: 0x00138C14
		public static string smethod_0(int int_0, int int_1)
		{
			bool flag = int_1 == 0;
			string text;
			if (flag)
			{
				text = "%00.0";
			}
			else
			{
				text = (double.Parse(Conversions.ToString(int_0)) / double.Parse(Conversions.ToString(int_1)) * 100.0 / 100.0).ToString("%00.0").Replace("100.0", "100");
			}
			return text;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0013A880 File Offset: 0x00138C80
		public static int smethod_1(int int_0, int int_1)
		{
			bool flag = int_1 == 0;
			int num = 0;
			if (flag)
			{
				num = 0;
			}
			else
			{
				num = (int)Math.Round(Math.Round((double)int_0 / (double)int_1 * 100.0));
			}
			return num;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0013A8BC File Offset: 0x00138CBC
		public static Form smethod_10(string string_0)
		{
			return MyProject.Application.OpenForms[string_0];
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0013A8E0 File Offset: 0x00138CE0
		public static byte[] smethod_11(ref string string_0)
		{
			return Encoding.Default.GetBytes(string_0);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0013A900 File Offset: 0x00138D00
		public static string smethod_12(ref byte[] byte_0)
		{
			return Encoding.Default.GetString(byte_0);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0013A920 File Offset: 0x00138D20
		public static string smethod_13()
		{
			return MyProject.Computer.Clock.LocalTime.ToString("[hh:mm:ss]");
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0013A950 File Offset: 0x00138D50
		public static string smethod_14(ref string string_0)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0));
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0013A974 File Offset: 0x00138D74
		public static int smethod_15(int int_0, int int_1, bool bool_0)
		{
			Class6.long_0 = (long)Math.Round(Math.Round((double)Class6.long_0 + 333.33));
			Random random = new Random((int)Class6.long_0);
			return random.Next(int_0, int_1 + 1);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0013A9C0 File Offset: 0x00138DC0
		public static string smethod_16(string string_0)
		{
			int num = 0;
			string text;
			for (;;)
			{
				try
				{
					byte[] array = Convert.FromBase64String(string_0);
					text = Encoding.UTF8.GetString(array);
					break;
				}
				catch (Exception ex)
				{
					num++;
					bool flag = num == 3;
					if (flag)
					{
						text = null;
						break;
					}
					string_0 += "=";
				}
			}
			return text;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0013AA4C File Offset: 0x00138E4C
		public static string smethod_17(long long_1)
		{
			bool flag = long_1.ToString().Length < 4;
			string text;
			if (flag)
			{
				text = Conversions.ToString(long_1) + " Bytes";
			}
			else
			{
				string text2 = string.Empty;
				double num = (double)long_1 / 1024.0;
				flag = num < 1024.0;
				if (flag)
				{
					text2 = "KB";
				}
				else
				{
					num /= 1024.0;
					flag = num < 1024.0;
					if (flag)
					{
						text2 = "MB";
					}
					else
					{
						num /= 1024.0;
						text2 = "GB";
					}
				}
				text = num.ToString(".0") + " " + text2;
			}
			return text;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0013AB04 File Offset: 0x00138F04
		public static string smethod_2(string string_0, string string_1)
		{
			string text;
			try
			{
				text = Conversions.ToString(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.CurrentUser.OpenSubKey("Software\\" + Class7.string_0).GetValue(string_0, string_1)));
			}
			catch (Exception ex)
			{
				text = string_1;
			}
			return text;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0013AB80 File Offset: 0x00138F80
		public static void smethod_3(string string_0, string string_1)
		{
			bool flag = string_1 == null;
			if (flag)
			{
				string_1 = string.Empty;
			}
			try
			{
				MyProject.Computer.Registry.CurrentUser.CreateSubKey("Software\\" + Class7.string_0).SetValue(string_0, string_1);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0013ABFC File Offset: 0x00138FFC
		public static string smethod_4(string string_0)
		{
			return Class6.smethod_5(Class6.smethod_11(ref string_0));
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0013AC1C File Offset: 0x0013901C
		public static string smethod_5(byte[] byte_0)
		{
			byte_0 = new MD5CryptoServiceProvider().ComputeHash(byte_0);
			string text = string.Empty;
			foreach (byte b in byte_0)
			{
				text += b.ToString("x2");
			}
			return text;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0013AC74 File Offset: 0x00139074
		public static string smethod_6(int int_0)
		{
			Random random = new Random();
			string text = string.Empty;
			string text2 = "abcdefghijklmnopqrstuvwxyz";
			for (int i = 1; i <= int_0; i++)
			{
				text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
			}
			return text;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0013ACD8 File Offset: 0x001390D8
		public static TreeNode smethod_7(string string_0, TreeNodeCollection treeNodeCollection_0)
		{
			bool flag = string_0.EndsWith("\\");
			if (flag)
			{
				string_0 = string_0.Remove(string_0.Length - 1, 1);
			}
			TreeNode treeNode = null;
			foreach (string text in Strings.Split(string_0, "\\", -1, CompareMethod.Binary))
			{
				treeNode = treeNodeCollection_0[text];
				treeNodeCollection_0 = treeNode.Nodes;
			}
			return treeNode;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0013AD4C File Offset: 0x0013914C
		public static byte[] smethod_8(byte[] byte_0, ref bool bool_0)
		{
			bool flag = bool_0;
			byte[] array2;
			if (flag)
			{
				MemoryStream memoryStream = new MemoryStream();
				GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true);
				gzipStream.Write(byte_0, 0, byte_0.Length);
				gzipStream.Dispose();
				memoryStream.Position = 0L;
				byte[] array = new byte[(int)memoryStream.Length + 1 - 1 + 1];
				memoryStream.Read(array, 0, array.Length);
				memoryStream.Dispose();
				array2 = array;
			}
			else
			{
				MemoryStream memoryStream2 = new MemoryStream(byte_0);
				GZipStream gzipStream2 = new GZipStream(memoryStream2, CompressionMode.Decompress);
				byte[] array3 = new byte[4];
				memoryStream2.Position = memoryStream2.Length - 5L;
				memoryStream2.Read(array3, 0, 4);
				int num = BitConverter.ToInt32(array3, 0);
				memoryStream2.Position = 0L;
				byte[] array4 = new byte[num - 1 + 1 - 1 + 1];
				gzipStream2.Read(array4, 0, num);
				gzipStream2.Dispose();
				memoryStream2.Dispose();
				array2 = array4;
			}
			return array2;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0013AE3C File Offset: 0x0013923C
		public static Array smethod_9(byte[] byte_0, string string_0)
		{
			List<byte[]> list = new List<byte[]>();
			int num = Array.IndexOf<byte>(byte_0, (byte)Strings.Asc(string_0[0]));
			bool flag;
			for (;;)
			{
				flag = !((num > -1) & (num + string_0.Length <= byte_0.Length));
				if (flag)
				{
					break;
				}
				byte[] array = new byte[string_0.Length - 1 + 1 - 1 + 1];
				int num2 = 0;
				int num3 = num + string_0.Length - 1;
				for (int i = num; i <= num3; i++)
				{
					array[num2] = byte_0[i];
					num2++;
				}
				flag = Operators.CompareString(Class6.smethod_12(ref array), string_0, false) == 0;
				if (flag)
				{
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(byte_0, 0, num);
					list.Add(memoryStream.ToArray());
					memoryStream.Dispose();
					memoryStream = new MemoryStream();
					memoryStream.Write(byte_0, num + string_0.Length, byte_0.Length - (num + string_0.Length));
					list.Add(memoryStream.ToArray());
					memoryStream.Dispose();
					break;
				}
				num = Array.IndexOf<byte>(byte_0, (byte)Strings.Asc(string_0[0]), num + 1);
			}
			flag = list.Count == 0;
			if (flag)
			{
				list.Add(byte_0);
			}
			return list.ToArray();
		}

		// Token: 0x04000289 RID: 649
		public static long long_0 = 0L;
	}
}
