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
        ICustomMessage AddStudent(IStudentBO studentBO);
        List<StudentBO> GetStudents();
    }
}
