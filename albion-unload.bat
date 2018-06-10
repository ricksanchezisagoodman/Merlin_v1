@echo off


echo Unoading
injector -dll Albion\Release\Merlin-unload.dll -target Albion-Online.exe -namespace Merlin -class Core -method Unload
del Albion\Release\Merlin-unload.dll

SET AssemblyPath=Albion\Release
SET AssemblyName=Merlin

SET Target=Albion-Online.exe

SET UnloadAssembly=%AssemblyPath%\%AssemblyName%-unload.dll

echo Unloading
if exist %UnloadAssembly% injector -dll %UnloadAssembly% -target %Target% -namespace %AssemblyName% -class Core -method Unload
if exist %UnloadAssembly% del %UnloadAssembly%
