using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrader
{
    class AsynchUrlTradeDataProvider : ITradeDataProvider
    {
        private readonly String url;
        UrlTradeDataProvider synchTradeProvider;
        public AsynchUrlTradeDataProvider(String url)
        {
            this.url = url;
            synchTradeProvider = new UrlTradeDataProvider(url);
        }
        public IEnumerable<string> GetTradeData()
        {
            Task.Run() => synchTradeProvider.GetTradeData();
        }
    }
}
