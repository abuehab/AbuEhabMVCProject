using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbuEhabMVCProject.Models
{
   public class Actitvity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ActivityName { get; set; }
        [Required]
        public string ActivityType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public double CostPrice { get; set; }
        public  virtual Project ProjectId { get; set; }
    }
}