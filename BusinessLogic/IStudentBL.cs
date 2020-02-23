using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IStudentBL
    {
        CustomMessage AddStudent(IStudentBO studentBO);
        List<StudentBO> GetStudents();
    }
}
