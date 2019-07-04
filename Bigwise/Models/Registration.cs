using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Bigwise.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Please enter your name")]

        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]
        public string CustomerEmail { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string CustomerPhone { get; set; }
        [Required(ErrorMessage = "Please enter your Location")]
        public string Customerlocation { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll Subscribe")]
        public bool? WillSubscribeCustomer { get; set; }
    }
}
