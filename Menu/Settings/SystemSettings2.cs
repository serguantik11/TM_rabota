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
    public partial class SystemSettings2 : Form
    {
        private bool cl = true;
        public SystemSettings2()
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

        private void SystemSettings2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }

        private void SystemSettings2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void SystemSettings2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = StartPage.SystemSettings2Item[0];
            comboBox2.SelectedIndex = StartPage.SystemSettings2Item[1];
            comboBox3.SelectedIndex = StartPage.SystemSettings2Item[2];

            PictureBox CultureBox = new PictureBox();
            CultureBox.BackgroundImageLayout = ImageLayout.Zoom;
            CultureBox.Image = StartPage.image;
            CultureBox.Location = new Point(0, 409);
            CultureBox.Name = "pictureBox1";
            CultureBox.Size = new Size(77, 62);
            CultureBox.TabStop = false;
            this.Controls.Add(CultureBox);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = StartPage.dateTime.ToString("HH:mm");
            date.Text = StartPage.dateTime.ToShortDateString();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartPage.SystemSettings2Item[1] = comboBox2.SelectedIndex;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartPage.SystemSettings2Item[0] = comboBox1.SelectedIndex;
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartPage.SystemSettings2Item[2] = comboBox3.SelectedIndex;
        }
    }
}
