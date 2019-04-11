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
            if (Form1.days[1].condition == "800")
            {
                this.pictureDay1.Image = Properties.Resources.smallSun;
            }
            else if (Form1.days[1].condition == "200" || Form1.days[1].condition == "201" || Form1.days[1].condition == "202"
                 || Form1.days[1].condition == "210" || Form1.days[1].condition == "211" || Form1.days[1].condition == "212"
                 || Form1.days[1].condition == "221" || Form1.days[1].condition == "230" || Form1.days[1].condition == "231"
                 || Form1.days[1].condition == "232")
            {
                this.pictureDay1.Image = Properties.Resources.smallStormy;
            }
             else if (Form1.days[1].condition == "300" || Form1.days[1].condition == "301" || Form1.days[1].condition == "302"
                  || Form1.days[1].condition == "310" || Form1.days[1].condition == "311" || Form1.days[1].condition == "312"
                  || Form1.days[1].condition == "313" || Form1.days[1].condition == "314" || Form1.days[1].condition == "321"
                  || Form1.days[1].condition == "500" || Form1.days[1].condition == "501" || Form1.days[1].condition == "502"
                  || Form1.days[1].condition == "503" || Form1.days[1].condition == "504" || Form1.days[1].condition == "511"
                  || Form1.days[1].condition == "520" || Form1.days[1].condition == "521" || Form1.days[1].condition == "522"
                  || Form1.days[1].condition == "531")
             {
                 this.pictureDay1.Image = Properties.Resources.smallRain;
             }
            else if (Form1.days[1].condition == "600" || Form1.days[1].condition == "601" || Form1.days[1].condition == "602"
                 || Form1.days[1].condition == "611" || Form1.days[1].condition == "612" || Form1.days[1].condition == "613"
                 || Form1.days[1].condition == "615" || Form1.days[1].condition == "616" || Form1.days[1].condition == "620"
                 || Form1.days[1].condition == "621" || Form1.days[1].condition == "622")
            {
                this.pictureDay1.Image = Properties.Resources.smallSnow;
            }
            else if (Form1.days[1].condition == "801" || Form1.days[1].condition == "802" || Form1.days[1].condition == "803"
                 || Form1.days[1].condition == "804")
            {
                this.pictureDay1.Image = Properties.Resources.smallCloud;
            }
            else
            {
                //Image of atmosphere
            }

            //day 2 conditions 
            if (Form1.days[2].condition == "800")
            {
                this.pictureDay2.Image = Properties.Resources.smallSun;
            }
            else if (Form1.days[2].condition == "200" || Form1.days[2].condition == "201" || Form1.days[2].condition == "202"
                 || Form1.days[2].condition == "210" || Form1.days[2].condition == "211" || Form1.days[2].condition == "212"
                 || Form1.days[2].condition == "221" || Form1.days[2].condition == "230" || Form1.days[2].condition == "231"
                 || Form1.days[2].condition == "232")
            {
                this.pictureDay2.Image = Properties.Resources.smallStormy;
            }
            else if (Form1.days[2].condition == "300" || Form1.days[2].condition == "301" || Form1.days[2].condition == "302"
                 || Form1.days[2].condition == "310" || Form1.days[2].condition == "311" || Form1.days[2].condition == "312"
                 || Form1.days[2].condition == "313" || Form1.days[2].condition == "314" || Form1.days[2].condition == "321"
                 || Form1.days[2].condition == "500" || Form1.days[2].condition == "501" || Form1.days[2].condition == "502"
                 || Form1.days[2].condition == "503" || Form1.days[2].condition == "504" || Form1.days[2].condition == "511"
                 || Form1.days[2].condition == "520" || Form1.days[2].condition == "521" || Form1.days[2].condition == "522"
                 || Form1.days[2].condition == "531")
            {
                this.pictureDay2.Image = Properties.Resources.smallRain;
            }
            else if (Form1.days[2].condition == "600" || Form1.days[2].condition == "601" || Form1.days[2].condition == "602"
                 || Form1.days[2].condition == "611" || Form1.days[2].condition == "612" || Form1.days[2].condition == "613"
                 || Form1.days[2].condition == "615" || Form1.days[2].condition == "616" || Form1.days[2].condition == "620"
                 || Form1.days[2].condition == "621" || Form1.days[2].condition == "622")
            {
                this.pictureDay2.Image = Properties.Resources.smallSnow;
            }
            else if (Form1.days[2].condition == "801" || Form1.days[2].condition == "802" || Form1.days[2].condition == "803"
                 || Form1.days[2].condition == "804")
            {
                this.pictureDay2.Image = Properties.Resources.smallCloud;
            }
            else
            {
                //Image of atmosphere
            }

            //day 3 conditions
            if (Form1.days[3].condition == "800")
            {
                this.pictureDay3.Image = Properties.Resources.smallSun;
            }
            else if (Form1.days[3].condition == "200" || Form1.days[3].condition == "201" || Form1.days[3].condition == "202"
                 || Form1.days[3].condition == "210" || Form1.days[3].condition == "211" || Form1.days[3].condition == "212"
                 || Form1.days[3].condition == "221" || Form1.days[3].condition == "230" || Form1.days[3].condition == "231"
                 || Form1.days[3].condition == "232")
            {
                this.pictureDay3.Image = Properties.Resources.smallStormy;
            }
            else if (Form1.days[3].condition == "300" || Form1.days[3].condition == "301" || Form1.days[3].condition == "302"
                 || Form1.days[3].condition == "310" || Form1.days[3].condition == "311" || Form1.days[3].condition == "312"
                 || Form1.days[3].condition == "313" || Form1.days[3].condition == "314" || Form1.days[3].condition == "321"
                 || Form1.days[3].condition == "500" || Form1.days[3].condition == "501" || Form1.days[3].condition == "502"
                 || Form1.days[3].condition == "503" || Form1.days[3].condition == "504" || Form1.days[3].condition == "511"
                 || Form1.days[3].condition == "520" || Form1.days[3].condition == "521" || Form1.days[3].condition == "522"
                 || Form1.days[3].condition == "531")
            {
                this.pictureDay3.Image = Properties.Resources.smallRain;
            }
            else if (Form1.days[3].condition == "600" || Form1.days[3].condition == "601" || Form1.days[3].condition == "602"
                 || Form1.days[3].condition == "611" || Form1.days[3].condition == "612" || Form1.days[3].condition == "613"
                 || Form1.days[3].condition == "615" || Form1.days[3].condition == "616" || Form1.days[3].condition == "620"
                 || Form1.days[3].condition == "621" || Form1.days[3].condition == "622")
            {
                this.pictureDay3.Image = Properties.Resources.smallSnow;
            }
            else if (Form1.days[3].condition == "801" || Form1.days[3].condition == "802" || Form1.days[3].condition == "803"
                 || Form1.days[3].condition == "804")
            {
                this.pictureDay3.Image = Properties.Resources.smallCloud;
            }
            else
            {
                //Image of atmosphere
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
