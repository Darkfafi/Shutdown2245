namespace Shutdown5244
{
	partial class Shutdown2544
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
			if (disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shutdown2544));
			this.MinutesTextbox = new System.Windows.Forms.TextBox();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.MinutesLabel = new System.Windows.Forms.Label();
			this.TimeLeftLabel = new System.Windows.Forms.Label();
			this.StartStopButton = new System.Windows.Forms.Button();
			this.TimeLeftDisplay = new System.Windows.Forms.Label();
			this.MinimizeButton = new System.Windows.Forms.Button();
			this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.PositionBarX = new System.Windows.Forms.TrackBar();
			this.NextDayCheckbox = new System.Windows.Forms.CheckBox();
			this.SafeLabel = new System.Windows.Forms.Label();
			this.SafeTimeValue = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PositionBarX)).BeginInit();
			this.SuspendLayout();
			// 
			// MinutesTextbox
			// 
			this.MinutesTextbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.MinutesTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
			this.MinutesTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MinutesTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.MinutesTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(172)))), ((int)(((byte)(123)))));
			this.MinutesTextbox.Location = new System.Drawing.Point(211, 76);
			this.MinutesTextbox.Name = "MinutesTextbox";
			this.MinutesTextbox.Size = new System.Drawing.Size(46, 20);
			this.MinutesTextbox.TabIndex = 0;
			this.MinutesTextbox.Text = "0";
			this.MinutesTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MinutesTextbox.TextChanged += new System.EventHandler(this.notification_value_changed);
			// 
			// TimeLabel
			// 
			this.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimeLabel.Location = new System.Drawing.Point(40, 45);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(33, 13);
			this.TimeLabel.TabIndex = 2;
			this.TimeLabel.Text = "Time:";
			this.TimeLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// MinutesLabel
			// 
			this.MinutesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.MinutesLabel.AutoSize = true;
			this.MinutesLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinutesLabel.Location = new System.Drawing.Point(40, 78);
			this.MinutesLabel.Name = "MinutesLabel";
			this.MinutesLabel.Size = new System.Drawing.Size(100, 13);
			this.MinutesLabel.TabIndex = 3;
			this.MinutesLabel.Text = "Minutes Til Notify:";
			this.MinutesLabel.Click += new System.EventHandler(this.label2_Click);
			// 
			// TimeLeftLabel
			// 
			this.TimeLeftLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TimeLeftLabel.AutoSize = true;
			this.TimeLeftLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimeLeftLabel.Location = new System.Drawing.Point(40, 114);
			this.TimeLeftLabel.Name = "TimeLeftLabel";
			this.TimeLeftLabel.Size = new System.Drawing.Size(55, 13);
			this.TimeLeftLabel.TabIndex = 4;
			this.TimeLeftLabel.Text = "Time Left:";
			this.TimeLeftLabel.Click += new System.EventHandler(this.label3_Click);
			// 
			// StartStopButton
			// 
			this.StartStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.StartStopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
			this.StartStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartStopButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartStopButton.Location = new System.Drawing.Point(32, 156);
			this.StartStopButton.Name = "StartStopButton";
			this.StartStopButton.Size = new System.Drawing.Size(83, 23);
			this.StartStopButton.TabIndex = 5;
			this.StartStopButton.Text = "Start";
			this.StartStopButton.UseVisualStyleBackColor = false;
			this.StartStopButton.Click += new System.EventHandler(this.start_pressed);
			// 
			// TimeLeftDisplay
			// 
			this.TimeLeftDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.TimeLeftDisplay.AutoSize = true;
			this.TimeLeftDisplay.Location = new System.Drawing.Point(208, 114);
			this.TimeLeftDisplay.Margin = new System.Windows.Forms.Padding(0);
			this.TimeLeftDisplay.Name = "TimeLeftDisplay";
			this.TimeLeftDisplay.Size = new System.Drawing.Size(49, 13);
			this.TimeLeftDisplay.TabIndex = 6;
			this.TimeLeftDisplay.Text = "00:00:00";
			this.TimeLeftDisplay.Click += new System.EventHandler(this.label4_Click);
			// 
			// MinimizeButton
			// 
			this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
			this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimizeButton.Location = new System.Drawing.Point(198, 156);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.Size = new System.Drawing.Size(83, 23);
			this.MinimizeButton.TabIndex = 7;
			this.MinimizeButton.Text = "Background";
			this.MinimizeButton.UseVisualStyleBackColor = false;
			this.MinimizeButton.Click += new System.EventHandler(this.minimize_pressed);
			// 
			// DateTimePicker
			// 
			this.DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.DateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
			this.DateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.DateTimePicker.Checked = false;
			this.DateTimePicker.CustomFormat = "H:mm";
			this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePicker.Location = new System.Drawing.Point(191, 41);
			this.DateTimePicker.Name = "DateTimePicker";
			this.DateTimePicker.ShowUpDown = true;
			this.DateTimePicker.Size = new System.Drawing.Size(90, 20);
			this.DateTimePicker.TabIndex = 8;
			this.DateTimePicker.TabStop = false;
			this.DateTimePicker.Value = new System.DateTime(2018, 10, 21, 14, 40, 9, 0);
			this.DateTimePicker.ValueChanged += new System.EventHandler(this.time_selection_ValueChanged);
			// 
			// PositionBarX
			// 
			this.PositionBarX.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PositionBarX.Location = new System.Drawing.Point(-7, -13);
			this.PositionBarX.Name = "PositionBarX";
			this.PositionBarX.Size = new System.Drawing.Size(322, 45);
			this.PositionBarX.TabIndex = 9;
			this.PositionBarX.Value = 5;
			this.PositionBarX.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// NextDayCheckbox
			// 
			this.NextDayCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.NextDayCheckbox.AutoSize = true;
			this.NextDayCheckbox.Location = new System.Drawing.Point(89, 44);
			this.NextDayCheckbox.Name = "NextDayCheckbox";
			this.NextDayCheckbox.Size = new System.Drawing.Size(70, 17);
			this.NextDayCheckbox.TabIndex = 10;
			this.NextDayCheckbox.Text = "Next Day";
			this.NextDayCheckbox.UseVisualStyleBackColor = true;
			// 
			// SafeLabel
			// 
			this.SafeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.SafeLabel.AutoSize = true;
			this.SafeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SafeLabel.Location = new System.Drawing.Point(177, 25);
			this.SafeLabel.Name = "SafeLabel";
			this.SafeLabel.Size = new System.Drawing.Size(60, 13);
			this.SafeLabel.TabIndex = 11;
			this.SafeLabel.Text = "Safe Until:";
			this.SafeLabel.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// SafeTimeValue
			// 
			this.SafeTimeValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.SafeTimeValue.AutoSize = true;
			this.SafeTimeValue.Location = new System.Drawing.Point(240, 25);
			this.SafeTimeValue.Margin = new System.Windows.Forms.Padding(0);
			this.SafeTimeValue.Name = "SafeTimeValue";
			this.SafeTimeValue.Size = new System.Drawing.Size(49, 13);
			this.SafeTimeValue.TabIndex = 12;
			this.SafeTimeValue.Text = "00:00:00";
			this.SafeTimeValue.Click += new System.EventHandler(this.label2_Click_1);
			// 
			// Shutdown2544
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(309, 211);
			this.Controls.Add(this.SafeTimeValue);
			this.Controls.Add(this.SafeLabel);
			this.Controls.Add(this.NextDayCheckbox);
			this.Controls.Add(this.PositionBarX);
			this.Controls.Add(this.DateTimePicker);
			this.Controls.Add(this.MinimizeButton);
			this.Controls.Add(this.TimeLeftDisplay);
			this.Controls.Add(this.StartStopButton);
			this.Controls.Add(this.TimeLeftLabel);
			this.Controls.Add(this.MinutesLabel);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.MinutesTextbox);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(172)))), ((int)(((byte)(123)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(325, 250);
			this.Name = "Shutdown2544";
			this.Opacity = 0.95D;
			this.Text = "Shutdown 2544";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.Maroon;
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.PositionBarX)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox MinutesTextbox;
		private System.Windows.Forms.Label TimeLabel;
		private System.Windows.Forms.Label MinutesLabel;
		private System.Windows.Forms.Label TimeLeftLabel;
		private System.Windows.Forms.Button StartStopButton;
		private System.Windows.Forms.Label TimeLeftDisplay;
		private System.Windows.Forms.DateTimePicker DateTimePicker;
		private System.Windows.Forms.Button MinimizeButton;
		private System.Windows.Forms.TrackBar PositionBarX;
		private System.Windows.Forms.CheckBox NextDayCheckbox;
		private System.Windows.Forms.Label SafeLabel;
		private System.Windows.Forms.Label SafeTimeValue;
	}
}

