using System;
using System.Collections.Generic;
using System.Text;
using TrCrexDeneme.Core.Map;
using TrCrexDeneme.Model.Entities;

namespace TrCrexDeneme.Model.Maps
{
    public class OrderMap:CoreMap<Order>
    {
        public OrderMap()
        {
            ToTable("dbo.Orders");
            HasRequired(o => o.Users).
                WithMany(a => a.Orders).
                HasForeignKey(o => o.UserId).
                WillCascadeOnDelete(false);

        }
    }
}
