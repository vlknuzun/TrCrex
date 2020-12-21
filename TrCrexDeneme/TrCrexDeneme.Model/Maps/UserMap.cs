using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using TrCrexDeneme.Core.Map;
using TrCrexDeneme.Model.Entities;

namespace TrCrexDeneme.Model.Maps
{
   public class UserMap:CoreMap<User>
    {
        public UserMap()
        {
            ToTable("dbo.Users");
            Property(x => x.Name).IsRequired().HasMaxLength(25);
            Property(x => x.Surname).IsRequired().HasMaxLength(20);
            Property(x => x.UserName).IsRequired().HasMaxLength(20);
            HasIndex(x => x.UserName).IsUnique();
            Property(x => x.Password).IsRequired().HasMaxLength(20);
            Property(x => x.Email).IsRequired().HasMaxLength(150);
            HasIndex(x => x.Email).IsUnique();
            Property(x => x.BirthDate).IsRequired().HasColumnType("datetime");
            Property(x => x.Role).IsOptional();
        }

        
    }
}
