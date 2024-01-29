using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TM_Simulator.Menu
{
    public partial class CopyPage : Form
    {
        private bool cl = true;
        public string NamePageString;
        public CopyPage()
        {
            InitializeComponent();
        }

        private void CopyMenu_Load(object sender, EventArgs e)
        {
            NamePage.Text = NamePageString;


            PictureBox CultureBox = new PictureBox();
            CultureBox.BackgroundImageLayout = ImageLayout.Zoom;
            CultureBox.Image = StartPage.image;
            CultureBox.Location = new Point(0, 600);
            CultureBox.Size = new Size(105, 85);
            CultureBox.TabStop = false;
            this.Controls.Add(CultureBox);
        }

        private void CopyMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Back_Click(this, e);
            }
        }

        private void CopyMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        //подключение ФЛЕШКИ
        protected override void WndProc(ref Message m)
        {
            const int WM_DEVICECHANGE = 0x0219;

            const int ADD_DEVICE = 0x8000;

            const int REMOVE_DEVICE = 0x8004;

            if (m.Msg == WM_DEVICECHANGE)
            {
                switch ((int)m.WParam)
                {
                    case ADD_DEVICE:
                        StartPage.USB = true;
                        break;
                    case REMOVE_DEVICE:
                        StartPage.USB = false;
                        break;
                }
            }
            base.WndProc(ref m); // Переопределение оконной процедуры
        }

        private int value = 1;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (StartPage.USB)
            {
                FinalError.Visible = false;
                value += 1;
                progressBar1.PerformStep();
                if (value == progressBar1.Maximum + 10)
                {
                    Final.Visible = true;
                }
            }
            else
            {
                value = 1;
                progressBar1.Value = 0;
                Final.Visible = false;
                FinalError.Text = "Подключите съёмный носитель!";
                FinalError.ForeColor = Color.Red;
                FinalError.Visible = true;
            }

            time.Text = StartPage.dateTime.ToString("HH:mm");
            date.Text = StartPage.dateTime.ToShortDateString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            cl = false;
            TM_Simulator.Menu.CopyMenu.CopyMenu copyMenu = new();
            copyMenu.Show();
            this.Close();
        }
    }
}
