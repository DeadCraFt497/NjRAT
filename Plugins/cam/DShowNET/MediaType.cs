using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200004B RID: 75
	[ComVisible(false)]
	public class MediaType
	{
		// Token: 0x04000128 RID: 296
		public static readonly Guid Video = new Guid(1935960438, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

		// Token: 0x04000129 RID: 297
		public static readonly Guid Interleaved = new Guid(1937138025, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

		// Token: 0x0400012A RID: 298
		public static readonly Guid Audio = new Guid(1935963489, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

		// Token: 0x0400012B RID: 299
		public static readonly Guid Text = new Guid(1937012852, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

		// Token: 0x0400012C RID: 300
		public static readonly Guid Stream = new Guid(3828804483U, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
	}
}
