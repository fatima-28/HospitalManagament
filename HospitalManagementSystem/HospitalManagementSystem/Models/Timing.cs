using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public enum Status
    {
        Available,
        Pending,
        Confirm
    }
    public class Timing:BaseEntity
    {
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public int MorningShftStartTime { get; set; }
        public int MorningShftEndTime { get; set; }
        public int AfternoonShftStartTime { get; set; }
        public int AfternoonShftEndTime { get; set; }
        public int Duration { get; set; }
        public Status Status { get; set; }
    }
}
