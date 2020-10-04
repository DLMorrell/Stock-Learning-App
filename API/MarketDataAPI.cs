using Alpaca.Markets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock_Learning_App.API
{
    public class MarketDataAPI : IAPI
    {
        private static async Task<IReadOnlyDictionary<string, IReadOnlyList<IAgg>>> AccessMarketData(string stockCode, int limit)
        {
            return await IAPI.dataClient.GetBarSetAsync(
              new BarSetRequest(stockCode, TimeFrame.Day) { Limit = limit });
        }

        public List<decimal> getStockPriceOverTimeFrame(string stockCode, int limit)
        {
            IReadOnlyDictionary<string, IReadOnlyList<IAgg>> marketData = AccessMarketData(stockCode, limit).Result;

            List<decimal> prices = new List<decimal>();
            foreach (IAgg price in marketData[stockCode])
            {
                prices.Add(price.Close);
            }
            return prices;
        }
    }
}
