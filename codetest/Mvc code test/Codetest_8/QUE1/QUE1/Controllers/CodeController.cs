using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeTest8.Models;
using System.Data.Entity;

namespace CodeTest8.Controllers
{
    public class CodeController : Controller
    {
        // GET: Code
        private readonly NorthwindEntities _DbContext = new NorthwindEntities();
        public ActionResult Index()
        {
            var germanCustomers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germanCustomers);
        }

        public ActionResult CustomersInGermany()
        {
            var customers = _DbContext.Customers.Where(c => c.Country == "Germany").ToList();
            return View(customers);
        }

        public ActionResult CustomerDetailsWithOrder()
        {
            var customerDetails = _DbContext.Orders
                .Where(o => o.OrderID == 10248)
                .Select(o => o.Customer)
                .FirstOrDefault();

            return View(customerDetails);
        }
    }
}