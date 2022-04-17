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
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
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
            adv_panel.Controls.Add(child_form);
            adv_panel.Tag = child_form;
            child_form.BringToFront();
            child_form.Show();
        }


        private void timer_Click(object sender, EventArgs e)
        {
            open_child_form(new Timer());
        }

        private void brightness_Click(object sender, EventArgs e)
        {
            open_child_form(new brightness());
        }

        private void bluelight_Click(object sender, EventArgs e)
        {
            open_child_form(new bluelight());
        }

        private void sleep_Click(object sender, EventArgs e)
        {
            open_child_form(new Sleep());
        }
    }
}
