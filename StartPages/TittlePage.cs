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

namespace TM_Simulator
{

    public partial class TittlePage : Form
    {
        private bool cl = true;
        private int background = 1;
        public TittlePage()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            cl = false;
            SystemMenu sysmenu = new();
            sysmenu.Show();
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
                Application.Exit();
        }
        // переключение страниц главного экрана
        private void TittlePage_Click(object sender, EventArgs e)
        {
            background += 1;
            switch (background)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.MainScreen;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.MainScreen2;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.MainScreen3;
                    background = 0;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = StartPage.dateTime.ToString("HH:mm");
            date.Text = StartPage.dateTime.ToShortDateString();
        }

        private void TittlePage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TittlePage_Click(this, e);
            }

            if (e.KeyCode == Keys.Left)
            {
                switch (background)
                {
                    case 1: background = 2; break;
                    case 2: background = 0; break;
                    case 0: background = 1; break;
                }
                TittlePage_Click(this, e);
            }
        }

        private void TittlePage_Load(object sender, EventArgs e)
        {
            PictureBox CultureBox = new PictureBox();
            CultureBox.BackgroundImageLayout = ImageLayout.Zoom;
            CultureBox.Image = StartPage.image;
            CultureBox.Location = new Point(0, 409);
            CultureBox.Name = "pictureBox1";
            CultureBox.Size = new Size(77, 62);
            CultureBox.TabStop = false;
            this.Controls.Add(CultureBox);
        }
    }
}