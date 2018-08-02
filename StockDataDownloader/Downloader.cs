using System;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockDataDownloader.Enums;

namespace StockDataDownloader
{
    public class Downloader
    {
        private Regex checkFormatter = new Regex(@"[\d]*/?[\d]*/?[\d]*;[\d]*:?[\d]*:?[\d]*;[\d]*\.[\d]*;[\d]*;[\d]*");
        private readonly TimeSpan Day1 = new TimeSpan(1, 0, 0, 0);
        private readonly TimeSpan Day10 = new TimeSpan(10, 0, 0, 0);
        private DateTime from;
        private DateTime to;
        private DateTime lastDateTime;
        private bool isStart;

        private RequestData requestData;

        public event EventHandler<ProgressEvent> ProgressUpdate;
        public event EventHandler<StatusEvent> StatusUpdate;

        public bool UseEvents { get; set; } = true;

        /// <summary>
        /// Загружает данные с биржи
        /// </summary>
        public async Task LoadDataAsync(RequestData requestData, string fileName)
        {
            this.requestData = requestData;

            int lineCounter = 0;
            string line, lastLine = null;
            string lastLineInFile = null;
            bool SizeExceeded = false;
            isStart = true;
            var fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamWriter file = new StreamWriter(fileStream);
            HttpClient client = new HttpClient() { Timeout = new TimeSpan(0, 10, 0) };

            int maxProgress = ConvertDateTimeToInt(requestData.To) - ConvertDateTimeToInt(requestData.From);

            lastDateTime = new DateTime(requestData.From.Ticks);
            SetNextDate();

            while (from.Ticks <= requestData.To.Ticks)
            {
                lineCounter = 0;
                lastLine = null;

                try
                {
                    if (UseEvents) StatusUpdate?.Invoke(this,
                        new StatusEvent(
                            $"Пакет данных загружается... {from.ToShortDateString()} - {to.ToShortDateString()}"));
                    var response = await client.GetAsync(requestData.GetRequestUrl(from, to));

                    using (var stream = new StreamReader(await response.Content.ReadAsStreamAsync()))
                    {
                        if (UseEvents) StatusUpdate?.Invoke(this, new StatusEvent("Пакет данных сохраняется в файл"));
                        while (!string.IsNullOrEmpty(line = stream.ReadLine()))
                        {
                            if (!checkFormatter.IsMatch(line)) continue;

                            if (SizeExceeded)
                            {
                                //читаем строчки в потоке до тех пор, пока не попадётся последняя записанная в файл
                                if (line == lastLineInFile)
                                    SizeExceeded = false;
                                continue;
                            }

                            lineCounter++;
                            lastLine = line;
                            lastLineInFile = line;
                            file.WriteLine(line);
                        }
                    }
                }
                catch (Exception e)
                {
                    if (UseEvents) StatusUpdate?.Invoke(this, new StatusEvent("Произошла ошибка!"));
                    MessageBox.Show($"{e.Message}\n\n{e.StackTrace}", "Error");
                }

                if (!string.IsNullOrEmpty(lastLine)) lastLineInFile = lastLine;


                SizeExceeded = lineCounter >= 990000; //Около миллиона

                if (lastLine == null) //Случаи выходных или праздничных дней
                    lastDateTime = new DateTime(to.Ticks + Day1.Ticks);
                else if (SizeExceeded) //Случай, когда особый ажиотаж на рынке
                    lastDateTime = GetDateTime(lastLine.Split(';')[0]);
                else
                    lastDateTime = new DateTime(to.Ticks + Day1.Ticks);


                if (UseEvents) ProgressUpdate?.Invoke(this,
                    new ProgressEvent()
                    {
                        MaxProgress = maxProgress,
                        CurrentProgress = ConvertDateTimeToInt(to) - ConvertDateTimeToInt(requestData.From),
                        IsFinished = false
                    });

                SetNextDate();
            }

            file.Close();

            if (UseEvents) ProgressUpdate?.Invoke(this, new ProgressEvent() { MaxProgress = 100, CurrentProgress = 100, IsFinished = true });
            if (UseEvents) StatusUpdate?.Invoke(this, new StatusEvent("Процесс загрузки данных закончен"));
        }

        private void SetNextDate()
        {
            //Существует ограничение на скачивание в этом промежутке
            var functionalityIsLimited = DateTime.Now.Hour >= 10 && DateTime.Now.Hour < 18;

            from = new DateTime(lastDateTime.Ticks);
            if (functionalityIsLimited)
                to = new DateTime(from.Ticks + Day1.Ticks);
            else
                to = new DateTime(from.Ticks + Day10.Ticks);

            to = to.Ticks > requestData.To.Ticks ? requestData.To : to;
        }

        private DateTime GetDateTime(string dateString)
        {
            int year = Convert.ToInt32(dateString.Substring(0, 4));
            int month = Convert.ToInt32(dateString.Substring(4, 2));
            int day = Convert.ToInt32(dateString.Substring(6));
            return new DateTime(year, month, day);
        }

        private int ConvertDateTimeToInt(DateTime dateTime)
        {
            return dateTime.Day + (dateTime.Month - 1) * 32 + (dateTime.Year - 1500) * 500;
        }
    }

    public class ProgressEvent
    {
        public int CurrentProgress { get; set; }
        public int MaxProgress { get; set; }
        public bool IsFinished { get; set; }
    }

    public class StatusEvent
    {
        public string StatusString { get; set; }

        public StatusEvent() { }

        public StatusEvent(string statusString)
        {
            StatusString = statusString;
        }
    }
}