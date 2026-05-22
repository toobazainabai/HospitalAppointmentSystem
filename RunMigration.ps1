#!/usr/bin/env powershell
# Database Migration Script
# This script adds the missing patient detail columns to the Patients table

param(
	[string]$ServerName = ".",
	[string]$DatabaseName = "HospitalDB"
)

Write-Host "Hospital Management System - Database Migration" -ForegroundColor Cyan
Write-Host "=================================================" -ForegroundColor Cyan
Write-Host ""

# Get the path to the migration script
$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Path
$migrationFile = Join-Path $scriptPath "Hospital.Core\Scripts\AddPatientColumns.sql"

if (-not (Test-Path $migrationFile)) {
	Write-Host "ERROR: Migration script not found at: $migrationFile" -ForegroundColor Red
	exit 1
}

Write-Host "Configuration:" -ForegroundColor Yellow
Write-Host "  Server: $ServerName"
Write-Host "  Database: $DatabaseName"
Write-Host "  Migration Script: $migrationFile"
Write-Host ""

# Check if sqlcmd is available
if (-not (Get-Command sqlcmd -ErrorAction SilentlyContinue)) {
	Write-Host "ERROR: sqlcmd utility not found. Please install SQL Server Command Line Utilities." -ForegroundColor Red
	exit 1
}

Write-Host "Executing migration script..." -ForegroundColor Yellow
Write-Host ""

try {
	sqlcmd -S $ServerName -d $DatabaseName -i $migrationFile

	if ($LASTEXITCODE -eq 0) {
		Write-Host ""
		Write-Host "SUCCESS: Migration completed successfully!" -ForegroundColor Green
		Write-Host ""
		Write-Host "New columns added:" -ForegroundColor Green
		Write-Host "  - Email"
		Write-Host "  - BloodGroup"
		Write-Host "  - AddressLine1"
		Write-Host "  - City"
		Write-Host "  - EmergencyName"
		Write-Host "  - EmergencyPhone"
		Write-Host "  - MedicalHistory"
	} else {
		Write-Host ""
		Write-Host "ERROR: Migration failed with exit code $LASTEXITCODE" -ForegroundColor Red
		exit 1
	}
}
catch {
	Write-Host "ERROR: $($_.Exception.Message)" -ForegroundColor Red
	exit 1
}
