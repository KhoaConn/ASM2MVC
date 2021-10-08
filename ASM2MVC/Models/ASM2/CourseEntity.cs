using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASM2MVC.EF
{
    public class CourseEntity
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter Name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Please enter Course Category")]
        public string CourseCategory { get; set; }

        [Required(ErrorMessage = "Please enter Description")]

        public string Description { get; set; }



        public string ToSeparatedString(string separator)
        {
            return $"{this.Id}{separator}" +
                $"{this.CourseName}{separator}" +
                $"{this.CourseCategory}{separator}" +
                $"{this.Description}";
        }
    }
}