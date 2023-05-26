using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class PatientReport:BaseEntity
    {
        public string? Diagnose { get; set; }
        public ICollection<PrescribedMedicine>? PrescribedMedicine { get; set; }
        public AppUser? Doctor { get; set; }
        public AppUser? Patient { get; set; }
    }
}
