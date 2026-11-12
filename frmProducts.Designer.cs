namespace Billing_system
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            labelTop = new Label();
            textSearch = new TextBox();
            labelSearch = new Label();
            dgvProducts = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            textDescription = new TextBox();
            textName = new TextBox();
            textProductID = new TextBox();
            labelDescription = new Label();
            labelName = new Label();
            labelProductsID = new Label();
            labelCategory = new Label();
            comboCategory = new ComboBox();
            labelRate = new Label();
            textRate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelTop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 35);
            panel1.TabIndex = 2;
            // 
            // labelTop
            // 
            labelTop.AutoSize = true;
            labelTop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTop.Location = new Point(284, 9);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(77, 21);
            labelTop.TabIndex = 0;
            labelTop.Text = "Products";
            // 
            // textSearch
            // 
            textSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textSearch.Location = new Point(330, 49);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(296, 25);
            textSearch.TabIndex = 25;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(276, 53);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(48, 17);
            labelSearch.TabIndex = 24;
            labelSearch.Text = "Search";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(276, 80);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(350, 196);
            dgvProducts.TabIndex = 23;
            dgvProducts.RowHeaderMouseClick += dgvProducts_RowHeaderMouseClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(284, 306);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 31);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.Location = new Point(188, 306);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 31);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.GreenYellow;
            btnAdd.Location = new Point(92, 306);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 31);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textDescription
            // 
            textDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textDescription.Location = new Point(92, 160);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(150, 106);
            textDescription.TabIndex = 19;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(92, 86);
            textName.Name = "textName";
            textName.Size = new Size(150, 25);
            textName.TabIndex = 18;
            // 
            // textProductID
            // 
            textProductID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textProductID.Location = new Point(92, 53);
            textProductID.Name = "textProductID";
            textProductID.ReadOnly = true;
            textProductID.Size = new Size(150, 25);
            textProductID.TabIndex = 17;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescription.Location = new Point(7, 160);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(79, 17);
            labelDescription.TabIndex = 16;
            labelDescription.Text = "Description";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(6, 86);
            labelName.Name = "labelName";
            labelName.Size = new Size(44, 17);
            labelName.TabIndex = 15;
            labelName.Text = "Name";
            // 
            // labelProductsID
            // 
            labelProductsID.AutoSize = true;
            labelProductsID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductsID.Location = new Point(6, 53);
            labelProductsID.Name = "labelProductsID";
            labelProductsID.Size = new Size(74, 17);
            labelProductsID.TabIndex = 14;
            labelProductsID.Text = "Product ID";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategory.Location = new Point(6, 122);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(64, 17);
            labelCategory.TabIndex = 26;
            labelCategory.Text = "Category";
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(92, 122);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(150, 23);
            comboCategory.TabIndex = 27;
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelRate.Location = new Point(6, 281);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(35, 17);
            labelRate.TabIndex = 28;
            labelRate.Text = "Rate";
            // 
            // textRate
            // 
            textRate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textRate.Location = new Point(92, 278);
            textRate.Name = "textRate";
            textRate.Size = new Size(150, 25);
            textRate.TabIndex = 29;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(642, 349);
            Controls.Add(textRate);
            Controls.Add(labelRate);
            Controls.Add(comboCategory);
            Controls.Add(labelCategory);
            Controls.Add(textSearch);
            Controls.Add(panel1);
            Controls.Add(labelSearch);
            Controls.Add(btnDelete);
            Controls.Add(dgvProducts);
            Controls.Add(labelProductsID);
            Controls.Add(labelName);
            Controls.Add(btnUpdate);
            Controls.Add(labelDescription);
            Controls.Add(btnAdd);
            Controls.Add(textProductID);
            Controls.Add(textDescription);
            Controls.Add(textName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label labelTop;
        private TextBox textSearch;
        private Label labelSearch;
        private DataGridView dgvProducts;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox textDescription;
        private TextBox textName;
        private TextBox textProductID;
        private Label labelDescription;
        private Label labelName;
        private Label labelProductsID;
        private Label labelCategory;
        private ComboBox comboCategory;
        private Label labelRate;
        private TextBox textRate;
    }
}