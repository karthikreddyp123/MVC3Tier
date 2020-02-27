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
        private ICustomMessage _customMessage;
        private readonly IStudentBO _studentBO;
        public StudentController(IStudentBL istudentBL,ICustomMessage customMessage,IStudentBO studentBO)
        {
            _customMessage = customMessage;
            _iStudentBL = istudentBL;
            _studentBO = studentBO;
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
                _customMessage = _iStudentBL.AddStudent(studentBO);
                TempData["MessageNumber"] = _customMessage.MessageNumber.ToString();
                TempData["CustomMessage"] = _customMessage.Message.ToString();
                if (_customMessage.MessageNumber == 1)
                {
                    return RedirectToAction("Index");
                }
            } 
            return View(studentBO);
        }
        public ActionResult Index()
        {

            ViewData["CustomMessage"] = TempData["CustomMessage"];
            return View(_iStudentBL.GetStudents());
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}