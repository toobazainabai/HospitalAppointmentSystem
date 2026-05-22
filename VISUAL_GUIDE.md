# 🎨 Visual Guide - Patient Edit Feature

## Architecture Diagram

```
┌─────────────────────────────────────────────────────────────┐
│                    HOSPITAL MANAGEMENT SYSTEM                │
├─────────────────────────────────────────────────────────────┤
│                                                              │
│  ┌──────────────────────────────────────────────────────┐  │
│  │                   PATIENT VIEW (UI)                   │  │
│  │                                                      │  │
│  │  ┌─────────────────────────────────────────────┐   │  │
│  │  │ [Add] [Edit] [View] [Delete] [Refresh]     │   │  │
│  │  └─────────────────────────────────────────────┘   │  │
│  │                                                      │  │
│  │  ┌─────────────────────────────────────────────┐   │  │
│  │  │ DataGridView (Patient List)                │   │  │
│  │  │ ID | Name | Phone | Email | BloodGroup... │   │  │
│  │  │ P001 | Ahmed | 1234... | ahmed@... | A+   │   │  │
│  │  │ P002 | Fatima| 5678... | fatima@.. | B-   │   │  │
│  │  └─────────────────────────────────────────────┘   │  │
│  └──────────────────────────────────────────────────────┘  │
│                         │                                    │
│                   [USER CLICKS EDIT]                        │
│                         │                                    │
└─────────────────────────┼────────────────────────────────────┘
						  │
						  ▼
┌─────────────────────────────────────────────────────────────┐
│              PATIENT VIEW CODE-BEHIND                        │
├─────────────────────────────────────────────────────────────┤
│                                                              │
│  btnEdit_Click()                                            │
│  ├─ Validate patient selected                              │
│  ├─ Get patient from database                              │
│  ├─ Open AddPatientForm(patient)                           │
│  └─ On Save: Update patient in database                    │
│                                                              │
└──────────────────────────┬─────────────────────────────────┘
						  │
						  ▼
┌─────────────────────────────────────────────────────────────┐
│                   ADDPATIENTFORM                             │
├─────────────────────────────────────────────────────────────┤
│                                                              │
│  Title: "Edit Patient" (changed from "Add Patient")         │
│                                                              │
│  ┌──────────────────────────────────────────────────────┐  │
│  │ First Name:     [Ahmed________________]             │  │
│  │ Last Name:      [Khan_________________]             │  │
│  │ Phone:          [03001234567_________]              │  │
│  │ Email:          [ahmed@example.com____]             │  │
│  │ Date of Birth:  [5/15/1990___________]              │  │
│  │ Gender:         [Male________________]              │  │
│  │ Blood Group:    [A+__________________]              │  │
│  │ Address:        [123 Main St_________]              │  │
│  │ City:           [Karachi_____________]              │  │
│  │ Emergency Name: [Aisha Khan___________]             │  │
│  │ Emergency Phone:[03009876543_________]              │  │
│  │ Medical History:[Diabetic____________]              │  │
│  │                                                      │  │
│  │              [Save]  [Cancel]                        │  │
│  └──────────────────────────────────────────────────────┘  │
│                                                              │
└──────────────────────────┬─────────────────────────────────┘
						  │
				   [USER MODIFIES FIELDS]
						  │
				   [USER CLICKS SAVE]
						  │
						  ▼
┌─────────────────────────────────────────────────────────────┐
│           PATIENT SERVICE (Business Logic)                   │
├─────────────────────────────────────────────────────────────┤
│                                                              │
│  Update(Patient patient)                                    │
│  ├─ Validate patient data                                  │
│  ├─ Call database service                                  │
│  └─ Return success/failure                                 │
│                                                              │
└──────────────────────────┬─────────────────────────────────┘
						  │
						  ▼
┌─────────────────────────────────────────────────────────────┐
│          DATABASE SERVICE (Data Access)                      │
├─────────────────────────────────────────────────────────────┤
│                                                              │
│  DbPatientService.Update(Patient patient)                   │
│  ├─ Build UPDATE SQL query                                 │
│  ├─ Add parameters (safe from SQL injection)               │
│  ├─ Execute query                                          │
│  └─ Close connection                                       │
│                                                              │
└──────────────────────────┬─────────────────────────────────┘
						  │
						  ▼
┌─────────────────────────────────────────────────────────────┐
│                    SQL SERVER DATABASE                       │
├─────────────────────────────────────────────────────────────┤
│                                                              │
│  UPDATE Patients SET                                        │
│    FirstName = 'Ahmed',                                     │
│    LastName = 'Khan',                                       │
│    Email = 'ahmed@example.com',                             │
│    BloodGroup = 'A+',                                       │
│    ...                                                      │
│  WHERE Id = 'P001'                                          │
│                                                              │
└──────────────────────────┬─────────────────────────────────┘
						  │
				   [DATABASE UPDATED]
						  │
						  ▼
				   [SUCCESS MESSAGE]
						  │
						  ▼
				  [REFRESH GRID]
						  │
						  ▼
		 [SHOW UPDATED DATA IN PATIENT LIST]
```

