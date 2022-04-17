using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace Cornea
{
    public partial class Sleep : Form
    {
        private System.Windows.Forms.Timer timer1= new System.Windows.Forms.Timer();
        private static int nightLight;
        private static int nightBrightness;
        private static int bedhour;
        private static int bedmin;
        private static int wakehour;
        private static int wakemin;
        public Sleep()
        {
            InitializeComponent();
        }
        public static void SetBrightness(int targetBrightness)
        {
            ManagementScope scope = new ManagementScope("root\\WMI");
            SelectQuery query = new SelectQuery("WmiMonitorBrightnessMethods");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
            {
                using (ManagementObjectCollection objectCollection = searcher.Get())
                {
                    foreach (ManagementObject mObj in objectCollection)
                    {
                        mObj.InvokeMethod("WmiSetBrightness",
                            new Object[] { UInt32.MaxValue, targetBrightness });
                        break;
                    }
                }
            }
        }
        

        public void Init_Timer()
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60000;
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            function();
        }

        public static int AccessHour()
        {
            DateTime UTCNow = DateTime.Now;
            int hour = UTCNow.Hour;
            return hour;
        }
        public static int AccessMinutes()
        {
            DateTime UTCNow = DateTime.Now;
            int minutes = UTCNow.Minute;
            return minutes;
        }

        private void brightnessSlider_ValueChanged(object sender, EventArgs e)
        {
            display2.Text = brightnessSlider.Value.ToString();
            nightBrightness = brightnessSlider.Value;
            function();
        }

        private void nightlightSlider_ValueChanged(object sender, EventArgs e)
        {
            display1.Text = nightlightSlider.Value.ToString();
            nightLight = nightlightSlider.Value;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "ON";
                function();
            }
            else
            {
                checkBox1.Text = "OFF";
            }
        }
        private void bedHour_TextChanged(object sender, EventArgs e)
        {
            if (bedHour.Text != "") {
                bedhour = int.Parse(bedHour.Text);
                function();
            }
        }

        private void bedMin_TextChanged(object sender, EventArgs e)
        {
            if (bedHour.Text != "")
            {
                bedmin = int.Parse(bedMin.Text);
                function();
            }
        }

        private void wakeHour_TextChanged(object sender, EventArgs e)
        {
            if (bedHour.Text != "")
            {
                wakehour = int.Parse(wakeHour.Text);
                function();
            }
        }

        private void wakeMin_TextChanged(object sender, EventArgs e)
        {
            if (bedHour.Text != "")
            {
                wakemin = int.Parse(wakeMin.Text);
                function();
            }
        }
        private void function()
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "ON";

                if (bedhour > wakehour) {
                    if (bedhour < AccessHour() || AccessHour() < wakehour)
                    {
                        SetBrightness(nightBrightness);
                    }
                    else if (bedhour == AccessHour() && bedmin <= AccessMinutes())
                    {
                        SetBrightness(nightBrightness);
                    }
                    else if (wakehour == AccessHour() && wakemin >= AccessMinutes())
                    {
                        SetBrightness(nightBrightness);
                    }
                }
                else if(bedhour < wakehour)
                {
                    if (bedhour < AccessHour() && AccessHour() < wakehour)
                    {
                        SetBrightness(nightBrightness);
                    }
                    else if (bedhour == AccessHour() && bedmin <= AccessMinutes())
                    {
                        SetBrightness(nightBrightness);
                    }
                    else if (wakehour == AccessHour() && wakemin >= AccessMinutes())
                    {
                        SetBrightness(nightBrightness);
                    }
                }
                else
                {
                    if (bedmin <= AccessMinutes() && AccessMinutes() <= wakemin)
                    {
                        SetBrightness(nightBrightness);
                    }
                }
            }
            else
            {
                checkBox1.Text = "OFF";
            }
        }

        private void Sleep_Load(object sender, EventArgs e)
        {
            Init_Timer();
        }
    }
}
