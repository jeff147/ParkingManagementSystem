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
    public partial class formMain : Form
    {
        string connectionString;

        public formMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["ParkingManagementSystem.Properties.Settings.ParkingDatabaseConnectionString"].ConnectionString;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            //do some stuffs
        }

        private void btnPermits_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form formPermits = new Form();
            //formPermits.Show();
            //formPermits.ShowDialog();
            this.Hide();
            //this.Close();

            formPermits frm = new ParkingManagementSystem.formPermits();
            frm.Show();
        }

    }
}
