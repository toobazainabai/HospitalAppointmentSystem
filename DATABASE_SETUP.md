# Hospital Appointment System - Database Setup Guide

## Overview
Yeh project **ADO.NET (Raw SQL)** approach use karta hai database operations ke liye.

## Architecture

### Services (ADO.NET-based)
- **DbPatientService** - Patient CRUD operations
- **DbDoctorService** - Doctor CRUD operations  
- **DbAppointmentService** - Appointment CRUD operations

### Connection
- **App.config** - Connection string configuration
- **SQL Server LocalDB** - Default database (offline, no install needed)

---

## Database Setup Steps

### Step 1: Create Database Tables

1. Open **SQL Server Management Studio (SSMS)** ya **Visual Studio SQL Server Object Explorer**
2. Connect to: `(localdb)\MSSQLLocalDB`
3. Open **Hospital.Core/Scripts/CreateDatabase.sql**
4. Execute the SQL script

Ya PowerShell se:
```powershell
sqlcmd -S "(localdb)\MSSQLLocalDB" -i "Hospital.Core\Scripts\CreateDatabase.sql"
```

### Step 2: Verify Connection String

Check `Hospital.WindowsApp/App.config`:
```xml
<connectionStrings>
  <add name="HospitalDb" 
       connectionString="Server=(localdb)\MSSQLLocalDB;Database=HospitalDb;..." />
</connectionStrings>
```

### Step 3: Build & Run

```powershell
dotnet build
dotnet run --project Hospital.WindowsApp
```

---

## Key Classes

### DbPatientService
```csharp
public class DbPatientService : IPatientService
{
    private readonly string _connectionString;

    public DbPatientService(string connString) { ... }

    public List<Patient> GetAll() { ... }
    public Patient GetById(string id) { ... }
    public void Add(Patient patient) { ... }
    public void Update(Patient patient) { ... }
    public void Delete(string id) { ... }
    public List<Patient> Search(string searchText) { ... }
}
```

### DbDoctorService
```csharp
public class DbDoctorService : IDoctorService
{
    public List<Doctor> GetAll() { ... }
    public Doctor GetById(string id) { ... }
    public void Add(Doctor doctor) { ... }
    public void Update(Doctor doctor) { ... }
    public void Delete(string id) { ... }
    public List<Doctor> GetBySpecialty(DoctorSpecialtyEnum specialty) { ... }
    public List<Doctor> Search(string text, DoctorSpecialtyEnum? specialty) { ... }
}
```

### DbAppointmentService
```csharp
public class DbAppointmentService : IAppointmentService
{
    public List<Appointment> GetAll() { ... }
    public Appointment GetById(string id) { ... }
    public void Add(Appointment appointment) { ... }
    public void Update(Appointment appointment) { ... }
    public void Delete(string id) { ... }
    public List<Appointment> GetByPatientId(string patientId) { ... }
    public List<Appointment> GetByDoctorId(string doctorId) { ... }
    public List<Appointment> GetByStatus(AppointmentStatusEnum status) { ... }
    public List<Appointment> Search(string text, AppointmentStatusEnum? status, DateTime? date) { ... }
    public bool IsDoctorAvailable(string doctorId, DateTime appointmentDateTime) { ... }
}
```

---

## Database Tables

### Patients
| Column | Type | Notes |
|--------|------|-------|
| Id | NVARCHAR(50) | PRIMARY KEY |
| FirstName | NVARCHAR(100) | NOT NULL |
| LastName | NVARCHAR(100) | NOT NULL |
| Phone | NVARCHAR(15) | |
| DateOfBirth | DATETIME | NOT NULL |
| Gender | NVARCHAR(50) | Default: 'Unknown' |

### Doctors
| Column | Type | Notes |
|--------|------|-------|
| Id | NVARCHAR(50) | PRIMARY KEY |
| FirstName | NVARCHAR(100) | NOT NULL |
| LastName | NVARCHAR(100) | NOT NULL |
| Phone | NVARCHAR(15) | |
| Email | NVARCHAR(100) | |
| ExperienceYears | INT | Default: 0 |
| Specialty | NVARCHAR(50) | Default: 'General' |

### Appointments
| Column | Type | Notes |
|--------|------|-------|
| Id | NVARCHAR(50) | PRIMARY KEY |
| PatientId | NVARCHAR(50) | FOREIGN KEY → Patients |
| DoctorId | NVARCHAR(50) | FOREIGN KEY → Doctors |
| AppointmentDateTime | DATETIME | NOT NULL |
| Status | NVARCHAR(50) | Default: 'Scheduled' |
| Notes | NVARCHAR(MAX) | |

---

## Usage in Forms/Views

```csharp
// Example in MainForm.cs
private readonly IPatientService _patientService;

public MainForm(IPatientService patientService)
{
    InitializeComponent();
    _patientService = patientService;
}

private void LoadPatients()
{
    var patients = _patientService.GetAll();
    dataGridView.DataSource = patients;
}

private void AddPatient()
{
    var patient = new Patient
    {
        Id = Guid.NewGuid().ToString(),
        FirstName = txtFirstName.Text,
        LastName = txtLastName.Text,
        Phone = txtPhone.Text,
        DateOfBirth = datePickerDOB.Value,
        Gender = (GenderEnum)comboGender.SelectedValue
    };

    _patientService.Add(patient);
}
```

---

## Key Features

✅ **Raw ADO.NET** - Direct SQL control  
✅ **Parameterized Queries** - SQL Injection protection  
✅ **Enum Handling** - Automatic enum parsing  
✅ **CRUD Operations** - Complete Add/Read/Update/Delete  
✅ **Advanced Search** - Filter by multiple criteria  
✅ **Doctor Availability** - Check doctor scheduling  
✅ **Dependency Injection** - Services registered in Program.cs  

---

## Troubleshooting

### Connection String Issues
```
Error: Cannot connect to (localdb)\MSSQLLocalDB
→ Ensure SQL Server LocalDB is installed
→ Check App.config connection string spelling
```

### Table Not Found
```
Error: Invalid object name 'Patients'
→ Run CreateDatabase.sql script in SSMS
→ Check database name is 'HospitalDb'
```

### SQL Server Object Explorer
```
View → SQL Server Object Explorer
→ Add SQL Server
→ (localdb)\MSSQLLocalDB
→ Right-click Databases → Create New Database → HospitalDb
```

---

## Viva Points (Sir ke liye)

1. **ADO.NET क्या है?** - Direct database access using SqlConnection, SqlCommand
2. **Parameterized Queries क्यों?** - SQL Injection से बचने के लिए
3. **Connection String कहाँ?** - App.config में
4. **Service Layer क्यों?** - Separation of concerns, reusability
5. **Enum Handling कैसे?** - Enum.TryParse() का उपयोग
6. **Database Relationships?** - Foreign Keys (PatientId, DoctorId)
7. **Performance?** - Indexes on PatientId, DoctorId, Status, Specialty
