using System;

namespace cam.DShowNET
{
	// Token: 0x02000012 RID: 18
	public enum DsEvCode
	{
		// Token: 0x0400003F RID: 63
		None,
		// Token: 0x04000040 RID: 64
		Complete,
		// Token: 0x04000041 RID: 65
		UserAbort,
		// Token: 0x04000042 RID: 66
		ErrorAbort,
		// Token: 0x04000043 RID: 67
		Time,
		// Token: 0x04000044 RID: 68
		Repaint,
		// Token: 0x04000045 RID: 69
		StErrStopped,
		// Token: 0x04000046 RID: 70
		StErrStPlaying,
		// Token: 0x04000047 RID: 71
		ErrorStPlaying,
		// Token: 0x04000048 RID: 72
		PaletteChanged,
		// Token: 0x04000049 RID: 73
		VideoSizeChanged,
		// Token: 0x0400004A RID: 74
		QualityChange,
		// Token: 0x0400004B RID: 75
		ShuttingDown,
		// Token: 0x0400004C RID: 76
		ClockChanged,
		// Token: 0x0400004D RID: 77
		Paused,
		// Token: 0x0400004E RID: 78
		OpeningFile = 16,
		// Token: 0x0400004F RID: 79
		BufferingData,
		// Token: 0x04000050 RID: 80
		FullScreenLost,
		// Token: 0x04000051 RID: 81
		Activate,
		// Token: 0x04000052 RID: 82
		NeedRestart,
		// Token: 0x04000053 RID: 83
		WindowDestroyed,
		// Token: 0x04000054 RID: 84
		DisplayChanged,
		// Token: 0x04000055 RID: 85
		Starvation,
		// Token: 0x04000056 RID: 86
		OleEvent,
		// Token: 0x04000057 RID: 87
		NotifyWindow,
		// Token: 0x04000058 RID: 88
		DvdDomChange = 257,
		// Token: 0x04000059 RID: 89
		DvdTitleChange,
		// Token: 0x0400005A RID: 90
		DvdChaptStart,
		// Token: 0x0400005B RID: 91
		DvdAudioStChange,
		// Token: 0x0400005C RID: 92
		DvdSubPicStChange,
		// Token: 0x0400005D RID: 93
		DvdAngleChange,
		// Token: 0x0400005E RID: 94
		DvdButtonChange,
		// Token: 0x0400005F RID: 95
		DvdValidUopsChange,
		// Token: 0x04000060 RID: 96
		DvdStillOn,
		// Token: 0x04000061 RID: 97
		DvdStillOff,
		// Token: 0x04000062 RID: 98
		DvdCurrentTime,
		// Token: 0x04000063 RID: 99
		DvdError,
		// Token: 0x04000064 RID: 100
		DvdWarning,
		// Token: 0x04000065 RID: 101
		DvdChaptAutoStop,
		// Token: 0x04000066 RID: 102
		DvdNoFpPgc,
		// Token: 0x04000067 RID: 103
		DvdPlaybRateChange,
		// Token: 0x04000068 RID: 104
		DvdParentalLChange,
		// Token: 0x04000069 RID: 105
		DvdPlaybStopped,
		// Token: 0x0400006A RID: 106
		DvdAnglesAvail,
		// Token: 0x0400006B RID: 107
		DvdPeriodAStop,
		// Token: 0x0400006C RID: 108
		DvdButtonAActivated,
		// Token: 0x0400006D RID: 109
		DvdCmdStart,
		// Token: 0x0400006E RID: 110
		DvdCmdEnd,
		// Token: 0x0400006F RID: 111
		DvdDiscEjected,
		// Token: 0x04000070 RID: 112
		DvdDiscInserted,
		// Token: 0x04000071 RID: 113
		DvdCurrentHmsfTime,
		// Token: 0x04000072 RID: 114
		DvdKaraokeMode
	}
}
