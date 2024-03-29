# w3wp HUD

![alt text](https://vsmarketplacebadge.apphb.com/version/Cynicollision.w3wpHUD.svg "Visual Studo Marketplace version badge") ![alt text](https://vsmarketplacebadge.apphb.com/installs/Cynicollision.w3wpHUD.svg "Visual Studo Marketplace installs badge")

A Visual Studio extension that provides a heads-up display of running w3wp.exe processes. Helpful for determining which IIS w3wp.exe process to connect the debugger to when you have more than one running and are frequently resetting ISS.

![alt text](w3wpHUDpreview.png "w3wpHUD screenshot")

It is essentially a wrapper around running the following command:
```
c:\windows\system32\inetsrv\appcmd list wp
```
### Installation

You can find w3wp HUD in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=Cynicollision.w3wpHUD).

Alternatively, you can clone and build it yourself. You will need to install the [Visual Studio SDK](https://docs.microsoft.com/en-us/visualstudio/extensibility/installing-the-visual-studio-sdk?view=vs-2019) in order to do so. 

1. Clone this repository.
2. Build w3wpHUD.sln.
2. Run (double-click) the generated w3wpHUD.vsix to install the extension (located in "bin/" directory).

### Usage Instructions

Find w3wp HUD in the "View > Other Windows" menu in Visual Studio. Dock the tool window to the location of your preference. Use the right-click context menu to refresh the display.

### Notes:
* Visual Studio must be running in adminstrator mode in order to use this extension.
* Compatible with Visual Studio 2015, 2017, 2019, and 2022.
