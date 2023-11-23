using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TM_Simulator.Menu.StatusOfSensors;

namespace TM_Simulator
{
    public partial class StatusOfSensorsPage : Form
    {
        private bool cl = true;

        public StatusOfSensorsPage()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            SystemMenu sysmenu = new();
            sysmenu.Show();
            this.Close();
        }

        private void StatusOfSensors_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }

        private void StatusOfSensors_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
                Application.Exit();
        }

        private void workingbodiesbutton_Click(object sender, EventArgs e)
        {
            cl = false;
            WorkingBodies workbodies = new();
            workbodies.Show();
            this.Close();
        }

        private void sensstatusbutton_Click(object sender, EventArgs e)
        {
            cl = false;
            StatusOfSensorsMode sensmode = new();
            sensmode.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm");
            date.Text = DateTime.Now.ToShortDateString();
        }
    }
}
