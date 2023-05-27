using HospitalManagementSystem.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Room:BaseEntity
    {
        //[Required]
        public string? Number { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
        public int HospitalId { get; set; }
        public Hospital? Hospital { get; set; }
    }
}