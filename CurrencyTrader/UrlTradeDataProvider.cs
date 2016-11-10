﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

using CurrencyTrader.Contracts;

namespace CurrencyTrader
{
    public class UrlTradeDataProvider : ITradeDataProvider
    {
        private readonly String url;
      
 

        public IEnumerable<string> GetTradeData()
        {
            var tradeData = new List<String>();
            var client = new WebClient();
            using (var stream = client.OpenRead(url))
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    tradeData.Add(line);
                }
            }
            return tradeData;
        }


    }
}
