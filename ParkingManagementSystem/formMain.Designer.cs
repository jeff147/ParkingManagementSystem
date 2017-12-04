namespace ParkingManagementSystem
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPermits = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPermits
            // 
            this.btnPermits.Location = new System.Drawing.Point(24, 13);
            this.btnPermits.Name = "btnPermits";
            this.btnPermits.Size = new System.Drawing.Size(75, 23);
            this.btnPermits.TabIndex = 0;
            this.btnPermits.Text = "Permits";
            this.btnPermits.UseVisualStyleBackColor = true;
            this.btnPermits.Click += new System.EventHandler(this.btnPermits_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.Location = new System.Drawing.Point(24, 42);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(75, 23);
            this.btnVehicles.TabIndex = 1;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.Location = new System.Drawing.Point(24, 72);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(75, 23);
            this.btnTickets.TabIndex = 2;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.UseVisualStyleBackColor = true;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(24, 102);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 252);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1026, 108);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 589);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnTickets);
            this.Controls.Add(this.btnVehicles);
            this.Controls.Add(this.btnPermits);
            this.Name = "formMain";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPermits;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.ListBox listBox1;
    }
}

