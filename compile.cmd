:: Compilador creado por ElmichiYT

@echo off
title Compilador de CMatrix
chcp 65001 >nul

:: Revisa si es Windows de 32 bits o de 64 bits
IF "%PROCESSOR_ARCHITECTURE%"=="x64" (
    SET APP=C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe
) else (
    SET APP=C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe
)

:: Mensaje de advertencia

echo [NOTE]: No cierre la consola hasta que finalize el proceso!
echo [NOTE]: Esto puede tardar 5 segundos o menos.

%APP% /nologo "CMatrix.cs"
:: Temporizador
timeout -t 3 /nobreak >nul
IF ERRORLEVEL 1 (
    echo [ERROR]: Falló la compilación.
    echo [ERROR]: Revise los mensajes de arriba.
    pause >nul
) else (
    echo [NOTE]: Se compiló CMatrix correctamente.
    echo [NOTE]: Ahora puede cerrar el programa.
    pause >nul
)

:: Seguridad
exit