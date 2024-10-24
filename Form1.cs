using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorrconEmulator
{
	public partial class Form1 : Form
	{
        System.Threading.Thread comThread;
		bool disconnectClicked = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			connectButton.Enabled = true;
			disconnectButton.Enabled = false;
		}

		private int GetSliderValue()
		{
			return pressSlider.Value;
		}

		private void communicate()
		{
			var s = new SerialPort("COM2", 9600);
			s.Open();
			byte[] buffer = new byte[1024];
			string recd, msg;
			while(!disconnectClicked)
			{
				var str = s.Read(buffer, 0, 2);
				recd = Encoding.Default.GetString(buffer);
				Console.WriteLine(recd);
				if(recd.Contains("*p"))
				{
					int sliderVal = 0;
					sliderVal = (int)pressSlider.Invoke(new Func<int>(() => GetSliderValue()));
					msg = "p1 " + sliderVal.ToString() + ":p2 0.0";
				}
				else if(recd.Contains("*v"))
				{
					int sliderVal = 0;
					sliderVal = (int)pressSlider.Invoke(new Func<int>(() => GetSliderValue()));
					sliderVal /= 76;
					msg = "p1 " + sliderVal.ToString() + ":p2 0.0";
				}
				else
				{
					msg = "error";
				}
				s.WriteLine(msg);
				Console.WriteLine(msg);
			}
			disconnectClicked = false;
			s.Close();
		}

		private void connectButton_Click(object sender, EventArgs e)
		{
			connectButton.Enabled = false;
			disconnectButton.Enabled = true;

			comThread = new System.Threading.Thread(() => communicate());
			comThread.Start();
		}

		private void disconnectButton_Click(object sender, EventArgs e)
		{
			connectButton.Enabled = true;
			disconnectButton.Enabled = false;
			disconnectClicked = true;
		}
	}
}
