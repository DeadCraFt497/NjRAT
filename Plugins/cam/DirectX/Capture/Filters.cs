using System;
using cam.DShowNET;

namespace cam.DirectX.Capture
{
	// Token: 0x0200005A RID: 90
	public class Filters
	{
		// Token: 0x060001EE RID: 494 RVA: 0x000058A0 File Offset: 0x00003AA0
		public Filters()
		{
			this.VideoInputDevices = new FilterCollection(FilterCategory.VideoInputDevice);
			this.AudioInputDevices = new FilterCollection(FilterCategory.AudioInputDevice);
			this.VideoCompressors = new FilterCollection(FilterCategory.VideoCompressorCategory);
			this.AudioCompressors = new FilterCollection(FilterCategory.AudioCompressorCategory);
		}

		// Token: 0x04000155 RID: 341
		public FilterCollection VideoInputDevices;

		// Token: 0x04000156 RID: 342
		public FilterCollection AudioInputDevices;

		// Token: 0x04000157 RID: 343
		public FilterCollection VideoCompressors;

		// Token: 0x04000158 RID: 344
		public FilterCollection AudioCompressors;
	}
}
