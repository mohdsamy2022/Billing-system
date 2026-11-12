using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_system
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        categoriesDAL cdal = new categoriesDAL();
        ProductsBLL p = new ProductsBLL();
        ProductsDAL pdal = new ProductsDAL();
        userDAL udal = new userDAL();
        private void frmProducts_Load(object sender, EventArgs e)
        {
            DataTable categoriesDT = cdal.Select();
            comboCategory.DataSource = categoriesDT;
            comboCategory.DisplayMember = "title";
            comboCategory.ValueMember = "title";
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.name = textName.Text;
            p.category = comboCategory.Text;
            p.description = textDescription.Text;
            p.rate = decimal.Parse(textRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;

            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUsr);
            p.added_by = usr.id;

            bool success = pdal.Insert(p);

            if (success)
            {
                MessageBox.Show("product inserted successfully");
                clear();
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to insert product");
            }
        }

        public void clear()
        {
            textProductID.Text = "";
            textName.Text = "";
            comboCategory.Text = "";
            textDescription.Text = "";
            textRate.Text = "";
            textSearch.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textProductID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            textName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            comboCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            textDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            textRate.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(textProductID.Text);
            p.name = textName.Text;
            p.description = textDescription.Text;
            p.category = comboCategory.Text;
            p.rate = decimal.Parse(textRate.Text);
            p.added_date = DateTime.Now;
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUsr);
            p.added_by = usr.id;

            bool success = pdal.Update(p);
            if (success)
            {
                MessageBox.Show("product updated successfully");
                clear();
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;

            }
            else
            {
                MessageBox.Show("failed to update product");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(textProductID.Text);

            bool success = pdal.Delete(p);
            if (success)
            {
                MessageBox.Show("product deleted successfully");
                clear();
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to delete product");
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = textSearch.Text;
            if (keywords.Length > 0)
            {
                DataTable dt = pdal.Search(keywords);
                dgvProducts.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
        }
    }
}
