using System;
using System.Runtime.InteropServices;
using cam.DShowNET;

namespace cam.DirectX.Capture
{
	// Token: 0x02000006 RID: 6
	public class CrossbarSource : Source
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00004210 File Offset: 0x00002410
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00004240 File Offset: 0x00002440
		public override bool Enabled
		{
			get
			{
				int num;
				return this.Crossbar.get_IsRoutedTo(this.OutputPin, out num) == 0 && this.InputPin == num;
			}
			set
			{
				if (value)
				{
					int num = this.Crossbar.Route(this.OutputPin, this.InputPin);
				}
				else
				{
					int num2 = this.Crossbar.Route(this.OutputPin, -1);
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004280 File Offset: 0x00002480
		internal CrossbarSource(IAMCrossbar crossbar, int outputPin, int inputPin, PhysicalConnectorType connectorType)
		{
			this.Crossbar = crossbar;
			this.OutputPin = outputPin;
			this.InputPin = inputPin;
			this.ConnectorType = connectorType;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000042A8 File Offset: 0x000024A8
		private string getName(PhysicalConnectorType connectorType)
		{
			string text;
			if (connectorType == PhysicalConnectorType.Video_Tuner)
			{
				text = "Video Tuner";
			}
			else if (connectorType == PhysicalConnectorType.Video_Composite)
			{
				text = "Video Composite";
			}
			else if (connectorType == PhysicalConnectorType.Video_SVideo)
			{
				text = "Video S-Video";
			}
			else if (connectorType == PhysicalConnectorType.Video_RGB)
			{
				text = "Video RGB";
			}
			else if (connectorType == PhysicalConnectorType.Video_YRYBY)
			{
				text = "Video YRYBY";
			}
			else if (connectorType == PhysicalConnectorType.Video_SerialDigital)
			{
				text = "Video Serial Digital";
			}
			else if (connectorType == PhysicalConnectorType.Video_ParallelDigital)
			{
				text = "Video Parallel Digital";
			}
			else if (connectorType == PhysicalConnectorType.Video_SCSI)
			{
				text = "Video SCSI";
			}
			else if (connectorType == PhysicalConnectorType.Video_AUX)
			{
				text = "Video AUX";
			}
			else if (connectorType == PhysicalConnectorType.Video_1394)
			{
				text = "Video Firewire";
			}
			else if (connectorType == PhysicalConnectorType.Video_USB)
			{
				text = "Video USB";
			}
			else if (connectorType == PhysicalConnectorType.Video_VideoDecoder)
			{
				text = "Video Decoder";
			}
			else if (connectorType == PhysicalConnectorType.Video_VideoEncoder)
			{
				text = "Video Encoder";
			}
			else if (connectorType == PhysicalConnectorType.Video_SCART)
			{
				text = "Video SCART";
			}
			else if (connectorType == PhysicalConnectorType.Audio_Tuner)
			{
				text = "Audio Tuner";
			}
			else if (connectorType == PhysicalConnectorType.Audio_Line)
			{
				text = "Audio Line In";
			}
			else if (connectorType == PhysicalConnectorType.Audio_Mic)
			{
				text = "Audio Mic";
			}
			else if (connectorType == PhysicalConnectorType.Audio_AESDigital)
			{
				text = "Audio AES Digital";
			}
			else if (connectorType == PhysicalConnectorType.Audio_SPDIFDigital)
			{
				text = "Audio SPDIF Digital";
			}
			else if (connectorType == PhysicalConnectorType.Audio_SCSI)
			{
				text = "Audio SCSI";
			}
			else if (connectorType == PhysicalConnectorType.Audio_AUX)
			{
				text = "Audio AUX";
			}
			else if (connectorType == PhysicalConnectorType.Audio_1394)
			{
				text = "Audio Firewire";
			}
			else if (connectorType == PhysicalConnectorType.Audio_USB)
			{
				text = "Audio USB";
			}
			else if (connectorType == PhysicalConnectorType.Audio_AudioDecoder)
			{
				text = "Audio Decoder";
			}
			else
			{
				text = "Unknown Connector";
			}
			return text;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000443C File Offset: 0x0000263C
		public override void Dispose()
		{
			if (this.Crossbar != null)
			{
				Marshal.ReleaseComObject(this.Crossbar);
			}
			this.Crossbar = null;
			base.Dispose();
		}

		// Token: 0x04000035 RID: 53
		internal IAMCrossbar Crossbar;

		// Token: 0x04000036 RID: 54
		internal int OutputPin;

		// Token: 0x04000037 RID: 55
		internal int InputPin;

		// Token: 0x04000038 RID: 56
		internal PhysicalConnectorType ConnectorType;
	}
}
