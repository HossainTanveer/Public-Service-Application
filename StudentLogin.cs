using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class StudentLogin : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();


        public StudentLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userEmailLogin = txtEmail.Text;
            string userPasswordLogin = txtPassword.Text;

            if (userEmailLogin.Equals(""))
            {
                MessageBox.Show("Enter your email or phone number");
            }
            else if (userPasswordLogin.Equals(""))
            {
                MessageBox.Show("Enter your password.");
            }
            else
            {
                string query = "Select * From StudentUserInfo Where Email='" + userEmailLogin + "'AND Password='" + userPasswordLogin + "'";

                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {

                    MessageBox.Show("You are in.");
                    this.Hide();
                    UserProfile f2 = new UserProfile();
                    f2.Show();

                }
                else
                {
                    MessageBox.Show("Invalid credentials you provide..Try again");
                }

            }
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void lblCreateNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            catagory cat = new catagory();
            cat.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUserType luType = new LoginUserType();
            luType.Show();
        }
    }
}
