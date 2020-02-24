using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessObjects;
namespace WebApplication.CustomBinder
{
    public class StudentBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase requestBase = controllerContext.HttpContext.Request;
            string strStudentName = requestBase.Form.Get("StudentName");
            string strStudentMarks = requestBase.Form.Get("Marks");
            string strEmailID = requestBase.Form.Get("EmailID");

            return new StudentBO
            {
                StudentName = strStudentName,
                EmailID = strEmailID,
                Marks = Convert.ToInt32(strStudentMarks)
            };
        }
    }
}