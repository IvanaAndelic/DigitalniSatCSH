using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DigitalniSat
{
    public partial class Form1 : Form
    {
        public Form1()
        { 

            InitializeComponent();

            CultureInfo[] custom = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            this.kulture.Items.AddRange(custom);

            

            DateTime trenutno_vrijeme = DateTime.Now;

            vrijeme.Text = trenutno_vrijeme.ToString();
            inicijalizirajTimer();



        }
        private System.Windows.Forms.Timer timer;

        public void inicijalizirajTimer()
        {
            timer = new System.Windows.Forms.Timer();//po defaultu postoji prazan konstruktor
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            vrijeme.Text = DateTime.Now.ToString();
        }

        private void kulture_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo odabran = kulture.SelectedItem as CultureInfo;
            Thread.CurrentThread.CurrentCulture = odabran;
            

        }
    }
}
