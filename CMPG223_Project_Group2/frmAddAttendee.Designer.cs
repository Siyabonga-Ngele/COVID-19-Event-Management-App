namespace CMPG223_Project_Group2
{
    partial class frmAddAttendee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAttendee));
            this.lblAttFName = new System.Windows.Forms.Label();
            this.lblAttLName = new System.Windows.Forms.Label();
            this.txtAttFName = new System.Windows.Forms.TextBox();
            this.txtAttLName = new System.Windows.Forms.TextBox();
            this.txtAttEmail = new System.Windows.Forms.TextBox();
            this.lblAttEmail = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnAddAttendee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbHelp = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAttFName
            // 
            this.lblAttFName.AutoSize = true;
            this.lblAttFName.Location = new System.Drawing.Point(110, 68);
            this.lblAttFName.Name = "lblAttFName";
            this.lblAttFName.Size = new System.Drawing.Size(132, 16);
            this.lblAttFName.TabIndex = 1;
            this.lblAttFName.Text = "Attendee First Name:";
            // 
            // lblAttLName
            // 
            this.lblAttLName.AutoSize = true;
            this.lblAttLName.Location = new System.Drawing.Point(110, 132);
            this.lblAttLName.Name = "lblAttLName";
            this.lblAttLName.Size = new System.Drawing.Size(132, 16);
            this.lblAttLName.TabIndex = 2;
            this.lblAttLName.Text = "Attendee Last Name:";
            // 
            // txtAttFName
            // 
            this.txtAttFName.Location = new System.Drawing.Point(267, 68);
            this.txtAttFName.Name = "txtAttFName";
            this.txtAttFName.Size = new System.Drawing.Size(100, 22);
            this.txtAttFName.TabIndex = 4;
            // 
            // txtAttLName
            // 
            this.txtAttLName.Location = new System.Drawing.Point(267, 132);
            this.txtAttLName.Name = "txtAttLName";
            this.txtAttLName.Size = new System.Drawing.Size(100, 22);
            this.txtAttLName.TabIndex = 5;
            // 
            // txtAttEmail
            // 
            this.txtAttEmail.Location = new System.Drawing.Point(267, 202);
            this.txtAttEmail.Name = "txtAttEmail";
            this.txtAttEmail.Size = new System.Drawing.Size(100, 22);
            this.txtAttEmail.TabIndex = 6;
            // 
            // lblAttEmail
            // 
            this.lblAttEmail.AutoSize = true;
            this.lblAttEmail.Location = new System.Drawing.Point(113, 207);
            this.lblAttEmail.Name = "lblAttEmail";
            this.lblAttEmail.Size = new System.Drawing.Size(101, 16);
            this.lblAttEmail.TabIndex = 7;
            this.lblAttEmail.Text = "Attendee Email:";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(12, 387);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(122, 16);
            this.lblErrorMessage.TabIndex = 8;
            this.lblErrorMessage.Text = "lblErrorMessage";
            // 
            // btnAddAttendee
            // 
            this.btnAddAttendee.Location = new System.Drawing.Point(146, 309);
            this.btnAddAttendee.Name = "btnAddAttendee";
            this.btnAddAttendee.Size = new System.Drawing.Size(197, 45);
            this.btnAddAttendee.TabIndex = 9;
            this.btnAddAttendee.Text = "Add New Attendee";
            this.btnAddAttendee.UseVisualStyleBackColor = true;
            this.btnAddAttendee.Click += new System.EventHandler(this.btnAddAttendee_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbHelp);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 39);
            this.panel1.TabIndex = 10;
            // 
            // cbHelp
            // 
            this.cbHelp.AutoSize = true;
            this.cbHelp.Location = new System.Drawing.Point(431, 11);
            this.cbHelp.Name = "cbHelp";
            this.cbHelp.Size = new System.Drawing.Size(58, 20);
            this.cbHelp.TabIndex = 0;
            this.cbHelp.Text = "Help";
            this.cbHelp.UseVisualStyleBackColor = true;
            this.cbHelp.CheckedChanged += new System.EventHandler(this.cbHelp_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 39);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(374, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Enter the attendee\'s first name here");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(374, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Enter the attendee\'s last name here");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(373, 197);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Enter the attendee\'s email address here");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 0;
            // 
            // frmAddAttendee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(501, 456);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddAttendee);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblAttEmail);
            this.Controls.Add(this.txtAttEmail);
            this.Controls.Add(this.txtAttLName);
            this.Controls.Add(this.txtAttFName);
            this.Controls.Add(this.lblAttLName);
            this.Controls.Add(this.lblAttFName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddAttendee";
            this.Text = "Add Attendee";
            this.Load += new System.EventHandler(this.frmAddAttendee_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAttFName;
        private System.Windows.Forms.Label lblAttLName;
        private System.Windows.Forms.TextBox txtAttFName;
        private System.Windows.Forms.TextBox txtAttLName;
        private System.Windows.Forms.TextBox txtAttEmail;
        private System.Windows.Forms.Label lblAttEmail;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnAddAttendee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}