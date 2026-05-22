# Copy & Paste SQL Fixes

## For Users Who Just Want to Copy-Paste the SQL

### Your Database Details:
- **Server:** (localdb)\MSSQLLocalDB
- **Database:** HospitalDb
- **Table:** Patients

---

## 🔧 QUICK FIX - Run This SQL

### In SQL Server Management Studio:
1. Connect to: **(localdb)\MSSQLLocalDB**
2. Select Database: **HospitalDb**
3. New Query
4. **Paste the SQL below and press F5 to execute:**

```sql
-- Add missing columns to Patients table
-- These columns are required for the patient edit functionality

-- Email column
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'Email')
	ALTER TABLE Patients ADD Email NVARCHAR(100) DEFAULT '';

-- BloodGroup column
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'BloodGroup')
	ALTER TABLE Patients ADD BloodGroup NVARCHAR(10) DEFAULT 'Unknown';

-- AddressLine1 column
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'AddressLine1')
	ALTER TABLE Patients ADD AddressLine1 NVARCHAR(255) DEFAULT '';

-- City column
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'City')
	ALTER TABLE Patients ADD City NVARCHAR(100) DEFAULT '';

-- EmergencyName column
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'EmergencyName')
	ALTER TABLE Patients ADD EmergencyName NVARCHAR(100) DEFAULT '';

-- EmergencyPhone column
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'EmergencyPhone')
	ALTER TABLE Patients ADD EmergencyPhone NVARCHAR(15) DEFAULT '';

-- MedicalHistory column
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'MedicalHistory')
	ALTER TABLE Patients ADD MedicalHistory NVARCHAR(MAX) DEFAULT '';

-- Show all columns to verify
SELECT COLUMN_NAME, DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Patients' 
ORDER BY ORDINAL_POSITION;
```

### Expected Result:
You should see output showing all the patient columns, including the 7 new ones you just added.

---

## ✅ Verification Query

After running the migration, run this to confirm all columns exist:

```sql
SELECT COLUMN_NAME, DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Patients' 
ORDER BY ORDINAL_POSITION;
```

**Expected columns to see:**
- Id (NVARCHAR)
- FirstName (NVARCHAR)
- LastName (NVARCHAR)
- Phone (NVARCHAR)
- DateOfBirth (DATETIME)
- Gender (NVARCHAR)
- Email (NVARCHAR) ← NEW
- BloodGroup (NVARCHAR) ← NEW
- AddressLine1 (NVARCHAR) ← NEW
- City (NVARCHAR) ← NEW
- EmergencyName (NVARCHAR) ← NEW
- EmergencyPhone (NVARCHAR) ← NEW
- MedicalHistory (NVARCHAR) ← NEW

---

## 🔍 Troubleshooting Queries

### Check if columns already exist:
```sql
SELECT COLUMN_NAME 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Patients' 
AND COLUMN_NAME IN ('Email', 'BloodGroup', 'AddressLine1', 'City', 'EmergencyName', 'EmergencyPhone', 'MedicalHistory')
ORDER BY COLUMN_NAME;
```

### View the entire Patients table structure:
```sql
EXEC sp_help 'Patients';
```

### Delete all test data and start fresh (⚠️ WARNING: This deletes all patient records!):
```sql
DELETE FROM Patients;
DBCC CHECKIDENT ('Patients', RESEED, 0);
```

---

## 🚀 After Running the Migration

1. Close the application completely
2. Restart the application
3. Go to the **Patients** tab
4. Select a patient
5. Click **Edit**
6. Modify any field
7. Click **Save**
8. Done! ✅

---

## 📝 Notes

- The `IF NOT EXISTS` checks ensure the script is safe to run multiple times
- All new columns have default values, so existing patient records won't break
- No data is lost - the script only adds new columns
- The changes are immediate - no application restart needed (well, restart to be safe)

**If you have any issues, run the verification query above to confirm all 7 columns exist.**
