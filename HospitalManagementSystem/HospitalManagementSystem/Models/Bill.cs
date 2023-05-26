using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class Bill:BaseEntity
    {
        public int BillNumber { get; set; }
        public AppUser? Patient { get; set; }
        public Insurance? Insurance { get; set; }
        public decimal DoctorCharge { get; set; }
        public decimal MedicineCharge { get; set; }
        public decimal RoomCharge { get; set; }
        public decimal OperationCharge { get; set; }
        public decimal NursingCharge { get; set; }
        public decimal LabCharge { get; set; }
        public decimal Progress { get; set; }
        public int NumOfDays { get; set; }
        public decimal TotalBill { get; set; }
    }
}
