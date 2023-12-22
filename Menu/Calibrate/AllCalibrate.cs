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
using System.Threading;

namespace TM_Simulator.Menu.Calibrate
{
    public partial class AllCalibrate : Form
    {
        private bool cl = true;
        public int CurrentPage;
        public int currentvalue = 1000;

        public AllCalibrate()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            CalibratePage calibratepage = new();
            calibratepage.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = StartPage.dateTime.ToString("HH:mm");
            date.Text = StartPage.dateTime.ToShortDateString();
        }

        private void AllCalibrate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }

        private void AllCalibrate_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentvalue = 1000;
            if (cl)
            {
                Application.Exit();
            }

        }

        private void AllCalibrate_Load(object sender, EventArgs e)
        {
            currentvaluecalibratepage.Text = currentvalue.ToString();
            switch (CurrentPage)
            {
                case 1:
                    {
                        namepage.Text = "ЗАЗОР ПОДБАРАБАНЬЯ";
                        minvalue.Text = StartPage.drumminggap[0].ToString();
                        maxvalue.Text = StartPage.drumminggap[1].ToString();
                    }
                    break;
                case 2:
                    {
                        namepage.Text = "     НИЖНИЕ РЕШЕТА";
                        minvalue.Text = StartPage.lowersieves[0].ToString();
                        maxvalue.Text = StartPage.lowersieves[1].ToString();
                    }
                    break;
                case 3:
                    {
                        namepage.Text = "     ВЕРХНИЕ РЕШЕТА";
                        minvalue.Text = StartPage.uppersieves[0].ToString();
                        maxvalue.Text = StartPage.uppersieves[1].ToString();
                    }
                    break;
                

            }
            PictureBox CultureBox = new PictureBox();
            CultureBox.BackgroundImageLayout = ImageLayout.Zoom;
            CultureBox.Image = StartPage.image;
            CultureBox.Location = new Point(0, 409);
            CultureBox.Name = "pictureBox1";
            CultureBox.Size = new Size(77, 62);
            CultureBox.TabStop = false;
            this.Controls.Add(CultureBox);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            currentvalue -= 10;
            if (currentvalue <= 0)
                currentvalue = 0;
            currentvaluecalibratepage.Text = currentvalue.ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            currentvalue += 10;
            if (currentvalue >= 3000)
                currentvalue = 3000;
            currentvaluecalibratepage.Text = currentvalue.ToString();
        }

        private void savemin_Click(object sender, EventArgs e)
        {
            minvalue.Text = currentvalue.ToString();
        }

        private void savemax_Click(object sender, EventArgs e)
        {
            maxvalue.Text = currentvalue.ToString();
        }

        private void saveAll_Click(object sender, EventArgs e)
        {

            switch (CurrentPage)
            {
                case 1:
                    {
                        StartPage.drumminggap[0] = Convert.ToInt32(minvalue.Text);
                        StartPage.drumminggap[1] = Convert.ToInt32(maxvalue.Text);
                    }
                    break;
                case 2:
                    {
                        StartPage.lowersieves[0] = Convert.ToInt32(minvalue.Text);
                        StartPage.lowersieves[1] = Convert.ToInt32(maxvalue.Text);
                    }
                    break;
                case 3:
                    {
                        StartPage.uppersieves[0] = Convert.ToInt32(minvalue.Text);
                        StartPage.uppersieves[1] = Convert.ToInt32(maxvalue.Text);
                    }
                    break;
            }
            MessageBox.Show("Калибровка выполнена успешно", "ИНФОРМАЦИЯ", MessageBoxButtons.OK);
        }
    }
}
