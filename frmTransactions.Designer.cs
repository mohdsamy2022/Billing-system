namespace Billing_system
{
    partial class frmTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            labelTop = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dgvTransactions = new DataGridView();
            labelTransactionType = new Label();
            comboTransactionType = new ComboBox();
            btnShowall = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // labelTop
            // 
            labelTop.AutoSize = true;
            labelTop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTop.Location = new Point(289, 9);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(105, 21);
            labelTop.TabIndex = 0;
            labelTop.Text = "Transactions";
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
            panel1.Size = new Size(700, 35);
            panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(663, 2);
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
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(12, 95);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowTemplate.Height = 25;
            dgvTransactions.Size = new Size(676, 237);
            dgvTransactions.TabIndex = 20;
            // 
            // labelTransactionType
            // 
            labelTransactionType.AutoSize = true;
            labelTransactionType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTransactionType.Location = new Point(12, 55);
            labelTransactionType.Name = "labelTransactionType";
            labelTransactionType.Size = new Size(99, 15);
            labelTransactionType.TabIndex = 30;
            labelTransactionType.Text = "Transaction Type";
            // 
            // comboTransactionType
            // 
            comboTransactionType.FormattingEnabled = true;
            comboTransactionType.Items.AddRange(new object[] { "Purchase", "Sales" });
            comboTransactionType.Location = new Point(112, 52);
            comboTransactionType.Name = "comboTransactionType";
            comboTransactionType.Size = new Size(182, 23);
            comboTransactionType.TabIndex = 31;
            comboTransactionType.SelectedIndexChanged += comboTransactionType_SelectedIndexChanged;
            // 
            // btnShowall
            // 
            btnShowall.BackColor = Color.LightYellow;
            btnShowall.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowall.Location = new Point(309, 52);
            btnShowall.Name = "btnShowall";
            btnShowall.Size = new Size(75, 23);
            btnShowall.TabIndex = 41;
            btnShowall.Text = "Show All";
            btnShowall.UseVisualStyleBackColor = false;
            btnShowall.Click += btnShowall_Click;
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(700, 344);
            Controls.Add(btnShowall);
            Controls.Add(comboTransactionType);
            Controls.Add(labelTransactionType);
            Controls.Add(dgvTransactions);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTransactions";
            Text = "frmTransactions";
            Load += frmTransactions_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTop;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dgvTransactions;
        private Label labelTransactionType;
        private ComboBox comboTransactionType;
        private Button btnShowall;
    }
}