using Alpaca.Markets;
using System;

namespace Stock_Learning_App.API
{
    public class AccountAPI : IAPI
    {
        private static Alpaca.Markets.IAccount account;

        public AccountAPI()
        {
            accessAccount();
        }

        private static void accessAccount()
        {
            account = IAPI.tradingClient.GetAccountAsync().Result;
        }

        public Guid getAccountId()
        {
            return account.AccountId;
        }

        public string getAccountNumber()
        {
            return account.AccountNumber;
        }

        public decimal getBuyingPower()
        {
            return account.BuyingPower;
        }

        public DateTime getCreatedAtUtc()
        {
            return account.CreatedAtUtc;
        }

        public string getCurrency()
        {
            return account.Currency;
        }

        public long getDayTradeAccount()
        {
            return account.DayTradeCount;
        }

        public decimal getDayTradingBuyingPower()
        {
            return account.DayTradingBuyingPower;
        }

        public decimal getInitialMargin()
        {
            return account.InitialMargin;
        }

        public bool isAccountBlocked()
        {
            return account.IsAccountBlocked;
        }

        public bool isDayPatternTrader()
        {
            return account.IsDayPatternTrader;
        }

        public bool isTradingBlocked()
        {
            return account.IsTradingBlocked;
        }

        public bool isTransfersBlocked()
        {
            return account.IsTransfersBlocked;
        }

        public decimal getLastEquity()
        {
            return account.LastEquity;
        }

        public decimal getLastMaintenanceMargin()
        {
            return account.LastMaintenanceMargin;
        }

        public decimal getLongMarketValue()
        {
            return account.LongMarketValue;
        }

        public decimal getMaintenanceMargin()
        {
            return account.MaintenanceMargin;
        }

        public long getMultiplier()
        {
            return account.Multiplier;
        }

        public decimal getRegulationBuyingPower()
        {
            return account.RegulationBuyingPower;
        }

        public bool isShortingEnabled()
        {
            return account.ShortingEnabled;
        }

        public decimal isShortMarketValue()
        {
            return account.ShortMarketValue;
        }

        public decimal getSma()
        {
            return account.Sma;
        }

        public AccountStatus getStatus()
        {
            return account.Status;
        }

        public decimal getTradeableCash()
        {
            return account.TradableCash;
        }

        public bool isTradeSuspendedByUser()
        {
            return account.TradeSuspendedByUser;
        }

        public decimal getWithdrawableCash()
        {
            return account.WithdrawableCash;
        }
    }
}
