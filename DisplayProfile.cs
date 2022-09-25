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
    public partial class DisplayProfile : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();



        public DisplayProfile()
        {
            InitializeComponent();
        }

        private void DisplayProfile_Load(object sender, EventArgs e)
        {
            string query = "Select * From GeneralUserInfo Where ID='"+Signin.id+"'";
            objDBAccess.readDatathroughAdapter(query,dtUsers);
            dataGridViewDSP.DataSource = dtUsers;
            objDBAccess.closeConn();

        }

        private void btnBackDSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            //LoginUserType LUtype = new LoginUserType();
            //LUtype.Show();
            //Signin signin = new Signin();
            //signin.Show();

            UserProfile upro = new UserProfile();
            upro.Show();
        }

        private void dataGridViewDSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
