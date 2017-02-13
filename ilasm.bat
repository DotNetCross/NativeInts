if not exist ".\build\Libs_AnyCPU_Debug\" mkdir .\build\Libs_AnyCPU_Debug\
if not exist ".\build\Libs_AnyCPU_Release\" mkdir .\build\Libs_AnyCPU_Release\
"C:\Windows\Microsoft.NET\Framework\v4.0.30319\Ilasm.exe" /nologo /dll /optimize .\src\DotNetCross.NativeInts\NativeInts.il /OUTPUT=.\build\Libs_AnyCPU_Debug\NativeInts.dll
"C:\Windows\Microsoft.NET\Framework\v4.0.30319\Ilasm.exe" /nologo /dll /optimize .\src\DotNetCross.NativeInts\NativeInts.il /OUTPUT=.\build\Libs_AnyCPU_Release\NativeInts.dll
REM .\tools\ilasm.exe /dll /optimize .\src\DotNetCross.NativeInts\NativeInts.il /OUTPUT=.\build\Libs_AnyCPU_Debug\NativeInts.dll
REM "C:\Windows\Microsoft.NET\Framework\v4.0.30319\Ilasm.exe" /NOLOGO /DLL /DEBUG  ".\src\DotNetCross.NativeInts\NativeInts.il" /OUTPUT:"./build/Libs_AnyCPU_Debug/DotNetCross.NativeInts.dll"  