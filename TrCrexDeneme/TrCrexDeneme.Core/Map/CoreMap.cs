using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TrCrexDeneme.Core.Entity;

namespace TrCrexDeneme.Core.Map
{
    public class CoreMap<T>: EntityTypeConfiguration<T> where T:CoreEntity
    {
        public CoreMap()
        {
            Property(x => x.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