---

## Data Flow Diagram

```
START: User wants to edit patient
  │
  ├─→ PatientView: User selects patient row
  │     └─→ dgvPatients_SelectionChanged()
  │         └─→ Store: _selectedPatientId = "P001"
  │
  ├─→ PatientView: User clicks "Edit" button
  │     └─→ btnEdit_Click()
  │         ├─→ Check: Is patient selected? (Yes)
  │         ├─→ Get: _patientService.GetById("P001")
  │         │   ├─→ DbPatientService.GetById()
  │         │   │   ├─→ SQL: SELECT * FROM Patients WHERE Id = 'P001'
  │         │   │   └─→ Return: Patient object with all fields populated
  │         │   └─→ Return to PatientView
  │         │
  │         ├─→ Open: new AddPatientForm(patient)
  │         │   └─→ Constructor: patientToEdit = patient
  │         │       ├─→ Set: _isEditMode = true
  │         │       ├─→ Call: PopulateForm(patient)
  │         │       │   ├─→ txtFirstName.Text = "Ahmed"
  │         │       │   ├─→ txtLastName.Text = "Khan"
  │         │       │   ├─→ txtEmail.Text = "ahmed@example.com"
  │         │       │   ├─→ cmbBloodGroup.SelectedItem = "A+"
  │         │       │   ├─→ ...and so on for all fields
  │         │       │   └─→ Form ready for editing
  │         │       └─→ Show form as modal dialog
  │         │
  │         ├─→ AddPatientForm: User modifies fields
  │         │   └─→ User changes data in various controls
  │         │
  │         ├─→ AddPatientForm: User clicks "Save"
  │         │   └─→ btnSave_Click()
  │         │       ├─→ Check: _isEditMode? (Yes)
  │         │       ├─→ Update: Patient.FirstName = txtFirstName.Text
  │         │       ├─→ Update: Patient.LastName = txtLastName.Text
  │         │       ├─→ Update: Patient.Email = txtEmail.Text
  │         │       ├─→ Update: ...all other fields
  │         │       ├─→ Set: DialogResult = OK
  │         │       └─→ Close form
  │         │
  │         ├─→ Back to PatientView: Dialog returned
  │         │   └─→ Check: DialogResult == OK? (Yes)
  │         │       ├─→ Call: _patientService.Update(form.Patient)
  │         │       │   ├─→ DbPatientService.Update(patient)
  │         │       │   │   ├─→ SQL: UPDATE Patients SET ... WHERE Id = 'P001'
  │         │       │   │   ├─→ Execute update query
  │         │       │   │   └─→ Return success
  │         │       │   └─→ Return to PatientView
  │         │       │
  │         │       ├─→ Show: "Patient updated successfully"
  │         │       ├─→ Call: RefreshGrid()
  │         │       │   ├─→ _patientService.GetAll()
  │         │       │   │   ├─→ SQL: SELECT * FROM Patients
  │         │       │   │   └─→ Return: List of all patients with updates
  │         │       │   └─→ dgvPatients.DataSource = patients
  │         │       │       └─→ Grid displays updated patient data
  │         │       │
  │         │       └─→ User sees updated patient in list
  │
  └─→ END: Patient successfully updated

```

---

## Component Interaction Diagram

