using HospitalManagementSystem.Services;
using HospitalManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Areas.AdminPanel.Controllers
{
    [Area("Admin")]
    public class HospitalController : Controller
    {
        private readonly IHospitalService _hospitalService;
        public HospitalController(IHospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }
        public IActionResult Index(int pageNum=1,int pageSize=10)
        {
            return View(_hospitalService.GetAll(pageNum, pageSize));
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


    }
}
