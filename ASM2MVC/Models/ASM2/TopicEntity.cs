using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASM2MVC.EF
{
    public class TopicEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        public string TopicName { get; set; }

        [Required(ErrorMessage = "Please enter Description")]

        public string Description { get; set; }


        public string ToSeparatedString(string separator)
        {
            return $"{this.Id}{separator}" +
                $"{this.TopicName}{separator}" +
                $"{this.Description}";
        }
    }
}