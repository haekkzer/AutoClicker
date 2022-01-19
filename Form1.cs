using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MausClicker
{
	public partial class MainWindow : Form
	{
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		bool isClickerOn = false;

		public MainWindow()
		{
			InitializeComponent();

			//0 = id of Hotkey; 6 = 2=CTRL + 4=SHIFT;
			RegisterHotKey(this.Handle, 0, 6, Keys.T.GetHashCode());
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			timer1.Interval = trackBar1.Value * 10;
		}

		private void toggleClicker()
		{
			isClickerOn = !isClickerOn;

			switch (isClickerOn)
			{
				case true:
					pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("Indicator_GREEN");
					break;
				default:
					pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("Indicator_RED");
					break;
			}

			timer1.Enabled = !timer1.Enabled;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Point pos = Cursor.Position;

			mouse_event(0x02, pos.X, pos.Y, 0, 0);
			mouse_event(0x04, pos.X, pos.Y, 0, 0);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = !this.TopMost;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!isClickerOn)
			{
				toggleClicker();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (isClickerOn)
			{
				toggleClicker();
			}
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == 0x0312)
			{
				toggleClicker();
			}
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			UnregisterHotKey(this.Handle, 0);
		}
	}
}