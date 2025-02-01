# PowerToys Run: Brave Beta Favorites plugin

Simple [PowerToys Run](https://learn.microsoft.com/windows/powertoys/run) experimental plugin for search Brave Beta Browser favorites.

## Important

- The plugin works only with Brave Beta based on Chromium!
- The plugin is built on top of the `%LOCALAPPDATA%\BraveSoftware\Brave-Browser-Beta\User Data\Default\Bookmarks` and may stop working in case of changes made by Brave Team

## Requirements

- Brave Beta set as default browser
- PowerToys minimum version 0.76.0

## Installation

- Download the [latest release](https://github.com/n8creator/PowerToys-Run-BraveBeta-Favorite/releases/) by selecting the architecture that matches your machine: `x64` (more common) or `ARM64`
- Close PowerToys
- Extract the archive to `%LOCALAPPDATA%\Microsoft\PowerToys\PowerToys Run\Plugins`
- Open PowerToys

## Build project

To build project run:

```powershell
> powershell -ExecutionPolicy Bypass .\Build.ps1
```


## Screenshots

![Plugin Manager](/images/PluginManager.png)

![Plugin Manager](/images/Search.png)

