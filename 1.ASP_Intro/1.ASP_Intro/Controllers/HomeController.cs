using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.ASP_Intro.Controllers
{
    public class HomeController:Controller
    {

        //public ContentResult Index()
        //{
        //    return Content("salam");
        //}

        //public ViewResult About()
        //{
        //    var view = new ViewResult();
        //    view.ViewName = "About";
        //    return View();
        //}

        public ViewResult Index()
        {
            return View();
        }

    }
}
