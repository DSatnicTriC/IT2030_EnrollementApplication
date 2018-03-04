using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollementApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        
        [Required]
        [RegularExpression(@"[A-Fa-f]")]
        public virtual char Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public virtual bool IsActive { get; set; }

        [Display(Name = "Assigned Campus")]
        [Required]
        public virtual string AssignedCampus { get; set; }

        [Display(Name = "Enrolled in Semester")]
        [Required]
        public virtual string EnrollmentSemester { get; set; }
        
        [Required]
        [Range(2018, int.MaxValue)]
        public virtual int EnrollmentYear { get; set; }
    }
}