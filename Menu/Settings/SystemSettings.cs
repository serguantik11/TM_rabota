﻿using System;
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
    public partial class SystemSettings : Form
    {
        private bool cl = true;
        public SystemSettings()
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
            TM_Simulator.Settings settings = new();
            settings.Show();
            this.Close();
        }

        private void SystemSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }

        private void SystemSettings_Load(object sender, EventArgs e)
        {

        }

        private void SystemSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }
    }
}