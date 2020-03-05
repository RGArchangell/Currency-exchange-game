using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyGame
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        double C;
        private double rub = 100000.0;
        private double eur = 0.0;
        private int day = 0;
        const double k = 0.02;

        public Form1()
        {
            C = rand.Next(10, 100) * 1.0;
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            updateCurrencyLabels();
            currencyChart.Series[0].Name = "Euro";
            currencyChart.ChartAreas[0].AxisY.IsStartedFromZero = false;
            currencyChart.ChartAreas[0].AxisX.Minimum = 0;
            currencyChart.Series[0].IsValueShownAsLabel = true;
            currencyChart.Series[0].Color = Color.Green;

            if (!gameTimer.Enabled)
            {
                currencyChart.Series[0].Points.AddXY(day, C);
                gameTimer.Start();
                startButton.Text = "Pause";
            }
            else
            {
                gameTimer.Stop();
                startButton.Text = "Start";
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            double eurAmount = (double) amountUpDown1.Value;

            if (eurAmount > eur)
            {
                eurAmount = eur;
            }

            rub += eurAmount * C;
            eur -= eurAmount;
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            double eurAmount = (double)amountUpDown1.Value;
            double rubAmount = eurAmount * C;

            if (rubAmount > rub)
            {
                rubAmount = rub;
            }

            eur += rubAmount / C;
            rub -= rubAmount;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            updateCurrencyLabels();

            day++;

            double x = (double) rand.NextDouble();
            C = C * (1 + k * (x - 0.5));
            currencyChart.Series[0].Points.AddXY(day, C);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            day = 0;
            currencyChart.Series[0].Points.Clear();
            C = rand.Next(10, 100) * 1.0;
            currencyChart.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void updateCurrencyLabels()
        {
            EuroLabel.Text = eur.ToString() + " EUR";
            RubLabel.Text = rub.ToString() + " RUB";
        }

    }
}
