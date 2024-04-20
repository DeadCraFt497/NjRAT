using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000035 RID: 53
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("211A8761-03AC-11d1-8D13-00AA00BD8339")]
	[ComImport]
	public interface IAMTuner
	{
		// Token: 0x06000157 RID: 343
		[PreserveSig]
		int put_Channel(int lChannel, AMTunerSubChannel lVideoSubChannel, AMTunerSubChannel lAudioSubChannel);

		// Token: 0x06000158 RID: 344
		[PreserveSig]
		int get_Channel(ref int plChannel, ref int plVideoSubChannel, ref int plAudioSubChannel);

		// Token: 0x06000159 RID: 345
		[PreserveSig]
		int ChannelMinMax(ref int lChannelMin, ref int lChannelMax);

		// Token: 0x0600015A RID: 346
		[PreserveSig]
		int put_CountryCode(int lCountryCode);

		// Token: 0x0600015B RID: 347
		[PreserveSig]
		int get_CountryCode(ref int plCountryCode);

		// Token: 0x0600015C RID: 348
		[PreserveSig]
		int put_TuningSpace(int lTuningSpace);

		// Token: 0x0600015D RID: 349
		[PreserveSig]
		int get_TuningSpace(ref int plTuningSpace);

		// Token: 0x0600015E RID: 350
		[PreserveSig]
		int Logon(IntPtr hCurrentUser);

		// Token: 0x0600015F RID: 351
		[PreserveSig]
		int Logout();

		// Token: 0x06000160 RID: 352
		[PreserveSig]
		int SignalPresent(ref AMTunerSignalStrength plSignalStrength);

		// Token: 0x06000161 RID: 353
		[PreserveSig]
		int put_Mode(AMTunerModeType lMode);

		// Token: 0x06000162 RID: 354
		[PreserveSig]
		int get_Mode(ref AMTunerModeType plMode);

		// Token: 0x06000163 RID: 355
		[PreserveSig]
		int GetAvailableModes(ref AMTunerModeType plModes);

		// Token: 0x06000164 RID: 356
		[PreserveSig]
		int RegisterNotificationCallBack(IAMTunerNotification pNotify, AMTunerEventType lEvents);

		// Token: 0x06000165 RID: 357
		[PreserveSig]
		int UnRegisterNotificationCallBack(IAMTunerNotification pNotify);
	}
}
