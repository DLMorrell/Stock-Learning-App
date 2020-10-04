using Alpaca.Markets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock_Learning_App.API
{
    public class PortfolioAPI : IAPI
    {
        public static async Task<IReadOnlyList<IPosition>> accessPositions()
        {
            return await IAPI.tradingClient.ListPositionsAsync();
        }
    }
}
