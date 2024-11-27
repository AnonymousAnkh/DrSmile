using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrSmile
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            cmsMaster.Show(btnMaster, 0, btnMaster.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labDateTime.Text = DateTime.Now.ToString();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            timerHome.Enabled = true;
            labUser.Text = loginForm.user;
        }

        private void cmsMaster_Opening(object sender, CancelEventArgs e)
        {
            cmsMaster.ForeColor = Color.CornflowerBlue;
        }

        private void procedureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
