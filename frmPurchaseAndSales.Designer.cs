namespace Billing_system
{
    partial class frmPurchaseAndSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAndSales));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelTop = new Label();
            panelDeaCust = new Panel();
            BillDatedateTimePicker1 = new DateTimePicker();
            textaddress = new TextBox();
            textContact = new TextBox();
            textEmail = new TextBox();
            textName = new TextBox();
            textSearch = new TextBox();
            labelBilldate = new Label();
            labelAddress = new Label();
            labelContact = new Label();
            labelEmail = new Label();
            labelName = new Label();
            labelSearch = new Label();
            labelDeaCustTitle = new Label();
            panel3 = new Panel();
            btnAdd = new Button();
            textProductQty = new TextBox();
            labelQty = new Label();
            textProductRate = new TextBox();
            labelProductRate = new Label();
            textProductInventory = new TextBox();
            labelProductInventory = new Label();
            textProductName = new TextBox();
            label1 = new Label();
            textProductSearch = new TextBox();
            labelProductName = new Label();
            labelProductSearch = new Label();
            panelDGV = new Panel();
            dgvAddedProducts = new DataGridView();
            labelAddedProduct = new Label();
            panelCalculation = new Panel();
            btnSavePrint = new Button();
            btnCalculationSave = new Button();
            textReturnAmount = new TextBox();
            labelReturnamount = new Label();
            textPaidAmount = new TextBox();
            labelPaidamount = new Label();
            textGrandtotal = new TextBox();
            labelGrandtotal = new Label();
            textVAT = new TextBox();
            labelVAT = new Label();
            textDiscount = new TextBox();
            labelDiscount = new Label();
            textSubtotal = new TextBox();
            labelSubtotal = new Label();
            labelCalculationTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDeaCust.SuspendLayout();
            panel3.SuspendLayout();
            panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).BeginInit();
            panelCalculation.SuspendLayout();
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
            panel1.Size = new Size(768, 35);
            panel1.TabIndex = 3;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelTop
            // 
            labelTop.AutoSize = true;
            labelTop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTop.Location = new Point(264, 9);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(155, 21);
            labelTop.TabIndex = 0;
            labelTop.Text = "Purchase and Sales";
            // 
            // panelDeaCust
            // 
            panelDeaCust.Controls.Add(BillDatedateTimePicker1);
            panelDeaCust.Controls.Add(textaddress);
            panelDeaCust.Controls.Add(textContact);
            panelDeaCust.Controls.Add(textEmail);
            panelDeaCust.Controls.Add(textName);
            panelDeaCust.Controls.Add(textSearch);
            panelDeaCust.Controls.Add(labelBilldate);
            panelDeaCust.Controls.Add(labelAddress);
            panelDeaCust.Controls.Add(labelContact);
            panelDeaCust.Controls.Add(labelEmail);
            panelDeaCust.Controls.Add(labelName);
            panelDeaCust.Controls.Add(labelSearch);
            panelDeaCust.Controls.Add(labelDeaCustTitle);
            panelDeaCust.Location = new Point(12, 41);
            panelDeaCust.Name = "panelDeaCust";
            panelDeaCust.Size = new Size(744, 86);
            panelDeaCust.TabIndex = 4;
            // 
            // BillDatedateTimePicker1
            // 
            BillDatedateTimePicker1.Location = new Point(631, 24);
            BillDatedateTimePicker1.Name = "BillDatedateTimePicker1";
            BillDatedateTimePicker1.Size = new Size(110, 23);
            BillDatedateTimePicker1.TabIndex = 28;
            // 
            // textaddress
            // 
            textaddress.Location = new Point(439, 27);
            textaddress.Multiline = true;
            textaddress.Name = "textaddress";
            textaddress.Size = new Size(133, 54);
            textaddress.TabIndex = 27;
            // 
            // textContact
            // 
            textContact.Location = new Point(245, 58);
            textContact.Name = "textContact";
            textContact.Size = new Size(133, 23);
            textContact.TabIndex = 26;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(245, 27);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(133, 23);
            textEmail.TabIndex = 25;
            // 
            // textName
            // 
            textName.Location = new Point(51, 55);
            textName.Name = "textName";
            textName.Size = new Size(133, 23);
            textName.TabIndex = 24;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(51, 27);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(133, 23);
            textSearch.TabIndex = 23;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // labelBilldate
            // 
            labelBilldate.AutoSize = true;
            labelBilldate.Location = new Point(578, 27);
            labelBilldate.Name = "labelBilldate";
            labelBilldate.Size = new Size(50, 15);
            labelBilldate.TabIndex = 22;
            labelBilldate.Text = "Bill Date";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(384, 27);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(49, 15);
            labelAddress.TabIndex = 21;
            labelAddress.Text = "Address";
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Location = new Point(190, 61);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(49, 15);
            labelContact.TabIndex = 20;
            labelContact.Text = "Contact";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(190, 30);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 19;
            labelEmail.Text = "Email";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 58);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 18;
            labelName.Text = "Name";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(6, 27);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(42, 15);
            labelSearch.TabIndex = 17;
            labelSearch.Text = "Search";
            // 
            // labelDeaCustTitle
            // 
            labelDeaCustTitle.AutoSize = true;
            labelDeaCustTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeaCustTitle.Location = new Point(3, 5);
            labelDeaCustTitle.Name = "labelDeaCustTitle";
            labelDeaCustTitle.Size = new Size(168, 17);
            labelDeaCustTitle.TabIndex = 16;
            labelDeaCustTitle.Text = "Dealer / Customer Details";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(textProductQty);
            panel3.Controls.Add(labelQty);
            panel3.Controls.Add(textProductRate);
            panel3.Controls.Add(labelProductRate);
            panel3.Controls.Add(textProductInventory);
            panel3.Controls.Add(labelProductInventory);
            panel3.Controls.Add(textProductName);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textProductSearch);
            panel3.Controls.Add(labelProductName);
            panel3.Controls.Add(labelProductSearch);
            panel3.Location = new Point(12, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(744, 70);
            panel3.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.GreenYellow;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(666, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textProductQty
            // 
            textProductQty.Location = new Point(694, 30);
            textProductQty.Name = "textProductQty";
            textProductQty.Size = new Size(47, 23);
            textProductQty.TabIndex = 38;
            // 
            // labelQty
            // 
            labelQty.AutoSize = true;
            labelQty.Location = new Point(662, 33);
            labelQty.Name = "labelQty";
            labelQty.Size = new Size(26, 15);
            labelQty.TabIndex = 37;
            labelQty.Text = "Qty";
            // 
            // textProductRate
            // 
            textProductRate.Location = new Point(609, 30);
            textProductRate.Name = "textProductRate";
            textProductRate.Size = new Size(47, 23);
            textProductRate.TabIndex = 36;
            // 
            // labelProductRate
            // 
            labelProductRate.AutoSize = true;
            labelProductRate.Location = new Point(573, 33);
            labelProductRate.Name = "labelProductRate";
            labelProductRate.Size = new Size(30, 15);
            labelProductRate.TabIndex = 35;
            labelProductRate.Text = "Rate";
            // 
            // textProductInventory
            // 
            textProductInventory.Location = new Point(434, 30);
            textProductInventory.Name = "textProductInventory";
            textProductInventory.Size = new Size(133, 23);
            textProductInventory.TabIndex = 34;
            // 
            // labelProductInventory
            // 
            labelProductInventory.AutoSize = true;
            labelProductInventory.Location = new Point(371, 33);
            labelProductInventory.Name = "labelProductInventory";
            labelProductInventory.Size = new Size(57, 15);
            labelProductInventory.TabIndex = 33;
            labelProductInventory.Text = "Inventory";
            // 
            // textProductName
            // 
            textProductName.Location = new Point(232, 30);
            textProductName.Name = "textProductName";
            textProductName.Size = new Size(133, 23);
            textProductName.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 17;
            label1.Text = "Product Details";
            // 
            // textProductSearch
            // 
            textProductSearch.Location = new Point(51, 30);
            textProductSearch.Name = "textProductSearch";
            textProductSearch.Size = new Size(133, 23);
            textProductSearch.TabIndex = 31;
            textProductSearch.TextChanged += textProductSearch_TextChanged;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(190, 33);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(39, 15);
            labelProductName.TabIndex = 30;
            labelProductName.Text = "Name";
            // 
            // labelProductSearch
            // 
            labelProductSearch.AutoSize = true;
            labelProductSearch.Location = new Point(6, 30);
            labelProductSearch.Name = "labelProductSearch";
            labelProductSearch.Size = new Size(42, 15);
            labelProductSearch.TabIndex = 29;
            labelProductSearch.Text = "Search";
            // 
            // panelDGV
            // 
            panelDGV.Controls.Add(dgvAddedProducts);
            panelDGV.Controls.Add(labelAddedProduct);
            panelDGV.Location = new Point(12, 209);
            panelDGV.Name = "panelDGV";
            panelDGV.Size = new Size(378, 197);
            panelDGV.TabIndex = 6;
            // 
            // dgvAddedProducts
            // 
            dgvAddedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddedProducts.Location = new Point(8, 20);
            dgvAddedProducts.Name = "dgvAddedProducts";
            dgvAddedProducts.RowTemplate.Height = 25;
            dgvAddedProducts.Size = new Size(357, 174);
            dgvAddedProducts.TabIndex = 19;
            // 
            // labelAddedProduct
            // 
            labelAddedProduct.AutoSize = true;
            labelAddedProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddedProduct.Location = new Point(3, 0);
            labelAddedProduct.Name = "labelAddedProduct";
            labelAddedProduct.Size = new Size(106, 17);
            labelAddedProduct.TabIndex = 18;
            labelAddedProduct.Text = "Added Products";
            // 
            // panelCalculation
            // 
            panelCalculation.Controls.Add(btnSavePrint);
            panelCalculation.Controls.Add(btnCalculationSave);
            panelCalculation.Controls.Add(textReturnAmount);
            panelCalculation.Controls.Add(labelReturnamount);
            panelCalculation.Controls.Add(textPaidAmount);
            panelCalculation.Controls.Add(labelPaidamount);
            panelCalculation.Controls.Add(textGrandtotal);
            panelCalculation.Controls.Add(labelGrandtotal);
            panelCalculation.Controls.Add(textVAT);
            panelCalculation.Controls.Add(labelVAT);
            panelCalculation.Controls.Add(textDiscount);
            panelCalculation.Controls.Add(labelDiscount);
            panelCalculation.Controls.Add(textSubtotal);
            panelCalculation.Controls.Add(labelSubtotal);
            panelCalculation.Controls.Add(labelCalculationTitle);
            panelCalculation.Location = new Point(396, 209);
            panelCalculation.Name = "panelCalculation";
            panelCalculation.Size = new Size(360, 197);
            panelCalculation.TabIndex = 7;
            // 
            // btnSavePrint
            // 
            btnSavePrint.BackColor = Color.LightYellow;
            btnSavePrint.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSavePrint.Location = new Point(256, 131);
            btnSavePrint.Name = "btnSavePrint";
            btnSavePrint.Size = new Size(87, 52);
            btnSavePrint.TabIndex = 41;
            btnSavePrint.Text = "Save and Print";
            btnSavePrint.UseVisualStyleBackColor = false;
            btnSavePrint.Click += btnSavePrint_Click;
            // 
            // btnCalculationSave
            // 
            btnCalculationSave.BackColor = Color.LightYellow;
            btnCalculationSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculationSave.Location = new Point(256, 91);
            btnCalculationSave.Name = "btnCalculationSave";
            btnCalculationSave.Size = new Size(87, 23);
            btnCalculationSave.TabIndex = 40;
            btnCalculationSave.Text = "Save";
            btnCalculationSave.UseVisualStyleBackColor = false;
            btnCalculationSave.Click += btnCalculationSave_Click;
            // 
            // textReturnAmount
            // 
            textReturnAmount.Location = new Point(96, 165);
            textReturnAmount.Name = "textReturnAmount";
            textReturnAmount.Size = new Size(133, 23);
            textReturnAmount.TabIndex = 40;
            // 
            // labelReturnamount
            // 
            labelReturnamount.AutoSize = true;
            labelReturnamount.Location = new Point(3, 168);
            labelReturnamount.Name = "labelReturnamount";
            labelReturnamount.Size = new Size(89, 15);
            labelReturnamount.TabIndex = 39;
            labelReturnamount.Text = "Return Amount";
            // 
            // textPaidAmount
            // 
            textPaidAmount.Location = new Point(96, 136);
            textPaidAmount.Name = "textPaidAmount";
            textPaidAmount.Size = new Size(133, 23);
            textPaidAmount.TabIndex = 38;
            textPaidAmount.TextChanged += textPaidAmount_TextChanged;
            // 
            // labelPaidamount
            // 
            labelPaidamount.AutoSize = true;
            labelPaidamount.Location = new Point(3, 139);
            labelPaidamount.Name = "labelPaidamount";
            labelPaidamount.Size = new Size(77, 15);
            labelPaidamount.TabIndex = 37;
            labelPaidamount.Text = "Paid Amount";
            // 
            // textGrandtotal
            // 
            textGrandtotal.Location = new Point(96, 107);
            textGrandtotal.Name = "textGrandtotal";
            textGrandtotal.Size = new Size(133, 23);
            textGrandtotal.TabIndex = 36;
            textGrandtotal.TextChanged += textGrandtotal_TextChanged;
            // 
            // labelGrandtotal
            // 
            labelGrandtotal.AutoSize = true;
            labelGrandtotal.Location = new Point(3, 110);
            labelGrandtotal.Name = "labelGrandtotal";
            labelGrandtotal.Size = new Size(67, 15);
            labelGrandtotal.TabIndex = 35;
            labelGrandtotal.Text = "Grand Total";
            // 
            // textVAT
            // 
            textVAT.Location = new Point(96, 78);
            textVAT.Name = "textVAT";
            textVAT.Size = new Size(133, 23);
            textVAT.TabIndex = 34;
            textVAT.TextChanged += textVAT_TextChanged;
            // 
            // labelVAT
            // 
            labelVAT.AutoSize = true;
            labelVAT.Location = new Point(5, 81);
            labelVAT.Name = "labelVAT";
            labelVAT.Size = new Size(39, 15);
            labelVAT.TabIndex = 33;
            labelVAT.Text = "VAT %";
            // 
            // textDiscount
            // 
            textDiscount.Location = new Point(96, 49);
            textDiscount.Name = "textDiscount";
            textDiscount.Size = new Size(133, 23);
            textDiscount.TabIndex = 32;
            textDiscount.TextChanged += textDiscount_TextChanged;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(3, 52);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(70, 15);
            labelDiscount.TabIndex = 31;
            labelDiscount.Text = " Discount %";
            // 
            // textSubtotal
            // 
            textSubtotal.Location = new Point(96, 20);
            textSubtotal.Name = "textSubtotal";
            textSubtotal.Size = new Size(133, 23);
            textSubtotal.TabIndex = 30;
            textSubtotal.Text = "0";
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Location = new Point(3, 23);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(55, 15);
            labelSubtotal.TabIndex = 29;
            labelSubtotal.Text = "Sub Total";
            // 
            // labelCalculationTitle
            // 
            labelCalculationTitle.AutoSize = true;
            labelCalculationTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCalculationTitle.Location = new Point(0, 0);
            labelCalculationTitle.Name = "labelCalculationTitle";
            labelCalculationTitle.Size = new Size(124, 17);
            labelCalculationTitle.TabIndex = 19;
            labelCalculationTitle.Text = "Calculation Details";
            // 
            // frmPurchaseAndSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(768, 418);
            Controls.Add(panelCalculation);
            Controls.Add(panelDGV);
            Controls.Add(panel3);
            Controls.Add(panelDeaCust);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPurchaseAndSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPurchaseAndSales";
            Load += frmPurchaseAndSales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDeaCust.ResumeLayout(false);
            panelDeaCust.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelDGV.ResumeLayout(false);
            panelDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).EndInit();
            panelCalculation.ResumeLayout(false);
            panelCalculation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelTop;
        private Panel panelDeaCust;
        private Panel panel3;
        private Panel panelDGV;
        private Panel panelCalculation;
        private Label labelDeaCustTitle;
        private Label label1;
        private Label labelAddedProduct;
        private Label labelCalculationTitle;
        private Label labelBilldate;
        private Label labelAddress;
        private Label labelContact;
        private Label labelEmail;
        private Label labelName;
        private Label labelSearch;
        private TextBox textaddress;
        private TextBox textContact;
        private TextBox textEmail;
        private TextBox textName;
        private TextBox textSearch;
        private DateTimePicker BillDatedateTimePicker1;
        private TextBox textProductQty;
        private Label labelQty;
        private TextBox textProductRate;
        private Label labelProductRate;
        private TextBox textProductInventory;
        private Label labelProductInventory;
        private TextBox textProductName;
        private TextBox textProductSearch;
        private Label labelProductName;
        private Label labelProductSearch;
        private Button btnAdd;
        private DataGridView dgvAddedProducts;
        private TextBox textReturnAmount;
        private Label labelReturnamount;
        private TextBox textPaidAmount;
        private Label labelPaidamount;
        private TextBox textGrandtotal;
        private Label labelGrandtotal;
        private TextBox textVAT;
        private Label labelVAT;
        private TextBox textDiscount;
        private Label labelDiscount;
        private TextBox textSubtotal;
        private Label labelSubtotal;
        private Button btnCalculationSave;
        private Button btnSavePrint;
    }
}