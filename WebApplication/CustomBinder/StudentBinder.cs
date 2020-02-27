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
        //This class is used to Bind Custom models
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase requestBase = controllerContext.HttpContext.Request;
            string strStudentName = requestBase.Form.Get("StudentName");
            string strStudentMarks = requestBase.Form.Get("Marks");
            string strEmailID = requestBase.Form.Get("EmailID");
            StudentBO studentBO = new StudentBO();
            studentBO.StudentName = strStudentName;
            studentBO.EmailID = strEmailID;
            int temp;
            if(Int32.TryParse(strStudentMarks,out temp))
            {
                studentBO.Marks = Convert.ToInt32(strStudentMarks);
            }
            
            return studentBO;
         }
    }
}