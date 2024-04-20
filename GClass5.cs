using System;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT
{
	// Token: 0x02000032 RID: 50
	public sealed class GClass5
	{
		// Token: 0x060005B2 RID: 1458 RVA: 0x00145710 File Offset: 0x00143B10
		public GClass5(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00145724 File Offset: 0x00143B24
		public int method_0()
		{
			bool flag = (this.string_0 == null) | (Operators.CompareString(this.string_0, string.Empty, false) == 0);
			int num = 0;
			if (flag)
			{
				num = GClass5.int_0;
			}
			else
			{
				num = Convert.ToInt32(this.string_0.Substring(4, 3)) - 105;
			}
			return num;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00145778 File Offset: 0x00143B78
		public bool method_1()
		{
			return this.string_0.IndexOf("FREE") < 0;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x001457A0 File Offset: 0x00143BA0
		public DateTime method_2()
		{
			int num = this.string_0.Length - 10;
			for (int i = 0; i <= num; i++)
			{
				bool flag = char.IsWhiteSpace(this.string_0[i]);
				if (flag)
				{
					string text = this.string_0.Substring(i + 1, 8);
					try
					{
						return DateTime.ParseExact(text, "yyyyMMdd", null);
					}
					catch (Exception ex)
					{
						Exception ex2 = ex;
						Console.Write(ex2.Message);
						break;
					}
				}
			}
			return DateTime.Now;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00145864 File Offset: 0x00143C64
		public string method_3()
		{
			return this.string_0;
		}

		// Token: 0x040002FA RID: 762
		public static int int_0 = 1;

		// Token: 0x040002FB RID: 763
		public static int int_1 = 7;

		// Token: 0x040002FC RID: 764
		public static int int_10 = 11;

		// Token: 0x040002FD RID: 765
		public static int int_11 = 12;

		// Token: 0x040002FE RID: 766
		public static int int_12 = 21;

		// Token: 0x040002FF RID: 767
		public static int int_13 = 22;

		// Token: 0x04000300 RID: 768
		public static int int_14 = 23;

		// Token: 0x04000301 RID: 769
		public static int int_15 = 24;

		// Token: 0x04000302 RID: 770
		public static int int_16 = 30;

		// Token: 0x04000303 RID: 771
		public static int int_17 = 31;

		// Token: 0x04000304 RID: 772
		public static int int_18 = 32;

		// Token: 0x04000305 RID: 773
		public static int int_19 = 33;

		// Token: 0x04000306 RID: 774
		public static int int_2 = 3;

		// Token: 0x04000307 RID: 775
		public static int int_3 = 6;

		// Token: 0x04000308 RID: 776
		public static int int_4 = 2;

		// Token: 0x04000309 RID: 777
		public static int int_5 = 5;

		// Token: 0x0400030A RID: 778
		public static int int_6 = 4;

		// Token: 0x0400030B RID: 779
		public static int int_7 = 8;

		// Token: 0x0400030C RID: 780
		public static int int_8 = 9;

		// Token: 0x0400030D RID: 781
		public static int int_9 = 10;

		// Token: 0x0400030E RID: 782
		private string string_0;
	}
}
