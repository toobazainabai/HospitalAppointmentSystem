# Quick Fix: Database Migration

## The Problem
When you try to edit a patient, you're getting an error about missing columns:
- `BloodGroup`
- `Email`
- `AddressLine1`
- `City`
- `EmergencyName`
- `EmergencyPhone`
- `MedicalHistory`

These columns need to be added to your database `Patients` table.

## The Solution - 3 Easy Steps

### Step 1: Open SQL Server Management Studio
(Or SQL Server Object Explorer in Visual Studio)

### Step 2: Run This Query
Copy and paste the following SQL command into a new query window and execute it:

```sql
-- Add missing columns to Patients table if they don't exist
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'Email')
	ALTER TABLE Patients ADD Email NVARCHAR(100) DEFAULT '';

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'BloodGroup')
	ALTER TABLE Patients ADD BloodGroup NVARCHAR(10) DEFAULT 'Unknown';

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'AddressLine1')
	ALTER TABLE Patients ADD AddressLine1 NVARCHAR(255) DEFAULT '';

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'City')
	ALTER TABLE Patients ADD City NVARCHAR(100) DEFAULT '';

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'EmergencyName')
	ALTER TABLE Patients ADD EmergencyName NVARCHAR(100) DEFAULT '';

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'EmergencyPhone')
	ALTER TABLE Patients ADD EmergencyPhone NVARCHAR(15) DEFAULT '';

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'MedicalHistory')
	ALTER TABLE Patients ADD MedicalHistory NVARCHAR(MAX) DEFAULT '';
```

**Connection Details:**
- **Server:** (localdb)\MSSQLLocalDB
- **Database:** HospitalDb

### Step 3: Test It
Run the application again and try to edit a patient. The error should be gone!

---

## Alternative: Use the Migration Script

We've also created an automated migration script at:
```
Hospital.Core\Scripts\AddPatientColumns.sql
```

You can:
1. Open it directly in Visual Studio
2. Execute it against the HospitalDb database

Or use PowerShell:
```powershell
sqlcmd -S "(localdb)\MSSQLLocalDB" -d "HospitalDb" -i "Hospital.Core\Scripts\AddPatientColumns.sql"
```

---

## What This Does
- Adds 7 new columns to the `Patients` table
- Uses safe checks so it won't fail if columns already exist
- Sets default values for backward compatibility
- Works instantly - no data loss

That's it! Your edit functionality should work after running this migration.
