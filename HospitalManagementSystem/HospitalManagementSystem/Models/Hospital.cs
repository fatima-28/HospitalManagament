using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class Hospital:BaseEntity
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PinCode { get; set; }
        public ICollection<Room>? Rooms { get; set; }
        public ICollection<Contact>? Contacts { get; set; }
    }
}
