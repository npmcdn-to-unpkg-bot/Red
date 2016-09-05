@pushd %~dp0

%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe "Specflow_Test_Project1.csproj"

@set AppHostName=http://www.comparethemeerkat.com

@if ERRORLEVEL 1 goto alternativeFolder

@cd packages\SpecRun.Runner.*\tools

@if ERRORLEVEL 1 goto end

@set profile=%1
@if "%profile%" == "" set profile=Default

SpecRun.exe run %profile%.srprofile "/baseFolder:%~dp0\bin\Debug" /log:specrun.log %2 %3 %4 %5

@cd ..\..\..\

:end

@popd

:alternativeFolder

@cd ..\packages\SpecRun.Runner.*\tools

@if ERRORLEVEL 1 goto end2

@set profile=%1
@if "%profile%" == "" set profile=Default

SpecRun.exe run %profile%.srprofile "/baseFolder:%~dp0\bin\Debug" /log:specrun.log %2 %3 %4 %5

@cd ..\..\..\Specflow_Test_Project1

:end2

@popd
