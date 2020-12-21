using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;
using TrCrexDeneme.Core.Entity;

namespace TrCrexDeneme.Model.Entities
{
    public class OrderDetail:CoreEntity
    {
        public int CurrencyId { get; set; }
        public int OrderId { get; set; }
        public decimal Price { get; set; }
        public short Amount { get; set; }
        public Currency Currencies { get; set; }
        public Order Orders { get; set; }
    }
}
