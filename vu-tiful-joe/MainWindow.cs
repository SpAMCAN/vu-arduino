using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OpenHardwareMonitor.Hardware;
using System.Runtime.InteropServices;


namespace vu_tiful_joe {
	public partial class MainWindow : Form {


		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		public MainWindow() {
			AllocConsole();

			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			for (int i = 0; i < m_VUMeters.Length; i++) {
				m_VUMeters[i] = new VUController();
			}

			VUController.SetupOpenHWM();

			React_VU1.SelectedIndex = 0;
			React_VU2.SelectedIndex = 0;

			ArduinoInterface.BaudRate = 9600;

			m_Settings = LoadSettingsFile();
			if (m_Settings == null) {
				m_Settings = GenerateSettings();
			}
			InstallSettings();

			try {
				ArduinoInterface.Open();
				ComStatus.Text = "OPEN";
			} catch {
				ComStatus.Text = "ERROR";
			}

			/*if (m_bStartHidden) {
				HideWindow_Click(null, null);
			}*/
		}

		VUController[] m_VUMeters = new VUController[2];

		Dictionary<string, string> m_Settings;

		Dictionary<string, string> LoadSettingsFile() {
			try {
				// Get the XML doc loaded in
				string xmlpath = "cfg.xml";
				bool exists = File.Exists(xmlpath);
				if (!exists) {
					return null; // No CFG file found
				}
				string xmlText = File.ReadAllText(xmlpath);
				var books = XDocument.Load(xmlpath);
				try {
					var path = books.Element("CFG");
					try {
						// Get all the tags
						IEnumerable<XElement> nodes = path.Elements();
						Dictionary<string, string> dictReturn = new Dictionary<string, string>();
						foreach (XElement n in nodes) {
							dictReturn.Add(n.Name.ToString(), n.Value.ToString());
						}
						return dictReturn;
					} catch {
						return null; // XML file malformed
					}
				} catch {
					return null; // CFG tag missing
				}
			} catch {
				return null; // No CFG file found
			}
		}

		Dictionary<string, string> GenerateSettings() {
			Dictionary<string, string> m_newSettings = new Dictionary<string, string>();
			m_newSettings.Add("ComPort", ComPort.Text);
			m_newSettings.Add("StartHidden", Convert.ToInt32(StartHidden.Checked).ToString());
			m_newSettings.Add("UpdateFreq_VU1", UpdateFreq_VU1.Text);
			m_newSettings.Add("UpdateFreq_VU2", UpdateFreq_VU2.Text);
			m_newSettings.Add("LED_VU1", Convert.ToInt32(LED_VU1.Checked).ToString());
			m_newSettings.Add("LED_VU2", Convert.ToInt32(LED_VU2.Checked).ToString());
			m_newSettings.Add("React_VU1", React_VU1.Text);
			m_newSettings.Add("React_VU2", React_VU2.Text);
			m_newSettings.Add("Min_VU1", Min_VU1.Text);
			m_newSettings.Add("Max_VU1", Max_VU1.Text);
			m_newSettings.Add("Min_VU2", Min_VU2.Text);
			m_newSettings.Add("Max_VU2", Max_VU2.Text);
			return m_newSettings;
		}

		void InstallSettings() {
			if (m_Settings == null) {
				return;
			}

			ComPort.Text = m_Settings["ComPort"];
			//ComPort_TextChanged(null, null);
			StartHidden.Checked = m_Settings["StartHidden"] != "0";
			m_bStartHidden = StartHidden.Checked;

			Min_VU1.Text = m_Settings["Min_VU1"];
			Min_VU1_TextChanged(null, null);
			Max_VU1.Text = m_Settings["Max_VU1"];
			Max_VU1_TextChanged(null, null);
			UpdateFreq_VU1.Text = m_Settings["UpdateFreq_VU1"];
			UpdateFreq_VU1_TextChanged(null, null);
			LED_VU1.Checked = m_Settings["LED_VU1"] != "0";
			m_VUMeters[0].SetEnumFromString(m_Settings["React_VU1"]);
			React_VU1.SelectedIndex = (int)m_VUMeters[0].m_eMode - 1;

			Min_VU2.Text = m_Settings["Min_VU2"];
			Min_VU2_TextChanged(null, null);
			Max_VU2.Text = m_Settings["Max_VU2"];
			Max_VU2_TextChanged(null, null);
			UpdateFreq_VU2.Text = m_Settings["UpdateFreq_VU2"];
			UpdateFreq_VU2_TextChanged(null, null);
			LED_VU2.Checked = m_Settings["LED_VU2"] != "0";
			m_VUMeters[1].SetEnumFromString(m_Settings["React_VU2"]);
			React_VU2.SelectedIndex = (int)m_VUMeters[1].m_eMode - 1;
		}

