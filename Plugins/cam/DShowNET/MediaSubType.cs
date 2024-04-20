using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200004C RID: 76
	[ComVisible(false)]
	public class MediaSubType
	{
		// Token: 0x0400012D RID: 301
		public static readonly Guid YUYV = new Guid(1448695129, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

		// Token: 0x0400012E RID: 302
		public static readonly Guid IYUV = new Guid(1448433993, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

		// Token: 0x0400012F RID: 303
		public static readonly Guid DVSD = new Guid(1146312260, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

		// Token: 0x04000130 RID: 304
		public static readonly Guid RGB1 = new Guid(3828804472U, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

		// Token: 0x04000131 RID: 305
		public static readonly Guid RGB4 = new Guid(3828804473U, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

		// Token: 0x04000132 RID: 306
		public static readonly Guid RGB8 = new Guid(3828804474U, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

		// Token: 0x04000133 RID: 307
		public static readonly Guid RGB565 = new Guid(3828804475U, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

		// Token: 0x04000134 RID: 308
		public static readonly Guid RGB555 = new Guid(3828804476U, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

		// Token: 0x04000135 RID: 309
		public static readonly Guid RGB24 = new Guid(3828804477U, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

		// Token: 0x04000136 RID: 310
		public static readonly Guid RGB32 = new Guid(3828804478U, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

		// Token: 0x04000137 RID: 311
		public static readonly Guid Avi = new Guid(3828804488U, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

		// Token: 0x04000138 RID: 312
		public static readonly Guid Asf = new Guid(1035472784U, 37906, 4561, 173, 237, 0, 0, 248, 117, 75, 153);
	}
}
