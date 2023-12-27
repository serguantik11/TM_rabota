using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_Simulator.Menu.CopyMenu
{
    public partial class CopyMenu : Form
    {
        private bool cl = true;

        public CopyMenu()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time.Text = StartPage.dateTime.ToString("HH:mm");
            date.Text = StartPage.dateTime.ToShortDateString();
        }

        private void CopyMenu_Load(object sender, EventArgs e)
        {
            PictureBox CultureBox = new PictureBox();
            CultureBox.BackgroundImageLayout = ImageLayout.Zoom;
            CultureBox.Image = StartPage.image;
            CultureBox.Location = new Point(0, 409);
            CultureBox.Name = "pictureBox";
            CultureBox.Size = new Size(77, 62);
            CultureBox.TabStop = false;
            this.Controls.Add(CultureBox);
        }

        private void CopyMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void CopyMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Back_Click(this, e);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            cl = false;
            TM_Simulator.SystemMenu sysMenu = new();
            sysMenu.Show();
            this.Close();
        }

        private void FuelConsumption_Click(object sender, EventArgs e)
        {
            cl = false;
            TM_Simulator.Menu.CopyPage copyPage = new();
            copyPage.NamePageString = "КОПИРОВАНИЕ РАСХОДА ТОПЛИВА";
            copyPage.Show();
            this.Close();
        }

        private void EventLog_Click(object sender, EventArgs e)
        {
            cl = false;
            TM_Simulator.Menu.CopyPage copyPage = new();
            copyPage.NamePageString = "КОПИРОВАНИЕ ЖУРНАЛА СОБЫТИЙ";
            copyPage.Show();
            this.Close();
        }
    }
}
