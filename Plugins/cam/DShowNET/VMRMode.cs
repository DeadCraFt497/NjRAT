using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000054 RID: 84
	[ComVisible(false)]
	public enum VMRMode : uint
	{
		// Token: 0x0400014C RID: 332
		Windowed = 1U,
		// Token: 0x0400014D RID: 333
		Windowless,
		// Token: 0x0400014E RID: 334
		Renderless = 4U
	}
}
