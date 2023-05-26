using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class Supplier:BaseEntity
    {
        public string? Company { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Adress { get; set; }
        public ICollection<MedicineReport>? MedicineReport { get; set; }
    }
}
