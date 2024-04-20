using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200003F RID: 63
	[ComVisible(false)]
	[StructLayout(LayoutKind.Sequential)]
	public class AudioStreamConfigCaps
	{
		// Token: 0x040000F7 RID: 247
		public Guid Guid;

		// Token: 0x040000F8 RID: 248
		public int MinimumChannels;

		// Token: 0x040000F9 RID: 249
		public int MaximumChannels;

		// Token: 0x040000FA RID: 250
		public int ChannelsGranularity;

		// Token: 0x040000FB RID: 251
		public int MinimumBitsPerSample;

		// Token: 0x040000FC RID: 252
		public int MaximumBitsPerSample;

		// Token: 0x040000FD RID: 253
		public int BitsPerSampleGranularity;

		// Token: 0x040000FE RID: 254
		public int MinimumSampleFrequency;

		// Token: 0x040000FF RID: 255
		public int MaximumSampleFrequency;

		// Token: 0x04000100 RID: 256
		public int SampleFrequencyGranularity;
	}
}
