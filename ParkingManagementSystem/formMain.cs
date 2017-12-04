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
        SqlConnection connection;
        string connectionString;

        public formMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["ParkingManagementSystem.Properties.Settings.ParkingDatabaseConnectionString"].ConnectionString;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // do some stuffs
            test();
        }

        private void btnPermits_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form formPermits = new Form();
            //formPermits.Show();
            //formPermits.ShowDialog();
            this.Hide();
            //this.Close();
            //this.Dispose();

            formPermits frm = new ParkingManagementSystem.formPermits();
            frm.Show();
            //this.Close();
            //this.Dispose();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            this.Hide();
            formVehicles frm = new ParkingManagementSystem.formVehicles();
            frm.Show();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTickets frm = new ParkingManagementSystem.formTickets();
            frm.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCustomer frm = new ParkingManagementSystem.formCustomer();
            frm.Show();
        }

        private void test()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", connection))
            {
                //connection.Open();

                DataTable testTable = new DataTable();
                adapter.Fill(testTable);

                listBox1.DataSource = testTable;
                listBox1.DisplayMember = "lastName";
                listBox1.ValueMember = "custId";
                

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
