﻿namespace TorrconEmulator
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pressSlider = new System.Windows.Forms.TrackBar();
			this.headerLabel = new System.Windows.Forms.Label();
			this.connectButton = new System.Windows.Forms.Button();
			this.disconnectButton = new System.Windows.Forms.Button();
			this.COMPortDropdown = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.pressLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pressSlider)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// pressSlider
			// 
			this.pressSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pressSlider.Location = new System.Drawing.Point(78, 30);
			this.pressSlider.Maximum = 760;
			this.pressSlider.Name = "pressSlider";
			this.pressSlider.Size = new System.Drawing.Size(542, 69);
			this.pressSlider.TabIndex = 0;
			this.pressSlider.Scroll += new System.EventHandler(this.pressSlider_Scroll);
			// 
			// headerLabel
			// 
			this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.headerLabel.Location = new System.Drawing.Point(168, 9);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(365, 40);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "TorrCon IV Emulator";
			// 
			// connectButton
			// 
			this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connectButton.Location = new System.Drawing.Point(59, 105);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(169, 53);
			this.connectButton.TabIndex = 2;
			this.connectButton.Text = "Connect";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
			// 
			// disconnectButton
			// 
			this.disconnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.disconnectButton.Location = new System.Drawing.Point(460, 105);
			this.disconnectButton.Name = "disconnectButton";
			this.disconnectButton.Size = new System.Drawing.Size(179, 53);
			this.disconnectButton.TabIndex = 3;
			this.disconnectButton.Text = "Disconnect";
			this.disconnectButton.UseVisualStyleBackColor = true;
			this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
			// 
			// COMPortDropdown
			// 
			this.COMPortDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.COMPortDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.COMPortDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.COMPortDropdown.FormattingEnabled = true;
			this.COMPortDropdown.Location = new System.Drawing.Point(284, 114);
			this.COMPortDropdown.Name = "COMPortDropdown";
			this.COMPortDropdown.Size = new System.Drawing.Size(121, 37);
			this.COMPortDropdown.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Red;
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(49, 53);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(10);
			this.panel2.Size = new System.Drawing.Size(614, 300);
			this.panel2.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.headerLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(712, 53);
			this.panel1.TabIndex = 7;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel10);
			this.panel3.Controls.Add(this.panel11);
			this.panel3.Controls.Add(this.panel9);
			this.panel3.Controls.Add(this.panel8);
			this.panel3.Controls.Add(this.panel7);
			this.panel3.Controls.Add(this.pressSlider);
			this.panel3.Controls.Add(this.connectButton);
			this.panel3.Controls.Add(this.disconnectButton);
			this.panel3.Controls.Add(this.COMPortDropdown);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 353);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(712, 609);
			this.panel3.TabIndex = 8;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(663, 53);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(49, 300);
			this.panel4.TabIndex = 9;
			// 
			// panel5
			// 
			this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new System.Drawing.Point(0, 53);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(49, 300);
			this.panel5.TabIndex = 10;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Gainsboro;
			this.panel6.Controls.Add(this.pressLabel);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(10, 10);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(594, 280);
			this.panel6.TabIndex = 0;
			// 
			// panel7
			// 
			this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel7.BackColor = System.Drawing.Color.Silver;
			this.panel7.Location = new System.Drawing.Point(561, 472);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(124, 136);
			this.panel7.TabIndex = 5;
			// 
			// panel8
			// 
			this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel8.BackColor = System.Drawing.Color.Black;
			this.panel8.Location = new System.Drawing.Point(36, 530);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(497, 76);
			this.panel8.TabIndex = 6;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.DarkKhaki;
			this.panel9.Location = new System.Drawing.Point(36, 472);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(156, 52);
			this.panel9.TabIndex = 7;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.DarkKhaki;
			this.panel10.Location = new System.Drawing.Point(198, 472);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(178, 52);
			this.panel10.TabIndex = 8;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.DarkKhaki;
			this.panel11.Location = new System.Drawing.Point(382, 472);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(151, 52);
			this.panel11.TabIndex = 8;
			// 
			// pressLabel
			// 
			this.pressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pressLabel.Location = new System.Drawing.Point(3, 0);
			this.pressLabel.Name = "pressLabel";
			this.pressLabel.Size = new System.Drawing.Size(588, 280);
			this.pressLabel.TabIndex = 0;
			this.pressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(712, 962);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pressSlider)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TrackBar pressSlider;
		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Button connectButton;
		private System.Windows.Forms.Button disconnectButton;
		private System.Windows.Forms.ComboBox COMPortDropdown;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label pressLabel;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel9;
	}
}

