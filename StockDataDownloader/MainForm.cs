using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormLibrary;
using StockDataDownloader.Enums;

namespace StockDataDownloader
{
    public partial class MainForm : Form
    {
        private Downloader downloader;


        public MainForm()
        {
            InitializeComponent();

            FillFields();

            downloader = new Downloader();

            marketComboBox.SelectedIndexChanged += OnMarketSelectedIndexChanged;
            fromDateTime.ValueChanged += DateTimeOnValueChanged;
            toDateTime.ValueChanged += DateTimeOnValueChanged;

            toDateTime.MaxDate = DateTime.Now;
            fromDateTime.MaxDate = DateTime.Now;
        }

        private void FillFields()
        {
            foreach (var x in Enum.GetValues(typeof(MarketEnum)))
            {
                marketComboBox.Items.Add(x.ToString());
            }

            foreach (var x in Enum.GetValues(typeof(TimeFrame)))
            {
                timeFrameComboBox.Items.Add(x.ToString());
            }
            timeFrameComboBox.SelectedItem = TimeFrame.Ticks.ToString();

            foreach (var x in Enum.GetValues(typeof(DateFormat)))
            {
                dateFormatComboBox.Items.Add(x.ToString());
            }
            dateFormatComboBox.SelectedItem = DateFormat.GGGGMMDD.ToString();

            foreach (var x in Enum.GetValues(typeof(TimeFormat)))
            {
                timeFormatComboBox.Items.Add(x.ToString());
            }
            timeFormatComboBox.SelectedItem = TimeFormat.HHMMSS.ToString();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MarketEnum market;
            Security security;
            TimeFrame timeFrame;
            TimeFormat timeFormat;
            DateFormat dateFormat;

            DateTime from, to;

            Enum.TryParse((string) marketComboBox.SelectedItem, out market);
            Enum.TryParse((string)securityComboBox.SelectedItem, out security);
            Enum.TryParse((string) timeFrameComboBox.SelectedItem, out timeFrame);
            Enum.TryParse((string) timeFormatComboBox.SelectedItem, out timeFormat);
            Enum.TryParse((string) dateFormatComboBox.SelectedItem, out dateFormat);

            from = fromDateTime.Value;
            to = toDateTime.Value;

            downloader.ProgressUpdate += OnProgressUpdate;
            var requestData = new RequestData(market, security, from, to, timeFrame, dateFormat, timeFormat);
            downloader.LoadData(requestData, fileDialogElement.Path);
        }

        private void OnProgressUpdate(object sender, ProgressEvent e)
        {
            this.Invoke((Action)(() =>
            {
                progressBar.Maximum = e.MaxProgress;
                progressBar.Value = e.CurrentProgress > e.MaxProgress || e.CurrentProgress < 0 ? e.MaxProgress : e.CurrentProgress;
                if (e.IsFinished)
                {
                    downloader.ProgressUpdate -= OnProgressUpdate;
                    progressBar.Value = e.MaxProgress;
                }
            }));
        }

        private void OnMarketSelectedIndexChanged(object sender, EventArgs e)
        {
            var marketBox = sender as ComboBox;
            if (marketBox == null)
                return;

            MarketEnum market;
            Enum.TryParse((string)marketBox.SelectedItem, out market);


            var values = Market.GetSecuritiesByMarket(market);

            securityComboBox.Items.Clear();
            foreach (var x in values)
            {
                securityComboBox.Items.Add(x.ToString());
            }
        }

        private void DateTimeOnValueChanged(object sender, EventArgs e)
        {
            if (sender == fromDateTime)
            {
                toDateTime.MinDate = fromDateTime.Value;
            }
            else
            {
                fromDateTime.MaxDate = toDateTime.Value;
            }
        }
    }
}
