using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using TrCrexDeneme.Model.Entities;

namespace TrCrexDeneme.Model.Context
{
    public class ProjectContext : DbContext
    {
        

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }
      
        public DbSet<User> Users { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
