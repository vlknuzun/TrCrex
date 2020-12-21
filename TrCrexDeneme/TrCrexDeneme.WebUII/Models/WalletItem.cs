using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrCrexDeneme.Core.Entity;

namespace TrCrexDeneme.WebUII.Models
{
    public class WalletItem : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Amount { get; set; }
        public decimal SubTotal { get { return Price * Amount; } }
    }
}
