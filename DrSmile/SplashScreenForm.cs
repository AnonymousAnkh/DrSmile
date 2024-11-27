namespace DrSmile
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            int lab1timer = int.Parse(lab1.Text);
            lab1timer += 1;
            lab1.Text = lab1timer.ToString();
            if (lab1timer == 100)
            {
                timerLoading.Stop();
                this.Hide();
                loginForm loginForm = new loginForm();
                loginForm.ShowDialog();
            }
            

        }
    }
}
