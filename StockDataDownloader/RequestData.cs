using System;
using StockDataDownloader.Enums;

namespace StockDataDownloader
{
    public class RequestData
    {
        /// <summary>
        /// Номер рынка. Не имеет значения, какой поставить. На сервере у финама он не учитывается
        /// </summary>
        public MarketEnum Market { get; set; }

        /// <summary>
        /// Номер инструмента
        /// </summary>
        public Security Security { get; set; }

        /// <summary>
        /// Непонятно зачем, но стоит 0
        /// </summary>
        public int Apply { get; set; }

        /// <summary>
        /// Начальная дата
        /// </summary>
        public DateTime From { get; set; }

        /// <summary>
        /// Конечная дата
        /// </summary>
        public DateTime To { get; set; }

        /// <summary>
        /// Таймфрейм
        /// </summary>
        public TimeFrame TimeFrame { get; set; }

        /// <summary>
        /// Формат даты
        /// </summary>
        public DateFormat DateFormat { get; set; }

        /// <summary>
        /// формат файла, который будет загружен
        /// </summary>
        public string FileFormat { get; set; }

        /// <summary>
        /// ФОрмат времени
        /// </summary>
        public TimeFormat TimeFormat { get; set; }

        /// <summary>
        /// Время свечи (0 - open; 1 - close)
        /// </summary>
        public int MSOR { get; set; }

        /// <summary>
        /// Московское время
        /// </summary>
        public string MsTime { get; set; }

        /// <summary>
        /// Коррекция часового пояса
        /// </summary>
        public int MsTimever { get; set; }

        /// <summary>
        /// Разделитель полей
        /// </summary>
        public int Sep { get; set; }

        /// <summary>
        /// Разделитель разрядов
        /// </summary>
        public int Sep2 { get; set; }

        /// <summary>
        /// Формат записи в файл
        /// </summary>
        public int Datf { get; set; }

        /// <summary>
        /// Нужны ли заголовки столбцов
        /// </summary>
        public int At { get; set; }

        public RequestData() { }

        /// <summary>
        /// Загружает данные с биржи
        /// </summary>
        /// <param name="market">Номер рынка. Не имеет значения, какой поставить. На сервере у финама он не учитывается</param>
        /// <param name="security">Номер инструмента</param>
        /// <param name="from">Начальная дата</param>
        /// <param name="to">Конечная дата(Включительно)</param>
        /// <param name="timeFrame">Таймфрейм</param>
        /// <param name="dateFormat">Формат даты</param>
        /// <param name="timeFormat">Формат времени</param>
        /// <param name="msor">Время свечи (0 - open; 1 - close)</param>
        /// <param name="mstime">Московское время</param>
        /// <param name="mstimever">Коррекция часового пояса</param>
        /// <param name="sep">Разделитель полей</param>
        /// <param name="sep2">Разделитель разрядов</param>
        /// <param name="datf">Формат записи в файл</param>
        /// <param name="at">Нужны ли заголовки столбцов</param>
        public RequestData(MarketEnum market, Security security, DateTime from, DateTime to,
            TimeFrame timeFrame = TimeFrame.Ticks, DateFormat dateFormat = DateFormat.GGGGMMDD,
            TimeFormat timeFormat = TimeFormat.HHMMSS, int msor = 1, string mstime = "on", int mstimever = 1,
            int sep = 3, int sep2 = 1, int datf = 11, int at = 0, string fileFormat=".txt", int apply = 0)
        {
            Market = market;
            Security = security;
            From = from;
            To = to;
            TimeFrame = timeFrame;
            DateFormat = dateFormat;
            TimeFormat = timeFormat;
            MSOR = msor;
            MsTime = mstime;
            MsTimever = mstimever;
            Sep = sep;
            Sep2 = sep2;
            Datf = datf;
            At = at;

            FileFormat = fileFormat;
            Apply = apply;
        }

        public string GetRequestUrl(DateTime from, DateTime to)
        {
            return
                $@"http://export.finam.ru/{Security.ToString().Replace('_', '.')}.txt?market={(int) Market
                    }&em={(int) Security
                    }&code={Security.ToString()
                    }&apply={Apply
                    }&df={from.Day
                    }&mf={from.Month - 1
                    }&yf={from.Year
                    }&from={from.ToShortDateString()
                    }&dt={to.Day
                    }&mt={to.Month - 1
                    }&yt={to.Year
                    }&to={to.ToShortDateString()
                    }&p={(int) TimeFrame
                    }&f={$"{Security.ToString()}_{from.Ticks}_{to.Ticks}"
                    }&e={FileFormat
                    }&cn={Security.ToString().Replace('_', '.')
                    }&dtf={(int) DateFormat
                    }&tmf={(int) TimeFormat
                    }&MSOR={MSOR
                    }&mstime={MsTime
                    }&mstimever={MsTimever
                    }&sep={Sep
                    }&sep2={Sep2
                    }&datf={Datf
                    }&at={At}";
        }
    }
}