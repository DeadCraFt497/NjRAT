using System;
using System.Drawing;
using System.Runtime.InteropServices;
using cam.DShowNET;

namespace cam.DirectX.Capture
{
	// Token: 0x02000067 RID: 103
	public class VideoCapabilities
	{
		// Token: 0x06000225 RID: 549 RVA: 0x000063DC File Offset: 0x000045DC
		internal VideoCapabilities(IAMStreamConfig videoStreamConfig)
		{
			AMMediaType ammediaType = null;
			IntPtr intPtr = IntPtr.Zero;
			try
			{
				int num2 = 0;
				int num3 = 0;
				int num = videoStreamConfig.GetNumberOfCapabilities(ref num2, ref num3);
				intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(VideoStreamConfigCaps)));
				IntPtr intPtr2;
				num = videoStreamConfig.GetStreamCaps(0, out intPtr2, intPtr);
				ammediaType = (AMMediaType)Marshal.PtrToStructure(intPtr2, typeof(AMMediaType));
				VideoStreamConfigCaps videoStreamConfigCaps = (VideoStreamConfigCaps)Marshal.PtrToStructure(intPtr, typeof(VideoStreamConfigCaps));
				this.InputSize = videoStreamConfigCaps.InputSize;
				this.MinFrameSize = videoStreamConfigCaps.MinOutputSize;
				this.MaxFrameSize = videoStreamConfigCaps.MaxOutputSize;
				this.FrameSizeGranularityX = videoStreamConfigCaps.OutputGranularityX;
				this.FrameSizeGranularityY = videoStreamConfigCaps.OutputGranularityY;
				this.MinFrameRate = 10000000.0 / (double)videoStreamConfigCaps.MaxFrameInterval;
				this.MaxFrameRate = 10000000.0 / (double)videoStreamConfigCaps.MinFrameInterval;
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeCoTaskMem(intPtr);
				}
				intPtr = IntPtr.Zero;
				if (ammediaType != null)
				{
					DsUtils.FreeAMMediaType(ammediaType);
				}
				ammediaType = null;
			}
		}

		// Token: 0x0400017A RID: 378
		public Size InputSize;

		// Token: 0x0400017B RID: 379
		public Size MinFrameSize;

		// Token: 0x0400017C RID: 380
		public Size MaxFrameSize;

		// Token: 0x0400017D RID: 381
		public int FrameSizeGranularityX = 0;

		// Token: 0x0400017E RID: 382
		public int FrameSizeGranularityY = 0;

		// Token: 0x0400017F RID: 383
		public double MinFrameRate;

		// Token: 0x04000180 RID: 384
		public double MaxFrameRate;
	}
}
