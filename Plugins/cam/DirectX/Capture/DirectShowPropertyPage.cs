using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using cam.DShowNET;

namespace cam.DirectX.Capture
{
	// Token: 0x02000007 RID: 7
	public class DirectShowPropertyPage : PropertyPage
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00004460 File Offset: 0x00002660
		public DirectShowPropertyPage(string name__1, ISpecifyPropertyPages specifyPropertyPages)
		{
			this.Name = name__1;
			this.SupportsPersisting = false;
			this.specifyPropertyPages = specifyPropertyPages;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004480 File Offset: 0x00002680
		public override void Show(Control owner)
		{
			DsCAUUID dsCAUUID = default(DsCAUUID);
			try
			{
				int num = this.specifyPropertyPages.GetPages(ref dsCAUUID);
				object obj = this.specifyPropertyPages;
				num = DirectShowPropertyPage.OleCreatePropertyFrame(owner.Handle, 30, 30, null, 1, ref obj, dsCAUUID.cElems, dsCAUUID.pElems, 0, 0, IntPtr.Zero);
			}
			finally
			{
				if (dsCAUUID.pElems != IntPtr.Zero)
				{
					Marshal.FreeCoTaskMem(dsCAUUID.pElems);
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004508 File Offset: 0x00002708
		public new void Dispose()
		{
			if (this.specifyPropertyPages != null)
			{
				Marshal.ReleaseComObject(this.specifyPropertyPages);
			}
			this.specifyPropertyPages = null;
		}

		// Token: 0x06000056 RID: 86
		[DllImport("olepro32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		private static extern int OleCreatePropertyFrame(IntPtr hwndOwner, int x, int y, string lpszCaption, int cObjects, [MarshalAs(UnmanagedType.Interface)] [In] ref object ppUnk, int cPages, IntPtr pPageClsID, int lcid, int dwReserved, IntPtr pvReserved);

		// Token: 0x04000039 RID: 57
		protected ISpecifyPropertyPages specifyPropertyPages;
	}
}
