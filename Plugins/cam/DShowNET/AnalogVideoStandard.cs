using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000037 RID: 55
	[ComVisible(false)]
	[Flags]
	public enum AnalogVideoStandard
	{
		// Token: 0x040000C5 RID: 197
		None = 0,
		// Token: 0x040000C6 RID: 198
		NTSC_M = 1,
		// Token: 0x040000C7 RID: 199
		NTSC_M_J = 2,
		// Token: 0x040000C8 RID: 200
		NTSC_433 = 4,
		// Token: 0x040000C9 RID: 201
		PAL_B = 16,
		// Token: 0x040000CA RID: 202
		PAL_D = 32,
		// Token: 0x040000CB RID: 203
		PAL_G = 64,
		// Token: 0x040000CC RID: 204
		PAL_H = 128,
		// Token: 0x040000CD RID: 205
		PAL_I = 256,
		// Token: 0x040000CE RID: 206
		PAL_M = 512,
		// Token: 0x040000CF RID: 207
		PAL_N = 1024,
		// Token: 0x040000D0 RID: 208
		PAL_60 = 2048,
		// Token: 0x040000D1 RID: 209
		SECAM_B = 4096,
		// Token: 0x040000D2 RID: 210
		SECAM_D = 8192,
		// Token: 0x040000D3 RID: 211
		SECAM_G = 16384,
		// Token: 0x040000D4 RID: 212
		SECAM_H = 32768,
		// Token: 0x040000D5 RID: 213
		SECAM_K = 65536,
		// Token: 0x040000D6 RID: 214
		SECAM_K1 = 131072,
		// Token: 0x040000D7 RID: 215
		SECAM_L = 262144,
		// Token: 0x040000D8 RID: 216
		SECAM_L1 = 524288,
		// Token: 0x040000D9 RID: 217
		PAL_N_COMBO = 1048576
	}
}
