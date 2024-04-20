using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace NJRAT
{
	// Token: 0x02000039 RID: 57
	public class IconN
	{
		// Token: 0x060005DC RID: 1500 RVA: 0x00146E70 File Offset: 0x00145270
		[DebuggerNonUserCode]
		public IconN()
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00146E7C File Offset: 0x0014527C
		public static void InjectIcon(string exeFileName, string iconFileName)
		{
			IconN.InjectIcon(exeFileName, iconFileName, 1U, 1U);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00146E8C File Offset: 0x0014528C
		public static void InjectIcon(string exeFileName, string iconFileName, uint iconGroupID, uint iconBaseID)
		{
			IconN.IconFile iconFile = IconN.IconFile.FromFile(iconFileName);
			IntPtr intPtr = IconN.NativeMethods.BeginUpdateResource(exeFileName, false);
			byte[] array = iconFile.CreateIconGroupData(iconBaseID);
			IntPtr intPtr2 = intPtr;
			IntPtr intPtr3 = new IntPtr(14L);
			IntPtr intPtr4 = intPtr3;
			IntPtr intPtr5 = new IntPtr((long)((ulong)iconGroupID));
			IconN.NativeMethods.UpdateResource(intPtr2, intPtr4, intPtr5, 0, array, array.Length);
			int num = 0;
			int num2 = iconFile.ImageCount - 1;
			int num3 = num;
			for (;;)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				byte[] array2 = iconFile.get_ImageData(num3);
				IntPtr intPtr6 = intPtr;
				intPtr5 = new IntPtr(3L);
				IntPtr intPtr7 = intPtr5;
				intPtr3 = new IntPtr((long)((ulong)iconBaseID + (ulong)((long)num3)));
				IconN.NativeMethods.UpdateResource(intPtr6, intPtr7, intPtr3, 0, array2, array2.Length);
				num3++;
			}
			IconN.NativeMethods.EndUpdateResource(intPtr, false);
		}

		// Token: 0x0200003A RID: 58
		[SuppressUnmanagedCodeSecurity]
		private class NativeMethods
		{
			// Token: 0x060005DF RID: 1503 RVA: 0x00146F30 File Offset: 0x00145330
			[DebuggerNonUserCode]
			public NativeMethods()
			{
			}

			// Token: 0x060005E0 RID: 1504
			[DllImport("kernel32")]
			public static extern IntPtr BeginUpdateResource(string fileName, [MarshalAs(UnmanagedType.Bool)] bool deleteExistingResources);

			// Token: 0x060005E1 RID: 1505
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool UpdateResource(IntPtr hUpdate, IntPtr type, IntPtr name, short language, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] data, int dataSize);

			// Token: 0x060005E2 RID: 1506
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool EndUpdateResource(IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool discard);
		}

		// Token: 0x0200003B RID: 59
		private struct ICONDIR
		{
			// Token: 0x0400032C RID: 812
			public ushort Reserved;

			// Token: 0x0400032D RID: 813
			public ushort Type;

			// Token: 0x0400032E RID: 814
			public ushort Count;
		}

		// Token: 0x0200003C RID: 60
		private struct ICONDIRENTRY
		{
			// Token: 0x0400032F RID: 815
			public byte Width;

			// Token: 0x04000330 RID: 816
			public byte Height;

			// Token: 0x04000331 RID: 817
			public byte ColorCount;

			// Token: 0x04000332 RID: 818
			public byte Reserved;

			// Token: 0x04000333 RID: 819
			public ushort Planes;

			// Token: 0x04000334 RID: 820
			public ushort BitCount;

			// Token: 0x04000335 RID: 821
			public int BytesInRes;

			// Token: 0x04000336 RID: 822
			public int ImageOffset;
		}

		// Token: 0x0200003D RID: 61
		private struct BITMAPINFOHEADER
		{
			// Token: 0x04000337 RID: 823
			public uint Size;

			// Token: 0x04000338 RID: 824
			public int Width;

			// Token: 0x04000339 RID: 825
			public int Height;

			// Token: 0x0400033A RID: 826
			public ushort Planes;

			// Token: 0x0400033B RID: 827
			public ushort BitCount;

			// Token: 0x0400033C RID: 828
			public uint Compression;

			// Token: 0x0400033D RID: 829
			public uint SizeImage;

			// Token: 0x0400033E RID: 830
			public int XPelsPerMeter;

			// Token: 0x0400033F RID: 831
			public int YPelsPerMeter;

			// Token: 0x04000340 RID: 832
			public uint ClrUsed;

			// Token: 0x04000341 RID: 833
			public uint ClrImportant;
		}

		// Token: 0x0200003E RID: 62
		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		private struct GRPICONDIRENTRY
		{
			// Token: 0x04000342 RID: 834
			public byte Width;

			// Token: 0x04000343 RID: 835
			public byte Height;

			// Token: 0x04000344 RID: 836
			public byte ColorCount;

			// Token: 0x04000345 RID: 837
			public byte Reserved;

			// Token: 0x04000346 RID: 838
			public ushort Planes;

			// Token: 0x04000347 RID: 839
			public ushort BitCount;

			// Token: 0x04000348 RID: 840
			public int BytesInRes;

			// Token: 0x04000349 RID: 841
			public ushort ID;
		}

		// Token: 0x0200003F RID: 63
		private class IconFile
		{
			// Token: 0x170001E4 RID: 484
			// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00146F3C File Offset: 0x0014533C
			public int ImageCount
			{
				get
				{
					return (int)this.iconDir.Count;
				}
			}

            // Token: 0x170001E5 RID: 485
            // (get) Token: 0x060005E4 RID: 1508 RVA: 0x00146F5C File Offset: 0x0014535C
            public byte[] ImageData(int index)
            {
                return this.iconImage[index];
            }


            // Token: 0x060005E5 RID: 1509 RVA: 0x00146F78 File Offset: 0x00145378
            private IconFile()
			{
				this.iconDir = default(IconN.ICONDIR);
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x00146F90 File Offset: 0x00145390
			public static IconN.IconFile FromFile(string filename)
			{
				IconN.IconFile iconFile = new IconN.IconFile();
				byte[] array = File.ReadAllBytes(filename);
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				iconFile.iconDir = (IconN.ICONDIR)Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), typeof(IconN.ICONDIR));
				iconFile.iconEntry = new IconN.ICONDIRENTRY[(int)(iconFile.iconDir.Count - 1 + 1)];
				iconFile.iconImage = new byte[(int)(iconFile.iconDir.Count - 1 + 1)][];
				int num = Marshal.SizeOf(iconFile.iconDir);
				Type typeFromHandle = typeof(IconN.ICONDIRENTRY);
				int num2 = Marshal.SizeOf(typeFromHandle);
				int num3 = 0;
				int num4 = (int)(iconFile.iconDir.Count - 1);
				int num5 = num3;
				for (;;)
				{
					int num6 = num5;
					int num7 = num4;
					if (num6 > num7)
					{
						break;
					}
					IntPtr intPtr = new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + (long)num);
					IconN.ICONDIRENTRY icondirentry = (IconN.ICONDIRENTRY)Marshal.PtrToStructure(intPtr, typeFromHandle);
					iconFile.iconEntry[num5] = icondirentry;
					iconFile.iconImage[num5] = new byte[icondirentry.BytesInRes - 1 + 1];
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage[num5], 0, icondirentry.BytesInRes);
					num += num2;
					num5++;
				}
				gchandle.Free();
				return iconFile;
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x001470F0 File Offset: 0x001454F0
			public byte[] CreateIconGroupData(uint iconBaseID)
			{
				int num = Marshal.SizeOf(typeof(IconN.ICONDIR)) + Marshal.SizeOf(typeof(IconN.GRPICONDIRENTRY)) * this.ImageCount;
				byte[] array = new byte[num - 1 + 1];
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				Marshal.StructureToPtr(this.iconDir, gchandle.AddrOfPinnedObject(), false);
				int num2 = Marshal.SizeOf(this.iconDir);
				int num3 = 0;
				int num4 = this.ImageCount - 1;
				int num5 = num3;
				for (;;)
				{
					int num6 = num5;
					int num7 = num4;
					if (num6 > num7)
					{
						break;
					}
					IconN.GRPICONDIRENTRY grpicondirentry = default(IconN.GRPICONDIRENTRY);
					IconN.BITMAPINFOHEADER bitmapinfoheader = default(IconN.BITMAPINFOHEADER);
					GCHandle gchandle2 = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned);
					Marshal.Copy(this.get_ImageData(num5), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof(IconN.BITMAPINFOHEADER)));
					gchandle2.Free();
					grpicondirentry.Width = this.iconEntry[num5].Width;
					grpicondirentry.Height = this.iconEntry[num5].Height;
					grpicondirentry.ColorCount = this.iconEntry[num5].ColorCount;
					grpicondirentry.Reserved = this.iconEntry[num5].Reserved;
					grpicondirentry.Planes = bitmapinfoheader.Planes;
					grpicondirentry.BitCount = bitmapinfoheader.BitCount;
					grpicondirentry.BytesInRes = this.iconEntry[num5].BytesInRes;
					grpicondirentry.ID = (ushort)((ulong)iconBaseID + (ulong)((long)num5));
					object obj = grpicondirentry;
					IntPtr intPtr = new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + (long)num2);
					Marshal.StructureToPtr(obj, intPtr, false);
					num2 += Marshal.SizeOf(typeof(IconN.GRPICONDIRENTRY));
					num5++;
				}
				gchandle.Free();
				return array;
			}

            public byte[] get_ImageData(int index)
            {
                return this.iconImage[index];
            }


            // Token: 0x0400034A RID: 842
            private IconN.ICONDIR iconDir;

			// Token: 0x0400034B RID: 843
			private IconN.ICONDIRENTRY[] iconEntry;

			// Token: 0x0400034C RID: 844
			private byte[][] iconImage;
		}
	}
}
