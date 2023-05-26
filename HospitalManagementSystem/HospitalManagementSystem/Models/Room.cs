using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class Room:BaseEntity
    {
        public string? Number { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
        public int HospitalId { get; set; }
        public Hospital? Hospital { get; set; }
    }
}