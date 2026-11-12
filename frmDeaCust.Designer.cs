namespace Billing_system
{
    partial class frmDeaCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeaCust));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelTop = new Label();
            textEmail = new TextBox();
            labelEmail = new Label();
            combodcType = new ComboBox();
            labelType = new Label();
            textSearch = new TextBox();
            labelSearch = new Label();
            btnDelete = new Button();
            dgvDeaCust = new DataGridView();
            labelDeaCustID = new Label();
            labelName = new Label();
            btnUpdate = new Button();
            labelAddress = new Label();
            btnAdd = new Button();
            textDeaCustID = new TextBox();
            textAddress = new TextBox();
            textName = new TextBox();
            textContact = new TextBox();
            labelContact = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeaCust).BeginInit();
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
            panel1.Size = new Size(648, 35);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(608, 2);
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
            labelTop.Location = new Point(238, 9);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(170, 21);
            labelTop.TabIndex = 0;
            labelTop.Text = "Dealer and Customer";
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textEmail.Location = new Point(102, 152);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(150, 25);
            textEmail.TabIndex = 45;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(16, 155);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(42, 17);
            labelEmail.TabIndex = 44;
            labelEmail.Text = "Email";
            // 
            // combodcType
            // 
            combodcType.FormattingEnabled = true;
            combodcType.Items.AddRange(new object[] { "customer", "dealer" });
            combodcType.Location = new Point(102, 83);
            combodcType.Name = "combodcType";
            combodcType.Size = new Size(150, 23);
            combodcType.TabIndex = 43;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.Location = new Point(16, 83);
            labelType.Name = "labelType";
            labelType.Size = new Size(37, 17);
            labelType.TabIndex = 42;
            labelType.Text = "Type";
            // 
            // textSearch
            // 
            textSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textSearch.Location = new Point(340, 42);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(296, 25);
            textSearch.TabIndex = 41;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(286, 46);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(48, 17);
            labelSearch.TabIndex = 40;
            labelSearch.Text = "Search";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(293, 328);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 31);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvDeaCust
            // 
            dgvDeaCust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeaCust.Location = new Point(286, 73);
            dgvDeaCust.Name = "dgvDeaCust";
            dgvDeaCust.RowTemplate.Height = 25;
            dgvDeaCust.Size = new Size(350, 246);
            dgvDeaCust.TabIndex = 39;
            dgvDeaCust.RowHeaderMouseClick += dgvDeaCust_RowHeaderMouseClick;
            // 
            // labelDeaCustID
            // 
            labelDeaCustID.AutoSize = true;
            labelDeaCustID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeaCustID.Location = new Point(16, 46);
            labelDeaCustID.Name = "labelDeaCustID";
            labelDeaCustID.Size = new Size(77, 17);
            labelDeaCustID.TabIndex = 30;
            labelDeaCustID.Text = "DeaCust ID";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(16, 115);
            labelName.Name = "labelName";
            labelName.Size = new Size(44, 17);
            labelName.TabIndex = 31;
            labelName.Text = "Name";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.Location = new Point(197, 328);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 31);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddress.Location = new Point(16, 225);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(57, 17);
            labelAddress.TabIndex = 32;
            labelAddress.Text = "Address";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.GreenYellow;
            btnAdd.Location = new Point(101, 328);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 31);
            btnAdd.TabIndex = 36;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textDeaCustID
            // 
            textDeaCustID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textDeaCustID.Location = new Point(102, 46);
            textDeaCustID.Name = "textDeaCustID";
            textDeaCustID.ReadOnly = true;
            textDeaCustID.Size = new Size(150, 25);
            textDeaCustID.TabIndex = 33;
            // 
            // textAddress
            // 
            textAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textAddress.Location = new Point(101, 222);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(150, 97);
            textAddress.TabIndex = 35;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(102, 115);
            textName.Name = "textName";
            textName.Size = new Size(150, 25);
            textName.TabIndex = 34;
            // 
            // textContact
            // 
            textContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textContact.Location = new Point(102, 187);
            textContact.Name = "textContact";
            textContact.Size = new Size(150, 25);
            textContact.TabIndex = 47;
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelContact.Location = new Point(16, 190);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(55, 17);
            labelContact.TabIndex = 46;
            labelContact.Text = "Contact";
            // 
            // frmDeaCust
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(648, 371);
            Controls.Add(textContact);
            Controls.Add(labelContact);
            Controls.Add(textEmail);
            Controls.Add(labelEmail);
            Controls.Add(combodcType);
            Controls.Add(labelType);
            Controls.Add(textSearch);
            Controls.Add(labelSearch);
            Controls.Add(btnDelete);
            Controls.Add(dgvDeaCust);
            Controls.Add(labelDeaCustID);
            Controls.Add(labelName);
            Controls.Add(btnUpdate);
            Controls.Add(labelAddress);
            Controls.Add(btnAdd);
            Controls.Add(textDeaCustID);
            Controls.Add(textAddress);
            Controls.Add(textName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDeaCust";
            Text = "DeaCust";
            Load += frmDeaCust_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeaCust).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelTop;
        private TextBox textEmail;
        private Label labelEmail;
        private ComboBox combodcType;
        private Label labelType;
        private TextBox textSearch;
        private Label labelSearch;
        private Button btnDelete;
        private DataGridView dgvDeaCust;
        private Label labelDeaCustID;
        private Label labelName;
        private Button btnUpdate;
        private Label labelAddress;
        private Button btnAdd;
        private TextBox textDeaCustID;
        private TextBox textAddress;
        private TextBox textName;
        private TextBox textContact;
        private Label labelContact;
    }
}