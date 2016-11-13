# w3wp HUD
A Visual Studio 2015 extension that provides a heads-up display of running w3wp.exe processes. Helpful for determining which w3wp.exe process to connect the debugger to when you have more than one running.

It is essentially a wrapper around running the following command:
```
c:\windows\system32\inetsvr\appcmd list wp
```
###Instructions
You will need to install the [Visual Studio 2015 SDK](https://msdn.microsoft.com/en-us/library/bb166441.aspx) in order to build this solution. 

1. Clone this repository and build w3wpHUD.sln.
2. Run the generated w3wpHUD.vsix (located in bin/ directory) to install the extension.
3. Find w3wp HUD in the View > Other Windows menu in Visual Studio.

Dock the tool window to the location of your preference. Use the right-click context menu to refresh the display.

###Notes:
* Visual Studio must be running in adminstrator mode in order to use this extension.

###Future:
This was an intentionally small project, but future features would include displaying and managing (start/stop) IIS sites and other IIS commands.

