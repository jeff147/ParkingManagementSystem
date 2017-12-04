namespace ParkingManagementSystem
{
    partial class voidTicket
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
            this.voidTicketReason = new System.Windows.Forms.RichTextBox();
            this.voidPermitId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ticketId = new System.Windows.Forms.Label();
            this.btnVoidTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voidTicketReason
            // 
            this.voidTicketReason.Location = new System.Drawing.Point(69, 47);
            this.voidTicketReason.Name = "voidTicketReason";
            this.voidTicketReason.Size = new System.Drawing.Size(100, 96);
            this.voidTicketReason.TabIndex = 10;
            this.voidTicketReason.Text = "";
            // 
            // voidPermitId
            // 
            this.voidPermitId.Location = new System.Drawing.Point(69, 18);
            this.voidPermitId.Name = "voidPermitId";
            this.voidPermitId.Size = new System.Drawing.Size(100, 20);
            this.voidPermitId.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reason:";
            // 
            // ticketId
            // 
            this.ticketId.AutoSize = true;
            this.ticketId.Location = new System.Drawing.Point(10, 21);
            this.ticketId.Name = "ticketId";
            this.ticketId.Size = new System.Drawing.Size(51, 13);
            this.ticketId.TabIndex = 7;
            this.ticketId.Text = "Ticket ID";
            // 
            // btnVoidTicket
            // 
            this.btnVoidTicket.Location = new System.Drawing.Point(563, 413);
            this.btnVoidTicket.Name = "btnVoidTicket";
            this.btnVoidTicket.Size = new System.Drawing.Size(75, 23);
            this.btnVoidTicket.TabIndex = 11;
            this.btnVoidTicket.Text = "Done";
            this.btnVoidTicket.UseVisualStyleBackColor = true;
            this.btnVoidTicket.Click += new System.EventHandler(this.btnVoidTicket_Click);
            // 
            // voidTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 448);
            this.Controls.Add(this.btnVoidTicket);
            this.Controls.Add(this.voidTicketReason);
            this.Controls.Add(this.voidPermitId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ticketId);
            this.Name = "voidTicket";
            this.Text = "Void Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox voidTicketReason;
        private System.Windows.Forms.TextBox voidPermitId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ticketId;
        private System.Windows.Forms.Button btnVoidTicket;
    }
}