using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200000E RID: 14
	[Guid("56a868b4-0ad4-11ce-b03a-0020af0ba770")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	[ComImport]
	public interface IVideoWindow
	{
		// Token: 0x06000093 RID: 147
		[PreserveSig]
		int put_Caption(string caption);

		// Token: 0x06000094 RID: 148
		[PreserveSig]
		int get_Caption(out string caption);

		// Token: 0x06000095 RID: 149
		[PreserveSig]
		int put_WindowStyle(int windowStyle);

		// Token: 0x06000096 RID: 150
		[PreserveSig]
		int get_WindowStyle(ref int windowStyle);

		// Token: 0x06000097 RID: 151
		[PreserveSig]
		int put_WindowStyleEx(int windowStyleEx);

		// Token: 0x06000098 RID: 152
		[PreserveSig]
		int get_WindowStyleEx(ref int windowStyleEx);

		// Token: 0x06000099 RID: 153
		[PreserveSig]
		int put_AutoShow(int autoShow);

		// Token: 0x0600009A RID: 154
		[PreserveSig]
		int get_AutoShow(ref int autoShow);

		// Token: 0x0600009B RID: 155
		[PreserveSig]
		int put_WindowState(int windowState);

		// Token: 0x0600009C RID: 156
		[PreserveSig]
		int get_WindowState(ref int windowState);

		// Token: 0x0600009D RID: 157
		[PreserveSig]
		int put_BackgroundPalette(int backgroundPalette);

		// Token: 0x0600009E RID: 158
		[PreserveSig]
		int get_BackgroundPalette(ref int backgroundPalette);

		// Token: 0x0600009F RID: 159
		[PreserveSig]
		int put_Visible(int visible);

		// Token: 0x060000A0 RID: 160
		[PreserveSig]
		int get_Visible(ref int visible);

		// Token: 0x060000A1 RID: 161
		[PreserveSig]
		int put_Left(int left);

		// Token: 0x060000A2 RID: 162
		[PreserveSig]
		int get_Left(ref int left);

		// Token: 0x060000A3 RID: 163
		[PreserveSig]
		int put_Width(int width);

		// Token: 0x060000A4 RID: 164
		[PreserveSig]
		int get_Width(ref int width);

		// Token: 0x060000A5 RID: 165
		[PreserveSig]
		int put_Top(int top);

		// Token: 0x060000A6 RID: 166
		[PreserveSig]
		int get_Top(ref int top);

		// Token: 0x060000A7 RID: 167
		[PreserveSig]
		int put_Height(int height);

		// Token: 0x060000A8 RID: 168
		[PreserveSig]
		int get_Height(ref int height);

		// Token: 0x060000A9 RID: 169
		[PreserveSig]
		int put_Owner(IntPtr owner);

		// Token: 0x060000AA RID: 170
		[PreserveSig]
		int get_Owner(ref IntPtr owner);

		// Token: 0x060000AB RID: 171
		[PreserveSig]
		int put_MessageDrain(IntPtr drain);

		// Token: 0x060000AC RID: 172
		[PreserveSig]
		int get_MessageDrain(ref IntPtr drain);

		// Token: 0x060000AD RID: 173
		[PreserveSig]
		int get_BorderColor(ref int color);

		// Token: 0x060000AE RID: 174
		[PreserveSig]
		int put_BorderColor(int color);

		// Token: 0x060000AF RID: 175
		[PreserveSig]
		int get_FullScreenMode(ref int fullScreenMode);

		// Token: 0x060000B0 RID: 176
		[PreserveSig]
		int put_FullScreenMode(int fullScreenMode);

		// Token: 0x060000B1 RID: 177
		[PreserveSig]
		int SetWindowForeground(int focus);

		// Token: 0x060000B2 RID: 178
		[PreserveSig]
		int NotifyOwnerMessage(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x060000B3 RID: 179
		[PreserveSig]
		int SetWindowPosition(int left, int top, int width, int height);

		// Token: 0x060000B4 RID: 180
		[PreserveSig]
		int GetWindowPosition(ref int left, ref int top, ref int width, ref int height);

		// Token: 0x060000B5 RID: 181
		[PreserveSig]
		int GetMinIdealImageSize(ref int width, ref int height);

		// Token: 0x060000B6 RID: 182
		[PreserveSig]
		int GetMaxIdealImageSize(ref int width, ref int height);

		// Token: 0x060000B7 RID: 183
		[PreserveSig]
		int GetRestorePosition(ref int left, ref int top, ref int width, ref int height);

		// Token: 0x060000B8 RID: 184
		[PreserveSig]
		int HideCursor(int hideCursor__1);

		// Token: 0x060000B9 RID: 185
		[PreserveSig]
		int IsCursorHidden(ref int hideCursor);
	}
}
