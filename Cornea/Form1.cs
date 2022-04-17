using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
namespace Cornea
{

    using static NativeMethods;
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Customize_design();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void Customize_design()
        {
            dropdown_mode.Visible = false;
        }

        private void Hide_Sub_Menu()
        {
            if (dropdown_mode.Visible)
            {
                dropdown_mode.Visible = false;
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
        #region mode_click
        private void button1_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(dropdown_mode);
        }

        public static void Interpolate(int a,int b)
        {
            int hour = Math.Abs(AccessTime());
            SetBrightness(a + ((b - a) * hour) / 12);
        }
        public static int AccessTime()
        {
            DateTime UTCNow = DateTime.Now;
            int hour = UTCNow.Hour;
            return hour - 12;
        }

        private void healthy_Click(object sender, EventArgs e)
        {
            MagUninitialize();
            button1.Text = healthy.Text;
            display.Text = "Simple: " + healthy.Text;
            Interpolate(100, 80);
            Hide_Sub_Menu();
           
        }

        private void reading_Click(object sender, EventArgs e)
        {
            MagUninitialize();
            button1.Text = reading.Text;
            display.Text = "Simple: " + reading.Text;
            SetBrightness(80);
            black_white();
            Hide_Sub_Menu();
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
        void black_white()
        {
            float redScale = 0.2126f, greenScale = 0.7152f, blueScale = 0.0722f;
            var magEffectInvert = new MAGCOLOREFFECT
            {
                transform = new[] {
                    redScale,   redScale,   redScale,   0.0f,  0.0f,
                    greenScale, greenScale, greenScale, 0.0f,  0.0f,
                    blueScale,  blueScale,  blueScale,  0.0f,  0.0f,
                    0.0f,       0.0f,       0.0f,       1.0f,  0.0f,
                    0.0f,       0.0f,       0.0f,       0.0f,  1.0f
                    }
            };

            MagInitialize();
            MagSetFullscreenColorEffect(ref magEffectInvert);
            display.Text = "Simple: "+ reading.Text;
            Hide_Sub_Menu();
            wait(60000);

            MagUninitialize();
        }
        private void gaming_Click(object sender, EventArgs e)
        {
            MagUninitialize();
            button1.Text = gaming.Text;
            display.Text = "Simple: " + gaming.Text;
            Interpolate(100, 95);
            Hide_Sub_Menu();
        }

        private void dark_Click(object sender, EventArgs e)
        {
            MagUninitialize();
            button1.Text = dark.Text;
            display.Text = "Simple: " + dark.Text;
            SetBrightness(120);
            Hide_Sub_Menu();
        }

        private void sleep_Click(object sender, EventArgs e)
        {
            MagUninitialize();
            button1.Text = sleep.Text;
            display.Text = "Simple: " + sleep.Text;
            SetBrightness(30);
            Hide_Sub_Menu();
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private Form active_form = null;
        private void open_child_form(Form child_form)
        {
            if (active_form != null)
            {
                active_form.Close();
            }

            active_form = child_form;
            child_form.TopLevel = false;
            child_form.FormBorderStyle = FormBorderStyle.None;
            child_form.Dock = DockStyle.Fill;
            simple_panel.Controls.Add(child_form);
            simple_panel.Tag = child_form;
            child_form.BringToFront();
            child_form.Show();
        }

        private void advanced_Click(object sender, EventArgs e)
        {
            advanced.BackColor = Color.White;
            open_child_form(new Advanced());
            simple.BackColor = Color.FromArgb(24, 30, 54);
            pause.BackColor = Color.FromArgb(24, 30, 54);
            display.Text = "Advanced";
        }

        private void simple_Click(object sender, EventArgs e)
        {
            if (active_form != null)
            {
                active_form.Close();
            }
            simple.BackColor = Color.White;
            advanced.BackColor = Color.FromArgb(24, 30, 54);
            pause.BackColor = Color.FromArgb(24, 30, 54);
            display.Text = "Simple";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            pause.BackColor = Color.FromArgb(198, 0, 0);
            advanced.BackColor = Color.FromArgb(24, 30, 54);
            simple.BackColor = Color.FromArgb(24, 30, 54);
            display.Text = "Paused";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    static class NativeMethods
    {
    const string Magnification = "Magnification.dll";

    [DllImport(Magnification, ExactSpelling = true, SetLastError = true)]
    public static extern bool MagInitialize();

    [DllImport(Magnification, ExactSpelling = true, SetLastError = true)]
    public static extern bool MagUninitialize();

    [DllImport(Magnification, ExactSpelling = true, SetLastError = true)]
    public static extern bool MagSetFullscreenColorEffect(ref MAGCOLOREFFECT pEffect);

    public struct MAGCOLOREFFECT
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
        public float[] transform;
    }
    }
}



