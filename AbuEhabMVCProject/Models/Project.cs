using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbuEhabMVCProject.Models
{
    public class Project
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime  FinishDate { get; set; }
        public double  CostPrice { get; set; }
        public virtual User  UserId { get; set; }


    }
}