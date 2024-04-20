using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace cam.DShowNET.Device
{
	// Token: 0x02000026 RID: 38
	[ComVisible(false)]
	public class DsDev
	{
		// Token: 0x0600012A RID: 298 RVA: 0x000045A0 File Offset: 0x000027A0
		public static bool GetDevicesOfCat(Guid cat, ref ArrayList devs)
		{
			devs = null;
			object obj = null;
			UCOMIEnumMoniker ucomienumMoniker = null;
			UCOMIMoniker[] array = new UCOMIMoniker[1];
			checked
			{
				bool flag;
				try
				{
					Type typeFromCLSID = Type.GetTypeFromCLSID(Clsid.SystemDeviceEnum);
					obj = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(typeFromCLSID));
					ICreateDevEnum createDevEnum = (ICreateDevEnum)obj;
					int num = createDevEnum.CreateClassEnumerator(ref cat, out ucomienumMoniker, 0);
					int num2 = 0;
					for (;;)
					{
						int num3;
						num = ucomienumMoniker.Next(1, array, out num3);
						if (num != 0)
						{
							break;
						}
						if (array[0] == null)
						{
							break;
						}
						DsDevice dsDevice = new DsDevice();
						dsDevice.Name = DsDev.GetFriendlyName(array[0]);
						if (devs == null)
						{
							devs = new ArrayList();
						}
						dsDevice.Mon = array[0];
						array[0] = null;
						devs.Add(dsDevice);
						num2++;
					}
					flag = num2 > 0;
				}
				catch (Exception ex)
				{
					if (devs != null)
					{
						try
						{
							foreach (object obj2 in devs)
							{
								DsDevice dsDevice2 = (DsDevice)obj2;
								dsDevice2.Dispose();
							}
						}
						finally
						{
							
						}
						devs = null;
					}
					flag = false;
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
				return flag;
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00004714 File Offset: 0x00002914
		private static string GetFriendlyName(UCOMIMoniker mon)
		{
			object obj = null;
			string text2;
			try
			{
				Guid guid = typeof(IPropertyBag).GUID;
				mon.BindToStorage(null, null, ref guid, out obj);
				IPropertyBag propertyBag = (IPropertyBag)obj;
				object obj2 = "";
				int num = propertyBag.Read("FriendlyName", ref obj2, IntPtr.Zero);
				string text = obj2 as string;
				text2 = text;
			}
			catch (Exception ex)
			{
				text2 = null;
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
	}
}
