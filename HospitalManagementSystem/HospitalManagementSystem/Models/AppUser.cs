using Microsoft.AspNetCore.Identity;

namespace HospitalManagementSystem.Models
{
    public enum Gender
    {
        Male,
        Famale,
        Other
    }
    public class AppUser:IdentityUser
    {
        public string? FullName { get; set; }
        public string? Nationality { get; set; }
        public string? Adress { get; set; }
        public string? Specialist { get; set; }
        public Gender Gender { get; set; }
        public DateTime Date { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Appointment>? Appointment { get; set; }
        public ICollection<Payroll>? Payrolls { get; set; }
    }
   
}
