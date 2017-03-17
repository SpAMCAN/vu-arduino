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

namespace vu_tiful_joe {
	public partial class MainWindow : Form {
		public MainWindow() {
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			for (int i = 0; i < m_VUMeters.Length; i++) {
				m_VUMeters[i] = new VUController();
			}

			React_VU1.SelectedIndex = 0;
			React_VU2.SelectedIndex = 1;
		}

		VUController[] m_VUMeters = new VUController[2];

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


		private void React_VU1_SelectedIndexChanged(object sender, EventArgs e) {
			m_VUMeters[0].SetEnumFromString(React_VU1.Text);
		}

		private void Min_VU1_TextChanged(object sender, EventArgs e) {
			try {
				m_VUMeters[0].m_nMinOutput = Convert.ToInt32(Min_VU1.Text);
			} catch {
				return;
			}
		}

		private void Max_VU1_TextChanged(object sender, EventArgs e) {
			try {
				m_VUMeters[0].m_nMaxOutput = Convert.ToInt32(Max_VU1.Text);
			} catch {
				return;
			}
		}

		private void UpdateFreq_VU1_TextChanged(object sender, EventArgs e) {
			m_VUMeters[0].m_nUpdateFreq = Convert.ToInt32(UpdateFreq_VU1.Text);
		}

		private void LED_VU1_CheckedChanged(object sender, EventArgs e) {
			m_VUMeters[0].m_bLED = LED_VU1.Checked;
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

		private void LoadCFG_Click(object sender, EventArgs e) {
			// LOAD CFG
		}

		private void SaveCFG_Click(object sender, EventArgs e) {
			// SAVE CFG
		}

		private void UpdateVU2_Click(object sender, EventArgs e) {
			int nVal = m_VUMeters[1].GetVUValue();
			VAR_VU2.Text = nVal.ToString();
		}

		private void Min_VU2_TextChanged(object sender, EventArgs e) {
			try {
				m_VUMeters[1].m_nMinOutput = Convert.ToInt32(Min_VU2.Text);
			} catch {
				return;
			}
		}

		private void Max_VU2_TextChanged(object sender, EventArgs e) {
			try {
				m_VUMeters[1].m_nMinOutput = Convert.ToInt32(Max_VU2.Text);
			} catch {
				return;
			}
		}

		private void LED_VU2_CheckedChanged(object sender, EventArgs e) {
			m_VUMeters[1].m_bLED = LED_VU2.Checked;
		}

		private void UpdateFreq_VU2_TextChanged(object sender, EventArgs e) {
			m_VUMeters[1].m_nUpdateFreq = Convert.ToInt32(UpdateFreq_VU2.Text);
		}

		private void React_VU2_SelectedIndexChanged(object sender, EventArgs e) {
			m_VUMeters[1].SetEnumFromString(React_VU2.Text);
		}
	}

	public class VUController {
		public int m_nMinOutput = 0;
		public int m_nMaxOutput = 60;

		public bool m_bLED = true;
		public int m_nUpdateFreq = 25;

		public enum VUMode_e {
			VOID,
			CPU,
			RAM,
			GPU,
			SOUND_LVL,
			SOUND_VOL
		}

		public void SetEnumFromString(string newStr) {
			m_eMode = (VUMode_e) Enum.Parse(typeof(VUMode_e), newStr, true);
		}

		public VUMode_e m_eMode = VUMode_e.VOID;

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

		public int GetVUValue() {
			switch (m_eMode) {
				case VUMode_e.VOID:
				default:
					return m_nMinOutput;
				case VUMode_e.CPU:
					return Remap(GetCurrentCpuUsage(), 0, 100, m_nMinOutput, m_nMaxOutput);
				case VUMode_e.RAM:
					return Remap(GetRamUsage(), 0, 100, m_nMinOutput, m_nMaxOutput);
				case VUMode_e.GPU:
					return m_nMinOutput;
				case VUMode_e.SOUND_LVL:
					return m_nMinOutput;
				case VUMode_e.SOUND_VOL:
					return m_nMinOutput;
			}
		}
	}
}