# Shutdown2245
Computer shutdown program to make life better &lt;3

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
| `safe=60` | Safe Time in minutes to (If 0 it is disabled) | 0 | any integer number |
| `debug=0` | Adds debug features when flagged 1, such as shutdown message instead of actual shutdown process | 0 | 0 or 1 |
