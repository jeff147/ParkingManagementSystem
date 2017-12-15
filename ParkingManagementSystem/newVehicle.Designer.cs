namespace ParkingManagementSystem
{
    partial class newVehicle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewVehicleDone = new System.Windows.Forms.Button();
            this.makeBox = new System.Windows.Forms.TextBox();
            this.listBoxTest = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.licensePlateBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.vinBox = new System.Windows.Forms.TextBox();
            this.vehicleIdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "License Plate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "State:";
            // 
            // btnNewVehicleDone
            // 
            this.btnNewVehicleDone.Location = new System.Drawing.Point(1020, 572);
            this.btnNewVehicleDone.Name = "btnNewVehicleDone";
            this.btnNewVehicleDone.Size = new System.Drawing.Size(75, 23);
            this.btnNewVehicleDone.TabIndex = 23;
            this.btnNewVehicleDone.Text = "Done";
            this.btnNewVehicleDone.UseVisualStyleBackColor = true;
            this.btnNewVehicleDone.Click += new System.EventHandler(this.btnNewVehicle_Click);
            // 
            // makeBox
            // 
            this.makeBox.Location = new System.Drawing.Point(128, 15);
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(100, 20);
            this.makeBox.TabIndex = 24;
            this.makeBox.TextChanged += new System.EventHandler(this.makeBox_TextChanged);
            // 
            // listBoxTest
            // 
            this.listBoxTest.FormattingEnabled = true;
            this.listBoxTest.Location = new System.Drawing.Point(45, 213);
            this.listBoxTest.Name = "listBoxTest";
            this.listBoxTest.Size = new System.Drawing.Size(900, 329);
            this.listBoxTest.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "VIN:";
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(128, 41);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(100, 20);
            this.modelBox.TabIndex = 27;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(128, 67);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(100, 20);
            this.yearBox.TabIndex = 28;
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(128, 93);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(100, 20);
            this.colorBox.TabIndex = 29;
            // 
            // licensePlateBox
            // 
            this.licensePlateBox.Location = new System.Drawing.Point(128, 119);
            this.licensePlateBox.Name = "licensePlateBox";
            this.licensePlateBox.Size = new System.Drawing.Size(100, 20);
            this.licensePlateBox.TabIndex = 30;
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(128, 146);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(100, 20);
            this.stateBox.TabIndex = 31;
            // 
            // vinBox
            // 
            this.vinBox.Location = new System.Drawing.Point(128, 172);
            this.vinBox.Name = "vinBox";
            this.vinBox.Size = new System.Drawing.Size(100, 20);
            this.vinBox.TabIndex = 32;
            // 
            // vehicleIdBox
            // 
            this.vehicleIdBox.Location = new System.Drawing.Point(541, 116);
            this.vehicleIdBox.Name = "vehicleIdBox";
            this.vehicleIdBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleIdBox.TabIndex = 33;
            // 
            // newVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 607);
            this.Controls.Add(this.vehicleIdBox);
            this.Controls.Add(this.vinBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.licensePlateBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxTest);
            this.Controls.Add(this.makeBox);
            this.Controls.Add(this.btnNewVehicleDone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "newVehicle";
            this.Text = "New Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewVehicleDone;
        private System.Windows.Forms.TextBox makeBox;
        private System.Windows.Forms.ListBox listBoxTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.TextBox licensePlateBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox vinBox;
        private System.Windows.Forms.TextBox vehicleIdBox;
    }
}