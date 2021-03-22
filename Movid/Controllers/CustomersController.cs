using Movid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movid.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {

            var customer = GetCustomers().ToList().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return new HttpNotFoundResult();
    

            return View(customer);
        }
        
         

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id = 1, Name = "Arthur Pille" },
                new Customer{Id = 2, Name = "Emilie Pille" },
                new Customer{Id = 3, Name = "Serge Pille" },
                new Customer{Id = 4, Name = "Arnold Schwarzenegger" },
                new Customer{Id = 5, Name = "Tom Cruise" }

            };

           
            
        }
    }
}