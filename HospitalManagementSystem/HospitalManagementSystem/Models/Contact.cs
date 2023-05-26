using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class Contact:BaseEntity
    {
        public int HospitalId { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Hospital? Hospital { get; set; }
    }
}