using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000039 RID: 57
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("211A8766-03AC-11d1-8D13-00AA00BD8339")]
	[ComImport]
	public interface IAMTVTuner
	{
		// Token: 0x06000167 RID: 359
		[PreserveSig]
		int put_Channel(int lChannel, AMTunerSubChannel lVideoSubChannel, AMTunerSubChannel lAudioSubChannel);

		// Token: 0x06000168 RID: 360
		[PreserveSig]
		int get_Channel(ref int plChannel, ref int plVideoSubChannel, ref int plAudioSubChannel);

		// Token: 0x06000169 RID: 361
		[PreserveSig]
		int ChannelMinMax(ref int lChannelMin, ref int lChannelMax);

		// Token: 0x0600016A RID: 362
		[PreserveSig]
		int put_CountryCode(int lCountryCode);

		// Token: 0x0600016B RID: 363
		[PreserveSig]
		int get_CountryCode(ref int plCountryCode);

		// Token: 0x0600016C RID: 364
		[PreserveSig]
		int put_TuningSpace(int lTuningSpace);

		// Token: 0x0600016D RID: 365
		[PreserveSig]
		int get_TuningSpace(ref int plTuningSpace);

		// Token: 0x0600016E RID: 366
		[PreserveSig]
		int Logon(IntPtr hCurrentUser);

		// Token: 0x0600016F RID: 367
		[PreserveSig]
		int Logout();

		// Token: 0x06000170 RID: 368
		[PreserveSig]
		int SignalPresent(ref AMTunerSignalStrength plSignalStrength);

		// Token: 0x06000171 RID: 369
		[PreserveSig]
		int put_Mode(AMTunerModeType lMode);

		// Token: 0x06000172 RID: 370
		[PreserveSig]
		int get_Mode(ref AMTunerModeType plMode);

		// Token: 0x06000173 RID: 371
		[PreserveSig]
		int GetAvailableModes(ref AMTunerModeType plModes);

		// Token: 0x06000174 RID: 372
		[PreserveSig]
		int RegisterNotificationCallBack(IAMTunerNotification pNotify, AMTunerEventType lEvents);

		// Token: 0x06000175 RID: 373
		[PreserveSig]
		int UnRegisterNotificationCallBack(IAMTunerNotification pNotify);

		// Token: 0x06000176 RID: 374
		[PreserveSig]
		int get_AvailableTVFormats(ref AnalogVideoStandard lAnalogVideoStandard);

		// Token: 0x06000177 RID: 375
		[PreserveSig]
		int get_TVFormat(ref AnalogVideoStandard lAnalogVideoStandard);

		// Token: 0x06000178 RID: 376
		[PreserveSig]
		int AutoTune(int lChannel, ref int plFoundSignal);

		// Token: 0x06000179 RID: 377
		[PreserveSig]
		int StoreAutoTune();

		// Token: 0x0600017A RID: 378
		[PreserveSig]
		int get_NumInputConnections(ref int plNumInputConnections);

		// Token: 0x0600017B RID: 379
		[PreserveSig]
		int put_InputType(int lIndex, TunerInputType inputType);

		// Token: 0x0600017C RID: 380
		[PreserveSig]
		int get_InputType(int lIndex, ref TunerInputType inputType);

		// Token: 0x0600017D RID: 381
		[PreserveSig]
		int put_ConnectInput(int lIndex);

		// Token: 0x0600017E RID: 382
		[PreserveSig]
		int get_ConnectInput(ref int lIndex);

		// Token: 0x0600017F RID: 383
		[PreserveSig]
		int get_VideoFrequency(ref int lFreq);

		// Token: 0x06000180 RID: 384
		[PreserveSig]
		int get_AudioFrequency(ref int lFreq);
        int get_InputType(int num, ref DirectX.Capture.TunerInputType tunerInputType);
        int put_InputType(int v, DirectX.Capture.TunerInputType value);
    }
}
