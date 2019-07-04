using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bigwise.Models
{
    public class Goods
    {
        [Required(ErrorMessage = "Please enter your name")]

        public string GoodsName { get; set; }
        [Required(ErrorMessage = "Please enter Goods Price")]
       
        public string GoodsPrice { get; set; }
        [Required(ErrorMessage = "Please enter the number of Goods")]
        public string GoodsNumber { get; set; }
        [Required(ErrorMessage = "Please enter Location of Goods")]
        public string Goodslocation { get; set; }
       
    }
}