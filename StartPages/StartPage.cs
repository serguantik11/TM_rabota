using System.Threading;

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
        public StartPage()
        {
            InitializeComponent();
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
        }

        private void StartPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
                Application.Exit();
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
                StartPage_Click (this, e);
            }
        }
    }
}