﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorrconEmulator
{
	public partial class TorrconEmulator : Form
	{
		SerialPort port;
        System.Threading.Thread comThread;
		bool disconnectClicked = false;
		double[] pressValues;

		public TorrconEmulator()
		{
			InitializeComponent();
			pressValues = new double[2];
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			connectButton.Enabled = true;
			disconnectButton.Enabled = false;
			populateComPortMenu();
			SetPressLabel();
			pressValues[0] = GetSliderValue();
			pressValues[1] = GetSliderValue();
		}

		private void SetPressLabel()
		{
			pressLabel.Text = pressValues[0].ToString() + " Torr";
			pressLabel2.Text = pressValues[1].ToString() + " Torr";
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
			port = new SerialPort(portName, 9600);
			port.Open();
			byte[] buffer;
			string recd, msg;
			while(!disconnectClicked)
			{
				int count = port.BytesToRead;
				if(count >= 2)
				{
					buffer = new byte[count];
					var str = port.Read(buffer, 0, count);
					recd = Encoding.Default.GetString(buffer);
					Console.WriteLine(recd);
					if(recd.Contains("*p"))
					{
						msg = "p1 " + pressValues[0].ToString() + ":p2 " + pressValues[1].ToString();
					}
					else if(recd.Contains("*v"))
					{
						double sliderVal = 0;
						sliderVal = pressValues[0] / 76;
						double sliderVal2 = 0;
						sliderVal2 = pressValues[1] / 76;
						msg = "p1 " + sliderVal.ToString() + ":p2 " + sliderVal2.ToString();
					}
					else if(recd.Contains("p"))
					{
						msg = pressValues[0].ToString();
					}
					else
					{
						msg = "error";
					}
					port.WriteLine(msg);
					Console.WriteLine(msg);
				}
				else
				{
					Console.WriteLine("here");
					Thread.Sleep(100);
				}
			}
			disconnectClicked = false;
			port.Close();
		}

		private void connectButton_Click(object sender, EventArgs e)
		{
			SetButtonStates(true);

			comThread = new Thread(() => communicate());
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
			pressValues[gaugeTabControl.SelectedIndex] = GetSliderValue();
			SetPressLabel();
		}

		private void SetButton_Click(object sender, EventArgs e)
		{
			if(Double.TryParse(pressInputBox.Text, out pressValues[gaugeTabControl.SelectedIndex]))
			{
				if(pressValues[gaugeTabControl.SelectedIndex] <= pressSlider.Maximum && pressValues[gaugeTabControl.SelectedIndex] >= pressSlider.Minimum)
				{
					pressSlider.Value = (int)pressValues[gaugeTabControl.SelectedIndex];
				}
				SetPressLabel();
			}
		}

		private void TorrconEmulator_FormClosed(object sender, FormClosedEventArgs e)
		{
			disconnectClicked = true;
			if(comThread != null) comThread.Join();
		}

		private void gaugeTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			pressSlider.Value = (int)pressValues[gaugeTabControl.SelectedIndex];
		}
	}
}
