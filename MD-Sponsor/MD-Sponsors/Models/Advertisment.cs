using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MD_Sponsors.Models
{
    public class Advertisment
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a Name for your advertisment")]
        [Display(Name = "Name")]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Please enter your endorsment for this product")]
        [Display(Name = "Personal Endorsment")]
        public string  Endorsment { get; set; }
        [Required(ErrorMessage = "Please enter your personal referal code for this product")]
        [Display(Name = "MY REFERRAL CODE!")]
        public string ReferralCode { get; set; }
        [Required(ErrorMessage = "please upload an image to use for this product")]
        public string Image { get; set; }
        [Required(ErrorMessage = "please upload a link to the product")]
        public string LinkToProduct { get; set; }

    }
}
