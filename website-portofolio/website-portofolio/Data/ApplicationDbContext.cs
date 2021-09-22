using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using website_portofolio.Models;

namespace website_portofolio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CVData> CVData { get; set; }

        public DbSet<ContactData> ContactData { get; set; }

        public DbSet<Login> Logins { get; set; }

    }
}
