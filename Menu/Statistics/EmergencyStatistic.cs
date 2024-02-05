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
using System.Runtime.InteropServices;

namespace TM_Simulator.Статистика
{
    public partial class EmergencyStatistic : Form
    {

        private bool cl = true;

        public EmergencyStatistic()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = StartPage.dateTime.ToString("HH:mm");
            date.Text = StartPage.dateTime.ToShortDateString();
        }

        private void EmergencyStatistic_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            StatisticData statistic = new();
            statistic.Show();
            this.Close();
        }
        [DllImport("user32.dll", SetLastError = true)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        private void EmergencyStatistic_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
            Cursor.Position = new Point(this.Location.X + 600, this.Location.Y + 400);
            //PictureBox box1 = new();
            //box1.Location = new Point(0, Y);
            //box1.Width = 700;
            //box1.Height = 1200;
            //box1.Image = (Image)Properties.Resources.ResourceManager.GetObject("emstatistic");
            //box1.SizeMode = PictureBoxSizeMode.Zoom;
            // эмуляция скролла по нажатию клавиатуры
            if (e.KeyCode == Keys.Down)
            {

                int u = -100;
                //Y = Y - 63;

                //panel1.Controls.Add(box1);//панель в которую заносится изображение
                mouse_event((uint)MouseEventFlags.MouseWheel, 0, 0, unchecked((uint)u), 0);
                //box1.BringToFront();
                //box1.Refresh();
            }
            if (e.KeyCode == Keys.Up)
            {
                int u = 100;
                //Y = Y + 63;
                //panel1.Controls.Add(box1);//панель в которую заносится изображение
                mouse_event((uint)MouseEventFlags.MouseWheel, 0, 0, unchecked((uint)u), 0);
                //box1.BringToFront();
                //box1.Refresh();
            }

        }
        // установка флагов для эмуляции скролла
        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010,
            MouseWheel = 0x0800
        }
        //вывод и скролл грёбаной картинки
        private void EmergencyStatistic_Load(object sender, EventArgs e)
        {
            Cursor.Position = new Point(this.Location.X + 600, this.Location.Y + 400);
            PictureBox box1 = new();
            box1.Location = new Point(0, -15);
            box1.Width = 1080;
            box1.Height = 1900;
            box1.Image = (Image)Properties.Resources.ResourceManager.GetObject("emstatistic");
            box1.SizeMode = PictureBoxSizeMode.Zoom;
            panel1.Controls.Add(box1);//панель в которую заносится изображение
                                      //if (Y != 0)
                                      //{
                                      //    box1.Dispose();
                                      //}
            PictureBox CultureBox = new PictureBox();
            CultureBox.BackgroundImageLayout = ImageLayout.Zoom;
            CultureBox.Image = StartPage.image;
            CultureBox.Location = new Point(0, 600);
            CultureBox.Size = new Size(105, 85);
            CultureBox.TabStop = false;
            this.Controls.Add(CultureBox);

        }
       
    }
}
