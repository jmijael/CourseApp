using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoursesApp.DataEF;

namespace CoursesAppMVC.Views
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentDataEF StudentDataEF = new StudentDataEF();
            ViewBag.Students = StudentDataEF.List();
            return View();
        }
    }
}