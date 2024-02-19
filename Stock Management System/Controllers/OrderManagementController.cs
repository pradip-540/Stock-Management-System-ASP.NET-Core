using Microsoft.AspNetCore.Mvc;
using Stock_Management_System.Controllers.Data;
using Stock_Management_System.Models;

namespace Stock_Management_System.Controllers
{
    public class OrderManagement : Controller
    {

        private readonly OrderDbContext db1;

        public OrderManagement(OrderDbContext context)
        {
            db1 = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SellManagement(SellItems model)
        {
            db1.SoldItems.Add(model);
            db1.SaveChanges();

            return Json(new { success = true, message = "Data saved successfully!" });//open json like page
        }

    }
}
