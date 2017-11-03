using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ParkingManagementSystem
{
    public partial class formPermits : Form
    {
        public formPermits()
        {
            InitializeComponent();
        }

        private void formPermits_Load(object sender, EventArgs e)
        {
            //things
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            issuePermit issue = new issuePermit();
            issue.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editPermit edit = new editPermit();
            edit.Show();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            voidPermit voidp = new voidPermit();
            voidp.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formMain main = new formMain();
            main.Show();
            this.Hide();
        }
    }
}
