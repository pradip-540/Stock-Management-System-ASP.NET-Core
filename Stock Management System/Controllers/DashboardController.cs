using Microsoft.AspNetCore.Mvc;
using Stock_Management_System.Models;
using System.Diagnostics;

namespace Stock_Management_System.Controllers
{
    public class DashboardController : Controller
    {

        public IActionResult Dashboard()
        {
            return View();
        }



    }
}