```
┌──────────────────────────────────────────────────────────────────┐
│                    USER INTERFACE LAYER                          │
├──────────────────────────────────────────────────────────────────┤
│                                                                  │
│  PatientView (WinForms UserControl)                             │
│  ├─ ToolStrip (Toolbar)                                        │
│  │  ├─ btnAdd ─────→ Opens AddPatientForm for NEW patient     │
│  │  ├─ btnEdit ────→ Opens AddPatientForm for EXISTING patient│
│  │  ├─ btnView ────→ Opens PatientDetailsForm                 │
│  │  ├─ btnDelete ──→ Removes patient                          │
│  │  └─ btnRefresh ─→ Reloads patient list                     │
│  │                                                              │
│  └─ DataGridView (Patient List)                                │
│     └─ Displays all patients with columns:                    │
│        Id, FirstName, LastName, Phone, Email,                │
│        DateOfBirth, Gender, BloodGroup, AddressLine1, City,  │
│        EmergencyName, EmergencyPhone, MedicalHistory         │
│                                                                  │
└─────────────────────────┬─────────────────────────────────────────┘
						  │
						  │ Uses
						  ▼
┌──────────────────────────────────────────────────────────────────┐
│                   PRESENTATION LAYER                             │
├──────────────────────────────────────────────────────────────────┤
│                                                                  │
│  AddPatientForm (Dialog Window)                                 │
│  ├─ Constructor(Patient patientToEdit)                         │
│  ├─ PopulateForm(Patient patient)                              │
│  ├─ btnSave_Click()                                            │
│  ├─ btnCancel_Click()                                          │
│  └─ Properties:                                                │
│     └─ Patient { get; set; } - returns edited/new patient    │
│                                                                  │
└─────────────────────────┬─────────────────────────────────────────┘
						  │
						  │ Uses
						  ▼
┌──────────────────────────────────────────────────────────────────┐
│                 BUSINESS LOGIC LAYER                             │
├──────────────────────────────────────────────────────────────────┤
│                                                                  │
│  IPatientService (Interface)                                   │
│  ├─ GetAll() : List<Patient>                                  │
│  ├─ GetById(string id) : Patient                              │
│  ├─ Add(Patient patient) : void                               │
│  ├─ Update(Patient patient) : void  ◄─── USES THIS           │
│  ├─ Delete(string id) : void                                  │
│  └─ Search(string searchText) : List<Patient>                │
│                                                                  │
└─────────────────────────┬─────────────────────────────────────────┘
						  │
						  │ Implements
						  ▼
┌──────────────────────────────────────────────────────────────────┐
│                  DATA ACCESS LAYER                               │
├──────────────────────────────────────────────────────────────────┤
│                                                                  │
│  DbPatientService (SQL Implementation)                          │
│  ├─ GetAll()                                                   │
│  ├─ GetById(string id)                                        │
│  ├─ Add(Patient patient)                                      │
│  ├─ Update(Patient patient) ◄─── EXECUTES SQL UPDATE         │
│  ├─ Delete(string id)                                         │
│  ├─ Search(string searchText)                                 │
│  ├─ GetSafeString()                                           │
│  ├─ GeneratePatientId()                                       │
│  └─ ResolveTableName()                                        │
│                                                                  │
└─────────────────────────┬─────────────────────────────────────────┘
						  │
						  │ Connects to
						  ▼
┌──────────────────────────────────────────────────────────────────┐
│                   DATABASE LAYER                                 │
├──────────────────────────────────────────────────────────────────┤
│                                                                  │
│  SQL Server (LocalDB)                                           │
│  └─ HospitalDb Database                                        │
│     └─ Patients Table                                          │
│        ├─ Id (Primary Key)                                    │
│        ├─ FirstName                                           │
│        ├─ LastName                                            │
│        ├─ Phone                                               │
│        ├─ DateOfBirth                                         │
│        ├─ Gender                                              │
│        ├─ Email ◄─── NEW COLUMN                             │
│        ├─ BloodGroup ◄─── NEW COLUMN                        │
│        ├─ AddressLine1 ◄─── NEW COLUMN                      │
│        ├─ City ◄─── NEW COLUMN                              │
│        ├─ EmergencyName ◄─── NEW COLUMN                     │
│        ├─ EmergencyPhone ◄─── NEW COLUMN                    │
│        └─ MedicalHistory ◄─── NEW COLUMN                    │
│                                                                  │
└──────────────────────────────────────────────────────────────────┘
```

---

## State Diagram

