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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.0") + " °C";
            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.0") + " °C";

            date2.Text = Form1.days[2].date;
            min2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.0") + " °C";
            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.0") + " °C";

            date3.Text = Form1.days[3].date;
            min3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0.0") + " °C";
            max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.0") + " °C";

            //display image of day 1 conditions
            int temp1 = Convert.ToInt32(Form1.days[1].condition);

            if (temp1 == 800)
            {
                this.pictureDay1.Image = Properties.Resources.smallSun;
            }
            else if (temp1 > 199 && temp1 < 233)
            {
                this.pictureDay1.Image = Properties.Resources.smallStormy;
            }
            else if (temp1 > 299 && temp1 < 532)
            {
                 this.pictureDay1.Image = Properties.Resources.smallRain;
            }
            else if (temp1 > 599 && temp1 < 623)
            {
                this.pictureDay1.Image = Properties.Resources.smallSnow;
            }
            else if (temp1 > 800 && temp1 < 805)
            {
                this.pictureDay1.Image = Properties.Resources.smallCloud;
            }
            else
            {
                this.pictureDay1.Image = Properties.Resources.smallCloud;
            }

            //day 2 conditions 
            int temp2 = Convert.ToInt32(Form1.days[2].condition);

            if (temp2 == 800)
            {
                this.pictureDay2.Image = Properties.Resources.smallSun;
            }
            else if (temp2 > 199 && temp2 < 233)
            {
                this.pictureDay2.Image = Properties.Resources.smallStormy;
            }
            else if (temp2 > 299 && temp2 < 532)
            {
                this.pictureDay2.Image = Properties.Resources.smallRain;
            }
            else if (temp2 > 599 && temp2 < 623)
            {
                this.pictureDay2.Image = Properties.Resources.smallSnow;
            }
            else if (temp2 > 800 && temp2 < 805)
            {
                this.pictureDay2.Image = Properties.Resources.smallCloud;
            }
            else
            {
                this.pictureDay2.Image = Properties.Resources.smallCloud;
            }

            //day 3 conditions
            int temp3 = Convert.ToInt32(Form1.days[3].condition);

            if (temp3 == 800)
            {
                this.pictureDay3.Image = Properties.Resources.smallSun;
            }
            else if (temp3 > 199 && temp3 < 233)
            {
                this.pictureDay3.Image = Properties.Resources.smallStormy;
            }
            else if (temp3 > 299 && temp3 < 532)
            {
                this.pictureDay3.Image = Properties.Resources.smallRain;
            }
            else if (temp3 > 599 && temp3 < 623)
            {
                this.pictureDay3.Image = Properties.Resources.smallSnow;
            }
            else if (temp3 > 800 && temp3 < 805)
            {
                this.pictureDay3.Image = Properties.Resources.smallCloud;
            }
            else
            {
                this.pictureDay3.Image = Properties.Resources.smallCloud;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
