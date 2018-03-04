using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollementApplication.Models
{
    public class Course
    {
        public virtual int Id { get; set; }

        [Display(Name = "Course Title")]
        [Required]
        [StringLength(150)]
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }

        [Display(Name = "Number of credits")]
        [Required]
        [Range(1,4)]
        public virtual int Credits { get; set; }
    }
}