using System;
using System.Runtime.InteropServices;
using cam.DShowNET;

namespace cam.DirectX.Capture
{
	// Token: 0x02000065 RID: 101
	public class Tuner : IDisposable
	{
		// Token: 0x0600021A RID: 538 RVA: 0x0000625C File Offset: 0x0000445C
		public Tuner(IAMTVTuner tuner__1)
		{
			this.tvTuner = null;
			this.tvTuner = tuner__1;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00006274 File Offset: 0x00004474
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00006294 File Offset: 0x00004494
		public int Channel
		{
			get
			{
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num = this.tvTuner.get_Channel(ref num2, ref num3, ref num4);
				return num2;
			}
			set
			{
				int num = this.tvTuner.put_Channel(value, AMTunerSubChannel.Default, AMTunerSubChannel.Default);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600021D RID: 541 RVA: 0x000062B0 File Offset: 0x000044B0
		// (set) Token: 0x0600021E RID: 542 RVA: 0x000062D4 File Offset: 0x000044D4
		public TunerInputType InputType
		{
			get
			{
				IAMTVTuner iamtvtuner = this.tvTuner;
				int num = 0;
				TunerInputType tunerInputType2 = 0;
				TunerInputType tunerInputType = (TunerInputType)tunerInputType2;
				int num2 = iamtvtuner.get_InputType(num, ref tunerInputType);
				tunerInputType2 = (TunerInputType)tunerInputType;
				return tunerInputType2;
			}
			set
			{
                _ = this.tvTuner.put_InputType(0, (TunerInputType)value);
            }
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000062F4 File Offset: 0x000044F4
		public bool SignalPresent
		{
			get
			{
				AMTunerSignalStrength amtunerSignalStrength = 0;
				int num = this.tvTuner.SignalPresent(ref amtunerSignalStrength);
				return amtunerSignalStrength == AMTunerSignalStrength.SignalPresent;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00006314 File Offset: 0x00004514
		public void Dispose()
		{
			if (this.tvTuner != null)
			{
				Marshal.ReleaseComObject(this.tvTuner);
			}
			this.tvTuner = null;
		}

		// Token: 0x04000178 RID: 376
		protected IAMTVTuner tvTuner;
	}
}
