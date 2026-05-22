using Hospital.Core.Contracts;
using Hospital.Core.Models;
using Hospital.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.Core.Services
{
    public class InMemoryAppointmentService : IAppointmentService
    {
        private readonly List<Appointment> _appointments = new();

        public List<Appointment> GetAll()
        {
            return _appointments.ToList();
        }

        public Appointment GetById(string id)
        {
            return _appointments.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException(nameof(appointment));
            }

            if (!IsDoctorAvailable(appointment.DoctorId, appointment.AppointmentDateTime))
            {
                throw new InvalidOperationException("Doctor is not available at this time.");
            }

            if (string.IsNullOrWhiteSpace(appointment.Id))
            {
                appointment.Id = Guid.NewGuid().ToString();
            }

            _appointments.Add(appointment);
        }

        public void Update(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException(nameof(appointment));
            }

            var existing = GetById(appointment.Id);
            if (existing == null)
            {
                return;
            }

            if (!IsDoctorAvailable(appointment.DoctorId, appointment.AppointmentDateTime, appointment.Id))
            {
                throw new InvalidOperationException("Doctor is not available at this time.");
            }

            existing.PatientId = appointment.PatientId;
            existing.DoctorId = appointment.DoctorId;
            existing.AppointmentDateTime = appointment.AppointmentDateTime;
            existing.Status = appointment.Status;
            existing.Notes = appointment.Notes;
        }

        public void Delete(string id)
        {
            var existing = GetById(id);
            if (existing != null)
            {
                _appointments.Remove(existing);
            }
        }

        public List<Appointment> GetByPatientId(string patientId)
        {
            return _appointments.Where(x => x.PatientId == patientId).ToList();
        }

        public List<Appointment> GetByDoctorId(string doctorId)
        {
            return _appointments.Where(x => x.DoctorId == doctorId).ToList();
        }

        public List<Appointment> GetByStatus(AppointmentStatusEnum status)
        {
            return _appointments.Where(x => x.Status == status).ToList();
        }

        public List<Appointment> Search(string text, AppointmentStatusEnum? status, DateTime? date)
        {
            IEnumerable<Appointment> query = _appointments;

            if (!string.IsNullOrWhiteSpace(text))
            {
                var searchText = text.Trim();
                query = query.Where(x =>
                    x.Id.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    x.PatientId.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    x.DoctorId.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    x.Notes.Contains(searchText, StringComparison.OrdinalIgnoreCase));
            }

            if (status.HasValue)
            {
                query = query.Where(x => x.Status == status.Value);
            }

            if (date.HasValue)
            {
                var targetDate = date.Value.Date;
                query = query.Where(x => x.AppointmentDateTime.Date == targetDate);
            }

            return query.ToList();
        }

        public List<Appointment> GetRecent(int count)
        {
            return _appointments
                .OrderByDescending(x => x.AppointmentDateTime)
                .Take(count)
                .ToList();
        }

        public string GetNextAppointmentId()
        {
            var existingIds = _appointments.Select(x => x.Id).ToList();
            return AppointmentIdGenerator.GenerateNextId(existingIds);
        }

        public bool IsDoctorAvailable(string doctorId, DateTime appointmentDateTime, string excludeAppointmentId = null)
        {
            return !_appointments.Any(x =>
                x.DoctorId == doctorId &&
                x.AppointmentDateTime == appointmentDateTime &&
                x.Id != excludeAppointmentId &&
                x.Status != AppointmentStatusEnum.Cancelled);
        }
    }
}
