using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TM_Simulator.Menu.Statistics;
using TM_Simulator.Статистика;

namespace TM_Simulator
{
    public partial class StatisticData : Form
    {
        private bool cl = true;

        public StatisticData()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            SystemMenu sysmenu = new();
            sysmenu.Show();
            this.Close();
        }

        private void StatisticData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void StatisticData_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = StartPage.dateTime.ToString("HH:mm");
            date.Text = StartPage.dateTime.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl = false;
            Statistic statistic = new();
            statistic.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cl = false;
            EmergencyStatistic estatistic = new();
            estatistic.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cl = false;
            EventLogPage eventlog = new();
            eventlog.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cl = false;
            TO maintenance = new();
            maintenance.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cl = false;
            MalfunctionsJ1939 malfunctionsJ1939 = new();
            malfunctionsJ1939.Show();
            this.Close();
        }
    }
}
