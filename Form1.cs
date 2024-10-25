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
			populateComPortMenu();
		}

		private void SetPressLabel()
		{
			pressLabel.Text = GetSliderValue().ToString() + " Torr";
		}

		private int GetSliderValue()
		{
			return pressSlider.Value;
		}

		private string GetDropdownValue()
		{
			if(COMPortDropdown.SelectedItem != null)
				return COMPortDropdown.SelectedItem.ToString();
			else
				return "";
		}

		private void SetButtonStates(bool connected)
		{
			if(connected)
			{
				connectButton.Enabled = false;
				disconnectButton.Enabled = true;
				connectButton.BackColor = Color.LightGreen;
				disconnectButton.BackColor = Color.White;
			}
			else
			{
				connectButton.Enabled = true;
				disconnectButton.Enabled = false;
				disconnectButton.BackColor = Color.Red;
				connectButton.BackColor = Color.White;
			}

		}

		private void communicate()
		{
			string portName = (string)COMPortDropdown.Invoke(new Func<string>(() => GetDropdownValue()));
			if(portName == "")
			{
				connectButton.Invoke(new Action(() => SetButtonStates(false)));
				return;
			}
			SerialPort port = new SerialPort(portName, 9600);
			port.Open();
			byte[] buffer = new byte[1024];
			string recd, msg;
			while(!disconnectClicked)
			{
				var str = port.Read(buffer, 0, 2);
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
				port.WriteLine(msg);
				Console.WriteLine(msg);
			}
			disconnectClicked = false;
			port.Close();
		}

		private void connectButton_Click(object sender, EventArgs e)
		{
			SetButtonStates(true);

			comThread = new System.Threading.Thread(() => communicate());
			comThread.Start();
		}

		private void disconnectButton_Click(object sender, EventArgs e)
		{
			SetButtonStates(false);
			disconnectClicked = true;
		}

		private void populateComPortMenu()
		{
			COMPortDropdown.Items.AddRange(
			        System.IO.Ports.SerialPort.GetPortNames()
			            .OrderBy(s => s)
			            .Distinct()
			            .ToArray());
		}

		private void pressSlider_Scroll(object sender, EventArgs e)
		{
			SetPressLabel();
		}
	}
}
