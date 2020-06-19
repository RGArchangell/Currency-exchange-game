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
        private double C;
        private double rub = 100000.0;
        private double eur = 0.0;
        private int day = 0;
        private const double k = 0.02;
        private const double w0 = 0;
        private double t = 1.0;
        private double dt = 0.1;
        private double wt = 0.0;

        public Form1()
        {
            C = rand.Next(70, 90) * 1.0;
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

            double mu = 0.01;
            double sigma = 0.01;
            double new_t = t + dt;
            wt = winear(t, new_t);

            C = C * Math.Exp((mu - sigma * sigma / 2) * dt + sigma * wt);
            currencyChart.Series[0].Points.AddXY(day, C);

            t = new_t;
        }

        private double winear(double t, double new_t)
        {
            double x = GenerateBoxMuller();
            return wt + Math.Sqrt(dt) * x;
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

        private double GenerateBoxMuller()
        {
            double a1 = rand.NextDouble();
            double a2 = rand.NextDouble();

            return Math.Sqrt(-2 * Math.Log(a1)) * Math.Cos(2 * Math.PI * a2);
        }

    }
}