		void SaveSettings() {
			var books = new XDocument();
			XElement root = new XElement("CFG");
			var path = root;
			foreach(KeyValuePair<string, string> kv in m_Settings) {
				path.Add(new XElement(kv.Key, kv.Value));
				//var val = path.Element(kv.Key);
			}
			books.AddFirst(root);
			books.Save("cfg.xml");
		}


		private void React_VU1_SelectedIndexChanged(object sender, EventArgs e) {
			m_VUMeters[0].SetEnumFromString(React_VU1.Text);
		}

		private void Min_VU1_TextChanged(object sender, EventArgs e) {
			try {
				m_VUMeters[0].m_nMinOutput = Clamp(Convert.ToInt32(Min_VU1.Text), 0, m_VUMeters[0].m_nMaxOutput);
				Min_VU1.Text = m_VUMeters[0].m_nMinOutput.ToString();
			} catch {
				return;
			}
		}

		private void Max_VU1_TextChanged(object sender, EventArgs e) {
			try {
				m_VUMeters[0].m_nMaxOutput = Clamp(Convert.ToInt32(Max_VU1.Text), m_VUMeters[0].m_nMinOutput, 100);
				Max_VU1.Text = m_VUMeters[0].m_nMaxOutput.ToString();
			} catch {
				return;
			}
		}

		int Clamp(int var, int min, int max) {
			if (var < min) {
				return min;	
			}
			if (var > max) {
				return max;
			}
			return var;
		}

		private void UpdateFreq_VU1_TextChanged(object sender, EventArgs e) {
			m_VUMeters[0].m_nUpdateFreq = Clamp(Convert.ToInt32(UpdateFreq_VU1.Text), 1, 10000);
			UpdateFreq_VU1.Text = m_VUMeters[0].m_nUpdateFreq.ToString();
			Timer_VU1.Interval = m_VUMeters[0].m_nUpdateFreq;
			if (Timer_VU1.Enabled) {
				Timer_VU1.Stop();
			}
			Timer_VU1.Start();
		}

		private void LED_VU1_CheckedChanged(object sender, EventArgs e) {
			m_VUMeters[0].m_bLED = LED_VU1.Checked;

			TransmitToArduino(msgType_e.MSG_LED1, Convert.ToInt32(m_VUMeters[0].m_bLED));
		}

		private void UpdateVU1_Click(object sender, EventArgs e) {
			int nVal = m_VUMeters[0].GetVUValue();
			VAR_VU1.Text = nVal.ToString();
		}

		private void Quit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void HideWindow_Click(object sender, EventArgs e) {
			WindowState = FormWindowState.Minimized;
			this.Hide();
			SystemTray.Visible = true;
		}

		private void SystemTray_MouseDoubleClick(object sender, MouseEventArgs e) {
			this.Show();
			this.WindowState = FormWindowState.Normal;
			SystemTray.Visible = false;
		}

		private void ShowWindow_Click(object sender, EventArgs e) {
			this.Show();
			this.WindowState = FormWindowState.Normal;
			SystemTray.Visible = false;
		}

		private void LoadCFG_Click(object sender, EventArgs e) {
			// LOAD CFG
			m_Settings = LoadSettingsFile();
			if (m_Settings == null) {
				m_Settings = GenerateSettings();
			}
			InstallSettings();
		}

		private void SaveCFG_Click(object sender, EventArgs e) {
			// SAVE CFG
			m_Settings = GenerateSettings();
			SaveSettings();
		}

