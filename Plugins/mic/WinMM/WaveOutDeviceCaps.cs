using System;

namespace WinMM
{
	// Token: 0x02000006 RID: 6
	public class WaveOutDeviceCaps
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00003778 File Offset: 0x00001978
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00003780 File Offset: 0x00001980
		public int DeviceId
		{
			get
			{
				return this.deviceId;
			}
			set
			{
				this.deviceId = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000378C File Offset: 0x0000198C
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00003794 File Offset: 0x00001994
		public string Manufacturer
		{
			get
			{
				return this.manufacturer;
			}
			set
			{
				this.manufacturer = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000037A0 File Offset: 0x000019A0
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000037A8 File Offset: 0x000019A8
		public int ProductId
		{
			get
			{
				return this.productId;
			}
			set
			{
				this.productId = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000037B4 File Offset: 0x000019B4
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000037BC File Offset: 0x000019BC
		public int DriverVersion
		{
			get
			{
				return this.driverVersion;
			}
			set
			{
				this.driverVersion = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000037C8 File Offset: 0x000019C8
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000037D0 File Offset: 0x000019D0
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000037DC File Offset: 0x000019DC
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000037E4 File Offset: 0x000019E4
		public int Channels
		{
			get
			{
				return this.channels;
			}
			set
			{
				this.channels = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000037F0 File Offset: 0x000019F0
		public bool SupportsPitch
		{
			get
			{
				return (this.Capabilities & NativeMethods.WAVECAPS.WAVECAPS_PITCH) != (NativeMethods.WAVECAPS)0;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003800 File Offset: 0x00001A00
		public bool SupportsPlaybackRate
		{
			get
			{
				return (this.Capabilities & NativeMethods.WAVECAPS.WAVECAPS_PLAYBACKRATE) != (NativeMethods.WAVECAPS)0;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003810 File Offset: 0x00001A10
		public bool SupportsVolume
		{
			get
			{
				return (this.Capabilities & NativeMethods.WAVECAPS.WAVECAPS_VOLUME) != (NativeMethods.WAVECAPS)0;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003820 File Offset: 0x00001A20
		public bool SupportsStereoVolume
		{
			get
			{
				return (this.Capabilities & NativeMethods.WAVECAPS.WAVECAPS_LRVOLUME) != (NativeMethods.WAVECAPS)0;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003830 File Offset: 0x00001A30
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00003838 File Offset: 0x00001A38
		internal NativeMethods.WAVECAPS Capabilities
		{
			get
			{
				return this.capabilities;
			}
			set
			{
				this.capabilities = value;
			}
		}

		// Token: 0x0400001D RID: 29
		private int deviceId;

		// Token: 0x0400001E RID: 30
		private string manufacturer;

		// Token: 0x0400001F RID: 31
		private int productId;

		// Token: 0x04000020 RID: 32
		private int driverVersion;

		// Token: 0x04000021 RID: 33
		private string name;

		// Token: 0x04000022 RID: 34
		private int channels;

		// Token: 0x04000023 RID: 35
		private NativeMethods.WAVECAPS capabilities;
	}
}
