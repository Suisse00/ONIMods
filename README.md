# ONIMods
Mods for Oxygen Not Included

## User
### How to install/Updates
#### From this repository
Use this method if mods aren't keep up to date within the Oxygen Not Included mods manager.

> [!NOTE]
> It will be your responsability to check for new updates, to download new updates and to install them again.

1. Download the latest [Mods.zip](https://github.com/Suisse00/ONIMods/releases/latest/download/Mods.zip)
2. Unzip it into `%userprofile%\Documents\Klei\OxygenNotIncluded\mods\dev`
  > [!IMPORTANT]
  > It should create multiple subdirectories - each of the directory should be named as a mod name.
  >
  > Eg. You should have `%userprofile%\Documents\Klei\OxygenNotIncluded\mods\dev\PassiveGasVentInput`
3. Start the game
4. Enable mods you want to use
> [!NOTE]
> You have to do this step for a new installation.
   1. Go into the `Mods` main menu's option.
   2. Scroll at the bottom of the list - Steam's workshop mods are always at the top, and locally installed mods are at the bottom.
   3. Check the checkboxes to enable mods you want to
   4. Restart the game
   > [!TIP]
   > Closing the `Mods`'s window will ask you to restart the game

## Developper
### Dependencies
- NET Framework 4.7.1 SDK
- Oxygen Not Included installed.
  - See source\lib\configuration.bat to update the game path if needed.
- MSBuild >= 15.0
  - Visual Studio 2017 and above.

### Compiling/Setup into Oxygen Not Included
1. Execute source\lib\fetch.bat
> [!NOTE]
> To be done once per Oxygen Not Included update
2. Compile projet(s) or the solution
> [!NOTE]
> It copied DLLs into the game in `%userprofile%\Documents\Klei\OxygenNotIncluded\mods\dev`. You just need to start the game and enable the mod(s). They are listed at the end of the list. Those at the top are Steam workshop ones.

### Release
1. Increment `AssemblyVersionAttribute` and `AssemblyFileVersionAttribute` in all `AssemblyInfo.cs` you need to
2. Increment `version` (to match `AssemblyInfo.cs`) in `Mods/*/mods_info.yaml` you need to
3. Compile the projet(s) or the solution
> [!NOTE]
> It will copy the output binary into its `Mods`'s subdirectory
4. Subfolders in `Mods` are your mods.

    Zip subfolders in a file named `Mods.zip`. Make sure if the user unzip it it will create subfolders matching the extension names.
5. Create a release in github and upload `Mods.zip`
