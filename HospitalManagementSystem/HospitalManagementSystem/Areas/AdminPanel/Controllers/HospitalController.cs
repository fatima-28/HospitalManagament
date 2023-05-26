using HospitalManagementSystem.Services;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
