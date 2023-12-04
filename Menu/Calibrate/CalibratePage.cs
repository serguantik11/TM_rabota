using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TM_Simulator.Menu.Calibrate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TM_Simulator
{
    public partial class CalibratePage : Form
    {
        private bool cl = true;

        public CalibratePage()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void backmenu_Click(object sender, EventArgs e)
        {
            cl = false;
            SystemMenu sysmenu = new();
            sysmenu.Show();
            this.Close();
        }

        private void CalibratePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void CalibratePage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                backmenu_Click(this, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm");
            date.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl = false;
            AllCalibrate allcalibrate = new();
            allcalibrate.CurrentPage = 1;
            allcalibrate.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cl = false;
            AllCalibrate allcalibrate = new();
            allcalibrate.CurrentPage = 2;
            allcalibrate.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cl = false;
            AllCalibrate allcalibrate = new();
            allcalibrate.CurrentPage = 3;
            allcalibrate.Show();
            this.Close();
        }
    }
}
