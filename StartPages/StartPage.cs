using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace TM_Simulator
{
    public partial class StartPage : Form
    {
        public static bool EngineerMode = false;
        private bool cl = true;
        public static bool[] controlstatus = new bool[60];
        public static int[] drumminggap = new int[2];
        public static int comboboxitem = 0;
        public static int[] lowersieves = new int[2];
        public static int[] uppersieves = new int[2];
        public static DateTime dateTime = DateTime.Now;
        public static DateTime tempDateTime = DateTime.Now;
        public static string Password1 = "0000";
        public static string Password2 = "0001";
        public static string Menu = "";
        public static bool[] PasswordVerification = new bool[2];
        public static int Password = 0;
        public static bool USB = false;
        public static int cultureImage = 0;
        public static Image image;
        public static int[] SystemSettings1Item = new int[4];
        public static int[] SystemSettings2Item = new int[3];

        public StartPage()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        private void StartPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }

        }

        private void StartPage_Click(object sender, EventArgs e)
        {
            cl = false;
            TittlePage tittle = new();
            tittle.Show();
            this.Visible = false;
        }

        private void StartPage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartPage_Click(this, e);
            }
        }


        private void StartPage_Load(object sender, EventArgs e)
        {
            for (int n = 0; n < controlstatus.Length; n++)
            {
                controlstatus[n] = false;
            }
            for (int v = 0; v < 2; v++)
            {
                drumminggap[v] = 0;
                lowersieves[v] = 0;
                uppersieves[v] = 0;
            }
            for (int n = 0; n < SystemSettings1Item.Length; n++)
            {
                SystemSettings1Item[n] = 1;
            }
            for (int n = 0; n < SystemSettings2Item.Length; n++)
            {
                SystemSettings2Item[n] = 1;
            }
            PasswordVerification[0] = false;
            PasswordVerification[1] = false;

            LoadData();
            image = (Image)Properties.Resources.ResourceManager.GetObject("culture" + cultureImage);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTime = dateTime.AddMilliseconds(100);
                    
       
        }


        //подключение ФЛЕШКИ
        protected override void WndProc(ref Message m)
        {
            const int WM_DEVICECHANGE = 0x0219;

            const int ADD_DEVICE = 0x8000;

            const int REMOVE_DEVICE = 0x8004;

            if (m.Msg == WM_DEVICECHANGE)
            {
                switch ((int)m.WParam)
                {
                    case ADD_DEVICE:
                        USB = true;
                        break;
                    case REMOVE_DEVICE:
                        USB = false;
                        break;
                }
            }
            base.WndProc(ref m); // Переопределение оконной процедуры
        }

        //массив для РЕЖИМА РАБОТЫ
        public static int[,] culture = 
        {
            { 725, 5, 725, 12, 8, 2, 2 },//пшеница
            { 600, 6, 625, 12, 8, 1, 1 },//овёс
            { 976, 4, 480, 7, 3, 0, 0 },//люцерна
            { 428, 15, 455, 10, 6, 1, 1 },//гречиха
            { 428, 14, 450, 12, 7, 4, 4},//кукуруза
            { 650, 5, 625, 12, 8, 2, 2 },//ячмень
            { 775, 5, 675, 12, 8, 2, 2 },//рожь
            { 976, 4, 480, 7, 3, 0, 0 },//клевер
            { 575, 6, 500, 9, 5, 0, 0 },//рапс
            { 450, 22, 725, 16, 11, 1, 1 },//соя
            { 407, 22, 785, 13, 11, 2, 2 },//нут
            { 250, 27, 785, 11, 8, 2, 2 }//подсолнух
        };
        
        
        public void SaveData()
        {
            SaveDataClass savedata = new();
            controlstatus.CopyTo(savedata.SensorStatus, 0);
            drumminggap.CopyTo(savedata.drumminggap, 0);
            lowersieves.CopyTo(savedata.lowersieves, 0);
            uppersieves.CopyTo(savedata.uppersieves, 0);
            savedata.dateTime = DateTime.Now;
            savedata.newDateTime = dateTime;
            savedata.Password1 = Password1;
            savedata.Password2 = Password2;
            savedata.combineItem = comboboxitem;
            savedata.culture = cultureImage;
            SystemSettings1Item.CopyTo(savedata.SystemSettings1Item, 0);
            SystemSettings2Item.CopyTo(savedata.SystemSettings2Item, 0);
            //запись в файл
            XmlSerializer xs = new XmlSerializer(typeof(SaveDataClass));
            using (FileStream fs = new FileStream("Data.xml", FileMode.Create))
            {
                xs.Serialize(fs, savedata);
            }
        }

        public void LoadData()
        {
            SaveDataClass savedata = new();
            string path = "Data.xml";
            if (File.Exists(path))
            {
                //чтение из файла
                XmlSerializer xs = new XmlSerializer(typeof(SaveDataClass));
                using (FileStream fs = new FileStream("Data.xml", FileMode.Open))
                {
                        savedata = xs.Deserialize(fs) as SaveDataClass;
                }

                if (savedata != null)
                {
                    savedata.SensorStatus.CopyTo(controlstatus, 0);
                    savedata.drumminggap.CopyTo(drumminggap, 0);
                    savedata.lowersieves.CopyTo(lowersieves, 0);
                    savedata.uppersieves.CopyTo(uppersieves, 0);
                    TimeSpan timeSpan = DateTime.Now - savedata.dateTime;
                    dateTime = savedata.newDateTime.Add(timeSpan);
                    Password1 = savedata.Password1;
                    Password2 = savedata.Password2;
                    comboboxitem = savedata.combineItem;
                    cultureImage = savedata.culture;
                    savedata.SystemSettings1Item.CopyTo(SystemSettings1Item, 0);
                    savedata.SystemSettings2Item.CopyTo(SystemSettings2Item, 0);

                }
            }

        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            SaveData();
        }

    }
    public class SaveDataClass
    {
        public bool[] SensorStatus = new bool[60];//контроль датчиков
        //калибровки
        public int[] drumminggap = new int[2];
        public int[] lowersieves = new int[2];
        public int[] uppersieves = new int[2];
        //время
        public DateTime dateTime;
        public DateTime newDateTime;
        //пароли
        public string Password1;
        public string Password2;
        //выбор в списках
        public int combineItem;
        public int[] SystemSettings1Item = new int[4];
        public int[] SystemSettings2Item = new int[3];
        //выбор культуры
        public int culture;
    }
}