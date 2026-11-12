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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        categoriesDAL cdal = new categoriesDAL();
        ProductsDAL pdal = new ProductsDAL();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            DataTable cdt = cdal.Select();
            comboCategory.DataSource = cdt;
            comboCategory.DisplayMember = "title";
            comboCategory.ValueMember = "title";
            DataTable pdt = pdal.Select();
            dgvInventory.DataSource = pdt;
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboCategory.Text;
            DataTable dt = pdal.DispalyProductByCategory(category);
            dgvInventory.DataSource = dt;
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            DataTable dt=pdal.Select();
            dgvInventory.DataSource=dt;
        }
    }
}
