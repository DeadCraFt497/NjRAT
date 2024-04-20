using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000049 RID: 73
	[ComVisible(false)]
	public class FilterCategory
	{
		// Token: 0x04000117 RID: 279
		public static readonly Guid AudioInputDevice = new Guid(869902178U, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);

		// Token: 0x04000118 RID: 280
		public static readonly Guid VideoInputDevice = new Guid(2248913680U, 23809, 4560, 189, 59, 0, 160, 201, 17, 206, 134);

		// Token: 0x04000119 RID: 281
		public static readonly Guid VideoCompressorCategory = new Guid(869902176U, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);

		// Token: 0x0400011A RID: 282
		public static readonly Guid AudioCompressorCategory = new Guid(869902177U, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);

		// Token: 0x0400011B RID: 283
		public static readonly Guid LegacyAmFilterCategory = new Guid(137913329, 28894, 4560, 189, 64, 0, 160, 201, 17, 206, 134);
	}
}
