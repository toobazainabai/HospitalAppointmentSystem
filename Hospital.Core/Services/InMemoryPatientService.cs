using Hospital.Core.Contracts;
using Hospital.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.Core.Services
{
    public class InMemoryPatientService : IPatientService
    {
        private readonly List<Patient> _patients = new();

        public List<Patient> GetAll()
        {
            return _patients.ToList();
        }

        public Patient GetById(string id)
        {
            return _patients.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentNullException(nameof(patient));
            }

            if (string.IsNullOrWhiteSpace(patient.Id))
            {
                patient.Id = Guid.NewGuid().ToString();
            }

            _patients.Add(patient);
        }

        public void Update(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentNullException(nameof(patient));
            }

            var existing = GetById(patient.Id);
            if (existing == null)
            {
                return;
            }

            existing.FirstName = patient.FirstName;
            existing.LastName = patient.LastName;
            existing.Phone = patient.Phone;
            existing.DateOfBirth = patient.DateOfBirth;
            existing.Gender = patient.Gender;
        }

        public void Delete(string id)
        {
            var existing = GetById(id);
            if (existing != null)
            {
                _patients.Remove(existing);
            }
        }

        public List<Patient> Search(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return GetAll();
            }

            text = text.Trim();

            return _patients
                .Where(x =>
                    x.FirstName.Contains(text, StringComparison.OrdinalIgnoreCase) ||
                    x.LastName.Contains(text, StringComparison.OrdinalIgnoreCase) ||
                    x.Phone.Contains(text, StringComparison.OrdinalIgnoreCase) ||
                    x.Id.Contains(text, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
