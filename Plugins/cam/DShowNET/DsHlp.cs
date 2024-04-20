using System;
using System.Runtime.InteropServices;
using System.Text;

namespace cam.DShowNET
{
	// Token: 0x02000015 RID: 21
	[ComVisible(false)]
	public class DsHlp
	{
		// Token: 0x060000CD RID: 205
		[DllImport("quartz.dll", CharSet = CharSet.Auto)]
		public static extern int AMGetErrorText(int hr, StringBuilder buf, int max);

		// Token: 0x0400008F RID: 143
		public const int OATRUE = -1;

		// Token: 0x04000090 RID: 144
		public const int OAFALSE = 0;
	}
}
