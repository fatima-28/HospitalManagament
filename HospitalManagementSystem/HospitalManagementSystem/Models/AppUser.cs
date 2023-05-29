using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

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
        public bool IsDoctor { get; set; }
        public string ImageUrl { get; set; }
        public Gender Gender { get; set; }
        public DateTime Date { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        [NotMapped]
        public ICollection<Appointment>? Appointment { get; set; }
        [NotMapped]
        public ICollection<Payroll>? Payrolls { get; set; }
    }
   
}
