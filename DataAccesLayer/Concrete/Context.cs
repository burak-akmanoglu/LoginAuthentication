using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccesLayer.Concrete
{
    public class Context:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BURAK;database=LoginAuthentication;integrated security=true");
        }
        public DbSet<User> Users { get; set; }
    }
}
