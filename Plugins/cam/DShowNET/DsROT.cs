using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000044 RID: 68
	[ComVisible(false)]
	public class DsROT
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00004B38 File Offset: 0x00002D38
		public static bool AddGraphToRot(object graph, ref int cookie)
		{
			cookie = 0;
			UCOMIRunningObjectTable ucomirunningObjectTable = null;
			UCOMIMoniker ucomimoniker = null;
			bool flag;
			try
			{
				int num = DsROT.GetRunningObjectTable(0, ref ucomirunningObjectTable);
				int currentProcessId = DsROT.GetCurrentProcessId();
				IntPtr iunknownForObject = Marshal.GetIUnknownForObject(RuntimeHelpers.GetObjectValue(graph));
				int num2 = (int)iunknownForObject;
				Marshal.Release(iunknownForObject);
				string text = string.Format("FilterGraph {0} pid {1}", num2.ToString("x8"), currentProcessId.ToString("x8"));
				num = DsROT.CreateItemMoniker("!", text, ref ucomimoniker);
				ucomirunningObjectTable.Register(1, RuntimeHelpers.GetObjectValue(graph), ucomimoniker, out cookie);
				flag = true;
			}
			catch (Exception ex)
			{
				flag = false;
			}
			finally
			{
				if (ucomimoniker != null)
				{
					Marshal.ReleaseComObject(ucomimoniker);
				}
				ucomimoniker = null;
				if (ucomirunningObjectTable != null)
				{
					Marshal.ReleaseComObject(ucomirunningObjectTable);
				}
				ucomirunningObjectTable = null;
			}
			return flag;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00004C0C File Offset: 0x00002E0C
		public static bool RemoveGraphFromRot(ref int cookie)
		{
			UCOMIRunningObjectTable ucomirunningObjectTable = null;
			bool flag;
			try
			{
				int runningObjectTable = DsROT.GetRunningObjectTable(0, ref ucomirunningObjectTable);
				ucomirunningObjectTable.Revoke(cookie);
				cookie = 0;
				flag = true;
			}
			catch (Exception ex)
			{
				flag = false;
			}
			finally
			{
				if (ucomirunningObjectTable != null)
				{
					Marshal.ReleaseComObject(ucomirunningObjectTable);
				}
				ucomirunningObjectTable = null;
			}
			return flag;
		}

		// Token: 0x060001A6 RID: 422
		[DllImport("ole32.dll", ExactSpelling = true)]
		private static extern int GetRunningObjectTable(int r, ref UCOMIRunningObjectTable pprot);

		// Token: 0x060001A7 RID: 423
		[DllImport("ole32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		private static extern int CreateItemMoniker(string delim, string item, ref UCOMIMoniker ppmk);

		// Token: 0x060001A8 RID: 424
		[DllImport("kernel32.dll", ExactSpelling = true)]
		private static extern int GetCurrentProcessId();

		// Token: 0x04000112 RID: 274
		private const int ROTFLAGS_REGISTRATIONKEEPSALIVE = 1;
	}
}
