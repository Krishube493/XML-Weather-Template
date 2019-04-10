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

            Convert.ToString(Form1.days[0].condition);

            if (Form1.days[0].condition = 800)
            {
                this.BackgroundImage = Properties.Resources.Sunny;
                this.BackgroundImageLayout = ImageLayout.Center;
            }
            else if (Form1.days[0].condition = 0) 
            {
                
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
