using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000047 RID: 71
	[ComVisible(false)]
	[StructLayout(LayoutKind.Sequential)]
	public class DsOptInt64
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00004C70 File Offset: 0x00002E70
		public DsOptInt64(long Value)
		{
			this.Value = Value;
		}

		// Token: 0x04000115 RID: 277
		public long Value;
	}
}
