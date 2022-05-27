using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.ASP_Intro.Controllers
{
    public class ExamController : Controller
    {
        //public IActionResult Result()
        //{
        //    return View();
        //}

        public  ActionResult Result(int studentId,int year)
        {
            return Content(studentId.ToString() + " " + year.ToString());
            //return View();
        }
        public ActionResult Detail (int id)
        {
            TempData["ExamId"] = id;
            ViewData["ExamId"] = id; 
            ViewBag.ExamId = id;
            return View();
        }
    }
}
