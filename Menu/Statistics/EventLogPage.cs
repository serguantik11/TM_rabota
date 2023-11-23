﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_Simulator.Menu.Statistics
{
    public partial class EventLogPage : Form
    {
        private int max = 1;
        private bool cl = true;
        public EventLogPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            max += 1;
            progressBar1.PerformStep();

            if (max == 30)
                progressBar1.Visible = false;
            time.Text = DateTime.Now.ToString("HH:mm");
            date.Text = DateTime.Now.ToShortDateString();
        }

        private void EventLogPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            StatisticData statisticdata = new();
            statisticdata.Show();
            this.Close();
        }

        private void back_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }
    }
}
