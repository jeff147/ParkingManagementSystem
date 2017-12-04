using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    public partial class formVehicles : Form
    {
        public formVehicles()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formMain main = new formMain();
            main.Show();
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newVehicle newv = new newVehicle();
            newv.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editVehicle edit = new editVehicle();
            edit.Show();
            
        }

        private void formVehicles_Load(object sender, EventArgs e)
        {

        }
    }
}
