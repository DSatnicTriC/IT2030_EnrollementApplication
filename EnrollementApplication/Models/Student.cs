using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Win32.SafeHandles;

namespace EnrollementApplication.Models
{
    public class Student
    {
        public virtual int Id { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(50)]
        public virtual string LastName { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(50)]
        public virtual string FirstName { get; set; }
    }
}