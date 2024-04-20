using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace plg.My
{
	// Token: 0x0200000E RID: 14
	[StandardModule]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[HideModuleName]
	internal sealed class MySettingsProperty
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000055C4 File Offset: 0x000037C4
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
