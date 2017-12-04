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
    public partial class formTickets : Form
    {
        public formTickets()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formMain main = new formMain();
            main.Show();
            this.Hide();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            newTicket tick = new newTicket();
            tick.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editTicket edit = new editTicket();
            edit.Show();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            voidTicket voidt = new voidTicket();
            voidt.Show();
        }

        private void formTickets_Load(object sender, EventArgs e)
        {

        }
    }
}
