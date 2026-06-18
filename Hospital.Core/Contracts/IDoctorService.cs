using Hospital.Core.Models;
using Hospital.Core.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.Core.Contracts
{
    public interface IDoctorService
    {
        // Synchronous methods (backward compatibility)
        List<Doctor> GetAll();
        Doctor GetById(string id);
        void Add(Doctor doctor);
        void Update(Doctor doctor);
        void Delete(string id);
        List<Doctor> GetBySpecialty(DoctorSpecialtyEnum specialty);
        List<Doctor> Search(string text, DoctorSpecialtyEnum? specialty = null);

        // Asynchronous methods
        Task<List<Doctor>> GetAllAsync();
        Task<Doctor> GetByIdAsync(string id);
        Task AddAsync(Doctor doctor);
        Task UpdateAsync(Doctor doctor);
        Task DeleteAsync(string id);
        Task<List<Doctor>> GetBySpecialtyAsync(DoctorSpecialtyEnum specialty);
        Task<List<Doctor>> SearchAsync(string text, DoctorSpecialtyEnum? specialty = null);
    }
}
