using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDataDownloader
{
    public partial class MainForm : Form
    {
        private Downloader downloader;


        public MainForm()
        {
            InitializeComponent();

            downloader = new Downloader();
            downloader.ProgressUpdate += OnProgressUpdate;

            RequestData data = new RequestData(Enums.MarketEnum.MosExchangeFutures, Enums.Security.SBRF_RTS, new DateTime(2018, 1, 1), new DateTime(2018, 5, 1));
            downloader.LoadData(data, "newtickdata.txt");
        }

        private void OnProgressUpdate(object sender, ProgressEvent e)
        {
            this.Invoke((Action)(() =>
            {
                progressBar.Maximum = e.MaxProgress;
                progressBar.Value = e.CurrentProgress > e.MaxProgress ? e.MaxProgress : e.CurrentProgress;
                if (e.IsFinished)
                    progressBar.Value = e.MaxProgress;
            }));
        }
    }
}
