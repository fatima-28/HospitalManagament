using HospitalManagementSystem.Models;

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
                PinCode = model.PinCode
            };
            return hospital;


        }




    }
}
