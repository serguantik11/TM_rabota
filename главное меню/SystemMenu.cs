﻿using System;
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
    public partial class SystemMenu : Form
    {
        private bool cl = true;

        public SystemMenu()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        private void SystemMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
                Application.Exit();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            cl = false;
            Settings f3 = new();
            f3.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            TittlePage tittle = new();
            tittle.Show();
            this.Close();

        }

        private void statisticdata_Click(object sender, EventArgs e)
        {
            cl = false;
            StatisticData statisticdata = new();
            statisticdata.Show();
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
            cl = false;
            HelpPage helppage = new();
            helppage.Show();
            this.Close();
        }

        private void kalibratepage_Click(object sender, EventArgs e)
        {
            cl = false;
            CalibratePage calibratepage = new();
            calibratepage.Show();
            this.Close();
        }

        private void SystemMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }
    }
}
