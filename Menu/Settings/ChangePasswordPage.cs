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
    public partial class ChangePasswordPage : Form
    {
        public string NamePage = "1";
        public ChangePasswordPage()
        {
            InitializeComponent();
        }



        private void ChangePasswordPage_Load(object sender, EventArgs e)
        {
            this.Text = "                                Смена пароля " + NamePage;
        }

        private void oldPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void newPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NamePage == "1" && StartPage.Password1 == oldPassword.Text)
            {
                StartPage.Password1 = newPassword.Text;
                this.Close();
                MessageBox.Show("Пароль успешно изменён!", "Сообщение", MessageBoxButtons.OK);

            }
            else
            {
                if (NamePage == "2" && StartPage.Password2 == oldPassword.Text)
                {
                    StartPage.Password2 = newPassword.Text;
                    this.Close();
                    MessageBox.Show("Пароль успешно изменён!", "Сообщение", MessageBoxButtons.OK);
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Был введен неправильный пароль!", "Ошибка", MessageBoxButtons.OK);
                }

            }
            this.Close();

        }
    }
}
