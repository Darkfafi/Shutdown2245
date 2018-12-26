# Shutdown2245
Computer shutdown program to make life better &lt;3

### [>> Download <<](http://ramsesdiperna.com/FileHosting/Shutdown2455/Shutdown2544.exe)

# Setup
* Place the `.exe` wherever you like and make a shortcut.
* Go to the startup folder of windows and place the shortcut there. (`shell:startup`)

# Customize Startup
* At the shortcut you created, right click and go to `Properties`
* at `target`, after the `.exe` you can add the customize options from the `customize options list` below.

## Customize Options List (`=exampleValue`)

| Command | Description | Default Value | Possible Values |
| --- | --- | --- | --- |
| `hours=24` | Target Hour | Current Hour | 0-24 |
| `minutes=55` | Target Minute | Current Minute | 0-60 |
| `seconds=55` | Target Second | Current Second | 0-60 |
| `notification=30` | Notification time in minutes | 0 | any integer number |
| `position=0.5` | X position normalized | 0 | 0-1 |
| `screen=0` | Index Screen on which the program will be launched | 0 | 0 or 1 |
| `start=1` | Auto start timer | 1 | 0 or 1 |
| `tomorrow=0` | If the time applies for the current day or the next | 0 | 0 or 1 |
| `safe=60` | `Safe Mode` Time in minutes (If 0 it is disabled) | 0 | any integer number |
| `debug=0` | `Debug Mode` Adds debug features when flagged 1 | 0 | 0 or 1 |

## Safe Mode
When you change the time or stop the timer when the current time is past safe mode, the computer will shut down immediately. This feature is off by default and can only be added through the customization options. This is to help you prevent yourself to lack from your wanted structure.

When safe mode is active, you can see `Safe Until: hh:mm:ss` above your time picker. This represents the time until you can still change & stop your timer without the computer shutting down.

## Debug Mode
When Debug mode is on, the following features are a given;
* Shutdown message instead of actual shutdown

# Use
### Timer
When you set the timer, you can start it. When it is started, it will count down. When the counter hits 0 (or you do an action outside safe mode (Read **Safe Mode**)) Then the shutdown process will be activated. Note that Windows automatically halts shutdown if unsaved files are present. So do not worry about losing your work. But it is adviced to simply be ready for shutdown at the given time.

### Next Day
When you pick a time, it is by default for the current day. If you wish to have a shutdown on, for example, 1am the next day. You pick the time 1 am and check the **Next Day** checkbox. So the program sees it as the next 1 am, and not the previous.

### Minutes Till Notify
When, for example, 30 is given to **Minutes Till Notify**, it will show a message above your program on that x minutes are left till the shutdown. If you leave this at 0, no notification will be given. You can change the notification time at any moment. So if you wish to get a notification after another, simply change the notification time to a lower one so you get notified again. 

### Visual Representation
When you unfocus from the timer menu, the timer will change into a smaller version of itself to represent the time you have left. The program will always render above any other program. So you will be able to see the timer / click on it, no matter what you are doing. If you don't want this, click `background` to minimize it instead. The messages will still render above your program when you do.

### Position
When positioning, drag the timer to the screen you wish to add it to, and set the slider which represents the top of that screen and the arrow represents the location of the timer.

# Visual Examples
## Adding Customize Options:
![Customize Options](https://raw.githubusercontent.com/Darkfafi/Shutdown2245/master/resources/screenshots/exampleParameters.png)

## Positioning:
![Positioning](https://raw.githubusercontent.com/Darkfafi/Shutdown2245/master/resources/screenshots/positionExample.png)
