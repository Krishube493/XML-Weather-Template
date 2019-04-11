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
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.0") + " °C";
            cityOutput.Text = Form1.days[0].location;
            minOutput.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.0") + " °C";
            maxOutput.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.0") + " °C";

            //display image of condition 
           if (Form1.days[0].condition == "800")
           {
                this.BackgroundImage = Properties.Resources.Sunny;
                this.BackgroundImageLayout = ImageLayout.Center;
           }
           else if (Form1.days[0].condition == "200" || Form1.days[0].condition == "201" || Form1.days[0].condition == "202"
                || Form1.days[0].condition == "210" || Form1.days[0].condition == "211" || Form1.days[0].condition == "212"
                || Form1.days[0].condition == "221" || Form1.days[0].condition == "230" || Form1.days[0].condition == "231" 
                || Form1.days[0].condition == "232") 
           {
                this.BackgroundImage = Properties.Resources.Stormy;
                this.BackgroundImageLayout = ImageLayout.Center;
           }
           else if (Form1.days[0].condition == "300" || Form1.days[0].condition == "301" || Form1.days[0].condition == "302" 
                || Form1.days[0].condition == "310" || Form1.days[0].condition == "311" || Form1.days[0].condition == "312" 
                || Form1.days[0].condition == "313" || Form1.days[0].condition == "314" || Form1.days[0].condition == "321" 
                || Form1.days[0].condition == "500" || Form1.days[0].condition == "501" || Form1.days[0].condition == "502"
                || Form1.days[0].condition == "503" || Form1.days[0].condition == "504" || Form1.days[0].condition == "511"
                || Form1.days[0].condition == "520" || Form1.days[0].condition == "521" || Form1.days[0].condition == "522"
                || Form1.days[0].condition == "531")
            {
                this.BackgroundImage = Properties.Resources.Rain;
                this.BackgroundImageLayout = ImageLayout.Center;
            }
           else if (Form1.days[0].condition == "600" || Form1.days[0].condition == "601" || Form1.days[0].condition == "602" 
                || Form1.days[0].condition == "611" || Form1.days[0].condition == "612" || Form1.days[0].condition == "613" 
                || Form1.days[0].condition == "615" || Form1.days[0].condition == "616" || Form1.days[0].condition == "620" 
                || Form1.days[0].condition == "621" || Form1.days[0].condition == "622")
            {
                this.BackgroundImage = Properties.Resources.Snowy;
                this.BackgroundImageLayout = ImageLayout.Center;
            }
           else if (Form1.days[0].condition == "801" || Form1.days[0].condition == "802" || Form1.days[0].condition == "803"
                || Form1.days[0].condition == "804")
            {
                this.BackgroundImage = Properties.Resources.Cloudy;
                this.BackgroundImageLayout = ImageLayout.Center;
            }
           else
           {
                //Image of atmosphere
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
