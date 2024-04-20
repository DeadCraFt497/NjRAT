using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using cam.DShowNET;
using cam.DShowNET.Device;

namespace cam.DirectX.Capture
{
	// Token: 0x02000058 RID: 88
	public class Filter : IComparable
	{
		// Token: 0x060001E4 RID: 484 RVA: 0x00005568 File Offset: 0x00003768
		public Filter(string monikerString__1)
		{
			this.Name = this.getName(monikerString__1);
			this.MonikerString = monikerString__1;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00005584 File Offset: 0x00003784
		internal Filter(UCOMIMoniker moniker)
		{
			this.Name = this.getName(moniker);
			this.MonikerString = this.getMonikerString(moniker);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000055A8 File Offset: 0x000037A8
		protected string getMonikerString(UCOMIMoniker moniker)
		{
			string text;
			moniker.GetDisplayName(null, null, out text);
			return text;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000055C0 File Offset: 0x000037C0
		protected string getName(UCOMIMoniker moniker)
		{
			object obj = null;
			string text2;
			try
			{
				Guid guid = typeof(IPropertyBag).GUID;
				moniker.BindToStorage(null, null, ref guid, out obj);
				IPropertyBag propertyBag = (IPropertyBag)obj;
				object obj2 = "";
				int num = propertyBag.Read("FriendlyName", ref obj2, IntPtr.Zero);
				string text = obj2 as string;
				text2 = text;
			}
			catch (Exception ex)
			{
				text2 = "";
			}
			finally
			{
				if (obj != null)
				{
					Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
				}
				obj = null;
			}
			return text2;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00005664 File Offset: 0x00003864
		protected string getName(string monikerString)
		{
			UCOMIMoniker ucomimoniker = null;
			UCOMIMoniker ucomimoniker2 = null;
			string name;
			try
			{
				ucomimoniker = this.getAnyMoniker();
				int num;
				ucomimoniker.ParseDisplayName(null, null, monikerString, out num, out ucomimoniker2);
				name = this.getName(ucomimoniker);
			}
			finally
			{
				if (ucomimoniker != null)
				{
					Marshal.ReleaseComObject(ucomimoniker);
				}
				ucomimoniker = null;
				if (ucomimoniker2 != null)
				{
					Marshal.ReleaseComObject(ucomimoniker2);
				}
				ucomimoniker2 = null;
			}
			return name;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000056C0 File Offset: 0x000038C0
		protected UCOMIMoniker getAnyMoniker()
		{
			Guid videoCompressorCategory = FilterCategory.VideoCompressorCategory;
			object obj = null;
			UCOMIEnumMoniker ucomienumMoniker = null;
			UCOMIMoniker[] array = new UCOMIMoniker[1];
			UCOMIMoniker ucomimoniker;
			try
			{
				Type typeFromCLSID = Type.GetTypeFromCLSID(Clsid.SystemDeviceEnum);
				obj = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(typeFromCLSID));
				ICreateDevEnum createDevEnum = (ICreateDevEnum)obj;
				int num = createDevEnum.CreateClassEnumerator(ref videoCompressorCategory, out ucomienumMoniker, 0);
				int num2;
				num = ucomienumMoniker.Next(1, array, out num2);
				if (num != 0)
				{
					array[0] = null;
				}
				ucomimoniker = array[0];
			}
			finally
			{
				if (ucomienumMoniker != null)
				{
					Marshal.ReleaseComObject(ucomienumMoniker);
				}
				ucomienumMoniker = null;
				if (obj != null)
				{
					Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
				}
				obj = null;
			}
			return ucomimoniker;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00005760 File Offset: 0x00003960
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			Filter filter = (Filter)obj;
			return this.Name.CompareTo(filter.Name);
		}

		// Token: 0x04000153 RID: 339
		public string Name;

		// Token: 0x04000154 RID: 340
		public string MonikerString;
	}
}
