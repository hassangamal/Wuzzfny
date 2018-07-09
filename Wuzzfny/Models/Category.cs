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
        [Display(Name="Category Type")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name="Job Discription")]
        public string CategoryDescription { get; set; }
        public virtual ICollection<Job>Jobs { get; set; }
       
    }
} 