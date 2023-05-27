using HospitalManagementSystem.Services;
using HospitalManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        public IActionResult Index(int PageNum = 1, int PageSize = 10)
        {
            return View(_roomService.GetAll(PageNum, PageSize));
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Create(RoomVM vm)
        { 
            _roomService.Add(vm);
            return RedirectToAction("Index");
            //if (!ModelState.IsValid)
            //{

            //    return View(vm);


            //}
            //else
            //{
            //    _roomService.Add(vm);
            //    return RedirectToAction("Index");
            //}

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var vm = _roomService.GetById(id);
            return View(vm);

        }
        [HttpPost]
        public IActionResult Edit(RoomVM vm)
        {
            _roomService.Edit(vm);
            return RedirectToAction("Index");

        }


        public IActionResult Delete(int id)
        {
            _roomService.Delete(id);
            return RedirectToAction("Index");

        }


    }
}
