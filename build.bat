@ECHO OFF
"C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MSBuild.exe" -m NHapiTools.sln /t:Clean,Build  /p:Configuration=Release