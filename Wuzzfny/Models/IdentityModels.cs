﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace Wuzzfny.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string  UserType{ get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Wuzzfny.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<Wuzzfny.Models.Job> Jobs { get; set; }
    }
}