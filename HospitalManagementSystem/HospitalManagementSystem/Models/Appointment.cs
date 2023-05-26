using HospitalManagementSystem.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Appointment:BaseEntity
    {
        public string? Number { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public DateTime CreatingDate { get; set; }
        [NotMapped]
        public AppUser? Doctor { get; set; }
        [NotMapped]
        public AppUser? Patient { get; set; }
    }
}