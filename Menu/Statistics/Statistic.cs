using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_Simulator
{
    public partial class Statistic : Form
    {
        private bool cl = true;
        public Statistic()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            StatisticData statisticdata = new();
            statisticdata.Show();
            this.Close();
        }

        private void Statistic_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void Statistic_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm");
            date.Text = DateTime.Now.ToShortDateString();
        }

        private void zerostatus_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ОБНУЛИТЬ текущие значения?",
                      "СООБЩЕНИЕ", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                label11.Text = " 0";
                label12.Text = " 0";
                label13.Text = " 0";
                label14.Text = " 0";
                label21.Text = " 0";
                label22.Text = " 0";
                label23.Text = " 0";
                label24.Text = " 0";
            }

        }
    }
}
