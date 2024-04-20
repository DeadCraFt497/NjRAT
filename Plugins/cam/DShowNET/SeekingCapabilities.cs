using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200001E RID: 30
	[ComVisible(false)]
	[Flags]
	public enum SeekingCapabilities
	{
		// Token: 0x04000094 RID: 148
		CanSeekAbsolute = 1,
		// Token: 0x04000095 RID: 149
		CanSeekForwards = 2,
		// Token: 0x04000096 RID: 150
		CanSeekBackwards = 4,
		// Token: 0x04000097 RID: 151
		CanGetCurrentPos = 8,
		// Token: 0x04000098 RID: 152
		CanGetStopPos = 16,
		// Token: 0x04000099 RID: 153
		CanGetDuration = 32,
		// Token: 0x0400009A RID: 154
		CanPlayBackwards = 64,
		// Token: 0x0400009B RID: 155
		CanDoSegments = 128,
		// Token: 0x0400009C RID: 156
		Source = 256
	}
}
