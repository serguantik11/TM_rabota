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
    public partial class OperatingMode : Form
    {
        private bool cl = true;
        public PictureBox CultureBox = new PictureBox();

        public OperatingMode()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            TM_Simulator.Settings settings = new();
            settings.Show();
            this.Close();
        }

        private void OperatingMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(sender, e);

            }
        }

        private void OperatingMode_Load(object sender, EventArgs e)
        {
            cultureBox.SelectedIndex = StartPage.cultureImage;
            modeBox.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            ModeBox_SelectedIndexChanged(sender, e );

            CultureBox.BackgroundImageLayout = ImageLayout.Zoom;
            CultureBox.Image = StartPage.image;
            CultureBox.Location = new Point(0, 409);
            CultureBox.Name = "pictureBox1";
            CultureBox.Size = new Size(77, 62);
            CultureBox.TabStop = false;
            this.Controls.Add(CultureBox);
        }

        private void OperatingMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = StartPage.dateTime.ToString("HH:mm");
            date.Text = StartPage.dateTime.ToShortDateString();
        }

        private void CultureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            l0.Text = StartPage.culture[cultureBox.SelectedIndex, 0].ToString();
            l1.Text = StartPage.culture[cultureBox.SelectedIndex, 1].ToString();
            l2.Text = StartPage.culture[cultureBox.SelectedIndex, 2].ToString();
            l3.Text = StartPage.culture[cultureBox.SelectedIndex, 3].ToString();
            l4.Text = StartPage.culture[cultureBox.SelectedIndex, 4].ToString();
            l5.Text = StartPage.culture[cultureBox.SelectedIndex, 5].ToString();
            l6.Text = StartPage.culture[cultureBox.SelectedIndex, 6].ToString();
            StartPage.cultureImage = cultureBox.SelectedIndex;
            StartPage.image = (Image)Properties.Resources.ResourceManager.GetObject("culture" + StartPage.cultureImage);
            CultureBox.Image = StartPage.image;
        }
        private string[] name = { "Обороты молотильного барабана", "Зазор подбарабанья", "Обороты вентилятора очистки", "Верхние решета", "Нижние решета", "Потери по каналу очистка", "Потери по каналу соломотряса" };

        private void AllTextBoxEnter(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox != null)
            {
                NameEnter.Text = name[Convert.ToInt32(textBox.Tag)];
            }
        }

        private void AllTextBoxLeave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox != null)
            {
                NameEnter.Text = " ";
            }
        }

        private void ModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modeBox.SelectedIndex)
            {
                case 0:
                    {
                        label21.Text = label22.Text = "ОК";
                        DownText.Visible = true;
                    }
                    break;
                case 1:
                    {
                        label21.Text = label22.Text = "ОК";
                        DownText.Visible = true;
                    }
                    break;
                case 2:
                    {
                        label21.Text = label22.Text = "ждите";
                        DownText.Visible = false;
                    }
                    break;
            }
        }
    }
}
