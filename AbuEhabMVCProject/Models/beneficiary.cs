using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbuEhabMVCProject.Models
{

    // المستفيدون 
    public class Beneficiary 
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string beneficiaryName { get; set; }
        [Required]
        public string Address { get; set; }

        public string  Phone { get; set; }
       
        public   virtual  Project ProjectId  { get; set; }


    }
}