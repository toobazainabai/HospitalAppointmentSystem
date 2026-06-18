-- Seed Sample Data for Hospital Database
-- Use the correct table names: dbPatient, dbDoctor, dbAppointment

-- Insert Patients into dbPatients table
INSERT INTO dbo.Patients (
    Id, FirstName, LastName, Phone, Email, DateOfBirth, Gender, 
    BloodGroup, AddressLine1, City, EmergencyName, EmergencyPhone, MedicalHistory
) VALUES 
('P002', 'Fatima', 'Ali', '03009876543', 'Aliii@gmail.com', '1988-08-22', 'Female', 'Unknown', 'Y Block ,Defence', 'Multan', 'Kamran', '03221134563', 'lungs function'),

('P003', 'Hassan', 'Malik', '03102345678', 'Malik@gmail.com', '1995-03-10', 'Male', 'B-', 'islamiya town', 'Bhawalpur', 'Raza Sami', '03242212567', 'Typhoid'),

('P004', 'Aisha', 'Ahmed', '03115555555', 'Aiaha@gmail.com', '1992-11-18', 'Female', 'Unknown', 'DHA', 'Bhawalpur', 'Ahmed Khan', '03334565758', 'Diarrhea'),

('P005', 'Muhammad', 'Hassan', '03214444444', 'Hassan@gmail.com', '1985-07-05', 'Male', 'AB+', 'Khan village', 'Khanpur', 'Ali Hammad', '03214123123', 'Diabetes'),

('P006', 'Zainab', 'Omar', '03016666666', 'omer@gmail.com', '1998-12-30', 'Female', 'O+', 'Gulberg', 'Multan', 'Sana Ameer', '03234568976', 'Asthma'),

('P007', 'ali', 'ahmad', '03454444333', 'AAli@gmail.com', '2026-05-18', 'Male', 'B+', 'Khan Village', 'KhanPur', 'Ali Mohsen', '03333345678', 'liver inflammati...');

-- Insert Doctors into dbDoctors table
INSERT INTO dbo.dbDoctors (Id, FirstName, LastName, Phone, Email, ExperienceYears, Specialty) VALUES
('D001', 'Dr. Ali', 'Ahmed', '03211111111', 'dr.ali@hospital.com', 15, 'Cardiology'),
('D002', 'Dr. Saira', 'Khan', '03212222222', 'dr.saira@hospital.com', 10, 'Neurology'),
('D003', 'Dr. Farooq', 'Malik', '03213333333', 'dr.farooq@hospital.com', 8, 'Orthopedics'),
('D004', 'Dr. Hina', 'Hussain', '03214444444', 'dr.hina@hospital.com', 12, 'Pediatrics'),
('D005', 'Dr. Tariq', 'Hassan', '03215555555', 'dr.tariq@hospital.com', 20, 'General'),
('D006', 'Dr. Amina', 'Raza', '03216666666', 'dr.amina@hospital.com', 7, 'Dermatology');

-- Insert Appointments into dbAppointments table
INSERT INTO dbo.dbAppointments (Id, PatientId, DoctorId, AppointmentDateTime, Status, Notes) VALUES
('A001', 'P001', 'D001', '2025-05-20 10:00:00', 'Scheduled', 'Regular checkup for heart condition'),
('A002', 'P002', 'D002', '2025-05-21 14:30:00', 'Scheduled', 'Neurological evaluation'),
('A003', 'P003', 'D003', '2025-05-22 09:15:00', 'Completed', 'Post-surgery follow-up'),
('A004', 'P004', 'D004', '2025-05-23 11:00:00', 'Scheduled', 'Child vaccination'),
('A005', 'P005', 'D005', '2025-05-24 16:45:00', 'Scheduled', 'General health checkup'),
('A006', 'P006', 'D006', '2025-05-25 13:20:00', 'Cancelled', 'Skin allergy treatment - Rescheduled');

-- Insert Prescriptions into dbo.Prescriptions table
INSERT INTO dbo.Prescriptions (Id, AppointmentId, PatientId, DoctorId, MedicationName, Dosage, Frequency, Duration, Instructions, DatePrescribed, Status) VALUES
('RX001', 'A001', 'P001', 'D001', 'Aspirin', '100mg', 'Once daily', '30 days', 'Take with food. Do not crush tablets.', '2025-05-20', 'Active'),
('RX002', 'A001', 'P001', 'D001', 'Lisinopril', '10mg', 'Once daily', '30 days', 'Take in the morning. Monitor blood pressure.', '2025-05-20', 'Active'),
('RX003', 'A002', 'P002', 'D002', 'Amitriptyline', '25mg', 'Once at bedtime', '60 days', 'May cause drowsiness. Do not drive.', '2025-05-21', 'Active'),
('RX004', 'A003', 'P003', 'D003', 'Ibuprofen', '400mg', 'Three times daily', '10 days', 'Take with meals. Avoid if allergic to NSAIDs.', '2025-05-22', 'Active'),
('RX005', 'A004', 'P004', 'D004', 'Paracetamol', '250mg', 'As needed', '5 days', 'For fever and pain relief. Max 5 doses per day.', '2025-05-23', 'Active'),
('RX006', 'A005', 'P005', 'D005', 'Metformin', '500mg', 'Twice daily', '90 days', 'Take with meals. Monitor blood sugar levels.', '2025-05-24', 'Active'),
('RX007', 'A006', 'P006', 'D006', 'Cetirizine', '10mg', 'Once daily', '14 days', 'Take as needed for allergies. May cause drowsiness.', '2025-05-25', 'Active')