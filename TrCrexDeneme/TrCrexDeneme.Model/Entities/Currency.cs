using System;
using System.Collections.Generic;
using System.Text;
using TrCrexDeneme.Core.Entity;

namespace TrCrexDeneme.Model.Entities
{
    public class Currency:CoreEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Amount { get; set; }
        public List<OrderDetail> OrderDetails{ get; set; }
    }
}
