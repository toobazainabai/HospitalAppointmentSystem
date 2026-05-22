# Database Migration Instructions

## Issue
The patient table in your database is missing required columns for the new patient details (Email, BloodGroup, Address, City, Emergency Contact, and Medical History).

## Solution

### Step 1: Locate the Migration Script
The migration script is located at:
```
Hospital.Core\Scripts\AddPatientColumns.sql
```

### Step 2: Execute the Migration

**Option A: Using SQL Server Management Studio (SSMS)**
1. Open SQL Server Management Studio
2. Connect to your SQL Server instance
3. Open the file: `Hospital.Core\Scripts\AddPatientColumns.sql`
4. Click **Execute** (or press F5)

**Option B: Using SQL Query in Command Line**
1. Open PowerShell or Command Prompt
2. Navigate to your project directory
3. Run the following command (replace server and database names as needed):
```powershell
sqlcmd -S "YOUR_SERVER_NAME" -d "YOUR_DATABASE_NAME" -i "Hospital.Core\Scripts\AddPatientColumns.sql"
```

**Option C: Using Visual Studio**
1. In Visual Studio, go to **View > SQL Server Object Explorer**
2. Connect to your SQL Server instance
3. Right-click your database and select **New Query**
4. Copy the contents of `Hospital.Core\Scripts\AddPatientColumns.sql`
5. Paste into the query window and execute

### Step 3: Verify Migration
After executing the script, verify the columns were added:
```sql
SELECT COLUMN_NAME 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Patients'
ORDER BY ORDINAL_POSITION;
```

You should see these new columns:
- Email
- BloodGroup
- AddressLine1
- City
- EmergencyName
- EmergencyPhone
- MedicalHistory

### Step 4: Test the Application
1. Restart the application
2. Try to edit a patient record
3. The error should now be resolved

## What Changed in the Code
- Updated `DbPatientService` to check for the correct table name `dbo.Patients` first
- Created migration script to add the missing columns safely (only if they don't already exist)
- The columns are added with default values to prevent NULL issues

## Notes
- The migration script uses `IF NOT EXISTS` checks, so it's safe to run multiple times
- All new columns have default values to maintain backward compatibility with existing records
- The script only adds columns if they don't already exist
