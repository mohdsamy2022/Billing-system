namespace Billing_system
{
    partial class frmUserDashboard
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
            menuStrip1 = new MenuStrip();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            dealerAndCustomerToolStripMenuItem = new ToolStripMenuItem();
            labelAppname2 = new Label();
            labelAppname = new Label();
            labelUsername = new Label();
            labelUser = new Label();
            pnlfooter = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            pnlfooter.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { purchaseToolStripMenuItem, salesToolStripMenuItem, inventoryToolStripMenuItem, dealerAndCustomerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(67, 20);
            purchaseToolStripMenuItem.Text = "Purchase";
            purchaseToolStripMenuItem.Click += purchaseToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(45, 20);
            salesToolStripMenuItem.Text = "Sales";
            salesToolStripMenuItem.Click += salesToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(69, 20);
            inventoryToolStripMenuItem.Text = "Inventory";
            inventoryToolStripMenuItem.Click += inventoryToolStripMenuItem_Click;
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            dealerAndCustomerToolStripMenuItem.Size = new Size(130, 20);
            dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            dealerAndCustomerToolStripMenuItem.Click += dealerAndCustomerToolStripMenuItem_Click;
            // 
            // labelAppname2
            // 
            labelAppname2.AutoSize = true;
            labelAppname2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAppname2.ForeColor = Color.Black;
            labelAppname2.Location = new Point(278, 272);
            labelAppname2.Name = "labelAppname2";
            labelAppname2.Size = new Size(323, 25);
            labelAppname2.TabIndex = 9;
            labelAppname2.Text = "Billing and Inventory Management";
            // 
            // labelAppname
            // 
            labelAppname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAppname.AutoSize = true;
            labelAppname.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelAppname.ForeColor = Color.BlueViolet;
            labelAppname.Location = new Point(394, 240);
            labelAppname.Name = "labelAppname";
            labelAppname.Size = new Size(125, 32);
            labelAppname.TabIndex = 8;
            labelAppname.Text = "Any Store";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.Green;
            labelUsername.Location = new Point(39, 24);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(64, 17);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "mo samy";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.Location = new Point(1, 24);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(40, 17);
            labelUser.TabIndex = 6;
            labelUser.Text = "User:";
            // 
            // pnlfooter
            // 
            pnlfooter.BackColor = Color.Teal;
            pnlfooter.Controls.Add(label1);
            pnlfooter.Dock = DockStyle.Bottom;
            pnlfooter.Location = new Point(0, 412);
            pnlfooter.Name = "pnlfooter";
            pnlfooter.Size = new Size(800, 38);
            pnlfooter.TabIndex = 10;
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
            // frmUserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlfooter);
            Controls.Add(labelAppname2);
            Controls.Add(labelAppname);
            Controls.Add(labelUsername);
            Controls.Add(labelUser);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmUserDashboard";
            Text = "frmUserDashboard";
            FormClosed += frmUserDashboard_FormClosed;
            Load += frmUserDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlfooter.ResumeLayout(false);
            pnlfooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private Label labelAppname2;
        private Label labelAppname;
        private Label labelUsername;
        private Label labelUser;
        private Panel pnlfooter;
        private Label label1;
        private ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
    }
}