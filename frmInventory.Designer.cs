namespace Billing_system
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            labelTop = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnShowall = new Button();
            comboCategory = new ComboBox();
            labelInventoryCategory = new Label();
            dgvInventory = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // labelTop
            // 
            labelTop.AutoSize = true;
            labelTop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTop.Location = new Point(305, 9);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(85, 21);
            labelTop.TabIndex = 0;
            labelTop.Text = "Inventory";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelTop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 35);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(656, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(731, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnShowall
            // 
            btnShowall.BackColor = Color.LightYellow;
            btnShowall.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowall.Location = new Point(305, 41);
            btnShowall.Name = "btnShowall";
            btnShowall.Size = new Size(75, 23);
            btnShowall.TabIndex = 45;
            btnShowall.Text = "Show All";
            btnShowall.UseVisualStyleBackColor = false;
            btnShowall.Click += btnShowall_Click;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(71, 41);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(219, 23);
            comboCategory.TabIndex = 44;
            comboCategory.SelectedIndexChanged += comboCategory_SelectedIndexChanged;
            // 
            // labelInventoryCategory
            // 
            labelInventoryCategory.AutoSize = true;
            labelInventoryCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelInventoryCategory.Location = new Point(8, 44);
            labelInventoryCategory.Name = "labelInventoryCategory";
            labelInventoryCategory.Size = new Size(57, 15);
            labelInventoryCategory.TabIndex = 43;
            labelInventoryCategory.Text = "Category";
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(5, 85);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowTemplate.Height = 25;
            dgvInventory.Size = new Size(685, 237);
            dgvInventory.TabIndex = 42;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(696, 334);
            Controls.Add(btnShowall);
            Controls.Add(comboCategory);
            Controls.Add(labelInventoryCategory);
            Controls.Add(dgvInventory);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventory";
            Text = "frmInventory";
            Load += frmInventory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTop;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnShowall;
        private ComboBox comboCategory;
        private Label labelInventoryCategory;
        private DataGridView dgvInventory;
    }
}