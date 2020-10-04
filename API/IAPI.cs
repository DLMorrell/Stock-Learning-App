using Alpaca.Markets;
using System.Configuration;

namespace Stock_Learning_App.API
{
    public interface IAPI
    {
        private static readonly string API_KEY = ConfigurationManager.AppSettings["API_KEY"];

        private static readonly string API_SECRET = ConfigurationManager.AppSettings["API_SECRET"];

        static IAlpacaTradingClient tradingClient = Alpaca.Markets.Environments.Paper.GetAlpacaTradingClient(new SecretKey(API_KEY, API_SECRET));

        static IAlpacaDataClient dataClient = Alpaca.Markets.Environments.Paper.GetAlpacaDataClient(new SecretKey(API_KEY, API_SECRET));
    }
}