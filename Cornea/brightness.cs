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
    public partial class brightness : Form
    {
        private static int dayBrightness=50;
        private static int nightBrightness=50;
        public brightness()
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
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        private void dayslider_ValueChanged(object sender, EventArgs e)
        {
            display1.Text = dayslider.Value.ToString();
            dayBrightness = dayslider.Value;
            SetBrightness(dayBrightness);
            wait(1000);
            if (checkBox1.Checked)
            {
                checkBox1.Text = "ON";
                SetBrightness(nightBrightness);
            }
            else
            {
                checkBox1.Text = "OFF";
                Interpolate();
            }
        }
        private void nightslider_ValueChanged(object sender, EventArgs e)
        {
            display2.Text = nightslider.Value.ToString();
            nightBrightness = nightslider.Value;
            SetBrightness(nightBrightness);
            wait(1000);
            if (checkBox1.Checked)
            {
                checkBox1.Text = "ON";
                SetBrightness(nightBrightness);
            }
            else
            {
                checkBox1.Text = "OFF";
                Interpolate();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "ON";
                SetBrightness(nightBrightness);
            }
            else
            {
                checkBox1.Text = "OFF";
                Interpolate();
            }
        }
        public static void Interpolate()
        {
            int hour = Math.Abs(AccessTime());
            SetBrightness(dayBrightness + ((nightBrightness - dayBrightness) * hour) / 12);
        }
        public static int AccessTime()
        {
            DateTime UTCNow = DateTime.Now;
            int hour = UTCNow.Hour;
            return hour - 12;
        }

        private void brightness_Load(object sender, EventArgs e)
        {
            dayslider.Value = dayBrightness;
            nightslider.Value = nightBrightness;
            display1.Text = dayBrightness.ToString();
            display2.Text = nightBrightness.ToString();
        }
    }
}
