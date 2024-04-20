using System;
using System.Collections;
using System.Runtime.CompilerServices;
using cam.DShowNET;

namespace cam.DirectX.Capture
{
	// Token: 0x02000063 RID: 99
	public class SourceCollection : CollectionBase, IDisposable
	{
		// Token: 0x0600020F RID: 527 RVA: 0x00005E58 File Offset: 0x00004058
		internal SourceCollection()
		{
			this.InnerList.Capacity = 1;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00005E6C File Offset: 0x0000406C
		internal SourceCollection(ICaptureGraphBuilder2 graphBuilder, IBaseFilter deviceFilter, bool isVideoDevice)
		{
			this.addFromGraph(graphBuilder, deviceFilter, isVideoDevice);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00005E80 File Offset: 0x00004080
		~SourceCollection()
		{
			this.Dispose();
		}

		// Token: 0x1700001E RID: 30
		public Source this[int index]
		{
			get
			{
				return (Source)this.InnerList[index];
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00005ECC File Offset: 0x000040CC
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00005F30 File Offset: 0x00004130
		internal Source CurrentSource
		{
			get
			{
				try
				{
					foreach (object obj in this.InnerList)
					{
						Source source = (Source)obj;
						if (source.Enabled)
						{
							return source;
						}
					}
				}
				finally
				{
					
				}
				return null;
			}
			set
			{
				if (value == null)
				{
					try
					{
						foreach (object obj in this.InnerList)
						{
							Source source = (Source)obj;
							source.Enabled = false;
						}
						return;
					}
					finally
					{
						
					}
				}
				if (value is CrossbarSource)
				{
					value.Enabled = true;
				}
				else
				{
					try
					{
						foreach (object obj2 in this.InnerList)
						{
							Source source2 = (Source)obj2;
							source2.Enabled = false;
						}
					}
					finally
					{
						
					}
					value.Enabled = true;
				}
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00005FF4 File Offset: 0x000041F4
		public new void Clear()
		{
			int num = 0;
			checked
			{
				int num2 = this.InnerList.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					this[i].Dispose();
				}
				this.InnerList.Clear();
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00006034 File Offset: 0x00004234
		public void Dispose()
		{
			this.Clear();
			this.InnerList.Capacity = 1;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00006048 File Offset: 0x00004248
		protected void addFromGraph(ICaptureGraphBuilder2 graphBuilder, IBaseFilter deviceFilter, bool isVideoDevice)
		{
			ArrayList arrayList = this.findCrossbars(graphBuilder, deviceFilter);
			try
			{
				foreach (object obj in arrayList)
				{
					IAMCrossbar iamcrossbar = (IAMCrossbar)obj;
					ArrayList arrayList2 = this.findCrossbarSources(graphBuilder, iamcrossbar, isVideoDevice);
					this.InnerList.AddRange(arrayList2);
				}
			}
			finally
			{
				
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000060B8 File Offset: 0x000042B8
		protected ArrayList findCrossbars(ICaptureGraphBuilder2 graphBuilder, IBaseFilter deviceFilter)
		{
			ArrayList arrayList = new ArrayList();
			Guid upstreamOnly = FindDirection.UpstreamOnly;
			Guid guid = default(Guid);
			Guid guid2 = typeof(IAMCrossbar).GUID;
			object obj = null;
			object obj2 = null;
			int num = graphBuilder.FindInterface(ref upstreamOnly, ref guid, deviceFilter, ref guid2, out obj);
			while (num == 0 && obj != null)
			{
				if (obj is IAMCrossbar)
				{
					arrayList.Add(obj as IAMCrossbar);
					num = graphBuilder.FindInterface(ref upstreamOnly, ref guid, obj as IBaseFilter, ref guid2, out obj2);
					obj = RuntimeHelpers.GetObjectValue(obj2);
				}
				else
				{
					obj = null;
				}
			}
			return arrayList;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00006140 File Offset: 0x00004340
		protected ArrayList findCrossbarSources(ICaptureGraphBuilder2 graphBuilder, IAMCrossbar crossbar, bool isVideoDevice)
		{
			ArrayList arrayList = new ArrayList();
			int num2;
			int num3;
			int num = crossbar.get_PinCounts(out num2, out num3);
			int num4 = 0;
			checked
			{
				int num5 = num2 - 1;
				for (int i = num4; i <= num5; i++)
				{
					int num6 = 0;
					int num7 = num3 - 1;
					for (int j = num6; j <= num7; j++)
					{
						num = crossbar.CanRoute(i, j);
						if (num == 0)
						{
							int num8;
							PhysicalConnectorType physicalConnectorType;
							num = crossbar.get_CrossbarPinInfo(true, j, out num8, out physicalConnectorType);
							CrossbarSource crossbarSource = new CrossbarSource(crossbar, i, j, physicalConnectorType);
							if (physicalConnectorType < PhysicalConnectorType.Audio_Tuner)
							{
								if (isVideoDevice)
								{
									arrayList.Add(crossbarSource);
								}
								else if (!isVideoDevice)
								{
									arrayList.Add(crossbarSource);
								}
							}
						}
					}
				}
				int k = 0;
				while (k < arrayList.Count)
				{
					bool flag = false;
					CrossbarSource crossbarSource2 = (CrossbarSource)arrayList[k];
					int num9 = 0;
					int num10 = arrayList.Count - 1;
					for (int l = num9; l <= num10; l++)
					{
						CrossbarSource crossbarSource3 = (CrossbarSource)arrayList[l];
						if (crossbarSource2.OutputPin == crossbarSource3.OutputPin && k != l)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						k++;
					}
					else
					{
						arrayList.RemoveAt(k);
					}
				}
				return arrayList;
			}
		}
	}
}
