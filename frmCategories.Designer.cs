namespace Billing_system
{
    partial class frmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelTop = new Label();
            labelCategoryID = new Label();
            labelTitle = new Label();
            labelDescription = new Label();
            textCategoryID = new TextBox();
            textTitle = new TextBox();
            textDescription = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvCategories = new DataGridView();
            labelSearch = new Label();
            textSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
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
            panel1.Size = new Size(659, 35);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(622, 3);
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
            labelTop.Location = new Point(284, 9);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(91, 21);
            labelTop.TabIndex = 0;
            labelTop.Text = "Categories";
            // 
            // labelCategoryID
            // 
            labelCategoryID.AutoSize = true;
            labelCategoryID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoryID.Location = new Point(14, 55);
            labelCategoryID.Name = "labelCategoryID";
            labelCategoryID.Size = new Size(82, 17);
            labelCategoryID.TabIndex = 2;
            labelCategoryID.Text = "Category ID";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(14, 88);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(36, 17);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Title";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescription.Location = new Point(14, 122);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(79, 17);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Description";
            // 
            // textCategoryID
            // 
            textCategoryID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textCategoryID.Location = new Point(100, 55);
            textCategoryID.Name = "textCategoryID";
            textCategoryID.ReadOnly = true;
            textCategoryID.Size = new Size(150, 25);
            textCategoryID.TabIndex = 5;
            // 
            // textTitle
            // 
            textTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textTitle.Location = new Point(100, 88);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(150, 25);
            textTitle.TabIndex = 6;
            // 
            // textDescription
            // 
            textDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textDescription.Location = new Point(99, 122);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(150, 130);
            textDescription.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.GreenYellow;
            btnAdd.Location = new Point(100, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.Location = new Point(196, 258);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 31);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(292, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 31);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(284, 82);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowTemplate.Height = 25;
            dgvCategories.Size = new Size(350, 170);
            dgvCategories.TabIndex = 11;
            dgvCategories.RowHeaderMouseClick += dgvCategories_RowHeaderMouseClick;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(284, 55);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(48, 17);
            labelSearch.TabIndex = 12;
            labelSearch.Text = "Search";
            // 
            // textSearch
            // 
            textSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textSearch.Location = new Point(338, 51);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(296, 25);
            textSearch.TabIndex = 13;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(659, 313);
            Controls.Add(textSearch);
            Controls.Add(labelSearch);
            Controls.Add(dgvCategories);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(textDescription);
            Controls.Add(textTitle);
            Controls.Add(textCategoryID);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            Controls.Add(labelCategoryID);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";
            Load += frmCategories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelTop;
        private Label labelCategoryID;
        private Label labelTitle;
        private Label labelDescription;
        private TextBox textCategoryID;
        private TextBox textTitle;
        private TextBox textDescription;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvCategories;
        private Label labelSearch;
        private TextBox textSearch;
    }
}