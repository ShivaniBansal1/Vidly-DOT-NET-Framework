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
        public ViewResult Index()
        {
            var customers = new List<Customer>()
                {
                    new Customer { Id = 1, Name = "John Smith" },
                    new Customer { Id = 2, Name = "Marry Williams" }
                };

            return View(customers);

        }
    }
}