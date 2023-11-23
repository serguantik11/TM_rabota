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
            this.KeyPreview = true;
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
            SystemMenu sysmenu = new();
            sysmenu.Show();
            this.Close();
        }

        // ВЫВОД ВРЕМЕНИ
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm");
            date.Text = DateTime.Now.ToShortDateString();
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
            CombineSettings form4 = new();
            form4.Show();
            this.Close();
        }

        private void Settings_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }
    }
}
