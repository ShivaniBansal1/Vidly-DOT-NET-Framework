using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlyy.Models;
using Vidlyy.ViewModels;

namespace Vidlyy.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>()
            {
                new Customer {Name="shivani"},
                new Customer {Name = "shefali"}
            };

            var viewModel = new MovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model = movie;

            return View(viewModel); //most appropriate

            //ViewData["Movie"] = movie; //viewData is a dictionary i.e viewDataDictionary
            //return View();

            //ViewBag.Movie = movie;  //casting issue and magic string problem
            //return View();


            //return new ViewResult();
            //return Content("hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });
        }

        public ActionResult Edit(int Id)
        {
            return Content("Id=" + Id);

        }

        public ActionResult Index(int? pageIndex, string sortBy) //string in c# is reference type so its already nullable
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")] //putting multiple constarints //power of attribute routing
        public ActionResult ByReleaseDate(int year , int month)
        {
            return Content(year+"/"+month);
        }

    }


}