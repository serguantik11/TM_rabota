using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public bool cl = true;

        public Settings()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        // ПОДКЛЮЧЕНИЕ ТАЙМЕРА
        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            PictureBox CultureBox = new PictureBox();
            CultureBox.BackgroundImageLayout = ImageLayout.Zoom;
            CultureBox.Image = StartPage.image;
            CultureBox.Location = new Point(0, 409);
            CultureBox.Name = "pictureBox1";
            CultureBox.Size = new Size(77, 62);
            CultureBox.TabStop = false;
            this.Controls.Add(CultureBox);
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
            time.Text = StartPage.dateTime.ToString("HH:mm");
            date.Text = StartPage.dateTime.ToShortDateString();
            if (StartPage.PasswordVerification[0])
            {

                switch (StartPage.Menu)
                {
                    case "SysMenu 1":
                        {
                            cl = false;
                            TM_Simulator.Menu.Settings.SystemSettings systemsettings = new();
                            systemsettings.Show();
                            this.Close();
                        }
                        break;
                    case "SysMenu 2":
                        {
                            cl = false;
                            TM_Simulator.Menu.Settings.SystemSettings2 systemsettings2 = new();
                            systemsettings2.Show();
                            this.Close();
                        }
                        break;
                }
                StartPage.PasswordVerification[0] = false;
            }


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

        private void systemsettings_Click(object sender, EventArgs e)
        {
            StartPage.Menu = "SysMenu 1";
            StartPage.Password = 1;
            TM_Simulator.Menu.Settings.PasswordEnter passEnter = new();
            passEnter.ShowDialog();
        }

        private void systemsettings2_Click(object sender, EventArgs e)
        {
            StartPage.Menu = "SysMenu 2";
            StartPage.Password = 1;
            TM_Simulator.Menu.Settings.PasswordEnter passEnter = new();
            passEnter.ShowDialog();
        }

        private void terminalsettings_Click(object sender, EventArgs e)
        {
            cl = false;
            TM_Simulator.Menu.Settings.TerminalSettings terminalSettings = new();
            terminalSettings.Show();
            this.Close();
        }

        private void Operatingmode_Click(object sender, EventArgs e)
        {
            cl = false;
            TM_Simulator.Menu.Settings.OperatingMode operatingMode = new();
            operatingMode.Show();
            this.Close();
        }
    }
}
