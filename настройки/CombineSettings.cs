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
    public partial class CombineSettings : Form
    {
        private bool cl = true;

        public CombineSettings()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl = false;
            Settings form3 = new();
            form3.Show();
            this.Close();
        }

        private void combset_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }

        private void combset_Load(object sender, EventArgs e)
        {

        }
    }
}
