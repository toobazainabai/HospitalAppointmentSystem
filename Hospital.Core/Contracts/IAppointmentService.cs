using Hospital.Core.Models;
using Hospital.Core.Utilities;
using System;
using System.Collections.Generic;

namespace Hospital.Core.Contracts
{
    public interface IAppointmentService
    {
        List<Appointment> GetAll();
        Appointment GetById(string id);

        void Add(Appointment appointment);
        void Update(Appointment appointment);
        void Delete(string id);

        List<Appointment> GetByPatientId(string patientId);
        List<Appointment> GetByDoctorId(string doctorId);
        List<Appointment> GetByStatus(AppointmentStatusEnum status);

        List<Appointment> Search(string text, AppointmentStatusEnum? status, DateTime? date);

        List<Appointment> GetRecent(int count);

        string GetNextAppointmentId();

        bool IsDoctorAvailable(string doctorId, DateTime appointmentDateTime, string excludeAppointmentId = null);
    }
}