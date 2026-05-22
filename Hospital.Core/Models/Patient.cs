using Hospital.Core.Utilities;
using System;

namespace Hospital.Core.Models
{
    public class Patient
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; } = GenderEnum.Unknown;
        public string BloodGroup { get; set; } = "Unknown";
        public string Email { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string EmergencyName { get; set; } = string.Empty;
        public string EmergencyPhone { get; set; } = string.Empty;
        public string MedicalHistory { get; set; } = string.Empty;
    }
}
