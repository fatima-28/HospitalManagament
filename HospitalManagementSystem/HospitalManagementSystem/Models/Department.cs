using HospitalManagementSystem.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Department:BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        //[NotMapped]
        public ICollection<AppUser>? Employees { get; set; }
    }
}
