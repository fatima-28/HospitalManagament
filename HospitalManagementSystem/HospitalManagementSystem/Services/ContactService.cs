using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Repositories.Interfaces;
using HospitalManagementSystem.ViewModels;

namespace HospitalManagementSystem.Services
{
    public class ContactService : IContactService
    {

        private readonly IUnitOfWork _unitOfWork;
        public ContactService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;


        }

        public void Add(ContactVM vm)
        {
            var model = new ContactVM().ConvertVM(vm);
            _unitOfWork.GenericRepository<Contact>().Add(model);
            _unitOfWork.Save();
        }

        public void Delete(int Id)
        {
            var model = _unitOfWork.GenericRepository<Contact>().GetById(Id);
            _unitOfWork.GenericRepository<Contact>().Delete(model);
            _unitOfWork.Save();

        }

        public void Edit(ContactVM vm)
        {
            var model = new ContactVM().ConvertVM(vm);
            var modelWthId = _unitOfWork.GenericRepository<Contact>().GetById(model.Id);
            modelWthId.Email = vm.Email;
            modelWthId.Phone = vm.Phone;          
            modelWthId.HospitalId = vm.HospitalId;
            _unitOfWork.GenericRepository<Contact>().Update(modelWthId);
            _unitOfWork.Save();

        }
        public ContactVM GetById(int id)
        {
            var Contact = _unitOfWork.GenericRepository<Contact>().GetById(id);
            var ContactVm = new ContactVM(Contact);
            return ContactVm;
        }

        public PagedResult<ContactVM> GetAll(int PageNum, int PageSize)
        {
            var ContactVM = new ContactVM();
            int totalCnt = 0;
            List<ContactVM> ContactVMList = new List<ContactVM>();
            try
            {
                var excRecords = (PageNum * PageSize) - PageSize;
                var modelList = _unitOfWork.GenericRepository<Contact>().GetAll(IncludeProperties: "Hospital").Skip(excRecords).Take(PageSize).ToList();

                totalCnt = _unitOfWork.GenericRepository<Contact>().GetAll().ToList().Count;
                ContactVMList = ConvertModelToVMList(modelList);
            }
            catch (Exception)
            {


                throw;
            }
            var res = new PagedResult<ContactVM>()
            {
                Data = ContactVMList,
                TotalItems = totalCnt,
                PageNum = PageNum,
                PageSize = PageSize

            };
            return res;
        }


        private List<ContactVM> ConvertModelToVMList(List<Contact> modelList)
        {
            return modelList.Select(l => new ContactVM(l)).ToList();
        }




    }
}
