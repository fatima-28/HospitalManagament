using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class Medicine:BaseEntity
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public ICollection<MedicineReport>? MedicineReport { get; set; }
        public ICollection<PrescribedMedicine>? PrescribedMedicine { get; set; }
    }
}
