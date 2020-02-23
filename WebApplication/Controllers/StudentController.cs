using BusinessLogic;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private readonly IStudentBL _iStudentBL;
        private readonly IStudentBO _iStudentBO;
        public StudentController(IStudentBL istudentBL,IStudentBO istudentBO)
        {
            _iStudentBL = istudentBL;
            _iStudentBO = istudentBO;
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(StudentBO studentBO)
        {
            if (ModelState.IsValid)
            {
                CustomMessage customMessage = new CustomMessage();
                customMessage = _iStudentBL.AddStudent(studentBO);
            } 
            return View(studentBO);
        }
        public ActionResult Index()
        {
            //StudentBL studentBL = new StudentBL();
            
            return View(_iStudentBL.GetStudents());
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}