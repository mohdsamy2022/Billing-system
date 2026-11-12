namespace Billing_system
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            comboUsertype = new ComboBox();
            labelUsertype = new Label();
            buttonLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            labelPassword = new Label();
            labelUsername = new Label();
            labelLogin = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(comboUsertype);
            panel1.Controls.Add(labelUsertype);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(labelLogin);
            panel1.Location = new Point(38, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 254);
            panel1.TabIndex = 0;
            // 
            // comboUsertype
            // 
            comboUsertype.FormattingEnabled = true;
            comboUsertype.Items.AddRange(new object[] { "user", "admin" });
            comboUsertype.Location = new Point(21, 186);
            comboUsertype.Name = "comboUsertype";
            comboUsertype.Size = new Size(175, 23);
            comboUsertype.TabIndex = 7;
            // 
            // labelUsertype
            // 
            labelUsertype.AutoSize = true;
            labelUsertype.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsertype.Location = new Point(21, 166);
            labelUsertype.Name = "labelUsertype";
            labelUsertype.Size = new Size(66, 17);
            labelUsertype.TabIndex = 6;
            labelUsertype.Text = "User type";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.MediumSeaGreen;
            buttonLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(18, 217);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(178, 34);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(18, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(178, 25);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(18, 64);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(178, 25);
            txtUsername.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(18, 103);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(66, 17);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(18, 44);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(69, 17);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.Location = new Point(78, 10);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(59, 21);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(260, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(287, 324);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label labelPassword;
        private Label labelUsername;
        private Label labelUsertype;
        private Button buttonLogin;
        private ComboBox comboUsertype;
        private PictureBox pictureBox1;
    }
}