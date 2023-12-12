using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_Simulator.Menu.Settings
{
    public partial class TerminalSettings : Form
    {
        private bool check = false;
        private bool cl = true;

        public TerminalSettings()
        {
            InitializeComponent();
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            if (check)
            {
                check = false;
                checkBox.BackgroundImage = null;
                checkStatus.Text = "Выкл.";
            }
            else
            {
                check = true;
                checkBox.BackgroundImage = Properties.Resources.checkbox1;
                checkBox.BackgroundImageLayout = ImageLayout.Zoom;
                checkStatus.Text = "Вкл.";
            }
        }

        private void TerminalSettings_Load(object sender, EventArgs e)
        {
            time.Text = StartPage.dateTime.ToString("HH:mm");
            date.Text = StartPage.dateTime.ToShortDateString();
            timeH.Value = Convert.ToInt32(StartPage.dateTime.ToString("HH"));
            timeM.Value = Convert.ToInt32(StartPage.dateTime.ToString("mm"));
            dateD.Value = Convert.ToInt32(StartPage.dateTime.ToString("dd"));
            datem.Value = Convert.ToInt32(StartPage.dateTime.ToString("MM"));
            dateY.Value = Convert.ToInt32(StartPage.dateTime.ToString("yyyy"));
        }

        private void TerminalSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartPage.dateTime = new DateTime(Convert.ToInt32(dateY.Value), Convert.ToInt32(datem.Value), Convert.ToInt32(dateD.Value), Convert.ToInt32(timeH.Value), Convert.ToInt32(timeM.Value), 0);
            if (cl)
                Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            TM_Simulator.Settings settings = new();
            settings.Show();
            this.Close();
        }

        private void datem_ValueChanged(object sender, EventArgs e)
        {
            if (datem.Value == 1 || datem.Value == 3 || datem.Value == 5 || datem.Value == 7 || datem.Value == 8 || datem.Value == 10 || datem.Value == 12)
                dateD.Maximum = 31;
            if (datem.Value == 4 || datem.Value == 6 || datem.Value == 9 || datem.Value == 11)
            {
                if (dateD.Value == 31)
                    dateD.Value = 30;
                dateD.Maximum = 30;

            }
            if (datem.Value == 2)
            {
                if (dateD.Value > 28)
                    dateD.Value = 28;
                dateD.Maximum = 28;
                dateY_ValueChanged(this, e);
            }
            dateD.Refresh();
        }

        private void dateY_ValueChanged(object sender, EventArgs e)
        {
            if (datem.Value == 2)
            {
                if (dateY.Value % 4 == 0)
                    dateD.Maximum = 29;
                else
                    dateD.Maximum = 28;
            }
        }
    }
}
