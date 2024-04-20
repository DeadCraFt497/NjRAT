using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace pw.My.Resources
{
	// Token: 0x0200000B RID: 11
	[StandardModule]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[HideModuleName]
	internal sealed class Resources
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00038C8C File Offset: 0x0003708C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("pw.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00038CCC File Offset: 0x000370CC
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00038CE0 File Offset: 0x000370E0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00038CE8 File Offset: 0x000370E8
		internal static byte[] BR
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("BR", Resources.resourceCulture));
				return (byte[])objectValue;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00038D18 File Offset: 0x00037118
		internal static string String1
		{
			get
			{
				return Resources.ResourceManager.GetString("String1", Resources.resourceCulture);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00038D3C File Offset: 0x0003713C
		internal static string String2
		{
			get
			{
				return Resources.ResourceManager.GetString("String2", Resources.resourceCulture);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00038D60 File Offset: 0x00037160
		internal static string String3
		{
			get
			{
				return Resources.ResourceManager.GetString("String3", Resources.resourceCulture);
			}
		}

		// Token: 0x04000022 RID: 34
		private static ResourceManager resourceMan;

		// Token: 0x04000023 RID: 35
		private static CultureInfo resourceCulture;
	}
}
