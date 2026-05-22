using Hospital.Core.Models;
using System.Collections.Generic;

namespace Hospital.Core.Contracts
{
    public interface IPatientService
    {
        List<Patient> GetAll();
        Patient GetById(string id);
        void Add(Patient patient);
        void Update(Patient patient);
        void Delete(string id);
        List<Patient> Search(string text);
    }
}