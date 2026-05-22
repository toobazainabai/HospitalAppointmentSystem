using Hospital.Core.Models;
using Hospital.Core.Utilities;
using System.Collections.Generic;

namespace Hospital.Core.Contracts
{
    public interface IDoctorService
    {
        List<Doctor> GetAll();
        Doctor GetById(string id);
        void Add(Doctor doctor);
        void Update(Doctor doctor);
        void Delete(string id);
        List<Doctor> GetBySpecialty(DoctorSpecialtyEnum specialty);
        List<Doctor> Search(string text, DoctorSpecialtyEnum? specialty = null);
    }
}
