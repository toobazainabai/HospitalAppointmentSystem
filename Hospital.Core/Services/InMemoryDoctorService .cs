using Hospital.Core.Contracts;
using Hospital.Core.Models;
using Hospital.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.Core.Services
{
    public class InMemoryDoctorService : IDoctorService
    {
        private readonly List<Doctor> _doctors = new();

        public List<Doctor> GetAll()
        {
            return _doctors.ToList();
        }

        public Doctor GetById(string id)
        {
            return _doctors.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Doctor doctor)
        {
            if (doctor == null)
            {
                throw new ArgumentNullException(nameof(doctor));
            }

            if (string.IsNullOrWhiteSpace(doctor.Id))
            {
                doctor.Id = Guid.NewGuid().ToString();
            }

            _doctors.Add(doctor);
        }

        public void Update(Doctor doctor)
        {
            if (doctor == null)
            {
                throw new ArgumentNullException(nameof(doctor));
            }

            var existing = GetById(doctor.Id);
            if (existing == null)
            {
                return;
            }

            existing.FirstName = doctor.FirstName;
            existing.LastName = doctor.LastName;
            existing.Phone = doctor.Phone;
            existing.Specialty = doctor.Specialty;
        }

        public void Delete(string id)
        {
            var existing = GetById(id);
            if (existing != null)
            {
                _doctors.Remove(existing);
            }
        }

        public List<Doctor> GetBySpecialty(DoctorSpecialtyEnum specialty)
        {
            return _doctors.Where(x => x.Specialty == specialty).ToList();
        }

        public List<Doctor> Search(string text, DoctorSpecialtyEnum? specialty = null)
        {
            IEnumerable<Doctor> query = _doctors;

            if (!string.IsNullOrWhiteSpace(text))
            {
                var searchText = text.Trim();
                query = query.Where(x =>
                    x.FirstName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    x.LastName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    x.Phone.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    x.Id.Contains(searchText, StringComparison.OrdinalIgnoreCase));
            }

            if (specialty.HasValue)
            {
                query = query.Where(x => x.Specialty == specialty.Value);
            }

            return query.ToList();
        }
    }
}
