using HospitalManagementSystem.Services;
using HospitalManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospitalManagementSystem.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ContactController : Controller
    {
        private readonly IContactService _contaxtService;
        private readonly IHospitalService _hospitalService;
        public ContactController(IContactService contaxtService, IHospitalService hospitalService)
        {
            _contaxtService = contaxtService;
            _hospitalService = hospitalService;
        }
        public IActionResult Index(int PageNum = 1, int PageSize = 10)
        {
            return View(_contaxtService.GetAll(PageNum, PageSize));
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Create(ContactVM vm)
        {
       
            _contaxtService.Add(vm);
            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
           // ViewBag.hospitals = new SelectList(_hospitalService.GetAll(), "Id", "Name");
            var vm = _contaxtService.GetById(id);
            return View(vm);

        }
        [HttpPost]
        public IActionResult Edit(ContactVM vm)
        {
            _contaxtService.Edit(vm);
            return RedirectToAction("Index");

        }


        public IActionResult Delete(int id)
        {
            _contaxtService.Delete(id);
            return RedirectToAction("Index");

        }


    }

}
