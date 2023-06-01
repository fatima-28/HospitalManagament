using HospitalManagementSystem.Models;
using HospitalManagementSystem.Services;
using HospitalManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class HospitalController : Controller
    {
        private readonly IHospitalService _hospitalService;
        private readonly IRoomService _roomService;
        public HospitalController(IHospitalService hospitalService, IRoomService roomService)
        {
            _hospitalService = hospitalService;
            _roomService = roomService;
        }
        public IActionResult Index(int PageNum=1,int PageSize=10)
        {
            return View(_hospitalService.GetAll(PageNum, PageSize));
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Create(HospitalVM vm)
        {
            _hospitalService.Add(vm);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var vm = _hospitalService.GetById(id);
            return View(vm);
            
        }
        [HttpPost]
        public IActionResult Edit(HospitalVM vm)
        {
           _hospitalService.Edit(vm);
            return RedirectToAction("Index");

        }

      
        public IActionResult Delete(int id)
        {
            _hospitalService.Delete(id);
            return RedirectToAction("Index");

        }

        public async Task< IActionResult> Detail(int id)
        {
            var rooms = _roomService.GetAll().Data.Where(m => m.HospitalId == id);
            ViewBag.rooms = rooms;
            HospitalVM hospital = _hospitalService.GetById(id);
            return View(hospital);

        }
    }
}
