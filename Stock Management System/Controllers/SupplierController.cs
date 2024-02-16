using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_Management_System.Controllers.Data;
using Stock_Management_System.Models;

namespace Stock_Management_System.Controllers
{
    public class SupplierController : Controller
    {
        private readonly SupplierDbContext _db;

        public SupplierController(SupplierDbContext dbContext)
        {
            _db = dbContext;
        }

        public IActionResult SuppliersData()
        {
            var data = _db.Suppliers.ToList(); // Retrieve data from the database
            return View(data);
        }

        public IActionResult AddSuppliers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSuppliers(Supplier supplier)
        {
            _db.Suppliers.Add(supplier);
            _db.SaveChanges();
            return RedirectToAction("SuppliersData");
        }

        public IActionResult UpdateSuppliers(int id)
        {

            var data = _db.Suppliers.Find(id);

            if (data == null)
            {
                return NotFound(); // Or handle the case where the student with the given id is not found
            }

            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateSuppliers(Supplier supplier)
        {
            _db.Entry(supplier).State = EntityState.Modified;
            _db.SaveChanges();

            return RedirectToAction("SuppliersData");
        }
        public IActionResult RemoveSuppliers(int id)
        {
            var supplier = _db.Suppliers.Find(id);

            if (supplier == null)
            {
                return NotFound(); // Or handle the case where the supplier with the given id is not found
            }

            return View(supplier);
        }

        [HttpPost, ActionName("RemoveSuppliers")]
        public IActionResult RemoveSuppliersConfirmed(int id)
        {
            var supplier = _db.Suppliers.Find(id);

            if (supplier == null)
            {
                return NotFound(); // Or handle the case where the supplier with the given id is not found
            }

            _db.Suppliers.Remove(supplier);
            _db.SaveChanges();

            return RedirectToAction("SuppliersData");
        }
    }
}
