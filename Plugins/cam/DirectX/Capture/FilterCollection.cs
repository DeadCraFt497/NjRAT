using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using cam.DShowNET;
using cam.DShowNET.Device;

namespace cam.DirectX.Capture
{
	// Token: 0x02000059 RID: 89
	public class FilterCollection : CollectionBase
	{
		// Token: 0x060001EB RID: 491 RVA: 0x0000578C File Offset: 0x0000398C
		internal FilterCollection(Guid category)
		{
			this.getFilters(category);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000579C File Offset: 0x0000399C
		protected void getFilters(Guid category)
		{
			object obj = null;
			UCOMIEnumMoniker ucomienumMoniker = null;
			UCOMIMoniker[] array = new UCOMIMoniker[1];
			try
			{
				Type typeFromCLSID = Type.GetTypeFromCLSID(Clsid.SystemDeviceEnum);
				obj = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(typeFromCLSID));
				ICreateDevEnum createDevEnum = (ICreateDevEnum)obj;
				int num = createDevEnum.CreateClassEnumerator(ref category, out ucomienumMoniker, 0);
				if (num != 0)
				{
				}
				for (;;)
				{
					int num2;
					num = ucomienumMoniker.Next(1, array, out num2);
					if (num != 0)
					{
						break;
					}
					if (array[0] == null)
					{
						break;
					}
					Filter filter = new Filter(array[0]);
					this.InnerList.Add(filter);
					Marshal.ReleaseComObject(array[0]);
					array[0] = null;
				}
				this.InnerList.Sort();
			}
			finally
			{
				if (array[0] != null)
				{
					Marshal.ReleaseComObject(array[0]);
				}
				array[0] = null;
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
		}

		// Token: 0x17000019 RID: 25
		public Filter this[int index]
		{
			get
			{
				return (Filter)this.InnerList[index];
			}
		}
	}
}
