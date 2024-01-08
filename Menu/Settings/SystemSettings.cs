using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            time.Text = StartPage.dateTime.ToString("HH:mm");
            date.Text = StartPage.dateTime.ToShortDateString();
            if (StartPage.PasswordVerification[1])
            {
                switch (StartPage.Menu)
                {
                    case "Default":
                        {
                            StartPage.PasswordVerification[1] = false;
                            DialogResult dr = MessageBox.Show("Выполнить сброс до заводских установок?", "СООБЩЕНИЕ", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                StartPage.defaulttMode = true;
                            }
                        }
                        break;
                    case "Btn1":
                        {
                            StartPage.PasswordVerification[1] = false;
                            MessageBox.Show("Суммарные значения сброшены!", "СООБЩЕНИЕ", MessageBoxButtons.OK);
                        }
                        break;
                    case "Btn2":
                        {
                            StartPage.PasswordVerification[1] = false;
                            MessageBox.Show("Аварийная статистика сброшена!", "СООБЩЕНИЕ", MessageBoxButtons.OK);
                        }
                        break;
                }

            }
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

            PictureBox CultureBox = new PictureBox();
            CultureBox.BackgroundImageLayout = ImageLayout.Zoom;
            CultureBox.Image = StartPage.image;
            CultureBox.Location = new Point(0, 409);
            CultureBox.Name = "pictureBox1";
            CultureBox.Size = new Size(77, 62);
            CultureBox.TabStop = false;
            this.Controls.Add(CultureBox);

            combineType.SelectedIndex = StartPage.SystemSettings1Item[0];
            harvesterType.SelectedIndex = StartPage.SystemSettings1Item[1];
            engineType.SelectedIndex = StartPage.SystemSettings1Item[2];
            fuelSensor.SelectedIndex = StartPage.SystemSettings1Item[3];
        }

        private void SystemSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void ChangePassword1_Click(object sender, EventArgs e)
        {
            ChangePasswordPage changePasswordPage = new();
            changePasswordPage.NamePage = "1";
            changePasswordPage.ShowDialog();
        }

        private void ChangePassword2_Click(object sender, EventArgs e)
        {
            ChangePasswordPage changePasswordPage = new();
            changePasswordPage.NamePage = "2";
            changePasswordPage.ShowDialog();
        }

        private void DefaultSettingsbutton_Click(object sender, EventArgs e)
        {
            StartPage.Menu = "Default";
            TM_Simulator.Menu.Settings.PasswordEnter passEnter = new();
            StartPage.Password = 2;
            passEnter.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartPage.Menu = "Btn1";
            TM_Simulator.Menu.Settings.PasswordEnter passEnter = new();
            StartPage.Password = 2;
            passEnter.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartPage.Menu = "Btn2";
            TM_Simulator.Menu.Settings.PasswordEnter passEnter = new();
            StartPage.Password = 2;
            passEnter.ShowDialog();
        }

        private void CombineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartPage.SystemSettings1Item[0] = combineType.SelectedIndex;
        }

        private void HarvesterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartPage.SystemSettings1Item[1] = harvesterType.SelectedIndex;
        }

        private void EngineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartPage.SystemSettings1Item[2] = engineType.SelectedIndex;
        }

        private void FuelSensor_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartPage.SystemSettings1Item[3] = fuelSensor.SelectedIndex;
        }
    }
}
