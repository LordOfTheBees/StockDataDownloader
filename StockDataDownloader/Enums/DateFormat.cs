namespace StockDataDownloader.Enums
{
    /// <summary>
    /// g - год | m - месяц | d - день | _ : /
    /// </summary>
    public enum DateFormat
    {
        GGGGMMDD = 1,
        GGMMDD = 2,
        DDMMGG = 3,
        DD_MM_GG = 4,
        MM_MM_GG = 5
    }
}