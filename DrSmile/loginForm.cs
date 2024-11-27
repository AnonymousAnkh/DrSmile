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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public static string user
        { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();

            
        }
        
    }
}
