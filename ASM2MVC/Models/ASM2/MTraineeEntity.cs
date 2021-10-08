using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASM2MVC.EF
{
    public class MTraineeEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        public string TraineeName { get; set; }

        [Required(ErrorMessage = "Please enter UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter DOB")]
        public string DOB { get; set; }

        [Required(ErrorMessage = "Please enter Main programming language")]

        public string Mainlanguage { get; set; }

        [Required(ErrorMessage = "Please enter TOEIC score")]
        public int TOEICScore { get; set; }

        [Required(ErrorMessage = "Please enter Department")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Please enter Location")]
        public string Location { get; set; }



        public string ToSeparatedString(string separator)
        {
            return $"{this.Id}{separator}" +
                $"{this.TraineeName}{separator}" +
                $"{this.UserName}{separator}" +
                $"{this.Age}{separator}" +
                $"{this.DOB}{separator}" +
                $"{this.Mainlanguage}{separator}" +
                $"{this.TOEICScore}{separator}" +
                $"{this.Department}{separator}" +
                $"{this.Location}";
        }
    }
}