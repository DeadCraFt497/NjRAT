using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200003B RID: 59
	[Guid("54C39221-8380-11d0-B3F0-00AA003761C5")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComVisible(true)]
	[ComImport]
	public interface IAMAudioInputMixer
	{
		// Token: 0x06000186 RID: 390
		int put_Enable([In] bool fEnable);

		// Token: 0x06000187 RID: 391
		int get_Enable(out bool pfEnable);

		// Token: 0x06000188 RID: 392
		int put_Mono([In] bool fMono);

		// Token: 0x06000189 RID: 393
		int get_Mono(out bool pfMono);

		// Token: 0x0600018A RID: 394
		int put_MixLevel([In] double Level);

		// Token: 0x0600018B RID: 395
		int get_MixLevel(out double pLevel);

		// Token: 0x0600018C RID: 396
		int put_Pan([In] double Pan);

		// Token: 0x0600018D RID: 397
		int get_Pan(out double pPan);

		// Token: 0x0600018E RID: 398
		int put_Loudness([In] bool fLoudness);

		// Token: 0x0600018F RID: 399
		int get_Loudness(out bool pfLoudness);

		// Token: 0x06000190 RID: 400
		int put_Treble([In] double Treble);

		// Token: 0x06000191 RID: 401
		int get_Treble(out double pTreble);

		// Token: 0x06000192 RID: 402
		int get_TrebleRange(out double pRange);

		// Token: 0x06000193 RID: 403
		int put_Bass([In] double Bass);

		// Token: 0x06000194 RID: 404
		int get_Bass(out double pBass);

		// Token: 0x06000195 RID: 405
		int get_BassRange(out double pRange);
	}
}
