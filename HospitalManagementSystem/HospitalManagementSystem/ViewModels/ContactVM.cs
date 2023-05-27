using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.ViewModels
{
    public class ContactVM
    {
        public int Id { get; set; }
        public int HospitalId { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public ContactVM()
        {

        }
        public ContactVM(Contact model)
        {
            Id = model.Id;
            Email = model.Email;
            Phone = model.Phone;
            HospitalId = model.HospitalId;


        }
        public Contact ConvertVM(ContactVM model)
        {
            Contact contact = new Contact
            {
                Id = model.Id,
                Email = model.Email,
                Phone = model.Phone,
                HospitalId = model.HospitalId,

            };
            return contact;


        }



    }
}
