using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class Appointment:BaseEntity
    {
        public string? Number { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public DateTime CreatingDate { get; set; }
        public AppUser? Doctor { get; set; }
        public AppUser? Patient { get; set; }
    }
}