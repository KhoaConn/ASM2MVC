using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASM2MVC.EF
{
    public class MTrainerEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        public string TrainerName { get; set; }

        public string Type { get; set; }

        [Required(ErrorMessage = "Please enter Working Place")]
        public string WorkingPlace { get; set; }

        [Required(ErrorMessage = "Please enter Telephone")]
        public int Telephone { get; set; }

        [Required(ErrorMessage = "Please enter Email")]

        public string Email { get; set; }


        public string ToSeparatedString(string separator)
        {
            return $"{this.Id}{separator}" +
                $"{this.TrainerName}{separator}" +
                $"{this.Type}{separator}" +
                $"{this.WorkingPlace}{separator}" +
                $"{this.Telephone}{separator}" +
                $"{this.Email}";
        }
    }
}