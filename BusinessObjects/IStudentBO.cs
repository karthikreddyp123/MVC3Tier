using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public interface IStudentBO
    {
        int StudentID { get; set; }
        [Required(ErrorMessage = "User Name is Required")]
        [Display(Name = "Student Name")]
        String StudentName { get; set; }
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "EmailID is Required")]
        [EmailAddress(ErrorMessage = "Enter Valid Email Address.")]
        String EmailID { get; set; }
        [Display(Name = "Marks Obtained")]
        int Marks { get; set; }
    }
}
