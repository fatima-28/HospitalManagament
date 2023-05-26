using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class PrescribedMedicine:BaseEntity
    {
        public int MyProperty { get; set; }
        public Medicine? Medicine { get; set; }

        public int MedicineId { get; set; }
        public PatientReport? PatientReport { get; set; }

        public int PatientReportId { get; set; }
    }
}
