using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200004A RID: 74
	[ComVisible(false)]
	public class Clsid
	{
		// Token: 0x0400011C RID: 284
		public static readonly Guid SystemDeviceEnum = new Guid(1656642832, 24811, 4560, 189, 59, 0, 160, 201, 17, 206, 134);

		// Token: 0x0400011D RID: 285
		public static readonly Guid FilterGraph = new Guid(3828804531U, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

		// Token: 0x0400011E RID: 286
		public static readonly Guid CaptureGraphBuilder2 = new Guid(3213342433U, 35879, 4560, 179, 240, 0, 170, 0, 55, 97, 197);

		// Token: 0x0400011F RID: 287
		public static readonly Guid SampleGrabber = new Guid(3253993632U, 16136, 4563, 159, 11, 0, 96, 8, 3, 158, 55);

		// Token: 0x04000120 RID: 288
		public static readonly Guid DvdGraphBuilder = new Guid(4240528055U, 62322, 4560, 142, 0, 0, 192, 79, 215, 192, 139);

		// Token: 0x04000121 RID: 289
		public static readonly Guid StreamBufferSink = new Guid("2db47ae5-cf39-43c2-b4d6-0cd8d90946f4");

		// Token: 0x04000122 RID: 290
		public static readonly Guid StreamBufferSource = new Guid("c9f5fe02-f851-4eb5-99ee-ad602af1e619");

		// Token: 0x04000123 RID: 291
		public static readonly Guid VideoMixingRenderer = new Guid(3095128955U, 36137, 16959, 174, 77, 101, 130, 193, 1, 117, 172);

		// Token: 0x04000124 RID: 292
		public static readonly Guid VideoMixingRenderer9 = new Guid(1370794995, 29839, 20027, 162, 118, 200, 40, 51, 14, 146, 106);

		// Token: 0x04000125 RID: 293
		public static readonly Guid VideoRendererDefault = new Guid(1807863802U, 36801, 16993, 172, 34, 207, 180, 204, 56, 219, 80);

		// Token: 0x04000126 RID: 294
		public static readonly Guid AviSplitter = new Guid(458509344U, 64779, 4558, 140, 99, 0, 170, 0, 68, 181, 30);

		// Token: 0x04000127 RID: 295
		public static readonly Guid SmartTee = new Guid(3428377216U, 35489, 4561, 179, 241, 0, 170, 0, 55, 97, 197);
	}
}
