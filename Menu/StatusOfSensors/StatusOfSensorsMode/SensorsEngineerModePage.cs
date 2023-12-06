using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            TM_Simulator.StatusOfSensorsMode sensmode = new();
            sensmode.Show();
            this.Close();
        }

        private void SensorsEngineerModePage_Load(object sender, EventArgs e)
        {
            AddModes();
            AddSensors();
            SensorsPicture.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("status" + Sensor);
            SensorsName.Text = PageName;

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






        public void AddModes()
        {
            modes[0].SensorItem = "ADS";
            modes[0].ZeroCount = "0000";
            modes[1].SensorItem = "LEVEL";
            modes[1].ZeroCount = "0000";
            modes[2].SensorItem = "ON off";
            modes[2].ZeroCount = "00000000";
            modes[3].SensorItem = "Up dn";
            modes[3].ZeroCount = "00000000";
            modes[4].SensorItem = "STATUS";
            modes[4].ZeroCount = "00000000";
            modes[5].SensorItem = "T*200ms";
            modes[5].ZeroCount = "0000";
            modes[6].SensorItem = "TIME ON";
            modes[6].ZeroCount = "0000";
            modes[7].SensorItem = "IF chan";
            modes[7].ZeroCount = "000";
            modes[8].SensorItem = "IF DATA";
            modes[8].ZeroCount = "0000";
            modes[9].SensorItem = "ERR up";
            modes[9].ZeroCount = "0000";
            modes[10].SensorItem = "ERR dn";
            modes[10].ZeroCount = "0000";
            modes[11].SensorItem = "NOW";
            modes[11].ZeroCount = "0000";
            modes[12].SensorItem = "SUM*200";
            modes[12].ZeroCount = "0000";
            modes[13].SensorItem = "D_pulse";
            modes[13].ZeroCount = "0000";
            modes[14].SensorItem = "D_HZ";
            modes[14].ZeroCount = "0000";
            modes[15].SensorItem = "D_RPM";
            modes[15].ZeroCount = "0000";
            modes[16].SensorItem = "1s hz";
            modes[16].ZeroCount = "0000";
            modes[17].SensorItem = "CA_RPM";
            modes[17].ZeroCount = "0000";
            modes[18].SensorItem = "CA K";
            modes[18].ZeroCount = "0000";
            modes[19].SensorItem = "%%%%";
            modes[19].ZeroCount = "0000";
            modes[20].SensorItem = "PROSKAL";
            modes[20].ZeroCount = "00000000";
            modes[21].SensorItem = "K*0.001";
            modes[21].ZeroCount = "0000";
            modes[22].SensorItem = "LO RPM";
            modes[22].ZeroCount = "0000";
            modes[23].SensorItem = "tms*100";
            modes[23].ZeroCount = "000";
            modes[24].SensorItem = "POINTS";
            modes[24].ZeroCount = "0000";
            modes[25].SensorItem = "TIME s";
            modes[25].ZeroCount = "0000";
            modes[26].SensorItem = "T*3ms";
            modes[26].ZeroCount = "0000";
            modes[27].SensorItem = "ton*3ms";
            modes[27].ZeroCount = "0000";

        }

        public void AddSensors()
        {
            public int[] sensors = new int[60][]
            {
        //    sensors[0] {0, 1, 2, 3, 4, 5, 6, 7, 8};
        //sensors[1]= [];
        //    sensors[2]= [];
        //    sensors[3]= [];
        //    sensors[4]= [];
        //    sensors[5]= [];
        //    sensors[6]= [];
        //    sensors[7]= [];
        //    sensors[8]= [];
        //    sensors[9]= [];
        //    sensors[10]= [];
        //    sensors[11]= [];
        //    sensors[12]= [];
        //    sensors[13]= [];
        //    sensors[15]= [];
        //    sensors[16]= [];
        //    sensors[17]= [];
        //    sensors[18]= [];
        //    sensors[19]= [];
        //    sensors[20]= [];
        //    sensors[21]= [];
        //    sensors[22]= [];
        //    sensors[23]= [];
        //    sensors[24]= [];
        //    sensors[25]= [];
        //    sensors[26]= [];
        //    sensors[27]= [];
        //    sensors[28]= [];
        //    sensors[29]= [];
        //    sensors[31]= [];
        //    sensors[33]= [];
        //    sensors[34]= [];
        //    sensors[35]= [];
        //    sensors[39]= [];
        //    sensors[40]= [];
        //    sensors[41]= [];
        //    sensors[42]= [];
        //    sensors[43]= [];
        //    sensors[44]= [];
        //    sensors[45]= [];
        //    sensors[46]= [];
        //    sensors[47]= [];
        //    sensors[49]= [];
        //    sensors[50]= [];
        //    sensors[51]= [];
        //    sensors[52]= [];
        //    sensors[53]= [];
        //    sensors[54]= [];
        //    sensors[55]= [];
        //    sensors[56]= [];
        //    sensors[57]= [];
        //    sensors[58]= [];
        //    sensors[59]= [];
            };
        }


        // создание массива структур
        public struct Mode
        {
            public string SensorItem;
            public string ZeroCount;
            //public int ColumsCount;

        }
        public Mode[] modes = new Mode[60];

        

    }
}
