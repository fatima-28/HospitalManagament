using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class Payroll:BaseEntity
    {
        public AppUser Employee { get; set; }
        public int AppUserId { get; set; }
        public decimal Salary { get; set; }
        public decimal NetSalary { get; set; }
        public decimal HourSalary { get; set; }
        public decimal BonusSalary { get; set; }
        public decimal Compensation { get; set; }
        public string? AccountNo { get; set; }
    }
}