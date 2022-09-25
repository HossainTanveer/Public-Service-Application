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
    public partial class LoginUserType : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers=new DataTable();

        public LoginUserType()
        {
            InitializeComponent();
        }
        

        private void SearchResult_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

       

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(rdbGeneral.Checked)
            {
                this.Hide();
                Signin signin = new Signin();
                signin.Show();
            }
            if(rdbStudent.Checked)
            {
                this.Hide();
                StudentLogin stLogin = new StudentLogin();
                stLogin.Show();
            }
            if(rdbPolice.Checked)
            {
                this.Hide();
                PoliceLogin pLogin = new PoliceLogin();
                pLogin.Show();
            }
        }

        private void rdbGeneral_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
