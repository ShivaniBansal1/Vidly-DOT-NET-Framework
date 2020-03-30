using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlyy.Models;
using Vidlyy.ViewModels;

namespace Vidlyy.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);

        }

        public IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
                {
                    new Customer { Id = 1, Name = "John Smith" },
                    new Customer { Id = 2, Name = "Marry Williams" }
                };

            return customers;

        }

        public ActionResult Details(int id = 0)
        {
            var listOfCustomers = GetCustomers();
            
            var customer = listOfCustomers.SingleOrDefault(item => item.Id == id);
            if (id==0 || customer == null)
            {
                return HttpNotFound();
            }
               
            return View(customer);
        }
    }
}