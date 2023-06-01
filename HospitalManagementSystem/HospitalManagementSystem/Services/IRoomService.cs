
using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.ViewModels;

namespace HospitalManagementSystem.Services
{
    public interface IRoomService
    {
        PagedResult<RoomVM> GetAll(int pageNum=1, int pageSize=10);
        RoomVM GetById(int id);
        void Edit(RoomVM vm);
        void Add(RoomVM vm);
        void Delete(int Id);
    }
}
