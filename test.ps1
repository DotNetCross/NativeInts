$dotnettest = "dotnet test "
$testRoot = "build\Tests\"

$testDlls = Get-ChildItem -Path $testRoot -File -Recurse -Include *Test*.dll

& $dotnettest $testDlls '/Platform:x86' '/Parallel'
& $dotnettest $testDlls '/Platform:x64' '/Parallel'