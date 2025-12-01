@echo off
setLocal EnableDelayedExpansion
call "%~dp0configurations.bat"

set dependencies="0Harmony.dll" "Assembly-CSharp-firstpass.dll" "Assembly-CSharp.dll" "Newtonsoft.Json.dll" "System.dll" "UnityEngine.CoreModule.dll" "UnityEngine.dll" "UnityEngine.InputLegacyModule.dll" "UnityEngine.TextRenderingModule.dll" "UnityEngine.UnityWebRequestModule.dll" "UnityEngine.InputLegacyModule.dll" "UnityEngine.TextRenderingModule.dll" "Unity.TextMeshPro.dll" "UnityEngine.UI.dll" "UnityEngine.UIModule.dll" "UnityEngine.ImageConversionModule.dll"

echo Fetching libraries
echo Source %source:"=%

for %%n in (%dependencies%) do (
	set filename="%%n"
	set sourcefile="%source:"=%!filename:"=!"

	if exist !sourcefile! (
		copy /Y !sourcefile! "%~dp0%%n" >nul
		echo File %%n created or updated
	) else (
		echo File %%n doesn't exists in source folder
	)
)