```
				START
				  │
				  ▼
		┌─────────────────┐
		│  PatientView    │
		│  Showing Grid   │
		└────────┬────────┘
				 │
		 [User selects row]
		 [_selectedPatientId set]
				 │
				 ▼
		┌─────────────────┐
		│  Row Selected   │
		│  Ready for Edit │
		└────────┬────────┘
				 │
		 [User clicks Edit]
				 │
				 ▼
		┌─────────────────┐
		│  AddPatientForm │
		│  Opening...     │
		└────────┬────────┘
				 │
		 [Constructor called]
		 [patientToEdit parameter passed]
		 [_isEditMode = true]
		 [PopulateForm() called]
		 [All fields filled with existing data]
				 │
				 ▼
		┌─────────────────┐
		│  Edit Form      │
		│  Displayed      │
		│  Ready for Edit │
		└────────┬────────┘
				 │
		 [User modifies fields]
				 │
				 ▼
		┌─────────────────┐
		│  Editing Form   │
		│  Data Changed   │
		└────────┬────────┘
				 │
		 [User clicks Save]
		 [btnSave_Click() triggered]
				 │
				 ▼
		┌─────────────────┐
		│  Processing...  │
		│  Updating       │
		│  Patient Object │
		└────────┬────────┘
				 │
		 [Check: _isEditMode?]
		 [Yes: Update existing object]
		 [Set DialogResult = OK]
		 [Close form]
				 │
				 ▼
		┌─────────────────┐
		│ Back to         │
		│ PatientView     │
		│ Dialog Closed   │
		└────────┬────────┘
				 │
		 [Check: DialogResult == OK?]
		 [Yes: Call Update()]
				 │
				 ▼
		┌─────────────────┐
		│  Saving to DB   │
		│  UPDATE query   │
		│  Executing      │
		└────────┬────────┘
				 │
				 ▼
		┌─────────────────┐
		│  Database       │
		│  Updated ✓      │
		└────────┬────────┘
				 │
		 [Success message shown]
		 [RefreshGrid() called]
				 │
				 ▼
		┌─────────────────┐
		│  Grid Refreshed │
		│  New Data Shown │
		│  Ready Again    │
		└────────┬────────┘
				 │
				 ▼
				DONE
```

---

## Technology Stack

```
┌─────────────────────────────────────────────────────────┐
│              TECHNOLOGY STACK                           │
├─────────────────────────────────────────────────────────┤
│                                                         │
│  Language:  C# 14.0                                    │
│  Framework: .NET 10 (net10.0-windows)                 │
│  UI:        WinForms (Windows Forms)                  │
│  Database:  SQL Server (LocalDB)                      │
│  Driver:    Microsoft.Data.SqlClient                  │
│                                                         │
│  IDE:       Visual Studio Community 2026 (18.6.0)     │
│  Shell:     PowerShell                                │
│                                                         │
│  Architecture Pattern:  N-Tier / Layered              │
│  Data Access Pattern:   ADO.NET (SqlConnection)       │
│  UI Pattern:            MVVM-ish (UserControl)        │
│                                                         │
└─────────────────────────────────────────────────────────┘
```

---

## Migration Execution Steps

```
START
  │
  ├─→ Choose Migration Method
  │     ├─→ Windows Batch: RunMigration.bat (Double-click)
  │     ├─→ SQL Copy-Paste: COPY_PASTE_SQL_QUICK_FIX.md
  │     └─→ PowerShell: RunMigration.ps1
  │
  ├─→ Locate Script
  │     └─→ Hospital.Core\Scripts\AddPatientColumns.sql
  │
  ├─→ Execute Script
  │     └─→ SQL Commands:
  │         ├─→ IF NOT EXISTS ... ALTER TABLE ... ADD Email
  │         ├─→ IF NOT EXISTS ... ALTER TABLE ... ADD BloodGroup
  │         ├─→ IF NOT EXISTS ... ALTER TABLE ... ADD AddressLine1
  │         ├─→ IF NOT EXISTS ... ALTER TABLE ... ADD City
  │         ├─→ IF NOT EXISTS ... ALTER TABLE ... ADD EmergencyName
  │         ├─→ IF NOT EXISTS ... ALTER TABLE ... ADD EmergencyPhone
  │         └─→ IF NOT EXISTS ... ALTER TABLE ... ADD MedicalHistory
  │
  ├─→ Verify Success
  │     └─→ No errors in output
  │
  ├─→ Restart Application
  │     └─→ Close and reopen Hospital Appointment System
  │
  ├─→ Test Feature
  │     ├─→ Go to Patients tab
  │     ├─→ Select a patient
  │     ├─→ Click Edit button
  │     ├─→ Modify patient info
  │     ├─→ Click Save
  │     └─→ Grid updates ✓
  │
  └─→ SUCCESS!
	  Edit feature is now fully functional
```

---

## Summary

```
┌──────────────────────────────────────────┐
│     PATIENT EDIT FEATURE SUMMARY          │
├──────────────────────────────────────────┤
│                                          │
│  Files Modified:        4                │
│  Files Created:         9                │
│  Code Compilation:      ✅ Success       │
│  Database Migration:    ⏳ Pending      │
│  Documentation:         ✅ Complete     │
│  Automation Scripts:    ✅ Ready        │
│                                          │
│  Time to Implement:     ~90 minutes      │
│  Time to Deploy:        ~5 minutes       │
│                                          │
│  Status:                ✅ READY!        │
│                                          │
└──────────────────────────────────────────┘
```

---

**All diagrams show the complete architecture and flow of the Patient Edit feature.**

**Choose your preferred migration method and execute the SQL to complete the implementation!**
