using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200004D RID: 77
	[ComVisible(false)]
	public class FormatType
	{
		// Token: 0x04000139 RID: 313
		public static readonly Guid None = new Guid(258217942U, 49944, 4560, 164, 63, 0, 160, 201, 34, 49, 150);

		// Token: 0x0400013A RID: 314
		public static readonly Guid VideoInfo = new Guid(89694080U, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);

		// Token: 0x0400013B RID: 315
		public static readonly Guid VideoInfo2 = new Guid(4146755232U, 60170, 4560, 172, 228, 0, 0, 192, 204, 22, 186);

		// Token: 0x0400013C RID: 316
		public static readonly Guid WaveEx = new Guid(89694081U, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);

		// Token: 0x0400013D RID: 317
		public static readonly Guid MpegVideo = new Guid(89694082U, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);

		// Token: 0x0400013E RID: 318
		public static readonly Guid MpegStreams = new Guid(89694083U, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);

		// Token: 0x0400013F RID: 319
		public static readonly Guid DvInfo = new Guid(89694084U, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);
	}
}
