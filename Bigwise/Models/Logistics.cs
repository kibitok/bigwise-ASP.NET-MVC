using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bigwise.Models
{
    public class Logistics
    {
        [Required(ErrorMessage = "Please enter the name of the car")]

        public string CarNumber { get; set; }
        [Required(ErrorMessage = "Please enter the registration of the Car")]
        
        public string CarNumberPlate { get; set; }
        [Required(ErrorMessage = "Please enter drivers phone number")]
        public string DriverPhone { get; set; }
        [Required(ErrorMessage = "Please enter Destination Location")]
        public string Destinationlocation { get; set; }
       
    }
}