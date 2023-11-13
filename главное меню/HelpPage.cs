using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace TM_Simulator
{
    public partial class HelpPage : Form
    {
        private bool cl = true;
        private int background = 1;

        public HelpPage()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void backmenu_Click(object sender, EventArgs e)
        {
            cl = false;
            SystemMenu sysmenu = new SystemMenu();
            sysmenu.Show();
            this.Close();
        }

        private void HelpPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void HelpPage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                backmenu_Click(this, e);
            }

        }
    }
}
