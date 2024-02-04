using Microsoft.AspNetCore.Mvc;

namespace Stock_Management_System.Controllers
{
    public class ProductManagementController : Controller
    {
        public IActionResult ViewAll()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