		private void UpdateVU2_Click(object sender, EventArgs e) {
			int nVal = m_VUMeters[1].GetVUValue();
			VAR_VU2.Text = nVal.ToString();
		}

		private void Min_VU2_TextChanged(object sender, EventArgs e) {
			try {
				m_VUMeters[1].m_nMinOutput = Clamp(Convert.ToInt32(Min_VU2.Text), 0, m_VUMeters[1].m_nMaxOutput);
				Min_VU2.Text = m_VUMeters[1].m_nMinOutput.ToString();
			} catch {
				return;
			}
		}

		private void Max_VU2_TextChanged(object sender, EventArgs e) {
			try {
				m_VUMeters[1].m_nMaxOutput = Clamp(Convert.ToInt32(Max_VU2.Text), m_VUMeters[1].m_nMinOutput, 100);
				Max_VU2.Text = m_VUMeters[1].m_nMaxOutput.ToString();
			} catch {
				return;
			}
		}

		private void LED_VU2_CheckedChanged(object sender, EventArgs e) {
			m_VUMeters[1].m_bLED = LED_VU2.Checked;
			TransmitToArduino(msgType_e.MSG_LED2, Convert.ToInt32(m_VUMeters[1].m_bLED));
		}

		private void UpdateFreq_VU2_TextChanged(object sender, EventArgs e) {
			m_VUMeters[1].m_nUpdateFreq = Clamp(Convert.ToInt32(UpdateFreq_VU2.Text), 1, 10000);
			UpdateFreq_VU2.Text = m_VUMeters[1].m_nUpdateFreq.ToString();
			Timer_VU2.Interval = m_VUMeters[1].m_nUpdateFreq;
			if (Timer_VU2.Enabled) {
				Timer_VU2.Stop();
			}
			Timer_VU2.Start();
		}

		private void React_VU2_SelectedIndexChanged(object sender, EventArgs e) {
			m_VUMeters[1].SetEnumFromString(React_VU2.Text);
		}

		private void Timer_VU1_Tick(object sender, EventArgs e) {
			int oldVal = m_VUMeters[0].m_nVal;
			int nVal = m_VUMeters[0].GetVUValue();
			VAR_VU1.Text = nVal.ToString();
			MenuStrip_VU1.Text = "VU1 (" + m_VUMeters[0].m_eMode.ToString() + "): " + nVal.ToString();

			if (oldVal != nVal) {
				TransmitToArduino(msgType_e.MSG_VU1, nVal);
			}
		}

		private void Timer_VU2_Tick(object sender, EventArgs e) {
			int oldVal = m_VUMeters[1].m_nVal;
			int nVal = m_VUMeters[1].GetVUValue();
			VAR_VU2.Text = nVal.ToString();
			MenuStrip_VU2.Text = "VU2 (" + m_VUMeters[1].m_eMode.ToString() + "): " + nVal.ToString();

			if (oldVal != nVal) {
				TransmitToArduino(msgType_e.MSG_VU2, nVal);
			}
		}

		enum msgType_e {
			MSG_VOID,
			MSG_VU1,
			MSG_VU2,
			MSG_LED1,
			MSG_LEDR1,
			MSG_LED2,
			MSG_LEDR2
		}

		void TransmitToArduino(msgType_e eType, int nMessage) {
			// Add transmission code here
			if (!ArduinoInterface.IsOpen) {
				return;
			}

			Byte[] bytes = new Byte[2];
			bytes[0] = Convert.ToByte((int)eType);
			bytes[1] = Convert.ToByte(nMessage);
			ArduinoInterface.Write(bytes, 0, 2);
		}

		private void ComPort_TextChanged(object sender, EventArgs e) {
			if (ArduinoInterface.IsOpen) {
				ArduinoInterface.Close();
			}

			ArduinoInterface.PortName = ComPort.Text;

			try {
				ArduinoInterface.Open();
				ComStatus.Text = "OPEN";
			} catch {
				ComStatus.Text = "ERROR";
			}
		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void MainWindow_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e) {
			m_Settings = GenerateSettings();
			SaveSettings();
		}

