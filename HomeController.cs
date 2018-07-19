using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sqlDBCheck.Models; // to tell VS we're using name of file and the models within it

namespace sqlDBCheck.Controllers
{
    public class HomeController : Controller
    {
        private CustomersOrdersJulyEntities db = new CustomersOrdersJulyEntities(); // line of code to add to link up the database - name of database file plus entities.

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}