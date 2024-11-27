namespace DrSmile
{
    partial class HomeForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            pictureBoxLogo = new PictureBox();
            labDrSmile = new Label();
            labDentalClinic = new Label();
            panel1 = new Panel();
            btnMini = new Button();
            button1 = new Button();
            panel2 = new Panel();
            btnLogOut = new Button();
            btnSchedule = new Button();
            btnSearch = new Button();
            btnNewPatient = new Button();
            btnDoctor = new Button();
            btnMaster = new Button();
            panel3 = new Panel();
            labCopyRight = new Label();
            panel4 = new Panel();
            labDateTime = new Label();
            labDate = new Label();
            labUser = new Label();
            labWelcome = new Label();
            cmsMaster = new ContextMenuStrip(components);
            systemToolStripMenuItem = new ToolStripMenuItem();
            treatmentToolStripMenuItem = new ToolStripMenuItem();
            medicineTypeToolStripMenuItem = new ToolStripMenuItem();
            medicineToolStripMenuItem = new ToolStripMenuItem();
            creditorToolStripMenuItem = new ToolStripMenuItem();
            timerHome = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            cmsMaster.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(12, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(73, 74);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 10;
            pictureBoxLogo.TabStop = false;
            // 
            // labDrSmile
            // 
            labDrSmile.AutoSize = true;
            labDrSmile.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDrSmile.ForeColor = Color.CornflowerBlue;
            labDrSmile.Location = new Point(12, 5);
            labDrSmile.Name = "labDrSmile";
            labDrSmile.Size = new Size(217, 51);
            labDrSmile.TabIndex = 11;
            labDrSmile.Text = "Dr. Smile";
            // 
            // labDentalClinic
            // 
            labDentalClinic.AutoSize = true;
            labDentalClinic.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDentalClinic.ForeColor = Color.CornflowerBlue;
            labDentalClinic.Location = new Point(213, 5);
            labDentalClinic.Name = "labDentalClinic";
            labDentalClinic.Size = new Size(295, 51);
            labDentalClinic.TabIndex = 12;
            labDentalClinic.Text = "Dental Clinic";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnMini);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labDentalClinic);
            panel1.Controls.Add(labDrSmile);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 61);
            panel1.TabIndex = 13;
            // 
            // btnMini
            // 
            btnMini.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMini.BackColor = Color.CornflowerBlue;
            btnMini.FlatStyle = FlatStyle.Flat;
            btnMini.ForeColor = Color.Black;
            btnMini.Location = new Point(1110, 12);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(35, 39);
            btnMini.TabIndex = 18;
            btnMini.Text = "-";
            btnMini.UseVisualStyleBackColor = false;
            btnMini.Click += btnMini_Click;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1151, 12);
            button1.Name = "button1";
            button1.Size = new Size(35, 39);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnSchedule);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnNewPatient);
            panel2.Controls.Add(btnDoctor);
            panel2.Controls.Add(btnMaster);
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(1198, 80);
            panel2.TabIndex = 14;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.CornflowerBlue;
            btnLogOut.Location = new Point(903, 16);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(153, 47);
            btnLogOut.TabIndex = 21;
            btnLogOut.Text = "LogOut";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            btnSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSchedule.ForeColor = Color.CornflowerBlue;
            btnSchedule.Image = (Image)resources.GetObject("btnSchedule.Image");
            btnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSchedule.Location = new Point(744, 16);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(153, 47);
            btnSchedule.TabIndex = 20;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.CornflowerBlue;
            btnSearch.Location = new Point(585, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(153, 47);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnNewPatient
            // 
            btnNewPatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNewPatient.ForeColor = Color.CornflowerBlue;
            btnNewPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewPatient.Location = new Point(426, 16);
            btnNewPatient.Name = "btnNewPatient";
            btnNewPatient.Size = new Size(153, 47);
            btnNewPatient.TabIndex = 18;
            btnNewPatient.Text = "New Patient";
            btnNewPatient.UseVisualStyleBackColor = true;
            // 
            // btnDoctor
            // 
            btnDoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDoctor.ForeColor = Color.CornflowerBlue;
            btnDoctor.Location = new Point(267, 16);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(153, 47);
            btnDoctor.TabIndex = 17;
            btnDoctor.Text = "Doctor";
            btnDoctor.UseVisualStyleBackColor = true;
            // 
            // btnMaster
            // 
            btnMaster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaster.ForeColor = Color.CornflowerBlue;
            btnMaster.Location = new Point(108, 16);
            btnMaster.Name = "btnMaster";
            btnMaster.Size = new Size(153, 47);
            btnMaster.TabIndex = 16;
            btnMaster.Text = "Master";
            btnMaster.UseVisualStyleBackColor = true;
            btnMaster.Click += btnMaster_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(1198, 12);
            panel3.TabIndex = 15;
            // 
            // labCopyRight
            // 
            labCopyRight.AutoSize = true;
            labCopyRight.Font = new Font("Segoe UI Light", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labCopyRight.ForeColor = Color.CornflowerBlue;
            labCopyRight.Location = new Point(917, 8);
            labCopyRight.Name = "labCopyRight";
            labCopyRight.Size = new Size(275, 30);
            labCopyRight.TabIndex = 16;
            labCopyRight.Text = "CopyRight | 2024@| DrSmile";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(labDateTime);
            panel4.Controls.Add(labDate);
            panel4.Controls.Add(labUser);
            panel4.Controls.Add(labWelcome);
            panel4.Controls.Add(labCopyRight);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 616);
            panel4.Name = "panel4";
            panel4.Size = new Size(1198, 46);
            panel4.TabIndex = 17;
            // 
            // labDateTime
            // 
            labDateTime.AutoSize = true;
            labDateTime.ForeColor = Color.CornflowerBlue;
            labDateTime.Location = new Point(459, 11);
            labDateTime.Name = "labDateTime";
            labDateTime.Size = new Size(49, 25);
            labDateTime.TabIndex = 21;
            labDateTime.Text = "Date";
            // 
            // labDate
            // 
            labDate.AutoSize = true;
            labDate.ForeColor = Color.CornflowerBlue;
            labDate.Location = new Point(385, 11);
            labDate.Name = "labDate";
            labDate.Size = new Size(58, 25);
            labDate.TabIndex = 20;
            labDate.Text = "Date :";
            // 
            // labUser
            // 
            labUser.AutoSize = true;
            labUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUser.ForeColor = Color.CornflowerBlue;
            labUser.Location = new Point(112, 11);
            labUser.Name = "labUser";
            labUser.Size = new Size(47, 25);
            labUser.TabIndex = 19;
            labUser.Text = "User";
            // 
            // labWelcome
            // 
            labWelcome.AutoSize = true;
            labWelcome.ForeColor = Color.CornflowerBlue;
            labWelcome.Location = new Point(12, 11);
            labWelcome.Name = "labWelcome";
            labWelcome.Size = new Size(94, 25);
            labWelcome.TabIndex = 18;
            labWelcome.Text = "Welcome ,";
            // 
            // cmsMaster
            // 
            cmsMaster.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmsMaster.ImageScalingSize = new Size(24, 24);
            cmsMaster.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, treatmentToolStripMenuItem, medicineTypeToolStripMenuItem, medicineToolStripMenuItem, creditorToolStripMenuItem });
            cmsMaster.Name = "cmsMaster";
            cmsMaster.Size = new Size(198, 164);
            cmsMaster.Opening += cmsMaster_Opening;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(197, 32);
            systemToolStripMenuItem.Text = "System";
            // 
            // treatmentToolStripMenuItem
            // 
            treatmentToolStripMenuItem.Name = "treatmentToolStripMenuItem";
            treatmentToolStripMenuItem.Size = new Size(197, 32);
            treatmentToolStripMenuItem.Text = "Treatment";
            // 
            // medicineTypeToolStripMenuItem
            // 
            medicineTypeToolStripMenuItem.Name = "medicineTypeToolStripMenuItem";
            medicineTypeToolStripMenuItem.Size = new Size(197, 32);
            medicineTypeToolStripMenuItem.Text = "Medicine Type";
            // 
            // medicineToolStripMenuItem
            // 
            medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            medicineToolStripMenuItem.Size = new Size(197, 32);
            medicineToolStripMenuItem.Text = "Medicine";
            // 
            // creditorToolStripMenuItem
            // 
            creditorToolStripMenuItem.Name = "creditorToolStripMenuItem";
            creditorToolStripMenuItem.Size = new Size(197, 32);
            creditorToolStripMenuItem.Text = "Creditor";
            // 
            // timerHome
            // 
            timerHome.Interval = 1000;
            timerHome.Tick += timer1_Tick;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 153);
            panel5.Name = "panel5";
            panel5.Size = new Size(1198, 463);
            panel5.TabIndex = 18;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1198, 662);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            cmsMaster.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labDrSmile;
        private Label labDentalClinic;
        private Panel panel1;
        private Panel panel2;
        private Button btnMaster;
        private Panel panel3;
        private Button btnLogOut;
        private Button btnSchedule;
        private Button btnSearch;
        private Button btnNewPatient;
        private Button btnDoctor;
        private Label labCopyRight;
        private Button button1;
        private Panel panel4;
        private Label labWelcome;
        private Label labDateTime;
        private Label labDate;
        private Button btnMini;
        private ContextMenuStrip cmsMaster;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem treatmentToolStripMenuItem;
        private System.Windows.Forms.Timer timerHome;
        private Label labUser;
        private ToolStripMenuItem medicineTypeToolStripMenuItem;
        private ToolStripMenuItem medicineToolStripMenuItem;
        private ToolStripMenuItem creditorToolStripMenuItem;
        private Panel panel5;
    }
}