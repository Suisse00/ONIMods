@echo off
setLocal EnableDelayedExpansion
call "%~dp0configurations.bat"

echo Update libraries
echo Source %source:"=%

for /f "tokens=*" %%n in ('dir %~dp0*.dll /b /a-d') do (
	set sourcefile="%source:"=%%%n"
	rem echo !sourcefile!
	if exist !sourcefile! (
		copy /Y !sourcefile! "%~dp0%%n" >nul
		echo File %%n updated
	) else (
		echo File %%n doesn't exists in source folder
	)
)

em echo|set/p="Press <ENTER> to continue.."&runas/u: "">NUL