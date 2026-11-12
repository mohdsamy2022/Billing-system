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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        userDAL dal = new userDAL();
        userBLL u = new userBLL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            
            u.first_name = txtFirstname.Text;
            u.last_name = txtLastname.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = comboGender.Text;
            u.user_type = comboUsertype.Text;
            u.added_date = DateTime.Now;
            //getting username of the logged in user
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = dal.GetIDFromUsername(loggedUser);
            u.added_by = usr.id;

            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("user created successfully");
                clear();
            }
            else
            {
                MessageBox.Show("failed to add new user");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }
        private void clear()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            comboGender.Text = "";
            comboUsertype.Text = "";
            txtUserID.Text = "";

        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstname.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastname.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            comboGender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            comboUsertype.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtUserID.Text);
            u.first_name = txtFirstname.Text;
            u.last_name = txtLastname.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = comboGender.Text;
            u.user_type = comboUsertype.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            bool success = dal.Update(u);
            if (success)
            {
                MessageBox.Show("user updated successfully");
                clear();
            }
            else
            {
                MessageBox.Show("failed to update user");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            u.id= Convert.ToInt32(txtUserID.Text);

            bool success = dal.Delete(u);
            if (success) 
            {
                MessageBox.Show("user deleted successfully");
                clear();
            }
            else
            {
                MessageBox.Show("failed to delete user");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }
    }
}
