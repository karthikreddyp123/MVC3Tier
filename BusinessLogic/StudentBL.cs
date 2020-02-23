using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccess;

namespace BusinessLogic
{
    public class StudentBL:IStudentBL
    {
        public CustomMessage AddStudent(IStudentBO studentBO)
        {
            return new StudentsDAL().AddStudent(studentBO);
        }
        public List<StudentBO> GetStudents()
        {
            return new StudentsDAL().GetStudents();
        }
    }
}
