using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using StockDataDownloader.Enums;

namespace StockDataDownloader
{
    public class Downloader
    {
        private readonly TimeSpan Day1 = new TimeSpan(1, 0, 0, 0);
        private readonly TimeSpan Day10 = new TimeSpan(10, 0, 0, 0);
        private DateTime from;
        private DateTime to;
        private DateTime lastDateTime;
        private bool isStart;

        private RequestData requestData;

        public event EventHandler<ProgressEvent> ProgressUpdate; 

        /// <summary>
        /// Загружает данные с биржи
        /// </summary>
        public void LoadData(RequestData requestData, string fileName)
        {
            this.requestData = requestData;

            Task.Run(async () =>
            {
                int lineCounter;
                string line, lastLine = null;
                string lastLineInFile;
                bool functionalityIsLimited;
                bool SizeExceeded = false;
                isStart = true;
                var fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
                StreamWriter file = new StreamWriter(fileStream);
                HttpClient client = new HttpClient() { Timeout = new TimeSpan(0, 10, 0) };

                int maxProgress = FromDateToInt(requestData.To) - FromDateToInt(requestData.From);

                lastDateTime = new DateTime(requestData.From.Ticks);
                while (from.Ticks <= requestData.To.Ticks)
                {
                    SetNextDate();
                    var response = await client.GetAsync(requestData.GetRequestUrl(from, to));

                    using (var stream = new StreamReader(await response.Content.ReadAsStreamAsync()))
                    {

                        lineCounter = 0;
                        lastLineInFile = lastLine;
                        lastLine = null;
                        while (!string.IsNullOrEmpty(line = stream.ReadLine()))
                        {
                            if (SizeExceeded)
                            {
                                //читаем строчки в потоке до тех пор, пока не попадётся последняя записанная в файл
                                if (line == lastLineInFile)
                                    SizeExceeded = false;
                                continue;
                            }

                            lineCounter++;
                            lastLine = line;
                            file.WriteLine(line);
                        }
                    }

                    SizeExceeded = lineCounter >= 990000;//Около миллиона

                    if (lastLine == null)//Случаи выходных или праздничных дней
                        lastDateTime = new DateTime(to.Ticks + Day1.Ticks);
                    else if (SizeExceeded)//Случай, когда особый ажиотаж на рынке
                        lastDateTime = GetDateTime(lastLine.Split(';')[0]);
                    else
                        lastDateTime = new DateTime(to.Ticks + Day1.Ticks);
                    ProgressUpdate?.Invoke(this, new ProgressEvent() { MaxProgress = maxProgress, CurrentProgress = FromDateToInt(from) - FromDateToInt(requestData.From), IsFinished = false });
                }

                file.Close();
                ProgressUpdate?.Invoke(this, new ProgressEvent() { MaxProgress = 100, CurrentProgress = 100, IsFinished = true });
            });
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
        }

        private DateTime GetDateTime(string dateString)
        {
            int year = Convert.ToInt32(dateString.Substring(0, 4));
            int month = Convert.ToInt32(dateString.Substring(4, 2));
            int day = Convert.ToInt32(dateString.Substring(6));
            return new DateTime(year, month, day);
        }

        private int FromDateToInt(DateTime dateTime)
        {
            return 367 * dateTime.Year + 32 * dateTime.Month + dateTime.Day;
        }
    }

    public class ProgressEvent
    {
        public int CurrentProgress { get; set; }
        public int MaxProgress { get; set; }
        public bool IsFinished { get; set; }
    }
}