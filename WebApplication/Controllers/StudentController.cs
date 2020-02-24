using BusinessLogic;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.CustomBinder;

namespace WebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private readonly IStudentBL _iStudentBL;
        public StudentController(IStudentBL istudentBL)
        {
            _iStudentBL = istudentBL;
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add([ModelBinder(typeof(StudentBinder))]IStudentBO studentBO)
        {
            if (ModelState.IsValid)
            {
                CustomMessage customMessage = new CustomMessage();
                customMessage = _iStudentBL.AddStudent(studentBO);
                //ViewBag.CustomMessage = customMessage.MessageNumber.ToString();
                return RedirectToAction("Index");
            } 
            return View(studentBO);
        }
        public ActionResult Index()
        {            
            return View(_iStudentBL.GetStudents());
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}