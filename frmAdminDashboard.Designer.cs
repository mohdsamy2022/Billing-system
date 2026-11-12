namespace Billing_system
{
    partial class frmAdminDashboard
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
            pnlfooter = new Panel();
            label1 = new Label();
            usersToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            menuStripTop = new MenuStrip();
            dealerAndCustomerToolStripMenuItem = new ToolStripMenuItem();
            labelUser = new Label();
            labelUsername = new Label();
            labelAppname = new Label();
            labelAppname2 = new Label();
            pnlfooter.SuspendLayout();
            menuStripTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlfooter
            // 
            pnlfooter.BackColor = Color.Teal;
            pnlfooter.Controls.Add(label1);
            pnlfooter.Dock = DockStyle.Bottom;
            pnlfooter.Location = new Point(0, 412);
            pnlfooter.Name = "pnlfooter";
            pnlfooter.Size = new Size(800, 38);
            pnlfooter.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(286, 8);
            label1.Name = "label1";
            label1.Size = new Size(259, 21);
            label1.TabIndex = 0;
            label1.Text = "developed by: mohammad samy";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(46, 20);
            usersToolStripMenuItem.Text = "users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(65, 20);
            categoryToolStripMenuItem.Text = "category";
            categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(66, 20);
            productsToolStripMenuItem.Text = "products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(69, 20);
            inventoryToolStripMenuItem.Text = "inventory";
            inventoryToolStripMenuItem.Click += inventoryToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(83, 20);
            transactionsToolStripMenuItem.Text = "transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // menuStripTop
            // 
            menuStripTop.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, categoryToolStripMenuItem, productsToolStripMenuItem, dealerAndCustomerToolStripMenuItem, inventoryToolStripMenuItem, transactionsToolStripMenuItem });
            menuStripTop.Location = new Point(0, 0);
            menuStripTop.Name = "menuStripTop";
            menuStripTop.Size = new Size(800, 24);
            menuStripTop.TabIndex = 1;
            menuStripTop.Text = "menuStripTop";
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            dealerAndCustomerToolStripMenuItem.Size = new Size(130, 20);
            dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            dealerAndCustomerToolStripMenuItem.Click += dealerAndCustomerToolStripMenuItem_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.Location = new Point(12, 33);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(40, 17);
            labelUser.TabIndex = 2;
            labelUser.Text = "User:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.Green;
            labelUsername.Location = new Point(46, 33);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(64, 17);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "mo samy";
            // 
            // labelAppname
            // 
            labelAppname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAppname.AutoSize = true;
            labelAppname.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelAppname.ForeColor = Color.BlueViolet;
            labelAppname.Location = new Point(402, 238);
            labelAppname.Name = "labelAppname";
            labelAppname.Size = new Size(125, 32);
            labelAppname.TabIndex = 4;
            labelAppname.Text = "Any Store";
            // 
            // labelAppname2
            // 
            labelAppname2.AutoSize = true;
            labelAppname2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAppname2.ForeColor = Color.Black;
            labelAppname2.Location = new Point(286, 270);
            labelAppname2.Name = "labelAppname2";
            labelAppname2.Size = new Size(323, 25);
            labelAppname2.TabIndex = 5;
            labelAppname2.Text = "Billing and Inventory Management";
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAppname2);
            Controls.Add(labelAppname);
            Controls.Add(labelUsername);
            Controls.Add(labelUser);
            Controls.Add(pnlfooter);
            Controls.Add(menuStripTop);
            MainMenuStrip = menuStripTop;
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            FormClosed += frmAdminDashboard_FormClosed;
            Load += frmAdminDashboard_Load;
            pnlfooter.ResumeLayout(false);
            pnlfooter.PerformLayout();
            menuStripTop.ResumeLayout(false);
            menuStripTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlfooter;
        private Label label1;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private MenuStrip menuStripTop;
        private Label labelUser;
        private Label labelUsername;
        private Label labelAppname;
        private Label labelAppname2;
        private ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
    }
}