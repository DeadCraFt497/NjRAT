using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200005E RID: 94
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0579154A-2B53-4994-B0D0-E773148EFF85")]
	[ComImport]
	public interface ISampleGrabberCB
	{
		// Token: 0x06000203 RID: 515
		[PreserveSig]
		int SampleCB(double SampleTime, IMediaSample pSample);

		// Token: 0x06000204 RID: 516
		[PreserveSig]
		int BufferCB(double SampleTime, IntPtr pBuffer, int BufferLen);
        int ISampleGrabberCB_SampleCB(double SampleTime, IMediaSample pSample);
        int ISampleGrabberCB_BufferCB(double SampleTime, IntPtr pBuffer, int BufferLen);
    }
}
