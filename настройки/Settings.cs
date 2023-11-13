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
    public partial class Settings : Form
    {
        private bool cl = true;
        public Settings()
        {
            InitializeComponent();
        }
        // ПОДКЛЮЧЕНИЕ ТАЙМЕРА
        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        // НАЗАД
        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            SystemMenu sysmenu = new SystemMenu();
            sysmenu.Show();
            this.Close();
        }

        // ВЫВОД ВРЕМЕНИ
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        // НАСТРОЙКИ КОМБАЙНА
        private void combinesettings_Click(object sender, EventArgs e)
        {
            cl = false;
            CombineSettings form4 = new CombineSettings();
            form4.Show();
            this.Close();
        }
    }
}
