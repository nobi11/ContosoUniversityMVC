using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversityMVC.Models
{
    public class Student : Person
    {
        //public int ID { get; set; }

        //[Required]
        //[DisplayName("Last Name")]
        //[StringLength(50)]
        //public string LastName { get; set; }

        //[Required]
        //[DisplayName("First Name")]
        //[StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        //public string FirstMidName { get; set; }

        [DisplayName("Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        //[Display(Name = "Full Name")]
        //public string FullName
        //{
        //    get
        //    {
        //        return LastName + ", " + FirstMidName;
        //    }
        //}

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
