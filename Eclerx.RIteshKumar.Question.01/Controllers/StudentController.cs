using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eclerx.RIteshKumar.Question._01.Models;

namespace Eclerx.RIteshKumar.Question._01.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult AddorEdit(int studentId=0)
        {
            StudentRegistraion StudentModel1 = new StudentRegistraion();
            return View(StudentModel1);
        }
    }
}