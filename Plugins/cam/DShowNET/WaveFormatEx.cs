using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000061 RID: 97
	[ComVisible(false)]
	[StructLayout(LayoutKind.Sequential)]
	public class WaveFormatEx
	{
		// Token: 0x0400016D RID: 365
		public short wFormatTag;

		// Token: 0x0400016E RID: 366
		public short nChannels;

		// Token: 0x0400016F RID: 367
		public int nSamplesPerSec;

		// Token: 0x04000170 RID: 368
		public int nAvgBytesPerSec;

		// Token: 0x04000171 RID: 369
		public short nBlockAlign;

		// Token: 0x04000172 RID: 370
		public short wBitsPerSample;

		// Token: 0x04000173 RID: 371
		public short cbSize;
	}
}
