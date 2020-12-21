using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TrCrexDeneme.Core.Map;
using TrCrexDeneme.Model.Entities;

namespace TrCrexDeneme.Model.Maps
{
   public class CurrencyMap:CoreMap<Currency>
    {
        public CurrencyMap()
        {
            ToTable("dbo.Currencies");
            Property(x => x.Name).IsRequired().HasMaxLength(20);
            Property(x => x.Price).IsRequired().HasColumnType("decimal");
            Property(x => x.Amount).IsRequired().HasColumnType("short");
        }
    }
}
