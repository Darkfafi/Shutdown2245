using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Shutdown5244
{
	public partial class Shutdown2544 : Form
	{
		private const double MINIMUM_MINUTES_TILL_END = 2d;

		private Timer _timer = new Timer();
		private bool _validTimeChange = false;
		private bool _isActive = false;
		private int _minutesToNotify = 0;
		private bool _smallSizedLocation = false;
		private DateTime _lastRunningTime;

		private Screen _targetScreenOnLoad = null;
		private DateTime _dateTimeOnLoad;
		private bool _autoStartOnLoad;
		private bool _nextDayCheckOnLoad;
		private int _safeMarginInMinutes = 0;
		private bool _debugMode = false;

		private bool _isFullSize
		{
			get
			{
				return FormBorderStyle == FormBorderStyle.FixedToolWindow;
			}
		}

		// Visual Tweak Values
		private Size BIG_MENU_SIZE = new Size(325, 250);
		private Size SMALL_MENU_SIZE = new Size(180, 40);

		private int TIME_LEFT_INDICATION_X_OFFSET = 20;
		private int TIME_LEFT_LABEL_X_OFFSET = 5;
		private int TIME_LEFT_ALL_Y_OFFSET = 15;

		public Shutdown2544()
		{
			Initialize();
			_dateTimeOnLoad = DateTime.Now;
			_nextDayCheckOnLoad = false;
		}

		public Shutdown2544(int hour, int minute, int second, bool nextDayCheck, int notification, float startPosNormalized, int indexScreen, bool autoStart, int safeModeMargin, bool debugMode)
		{
			Initialize();
			_dateTimeOnLoad = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
			MinutesTextbox.Text = notification.ToString();
			PositionBarX.Value = (int)(startPosNormalized * 10);
			Screen[] screens = Screen.AllScreens;
			_debugMode = debugMode;

			if (screens.Length > 0)
			{
				if (indexScreen >= screens.Length)
				{
					indexScreen = screens.Length - 1;
				}
				else if (indexScreen < 0)
				{
					indexScreen = 0;
				}


				_targetScreenOnLoad = screens[indexScreen];
			}

			_autoStartOnLoad = autoStart;
			_nextDayCheckOnLoad = nextDayCheck;

			_safeMarginInMinutes = safeModeMargin;
		}

		private void Initialize()
		{
			InitializeComponent();
			MinutesTextbox.Text = "0";
			_timer.Tick += OnTimerTick;
			NextDayCheckbox.CheckedChanged += OnNextDayCheckChanged;
			UpdateSafeDisplay();
		}

		// On Loaded
		private void Form1_Load(object sender, EventArgs e)
		{
			if (_targetScreenOnLoad != null)
				SetProgramPosition(_targetScreenOnLoad, true);

			_validTimeChange = true;
			DateTimePicker.Value = _dateTimeOnLoad;
			SetDateTimeDay(_nextDayCheckOnLoad);
			_validTimeChange = false;

			if (!_isActive && _autoStartOnLoad)
				StartStopToggle();
		}

		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			SetFullWindowState(true);
		}

		protected override void OnDeactivate(EventArgs e)
		{
			base.OnDeactivate(e);
			SetFullWindowState(false);
		}

		private void SetFullWindowState(bool toFullWindow)
		{
			if (_isFullSize == toFullWindow || WindowState != FormWindowState.Normal)
				return;

			// App Styling
			FormBorderStyle = toFullWindow ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			Size = toFullWindow ? BIG_MENU_SIZE : SMALL_MENU_SIZE;

			// Orientation
			Screen s = Screen.FromPoint(Location);
			SetProgramPosition(s, toFullWindow);

			// Visual Disabling
			StartStopButton.Visible = toFullWindow;
			MinimizeButton.Visible = toFullWindow;
			MinutesLabel.Visible = toFullWindow;
			PositionBarX.Visible = toFullWindow;
			MinutesTextbox.Visible = toFullWindow;

			// Setting of required items orientation
			if (_smallSizedLocation || !toFullWindow)
			{
				int dir = (toFullWindow ? 1 : -1);
				TimeLeftDisplay.Location = new Point(TimeLeftDisplay.Location.X - TIME_LEFT_INDICATION_X_OFFSET * dir, TimeLeftDisplay.Location.Y + TIME_LEFT_ALL_Y_OFFSET * dir);
				TimeLeftLabel.Location = new Point(TimeLeftLabel.Location.X + TIME_LEFT_LABEL_X_OFFSET * dir, TimeLeftLabel.Location.Y + TIME_LEFT_ALL_Y_OFFSET * dir);
			}

			_smallSizedLocation = !toFullWindow;
		}

		private void OnTimerTick(object sender, EventArgs e)
		{
			TimeSpan timeSpan = GetTimeLeft();

			if (timeSpan.TotalSeconds <= 0)
			{
				Shutdown();
				return;
			}

			if (timeSpan.TotalMinutes < _minutesToNotify)
			{
				_minutesToNotify = 0;
				MessageBox.Show(this, string.Format("Computer shuts down within {0} minutes!", Math.Ceiling(timeSpan.TotalMinutes)));
			}

			TimeLeftDisplay.Text = timeSpan.ToString(@"hh\:mm\:ss");
			UpdateTimeLeftDisplay(timeSpan);
		}

		private void StartStopToggle()
		{
			_isActive = !_isActive;

			StartStopButton.Text = !_isActive ? "Start" : "x Stop x";

			if (_isActive)
			{
				SetMinimumTime();
				_timer.Interval = 1000;
				_timer.Start();
				SetNotificationValueToGivenValue();
				UpdateTimeLeftDisplay();
			}
			else
			{
				_timer.Stop();
			}
		}

		private void UpdateTimeLeftDisplay()
		{
			UpdateTimeLeftDisplay(GetTimeLeft());
			UpdateSafeDisplay();

			_lastRunningTime = DateTimePicker.Value;
		}

		private void UpdateTimeLeftDisplay(TimeSpan timeSpan)
		{
			TimeLeftDisplay.Text = GetTimeDisplayString(timeSpan);
		}

		private void UpdateSafeDisplay()
		{
			if(_safeMarginInMinutes > 0)
			{
				DateTime safeDate = DateTimePicker.Value;
				TimeSpan minutesToRemove = new TimeSpan(0, _safeMarginInMinutes, 0);
				safeDate = safeDate.Subtract(minutesToRemove);
				SafeTimeValue.Text = GetTimeDisplayString(safeDate);
			}


			SafeLabel.Visible = SafeTimeValue.Visible = _safeMarginInMinutes > 0;
		}

		private TimeSpan GetTimeLeft(bool lastRunningTime = false)
		{
			if(!lastRunningTime)
				return DateTimePicker.Value - DateTime.Now;

			if(_lastRunningTime != null)
				return _lastRunningTime - DateTime.Now;

			return default(TimeSpan);
		}

		private void SetProgramPosition(Screen screen, bool isFullWindow)
		{
			float percentageX = PositionBarX.Value * 0.1f;
			float offsetX = Size.Width * percentageX;
			int x = screen.Bounds.Left + (int)(screen.Bounds.Width * percentageX - offsetX);
			int y = screen.Bounds.Top + (isFullWindow ? screen.Bounds.Height / 2 - Size.Height : 0);
			Location = new Point(x, y);
		}

		private void SetMinimumTime()
		{
			if ((DateTimePicker.Value - DateTime.Now).TotalMinutes < MINIMUM_MINUTES_TILL_END && !_validTimeChange)
			{
				_validTimeChange = true;
				DateTimePicker.Value = DateTime.Now.AddMinutes(MINIMUM_MINUTES_TILL_END);
				_validTimeChange = false;
			}
		}

		private void OnNextDayCheckChanged(object sender, EventArgs e)
		{
			SetDateTimeDay(NextDayCheckbox.Checked);
		}

		private void SetDateTimeDay(bool nextDay)
		{
			DateTime dt = DateTimePicker.Value;

			NextDayCheckbox.Checked = nextDay;

			if (nextDay)
			{
				dt = new DateTime(dt.Year, dt.Month, DateTime.Now.Day + 1, dt.Hour, dt.Minute, dt.Second);
			}
			else
			{
				dt = new DateTime(dt.Year, dt.Month, DateTime.Now.Day, dt.Hour, dt.Minute, dt.Second);
			}

			DateTimePicker.Value = dt;
		}

		private void SetNotificationValueToGivenValue()
		{
			int newMinutes;
			if (int.TryParse(MinutesTextbox.Text, out newMinutes))
			{
				if (newMinutes >= 0)
				{
					_minutesToNotify = newMinutes;
				}
			}
			else
			{
				MinutesTextbox.Text = _minutesToNotify.ToString();
			}
		}

		private void SafeMarginLogics()
		{
			if(_lastRunningTime != null)
			{
				if(_safeMarginInMinutes > 0 && GetTimeLeft(true).TotalMinutes <= _safeMarginInMinutes)
				{
					Shutdown();
				}
			}
		}

		private void Shutdown()
		{
			if(_isActive)
			{
				StartStopToggle();
			}

			if(_debugMode)
			{
				MessageBox.Show(this, string.Format("Computer DEBUG Shutdown"));
			}
			else
			{
				Process.Start("shutdown", "/s /t 0");
			}
		}

		private string GetTimeDisplayString(DateTime dateTime)
		{
			int hours = dateTime.Hour;
			string hourIndication = (hours <= 9) ? string.Concat("0", hours.ToString()) : hours.ToString();
			return string.Concat(hourIndication, dateTime.ToString(@"\:mm\:ss"));
		}

		private string GetTimeDisplayString(TimeSpan timeSpan)
		{
			int hours = (int)timeSpan.TotalHours;
			string hourIndication = (hours <= 9) ? string.Concat("0", hours.ToString()) : hours.ToString();
			return string.Concat(hourIndication, timeSpan.ToString(@"\:mm\:ss"));
		}

		// Used View Methods

		private void notification_value_changed(object sender, EventArgs e)
		{
			SetNotificationValueToGivenValue();
		}

		private void start_pressed(object sender, EventArgs e)
		{
			StartStopToggle();
			if(!_isActive && !_validTimeChange)
			{
				SafeMarginLogics();
			}
		}

		private void minimize_pressed(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void time_selection_ValueChanged(object sender, EventArgs e)
		{
			SetMinimumTime();

			if(!_validTimeChange)
			{
				SafeMarginLogics();
				if(_isActive)
				{
					StartStopToggle();
				}
			}
		}

		// Unused View methods

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void label2_Click_1(object sender, EventArgs e)
		{

		}
	}
}
