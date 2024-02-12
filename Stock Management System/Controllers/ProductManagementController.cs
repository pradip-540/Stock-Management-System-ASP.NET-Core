using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_Management_System.Controllers.Data;
using Stock_Management_System.Models;

namespace Stock_Management_System.Controllers
{
    public class ProductManagementController : Controller
    {
        private readonly StockDbContext db;

        public ProductManagementController(StockDbContext context)
        {
            db = context;
        }
        public IActionResult ViewAll()
        {

            var data = db.ViewAllItems.ToList(); // Retrieve data from the database
            return View(data);
         
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(View model)
        {
            db.ViewAllItems.Add(model);
            db.SaveChanges();
            return RedirectToAction("ViewAll");
        }

      
 
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Remove()
        {
            return View();
        }


    }
}
