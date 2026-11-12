namespace Billing_system
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelTop = new Label();
            labelFirstname = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            labelLastname = new Label();
            txtEmail = new TextBox();
            labelEmail = new Label();
            txtUsername = new TextBox();
            labelUsername = new Label();
            txtPassword = new TextBox();
            labelPassword = new Label();
            txtContact = new TextBox();
            labelContact = new Label();
            txtUserID = new TextBox();
            labelUserID = new Label();
            txtAddress = new TextBox();
            labelAddress = new Label();
            labelGender = new Label();
            comboGender = new ComboBox();
            comboUsertype = new ComboBox();
            labelUsertype = new Label();
            dgvUsers = new DataGridView();
            txtSearch = new TextBox();
            labelSearch = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelTop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 35);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(590, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelTop
            // 
            labelTop.AutoSize = true;
            labelTop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTop.Location = new Point(293, 9);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(51, 21);
            labelTop.TabIndex = 0;
            labelTop.Text = "Users";
            // 
            // labelFirstname
            // 
            labelFirstname.AutoSize = true;
            labelFirstname.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelFirstname.Location = new Point(12, 80);
            labelFirstname.Name = "labelFirstname";
            labelFirstname.Size = new Size(69, 17);
            labelFirstname.TabIndex = 1;
            labelFirstname.Text = "Firstname";
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstname.Location = new Point(87, 79);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(145, 25);
            txtFirstname.TabIndex = 2;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastname.Location = new Point(87, 118);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(145, 25);
            txtLastname.TabIndex = 4;
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLastname.Location = new Point(12, 119);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(67, 17);
            labelLastname.TabIndex = 3;
            labelLastname.Text = "Lastname";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(87, 158);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(145, 25);
            txtEmail.TabIndex = 6;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(12, 159);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(42, 17);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(87, 199);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(145, 25);
            txtUsername.TabIndex = 8;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(12, 200);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(69, 17);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(87, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(145, 25);
            txtPassword.TabIndex = 10;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(12, 238);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(66, 17);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtContact.Location = new Point(87, 276);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(145, 25);
            txtContact.TabIndex = 12;
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelContact.Location = new Point(12, 277);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(55, 17);
            labelContact.TabIndex = 11;
            labelContact.Text = "Contact";
            // 
            // txtUserID
            // 
            txtUserID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserID.Location = new Point(87, 41);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(145, 25);
            txtUserID.TabIndex = 14;
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserID.Location = new Point(12, 42);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(53, 17);
            labelUserID.TabIndex = 13;
            labelUserID.Text = "User ID";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddress.Location = new Point(87, 317);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(145, 25);
            txtAddress.TabIndex = 16;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddress.Location = new Point(12, 318);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(57, 17);
            labelAddress.TabIndex = 15;
            labelAddress.Text = "Address";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelGender.Location = new Point(12, 354);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(52, 17);
            labelGender.TabIndex = 17;
            labelGender.Text = "Gender";
            // 
            // comboGender
            // 
            comboGender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "male", "female" });
            comboGender.Location = new Point(86, 353);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(146, 25);
            comboGender.TabIndex = 18;
            // 
            // comboUsertype
            // 
            comboUsertype.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboUsertype.FormattingEnabled = true;
            comboUsertype.Items.AddRange(new object[] { "user", "admin" });
            comboUsertype.Location = new Point(86, 383);
            comboUsertype.Name = "comboUsertype";
            comboUsertype.Size = new Size(146, 25);
            comboUsertype.TabIndex = 20;
            // 
            // labelUsertype
            // 
            labelUsertype.AutoSize = true;
            labelUsertype.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsertype.Location = new Point(12, 384);
            labelUsertype.Name = "labelUsertype";
            labelUsertype.Size = new Size(66, 17);
            labelUsertype.TabIndex = 19;
            labelUsertype.Text = "User type";
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(249, 79);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.Size = new Size(357, 322);
            dgvUsers.TabIndex = 21;
            dgvUsers.RowHeaderMouseClick += dgvUsers_RowHeaderMouseClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(301, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(305, 25);
            txtSearch.TabIndex = 23;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(247, 49);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(48, 17);
            labelSearch.TabIndex = 22;
            labelSearch.Text = "Search";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Lime;
            buttonAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(144, 414);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(90, 33);
            buttonAdd.TabIndex = 24;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.OliveDrab;
            buttonUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(247, 414);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(90, 33);
            buttonUpdate.TabIndex = 25;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(353, 414);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(90, 33);
            buttonDelete.TabIndex = 26;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(627, 459);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(txtSearch);
            Controls.Add(labelSearch);
            Controls.Add(dgvUsers);
            Controls.Add(comboUsertype);
            Controls.Add(labelUsertype);
            Controls.Add(comboGender);
            Controls.Add(labelGender);
            Controls.Add(txtAddress);
            Controls.Add(labelAddress);
            Controls.Add(txtUserID);
            Controls.Add(labelUserID);
            Controls.Add(txtContact);
            Controls.Add(labelContact);
            Controls.Add(txtPassword);
            Controls.Add(labelPassword);
            Controls.Add(txtUsername);
            Controls.Add(labelUsername);
            Controls.Add(txtEmail);
            Controls.Add(labelEmail);
            Controls.Add(txtLastname);
            Controls.Add(labelLastname);
            Controls.Add(txtFirstname);
            Controls.Add(labelFirstname);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsers";
            Text = "Users";
            Load += frmUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelTop;
        private PictureBox pictureBox1;
        private Label labelFirstname;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private Label labelLastname;
        private TextBox txtEmail;
        private Label labelEmail;
        private TextBox txtUsername;
        private Label labelUsername;
        private TextBox txtPassword;
        private Label labelPassword;
        private TextBox txtContact;
        private Label labelContact;
        private TextBox txtUserID;
        private Label labelUserID;
        private TextBox txtAddress;
        private Label labelAddress;
        private Label labelGender;
        private ComboBox comboGender;
        private ComboBox comboUsertype;
        private Label labelUsertype;
        private DataGridView dgvUsers;
        private TextBox txtSearch;
        private Label labelSearch;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}