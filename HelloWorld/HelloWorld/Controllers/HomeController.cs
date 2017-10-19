using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            var model = new HomeModel();

            model.Message = "Hello, World!!";
            
            //ViewBag.message = "Hello, World!"
           // ViewData["message"] = "Hello, World"; //ViewData is a collection and can be used to pass data like you would in a Viewstate. 
            return View(model);
        }

    }
}
