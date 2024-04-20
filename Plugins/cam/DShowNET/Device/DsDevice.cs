using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET.Device
{
	// Token: 0x02000027 RID: 39
	[ComVisible(false)]
	public class DsDevice : IDisposable
	{
		// Token: 0x0600012D RID: 301 RVA: 0x000047BC File Offset: 0x000029BC
		public void Dispose()
		{
			if (this.Mon != null)
			{
				Marshal.ReleaseComObject(this.Mon);
			}
			this.Mon = null;
		}

		// Token: 0x040000B3 RID: 179
		public string Name;

		// Token: 0x040000B4 RID: 180
		public UCOMIMoniker Mon;
	}
}
