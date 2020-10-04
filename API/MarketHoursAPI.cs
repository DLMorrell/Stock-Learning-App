using Alpaca.Markets;
using System;

namespace Stock_Learning_App.API
{
    public class MarketHoursAPI : IAPI
    {
        private static IClock marketHours;

        public MarketHoursAPI()
        {
            accessMarketHours();
        }

        private static async void accessMarketHours()
        {
            marketHours = await IAPI.tradingClient.GetClockAsync();
        }

        public bool isMarketOpen()
        {
            return marketHours.IsOpen;
        }

        public DateTime nextCloseUtc()
        {
            return marketHours.NextCloseUtc;
        }

        public DateTime nextOpenUtc()
        {
            return marketHours.NextOpenUtc;
        }

        public DateTime nextTimestampUtc()
        {
            return marketHours.TimestampUtc;
        }
    }
}
