using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Searching : Form
    {
        //MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; Initial Catalog = 'general'; username = root; password=");
        
        DataTable table=new DataTable();
        DBAccess objDBAccess = new DBAccess();
        // dtUsers = new DataTable();

        public Searching()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            searchData1("");
            searchData2("");
            searchData3("");
        }
        public void searchData1(string valueToSearch)
        {
            string query = "SELECT * FROM GeneralUserInfo WHERE CONCAT('FirstName', 'LastName', 'Email', 'Phone', 'PresentAddress', 'PermanetAddress', 'NationalID', 'DateofBirth', 'PassportNumber', 'BloodGruop', 'Age', 'Gender') like '%" + valueToSearch + "%'";
            //SqlCommand searchCommand = new SqlCommand(query);

            /* SqlCommand searchCommand = new SqlCommand(query);
             int row = objDBAccess.executeQuery(searchCommand);
             if (row == 1)
             {
                 //adapter.Fill(table);

                 //dataview.DataSource = dtUsers;
             }
             adapter = new SqlDataAdapter(searchCommand);*/
            objDBAccess.readDatathroughAdapter(query,table);

            
            dataview.DataSource = table;

            //dataview.DataSource = dtUsers;
            //objDBAccess.closeConn();
            /**command = new SqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataview.DataSource = table;*/
        }
        public void searchData2(string valueToSearch)
        {
            string query = "SELECT * FROM StudentUserInfo WHERE CONCAT('FirstName', 'LastName', 'Email', 'Phone', 'StudentID', 'SchoolName', 'Class', 'DateofBirth', 'NationalID', 'BloodGruop', 'Age', 'Gender') like '%" + valueToSearch + "%'";
            //SqlCommand searchCommand = new SqlCommand(query);
            /*int row=objDBAccess.executeQuery(searchCommand);
            if(row==1)
            {
                //adapter.Fill(table);

                dataview.DataSource = dtUsers;
            }
            objDBAccess.readDatathroughAdapter(query, dtUsers);
           
            objDBAccess.closeConn();*/

            objDBAccess.readDatathroughAdapter(query, table);
            dataview.DataSource = table;

        }
        public void searchData3(string valueToSearch)
        {
            string query = "SELECT * FROM PoliceUserInfo WHERE CONCAT('FirstName', 'LastName', 'Email', 'Phone', 'PoliceID', 'Area', 'Rank', 'DateofBirth', 'NationalID', 'BloodGruop', 'Age', 'Gender') like '%" + valueToSearch + "%'";
            /* SqlCommand searchCommand = new SqlCommand(query);
             int row = objDBAccess.executeQuery(searchCommand);
             if (row == 1)
             {
                 //adapter.Fill(table);

                 //dataview.DataSource = dtUsers;
             }*/

            objDBAccess.readDatathroughAdapter(query, table);
            dataview.DataSource = table;

            // objDBAccess.readDatathroughAdapter(query, dtUsers);
            //dataview.DataSource = dtUsers;
            //objDBAccess.closeConn();
            /*command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataview.DataSource = table;*/
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            /*string valueToSearch = datasearch.Text.ToString();
            searchData1(valueToSearch);
            searchData2(valueToSearch);
            searchData3(valueToSearch);*/

            //filterStringByColumn("Phone",txtSearchData);


        }
        

        private void datasearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string valueToSearch = txtSearchData.Text.ToString();
                searchData1(valueToSearch);

            }
        }

       /* private void datasearch_MouseEnter(object sender, EventArgs e)
        {
            txtSearchData.Text = "";
        }*/
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile userProfile = new UserProfile();
            userProfile.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void datasearch_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchData_TextChanged(object sender, EventArgs e)
        {
            //filterStringByColumn("Phone", txtSearchData);
            filterStringByColumn("NationalID", txtSearchData);
            //filterStringByColumn("StudentID", txtSearchData);
            //filterStringByColumn("PoliceID", txtSearchData);
            //filterStringByColumn("Age", txtSearchData);
        }
        private void filterStringByColumn(string columnNmae, TextBox txtBox)
        {
            DataView viewData = table.DefaultView;
            
            viewData.RowFilter = columnNmae + " Like '%" + txtBox.Text + "%'";
        }
    }
}
