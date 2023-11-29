using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_Simulator
{
    public partial class StatusOfSensorsMode : Form
    {
        private bool cl = true;
        public Button[] bt = new Button[60];
        public int X=40, Y=40;
        public StatusOfSensorsMode()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            StatusOfSensorsPage sensmenu = new();
            sensmenu.Show();
            this.Close();
        }

        private void StatusOfSensors_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
                Application.Exit();
        }

        private void StatusOfSensors_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }

        private void StatusOfSensorsMode_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < bt.Length; i++)
            {

                bt[i] = new Button();
                bt[i].Location = new Point(X,Y);
                bt[i].Size = new Size(60, 60);
                bt[i].Tag = i;
                bt[i].Name = "btn" + i;
                bt[i].Text = "Кнопка " + i;
                bt[i].Click += ButtonAllClick;
                Controls.Add(bt[i]);
                X += 65;
                if (i % 10 == 9)
                {
                    X = 40;
                    Y += 65;
                }

            }
        }
        private void ButtonAllClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button != null)
            {
                string t = Convert.ToString(button.TabIndex);
                MessageBox.Show(t);

            }
        }
    }
}
