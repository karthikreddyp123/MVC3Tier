using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
namespace DataAccess
{
    public interface IStudentDAL
    {
        CustomMessage AddStudent(IStudentBO studentBO);
        List<StudentBO> GetStudents();
    }
}
