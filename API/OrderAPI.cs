using Alpaca.Markets;

namespace Stock_Learning_App.API
{
    public class OrderAPI : IAPI
    {
        public static async void purchaseStockAtMarketPrice(string stockCode, int quantity, TimeInForce timeInForce)
        {
            await IAPI.tradingClient.PostOrderAsync(new NewOrderRequest(stockCode, quantity, OrderSide.Buy, OrderType.Market, timeInForce));
        }

        public static async void purchaseStockAtLimitPrice(string stockCode, int quantity, TimeInForce timeInForce, decimal price)
        {
            await IAPI.tradingClient.PostOrderAsync(new NewOrderRequest(stockCode, quantity, OrderSide.Buy, OrderType.Limit, timeInForce)
            {
                LimitPrice = price
            });
        }

        public static async void sellStockAtMarketPrice(string stockCode, int quantity, TimeInForce timeInForce)
        {
            await IAPI.tradingClient.PostOrderAsync(new NewOrderRequest(stockCode, quantity, OrderSide.Sell, OrderType.Market, timeInForce));
        }

        public static async void sellStockAtLimitPrice(string stockCode, int quantity, TimeInForce timeInForce, decimal price)
        {
            await IAPI.tradingClient.PostOrderAsync(new NewOrderRequest(stockCode, quantity, OrderSide.Sell, OrderType.Limit, timeInForce)
            {
                LimitPrice = price
            });
        }
    }
}
