using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidlyy.Models;

namespace Vidlyy.ViewModels
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}