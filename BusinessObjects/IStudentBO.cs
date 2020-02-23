using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public interface IStudentBO
    {
        int StudentID { get; set; }
        String StudentName { get; set; }
        String EmailID { get; set; }
        int Marks { get; set; }
    }
}
