using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AddressBook_ben.Entities;
using AddressBook_ben.DataContext;

namespace AddressBook_ben.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new AddressBookContext();
            var contacts = db.Contacts;
            
            return View(contacts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }
    }
}