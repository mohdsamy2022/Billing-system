using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_system
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.title = textTitle.Text;
            c.description = textDescription.Text;
            c.added_date = DateTime.Now;

            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            c.added_by = usr.id;

            bool success = dal.Insert(c);

            if (success)
            {
                MessageBox.Show("new category inserted successfully");
                Clear();
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to insert category");
            }


        }

        public void Clear()
        {
            textCategoryID.Text = "";
            textDescription.Text = "";
            textTitle.Text = "";
            textSearch.Text = "";
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(textCategoryID.Text);
            c.title = textTitle.Text;
            c.description = textDescription.Text;
            c.added_date = DateTime.Now;

            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            c.added_by = usr.id;

            bool success = dal.Update(c);

            if (success)
            {
                MessageBox.Show("category updated successfully");
                Clear();
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to update category");
            }
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            textCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            textDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();
            textTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(textCategoryID.Text);


            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            c.added_by = usr.id;

            bool success = dal.Delete(c);

            if (success)
            {
                MessageBox.Show("category deleted successfully");
                Clear();
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to update category");
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = textSearch.Text;
            if (keywords != null)
            {
                DataTable dt= dal.Search(keywords);
                dgvCategories.DataSource= dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }


        }
    }
}
