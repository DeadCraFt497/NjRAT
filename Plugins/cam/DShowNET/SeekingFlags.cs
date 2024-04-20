using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200001F RID: 31
	[Flags]
	[ComVisible(false)]
	public enum SeekingFlags
	{
		// Token: 0x0400009E RID: 158
		NoPositioning = 0,
		// Token: 0x0400009F RID: 159
		AbsolutePositioning = 1,
		// Token: 0x040000A0 RID: 160
		RelativePositioning = 2,
		// Token: 0x040000A1 RID: 161
		IncrementalPositioning = 3,
		// Token: 0x040000A2 RID: 162
		PositioningBitsMask = 3,
		// Token: 0x040000A3 RID: 163
		SeekToKeyFrame = 4,
		// Token: 0x040000A4 RID: 164
		ReturnTime = 8,
		// Token: 0x040000A5 RID: 165
		Segment = 16,
		// Token: 0x040000A6 RID: 166
		NoFlush = 32
	}
}
