using Hospital.Core.Models;
using Hospital.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.Core.Contracts
{
    public interface IAppointmentService
    {List<Appointment> GetAll();
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

        // Asynchronous methods
        Task<List<Appointment>> GetAllAsync();
        Task<Appointment> GetByIdAsync(string id);

        Task AddAsync(Appointment appointment);
        Task UpdateAsync(Appointment appointment);
        Task DeleteAsync(string id);

        Task<List<Appointment>> GetByPatientIdAsync(string patientId);
        Task<List<Appointment>> GetByDoctorIdAsync(string doctorId);
        Task<List<Appointment>> GetByStatusAsync(AppointmentStatusEnum status);

        Task<List<Appointment>> SearchAsync(string text, AppointmentStatusEnum? status, DateTime? date);

        Task<List<Appointment>> GetRecentAsync(int count);

        Task<string> GetNextAppointmentIdAsync();

        Task<bool> IsDoctorAvailableAsync(string doctorId, DateTime appointmentDateTime, string excludeAppointmentId = null);
    }
}
        // Synchronous methods (backward compatibility)
        