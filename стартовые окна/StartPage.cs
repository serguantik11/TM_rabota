using System.Threading;

namespace TM_Simulator
{
    public partial class StartPage : Form
    {
        private bool cl = true;
        public StartPage()
        {
            InitializeComponent();
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
    }
}