using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using cam.DShowNET;
using Microsoft.VisualBasic.CompilerServices;

namespace cam.DirectX.Capture
{
	// Token: 0x02000003 RID: 3
	public class Capture : ISampleGrabberCB
	{
        
        // Token: 0x17000002 RID: 2
        // (get) Token: 0x06000012 RID: 18 RVA: 0x00002B3C File Offset: 0x00000D3C
        public bool Capturing
		{
			get
			{
				return this.zgraphState == Capture.GraphState.Capturing;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002B54 File Offset: 0x00000D54
		public bool Cued
		{
			get
			{
				return this.isCaptureRendered && this.zgraphState == Capture.GraphState.Rendered;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002B78 File Offset: 0x00000D78
		public bool Stopped
		{
			get
			{
				return this.zgraphState != Capture.GraphState.Capturing;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002B94 File Offset: 0x00000D94
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002BA8 File Offset: 0x00000DA8
		public string Filename
		{
			get
			{
				return this.m_filename;
			}
			set
			{
				this.assertStopped();
				this.m_filename = value;
				if (this.fileWriterFilter != null)
				{
					AMMediaType ammediaType = new AMMediaType();
					string text;
					int num = this.fileWriterFilter.GetCurFile(out text, ammediaType);
					if (ammediaType.formatSize > 0)
					{
						Marshal.FreeCoTaskMem(ammediaType.formatPtr);
					}
					num = this.fileWriterFilter.SetFileName(this.m_filename, ammediaType);
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002C08 File Offset: 0x00000E08
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002C1C File Offset: 0x00000E1C
		public Control PreviewWindow
		{
			get
			{
				return this.m_previewWindow;
			}
			set
			{
				this.assertStopped();
				this.derenderGraph();
				this.m_previewWindow = value;
				this.wantPreviewRendered = this.m_previewWindow != null && this.m_videoDevice != null;
				this.renderGraph();
				this.startPreviewIfNeeded();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002C58 File Offset: 0x00000E58
		public VideoCapabilities VideoCaps
		{
			get
			{
				if (this.m_videoCaps == null && this.videoStreamConfig != null)
				{
					try
					{
						this.m_videoCaps = new VideoCapabilities(this.videoStreamConfig);
					}
					catch (Exception ex)
					{
					}
				}
				return this.m_videoCaps;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002CAC File Offset: 0x00000EAC
		public Filter VideoDevice
		{
			get
			{
				return this.m_videoDevice;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002CC0 File Offset: 0x00000EC0
		public Filter AudioDevice
		{
			get
			{
				return this.m_audioDevice;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002CD4 File Offset: 0x00000ED4
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002CE8 File Offset: 0x00000EE8
		public Filter VideoCompressor
		{
			get
			{
				return this.m_videoCompressor;
			}
			set
			{
				this.assertStopped();
				this.destroyGraph();
				this.m_videoCompressor = value;
				this.renderGraph();
				this.startPreviewIfNeeded();
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002D0C File Offset: 0x00000F0C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002D20 File Offset: 0x00000F20
		public Filter AudioCompressor
		{
			get
			{
				return this.m_audioCompressor;
			}
			set
			{
				this.assertStopped();
				this.destroyGraph();
				this.m_audioCompressor = value;
				this.renderGraph();
				this.startPreviewIfNeeded();
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002D44 File Offset: 0x00000F44
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002D5C File Offset: 0x00000F5C
		public Source VideoSource
		{
			get
			{
				return this.VideoSources.CurrentSource;
			}
			set
			{
				this.VideoSources.CurrentSource = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002D6C File Offset: 0x00000F6C
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002D84 File Offset: 0x00000F84
		public Source AudioSource
		{
			get
			{
				return this.AudioSources.CurrentSource;
			}
			set
			{
				this.AudioSources.CurrentSource = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002D94 File Offset: 0x00000F94
		public SourceCollection VideoSources
		{
			get
			{
				if (this.m_videoSources == null)
				{
					try
					{
						if (this.m_videoDevice != null)
						{
							this.m_videoSources = new SourceCollection(this.captureGraphBuilder, this.videoDeviceFilter, true);
						}
						else
						{
							this.m_videoSources = new SourceCollection();
						}
					}
					catch (Exception ex)
					{
					}
				}
				return this.m_videoSources;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002DFC File Offset: 0x00000FFC
		public SourceCollection AudioSources
		{
			get
			{
				if (this.m_audioSources == null)
				{
					try
					{
						if (this.m_audioDevice != null)
						{
							this.m_audioSources = new SourceCollection(this.captureGraphBuilder, this.audioDeviceFilter, false);
						}
						else
						{
							this.m_audioSources = new SourceCollection();
						}
					}
					catch (Exception ex)
					{
					}
				}
				return this.m_audioSources;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002E64 File Offset: 0x00001064
		public PropertyPageCollection PropertyPages
		{
			get
			{
				if (this.m_propertyPages == null)
				{
					try
					{
						this.m_propertyPages = new PropertyPageCollection(this.captureGraphBuilder, this.videoDeviceFilter, this.audioDeviceFilter, this.videoCompressorFilter, this.audioCompressorFilter, this.VideoSources, this.AudioSources);
					}
					catch (Exception ex)
					{
					}
				}
				return this.m_propertyPages;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002ED4 File Offset: 0x000010D4
		public Tuner Tuner
		{
			get
			{
				return this.m_tuner;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002EE8 File Offset: 0x000010E8
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002F18 File Offset: 0x00001118
		public double FrameRate
		{
			get
			{
				long num = Conversions.ToLong(this.getStreamConfigSetting(this.videoStreamConfig, "AvgTimePerFrame"));
				return 10000000.0 / (double)num;
			}
			set
			{
				long num = checked((long)Math.Round(Math.Truncate(10000000.0 / value)));
				this.setStreamConfigSetting(this.videoStreamConfig, "AvgTimePerFrame", num);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002F54 File Offset: 0x00001154
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002F94 File Offset: 0x00001194
		public Size FrameSize
		{
			get
			{
				BitmapInfoHeader bitmapInfoHeader = (BitmapInfoHeader)this.getStreamConfigSetting(this.videoStreamConfig, "BmiHeader");
				Size size = new Size(bitmapInfoHeader.Width, bitmapInfoHeader.Height);
				return size;
			}
			set
			{
				BitmapInfoHeader bitmapInfoHeader = (BitmapInfoHeader)this.getStreamConfigSetting(this.videoStreamConfig, "BmiHeader");
				bitmapInfoHeader.Width = value.Width;
				bitmapInfoHeader.Height = value.Height;
				this.setStreamConfigSetting(this.videoStreamConfig, "BmiHeader", bitmapInfoHeader);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002FF4 File Offset: 0x000011F4
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0000301C File Offset: 0x0000121C
		public short AudioChannels
		{
			get
			{
				return Conversions.ToShort(this.getStreamConfigSetting(this.audioStreamConfig, "nChannels"));
			}
			set
			{
				this.setStreamConfigSetting(this.audioStreamConfig, "nChannels", value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003038 File Offset: 0x00001238
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00003060 File Offset: 0x00001260
		public int AudioSamplingRate
		{
			get
			{
				return Conversions.ToInteger(this.getStreamConfigSetting(this.audioStreamConfig, "nSamplesPerSec"));
			}
			set
			{
				this.setStreamConfigSetting(this.audioStreamConfig, "nSamplesPerSec", value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000307C File Offset: 0x0000127C
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000030A4 File Offset: 0x000012A4
		public short AudioSampleSize
		{
			get
			{
				return Conversions.ToShort(this.getStreamConfigSetting(this.audioStreamConfig, "wBitsPerSample"));
			}
			set
			{
				this.setStreamConfigSetting(this.audioStreamConfig, "wBitsPerSample", value);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000032 RID: 50 RVA: 0x000030C0 File Offset: 0x000012C0
		// (remove) Token: 0x06000033 RID: 51 RVA: 0x000030DC File Offset: 0x000012DC
		public event Capture.HeFrame FrameEvent2;

		// Token: 0x06000034 RID: 52 RVA: 0x000030F8 File Offset: 0x000012F8
		public Capture(Filter videoDevice, Filter audioDevice)
		{
			this.zgraphState = Capture.GraphState.Null;
			this.isPreviewRendered = false;
			this.isCaptureRendered = false;
			this.wantPreviewRendered = false;
			this.wantCaptureRendered = false;
			this.rotCookie = 0;
			this.m_videoDevice = null;
			this.m_audioDevice = null;
			this.m_videoCompressor = null;
			this.m_audioCompressor = null;
			this.m_filename = "";
			this.m_previewWindow = null;
			this.m_videoCaps = null;
			this.m_videoSources = null;
			this.m_audioSources = null;
			this.m_propertyPages = null;
			this.m_tuner = null;
			this.captureGraphBuilder = null;
			this.videoStreamConfig = null;
			this.audioStreamConfig = null;
			this.videoDeviceFilter = null;
			this.videoCompressorFilter = null;
			this.audioDeviceFilter = null;
			this.audioCompressorFilter = null;
			this.muxFilter = null;
			this.fileWriterFilter = null;
			this.sampGrabber = null;
			this.m_videoDevice = videoDevice;
			this.m_audioDevice = audioDevice;
			this.Filename = this.getTempFilename();
			this.createGraph();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000031EC File Offset: 0x000013EC
		~Capture()
		{
			this.Dispose();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003218 File Offset: 0x00001418
		public void Cue()
		{
			this.assertStopped();
			this.wantCaptureRendered = true;
			this.renderGraph();
			int num = this.mediaControl.Pause();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003244 File Offset: 0x00001444
		public void Start()
		{
			this.assertStopped();
			this.wantCaptureRendered = true;
			this.renderGraph();
			int num = this.mediaControl.Run();
			this.zgraphState = Capture.GraphState.Capturing;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003278 File Offset: 0x00001478
		public void Stop()
		{
			this.wantCaptureRendered = false;
			if (this.mediaControl != null)
			{
				this.mediaControl.Stop();
			}
			if (this.zgraphState == Capture.GraphState.Capturing)
			{
				this.zgraphState = Capture.GraphState.Rendered;
			}
			try
			{
				this.renderGraph();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.startPreviewIfNeeded();
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000032F4 File Offset: 0x000014F4
		public void Dispose()
		{
			this.wantPreviewRendered = false;
			this.wantCaptureRendered = false;
			try
			{
				this.destroyGraph();
			}
			catch (Exception ex)
			{
			}
			if (this.m_videoSources != null)
			{
				this.m_videoSources.Dispose();
			}
			this.m_videoSources = null;
			if (this.m_audioSources != null)
			{
				this.m_audioSources.Dispose();
			}
			this.m_audioSources = null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003368 File Offset: 0x00001568
		protected void createGraph()
		{
			if (this.zgraphState < Capture.GraphState.Created)
			{
				GC.Collect();
				this.graphBuilder = (IGraphBuilder)Activator.CreateInstance(Type.GetTypeFromCLSID(Clsid.FilterGraph, true));
				Guid captureGraphBuilder = Clsid.CaptureGraphBuilder2;
				Guid guid = typeof(ICaptureGraphBuilder2).GUID;
				this.captureGraphBuilder = (ICaptureGraphBuilder2)DsBugWO.CreateDsInstance(ref captureGraphBuilder, ref guid);
				int num = this.captureGraphBuilder.SetFiltergraph(this.graphBuilder);
				Type typeFromCLSID = Type.GetTypeFromCLSID(Clsid.SampleGrabber);
				object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(typeFromCLSID));
				this.sampGrabber = (ISampleGrabber)objectValue;
				this.baseGrabFlt = (IBaseFilter)this.sampGrabber;
				AMMediaType ammediaType = new AMMediaType();
				if (this.VideoDevice != null)
				{
					this.videoDeviceFilter = (IBaseFilter)Marshal.BindToMoniker(this.VideoDevice.MonikerString);
					num = this.graphBuilder.AddFilter(this.videoDeviceFilter, "Video Capture Device");
					ammediaType.majorType = MediaType.Video;
					ammediaType.subType = MediaSubType.RGB24;
					ammediaType.formatType = FormatType.VideoInfo;
					num = this.sampGrabber.SetMediaType(ammediaType);
					num = this.graphBuilder.AddFilter(this.baseGrabFlt, "Ds.NET Grabber");
				}
				if (this.AudioDevice != null)
				{
					this.audioDeviceFilter = (IBaseFilter)Marshal.BindToMoniker(this.AudioDevice.MonikerString);
					num = this.graphBuilder.AddFilter(this.audioDeviceFilter, "Audio Capture Device");
				}
				if (this.VideoCompressor != null)
				{
					this.videoCompressorFilter = (IBaseFilter)Marshal.BindToMoniker(this.VideoCompressor.MonikerString);
					num = this.graphBuilder.AddFilter(this.videoCompressorFilter, "Video Compressor");
				}
				if (this.AudioCompressor != null)
				{
					this.audioCompressorFilter = (IBaseFilter)Marshal.BindToMoniker(this.AudioCompressor.MonikerString);
					num = this.graphBuilder.AddFilter(this.audioCompressorFilter, "Audio Compressor");
				}
				Guid guid2 = PinCategory.Capture;
				Guid guid3 = MediaType.Interleaved;
				Guid guid4 = typeof(IAMStreamConfig).GUID;
				object obj;
				num = this.captureGraphBuilder.FindInterface(ref guid2, ref guid3, this.videoDeviceFilter, ref guid4, out obj);
				if (num != 0)
				{
					guid3 = MediaType.Video;
					num = this.captureGraphBuilder.FindInterface(ref guid2, ref guid3, this.videoDeviceFilter, ref guid4, out obj);
					if (num != 0)
					{
						obj = null;
					}
				}
				this.videoStreamConfig = obj as IAMStreamConfig;
				obj = null;
				guid2 = PinCategory.Capture;
				guid3 = MediaType.Audio;
				guid4 = typeof(IAMStreamConfig).GUID;
				num = this.captureGraphBuilder.FindInterface(ref guid2, ref guid3, this.audioDeviceFilter, ref guid4, out obj);
				if (num != 0)
				{
					obj = null;
				}
				this.audioStreamConfig = obj as IAMStreamConfig;
				this.mediaControl = (IMediaControl)this.graphBuilder;
				if (this.m_videoSources != null)
				{
					this.m_videoSources.Dispose();
				}
				this.m_videoSources = null;
				if (this.m_audioSources != null)
				{
					this.m_audioSources.Dispose();
				}
				this.m_audioSources = null;
				if (this.m_propertyPages != null)
				{
					this.m_propertyPages.Dispose();
				}
				this.m_propertyPages = null;
				this.m_videoCaps = null;
				obj = null;
				guid2 = PinCategory.Capture;
				guid3 = MediaType.Interleaved;
				guid4 = typeof(IAMTVTuner).GUID;
				num = this.captureGraphBuilder.FindInterface(ref guid2, ref guid3, this.videoDeviceFilter, ref guid4, out obj);
				if (num != 0)
				{
					guid3 = MediaType.Video;
					num = this.captureGraphBuilder.FindInterface(ref guid2, ref guid3, this.videoDeviceFilter, ref guid4, out obj);
					if (num != 0)
					{
						obj = null;
					}
				}
				IAMTVTuner iamtvtuner = obj as IAMTVTuner;
				if (iamtvtuner != null)
				{
					this.m_tuner = new Tuner(iamtvtuner);
				}
				this.videoInfoHeader = (VideoInfoHeader)Marshal.PtrToStructure(ammediaType.formatPtr, typeof(VideoInfoHeader));
				Marshal.FreeCoTaskMem(ammediaType.formatPtr);
				ammediaType.formatPtr = IntPtr.Zero;
				num = this.sampGrabber.SetBufferSamples(false);
				if (num == 0)
				{
					num = this.sampGrabber.SetOneShot(false);
				}
				if (num == 0)
				{
					num = this.sampGrabber.SetCallback(null, 0);
				}
				this.zgraphState = Capture.GraphState.Created;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003768 File Offset: 0x00001968
		protected void renderGraph()
		{
			bool flag = false;
			this.assertStopped();
			if (this.mediaControl != null)
			{
				this.mediaControl.Stop();
			}
			this.createGraph();
			if (!this.wantPreviewRendered && this.isPreviewRendered)
			{
				this.derenderGraph();
			}
			if (!this.wantCaptureRendered && this.isCaptureRendered && this.wantPreviewRendered)
			{
				this.derenderGraph();
			}
			if (this.wantCaptureRendered && !this.isCaptureRendered)
			{
				Guid avi = MediaSubType.Avi;
				int num = this.captureGraphBuilder.SetOutputFileName(ref avi, this.Filename, out this.muxFilter, out this.fileWriterFilter);
				if (this.VideoDevice != null)
				{
					Guid guid = PinCategory.Capture;
					Guid guid2 = MediaType.Interleaved;
					num = this.captureGraphBuilder.RenderStream(ref guid, ref guid2, this.videoDeviceFilter, this.videoCompressorFilter, this.muxFilter);
					if (num < 0)
					{
						guid2 = MediaType.Video;
						num = this.captureGraphBuilder.RenderStream(ref guid, ref guid2, this.videoDeviceFilter, this.videoCompressorFilter, this.muxFilter);
					}
				}
				if (this.AudioDevice != null)
				{
					Guid guid = PinCategory.Capture;
					Guid guid2 = MediaType.Audio;
					num = this.captureGraphBuilder.RenderStream(ref guid, ref guid2, this.audioDeviceFilter, this.audioCompressorFilter, this.muxFilter);
				}
				this.isCaptureRendered = true;
				flag = true;
			}
			if (this.wantPreviewRendered && !this.isPreviewRendered)
			{
				Guid guid = PinCategory.Preview;
				Guid guid2 = MediaType.Video;
				int num = this.captureGraphBuilder.RenderStream(ref guid, ref guid2, this.videoDeviceFilter, this.baseGrabFlt, null);
				this.videoWindow = (IVideoWindow)this.graphBuilder;
				num = this.videoWindow.put_Owner(this.m_previewWindow.Handle);
				num = this.videoWindow.put_WindowStyle(1174405120);
				this.m_previewWindow.Resize += this.onPreviewWindowResize;
				this.onPreviewWindowResize(this, null);
				num = this.videoWindow.put_Visible(-1);
				this.isPreviewRendered = true;
				flag = true;
				AMMediaType ammediaType = new AMMediaType();
				num = this.sampGrabber.GetConnectedMediaType(ammediaType);
				this.videoInfoHeader = (VideoInfoHeader)Marshal.PtrToStructure(ammediaType.formatPtr, typeof(VideoInfoHeader));
				Marshal.FreeCoTaskMem(ammediaType.formatPtr);
				ammediaType.formatPtr = IntPtr.Zero;
			}
			if (flag)
			{
				this.zgraphState = Capture.GraphState.Rendered;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000039B0 File Offset: 0x00001BB0
		protected void startPreviewIfNeeded()
		{
			if (this.wantPreviewRendered && this.isPreviewRendered && !this.isCaptureRendered)
			{
				this.mediaControl.Run();
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000039D8 File Offset: 0x00001BD8
		protected void derenderGraph()
		{
			if (this.mediaControl != null)
			{
				this.mediaControl.Stop();
			}
			if (this.videoWindow != null)
			{
				this.videoWindow.put_Visible(0);
				this.videoWindow.put_Owner(IntPtr.Zero);
				this.videoWindow = null;
			}
			if (this.PreviewWindow != null)
			{
				this.m_previewWindow.Resize -= this.onPreviewWindowResize;
			}
			if (this.zgraphState >= Capture.GraphState.Rendered)
			{
				this.zgraphState = Capture.GraphState.Created;
				this.isCaptureRendered = false;
				this.isPreviewRendered = false;
				if (this.videoDeviceFilter != null)
				{
					this.removeDownstream(this.videoDeviceFilter, this.m_videoCompressor == null);
				}
				if (this.audioDeviceFilter != null)
				{
					this.removeDownstream(this.audioDeviceFilter, this.m_audioCompressor == null);
				}
				this.muxFilter = null;
				this.fileWriterFilter = null;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003AAC File Offset: 0x00001CAC
		protected void removeDownstream(IBaseFilter filter, bool removeFirstFilter)
		{
			IEnumPins enumPins;
			int num = filter.EnumPins(out enumPins);
			enumPins.Reset();
			if (num == 0 && enumPins != null)
			{
				IPin[] array = new IPin[1];
				do
				{
					int num2;
					num = enumPins.Next(1, array, out num2);
					if (num == 0 && array[0] != null)
					{
						IPin pin = null;
						array[0].ConnectedTo(out pin);
						if (pin != null)
						{
							PinInfo pinInfo = default(PinInfo);
							num = pin.QueryPinInfo(out pinInfo);
							if (num == 0 && pinInfo.dir == PinDirection.Input)
							{
								this.removeDownstream(pinInfo.filter, true);
								this.graphBuilder.Disconnect(pin);
								this.graphBuilder.Disconnect(array[0]);
								if (pinInfo.filter == this.videoCompressorFilter && pinInfo.filter == this.audioCompressorFilter)
								{
									this.graphBuilder.RemoveFilter(pinInfo.filter);
								}
							}
							Marshal.ReleaseComObject(pinInfo.filter);
							Marshal.ReleaseComObject(pin);
						}
						Marshal.ReleaseComObject(array[0]);
					}
				}
				while (num == 0);
				Marshal.ReleaseComObject(enumPins);
				enumPins = null;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003BB8 File Offset: 0x00001DB8
		protected void destroyGraph()
		{
			try
			{
				this.derenderGraph();
			}
			catch (Exception ex)
			{
			}
			this.zgraphState = Capture.GraphState.Null;
			this.isCaptureRendered = false;
			this.isPreviewRendered = false;
			if (this.rotCookie != 0)
			{
				DsROT.RemoveGraphFromRot(ref this.rotCookie);
				this.rotCookie = 0;
			}
			if (this.muxFilter != null)
			{
				this.graphBuilder.RemoveFilter(this.muxFilter);
			}
			if (this.videoCompressorFilter != null)
			{
				this.graphBuilder.RemoveFilter(this.videoCompressorFilter);
			}
			if (this.audioCompressorFilter != null)
			{
				this.graphBuilder.RemoveFilter(this.audioCompressorFilter);
			}
			if (this.videoDeviceFilter != null)
			{
				this.graphBuilder.RemoveFilter(this.videoDeviceFilter);
			}
			if (this.audioDeviceFilter != null)
			{
				this.graphBuilder.RemoveFilter(this.audioDeviceFilter);
			}
			if (this.m_videoSources != null)
			{
				this.m_videoSources.Dispose();
			}
			this.m_videoSources = null;
			if (this.m_audioSources != null)
			{
				this.m_audioSources.Dispose();
			}
			this.m_audioSources = null;
			if (this.m_propertyPages != null)
			{
				this.m_propertyPages.Dispose();
			}
			this.m_propertyPages = null;
			if (this.m_tuner != null)
			{
				this.m_tuner.Dispose();
			}
			this.m_tuner = null;
			if (this.graphBuilder != null)
			{
				Marshal.ReleaseComObject(this.graphBuilder);
			}
			this.graphBuilder = null;
			if (this.captureGraphBuilder != null)
			{
				Marshal.ReleaseComObject(this.captureGraphBuilder);
			}
			this.captureGraphBuilder = null;
			if (this.muxFilter != null)
			{
				Marshal.ReleaseComObject(this.muxFilter);
			}
			this.muxFilter = null;
			if (this.fileWriterFilter != null)
			{
				Marshal.ReleaseComObject(this.fileWriterFilter);
			}
			this.fileWriterFilter = null;
			if (this.videoDeviceFilter != null)
			{
				Marshal.ReleaseComObject(this.videoDeviceFilter);
			}
			this.videoDeviceFilter = null;
			if (this.audioDeviceFilter != null)
			{
				Marshal.ReleaseComObject(this.audioDeviceFilter);
			}
			this.audioDeviceFilter = null;
			if (this.videoCompressorFilter != null)
			{
				Marshal.ReleaseComObject(this.videoCompressorFilter);
			}
			this.videoCompressorFilter = null;
			if (this.audioCompressorFilter != null)
			{
				Marshal.ReleaseComObject(this.audioCompressorFilter);
			}
			this.audioCompressorFilter = null;
			this.mediaControl = null;
			this.videoWindow = null;
			GC.Collect();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003DF0 File Offset: 0x00001FF0
		protected void onPreviewWindowResize(object sender, EventArgs e)
		{
			if (this.videoWindow != null)
			{
				Rectangle clientRectangle = this.m_previewWindow.ClientRectangle;
				this.videoWindow.SetWindowPosition(0, 0, clientRectangle.Right, clientRectangle.Bottom);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003E30 File Offset: 0x00002030
		protected string getTempFilename()
		{
			checked
			{
				string text;
				try
				{
					int num = 0;
					Random random = new Random();
					string tempPath = Path.GetTempPath();
					do
					{
						text = Path.Combine(tempPath, random.Next().ToString("X") + ".avi");
						num++;
						if (num > 100)
						{
						}
					}
					while (File.Exists(text));
				}
				catch (Exception ex)
				{
					text = "c:\temp.avi";
				}
				return text;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003EAC File Offset: 0x000020AC
		protected object getStreamConfigSetting(IAMStreamConfig streamConfig, string fieldName)
		{
			this.assertStopped();
			this.derenderGraph();
			object obj = null;
			IntPtr zero = IntPtr.Zero;
			AMMediaType ammediaType = new AMMediaType();
			try
			{
				int format = streamConfig.GetFormat(out zero);
				Marshal.PtrToStructure(zero, ammediaType);
				object obj2 = null;
				if (ammediaType.formatType == FormatType.WaveEx)
				{
					obj2 = new WaveFormatEx();
				}
				else if (ammediaType.formatType == FormatType.VideoInfo)
				{
					obj2 = new VideoInfoHeader();
				}
				else if (ammediaType.formatType == FormatType.VideoInfo2)
				{
					obj2 = new VideoInfoHeader2();
				}
				Marshal.PtrToStructure(ammediaType.formatPtr, RuntimeHelpers.GetObjectValue(obj2));
				Type type = obj2.GetType();
				FieldInfo field = type.GetField(fieldName);
				obj = RuntimeHelpers.GetObjectValue(field.GetValue(RuntimeHelpers.GetObjectValue(obj2)));
			}
			finally
			{
				DsUtils.FreeAMMediaType(ammediaType);
				Marshal.FreeCoTaskMem(zero);
			}
			this.renderGraph();
			this.startPreviewIfNeeded();
			return obj;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003F98 File Offset: 0x00002198
		protected object setStreamConfigSetting(IAMStreamConfig streamConfig, string fieldName, object newValue)
		{
			this.assertStopped();
			this.derenderGraph();
			object obj = new WaveFormatEx();
			IntPtr zero = IntPtr.Zero;
			AMMediaType ammediaType = new AMMediaType();
			try
			{
				int num = streamConfig.GetFormat(out zero);
				Marshal.PtrToStructure(zero, ammediaType);
				object obj2 = null;
				if (ammediaType.formatType == FormatType.WaveEx)
				{
					obj2 = new WaveFormatEx();
				}
				else if (ammediaType.formatType == FormatType.VideoInfo)
				{
					obj2 = new VideoInfoHeader();
				}
				else if (ammediaType.formatType == FormatType.VideoInfo2)
				{
					obj2 = new VideoInfoHeader2();
				}
				Marshal.PtrToStructure(ammediaType.formatPtr, RuntimeHelpers.GetObjectValue(obj2));
				Type type = obj2.GetType();
				FieldInfo field = type.GetField(fieldName);
				field.SetValue(RuntimeHelpers.GetObjectValue(obj2), RuntimeHelpers.GetObjectValue(newValue));
				Marshal.StructureToPtr(RuntimeHelpers.GetObjectValue(obj2), ammediaType.formatPtr, false);
				num = streamConfig.SetFormat(ammediaType);
			}
			finally
			{
				DsUtils.FreeAMMediaType(ammediaType);
				Marshal.FreeCoTaskMem(zero);
			}
			this.renderGraph();
			this.startPreviewIfNeeded();
			return obj;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000040A0 File Offset: 0x000022A0
		protected void assertStopped()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000040A4 File Offset: 0x000022A4
		int ISampleGrabberCB.ISampleGrabberCB_SampleCB(double SampleTime, IMediaSample pSample)
		{
			return 0;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000040B4 File Offset: 0x000022B4
		int ISampleGrabberCB.ISampleGrabberCB_BufferCB(double SampleTime, IntPtr pBuffer, int BufferLen)
		{
			checked
			{
				try
				{
					this.bufferedSize = BufferLen;
					int width = this.videoInfoHeader.BmiHeader.Width;
					int height = this.videoInfoHeader.BmiHeader.Height;
					int num = width * 3;
					Marshal.Copy(pBuffer, this.savedArray, 0, BufferLen);
					GCHandle gchandle = GCHandle.Alloc(this.savedArray, GCHandleType.Pinned);
					int num2 = (int)gchandle.AddrOfPinnedObject();
					num2 += (height - 1) * num;
					Bitmap bitmap = new Bitmap(width, height, 0 - num, PixelFormat.Format24bppRgb, (IntPtr)num2);
					gchandle.Free();
					this.SetBitmap = bitmap;
				}
				catch (Exception ex)
				{
				}
				return 0;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004170 File Offset: 0x00002370
		private void OnCaptureDone()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004174 File Offset: 0x00002374
		public void GrapImg()
		{
			try
			{
				if (this.savedArray == null)
				{
					int imageSize = this.videoInfoHeader.BmiHeader.ImageSize;
					if (imageSize < 1000 || imageSize > 16000000)
					{
						return;
					}
					this.savedArray = new byte[checked(imageSize + 63999 + 1)];
				}
				this.sampGrabber.SetCallback(this, 1);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000041F0 File Offset: 0x000023F0
		public Bitmap SetBitmap
		{
			set
			{
				Capture.HeFrame frameEvent2Event = this.FrameEvent2Event;
				if (frameEvent2Event != null)
				{
					frameEvent2Event(value);
				}
			}
		}

        private void FrameEvent2Event(Bitmap BM)
        {
            throw new NotImplementedException();
        }

        // Token: 0x0400000D RID: 13
        protected Capture.GraphState zgraphState;

		// Token: 0x0400000E RID: 14
		protected bool isPreviewRendered;

		// Token: 0x0400000F RID: 15
		protected bool isCaptureRendered;

		// Token: 0x04000010 RID: 16
		protected bool wantPreviewRendered;

		// Token: 0x04000011 RID: 17
		protected bool wantCaptureRendered;

		// Token: 0x04000012 RID: 18
		protected int rotCookie;

		// Token: 0x04000013 RID: 19
		protected Filter m_videoDevice;

		// Token: 0x04000014 RID: 20
		protected Filter m_audioDevice;

		// Token: 0x04000015 RID: 21
		protected Filter m_videoCompressor;

		// Token: 0x04000016 RID: 22
		protected Filter m_audioCompressor;

		// Token: 0x04000017 RID: 23
		protected string m_filename;

		// Token: 0x04000018 RID: 24
		protected Control m_previewWindow;

		// Token: 0x04000019 RID: 25
		protected VideoCapabilities m_videoCaps;

		// Token: 0x0400001A RID: 26
		protected SourceCollection m_videoSources;

		// Token: 0x0400001B RID: 27
		protected SourceCollection m_audioSources;

		// Token: 0x0400001C RID: 28
		protected PropertyPageCollection m_propertyPages;

		// Token: 0x0400001D RID: 29
		protected Tuner m_tuner;

		// Token: 0x0400001E RID: 30
		protected IGraphBuilder graphBuilder;

		// Token: 0x0400001F RID: 31
		protected IMediaControl mediaControl;

		// Token: 0x04000020 RID: 32
		protected IVideoWindow videoWindow;

		// Token: 0x04000021 RID: 33
		protected ICaptureGraphBuilder2 captureGraphBuilder;

		// Token: 0x04000022 RID: 34
		protected IAMStreamConfig videoStreamConfig;

		// Token: 0x04000023 RID: 35
		protected IAMStreamConfig audioStreamConfig;

		// Token: 0x04000024 RID: 36
		protected IBaseFilter videoDeviceFilter;

		// Token: 0x04000025 RID: 37
		protected IBaseFilter videoCompressorFilter;

		// Token: 0x04000026 RID: 38
		protected IBaseFilter audioDeviceFilter;

		// Token: 0x04000027 RID: 39
		protected IBaseFilter audioCompressorFilter;

		// Token: 0x04000028 RID: 40
		protected IBaseFilter muxFilter;

		// Token: 0x04000029 RID: 41
		protected IFileSinkFilter fileWriterFilter;

		// Token: 0x0400002A RID: 42
		private IBaseFilter baseGrabFlt;

		// Token: 0x0400002B RID: 43
		protected ISampleGrabber sampGrabber;

		// Token: 0x0400002C RID: 44
		private VideoInfoHeader videoInfoHeader;

		// Token: 0x0400002E RID: 46
		private byte[] savedArray;

		// Token: 0x0400002F RID: 47
		private int bufferedSize;

		// Token: 0x02000004 RID: 4
		protected enum GraphState
		{
			// Token: 0x04000031 RID: 49
			Null,
			// Token: 0x04000032 RID: 50
			Created,
			// Token: 0x04000033 RID: 51
			Rendered,
			// Token: 0x04000034 RID: 52
			Capturing
		}

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600004D RID: 77
		public delegate void HeFrame(Bitmap BM);

        public int SampleCB(double SampleTime, IMediaSample pSample)
        {
            throw new NotImplementedException();
        }

        public int BufferCB(double SampleTime, IntPtr pBuffer, int BufferLen)
        {
            throw new NotImplementedException();
        }
    }
}
