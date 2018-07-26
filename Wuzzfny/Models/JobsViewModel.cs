using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wuzzfny.Models
{
    public class JobsViewModel
    {
        public String JobTitle { get; set; }
        public IEnumerable<ApplyForJob> Items { get; set; }
    }
}