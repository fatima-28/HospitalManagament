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

        public void Add(HospitalVM vm)
        {
           var model=new HospitalVM().ConvertVM(vm);
            _unitOfWork.GenericRepository<Hospital>().Add(model);
            _unitOfWork.Save();
        }

        public void Delete(int Id)
        {
           var model=_unitOfWork.GenericRepository<Hospital>().GetById(Id);
            _unitOfWork.GenericRepository<Hospital>().Delete(model);
            _unitOfWork.Save();

        }

        public void Edit(HospitalVM vm)
        {
            var model = new HospitalVM().ConvertVM(vm);
            var modelWthId = _unitOfWork.GenericRepository<Hospital>().GetById(model.Id);
            modelWthId.PinCode=vm.PinCode;
            modelWthId.City=vm.City;
            modelWthId.Name=vm.Name;
            modelWthId.Country=vm.Country;
            _unitOfWork.GenericRepository<Hospital>().Update(modelWthId);
            _unitOfWork.Save();

        }
        public HospitalVM GetById(int id)
        {
            var hospital = _unitOfWork.GenericRepository<Hospital>().GetById(id);
            var hospVm = new HospitalVM(hospital);
            return hospVm;
        }

        public PagedResult<HospitalVM> GetAll(int PageNum, int PageSize)
        {
            var hospitalVM = new HospitalVM();
            int totalCnt = 0;
            List<HospitalVM> hospitalVmList = new List<HospitalVM>();
            try
            {
                var excRecords = (PageNum * PageSize) - PageSize;
                var modelList = _unitOfWork.GenericRepository<Hospital>().GetAll().Skip(excRecords).Take(PageSize).ToList();

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
                PageNum = PageNum,
                PageSize = PageSize

            };
            return res;
        }

      
        private List<HospitalVM> ConvertModelToVMList(List<Hospital> modelList)
        {
            return modelList.Select(l => new HospitalVM(l)).ToList();
        }
       

    }
}

