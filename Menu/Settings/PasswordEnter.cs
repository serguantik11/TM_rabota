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
    public partial class PasswordEnter : Form
    {
        
        
        public PasswordEnter()
        {
            InitializeComponent();
        }

        private void PasswordEnter_Load(object sender, EventArgs e)
        {
            this.Text = "                         Введите пароль " + StartPage.Password.ToString();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (StartPage.Password == 1 && PasswordField.Text == StartPage.Password1)
            {
                StartPage.PasswordVerification[0] = true;
                this.Close();
            }
            else
            {
                if (StartPage.Password == 2 && PasswordField.Text == StartPage.Password2)
                {
                    StartPage.PasswordVerification[1] = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Был введен неправильный пароль!", "Ошибка", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void PasswordField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 16)
            {
                e.Handled = true;
            }
        }
    }
}
