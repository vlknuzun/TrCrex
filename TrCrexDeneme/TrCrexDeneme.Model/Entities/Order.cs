using System;
using System.Collections.Generic;
using System.Text;
using TrCrexDeneme.Core.Entity;

namespace TrCrexDeneme.Model.Entities
{
    public class Order:CoreEntity
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public decimal SellPrice { get; set; }
        public decimal BuyPrice { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        
    }
}
