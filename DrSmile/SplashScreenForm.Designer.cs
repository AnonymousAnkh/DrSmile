namespace DrSmile
{
    partial class SplashScreenForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            pictureBoxLogo = new PictureBox();
            labWelcome = new Label();
            labDrSmile = new Label();
            labDentalClinic = new Label();
            labCopyRight = new Label();
            lab1 = new Label();
            labPercent = new Label();
            timerLoading = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(91, 81);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(322, 324);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labWelcome
            // 
            labWelcome.AutoSize = true;
            labWelcome.Font = new Font("Arial Rounded MT Bold", 56F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labWelcome.ForeColor = Color.White;
            labWelcome.Location = new Point(443, 86);
            labWelcome.Name = "labWelcome";
            labWelcome.Size = new Size(724, 130);
            labWelcome.TabIndex = 1;
            labWelcome.Text = "Welcome To";
            // 
            // labDrSmile
            // 
            labDrSmile.AutoSize = true;
            labDrSmile.Font = new Font("Arial Rounded MT Bold", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDrSmile.ForeColor = Color.White;
            labDrSmile.Location = new Point(441, 201);
            labDrSmile.Name = "labDrSmile";
            labDrSmile.Size = new Size(442, 104);
            labDrSmile.TabIndex = 2;
            labDrSmile.Text = "Dr. Smile";
            // 
            // labDentalClinic
            // 
            labDentalClinic.AutoSize = true;
            labDentalClinic.Font = new Font("Arial Rounded MT Bold", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDentalClinic.ForeColor = Color.White;
            labDentalClinic.Location = new Point(452, 319);
            labDentalClinic.Name = "labDentalClinic";
            labDentalClinic.Size = new Size(371, 65);
            labDentalClinic.TabIndex = 3;
            labDentalClinic.Text = "Dental Clinic";
            // 
            // labCopyRight
            // 
            labCopyRight.AutoSize = true;
            labCopyRight.Font = new Font("Segoe UI Light", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labCopyRight.ForeColor = Color.White;
            labCopyRight.Location = new Point(911, 467);
            labCopyRight.Name = "labCopyRight";
            labCopyRight.Size = new Size(275, 30);
            labCopyRight.TabIndex = 4;
            labCopyRight.Text = "CopyRight | 2024@| DrSmile";
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab1.ForeColor = Color.White;
            lab1.Location = new Point(638, 417);
            lab1.Name = "lab1";
            lab1.Size = new Size(25, 26);
            lab1.TabIndex = 5;
            lab1.Text = "1";
            // 
            // labPercent
            // 
            labPercent.AutoSize = true;
            labPercent.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labPercent.ForeColor = Color.White;
            labPercent.Location = new Point(681, 417);
            labPercent.Name = "labPercent";
            labPercent.Size = new Size(31, 26);
            labPercent.TabIndex = 6;
            labPercent.Text = "%";
            // 
            // timerLoading
            // 
            timerLoading.Enabled = true;
            timerLoading.Interval = 25;
            timerLoading.Tick += timerLoading_Tick;
            // 
            // SplashScreenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1194, 503);
            Controls.Add(labPercent);
            Controls.Add(lab1);
            Controls.Add(labCopyRight);
            Controls.Add(labDentalClinic);
            Controls.Add(labDrSmile);
            Controls.Add(labWelcome);
            Controls.Add(pictureBoxLogo);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreenForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labWelcome;
        private Label labDrSmile;
        private Label labDentalClinic;
        private Label labCopyRight;
        private Label lab1;
        private Label labPercent;
        internal System.Windows.Forms.Timer timerLoading;
    }
}
