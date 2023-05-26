using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class Department:BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<AppUser>? Employees { get; set; }
    }
}
