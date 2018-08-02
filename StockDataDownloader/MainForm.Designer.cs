namespace StockDataDownloader
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.marketDateTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDateTime = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.toDateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.securityComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.marketComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.secondTable = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.timeFrameComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateFormatComboBox = new System.Windows.Forms.ComboBox();
            this.timeFormatComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fileDialogElement = new AdditionalForms.FileDialogElement();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.marketDateTablePanel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.secondTable.SuspendLayout();
            this.buttonsTable.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.marketDateTablePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.secondTable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonsTable, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // marketDateTablePanel
            // 
            this.marketDateTablePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.marketDateTablePanel.ColumnCount = 2;
            this.marketDateTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.marketDateTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.marketDateTablePanel.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.marketDateTablePanel.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.marketDateTablePanel.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.marketDateTablePanel.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.marketDateTablePanel.Location = new System.Drawing.Point(22, 0);
            this.marketDateTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.marketDateTablePanel.Name = "marketDateTablePanel";
            this.marketDateTablePanel.RowCount = 2;
            this.marketDateTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.marketDateTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.marketDateTablePanel.Size = new System.Drawing.Size(239, 100);
            this.marketDateTablePanel.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.fromDateTime, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(120, 52);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Начальная дата";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // fromDateTime
            // 
            this.fromDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDateTime.CustomFormat = "dd/MM/yyyy";
            this.fromDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTime.Location = new System.Drawing.Point(3, 29);
            this.fromDateTime.Name = "fromDateTime";
            this.fromDateTime.Size = new System.Drawing.Size(114, 20);
            this.fromDateTime.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.toDateTime, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(120, 54);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(119, 52);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // toDateTime
            // 
            this.toDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toDateTime.CustomFormat = "dd/MM/yyyy";
            this.toDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTime.Location = new System.Drawing.Point(3, 29);
            this.toDateTime.Name = "toDateTime";
            this.toDateTime.Size = new System.Drawing.Size(113, 20);
            this.toDateTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Конечная дата";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.securityComboBox, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(120, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(119, 54);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Цунная бумага";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // securityComboBox
            // 
            this.securityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.securityComboBox.FormattingEnabled = true;
            this.securityComboBox.Location = new System.Drawing.Point(3, 30);
            this.securityComboBox.Name = "securityComboBox";
            this.securityComboBox.Size = new System.Drawing.Size(113, 21);
            this.securityComboBox.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.marketComboBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(120, 54);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рынок";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // marketComboBox
            // 
            this.marketComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.marketComboBox.FormattingEnabled = true;
            this.marketComboBox.Location = new System.Drawing.Point(3, 30);
            this.marketComboBox.Name = "marketComboBox";
            this.marketComboBox.Size = new System.Drawing.Size(114, 21);
            this.marketComboBox.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBar.Location = new System.Drawing.Point(21, 212);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(241, 19);
            this.progressBar.TabIndex = 5;
            // 
            // secondTable
            // 
            this.secondTable.AutoSize = true;
            this.secondTable.ColumnCount = 2;
            this.secondTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.secondTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.secondTable.Controls.Add(this.label5, 0, 0);
            this.secondTable.Controls.Add(this.timeFrameComboBox, 1, 0);
            this.secondTable.Controls.Add(this.label6, 0, 3);
            this.secondTable.Controls.Add(this.label7, 0, 1);
            this.secondTable.Controls.Add(this.dateFormatComboBox, 1, 1);
            this.secondTable.Controls.Add(this.timeFormatComboBox, 1, 2);
            this.secondTable.Controls.Add(this.label8, 0, 2);
            this.secondTable.Controls.Add(this.fileDialogElement, 1, 3);
            this.secondTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondTable.Location = new System.Drawing.Point(0, 103);
            this.secondTable.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.secondTable.Name = "secondTable";
            this.secondTable.RowCount = 4;
            this.secondTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.secondTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.secondTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.secondTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.secondTable.Size = new System.Drawing.Size(284, 107);
            this.secondTable.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Таймфрейм";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeFrameComboBox
            // 
            this.timeFrameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeFrameComboBox.FormattingEnabled = true;
            this.timeFrameComboBox.Location = new System.Drawing.Point(145, 3);
            this.timeFrameComboBox.Name = "timeFrameComboBox";
            this.timeFrameComboBox.Size = new System.Drawing.Size(136, 21);
            this.timeFrameComboBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Куда сохранить";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Формат даты";
            // 
            // dateFormatComboBox
            // 
            this.dateFormatComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFormatComboBox.FormattingEnabled = true;
            this.dateFormatComboBox.Location = new System.Drawing.Point(145, 30);
            this.dateFormatComboBox.Name = "dateFormatComboBox";
            this.dateFormatComboBox.Size = new System.Drawing.Size(136, 21);
            this.dateFormatComboBox.TabIndex = 5;
            // 
            // timeFormatComboBox
            // 
            this.timeFormatComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeFormatComboBox.FormattingEnabled = true;
            this.timeFormatComboBox.Location = new System.Drawing.Point(145, 57);
            this.timeFormatComboBox.Name = "timeFormatComboBox";
            this.timeFormatComboBox.Size = new System.Drawing.Size(136, 21);
            this.timeFormatComboBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Формат времени";
            // 
            // fileDialogElement
            // 
            this.fileDialogElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileDialogElement.Location = new System.Drawing.Point(145, 84);
            this.fileDialogElement.MinimumSize = new System.Drawing.Size(0, 20);
            this.fileDialogElement.Name = "fileDialogElement";
            this.fileDialogElement.Size = new System.Drawing.Size(136, 20);
            this.fileDialogElement.TabIndex = 8;
            this.fileDialogElement.Type = AdditionalForms.DialogType.SaveFile;
            // 
            // buttonsTable
            // 
            this.buttonsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsTable.AutoSize = true;
            this.buttonsTable.ColumnCount = 2;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Controls.Add(this.startButton, 0, 0);
            this.buttonsTable.Controls.Add(this.stopButton, 1, 0);
            this.buttonsTable.Location = new System.Drawing.Point(3, 236);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Size = new System.Drawing.Size(278, 29);
            this.buttonsTable.TabIndex = 7;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.Location = new System.Drawing.Point(32, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopButton.BackColor = System.Drawing.Color.LightCoral;
            this.stopButton.Location = new System.Drawing.Point(171, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 270);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(284, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 292);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1000, 331);
            this.MinimumSize = new System.Drawing.Size(300, 331);
            this.Name = "MainForm";
            this.Text = "Stock Data Downloader";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.marketDateTablePanel.ResumeLayout(false);
            this.marketDateTablePanel.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.secondTable.ResumeLayout(false);
            this.secondTable.PerformLayout();
            this.buttonsTable.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel marketDateTablePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fromDateTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox securityComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox marketComboBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DateTimePicker toDateTime;
        private System.Windows.Forms.TableLayoutPanel secondTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox timeFrameComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dateFormatComboBox;
        private System.Windows.Forms.ComboBox timeFormatComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private AdditionalForms.FileDialogElement fileDialogElement;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

