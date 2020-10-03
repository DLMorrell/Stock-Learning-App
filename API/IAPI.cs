using Alpaca.Markets;

namespace Stock_Learning_App.API
{
    public interface IAPI
    {
        private static string API_KEY = "PK5DR4H954FS22OYHSYI";

        private static string API_SECRET = "dqb1jqWgnOuXP34CoixMqRD830rnl85atHX9xy2m";

        static IAlpacaTradingClient tradingClient = Alpaca.Markets.Environments.Paper.GetAlpacaTradingClient(new SecretKey(API_KEY, API_SECRET));

        static IAlpacaDataClient dataClient = Alpaca.Markets.Environments.Paper.GetAlpacaDataClient(new SecretKey(API_KEY, API_SECRET));
    }
}
