using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagementSystem.Services
{
    public interface IHospitalService
    {
        PagedResult<HospitalVM> GetAll(int pageNum, int pageSize);
        HospitalVM GetById(int id);
        void Edit(HospitalVM vm);
        void Add(HospitalVM vm);
        void Delete(int Id);
    }
}
