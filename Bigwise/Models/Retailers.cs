using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bigwise.Models
{
    public class Retailers
    {
        [Required(ErrorMessage = "Please enter your name")]

        public string RetailersName { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
ErrorMessage = "Please enter a valid email address")]
        public string RetailersEmail { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string RetailersPhone { get; set; }
        [Required(ErrorMessage = "Please enter your Location")]
        public string Retailerslocation { get; set; }
       
    }
}