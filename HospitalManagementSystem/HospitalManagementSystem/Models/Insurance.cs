using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class Insurance:BaseEntity
    {
        public string? PolicyNum { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public ICollection<Bill>? Bill { get; set; }
    }
}
