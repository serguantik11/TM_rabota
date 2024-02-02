using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_Simulator.Menu.StatusOfSensors.StatusOfSensorsMode
{
    public partial class SensorsEngineerModePage : Form
    {
        private bool cl = true;
        public string PageName;
        public int Sensor;

        public SensorsEngineerModePage()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            cl = false;
            TM_Simulator.StatusOfSensorsMode sensmodeEng = new();
            sensmodeEng.Show();
            this.Close();
        }

        private void SensorsEngineerModePage_Load(object sender, EventArgs e)
        {
            BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(Sensor.ToString());
            //SensorsPicture.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("status" + Sensor);
            //SensorsName.Text = PageName;

        }

        private void SensorsEngineerModePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
                Application.Exit();
        }

        private void SensorsEngineerModePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }
        }


    }
}
