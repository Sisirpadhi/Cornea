using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cornea
{
    public partial class SplashScreen : Form
    {
        
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void countdown_timer_stayTime()
        //{
        //    //timer3 = new System.Windows.Forms.Timer();
        //    timer1.Tick += new EventHandler(timer1_Tick);
        //    timer1.Interval = 1000; // 1 second 
        //    timer1.Start();
        //}
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    var sett2 = new Timer();
        //    if (counter2 > 0)
        //    {
        //        counter2--;
        //        label1.Text = counter2.ToString();
        //    }
        //    else
        //    {

        //        this.Close();
        //    }
        //}
        //private void SplashScreen_Load(object sender, EventArgs e)
        //{
        //    var sett1 = new Timer();
        //    counter2 = 20;
        //    countdown_timer_stayTime();
        //    //label1.Text= sett1.counter1.ToString();
        //    //Console.WriteLine(label1.Text);
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}
