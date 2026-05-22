-- Create Patients Table
CREATE TABLE Patients (
    Id NVARCHAR(50) PRIMARY KEY,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(15),
    DateOfBirth DATETIME NOT NULL,
    Gender NVARCHAR(50) NOT NULL DEFAULT 'Unknown'
);

-- Create Doctors Table
CREATE TABLE Doctors (
    Id NVARCHAR(50) PRIMARY KEY,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(15),
    Email NVARCHAR(100),
    ExperienceYears INT NOT NULL DEFAULT 0,
    Specialty NVARCHAR(50) NOT NULL DEFAULT 'General'
);

-- Create Appointments Table
CREATE TABLE Appointments (
    Id NVARCHAR(50) PRIMARY KEY,
    PatientId NVARCHAR(50) NOT NULL,
    DoctorId NVARCHAR(50) NOT NULL,
    AppointmentDateTime DATETIME NOT NULL,
    Status NVARCHAR(50) NOT NULL DEFAULT 'Scheduled',
    Notes NVARCHAR(MAX),
    FOREIGN KEY (PatientId) REFERENCES Patients(Id),
    FOREIGN KEY (DoctorId) REFERENCES Doctors(Id)
);

-- Create Indexes for Better Performance
CREATE INDEX IX_Appointments_PatientId ON Appointments(PatientId);
CREATE INDEX IX_Appointments_DoctorId ON Appointments(DoctorId);
CREATE INDEX IX_Appointments_Status ON Appointments(Status);
CREATE INDEX IX_Doctors_Specialty ON Doctors(Specialty);
