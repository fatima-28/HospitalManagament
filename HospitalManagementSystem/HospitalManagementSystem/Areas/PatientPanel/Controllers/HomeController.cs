using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Areas.PatientPanel.Controllers
{
    public class HomeController : Controller
    {
        [Area("PatientPanel")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
