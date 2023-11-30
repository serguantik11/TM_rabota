using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace TM_Simulator
{
    public partial class HelpPage : Form
    {
        private bool cl = true;
        private double background = 1;

        public HelpPage()
        {
            InitializeComponent();
            pictureBox.MouseWheel += new MouseEventHandler(pictureBox_MouseWheel);

            this.KeyPreview = true;
        }

        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            //if (e.Delta > 0)
            //{
            //    background -= 1;
            //    if (background == 0)
            //        background = 1;
            //    pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("help" + background);
            //}
            //else
            //{
            //    background += 1;
            //    if (background == 7)
            //        background = 6;
            //    pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("help" + background);
            //}
        }
        private void backmenu_Click(object sender, EventArgs e)
        {
            cl = false;
            SystemMenu sysmenu = new();
            sysmenu.Show();
            this.Close();
        }

        private void HelpPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void HelpPage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                backmenu_Click(this, e);
            }

            if (e.KeyCode == Keys.Down)
            {
                buttonDown_Click(this, e);
            }

            if (e.KeyCode == Keys.Up)
            {
                buttonUp_Click(this, e);
            }

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            background -= 1;
            if (background == 0)
                background = 1;
            pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("help" + background);
            page.Text = "Стр. " + background.ToString() + "/6";
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            background += 1;
            if (background == 7)
                background = 6;
            pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("help" + background);
            page.Text = "Стр. " + background.ToString() + "/6";
        }
    }
}
