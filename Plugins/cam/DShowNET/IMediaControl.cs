using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200000A RID: 10
	[Guid("56a868b1-0ad4-11ce-b03a-0020af0ba770")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	[ComImport]
	public interface IMediaControl
	{
		// Token: 0x0600005A RID: 90
		[PreserveSig]
		int Run();

		// Token: 0x0600005B RID: 91
		[PreserveSig]
		int Pause();

		// Token: 0x0600005C RID: 92
		[PreserveSig]
		int Stop();

		// Token: 0x0600005D RID: 93
		[PreserveSig]
		int GetState(int msTimeout, ref int pfs);

		// Token: 0x0600005E RID: 94
		[PreserveSig]
		int RenderFile(string strFilename);

		// Token: 0x0600005F RID: 95
		[PreserveSig]
		int AddSourceFilter([In] string strFilename, [MarshalAs(UnmanagedType.IDispatch)] out object ppUnk);

		// Token: 0x06000060 RID: 96
		[PreserveSig]
		int get_FilterCollection([MarshalAs(UnmanagedType.IDispatch)] out object ppUnk);

		// Token: 0x06000061 RID: 97
		[PreserveSig]
		int get_RegFilterCollection([MarshalAs(UnmanagedType.IDispatch)] out object ppUnk);

		// Token: 0x06000062 RID: 98
		[PreserveSig]
		int StopWhenReady();
	}
}
