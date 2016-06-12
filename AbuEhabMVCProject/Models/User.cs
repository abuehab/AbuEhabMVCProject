using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbuEhabMVCProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required ]
        public string UserName{ get; set; }
        [Required ]
        public string UserPassword { get; set; }
        public  Project x { get; set; }
    }
}