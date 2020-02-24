using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccess;
using Unity;

namespace BusinessLogic
{
    public class StudentBL:IStudentBL
    {
        private readonly IStudentDAL _iStudentDAL;
        public StudentBL(IStudentDAL studentDAL)
        {
            _iStudentDAL = studentDAL;
        }
        
        public CustomMessage AddStudent(IStudentBO studentBO)
        {
            return _iStudentDAL.AddStudent(studentBO);
        }
        public List<StudentBO> GetStudents()
        {
            return _iStudentDAL.GetStudents();
        }
    }
}
