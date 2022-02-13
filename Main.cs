using System;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
	public partial class MainWindow : Form
	{
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		readonly string settingsFile = "AutoClicker.ini";
		bool isClickerOn = false;
		bool isHotkeyOn = false;

		public MainWindow()
		{
			InitializeComponent();

			//0 = id of Hotkey; 6 = 2=CTRL + 4=SHIFT;
			RegisterHotKey(this.Handle, 0, 6, Keys.T.GetHashCode());

			DiableTabStop();

			LoadSettings();
			TimerClick.Interval = TrackBarCPS.Value;
		}

		private void DiableTabStop()
		{
			foreach (Control ctrl in this.Controls)
			{
				ctrl.TabStop = false;
			}
		}

		private void ToggleClicker()
		{
			isClickerOn = !isClickerOn;

			switch (isClickerOn)
			{
				case true:
					PictureBoxIndicator.Image = (Image)Properties.Resources.ResourceManager.GetObject("Indicator_GREEN");
					break;
				default:
					PictureBoxIndicator.Image = (Image)Properties.Resources.ResourceManager.GetObject("Indicator_RED");
					break;
			}

			TimerClick.Enabled = !TimerClick.Enabled;
		}

		private void TimerClick_Tick(object sender, EventArgs e)
		{
			Point pos = Cursor.Position;
			
			for (int i = 0; i < TrackBarMp.Value; i++)
			{
				mouse_event(0x02, pos.X, pos.Y, 0, 0);
				mouse_event(0x04, pos.X, pos.Y, 0, 0);
			}
		}

		private void TrackBarCPS_Scroll(object sender, EventArgs e)
		{
			TimerClick.Interval = TrackBarCPS.Value;
		}

		private void TrackBarCPS_Enter(object sender, EventArgs e)
		{
			PictureBoxIndicator.Focus();
		}

		private void TrackBarMp_Enter(object sender, EventArgs e)
		{
			PictureBoxIndicator.Focus();
		}

		private void CheckBoxAlwaysOnTop_Changed(object sender, EventArgs e)
		{
			switch (CheckBoxAOT.Checked)
			{
				case true:
					this.TopMost = true;
					break;
				default:
					this.TopMost = false;
					break;
			}
			PictureBoxIndicator.Focus();
			Thread.Sleep(100);
		}

		private void CheckBoxHotkey_Changed(object sender, EventArgs e)
		{
			switch (CheckBoxHk.Checked)
			{
				case true:
					isHotkeyOn = true;
					break;
				default:
					isHotkeyOn = false;
					break;
			}
			PictureBoxIndicator.Focus();
			Thread.Sleep(100);
		}

		private void CheckBoxMultiplier_Changed(object sender, EventArgs e)
		{
			switch (CheckBoxMp.Checked)
			{
				case true:
					TrackBarMp.Enabled = true;
					break;
				default:
					TrackBarMp.Value = 1;
					TrackBarMp.Enabled = false;
					break;
			}
			PictureBoxIndicator.Focus();
			Thread.Sleep(100);
		}

		private void ButtonEnable_Click(object sender, EventArgs e)
		{
			if (!isClickerOn)
			{
				ToggleClicker();
			}
			PictureBoxIndicator.Focus();
			Thread.Sleep(100);
		}

		private void ButtonDisable_Click(object sender, EventArgs e)
		{
			if (isClickerOn)
			{
				ToggleClicker();
			}
			PictureBoxIndicator.Focus();
			Thread.Sleep(100);
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == 0x0312 && isHotkeyOn)
			{
				ToggleClicker();
			}
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			UnregisterHotKey(this.Handle, 0);
			SaveSettings();
		}

		private void LoadSettings()
		{
			if (File.Exists(settingsFile))
			{
				using (StreamReader sr = File.OpenText(settingsFile))
				{
					string s = "";
					while ((s = sr.ReadLine()) != null)
					{
						switch (s)
						{
							case string a when a.Contains("AlwaysOnTop"):
								a = a.Substring(a.IndexOf("=") + 1);
								try
								{
									CheckBoxAOT.Checked = Convert.ToBoolean(a);
								}
								catch (Exception)
								{
									break;
								}
								break;
							case string a when a.Contains("Hotkey"):
								a = a.Substring(a.IndexOf("=") + 1);
								try
								{
									CheckBoxHk.Checked = Convert.ToBoolean(a);
								}
								catch (Exception)
								{
									break;
								}
								break;
							case string a when a.Contains("CPS_Value"):
								a = a.Substring(a.IndexOf("=") + 1);
								try
								{
									TrackBarCPS.Value = Convert.ToInt32(a);
								}
								catch (Exception)
								{
									break;
								}
								break;
							case string a when a.Contains("Multiplier="):
								a = a.Substring(a.IndexOf("=") + 1);
								try
								{
									CheckBoxMp.Checked = Convert.ToBoolean(a);
								}
								catch (Exception)
								{
									break;
								}
								break;
							case string a when a.Contains("Multiplier_Value"):
								a = a.Substring(a.IndexOf("=") + 1);
								try
								{
									TrackBarMp.Value = Convert.ToInt32(a);
								}
								catch (Exception)
								{
									break;
								}
								break;
							default:
								break;
						}
					}
				}
			}

		}

		private void SaveSettings()
		{
			File.WriteAllText(settingsFile, "");
			using (StreamWriter sw = File.AppendText(settingsFile))
			{
				sw.WriteLine("[AutoClicker]");
				sw.WriteLine("AlwaysOnTop={0}", CheckBoxAOT.Checked);
				sw.WriteLine("Hotkey={0}", CheckBoxHk.Checked);
				sw.WriteLine("CPS_Value={0}", TrackBarCPS.Value);
				sw.WriteLine("Multiplier={0}", CheckBoxMp.Checked);
				if (CheckBoxMp.Checked)
				{
					sw.WriteLine("Multiplier_Value={0}", TrackBarMp.Value);
				}
			}
		}
	}
}


/*	CHANGELOG
 *	
 * 
 * TODO
 * 
 * 
 */