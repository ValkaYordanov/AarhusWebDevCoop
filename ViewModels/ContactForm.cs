using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AarhusWebDevCoop.ViewModels
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Plase enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Plase enter your email address")]
        [Display(Name = "Email")]
       // [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@([a-zA-Z0-9\-])+([a-zA-Z0-9]{2,4})+$",ErrorMessage ="please enter correct email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Plase enter a subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Plase enter a message")]
        public string Message { get; set; }
    }
}