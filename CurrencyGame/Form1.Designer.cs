namespace CurrencyGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.RubLabel = new System.Windows.Forms.Label();
            this.EuroLabel = new System.Windows.Forms.Label();
            this.currencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.amountUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.sellButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.currencyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // RubLabel
            // 
            this.RubLabel.AutoSize = true;
            this.RubLabel.Location = new System.Drawing.Point(12, 22);
            this.RubLabel.Name = "RubLabel";
            this.RubLabel.Size = new System.Drawing.Size(39, 13);
            this.RubLabel.TabIndex = 0;
            this.RubLabel.Text = "0 RUB";
            // 
            // EuroLabel
            // 
            this.EuroLabel.AutoSize = true;
            this.EuroLabel.Location = new System.Drawing.Point(12, 44);
            this.EuroLabel.Name = "EuroLabel";
            this.EuroLabel.Size = new System.Drawing.Size(39, 13);
            this.EuroLabel.TabIndex = 1;
            this.EuroLabel.Text = "0 EUR";
            // 
            // currencyChart
            // 
            chartArea6.Name = "ChartArea1";
            this.currencyChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.currencyChart.Legends.Add(legend6);
            this.currencyChart.Location = new System.Drawing.Point(15, 76);
            this.currencyChart.Name = "currencyChart";
            this.currencyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.currencyChart.Series.Add(series6);
            this.currencyChart.Size = new System.Drawing.Size(905, 556);
            this.currencyChart.SuppressExceptions = true;
            this.currencyChart.TabIndex = 2;
            this.currencyChart.Text = "chart1";
            // 
            // amountUpDown1
            // 
            this.amountUpDown1.Location = new System.Drawing.Point(612, 22);
            this.amountUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amountUpDown1.Name = "amountUpDown1";
            this.amountUpDown1.Size = new System.Drawing.Size(92, 20);
            this.amountUpDown1.TabIndex = 3;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(710, 12);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 23);
            this.sellButton.TabIndex = 4;
            this.sellButton.Text = "Sell EUR";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(710, 39);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 5;
            this.buyButton.Text = "Buy EUR";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 3000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(262, 22);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 24);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(391, 22);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 644);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.amountUpDown1);
            this.Controls.Add(this.currencyChart);
            this.Controls.Add(this.EuroLabel);
            this.Controls.Add(this.RubLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.currencyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RubLabel;
        private System.Windows.Forms.Label EuroLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart currencyChart;
        private System.Windows.Forms.NumericUpDown amountUpDown1;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button clearButton;
    }
}

