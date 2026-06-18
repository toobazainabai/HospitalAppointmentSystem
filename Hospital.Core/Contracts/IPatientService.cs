using Hospital.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.Core.Contracts
{
    public interface IPatientService
    {
        // Synchronous methods (backward compatibility)
        List<Patient> GetAll();
        Patient GetById(string id);
        void Add(Patient patient);
        void Update(Patient patient);
        void Delete(string id);
        List<Patient> Search(string text);

        // Asynchronous methods
        Task<List<Patient>> GetAllAsync();
        Task<Patient> GetByIdAsync(string id);
        Task AddAsync(Patient patient);
        Task UpdateAsync(Patient patient);
        Task DeleteAsync(string id);
        Task<List<Patient>> SearchAsync(string text);
    }
}