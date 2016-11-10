using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrader.Contracts
{
    class AsynchUrlTradeDataProvider : ITradeDataProvider
    {
        private readonly String url;
        UrlTradeDataProvider synchTradeProvider;
        static TradeDataUpdate tradeUpdater;
        public AsynchUrlTradeDataProvider(String url, TradeUpdater)
        {
            this.url = url;
            synchTradeProvider = new UrlTradeDataProvider(url);
        }
        public IEnumerable<string> GetTradeData()
        {
            //  Task.Run() => synchTradeProvider.GetTradeData();
            WebClient clint = new WebClient();
            Uri uri = new Uri(url);
            client.DownloadStringCompleted += DownloadString Completed;
            client.DownloadStringAsync(new Uri(url));
        }
        static void DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string[] lines = e.Result.Split(new string[] {Environment.NewLine}
               
        }
    }
}
