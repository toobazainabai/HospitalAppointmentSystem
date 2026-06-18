-- Complete Hospital Database Setup Script
-- This script creates the database, tables, and adds sample data

-- Step 1: Create Database (if it doesn't exist)
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'HospitalDb')
BEGIN
	CREATE DATABASE HospitalDb;
END
GO

-- Step 2: Use the HospitalDb database
USE HospitalDb;
GO

-- Step 3: Create dbPatient Table (if it doesn't exist)
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'dbPatient')
BEGIN
	CREATE TABLE dbo.dbPatient (
		Id NVARCHAR(50) PRIMARY KEY,
		FirstName NVARCHAR(100) NOT NULL,
		LastName NVARCHAR(100) NOT NULL,
		Phone NVARCHAR(15),
		DateOfBirth DATETIME NOT NULL,
		Gender NVARCHAR(50) NOT NULL DEFAULT 'Unknown'
	);
END
GO

-- Step 4: Create dbDoctor Table (if it doesn't exist)
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'dbDoctor')
BEGIN
	CREATE TABLE dbo.dbDoctor (
		Id NVARCHAR(50) PRIMARY KEY,
		FirstName NVARCHAR(100) NOT NULL,
		LastName NVARCHAR(100) NOT NULL,
		Phone NVARCHAR(15),
		Email NVARCHAR(100),
		ExperienceYears INT NOT NULL DEFAULT 0,
		Specialty NVARCHAR(50) NOT NULL DEFAULT 'General'
	);
END
GO

-- Step 5: Create dbAppointment Table (if it doesn't exist)
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'dbAppointment')
BEGIN
	CREATE TABLE dbo.dbAppointment (
		Id NVARCHAR(50) PRIMARY KEY,
		PatientId NVARCHAR(50) NOT NULL,
		DoctorId NVARCHAR(50) NOT NULL,
		AppointmentDateTime DATETIME NOT NULL,
		Status NVARCHAR(50) NOT NULL DEFAULT 'Scheduled',
		Notes NVARCHAR(MAX),
		FOREIGN KEY (PatientId) REFERENCES dbo.dbPatient(Id),
		FOREIGN KEY (DoctorId) REFERENCES dbo.dbDoctor(Id)
	);
END
GO

-- Step 5.5: Create dbPrescription Table (if it doesn't exist)
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'dbPrescription')
BEGIN
	CREATE TABLE dbo.dbPrescription (
		Id NVARCHAR(50) PRIMARY KEY,
		AppointmentId NVARCHAR(50) NOT NULL,
		PatientId NVARCHAR(50) NOT NULL,
		DoctorId NVARCHAR(50) NOT NULL,
		MedicationName NVARCHAR(100) NOT NULL,
		Dosage NVARCHAR(50) NOT NULL,
		Frequency NVARCHAR(100) NOT NULL,
		Duration NVARCHAR(50) NOT NULL,
		Instructions NVARCHAR(MAX),
		DatePrescribed DATETIME NOT NULL DEFAULT GETDATE(),
		Status NVARCHAR(50) NOT NULL DEFAULT 'Active',
		FOREIGN KEY (AppointmentId) REFERENCES dbo.dbAppointment(Id),
		FOREIGN KEY (PatientId) REFERENCES dbo.dbPatient(Id),
		FOREIGN KEY (DoctorId) REFERENCES dbo.dbDoctor(Id)
	);
END
GO

-- Step 6: Create Indexes for Better Performance
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Appointments_PatientId')
	CREATE INDEX IX_Appointments_PatientId ON dbo.dbAppointment(PatientId);
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Appointments_DoctorId')
	CREATE INDEX IX_Appointments_DoctorId ON dbo.dbAppointment(DoctorId);
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Appointments_Status')
	CREATE INDEX IX_Appointments_Status ON dbo.dbAppointment(Status);
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Doctors_Specialty')
	CREATE INDEX IX_Doctors_Specialty ON dbo.dbDoctor(Specialty);
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Prescriptions_AppointmentId')
	CREATE INDEX IX_Prescriptions_AppointmentId ON dbo.dbPrescription(AppointmentId);
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Prescriptions_PatientId')
	CREATE INDEX IX_Prescriptions_PatientId ON dbo.dbPrescription(PatientId);
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Prescriptions_DoctorId')
	CREATE INDEX IX_Prescriptions_DoctorId ON dbo.dbPrescription(DoctorId);
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Prescriptions_Status')
	CREATE INDEX IX_Prescriptions_Status ON dbo.dbPrescription(Status);
GO

-- Step 7: Clear existing data (optional - comment out if you want to keep existing data)
DELETE FROM dbo.dbPrescription;
DELETE FROM dbo.dbAppointment;
DELETE FROM dbo.dbPatient;
DELETE FROM dbo.dbDoctor;
GO

