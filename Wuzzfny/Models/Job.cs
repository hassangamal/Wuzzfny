using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
namespace Wuzzfny.Models
{
    public class Job
    {
        public int Id { get; set; }
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }
        [DisplayName("Job Desciption")]
        public string JobContent { get; set; }
        [DisplayName("Job Image")]
        public string JobImage { get; set; }
        public string UserId { get; set; }
        [DisplayName("Job Tybe")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}