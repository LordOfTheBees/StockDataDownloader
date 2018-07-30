using System.Collections.Generic;

namespace StockDataDownloader.Enums
{
    public static class Market
    {
        public static List<Security> GetSecuritiesByMarket(MarketEnum market)
        {
            switch (market)
            {
                case MarketEnum.MosExchangeFutures:
                    return new List<Security>()
                    {
                        Security.SBRF_RTS
                    };

                default:
                    return null;
            }
        }
    }

    public enum MarketEnum
    {
        MosExchangeFutures = 14
    }
}