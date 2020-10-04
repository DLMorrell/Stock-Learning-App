using Alpaca.Markets;
using System.Collections.Generic;
using System.Linq;

namespace Stock_Learning_App.API
{
    public class AssestsAPI : IAPI
    {
        private static IReadOnlyList<Alpaca.Markets.IAsset> assets;

        public AssestsAPI()
        {
            accessAssests();
        }

        private static async void accessAssests()
        {
            assets = await IAPI.tradingClient.ListAssetsAsync(
                new AssetsRequest { AssetStatus = AssetStatus.Active });
        }

        public IReadOnlyList<Alpaca.Markets.IAsset> getAssets()
        {
            return assets;
        }

        public IEnumerable<Alpaca.Markets.IAsset> getAssetsOnNASDAQ()
        {
            return assets.Where(asset => asset.Exchange == Exchange.NyseMkt);
        }
    }
}
