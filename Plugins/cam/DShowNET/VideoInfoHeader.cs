using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200005F RID: 95
	[ComVisible(false)]
	[StructLayout(LayoutKind.Sequential)]
	public class VideoInfoHeader
	{
		// Token: 0x0400015B RID: 347
		public DsRECT SrcRect;

		// Token: 0x0400015C RID: 348
		public DsRECT TargetRect;

		// Token: 0x0400015D RID: 349
		public int BitRate;

		// Token: 0x0400015E RID: 350
		public int BitErrorRate;

		// Token: 0x0400015F RID: 351
		public long AvgTimePerFrame;

		// Token: 0x04000160 RID: 352
		public BitmapInfoHeader BmiHeader;
	}
}
