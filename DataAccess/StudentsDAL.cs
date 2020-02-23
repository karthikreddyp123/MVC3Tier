using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
namespace DataAccess
{
    public class StudentsDAL
    {
        private StudentsEntities studentsEntities;
        public StudentsDAL()
        {
            studentsEntities = new StudentsEntities();
        }
        public CustomMessage AddStudent(IStudentBO studentBO)
        {
            CustomMessage customMessage = new CustomMessage();
            StudentTable studentTable = new StudentTable()
            {
                StudentName=studentBO.StudentName,
                EmailID=studentBO.EmailID,
                Marks=studentBO.Marks
            };
            studentsEntities.StudentTables.Add(studentTable);
            //studentsEntities.StudentTables.ToList<StudentTable>();
            int returnValue = studentsEntities.SaveChanges();
            if (returnValue > 0)
            {
                customMessage.MessageNumber = returnValue;
                customMessage.Message = "Student Added Susscessfully.";
            }
            else
            {
                customMessage.MessageNumber = returnValue;
                customMessage.Message = "Cannot Add Student.";
            }
            return customMessage;
        }
        public List<StudentBO> GetStudents()
        {
            List<StudentTable> list = studentsEntities.StudentTables.ToList<StudentTable>();
            List<StudentBO> BOList = new List<StudentBO>();
            foreach (StudentTable st in list)
            {
                StudentBO sb = new StudentBO()
                {
                    StudentID = st.StudentID,
                    StudentName = st.StudentName,
                    EmailID = st.EmailID,
                    Marks = (int)st.Marks
                };
                BOList.Add(sb);
            }
            return BOList;
        }
    }
}
