using System;
using System.Collections.Generic;
using System.Text;
using TrCrexDeneme.Core.Map;
using TrCrexDeneme.Model.Entities;

namespace TrCrexDeneme.Model.Maps
{
    public class OrderDetailMap : CoreMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable("dbo.OrderDetails");
            HasKey(x => new { x.OrderId, x.CurrencyId });
        }
    }
}
