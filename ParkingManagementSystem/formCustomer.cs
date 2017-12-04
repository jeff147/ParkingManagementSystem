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
    public partial class formCustomer : Form
    {
        public formCustomer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formMain main = new formMain();
            main.Show();
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newCustomer cust = new newCustomer();
            cust.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editCustomer edit = new editCustomer();
            edit.Show();
        }
    }
}
