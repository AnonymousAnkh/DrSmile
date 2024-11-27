namespace DrSmile
{
    partial class SystemicForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemicForm));
            panel1 = new Panel();
            btnClose = new Button();
            labDentalClinic = new Label();
            labDrSmile = new Label();
            panel2 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(labDentalClinic);
            panel1.Controls.Add(labDrSmile);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 61);
            panel1.TabIndex = 14;
            // 
            // btnClose
            // 
            btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1153, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 39);
            btnClose.TabIndex = 18;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // labDentalClinic
            // 
            labDentalClinic.AutoSize = true;
            labDentalClinic.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDentalClinic.ForeColor = Color.CornflowerBlue;
            labDentalClinic.Location = new Point(159, 6);
            labDentalClinic.Name = "labDentalClinic";
            labDentalClinic.Size = new Size(132, 48);
            labDentalClinic.TabIndex = 12;
            labDentalClinic.Text = "System";
            // 
            // labDrSmile
            // 
            labDrSmile.AutoSize = true;
            labDrSmile.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDrSmile.ForeColor = Color.CornflowerBlue;
            labDrSmile.Location = new Point(12, 6);
            labDrSmile.Name = "labDrSmile";
            labDrSmile.Size = new Size(153, 48);
            labDrSmile.TabIndex = 11;
            labDrSmile.Text = "Master /";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(72, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(1041, 109);
            panel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 38);
            label1.Name = "label1";
            label1.Size = new Size(186, 38);
            label1.TabIndex = 0;
            label1.Text = "System Alert :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(424, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(440, 33);
            comboBox1.TabIndex = 1;
            // 
            // SystemicForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SystemicForm";
            Size = new Size(1198, 463);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labDentalClinic;
        private Label labDrSmile;
        private Button btnClose;
        private Panel panel2;
        private Label label1;
        private ComboBox comboBox1;
    }
}
