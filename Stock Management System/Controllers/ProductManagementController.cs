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

        [HttpPost]
        public IActionResult Update(int id, [Bind("Id, Product, Item, Price")] View model)
        {
            if (id != model.Id)
            {
                return NotFound(); // Handle case where entity ID does not match
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Retrieve the existing entity from the database
                    var existingEntity = db.ViewAllItems.Find(id);
                    if (existingEntity == null)
                    {
                        return NotFound(); // Handle case where entity is not found
                    }

                    // Update the properties of the existing entity with data from the form
                    existingEntity.Product = model.Product;
                    existingEntity.Item = model.Item;
                    existingEntity.Price = model.Price;

                    // Save changes to persist the updated entity in the database
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    // Handle exception
                    return RedirectToAction("Error", "Home"); // Redirect to error page
                }

                return RedirectToAction("ViewAll"); // Redirect to ViewAll action after successful update
            }

            // If ModelState is not valid, return the view with validation errors
            return View(model);
        }

        public IActionResult Remove()
        {
            return View();
        }
        [HttpPost, ActionName("Remove")]
        [ValidateAntiForgeryToken]
        public IActionResult Remove(int id)
        {
            try
            {
                // Retrieve the entity to be deleted from the database
                var entity = db.ViewAllItems.Find(id);
                if (entity == null)
                {
                    return NotFound(); // Handle case where entity is not found
                }

                // Remove the entity from the database
                db.ViewAllItems.Remove(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                // Handle exception
                return RedirectToAction("Error", "Home"); // Redirect to error page
            }

            return RedirectToAction("ViewAll"); // Redirect to ViewAll action after successful deletion
        }

        //order Management here goes
        public IActionResult Purchase()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Purchase(View model)
        {
            db.ViewAllItems.Add(model);
            db.SaveChanges();
            return RedirectToAction("ViewAll");
        }

        public IActionResult SellManagement()
        {
            return View();
        }

      
    }
}
