using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.ViewModels;

namespace HospitalManagementSystem.Services
{
    public interface IContactService
    {
        PagedResult<ContactVM> GetAll(int pageNum, int pageSize);
        ContactVM GetById(int id);
        void Edit(ContactVM vm);
        void Add(ContactVM vm);
        void Delete(int Id);
    }
}
