
using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.ViewModels;

namespace HospitalManagementSystem.Services
{
    public interface IRoomService
    {
        PagedResult<RoomVM> GetAll(int pageNum, int pageSize);
        RoomVM GetById(int id);
        void Edit(RoomVM vm);
        void Add(RoomVM vm);
        void Delete(int Id);
    }
}
