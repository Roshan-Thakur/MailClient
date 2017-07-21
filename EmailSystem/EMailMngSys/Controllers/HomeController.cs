using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMailMngSys.Models;

namespace EMailMngSys.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index(UserDetails model)
        {
            //model.Name = "Roshan Thakur";
            //model.Address = "1546,Arthala Mohan Nagar Ghazibad";
            //model.Contact = "9716526132";
            //model.Email = "troshan23@gmail.com";
            //model.Password = "1234567";

            return View(model);
        }
	}
}