using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrader.Contracts
{
    class TradeDataUpdate
    {
        ListBox.ObjectCollection tradeItems;
        public TradeDataUpdate(ListBox.ObjectCollection items)
        {
            this.tradeItems = items;
        }
        public void UpdateTradeData(IEnumerable<string>)
    }
}