-- Step 8: Insert Patients into dbPatient table
INSERT INTO dbo.dbPatient (Id, FirstName, LastName, Phone, DateOfBirth, Gender) VALUES
('P001', 'Ahmed', 'Khan', '03001234567', '1990-05-15', 'Male'),
('P002', 'Fatima', 'Ali', '03009876543', '1988-08-22', 'Female'),
('P003', 'Hassan', 'Malik', '03102345678', '1995-03-10', 'Male'),
('P004', 'Aisha', 'Ahmed', '03115555555', '1992-11-18', 'Female'),
('P005', 'Muhammad', 'Hassan', '03214444444', '1985-07-05', 'Male'),
('P006', 'Zainab', 'Omar', '03016666666', '1998-12-30', 'Female');

-- Step 9: Insert Doctors into dbDoctor table
INSERT INTO dbo.dbDoctor (Id, FirstName, LastName, Phone, Email, ExperienceYears, Specialty) VALUES
('D001', 'Dr. Ali', 'Ahmed', '03211111111', 'dr.ali@hospital.com', 15, 'Cardiology'),
('D002', 'Dr. Saira', 'Khan', '03212222222', 'dr.saira@hospital.com', 10, 'Neurology'),
('D003', 'Dr. Farooq', 'Malik', '03213333333', 'dr.farooq@hospital.com', 8, 'Orthopedics'),
('D004', 'Dr. Hina', 'Hussain', '03214444444', 'dr.hina@hospital.com', 12, 'Pediatrics'),
('D005', 'Dr. Tariq', 'Hassan', '03215555555', 'dr.tariq@hospital.com', 20, 'General'),
('D006', 'Dr. Amina', 'Raza', '03216666666', 'dr.amina@hospital.com', 7, 'Dermatology');

-- Step 10: Insert Appointments into dbAppointment table
INSERT INTO dbo.dbAppointment (Id, PatientId, DoctorId, AppointmentDateTime, Status, Notes) VALUES
('A001', 'P001', 'D001', '2025-05-20 10:00:00', 'Scheduled', 'Regular checkup for heart condition'),
('A002', 'P002', 'D002', '2025-05-21 14:30:00', 'Scheduled', 'Neurological evaluation'),
('A003', 'P003', 'D003', '2025-05-22 09:15:00', 'Completed', 'Post-surgery follow-up'),
('A004', 'P004', 'D004', '2025-05-23 11:00:00', 'Scheduled', 'Child vaccination'),
('A005', 'P005', 'D005', '2025-05-24 16:45:00', 'Scheduled', 'General health checkup'),
('A006', 'P006', 'D006', '2025-05-25 13:20:00', 'Cancelled', 'Skin allergy treatment - Rescheduled');

-- Step 11: Insert Prescriptions into dbPrescription table
INSERT INTO dbo.dbPrescription (Id, AppointmentId, PatientId, DoctorId, MedicationName, Dosage, Frequency, Duration, Instructions, DatePrescribed, Status) VALUES
('RX001', 'A001', 'P001', 'D001', 'Aspirin', '100mg', 'Once daily', '30 days', 'Take with food. Do not crush tablets.', '2025-05-20', 'Active'),
('RX002', 'A001', 'P001', 'D001', 'Lisinopril', '10mg', 'Once daily', '30 days', 'Take in the morning. Monitor blood pressure.', '2025-05-20', 'Active'),
('RX003', 'A002', 'P002', 'D002', 'Amitriptyline', '25mg', 'Once at bedtime', '60 days', 'May cause drowsiness. Do not drive.', '2025-05-21', 'Active'),
('RX004', 'A003', 'P003', 'D003', 'Ibuprofen', '400mg', 'Three times daily', '10 days', 'Take with meals. Avoid if allergic to NSAIDs.', '2025-05-22', 'Active'),
('RX005', 'A004', 'P004', 'D004', 'Paracetamol', '250mg', 'As needed', '5 days', 'For fever and pain relief. Max 5 doses per day.', '2025-05-23', 'Active'),
('RX006', 'A005', 'P005', 'D005', 'Metformin', '500mg', 'Twice daily', '90 days', 'Take with meals. Monitor blood sugar levels.', '2025-05-24', 'Active'),
('RX007', 'A006', 'P006', 'D006', 'Cetirizine', '10mg', 'Once daily', '14 days', 'Take as needed for allergies. May cause drowsiness.', '2025-05-25', 'Active');

PRINT 'Database setup completed successfully!';
PRINT 'Tables created: dbPatient, dbDoctor, dbAppointment, dbPrescription';
PRINT 'Sample data inserted: 6 Patients, 6 Doctors, 6 Appointments, 7 Prescriptions';
