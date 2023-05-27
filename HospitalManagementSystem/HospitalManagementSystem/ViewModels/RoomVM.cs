using HospitalManagementSystem.Helper;
using HospitalManagementSystem.Models;
using Microsoft.Build.Framework;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace HospitalManagementSystem.ViewModels
{
    public class RoomVM
    {
        public int Id { get; set; }
        //[Required]
        public string? RoomNo { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
        public int HospitalId { get; set; }
        public RoomVM()
        {

        }
        public RoomVM(Room model)
        {
            Id = model.Id;
            RoomNo = model.Number;
            Type = model.Type;
            Status = model.Status;
            HospitalId = model.HospitalId;


        }
        public Room ConvertVM(RoomVM model)
        {
            Room room = new Room
            {
                Id = model.Id,
                Number = model.RoomNo,
                Type = model.Type,
                Status = model.Status,
                HospitalId = model.HospitalId,

            };
            return room;


        }


    }

}