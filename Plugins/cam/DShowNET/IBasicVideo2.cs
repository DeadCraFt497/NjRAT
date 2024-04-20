using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200000D RID: 13
	[Guid("329bb360-f6ea-11d1-9038-00a0c9697298")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComImport]
	public interface IBasicVideo2
	{
		// Token: 0x06000072 RID: 114
		[PreserveSig]
		int AvgTimePerFrame(ref double pAvgTimePerFrame);

		// Token: 0x06000073 RID: 115
		[PreserveSig]
		int BitRate(ref int pBitRate);

		// Token: 0x06000074 RID: 116
		[PreserveSig]
		int BitErrorRate(ref int pBitRate);

		// Token: 0x06000075 RID: 117
		[PreserveSig]
		int VideoWidth(ref int pVideoWidth);

		// Token: 0x06000076 RID: 118
		[PreserveSig]
		int VideoHeight(ref int pVideoHeight);

		// Token: 0x06000077 RID: 119
		[PreserveSig]
		int put_SourceLeft(int SourceLeft);

		// Token: 0x06000078 RID: 120
		[PreserveSig]
		int get_SourceLeft(ref int pSourceLeft);

		// Token: 0x06000079 RID: 121
		[PreserveSig]
		int put_SourceWidth(int SourceWidth);

		// Token: 0x0600007A RID: 122
		[PreserveSig]
		int get_SourceWidth(ref int pSourceWidth);

		// Token: 0x0600007B RID: 123
		[PreserveSig]
		int put_SourceTop(int SourceTop);

		// Token: 0x0600007C RID: 124
		[PreserveSig]
		int get_SourceTop(ref int pSourceTop);

		// Token: 0x0600007D RID: 125
		[PreserveSig]
		int put_SourceHeight(int SourceHeight);

		// Token: 0x0600007E RID: 126
		[PreserveSig]
		int get_SourceHeight(ref int pSourceHeight);

		// Token: 0x0600007F RID: 127
		[PreserveSig]
		int put_DestinationLeft(int DestinationLeft);

		// Token: 0x06000080 RID: 128
		[PreserveSig]
		int get_DestinationLeft(ref int pDestinationLeft);

		// Token: 0x06000081 RID: 129
		[PreserveSig]
		int put_DestinationWidth(int DestinationWidth);

		// Token: 0x06000082 RID: 130
		[PreserveSig]
		int get_DestinationWidth(ref int pDestinationWidth);

		// Token: 0x06000083 RID: 131
		[PreserveSig]
		int put_DestinationTop(int DestinationTop);

		// Token: 0x06000084 RID: 132
		[PreserveSig]
		int get_DestinationTop(ref int pDestinationTop);

		// Token: 0x06000085 RID: 133
		[PreserveSig]
		int put_DestinationHeight(int DestinationHeight);

		// Token: 0x06000086 RID: 134
		[PreserveSig]
		int get_DestinationHeight(ref int pDestinationHeight);

		// Token: 0x06000087 RID: 135
		[PreserveSig]
		int SetSourcePosition(int left, int top, int width, int height);

		// Token: 0x06000088 RID: 136
		[PreserveSig]
		int GetSourcePosition(ref int left, ref int top, ref int width, ref int height);

		// Token: 0x06000089 RID: 137
		[PreserveSig]
		int SetDefaultSourcePosition();

		// Token: 0x0600008A RID: 138
		[PreserveSig]
		int SetDestinationPosition(int left, int top, int width, int height);

		// Token: 0x0600008B RID: 139
		[PreserveSig]
		int GetDestinationPosition(ref int left, ref int top, ref int width, ref int height);

		// Token: 0x0600008C RID: 140
		[PreserveSig]
		int SetDefaultDestinationPosition();

		// Token: 0x0600008D RID: 141
		[PreserveSig]
		int GetVideoSize(ref int pWidth, ref int pHeight);

		// Token: 0x0600008E RID: 142
		[PreserveSig]
		int GetVideoPaletteEntries(int StartIndex, int Entries, ref int pRetrieved, IntPtr pPalette);

		// Token: 0x0600008F RID: 143
		[PreserveSig]
		int GetCurrentImage(ref int pBufferSize, IntPtr pDIBImage);

		// Token: 0x06000090 RID: 144
		[PreserveSig]
		int IsUsingDefaultSource();

		// Token: 0x06000091 RID: 145
		[PreserveSig]
		int IsUsingDefaultDestination();

		// Token: 0x06000092 RID: 146
		[PreserveSig]
		int GetPreferredAspectRatio(ref int plAspectX, ref int plAspectY);
	}
}
