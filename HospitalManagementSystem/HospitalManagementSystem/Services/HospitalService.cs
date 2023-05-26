using HospitalManagementSystem.Models;
using HospitalManagementSystem.Repositories.Interfaces;
using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.ViewModels;

namespace HospitalManagementSystem.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly IUnitOfWork _unitOfWork;
        public HospitalService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;


        }
        public PagedResult<HospitalVM> GetAll(int pageNum, int pageSize)
        {
            var hospitalVM = new HospitalVM();
            int totalCnt = 0;
            List<HospitalVM> hospitalVmList = new List<HospitalVM>();
            try
            {
                var excRecords = (pageNum * pageSize) - pageSize;
                var modelList = _unitOfWork.GenericRepository<Hospital>().GetAll().Skip(excRecords).Take(pageSize).ToList();

                totalCnt = _unitOfWork.GenericRepository<Hospital>().GetAll().ToList().Count;
                hospitalVmList = ConvertModelToVMList(modelList);
            }
            catch (Exception)
            {


                throw;
            }
            var res = new PagedResult<HospitalVM>()
            {
                Data = hospitalVmList,
                TotalItems = totalCnt,
                PageNum = pageNum,
                PageSize = pageSize

            };
            return res;
        }
        private List<HospitalVM> ConvertModelToVMList(List<Hospital> modelList)
        {
            return modelList.Select(l => new HospitalVM(l)).ToList();
        }


    }
}

