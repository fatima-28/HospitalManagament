using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class Labaratory:BaseEntity
    {
        public string? Number { get; set; }
        public string? TestType { get; set; }
        public string? TestCode { get; set; }
        public string? TestResult { get; set; }
        public AppUser? Patient { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Temperature { get; set; }
        public int BloodPreasure { get; set; }
    }
}
