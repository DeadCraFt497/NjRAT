using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml;
using WinMM.Properties;

namespace WinMM
{
	// Token: 0x02000007 RID: 7
	public sealed class WaveOut : IDisposable
	{
		// Token: 0x06000045 RID: 69 RVA: 0x0000384C File Offset: 0x00001A4C
		public WaveOut(int deviceId)
		{
			if (deviceId >= WaveOut.DeviceCount && deviceId != -1)
			{
				throw new ArgumentOutOfRangeException("deviceId", "The Device ID specified was not within the valid range.");
			}
			this.callback = new NativeMethods.waveOutProc(this.InternalCallback);
			this.deviceId = deviceId;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000038C0 File Offset: 0x00001AC0
		~WaveOut()
		{
			this.Dispose(false);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000047 RID: 71 RVA: 0x000038F0 File Offset: 0x00001AF0
		// (remove) Token: 0x06000048 RID: 72 RVA: 0x0000390C File Offset: 0x00001B0C
		public event EventHandler<WaveOutMessageReceivedEventArgs> MessageReceived;

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00003928 File Offset: 0x00001B28
		public static ReadOnlyCollection<WaveOutDeviceCaps> Devices
		{
			get
			{
				return WaveOut.GetAllDeviceCaps().AsReadOnly();
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003934 File Offset: 0x00001B34
		public WaveOutDeviceCaps Capabilities
		{
			get
			{
				if (this.capabilities == null)
				{
					this.capabilities = WaveOut.GetDeviceCaps(this.deviceId);
				}
				return this.capabilities;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003958 File Offset: 0x00001B58
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000039FC File Offset: 0x00001BFC
		public Volume Volume
		{
			get
			{
				uint num = 0U;
				if (this.handle != null && !this.handle.IsInvalid && !this.handle.IsClosed)
				{
					NativeMethods.Throw(NativeMethods.waveOutGetVolume(this.handle, ref num), NativeMethods.ErrorSource.WaveOut);
				}
				else
				{
					NativeMethods.Throw(NativeMethods.waveOutGetVolume((UIntPtr)((uint)this.deviceId), ref num), NativeMethods.ErrorSource.WaveOut);
				}
				uint num2 = num & 65535U;
				uint num3 = num >> 16;
				return new Volume
				{
					Left = num2 / 65535f,
					Right = num3 / 65535f
				};
			}
			set
			{
				float num = Math.Min(Math.Max(value.Left, 0f), 1f);
				float num2 = Math.Min(Math.Max(value.Right, 0f), 1f);
				uint num3 = (uint)(65535f * num);
				uint num4 = (uint)(65535f * num2);
				uint num5 = num3 | (num4 << 16);
				if (this.handle != null && !this.handle.IsInvalid && !this.handle.IsClosed)
				{
					NativeMethods.Throw(NativeMethods.waveOutSetVolume(this.handle, num5), NativeMethods.ErrorSource.WaveOut);
					return;
				}
				NativeMethods.Throw(NativeMethods.waveOutSetVolume((UIntPtr)((uint)this.deviceId), num5), NativeMethods.ErrorSource.WaveOut);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003AB8 File Offset: 0x00001CB8
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public float Pitch
		{
			get
			{
				uint num = 0U;
				NativeMethods.Throw(NativeMethods.waveOutGetPitch(this.handle, ref num), NativeMethods.ErrorSource.WaveOut);
				return WaveOut.FixedToFloat(num);
			}
			set
			{
				NativeMethods.Throw(NativeMethods.waveOutSetPitch(this.handle, WaveOut.FloatToFixed(value)), NativeMethods.ErrorSource.WaveOut);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003B00 File Offset: 0x00001D00
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00003B2C File Offset: 0x00001D2C
		public float PlaybackRate
		{
			get
			{
				uint num = 0U;
				NativeMethods.Throw(NativeMethods.waveOutGetPlaybackRate(this.handle, ref num), NativeMethods.ErrorSource.WaveOut);
				return WaveOut.FixedToFloat(num);
			}
			set
			{
				NativeMethods.Throw(NativeMethods.waveOutSetPlaybackRate(this.handle, WaveOut.FloatToFixed(value)), NativeMethods.ErrorSource.WaveOut);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003B48 File Offset: 0x00001D48
		private static int DeviceCount
		{
			get
			{
				return (int)NativeMethods.waveOutGetNumDevs();
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003B50 File Offset: 0x00001D50
		private static XmlDocument Manufacturers
		{
			get
			{
				if (WaveOut.manufacturers == null)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(Resources.Devices);
					WaveOut.manufacturers = xmlDocument;
				}
				return WaveOut.manufacturers;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003B88 File Offset: 0x00001D88
		public void Open(WaveFormat waveFormat)
		{
			lock (this.startStopLock)
			{
				if (this.handle != null)
				{
					throw new InvalidOperationException("The device is already open.");
				}
				NativeMethods.WAVEFORMATEX waveformatex = default(NativeMethods.WAVEFORMATEX);
				waveformatex.nAvgBytesPerSec = waveFormat.AverageBytesPerSecond;
				waveformatex.wBitsPerSample = waveFormat.BitsPerSample;
				waveformatex.nBlockAlign = waveFormat.BlockAlign;
				waveformatex.nChannels = waveFormat.Channels;
				waveformatex.wFormatTag = (short)waveFormat.FormatTag;
				waveformatex.nSamplesPerSec = waveFormat.SamplesPerSecond;
				waveformatex.cbSize = 0;
				IntPtr intPtr = IntPtr.Zero;
				NativeMethods.Throw(NativeMethods.waveOutOpen(ref intPtr, (uint)this.deviceId, ref waveformatex, this.callback, (IntPtr)0, NativeMethods.WAVEOPENFLAGS.CALLBACK_WINDOW | NativeMethods.WAVEOPENFLAGS.CALLBACK_THREAD | NativeMethods.WAVEOPENFLAGS.WAVE_FORMAT_DIRECT), NativeMethods.ErrorSource.WaveOut);
				this.handle = new WaveOutSafeHandle(intPtr);
				lock (this.bufferingLock)
				{
					this.buffering = true;
					Monitor.Pulse(this.bufferingLock);
				}
				this.bufferMaintainerThread = new Thread(new ThreadStart(this.MaintainBuffers));
				this.bufferMaintainerThread.IsBackground = true;
				this.bufferMaintainerThread.Name = "WaveOut MaintainBuffers thread. (DeviceID = " + this.deviceId + ")";
				this.bufferMaintainerThread.Start();
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003D10 File Offset: 0x00001F10
		public void Close()
		{
			lock (this.startStopLock)
			{
				if (this.handle != null && !this.handle.IsClosed && !this.handle.IsInvalid)
				{
					this.Stop();
					lock (this.bufferingLock)
					{
						this.buffering = false;
						Monitor.Pulse(this.bufferingLock);
					}
					this.bufferMaintainerThread.Join();
					this.handle.Close();
					this.handle = null;
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003DCC File Offset: 0x00001FCC
		public void Write(byte[] bufferData)
		{
			lock (this.startStopLock)
			{
				IntPtr intPtr = Marshal.AllocHGlobal(bufferData.Length);
				Marshal.Copy(bufferData, 0, intPtr, bufferData.Length);
				NativeMethods.WAVEHDR wavehdr = new NativeMethods.WAVEHDR
				{
					dwBufferLength = (uint)bufferData.Length,
					dwFlags = (NativeMethods.WAVEHDRFLAGS)0,
					lpData = intPtr,
					dwUser = new IntPtr(12345)
				};
				IntPtr intPtr2 = Marshal.AllocHGlobal(Marshal.SizeOf(wavehdr));
				Marshal.StructureToPtr(wavehdr, intPtr2, false);
				NativeMethods.Throw(NativeMethods.waveOutPrepareHeader(this.handle, intPtr2, (uint)Marshal.SizeOf(typeof(NativeMethods.WAVEHDR))), NativeMethods.ErrorSource.WaveOut);
				NativeMethods.Throw(NativeMethods.waveOutWrite(this.handle, intPtr2, (uint)Marshal.SizeOf(typeof(NativeMethods.WAVEHDR))), NativeMethods.ErrorSource.WaveOut);
				lock (this.bufferingLock)
				{
					this.bufferQueueCount++;
					Monitor.Pulse(this.bufferingLock);
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003EEC File Offset: 0x000020EC
		public void Pause()
		{
			lock (this.startStopLock)
			{
				NativeMethods.Throw(NativeMethods.waveOutPause(this.handle), NativeMethods.ErrorSource.WaveOut);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003F34 File Offset: 0x00002134
		public void Resume()
		{
			lock (this.startStopLock)
			{
				NativeMethods.Throw(NativeMethods.waveOutRestart(this.handle), NativeMethods.ErrorSource.WaveOut);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003F7C File Offset: 0x0000217C
		public void Stop()
		{
			lock (this.startStopLock)
			{
				NativeMethods.Throw(NativeMethods.waveOutReset(this.handle), NativeMethods.ErrorSource.WaveOut);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003FC4 File Offset: 0x000021C4
		public bool SupportsFormat(WaveFormat waveFormat)
		{
			NativeMethods.WAVEFORMATEX waveformatex = default(NativeMethods.WAVEFORMATEX);
			waveformatex.nAvgBytesPerSec = waveFormat.AverageBytesPerSecond;
			waveformatex.wBitsPerSample = waveFormat.BitsPerSample;
			waveformatex.nBlockAlign = waveFormat.BlockAlign;
			waveformatex.nChannels = waveFormat.Channels;
			waveformatex.wFormatTag = (short)waveFormat.FormatTag;
			waveformatex.nSamplesPerSec = waveFormat.SamplesPerSecond;
			waveformatex.cbSize = 0;
			IntPtr intPtr = new IntPtr(0);
			NativeMethods.MMSYSERROR mmsyserror = NativeMethods.waveOutOpen(ref intPtr, (uint)this.deviceId, ref waveformatex, null, (IntPtr)0, NativeMethods.WAVEOPENFLAGS.WAVE_FORMAT_QUERY);
			if (mmsyserror == NativeMethods.MMSYSERROR.MMSYSERR_NOERROR)
			{
				return true;
			}
			if (mmsyserror == NativeMethods.MMSYSERROR.WAVERR_BADFORMAT)
			{
				return false;
			}
			NativeMethods.Throw(mmsyserror, NativeMethods.ErrorSource.WaveOut);
			return false;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004070 File Offset: 0x00002270
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004080 File Offset: 0x00002280
		private static WaveOutDeviceCaps GetDeviceCaps(int deviceId)
		{
			NativeMethods.WAVEOUTCAPS waveoutcaps = default(NativeMethods.WAVEOUTCAPS);
			NativeMethods.waveOutGetDevCaps(new UIntPtr((uint)deviceId), ref waveoutcaps, (uint)Marshal.SizeOf(waveoutcaps.GetType()));
			return new WaveOutDeviceCaps
			{
				DeviceId = deviceId,
				Channels = (int)waveoutcaps.wChannels,
				DriverVersion = (int)waveoutcaps.vDriverVersion,
				Manufacturer = WaveOut.GetManufacturer(waveoutcaps.wMid),
				Name = waveoutcaps.szPname,
				ProductId = (int)waveoutcaps.wPid,
				Capabilities = waveoutcaps.dwSupport
			};
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004118 File Offset: 0x00002318
		private static string GetManufacturer(ushort manufacturerId)
		{
			XmlDocument xmlDocument = WaveOut.Manufacturers;
			XmlElement xmlElement = null;
			if (xmlDocument != null)
			{
				xmlElement = (XmlElement)xmlDocument.SelectSingleNode("/devices/manufacturer[@id='" + manufacturerId.ToString(CultureInfo.InvariantCulture) + "']");
			}
			if (xmlElement == null)
			{
				return "Unknown [" + manufacturerId + "]";
			}
			return xmlElement.GetAttribute("name");
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004188 File Offset: 0x00002388
		private static uint FloatToFixed(float value)
		{
			short num = (short)value;
			ushort num2 = (ushort)((value - (float)num) * 65535f);
			return (uint)(((int)num << 8) | (int)((uint)num2 >> 8));
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000041B0 File Offset: 0x000023B0
		private static float FixedToFloat(uint value)
		{
			short num = (short)(value >> 8);
			ushort num2 = (ushort)value;
			return (float)num + (float)num2 / 65535f;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000041D4 File Offset: 0x000023D4
		private static List<WaveOutDeviceCaps> GetAllDeviceCaps()
		{
			List<WaveOutDeviceCaps> list = new List<WaveOutDeviceCaps>();
			int deviceCount = WaveOut.DeviceCount;
			for (int i = 0; i < deviceCount; i++)
			{
				list.Add(WaveOut.GetDeviceCaps(i));
			}
			list.Add(WaveOut.GetDeviceCaps(-1));
			return list;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000421C File Offset: 0x0000241C
		private void InternalCallback(IntPtr waveOutHandle, NativeMethods.WAVEOUTMESSAGE message, IntPtr instance, IntPtr param1, IntPtr param2)
		{
			if (message == NativeMethods.WAVEOUTMESSAGE.WOM_DONE)
			{
				lock (this.bufferingLock)
				{
					this.bufferReleaseQueue.Enqueue(param1);
					this.bufferQueueCount--;
					Monitor.Pulse(this.bufferingLock);
				}
			}
			if (this.MessageReceived != null)
			{
				this.MessageReceived(this, new WaveOutMessageReceivedEventArgs((WaveOutMessage)message));
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000042A0 File Offset: 0x000024A0
		private void MaintainBuffers()
		{
			try
			{
				while (this.buffering || this.bufferQueueCount > 0 || this.bufferReleaseQueue.Count > 0)
				{
					lock (this.bufferingLock)
					{
						while (this.bufferReleaseQueue.Count == 0 && (this.bufferQueueCount > 0 || this.buffering))
						{
							Monitor.Wait(this.bufferingLock, 1000);
						}
						goto IL_5B;
					}
					goto IL_55;
					IL_5B:
					if (this.bufferReleaseQueue.Count <= 0)
					{
						continue;
					}
					IL_55:
					this.ProcessDone();
					goto IL_5B;
				}
			}
			catch (ThreadAbortException)
			{
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004360 File Offset: 0x00002560
		private void ProcessDone()
		{
			IntPtr intPtr;
			lock (this.bufferingLock)
			{
				intPtr = this.bufferReleaseQueue.Dequeue();
				Monitor.Pulse(this.bufferingLock);
			}
			IntPtr lpData = ((NativeMethods.WAVEHDR)Marshal.PtrToStructure(intPtr, typeof(NativeMethods.WAVEHDR))).lpData;
			NativeMethods.Throw(NativeMethods.waveOutUnprepareHeader(this.handle, intPtr, (uint)Marshal.SizeOf(typeof(NativeMethods.WAVEHDR))), NativeMethods.ErrorSource.WaveOut);
			Marshal.FreeHGlobal(lpData);
			Marshal.FreeHGlobal(intPtr);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000043F8 File Offset: 0x000025F8
		private void Dispose(bool disposing)
		{
			if (this.handle != null)
			{
				this.Close();
			}
		}

		// Token: 0x04000024 RID: 36
		public const int WaveOutMapperDeviceId = -1;

		// Token: 0x04000025 RID: 37
		private static XmlDocument manufacturers;

		// Token: 0x04000026 RID: 38
		private int deviceId;

		// Token: 0x04000027 RID: 39
		private WaveOutDeviceCaps capabilities;

		// Token: 0x04000028 RID: 40
		private object startStopLock = new object();

		// Token: 0x04000029 RID: 41
		private object bufferingLock = new object();

		// Token: 0x0400002A RID: 42
		private bool buffering;

		// Token: 0x0400002B RID: 43
		private int bufferQueueCount;

		// Token: 0x0400002C RID: 44
		private Queue<IntPtr> bufferReleaseQueue = new Queue<IntPtr>();

		// Token: 0x0400002D RID: 45
		private Thread bufferMaintainerThread;

		// Token: 0x0400002E RID: 46
		private WaveOutSafeHandle handle;

		// Token: 0x0400002F RID: 47
		private NativeMethods.waveOutProc callback;
	}
}
