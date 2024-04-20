using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000060 RID: 96
	[ComVisible(false)]
	[StructLayout(LayoutKind.Sequential)]
	public class VideoInfoHeader2
	{
		// Token: 0x04000161 RID: 353
		public DsRECT SrcRect;

		// Token: 0x04000162 RID: 354
		public DsRECT TargetRect;

		// Token: 0x04000163 RID: 355
		public int BitRate;

		// Token: 0x04000164 RID: 356
		public int BitErrorRate;

		// Token: 0x04000165 RID: 357
		public long AvgTimePerFrame;

		// Token: 0x04000166 RID: 358
		public int InterlaceFlags;

		// Token: 0x04000167 RID: 359
		public int CopyProtectFlags;

		// Token: 0x04000168 RID: 360
		public int PictAspectRatioX;

		// Token: 0x04000169 RID: 361
		public int PictAspectRatioY;

		// Token: 0x0400016A RID: 362
		public int ControlFlags;

		// Token: 0x0400016B RID: 363
		public int Reserved2;

		// Token: 0x0400016C RID: 364
		public BitmapInfoHeader BmiHeader;
	}
}
