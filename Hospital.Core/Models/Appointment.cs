using System;
using Hospital.Core.Utilities;

namespace Hospital.Core.Models
{
    public class Appointment
    {
        public string Id { get; set; } = string.Empty;
        public string PatientId { get; set; } = string.Empty;
        public string DoctorId { get; set; } = string.Empty;
        public DateTime AppointmentDateTime { get; set; }
        public AppointmentStatusEnum Status { get; set; } = AppointmentStatusEnum.Scheduled;
        public string Notes { get; set; } = string.Empty;
    }
}
