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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace TM_Simulator.Menu.StatusOfSensors.StatusOfSensorsMode
{
    public partial class SensorsModePage : Form
    {
        private bool cl = true;
        public int btn;

        public SensorsModePage()
        {
            InitializeComponent();

        }

        private void SensorsMode_Load(object sender, EventArgs e)
        {
            if (btn == 28 || btn == 29 || btn == 39 || btn == 42 || btn == 41 || btn == 40)
            {
                buttonOfControl.Visible = false;
            }

            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("sensorhelp" + btn);
            if (!StartPage.controlstatus[btn])
            {
                buttonOfControl.Text = "Поставить на контроль";
            }
            else
            {
                buttonOfControl.Text = "Снять с контроля";
            }
        }

        private void SensorsMode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }

        private void SensorsMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
                Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            TM_Simulator.StatusOfSensorsMode sensorsmode = new();
            sensorsmode.Show();
            this.Close();
        }

        private void buttonOfControl_Click(object sender, EventArgs e)
        {
            if (!StartPage.controlstatus[btn])
            { 
                DialogResult dr = MessageBox.Show("Поставить на контроль?", "СООБЩЕНИЕ", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    StartPage.controlstatus[btn]=true;
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Снять с контроля?", "СООБЩЕНИЕ", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    StartPage.controlstatus[btn]=false;
                }
            }
            SensorsMode_Load(this, e);
        }
    }
}
