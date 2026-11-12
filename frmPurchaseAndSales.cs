using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Billing_system
{
    public partial class frmPurchaseAndSales : Form
    {
        public frmPurchaseAndSales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        DeaCustDAL dcDAL = new DeaCustDAL();
        ProductsDAL pDAL = new ProductsDAL();
        userDAL uDAL = new userDAL();
        transactionDAL tDAL = new transactionDAL();
        transactionDetailDAL tdDAL = new transactionDetailDAL();
        DataTable transactionDT = new DataTable();
        private void frmPurchaseAndSales_Load(object sender, EventArgs e)
        {
            string type = frmUserDashboard.transactionType;
            labelTop.Text = type;
            transactionDT.Columns.Add("ProductName");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textSearch.Text;
            if (keyword == "")
            {
                textName.Text = "";
                textEmail.Text = "";
                textContact.Text = "";
                textaddress.Text = "";
                return;
            }

            DeaCustBLL dc = dcDAL.searchDealerCustomerforTransaction(keyword);
            textName.Text = dc.name;
            textEmail.Text = dc.email;
            textContact.Text = dc.contact;
            textaddress.Text = dc.address;
        }

        private void textProductSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textProductSearch.Text;
            if (keyword == "")
            {
                textProductName.Text = "";
                textProductInventory.Text = "";
                textProductRate.Text = "";
                textProductQty.Text = "";
                return;
            }
            ProductsBLL p = pDAL.GetProductsForTransaction(keyword);
            textProductName.Text = p.name;
            textProductInventory.Text = p.qty.ToString();
            textProductRate.Text = p.rate.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (textProductName.Text == "" || textProductQty.Text == "")
            {
                MessageBox.Show("select the product and qty first,please try again");
            }
            else
            {
                string productName = textProductName.Text;
                decimal Rate = decimal.Parse(textProductRate.Text);
                decimal Qty = decimal.Parse(textProductQty.Text);
                decimal Total = Rate * Qty;
                decimal subTotal = Math.Round(decimal.Parse(textSubtotal.Text), 2);
                subTotal = subTotal + Total;

                transactionDT.Rows.Add(productName, Rate, Qty, Total);
                dgvAddedProducts.DataSource = transactionDT;
                textSubtotal.Text = subTotal.ToString();
                //clear the text boxes
                textProductSearch.Text = "";
                textProductName.Text = "";
                textProductInventory.Text = "0.00";
                textProductQty.Text = "";
                textProductRate.Text = "0.00";
            }
        }

        private void textDiscount_TextChanged(object sender, EventArgs e)
        {
            string value = textDiscount.Text;
            if (value == "")
            {
                MessageBox.Show("please add discount first");
            }
            else
            {
                decimal subTotal = decimal.Parse(textSubtotal.Text);
                decimal discount = decimal.Parse(textDiscount.Text);
                decimal grandTotal = Math.Round((((100 - discount) / 100) * subTotal), 2);
                textGrandtotal.Text = grandTotal.ToString();

            }

        }

        private void textVAT_TextChanged(object sender, EventArgs e)
        {
            string check = textGrandtotal.Text;
            string check2 = textVAT.Text;
            if (check == "")
            {
                MessageBox.Show("caculate the discount and set the grand total first");
            }
            else if (check2 == "")
            {
                MessageBox.Show("calculate VAT first");
            }
            else
            {
                decimal previousGT = decimal.Parse(textGrandtotal.Text);
                decimal vat = decimal.Parse(textVAT.Text);
                decimal grandTotalwithVAT = Math.Round((((100 + vat) / 100) * previousGT), 2);
                textGrandtotal.Text = grandTotalwithVAT.ToString();


            }
        }

        private void textPaidAmount_TextChanged(object sender, EventArgs e)
        {

            if (textPaidAmount.Text != "")
            {
                decimal grandTotal = decimal.Parse(textGrandtotal.Text);
                decimal paidAmount = decimal.Parse(textPaidAmount.Text);
                decimal returnAmount = paidAmount - grandTotal;
                textReturnAmount.Text = returnAmount.ToString();
            }
            else
            {
                MessageBox.Show("please enter paid amount");
            }

        }

        private void btnCalculationSave_Click(object sender, EventArgs e)
        {
            transactionsBLL transaction = new transactionsBLL();
            transaction.type = labelTop.Text;
            string DeaCustName = textName.Text;
            DeaCustBLL dc = dcDAL.GetDeaCustIDFromName(DeaCustName);
            transaction.dea_cust_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(textGrandtotal.Text), 2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(textVAT.Text);
            transaction.discount = decimal.Parse(textDiscount.Text);

            string username = frmLogin.loggedIn;
            userBLL u = uDAL.GetIDFromUsername(username);
            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;

            bool success = false;
            //actual code to insert transaction and transaction details
            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                bool w = tDAL.Insert_Transaction(transaction, out transactionID);
                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    transactionDetailBLL transactionDetail = new transactionDetailBLL();
                    string ProductName = transactionDT.Rows[i][0].ToString();
                    ProductsBLL p = pDAL.GetProductIDFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
                    transactionDetail.dea_cust_id = dc.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = u.id;
                    //here increase of decrease qty based purchase or sale
                    string transactionType = labelTop.Text;
                    //check if we are on purchase or sale
                    bool x = false;
                    if (transactionType == "Purchase")
                    {
                        //increase the product
                        x = pDAL.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    else if (transactionType == "Sales")
                    {
                        //decrease the product
                        x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    //insert transaction details inside database
                    bool y = tdDAL.InsertTransactionDetail(transactionDetail);
                    success = w && x && y;

                }
                if (success)
                {
                    scope.Complete();


                    MessageBox.Show("transaction completed successfully");

                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();
                    textSearch.Text = "";
                    textName.Text = "";
                    textEmail.Text = "";
                    textContact.Text = "";
                    textaddress.Text = "";
                    textProductSearch.Text = "";
                    textProductName.Text = "";
                    textProductInventory.Text = "0";
                    textProductRate.Text = "0";
                    textProductQty.Text = "0";
                    textSubtotal.Text = "0";
                    textDiscount.Text = "0";
                    textVAT.Text = "0";
                    textGrandtotal.Text = "0";
                    textPaidAmount.Text = "0";
                    textReturnAmount.Text = "0";
                }
                else
                {
                    MessageBox.Show("transaction failed");
                }
            }
        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {
            transactionsBLL transaction = new transactionsBLL();
            transaction.type = labelTop.Text;
            string DeaCustName = textName.Text;
            DeaCustBLL dc = dcDAL.GetDeaCustIDFromName(DeaCustName);
            transaction.dea_cust_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(textGrandtotal.Text), 2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(textVAT.Text);
            transaction.discount = decimal.Parse(textDiscount.Text);

            string username = frmLogin.loggedIn;
            userBLL u = uDAL.GetIDFromUsername(username);
            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;

            bool success = false;
            //actual code to insert transaction and transaction details
            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                bool w = tDAL.Insert_Transaction(transaction, out transactionID);
                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    transactionDetailBLL transactionDetail = new transactionDetailBLL();
                    string ProductName = transactionDT.Rows[i][0].ToString();
                    ProductsBLL p = pDAL.GetProductIDFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
                    transactionDetail.dea_cust_id = dc.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = u.id;
                    //here increase of decrease qty based purchase or sale
                    string transactionType = labelTop.Text;
                    //check if we are on purchase or sale
                    bool x = false;
                    if (transactionType == "Purchase")
                    {
                        //increase the product
                        x = pDAL.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    else if (transactionType == "Sales")
                    {
                        //decrease the product
                        x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    //insert transaction details inside database
                    bool y = tdDAL.InsertTransactionDetail(transactionDetail);
                    success = w && x && y;

                }
                if (success)
                {
                    scope.Complete();
                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "\r\n\r\n ANYSTORE 2023";
                    printer.SubTitle = "cairo, egypt \r\n phone 07775000";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Discount: " + textDiscount.Text + "% \r\n" + "VAT: " + textVAT.Text + "% \r\n" + "Grand Total: " + textGrandtotal.Text + "\r\n" + "thank you for your visit";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(dgvAddedProducts);
                    MessageBox.Show("transaction completed successfully");

                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();
                    textSearch.Text = "";
                    textName.Text = "";
                    textEmail.Text = "";
                    textContact.Text = "";
                    textaddress.Text = "";
                    textProductSearch.Text = "";
                    textProductName.Text = "";
                    textProductInventory.Text = "0";
                    textProductRate.Text = "0";
                    textProductQty.Text = "0";
                    textSubtotal.Text = "0";
                    textDiscount.Text = "0";
                    textVAT.Text = "0";
                    textGrandtotal.Text = "0";
                    textPaidAmount.Text = "0";
                    textReturnAmount.Text = "0";
                }
                else
                {
                    MessageBox.Show("transaction failed");
                }
            }
        }

        private void textGrandtotal_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(textGrandtotal.Text);
            if (textPaidAmount.Text != "")
            {
  
                decimal paidAmount = decimal.Parse(textPaidAmount.Text);
                decimal returnAmount = paidAmount - grandTotal;
                textReturnAmount.Text = returnAmount.ToString();
            }

        }
    }
}
