SET path=C:\Program Files (x86)
REM Installing at %$path%

md "C:\Program Files (x86)\LiveBackgroundChanger"

COPY "%~dp0\BackgroundChangerForm.exe" "%path%\LiveBackgroundChanger"
pause