		bool m_bStartHidden = false;
		bool m_bProgramStarted = false;
		private void MainWindow_Paint(object sender, PaintEventArgs e) {
			if (m_bStartHidden && !m_bProgramStarted) {
				HideWindow_Click(null, null);
				m_bProgramStarted = true;
			}
		}
	}

	public class VUController {
		public int m_nMinOutput = 0;
		public int m_nMaxOutput = 60;

		public bool m_bLED = true;
		public int m_nUpdateFreq = 25;

		// Needs to match dropdown lists
		public enum VUMode_e {
			VOID,
			CPU,
			RAM,
			GPU_TEMP,
			GPU_LOAD,
			SOUND_LVL,
			SOUND_VOL
		}

		// OpenHWM
		static Computer cpt = new Computer();
		public static void SetupOpenHWM() {
			cpt.Open();
			cpt.GPUEnabled = true;
		}

		public int GetGPU(SensorType sensorType, string strName = null) {
			foreach (var hardware in cpt.Hardware) {
				hardware.Update();
				foreach (var sensor in hardware.Sensors) {
					if (sensor.Hardware.HardwareType == HardwareType.GpuNvidia || sensor.Hardware.HardwareType == HardwareType.GpuAti) {
						if (sensor.Value == null) {
							continue;
						}

						if (sensor.SensorType == sensorType && (strName == null || sensor.Name == strName)) {
							return (int)sensor.Value;
						}
					}
				}
			}

			return 0;
		}

		public void SetEnumFromString(string newStr) {
			m_eMode = (VUMode_e) Enum.Parse(typeof(VUMode_e), newStr, true);
		}

		public VUMode_e m_eMode = VUMode_e.VOID;

		int LogRemap(int value, int minInputValue, int maxInputValue, int minOutputValue, int maxOutputValue) {
			/*if (value <= 1)
				return 0;

			double scaleFactor = 1;
			double d = maxOutputValue * Math.Pow(Math.Log(value), scaleFactor) / Math.Pow(Math.Log(maxInputValue), scaleFactor);
			return Convert.ToInt32(d);*/

			double dB = Math.Log(1 + (value)) * 20.0f;
			//dB *= maxOutputValue;
			return Remap(Convert.ToInt32(dB), minInputValue, maxInputValue, minOutputValue, maxOutputValue);
			return Convert.ToInt32(dB);
		}

		int Remap(int s, int a1, int a2, int b1, int b2) {
			return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
		}

		PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
		PerformanceCounter ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

		public int GetCurrentCpuUsage() {
			return Convert.ToInt32(cpuCounter.NextValue());
		}

		public int GetRamUsage() {
			return Convert.ToInt32(ramCounter.NextValue());
		}

		public int m_nVal = 0;

		public int GetVUValue() {
			switch (m_eMode) {
				case VUMode_e.VOID:
				default:
					m_nVal = m_nMinOutput;
					break;
				case VUMode_e.CPU:
					m_nVal = Remap(GetCurrentCpuUsage(), 0, 100, m_nMinOutput, m_nMaxOutput);
					break;
				case VUMode_e.RAM:
					m_nVal = Remap(GetRamUsage(), 0, 100, m_nMinOutput, m_nMaxOutput);
					break;
				case VUMode_e.GPU_TEMP:
					m_nVal = Remap(GetGPU(SensorType.Temperature), 0, 110, m_nMinOutput, m_nMaxOutput);
					break;
				case VUMode_e.GPU_LOAD:
					m_nVal = Remap(GetGPU(SensorType.Load, "GPU Core"), 0, 100, m_nMinOutput, m_nMaxOutput);
					break;
				case VUMode_e.SOUND_LVL:
					m_nVal = Remap(Convert.ToInt32(VideoPlayerController.AudioMeter.PeakValue * 100), 0, 100, m_nMinOutput, m_nMaxOutput);
					break;	
				case VUMode_e.SOUND_VOL:
					m_nVal = Remap(Convert.ToInt32(VideoPlayerController.AudioManager.GetMasterVolume()), 0, 100, m_nMinOutput, m_nMaxOutput);
					break;
			}

			return m_nVal;
		}
	}
}