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
    public partial class Timer : Form
    {
        public int counter1;
        private int intervalTime;
        private int stayTime ;
        private int postponeTime;
        private System.Windows.Forms.Timer timer3 = new System.Windows.Forms.Timer();
        public Timer()
        {
            InitializeComponent();
            Customize_design();
        }

        private void Customize_design()
        {
            timer_dropdown.Visible = false;
        }

        private void Hide_Sub_Menu()
        {
            if (timer_dropdown.Visible)
            {
                timer_dropdown.Visible = false;
            }
        }

        private void Show_Sub_Menu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                Hide_Sub_Menu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void timertype_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(timer_dropdown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timertype.Text = "OFF";
            Hide_Sub_Menu();
            label7.Text = "paused";
        }

        private String Conversion(int time)
        {
            int hour = time / 3600;
            String hr;
            if(hour < 10)
            {
                hr = "0"+hour.ToString();
            }
            else
            {
                hr = hour.ToString();
            }
            int min = (time % 3600) / 60;
            String m;
            if (min < 10)
            {
                m = "0" + min.ToString();
            }
            else
            {
                m = min.ToString();
            }
            int sec = time % 60;
            String s;
            if (sec < 10)
            {
                s = "0" + sec.ToString();
            }
            else
            {
                s = sec.ToString();
            }
            String str;
            str = hr + ":" + m + ":" + s;
            return str;
        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timertype.Text == "OFF")
            {
                //timer1.Enabled = false;
                counter1 = 0;
                return;
            }

            if (counter1 > stayTime)
            {
                counter1--;
                label7.Text = Conversion(counter1 - stayTime)  ;
            } 
            else if (counter1 <= stayTime && counter1 > 0)
            {
                counter1--;
                label7.Text = Conversion(counter1);

                //Thread.Sleep(); 
            }
            else if(counter1 == 0)
            {
                counter1 = intervalTime + stayTime;
            }

            PopUpForm popup = new PopUpForm();
            DialogResult dialogresult;
            if (counter1 <= 10+stayTime && counter1 > 9+stayTime)
            {
                //popup
                dialogresult = popup.ShowDialog(this);
                if (dialogresult == DialogResult.OK)
                {
                    counter1 += postponeTime;
                }
                //popup.Dispose();
            }

            SplashScreen ss = new SplashScreen();
            if (counter1 <= stayTime && counter1 > stayTime-1)
            {
                dialogresult = DialogResult.Cancel;
                popup.Dispose();
                DialogResult dialogresult2 = ss.ShowDialog();
                if (dialogresult2 == DialogResult.Cancel)
                {
                    counter1 = intervalTime + stayTime;// or cnter1=0;
                }
            }
        }

        private void countdown_timer_intervalTime()
        {
            //timer3 = new System.Windows.Forms.Timer();
            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Interval = 1000; // 1 second
            timer3.Start();
        }

        private void function()
        { 
            counter1 = intervalTime + stayTime; //interval time in minutes
            //counter2 = stayTime;    //stay time in seconds
            
            countdown_timer_intervalTime();
                //label8.Text = "true";
                //if (!TimerOn)
                //    break;
                //blank screen on
                //countdown_timer_stayTime();
                //blank screen off

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timertype.Text = "ON";
            Hide_Sub_Menu();
            //TimerOn = true;
            function();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //IntervalTime
        {
            if (textBox2.Text != "")
            {
                intervalTime = int.Parse(textBox2.Text)*60;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //StayTime
        {
            if (textBox3.Text != "")
            {
                stayTime = int.Parse(textBox3.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                postponeTime = int.Parse(textBox1.Text);
            }
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            textBox1.Text = "300";
            textBox2.Text = "20";
            textBox3.Text = "20";
        }
    }
}
