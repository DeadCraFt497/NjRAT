using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000014 RID: 20
	[ComVisible(false)]
	public enum PhysicalConnectorType
	{
		// Token: 0x04000077 RID: 119
		Video_Tuner = 1,
		// Token: 0x04000078 RID: 120
		Video_Composite,
		// Token: 0x04000079 RID: 121
		Video_SVideo,
		// Token: 0x0400007A RID: 122
		Video_RGB,
		// Token: 0x0400007B RID: 123
		Video_YRYBY,
		// Token: 0x0400007C RID: 124
		Video_SerialDigital,
		// Token: 0x0400007D RID: 125
		Video_ParallelDigital,
		// Token: 0x0400007E RID: 126
		Video_SCSI,
		// Token: 0x0400007F RID: 127
		Video_AUX,
		// Token: 0x04000080 RID: 128
		Video_1394,
		// Token: 0x04000081 RID: 129
		Video_USB,
		// Token: 0x04000082 RID: 130
		Video_VideoDecoder,
		// Token: 0x04000083 RID: 131
		Video_VideoEncoder,
		// Token: 0x04000084 RID: 132
		Video_SCART,
		// Token: 0x04000085 RID: 133
		Audio_Tuner = 4096,
		// Token: 0x04000086 RID: 134
		Audio_Line,
		// Token: 0x04000087 RID: 135
		Audio_Mic,
		// Token: 0x04000088 RID: 136
		Audio_AESDigital,
		// Token: 0x04000089 RID: 137
		Audio_SPDIFDigital,
		// Token: 0x0400008A RID: 138
		Audio_SCSI,
		// Token: 0x0400008B RID: 139
		Audio_AUX,
		// Token: 0x0400008C RID: 140
		Audio_1394,
		// Token: 0x0400008D RID: 141
		Audio_USB,
		// Token: 0x0400008E RID: 142
		Audio_AudioDecoder
	}
}
