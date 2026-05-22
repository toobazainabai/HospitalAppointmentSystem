@echo off
REM Database Migration Script for Hospital Management System
REM This script adds missing patient detail columns to the Patients table

echo.
echo ====================================================
echo Hospital Management System - Database Migration
echo ====================================================
echo.

REM Configuration
set SERVER=(localdb)\MSSQLLocalDB
set DATABASE=HospitalDb
set SCRIPT_PATH=%~dp0Hospital.Core\Scripts\AddPatientColumns.sql

echo Configuration:
echo   Server: %SERVER%
echo   Database: %DATABASE%
echo   Migration Script: %SCRIPT_PATH%
echo.

REM Check if script exists
if not exist "%SCRIPT_PATH%" (
	echo ERROR: Migration script not found at: %SCRIPT_PATH%
	pause
	exit /b 1
)

REM Check if sqlcmd is available
where sqlcmd >nul 2>nul
if %ERRORLEVEL% NEQ 0 (
	echo ERROR: sqlcmd utility not found.
	echo Please install SQL Server Command Line Utilities.
	echo Download from: https://learn.microsoft.com/en-us/sql/tools/sqlcmd/sqlcmd-utility
	pause
	exit /b 1
)

echo Executing migration script...
echo.

sqlcmd -S "%SERVER%" -d "%DATABASE%" -i "%SCRIPT_PATH%"

if %ERRORLEVEL% EQU 0 (
	echo.
	echo ====================================================
	echo SUCCESS: Migration completed successfully!
	echo ====================================================
	echo.
	echo New columns added:
	echo   - Email
	echo   - BloodGroup
	echo   - AddressLine1
	echo   - City
	echo   - EmergencyName
	echo   - EmergencyPhone
	echo   - MedicalHistory
	echo.
	echo You can now close this window and test the application.
) else (
	echo.
	echo ERROR: Migration failed with exit code %ERRORLEVEL%
	echo Please check your SQL Server connection and database name.
)

pause
