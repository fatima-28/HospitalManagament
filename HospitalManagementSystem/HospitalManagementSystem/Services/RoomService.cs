
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Repositories.Interfaces;
using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.ViewModels;

namespace HospitalManagementSystem.Services
{
    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;


        }

        public void Add(RoomVM vm)
        {
            var model = new RoomVM().ConvertVM(vm);
                _unitOfWork.GenericRepository<Room>().Add(model);
                _unitOfWork.Save();
      
           
        }

        public void Delete(int Id)
        {
            var model = _unitOfWork.GenericRepository<Room>().GetById(Id);
            _unitOfWork.GenericRepository<Room>().Delete(model);
            _unitOfWork.Save();

        }

        public void Edit(RoomVM vm)
        {
            var model = new RoomVM().ConvertVM(vm);
            var modelWthId = _unitOfWork.GenericRepository<Room>().GetById(model.Id);
            modelWthId.Number = vm.RoomNo;
            modelWthId.Type = vm.Type;
            modelWthId.Status = vm.Status;
            modelWthId.HospitalId = vm.HospitalId;
            _unitOfWork.GenericRepository<Room>().Update(modelWthId);
            _unitOfWork.Save();

        }
        public RoomVM GetById(int id)
        {
            var room = _unitOfWork.GenericRepository<Room>().GetById(id);
            var roomVm = new RoomVM(room);
            return roomVm;
        }

        public PagedResult<RoomVM> GetAll(int PageNum, int PageSize)
        {
            var roomVM = new RoomVM();
            int totalCnt = 0;
            List<RoomVM> roomVmList = new List<RoomVM>();
            try
            {
                var excRecords = (PageNum * PageSize) - PageSize;
                var modelList = _unitOfWork.GenericRepository<Room>().GetAll(IncludeProperties:"Hospital").Skip(excRecords).Take(PageSize).ToList();
                totalCnt = _unitOfWork.GenericRepository<Room>().GetAll().ToList().Count;
                roomVmList = ConvertModelToVMList(modelList);
            }
            catch (Exception)
            {


                throw;
            }
            var res = new PagedResult<RoomVM>()
            {
                Data = roomVmList,
                TotalItems = totalCnt,
                PageNum = PageNum,
                PageSize = PageSize

            };
            return res;
        }

        private List<RoomVM> ConvertModelToVMList(List<Room> modelList)
        {
            return modelList.Select(l => new RoomVM(l)).ToList();
        }


    

}
}
