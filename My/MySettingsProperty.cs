using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NJRAT.My
{
	// Token: 0x0200004A RID: 74
	[DebuggerNonUserCode]
	[HideModuleName]
	[StandardModule]
	[CompilerGenerated]
	internal sealed class MySettingsProperty
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00148A10 File Offset: 0x00146E10
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
