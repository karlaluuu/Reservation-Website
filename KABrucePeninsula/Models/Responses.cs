using System;
using System.ComponentModel.DataAnnotations;
namespace KABrucePeninsula.Models
{
    public class Responses
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please confirm your attendance")]
        public bool? WillAttend { get; set; }
        public String DateSelection { get; set; }
        public String currentTime
        {
            get
            {
                return DateTime.Now.ToString("h:mm:ss tt");
            }
            set => this.currentTime = currentTime;
        }
    }
}
