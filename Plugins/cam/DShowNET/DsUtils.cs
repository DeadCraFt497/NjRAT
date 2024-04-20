using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000040 RID: 64
	[ComVisible(false)]
	public class DsUtils
	{
		// Token: 0x0600019D RID: 413 RVA: 0x000047F4 File Offset: 0x000029F4
		public static bool IsCorrectDirectXVersion()
		{
			return File.Exists(Path.Combine(Environment.SystemDirectory, "dpnhpast.dll"));
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00004818 File Offset: 0x00002A18
		public static bool ShowCapPinDialog(ICaptureGraphBuilder2 bld, IBaseFilter flt, IntPtr hwnd)
		{
			object obj = null;
			DsCAUUID dsCAUUID = default(DsCAUUID);
			bool flag;
			try
			{
				Guid capture = PinCategory.Capture;
				Guid guid = MediaType.Interleaved;
				Guid guid2 = typeof(IAMStreamConfig).GUID;
				int num = bld.FindInterface(ref capture, ref guid, flt, ref guid2, out obj);
				if (num != 0)
				{
					guid = MediaType.Video;
					num = bld.FindInterface(ref capture, ref guid, flt, ref guid2, out obj);
					if (num != 0)
					{
						return false;
					}
				}
				ISpecifyPropertyPages specifyPropertyPages = obj as ISpecifyPropertyPages;
				if (specifyPropertyPages == null)
				{
					flag = false;
				}
				else
				{
					num = specifyPropertyPages.GetPages(ref dsCAUUID);
					num = DsUtils.OleCreatePropertyFrame(hwnd, 30, 30, null, 1, ref obj, dsCAUUID.cElems, dsCAUUID.pElems, 0, 0, IntPtr.Zero);
					flag = true;
				}
			}
			catch (Exception ex)
			{
				flag = false;
			}
			finally
			{
				if (dsCAUUID.pElems != IntPtr.Zero)
				{
					Marshal.FreeCoTaskMem(dsCAUUID.pElems);
				}
				if (obj != null)
				{
					Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
				}
				obj = null;
			}
			return flag;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000492C File Offset: 0x00002B2C
		public static bool ShowTunerPinDialog(ICaptureGraphBuilder2 bld, IBaseFilter flt, IntPtr hwnd)
		{
			object obj = null;
			DsCAUUID dsCAUUID = default(DsCAUUID);
			bool flag;
			try
			{
				Guid capture = PinCategory.Capture;
				Guid guid = MediaType.Interleaved;
				Guid guid2 = typeof(IAMTVTuner).GUID;
				int num = bld.FindInterface(ref capture, ref guid, flt, ref guid2, out obj);
				if (num != 0)
				{
					guid = MediaType.Video;
					num = bld.FindInterface(ref capture, ref guid, flt, ref guid2, out obj);
					if (num != 0)
					{
						return false;
					}
				}
				ISpecifyPropertyPages specifyPropertyPages = obj as ISpecifyPropertyPages;
				if (specifyPropertyPages == null)
				{
					flag = false;
				}
				else
				{
					num = specifyPropertyPages.GetPages(ref dsCAUUID);
					num = DsUtils.OleCreatePropertyFrame(hwnd, 30, 30, null, 1, ref obj, dsCAUUID.cElems, dsCAUUID.pElems, 0, 0, IntPtr.Zero);
					flag = true;
				}
			}
			catch (Exception ex)
			{
				flag = false;
			}
			finally
			{
				if (dsCAUUID.pElems != IntPtr.Zero)
				{
					Marshal.FreeCoTaskMem(dsCAUUID.pElems);
				}
				if (obj != null)
				{
					Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
				}
				obj = null;
			}
			return flag;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00004A40 File Offset: 0x00002C40
		public int GetPin(IBaseFilter filter, PinDirection dirrequired, int num, ref IPin ppPin)
		{
			ppPin = null;
			IEnumPins enumPins;
			int num2 = filter.EnumPins(out enumPins);
			if (num2 < 0 || enumPins == null)
			{
				return num2;
			}
			IPin[] array = new IPin[1];
			checked
			{
				do
				{
					int num3;
					num2 = enumPins.Next(1, array, out num3);
					if (num2 != 0)
					{
						break;
					}
					if (array[0] == null)
					{
						break;
					}
					PinDirection pinDirection = (PinDirection)3;
					num2 = array[0].QueryDirection(ref pinDirection);
					if (num2 == 0 && pinDirection == dirrequired)
					{
						if (num == 0)
						{
							goto Block_6;
						}
						num--;
					}
					Marshal.ReleaseComObject(array[0]);
					array[0] = null;
				}
				while (num2 == 0);
				goto IL_78;
			}
			Block_6:
			ppPin = array[0];
			array[0] = null;
			IL_78:
			Marshal.ReleaseComObject(enumPins);
			enumPins = null;
			return num2;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00004AD4 File Offset: 0x00002CD4
		public static void FreeAMMediaType(AMMediaType mediaType)
		{
			if (mediaType.formatSize != 0)
			{
				Marshal.FreeCoTaskMem(mediaType.formatPtr);
			}
			if (mediaType.unkPtr != IntPtr.Zero)
			{
				Marshal.Release(mediaType.unkPtr);
			}
			mediaType.formatSize = 0;
			mediaType.formatPtr = IntPtr.Zero;
			mediaType.unkPtr = IntPtr.Zero;
		}

		// Token: 0x060001A2 RID: 418
		[DllImport("olepro32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		private static extern int OleCreatePropertyFrame(IntPtr hwndOwner, int x, int y, string lpszCaption, int cObjects, [MarshalAs(UnmanagedType.Interface)] [In] ref object ppUnk, int cPages, IntPtr pPageClsID, int lcid, int dwReserved, IntPtr pvReserved);
	}
}
