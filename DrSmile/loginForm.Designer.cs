namespace DrSmile
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            button1 = new Button();
            pictureBoxUser = new PictureBox();
            pictureBoxPassword = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            labDrSmile = new Label();
            labDentalClinic = new Label();
            btnLogin = new Button();
            pictureBoxLogo = new PictureBox();
            labCopyRight = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(592, 4);
            button1.Name = "button1";
            button1.Size = new Size(35, 39);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
            pictureBoxUser.Location = new Point(195, 248);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(49, 41);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUser.TabIndex = 2;
            pictureBoxUser.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.BackColor = Color.White;
            pictureBoxPassword.Image = (Image)resources.GetObject("pictureBoxPassword.Image");
            pictureBoxPassword.Location = new Point(195, 318);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(49, 41);
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPassword.TabIndex = 3;
            pictureBoxPassword.TabStop = false;
            pictureBoxPassword.Click += pictureBox3_Click;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.CornflowerBlue;
            txtUser.Location = new Point(283, 255);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "User Name";
            txtUser.Size = new Size(253, 39);
            txtUser.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.CornflowerBlue;
            txtPassword.Location = new Point(283, 324);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(253, 39);
            txtPassword.TabIndex = 5;
            // 
            // labDrSmile
            // 
            labDrSmile.AutoSize = true;
            labDrSmile.Font = new Font("Arial Rounded MT Bold", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDrSmile.ForeColor = Color.White;
            labDrSmile.Location = new Point(222, 66);
            labDrSmile.Name = "labDrSmile";
            labDrSmile.Size = new Size(395, 93);
            labDrSmile.TabIndex = 6;
            labDrSmile.Text = "Dr. Smile";
            // 
            // labDentalClinic
            // 
            labDentalClinic.AutoSize = true;
            labDentalClinic.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDentalClinic.ForeColor = Color.White;
            labDentalClinic.Location = new Point(270, 159);
            labDentalClinic.Name = "labDentalClinic";
            labDentalClinic.Size = new Size(295, 51);
            labDentalClinic.TabIndex = 7;
            labDentalClinic.Text = "Dental Clinic";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.CornflowerBlue;
            btnLogin.Location = new Point(283, 382);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(253, 34);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(49, 63);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(180, 179);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 9;
            pictureBoxLogo.TabStop = false;
            // 
            // labCopyRight
            // 
            labCopyRight.AutoSize = true;
            labCopyRight.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labCopyRight.ForeColor = Color.White;
            labCopyRight.Location = new Point(206, 470);
            labCopyRight.Name = "labCopyRight";
            labCopyRight.Size = new Size(226, 25);
            labCopyRight.TabIndex = 10;
            labCopyRight.Text = "CopyRight | 2024@| DrSmile";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(631, 502);
            Controls.Add(labCopyRight);
            Controls.Add(pictureBoxLogo);
            Controls.Add(btnLogin);
            Controls.Add(labDentalClinic);
            Controls.Add(labDrSmile);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pictureBoxPassword);
            Controls.Add(pictureBoxUser);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBoxUser;
        private PictureBox pictureBoxPassword;
        private TextBox txtPassword;
        private Label labDrSmile;
        private Label labDentalClinic;
        private Button btnLogin;
        private PictureBox pictureBoxLogo;
        private Label labCopyRight;
        private TextBox txtUser;
    }
}