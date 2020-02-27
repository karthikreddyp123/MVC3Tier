using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class StudentBO:IStudentBO
    {
        //Setting Model properties
        public int StudentID { get; set; }
        [Required(ErrorMessage ="User Name is Required")]
        [Display(Name ="Student Name")]
        public String StudentName { get; set; }
        [Display(Name ="EmailID")]
        [Required(ErrorMessage ="EmailID is Required")]
        [EmailAddress(ErrorMessage ="Enter Valid Email Address.")]
        public String EmailID { get; set; }
        [Display(Name ="Marks")]
        public int Marks { get; set; }
    }
}
