using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TrCrexDeneme.Model.Context
{
    //public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<ProjectContext>
    //{
    //    public ProjectContext CreateDbContext(string[] args)
    //    {
    //        DbContextOptionsBuilder<ProjectContext> builder = new DbContextOptionsBuilder<ProjectContext>();
    //        IConfiguration config = new ConfigurationBuilder().SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TrCrex")).AddJsonFile("appsettings.json").Build();
    //        builder.UseSqlServer(config.GetConnectionString("SQLProvider"));
    //        return new ProjectContext(builder.Options);
    //    }
    //}
}
