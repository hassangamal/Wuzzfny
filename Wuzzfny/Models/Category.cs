using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Wuzzfny.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Job Type")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name="Job Discripe")]
        public string CategoryDescription { get; set; }
        public ICollection<Job>Jobs { get; set; }
       
    }
} 