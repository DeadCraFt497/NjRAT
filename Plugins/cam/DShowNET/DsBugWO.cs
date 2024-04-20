using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;

namespace cam.DShowNET
{
	// Token: 0x02000008 RID: 8
	public class DsBugWO
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00004530 File Offset: 0x00002730
		public static object CreateDsInstance(ref Guid clsid, ref Guid riid)
		{
			IntPtr intPtr = IntPtr.Zero;
			int num = DsBugWO.CoCreateInstance(ref clsid, IntPtr.Zero, CLSCTX.Inproc, ref riid, ref intPtr);
			Guid guid = new Guid("00000000-0000-0000-C000-000000000046");
			IntPtr intPtr2;
			num = Marshal.QueryInterface(intPtr, ref guid, out intPtr2);
			object objectValue = RuntimeHelpers.GetObjectValue(EnterpriseServicesHelper.WrapIUnknownWithComObject(intPtr));
			int num2 = Marshal.Release(intPtr);
			return objectValue;
		}

		// Token: 0x06000059 RID: 89
		[DllImport("ole32.dll")]
		private static extern int CoCreateInstance(ref Guid clsid, IntPtr pUnkOuter, CLSCTX dwClsContext, ref Guid iid, ref IntPtr ptrIf);
	}
}
