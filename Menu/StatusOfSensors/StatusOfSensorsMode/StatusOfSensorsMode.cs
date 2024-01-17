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
using TM_Simulator.Menu.StatusOfSensors.StatusOfSensorsMode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace TM_Simulator
{
    public partial class StatusOfSensorsMode : Form
    {
        private bool cl = true;
        public Button[] bt = new Button[60];
        public static string[] SensorsName = new string[60];
        public int X = 43, Y = 55;
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

        private void StatusOfSensors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                back_Click(this, e);
            }

            if (e.KeyCode == Keys.E)
            {
                this.EngineerModeBtn_Click(this, e);
            }



        }

        private void EngineerModeBtn_Click(object sender, EventArgs e)
        {
            if (StartPage.EngineerMode)
            {
                    StartPage.EngineerMode = false;
                    PageName.Text = "СОСТОЯНИЕ ДАТЧИКОВ";
                    PageName.ForeColor = Color.Black;
            }
            else
            {
                    StartPage.EngineerMode = true;
                    PageName.Text = "СОСТОЯНИЕ ДАТЧИКОВ  <ENGINEER MODE>";
                    PageName.ForeColor = Color.Lime;
            }
        }

        private void StatusOfSensorsMode_Load(object sender, EventArgs e)
        {
            if (StartPage.EngineerMode)
            {
                PageName.Text = "СОСТОЯНИЕ ДАТЧИКОВ  <ENGINEER MODE>";
                PageName.ForeColor = Color.Lime;
            }
            else
            {
                PageName.Text = "СОСТОЯНИЕ ДАТЧИКОВ";
                PageName.ForeColor = Color.Black;
            }
            for (int i = 0; i < bt.Length; i++)
            {
                if (i != 14 && i != 30 && i != 32 && i != 36 && i != 37 && i != 38 && i != 48)
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
            for (int a = 0; a < 60; a++)
            {
                switch (a)
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
                    case 19:
                        btn_txt = "Засорен напорный фильтр гидросистемы силовых цилиндров";
                        break;
                    case 20:
                        btn_txt = "Копнитель заполнен на 75%";
                        break;
                    case 21:
                        btn_txt = "Зазор подбарабанья";
                        break;
                    case 22:
                        btn_txt = "Аварийный уровень охлаждающей жидкости двигателя";
                        break;
                    case 23:
                        btn_txt = "Датчик скорости движения";
                        break;
                    case 24:
                        btn_txt = "Включен привод выгрузного шнека при сложенной выгрузной трубе";
                        break;
                    case 25:
                        btn_txt = "Открыт вход в зерновой бункер";
                        break;
                    case 26:
                        btn_txt = "Положение верхних решет";
                        break;
                    case 27:
                        btn_txt = "Положение нижних решет";
                        break;
                    case 28:
                        btn_txt = "Включение дальнего света";
                        break;
                    case 29:
                        btn_txt = "Датчик положения наклонной камеры";
                        break;
                    case 31:
                        btn_txt = "Забивание соломотряса";
                        break;
                    case 33:
                        btn_txt = "Потери по каналу соломотряса";
                        break;
                    case 34:
                        btn_txt = "Потери по каналу очистка";
                        break;
                    case 35:
                        btn_txt = "Аккумуляторная батарея";
                        break;
                    case 39:
                        btn_txt = "Включение стояночного тормоза";
                        break;
                    case 40:
                        btn_txt = "Обороты двигателя";
                        break;
                    case 41:
                        btn_txt = "Обороты молотильного барабана";
                        break;
                    case 42:
                        btn_txt = "Обороты вентилятора очистки";
                        break;
                    case 43:
                        btn_txt = "Обороты барабана измельчителя";
                        break;
                    case 44:
                        btn_txt = "Обороты вала соломотряса";
                        break;
                    case 45:
                        btn_txt = "Обороты колосового шнека";
                        break;
                    case 46:
                        btn_txt = "Обороты зернового шнека";
                        break;
                    case 47:
                        btn_txt = "Обороты соломосепаратора";
                        break;
                    case 49:
                        btn_txt = "Обороты вала копнителя";
                        break;
                    case 50:
                        btn_txt = "Увеличение оборотов молотильного барабана";
                        break;
                    case 51:
                        btn_txt = "Снижение оборотов молотильного барабана";
                        break;
                    case 52:
                        btn_txt = "Увеличение оборотов вентилятора очистки";
                        break;
                    case 53:
                        btn_txt = "Снижение оборотов вентилятора очистки";
                        break;
                    case 54:
                        btn_txt = "Увеличение зазора подбарабанья";
                        break;
                    case 55:
                        btn_txt = "Уменьшение зазора подбарабанья";
                        break;
                    case 56:
                        btn_txt = "Увеличение зазора положения верхних решет";
                        break;
                    case 57:
                        btn_txt = "Уменьшение зазора положения верхних решет";
                        break;
                    case 58:
                        btn_txt = "Увеличение зазора положения нижних решет";
                        break;
                    case 59:
                        btn_txt = "Уменьшение зазора положения нижних решет";
                        break;
                }
                SensorsName[a] = btn_txt;
            }
        }

        private void ButtonAllClick(object sender, EventArgs e)
        {
            var buttoncl = (Button)sender;
            if (buttoncl != null)
            {
                cl = false;
                TM_Simulator.Menu.StatusOfSensors.StatusOfSensorsMode.SensorsModePage sensmode = new();
                SensorsEngineerModePage sensorsEngineerModePage = new();
                sensorsEngineerModePage.Sensor = Convert.ToInt32(buttoncl.Tag);
                sensorsEngineerModePage.PageName = SensorsName[sensorsEngineerModePage.Sensor];
                sensmode.btn = Convert.ToInt32(buttoncl.Tag);
                if (StartPage.EngineerMode)
                    sensorsEngineerModePage.Show();
                else
                    sensmode.Show();
                this.Close();
            }
        }

        private void ButtonAllHover(object sender, EventArgs e)
        {

            var button = (Button)sender;
            if (button != null)
            {
                button.Focus();
                //ВЫВОД названия датчиков

                this.SensorName.Text = "Датчик: " + SensorsName[Convert.ToInt32(button.Tag)];

            }
        }

        
    }
}
