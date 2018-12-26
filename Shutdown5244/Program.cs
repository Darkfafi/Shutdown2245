using System;
using System.Windows.Forms;

namespace Shutdown5244
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if(args.Length == 0)
			{
				Application.Run(new Shutdown2544());
			}
			else
			{
				int hours = DateTime.Now.Hour;
				int minutes = DateTime.Now.Minute;
				int seconds = DateTime.Now.Second;
				int tomorrow = 0;
				int notification = 0;
				int screen = 0;
				int start = 1;
				float position = 0.5f;
				int safe = 0;
				int debug = 0;

				foreach (string arg in args)
				{
					string[] split = arg.Split('=');
					if (split.Length == 2)
					{
						switch (split[0])
						{
							case "hours": // Hours Set Time
								TryParseOrLetBe(ref hours, split[1]);
								break;
							case "minutes": // Minutes Set Time
								TryParseOrLetBe(ref minutes, split[1]);
								break;
							case "seconds": // Seconds Set Time
								TryParseOrLetBe(ref seconds, split[1]);
								break;
							case "tomorrow": // Next Day
								TryParseOrLetBe(ref tomorrow, split[1]);
								break;
							case "notification": // Notification Time in Minutes
								TryParseOrLetBe(ref notification, split[1]);
								break;
							case "position": // Position Normalized (0 - 1)
								TryParseOrLetBe(ref position, split[1]);
								break;
							case "screen": // Screen Index
								TryParseOrLetBe(ref screen, split[1]);
								break;
							case "start": // Auto Start
								TryParseOrLetBe(ref start, split[1]);
								break;
							case "safe": // Safe Margin in minutes
								TryParseOrLetBe(ref safe, split[1]);
								break;
							case "debug": // Debug Mode
								TryParseOrLetBe(ref debug, split[1]);
								break;
						}
					}
				}

				Application.Run(new Shutdown2544(hours, minutes, seconds, tomorrow > 0, notification, position, screen, start > 0, safe, debug > 0));
			}
		}

		static void TryParseOrLetBe(ref int target, string parsingString)
		{
			int val;
			if(int.TryParse(parsingString, out val))
			{
				target = val;
			}
		}

		static void TryParseOrLetBe(ref float target, string parsingString)
		{
			float val;
			if (float.TryParse(parsingString, out val))
			{
				target = val;
			}
		}
	}
}
