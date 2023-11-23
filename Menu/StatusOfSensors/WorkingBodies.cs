using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_Simulator.Menu.StatusOfSensors
{
    public partial class WorkingBodies : Form
    {
        private bool cl = true;
        public WorkingBodies()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm");
            date.Text = DateTime.Now.ToShortDateString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            StatusOfSensorsPage sensmenu = new();
            sensmenu.Show();
            this.Close();
        }

        private void WorkingBodies_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }

        private void WorkingBodies_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
                Application.Exit();
        }
    }
}
