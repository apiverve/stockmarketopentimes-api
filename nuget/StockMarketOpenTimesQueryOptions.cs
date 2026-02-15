using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.StockMarketOpenTimes
{
    /// <summary>
    /// Query options for the Stock Market Open Times API
    /// </summary>
    public class StockMarketOpenTimesQueryOptions
    {
        /// <summary>
        /// The stock exchange code
        /// </summary>
        [JsonProperty("exchange")]
        public string Exchange { get; set; }
    }
}
