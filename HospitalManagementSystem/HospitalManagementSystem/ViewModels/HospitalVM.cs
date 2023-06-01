using HospitalManagementSystem.Helper;
using HospitalManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HospitalManagementSystem.ViewModels
{
    public class HospitalVM
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PinCode { get; set; }
        public ICollection<Room>? Rooms { get; set; }
        public ICollection<Contact>? Contacts { get; set; }
        public HospitalVM()
        {
            
        }
        public HospitalVM(Hospital model)
        {
            Id=model.Id; 
            Name=model.Name;
            Type=model.Type;
            City=model.City;
            Country=model.Country;
            PinCode=model.PinCode;
            Rooms = model.Rooms;
            Contacts = model.Contacts;


        }
        public Hospital ConvertVM(HospitalVM model)
        {
            Hospital hospital = new Hospital
            {
                Id = model.Id,
                Name = model.Name,
                Type = model.Type,
                City = model.City,
                Country = model.Country,
                PinCode = GeneratePinCode.Generate(),
                Contacts = model.Contacts,
                Rooms = model.Rooms
        };
            return hospital;


        }
       




    }
}
