using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
namespace DataAccess
{
    public class StudentsDAL:IStudentDAL
    {
        private readonly ICustomMessage _customMessage;
        private StudentEntities studentsEntities;
        public StudentsDAL(ICustomMessage customMessage)
        {
            studentsEntities = new StudentEntities();
            _customMessage = customMessage;
        }
        /// <summary>
        /// This method adds a new student to the database
        /// </summary>
        /// <param name="studentBO"></param>
        /// <returns>ICustomMessage</returns>
        public ICustomMessage AddStudent(IStudentBO studentBO)
        {
            try
            {
                Student studentTable = new Student()
                {
                    StudentName = studentBO.StudentName,
                    EmailID = studentBO.EmailID,
                    Marks = studentBO.Marks
                };
                studentsEntities.Students.Add(studentTable);//Adding data to table
                int returnValue = studentsEntities.SaveChanges();
                if (returnValue > 0)
                {
                    _customMessage.MessageNumber = returnValue;
                    _customMessage.Message = "Student Added Susscessfully.";
                }
                else
                {
                    _customMessage.MessageNumber = returnValue;
                    _customMessage.Message = "Cannot Add Student.";
                }
            }
            catch (Exception e)
            {

            }
            return _customMessage;
            
        }
        /// <summary>
        /// This method retrieves data from the database
        /// </summary>
        /// <returns>List<StudentBO></returns>
        public List<StudentBO> GetStudents()
        {
            List<Student> list = studentsEntities.Students.ToList<Student>();
            List<StudentBO> BOList = new List<StudentBO>();
            try
            { 
                foreach (Student st in list)
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
            }
            catch(Exception e)
            {

            }
            return BOList;
        }
    }
}
