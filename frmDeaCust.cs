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
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DeaCustBLL dc = new DeaCustBLL();
        DeaCustDAL dcdal = new DeaCustDAL();
        userDAL udal = new userDAL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dc.type = combodcType.Text;
            dc.name = textName.Text;
            dc.email = textEmail.Text;
            dc.contact = textContact.Text;
            dc.address = textAddress.Text;
            dc.added_date = DateTime.Now;

            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUsr);
            dc.added_by = usr.id;

            bool success = dcdal.Insert(dc);
            if (success)
            {
                MessageBox.Show("dealer/customer inserted successfully");
                clear();
                DataTable dt = dcdal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to insert dealer/customer");
            }
        }
        public void clear()
        {
            textName.Text = "";
            textContact.Text = "";
            textAddress.Text = "";
            textEmail.Text = "";
            textDeaCustID.Text = "";
            combodcType.Text = "";
        }

        private void frmDeaCust_Load(object sender, EventArgs e)
        {
            DataTable dt = dcdal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            textDeaCustID.Text = dgvDeaCust.Rows[rowIndex].Cells[0].Value.ToString();
            combodcType.Text = dgvDeaCust.Rows[rowIndex].Cells[1].Value.ToString();
            textName.Text = dgvDeaCust.Rows[rowIndex].Cells[2].Value.ToString();
            textEmail.Text = dgvDeaCust.Rows[rowIndex].Cells[3].Value.ToString();
            textContact.Text = dgvDeaCust.Rows[rowIndex].Cells[4].Value.ToString();
            textAddress.Text = dgvDeaCust.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(textDeaCustID.Text);
            dc.type = combodcType.Text;
            dc.name = textName.Text;
            dc.email = textEmail.Text;
            dc.address = textAddress.Text;
            dc.contact = textContact.Text;
            dc.added_date = DateTime.Now;

            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUsr);
            dc.added_by = usr.id;

            bool success = dcdal.Update(dc);
            if (success)
            {
                MessageBox.Show("dealer/customer updated successfully");
                clear();
                DataTable dt = dcdal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to update dealer/customer");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(textDeaCustID.Text);

            bool success = dcdal.Delete(dc);
            if (success)
            {
                MessageBox.Show("dealer/customer deleted successfully");
                clear();
                DataTable dt = dcdal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to delete dealer/customer");
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword=textSearch.Text;
            if(keyword.Length > 0)
            {
                DataTable dt = dcdal.Search(keyword);
                dgvDeaCust.DataSource=dt;
            }
            else
            {
                DataTable dt = dcdal.Select();
                dgvDeaCust.DataSource = dt;
            }
        }
    }
}
