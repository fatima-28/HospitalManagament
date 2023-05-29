using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagementSystem.Services
{
    public interface IHospitalService
    {
        PagedResult<HospitalVM> GetAll(int pageNum=1, int pageSize=10);
        HospitalVM GetById(int id);
        void Edit(HospitalVM vm);
        void Add(HospitalVM vm);
        void Delete(int Id);
    }
}
