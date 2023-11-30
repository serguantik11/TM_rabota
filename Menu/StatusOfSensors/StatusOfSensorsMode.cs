using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace TM_Simulator
{
    public partial class StatusOfSensorsMode : Form
    {
        private bool cl = true;
        public Button[] bt = new Button[60];
        public int X=43, Y=55;
        private string btn_txt;
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
                if (i!=14 && i!=30 && i!=32 && i!=36 && i!=37 && i!=38 && i!=48)
                {
                    bt[i] = new Button();
                    bt[i].Location = new Point(X, Y);
                    bt[i].Size = new Size(65, 65);
                    bt[i].Tag = i;
                    bt[i].Name = "btn" + i;
                    bt[i].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("status" + i);
                    bt[i].BackgroundImageLayout = ImageLayout.Zoom;
                    bt[i].Click += ButtonAllClick;
                    bt[i].MouseHover += ButtonAllHover;
                    bt[i].Enter += ButtonAllHover;
                    Controls.Add(bt[i]);
                }
                X += 70;
                if (i % 10 == 9)
                {
                    X = 43;
                    Y += 69;
                }
            }
        }


        private void ButtonAllClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button != null)
            {
                string t = Convert.ToString(button.Tag);
                MessageBox.Show(t);

            }
        }

        private void ButtonAllHover(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Focus();
            if (button != null)
            {
                switch (button.Tag)
                {
                    case 0:
                        btn_txt = "Аварийное давление масла в двигателе";
                        break;
                    case 1:
                        btn_txt = "Аварийная температура охлаждающей жидкости в двигателе";
                        break;
                    case 2:
                        btn_txt = "Засорен масляный фильтр двигателя";
                        break;
                    case 3:
                        btn_txt = "Аварийная температура масла в гидросистеме ходовой части";
                        break;
                    case 4:
                        btn_txt = "Аварийный уровень масла в маслобаке";
                        break;
                    case 5:
                        btn_txt = "Переливная секция гидроблока";
                        break;
                    case 6:
                        btn_txt = "Аварийная температура масла в гидросистеме силовых цилиндров";
                        break;
                    case 7:
                        btn_txt = "Бункер зерна заполнен на 70%";
                        break;
                    case 8:
                        btn_txt = "Бункер зерна полон";
                        break;
                    case 9:
                        btn_txt = "Засорен воздушный фильтр";
                        break;
                    case 10:
                        btn_txt = "Давление масла в двигателе";
                        break;
                    case 11:
                        btn_txt = "Температура охлаждающей жидкости в двигателе";
                        break;
                    case 12:
                        btn_txt = "Давление масла в гидросистеме силовых цилиндров";
                        break;
                    case 13:
                        btn_txt = "Температура масла в гидросистеме ходовой части";
                        break;
                    case 15:
                        btn_txt = "Уровень топлива в баке";
                        break;
                    case 16:
                        btn_txt = "Уровень топлива в баке меньше 10%";
                        break;
                    case 17:
                        btn_txt = "Засорен топливный фильтр";
                        break;
                    case 18:
                        btn_txt = "Засорен сливной фильтр гидросистемы силовых цилиндров";
                        break;
                }
                this.SensorName.Text = "Датчик: " + btn_txt;
            }


        }
    }
}
