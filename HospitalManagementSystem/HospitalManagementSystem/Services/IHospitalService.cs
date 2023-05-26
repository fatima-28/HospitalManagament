using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagementSystem.Services
{
    public interface IHospitalService
    {
        PagedResult<HospitalVM> GetAll(int pageNum, int pageSize);
    }
}
