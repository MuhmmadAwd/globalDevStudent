
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using globalDevStudent.GlobalDev.Entities;
using globalDevStudent.GlobalDev;

namespace globalDevStudent.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var DB = new GlobalDevContxt();
            var Students = DB.Students.ToList();
            return View(Students);
        }
        public ActionResult Create(Student student)
        {
            var DB = new GlobalDevContxt();
            DB.Students.Add(student);
            DB.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}