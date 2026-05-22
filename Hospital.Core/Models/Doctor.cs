using Hospital.Core.Utilities;
using System;

namespace Hospital.Core.Models
{
    public class Doctor
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int ExperienceYears { get; set; } = 0;
        public DoctorSpecialtyEnum Specialty { get; set; } = DoctorSpecialtyEnum.General;
    }
}
