using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000043 RID: 67
	[ComVisible(false)]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct BitmapInfoHeader
	{
		// Token: 0x04000107 RID: 263
		public int Size;

		// Token: 0x04000108 RID: 264
		public int Width;

		// Token: 0x04000109 RID: 265
		public int Height;

		// Token: 0x0400010A RID: 266
		public short Planes;

		// Token: 0x0400010B RID: 267
		public short BitCount;

		// Token: 0x0400010C RID: 268
		public int Compression;

		// Token: 0x0400010D RID: 269
		public int ImageSize;

		// Token: 0x0400010E RID: 270
		public int XPelsPerMeter;

		// Token: 0x0400010F RID: 271
		public int YPelsPerMeter;

		// Token: 0x04000110 RID: 272
		public int ClrUsed;

		// Token: 0x04000111 RID: 273
		public int ClrImportant;
	}
}
