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
    public partial class newVehicle : Form
    {
        SqlConnection connection;
        string connectionString;

        public newVehicle()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["ParkingManagementSystem.Properties.Settings.ParkingDatabaseConnectionString"].ConnectionString;
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            string query = "SET IDENTITY_INSERT Vehicles ON;INSERT INTO Vehicles(vehicleId, licensePlate, state, make, model, year, color, VIN) " +
                "VALUES ('@vehicleId', '@licensePlate', '@state', '@make', '@model', '@year', '@color', '@VIN');SET IDENTITY_INSERT Vehicles OFF;";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            //using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@vehicleId", Int32.Parse(vehicleIdBox.Text));
                command.Parameters.AddWithValue("@licensePlate", licensePlateBox.Text);
                command.Parameters.AddWithValue("@state", stateBox.Text);
                command.Parameters.AddWithValue("@make", makeBox.Text);
                command.Parameters.AddWithValue("@model", modelBox.Text);
                command.Parameters.AddWithValue("@year", yearBox.Text);
                command.Parameters.AddWithValue("@color", colorBox.Text);
                command.Parameters.AddWithValue("@VIN", vinBox.Text);

                command.ExecuteNonQuery();

                connection.Close();
            }
                //this.Hide();
        }

        private void makeBox_TextChanged(object sender, EventArgs e)
        {
            /*string query = "INSERT @vehicleId @licensePlate @state @make @model @year @color @VIN";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            //using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@vehicleId", vehicleIdBox.Text);
                command.Parameters.AddWithValue("@licensePlate", licensePlateBox.Text);
                command.Parameters.AddWithValue("@state", stateBox.Text);
                command.Parameters.AddWithValue("@make", makeBox.Text);
                command.Parameters.AddWithValue("@model", modelBox.Text);
                command.Parameters.AddWithValue("@year", yearBox.Text);
                command.Parameters.AddWithValue("@color", colorBox.Text);
                command.Parameters.AddWithValue("@VIN", vinBox.Text);

                command.ExecuteNonQuery();

                connection.Close();

                //DataTable newVehicleTable = new DataTable();
                //adapter.Fill(newVehicleTable);

                //listBoxTest.DisplayMember = "licensePlate";
                //listBoxTest.ValueMember = "vehicleId";
                //listBoxTest.DataSource = newVehicleTable;

                //listBoxTest.DisplayMember = "vehicleId";
            }*/

        }
    }
}
