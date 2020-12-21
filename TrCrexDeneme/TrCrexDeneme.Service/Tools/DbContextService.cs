//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using TrCrexDeneme.Model.Context;

//namespace TrCrexDeneme.Service.Tools
//{
//   static class DbContextService
//    {
//        public static IServiceCollection AddDbContextService(this IServiceCollection services)
//        {
//            ServiceProvider provider = services.BuildServiceProvider();
//            IConfiguration configuration = provider.GetService<IConfiguration>();

//            services.AddDbContext<ProjectContext>(x => x.UseSqlServer("server=desktop-3vcbfaj;database=trcrex;trusted_connection=true"));
//            return services;
//        }
//    }

//}
