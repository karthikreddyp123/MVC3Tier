using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccess;
using Unity;

namespace BusinessLogic
{
    public class StudentBL:IStudentBL
    {
        private readonly IStudentDAL _iStudentDAL;
        private ICustomMessage _customMessage;
        public StudentBL(IStudentDAL studentDAL,ICustomMessage customMessage)
        {
            _iStudentDAL = studentDAL;
            _customMessage = customMessage;
        }
        /// <summary>
        /// This method performs client side validations and applies respective business logic to pass data from PL to DAL to add Student
        /// </summary>
        /// <param name="studentBO"></param>
        /// <returns></returns>
        public ICustomMessage AddStudent(IStudentBO studentBO)
        {
            int _flag = 0;
            bool isEmail = Regex.IsMatch(studentBO.EmailID, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (studentBO.StudentName=="")
            {
                _flag = 1;
            }
            if (!isEmail)
            {
                _flag = 1;
            }
            if (_flag == 0)
            {
                return _iStudentDAL.AddStudent(studentBO);
            }
            else
            {
                _customMessage.MessageNumber = 0;
                _customMessage.Message = "Please Enter correct Details";
                return _customMessage;
            }
        }
        /// <summary>
        /// This methods Student List sent from DAL to PL
        /// </summary>
        /// <returns></returns>
        public List<StudentBO> GetStudents()
        {
            return _iStudentDAL.GetStudents();
        }
    }
}
