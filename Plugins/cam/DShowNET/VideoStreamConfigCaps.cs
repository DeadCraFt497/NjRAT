using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200003E RID: 62
	[ComVisible(false)]
	[StructLayout(LayoutKind.Sequential)]
	public class VideoStreamConfigCaps
	{
		// Token: 0x040000E2 RID: 226
		public Guid Guid;

		// Token: 0x040000E3 RID: 227
		public AnalogVideoStandard VideoStandard;

		// Token: 0x040000E4 RID: 228
		public Size InputSize;

		// Token: 0x040000E5 RID: 229
		public Size MinCroppingSize;

		// Token: 0x040000E6 RID: 230
		public Size MaxCroppingSize;

		// Token: 0x040000E7 RID: 231
		public int CropGranularityX;

		// Token: 0x040000E8 RID: 232
		public int CropGranularityY;

		// Token: 0x040000E9 RID: 233
		public int CropAlignX;

		// Token: 0x040000EA RID: 234
		public int CropAlignY;

		// Token: 0x040000EB RID: 235
		public Size MinOutputSize;

		// Token: 0x040000EC RID: 236
		public Size MaxOutputSize;

		// Token: 0x040000ED RID: 237
		public int OutputGranularityX;

		// Token: 0x040000EE RID: 238
		public int OutputGranularityY;

		// Token: 0x040000EF RID: 239
		public int StretchTapsX;

		// Token: 0x040000F0 RID: 240
		public int StretchTapsY;

		// Token: 0x040000F1 RID: 241
		public int ShrinkTapsX;

		// Token: 0x040000F2 RID: 242
		public int ShrinkTapsY;

		// Token: 0x040000F3 RID: 243
		public long MinFrameInterval;

		// Token: 0x040000F4 RID: 244
		public long MaxFrameInterval;

		// Token: 0x040000F5 RID: 245
		public int MinBitsPerSecond;

		// Token: 0x040000F6 RID: 246
		public int MaxBitsPerSecond;
	}
}
