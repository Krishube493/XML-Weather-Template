using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            Wind.Text = "Wind: " + Form1.days[0].windDirection + ", " +  Form1.days[0].windSpeed;
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.0") + " °C";
            cityOutput.Text = Form1.days[0].location;
            minOutput.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.0") + " °C";
            maxOutput.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.0") + " °C";


           int temp = Convert.ToInt32(Form1.days[0].condition);

            //display image of condition 
           if (temp == 800)
           {
                this.BackgroundImage = Properties.Resources.Sunny;
                this.BackgroundImageLayout = ImageLayout.Center;
           }
           else if (temp > 199 && temp < 233)
           {
                this.BackgroundImage = Properties.Resources.Stormy;
                this.BackgroundImageLayout = ImageLayout.Center;
           }
           else if (temp > 299 && temp < 532)
            {
                this.BackgroundImage = Properties.Resources.Rain;
                this.BackgroundImageLayout = ImageLayout.Center;
            }
           else if (temp > 599 && temp < 623)
            {
                this.BackgroundImage = Properties.Resources.Snowy;
                this.BackgroundImageLayout = ImageLayout.Center;
            }
           else if (temp > 800 && temp < 805)
            {
                this.BackgroundImage = Properties.Resources.Cloudy;
                this.BackgroundImageLayout = ImageLayout.Center;
            }
           else
            {
                this.BackgroundImage = Properties.Resources.Cloudy;
                this.BackgroundImageLayout = ImageLayout.Center;
            }

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
