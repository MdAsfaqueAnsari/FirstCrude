using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstCrude.Models
{
    public class Class1
    {

        
        public int sid { get; set; }

        [Required(ErrorMessage = "Enter Your Nmae")]
        public string sname { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "Enter Your Email")]
        public string smail { get; set; }


        [Required(ErrorMessage = "Enter Your Mobile No")]
        public int smob { get; set; }


        [Required(ErrorMessage = "Enter Your City ")]
        public string city { get; set; }
        
    }
}