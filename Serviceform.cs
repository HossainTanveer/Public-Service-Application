using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Serviceform : Form
    {
        public Serviceform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.passport.gov.bd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://services.nidw.gov.bd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.police.gov.bd/en/citizen_charter");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile u1 = new UserProfile();
                u1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This may allow authority to track Your Location");
        }
    }
}
