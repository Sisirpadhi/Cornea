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
    public partial class bluelight : Form
    {
        private static int daylight=100;
        private static int nightlight=100;
        public bluelight()
        {
            InitializeComponent();
        }
        private void dayslider_ValueChanged(object sender, EventArgs e)
        {
            display1.Text = dayslider.Value.ToString();
            daylight = dayslider.Value;
        }
        private void nightslider_ValueChanged(object sender, EventArgs e)
        {
            display2.Text = nightslider.Value.ToString();
            nightlight = nightslider.Value;
            if (checkBox1.Checked)
            {
                checkBox1.Text = "ON";
            }
            else
            {
                checkBox1.Text = "OFF";
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "ON";
            }
            else
            {
                checkBox1.Text = "OFF";
            }
        }

        private void bluelight_Load(object sender, EventArgs e)
        {
            dayslider.Value = daylight;
            nightslider.Value = nightlight;
            display1.Text = daylight.ToString();
            display2.Text = nightlight.ToString();
        }
    }
}
