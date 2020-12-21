using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrCrexDeneme.WebUII.Models;

namespace TrCrexDeneme.WebUII.Heplers
{
    public class WalletHelper
    {
        private Dictionary<int, WalletItem> _wallet = null;
        public WalletHelper()
        {
            _wallet = new Dictionary<int, WalletItem>();
        }
        List<WalletItem> WalletList { get => _wallet.Values.ToList(); }

        public void RemoveWallet(int id)
        {
            _wallet.Remove(id);
        }
        public void IncreaseWallet(int id)
        {
            _wallet[id].Amount += 1;
        }
        public void DecreaseWallet(int id)
        {
            _wallet[id].Amount -= 1;
            if (_wallet[id].Amount<=0)
            {
                RemoveWallet(id);
            }
        }


        public void AddToWallet(WalletItem item)
        {
            if (item.Amount==0)
            {
                RemoveWallet(item.Id);
                return;
            }
        }
    }
}
