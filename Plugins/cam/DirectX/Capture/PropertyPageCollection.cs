using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using cam.DShowNET;

namespace cam.DirectX.Capture
{
	// Token: 0x0200005C RID: 92
	public class PropertyPageCollection : CollectionBase, IDisposable
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x00005920 File Offset: 0x00003B20
		internal PropertyPageCollection()
		{
			this.InnerList.Capacity = 1;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00005934 File Offset: 0x00003B34
		internal PropertyPageCollection(ICaptureGraphBuilder2 graphBuilder, IBaseFilter videoDeviceFilter, IBaseFilter audioDeviceFilter, IBaseFilter videoCompressorFilter, IBaseFilter audioCompressorFilter, SourceCollection videoSources, SourceCollection audioSources)
		{
			this.addFromGraph(graphBuilder, videoDeviceFilter, audioDeviceFilter, videoCompressorFilter, audioCompressorFilter, videoSources, audioSources);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00005950 File Offset: 0x00003B50
		~PropertyPageCollection()
		{
			this.Dispose();
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000597C File Offset: 0x00003B7C
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

		// Token: 0x060001F8 RID: 504 RVA: 0x000059BC File Offset: 0x00003BBC
		public void Dispose()
		{
			this.Clear();
			this.InnerList.Capacity = 1;
		}

		// Token: 0x1700001B RID: 27
		public PropertyPage this[int index]
		{
			get
			{
				return (PropertyPage)this.InnerList[index];
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000059F0 File Offset: 0x00003BF0
		protected void addFromGraph(ICaptureGraphBuilder2 graphBuilder, IBaseFilter videoDeviceFilter, IBaseFilter audioDeviceFilter, IBaseFilter videoCompressorFilter, IBaseFilter audioCompressorFilter, SourceCollection videoSources, SourceCollection audioSources)
		{
			object obj = null;
			this.addIfSupported(videoDeviceFilter, "Video Capture Device");
			Guid guid = PinCategory.Capture;
			Guid guid2 = MediaType.Interleaved;
			Guid guid3 = typeof(IAMStreamConfig).GUID;
			int num = graphBuilder.FindInterface(ref guid, ref guid2, videoDeviceFilter, ref guid3, out obj);
			if (num != 0)
			{
				guid2 = MediaType.Video;
				num = graphBuilder.FindInterface(ref guid, ref guid2, videoDeviceFilter, ref guid3, out obj);
				if (num != 0)
				{
					obj = null;
				}
			}
			this.addIfSupported(RuntimeHelpers.GetObjectValue(obj), "Video Capture Pin");
			guid = PinCategory.Preview;
			guid2 = MediaType.Interleaved;
			guid3 = typeof(IAMStreamConfig).GUID;
			num = graphBuilder.FindInterface(ref guid, ref guid2, videoDeviceFilter, ref guid3, out obj);
			if (num != 0)
			{
				guid2 = MediaType.Video;
				num = graphBuilder.FindInterface(ref guid, ref guid2, videoDeviceFilter, ref guid3, out obj);
				if (num != 0)
				{
					obj = null;
				}
			}
			this.addIfSupported(RuntimeHelpers.GetObjectValue(obj), "Video Preview Pin");
			ArrayList arrayList = new ArrayList();
			int num2 = 1;
			int num3 = 0;
			checked
			{
				int num4 = videoSources.Count - 1;
				for (int i = num3; i <= num4; i++)
				{
					CrossbarSource crossbarSource = videoSources[i] as CrossbarSource;
					if (crossbarSource != null && arrayList.IndexOf(crossbarSource.Crossbar) < 0)
					{
						arrayList.Add(crossbarSource.Crossbar);
						if (this.addIfSupported(crossbarSource.Crossbar, "Video Crossbar " + ((num2 == 1) ? "" : num2.ToString())))
						{
							num2++;
						}
					}
				}
				arrayList.Clear();
				this.addIfSupported(videoCompressorFilter, "Video Compressor");
				guid = PinCategory.Capture;
				guid2 = MediaType.Interleaved;
				guid3 = typeof(IAMTVTuner).GUID;
				num = graphBuilder.FindInterface(ref guid, ref guid2, videoDeviceFilter, ref guid3, out obj);
				if (num != 0)
				{
					guid2 = MediaType.Video;
					num = graphBuilder.FindInterface(ref guid, ref guid2, videoDeviceFilter, ref guid3, out obj);
					if (num != 0)
					{
						obj = null;
					}
				}
				this.addIfSupported(RuntimeHelpers.GetObjectValue(obj), "TV Tuner");
				IAMVfwCompressDialogs iamvfwCompressDialogs = videoCompressorFilter as IAMVfwCompressDialogs;
				if (iamvfwCompressDialogs != null)
				{
					VfwCompressorPropertyPage vfwCompressorPropertyPage = new VfwCompressorPropertyPage("Video Compressor", iamvfwCompressDialogs);
					this.InnerList.Add(vfwCompressorPropertyPage);
				}
				this.addIfSupported(audioDeviceFilter, "Audio Capture Device");
				guid = PinCategory.Capture;
				guid2 = MediaType.Audio;
				guid3 = typeof(IAMStreamConfig).GUID;
				num = graphBuilder.FindInterface(ref guid, ref guid2, audioDeviceFilter, ref guid3, out obj);
				if (num != 0)
				{
					obj = null;
				}
				this.addIfSupported(RuntimeHelpers.GetObjectValue(obj), "Audio Capture Pin");
				guid = PinCategory.Preview;
				guid2 = MediaType.Audio;
				guid3 = typeof(IAMStreamConfig).GUID;
				num = graphBuilder.FindInterface(ref guid, ref guid2, audioDeviceFilter, ref guid3, out obj);
				if (num != 0)
				{
					obj = null;
				}
				this.addIfSupported(RuntimeHelpers.GetObjectValue(obj), "Audio Preview Pin");
				num2 = 1;
				int num5 = 0;
				int num6 = audioSources.Count - 1;
				for (int j = num5; j <= num6; j++)
				{
					CrossbarSource crossbarSource2 = audioSources[j] as CrossbarSource;
					if (crossbarSource2 != null && arrayList.IndexOf(crossbarSource2.Crossbar) < 0)
					{
						arrayList.Add(crossbarSource2.Crossbar);
						if (this.addIfSupported(crossbarSource2.Crossbar, "Audio Crossbar " + ((num2 == 1) ? "" : num2.ToString())))
						{
							num2++;
						}
					}
				}
				arrayList.Clear();
				this.addIfSupported(audioCompressorFilter, "Audio Compressor");
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00005D34 File Offset: 0x00003F34
		protected bool addIfSupported(object o, string name)
		{
			ISpecifyPropertyPages specifyPropertyPages = null;
			DsCAUUID dsCAUUID = default(DsCAUUID);
			bool flag = false;
			try
			{
				specifyPropertyPages = o as ISpecifyPropertyPages;
				if (specifyPropertyPages != null)
				{
					int pages = specifyPropertyPages.GetPages(ref dsCAUUID);
					if (pages != 0 || dsCAUUID.cElems <= 0)
					{
						specifyPropertyPages = null;
					}
				}
			}
			finally
			{
				if (dsCAUUID.pElems != IntPtr.Zero)
				{
					Marshal.FreeCoTaskMem(dsCAUUID.pElems);
				}
			}
			if (specifyPropertyPages != null)
			{
				DirectShowPropertyPage directShowPropertyPage = new DirectShowPropertyPage(name, specifyPropertyPages);
				this.InnerList.Add(directShowPropertyPage);
				flag = true;
			}
			return flag;
		}
	}
}
