namespace CMPG223_Project_Group2
{
    partial class frmUpdateThreshold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateThreshold));
            this.dgUpdateThres = new System.Windows.Forms.DataGridView();
            this.lblThresID = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.cbThresID = new System.Windows.Forms.ComboBox();
            this.lblUpdateTempLimit = new System.Windows.Forms.Label();
            this.lblUpdateCapLimit = new System.Windows.Forms.Label();
            this.txtUpdateTempLimit = new System.Windows.Forms.TextBox();
            this.txtUpdateCapLimit = new System.Windows.Forms.TextBox();
            this.btnUpdateThres = new System.Windows.Forms.Button();
            this.btnUpdateTemp = new System.Windows.Forms.Button();
            this.btnUpdateCap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cbHelp = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUpdateThres
            // 
            this.dgUpdateThres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUpdateThres.Location = new System.Drawing.Point(22, 76);
            this.dgUpdateThres.Name = "dgUpdateThres";
            this.dgUpdateThres.RowHeadersWidth = 51;
            this.dgUpdateThres.RowTemplate.Height = 24;
            this.dgUpdateThres.Size = new System.Drawing.Size(745, 150);
            this.dgUpdateThres.TabIndex = 0;
            // 
            // lblThresID
            // 
            this.lblThresID.AutoSize = true;
            this.lblThresID.Location = new System.Drawing.Point(246, 259);
            this.lblThresID.Name = "lblThresID";
            this.lblThresID.Size = new System.Drawing.Size(87, 16);
            this.lblThresID.TabIndex = 1;
            this.lblThresID.Text = "Threshold ID:";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(12, 611);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(122, 16);
            this.lblErrorMessage.TabIndex = 2;
            this.lblErrorMessage.Text = "lblErrorMessage";
            // 
            // cbThresID
            // 
            this.cbThresID.FormattingEnabled = true;
            this.cbThresID.Location = new System.Drawing.Point(348, 259);
            this.cbThresID.Name = "cbThresID";
            this.cbThresID.Size = new System.Drawing.Size(130, 24);
            this.cbThresID.TabIndex = 3;
            // 
            // lblUpdateTempLimit
            // 
            this.lblUpdateTempLimit.AutoSize = true;
            this.lblUpdateTempLimit.Location = new System.Drawing.Point(82, 361);
            this.lblUpdateTempLimit.Name = "lblUpdateTempLimit";
            this.lblUpdateTempLimit.Size = new System.Drawing.Size(174, 16);
            this.lblUpdateTempLimit.TabIndex = 4;
            this.lblUpdateTempLimit.Text = "Updated Temperature Limit:";
            // 
            // lblUpdateCapLimit
            // 
            this.lblUpdateCapLimit.AutoSize = true;
            this.lblUpdateCapLimit.Location = new System.Drawing.Point(82, 436);
            this.lblUpdateCapLimit.Name = "lblUpdateCapLimit";
            this.lblUpdateCapLimit.Size = new System.Drawing.Size(149, 16);
            this.lblUpdateCapLimit.TabIndex = 5;
            this.lblUpdateCapLimit.Text = "Updated Capacity Limit:";
            // 
            // txtUpdateTempLimit
            // 
            this.txtUpdateTempLimit.Location = new System.Drawing.Point(328, 361);
            this.txtUpdateTempLimit.Name = "txtUpdateTempLimit";
            this.txtUpdateTempLimit.Size = new System.Drawing.Size(130, 22);
            this.txtUpdateTempLimit.TabIndex = 6;
            // 
            // txtUpdateCapLimit
            // 
            this.txtUpdateCapLimit.Location = new System.Drawing.Point(328, 433);
            this.txtUpdateCapLimit.Name = "txtUpdateCapLimit";
            this.txtUpdateCapLimit.Size = new System.Drawing.Size(130, 22);
            this.txtUpdateCapLimit.TabIndex = 7;
            // 
            // btnUpdateThres
            // 
            this.btnUpdateThres.Location = new System.Drawing.Point(301, 521);
            this.btnUpdateThres.Name = "btnUpdateThres";
            this.btnUpdateThres.Size = new System.Drawing.Size(197, 44);
            this.btnUpdateThres.TabIndex = 8;
            this.btnUpdateThres.Text = "Update both limits";
            this.btnUpdateThres.UseVisualStyleBackColor = true;
            this.btnUpdateThres.Click += new System.EventHandler(this.btnUpdateThres_Click);
            // 
            // btnUpdateTemp
            // 
            this.btnUpdateTemp.Location = new System.Drawing.Point(535, 361);
            this.btnUpdateTemp.Name = "btnUpdateTemp";
            this.btnUpdateTemp.Size = new System.Drawing.Size(195, 23);
            this.btnUpdateTemp.TabIndex = 9;
            this.btnUpdateTemp.Text = "Update Temperature";
            this.btnUpdateTemp.UseVisualStyleBackColor = true;
            this.btnUpdateTemp.Click += new System.EventHandler(this.btnUpdateTemp_Click);
            // 
            // btnUpdateCap
            // 
            this.btnUpdateCap.Location = new System.Drawing.Point(535, 432);
            this.btnUpdateCap.Name = "btnUpdateCap";
            this.btnUpdateCap.Size = new System.Drawing.Size(195, 23);
            this.btnUpdateCap.TabIndex = 10;
            this.btnUpdateCap.Text = "Update Capacity";
            this.btnUpdateCap.UseVisualStyleBackColor = true;
            this.btnUpdateCap.Click += new System.EventHandler(this.btnUpdateCap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(487, 253);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Always select the desired Threshold ID before clicking any of the update buttons." +
        "");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(467, 427);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Be sure to enter the updated capacity limit here.");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(465, 354);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Be sure to enter the new temperature limit here.");
            // 
            // cbHelp
            // 
            this.cbHelp.AutoSize = true;
            this.cbHelp.Location = new System.Drawing.Point(730, 12);
            this.cbHelp.Name = "cbHelp";
            this.cbHelp.Size = new System.Drawing.Size(58, 20);
            this.cbHelp.TabIndex = 15;
            this.cbHelp.Text = "Help";
            this.cbHelp.UseVisualStyleBackColor = true;
            this.cbHelp.CheckedChanged += new System.EventHandler(this.cbHelp_CheckedChanged);
            // 
            // frmUpdateThreshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.cbHelp);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdateCap);
            this.Controls.Add(this.btnUpdateTemp);
            this.Controls.Add(this.btnUpdateThres);
            this.Controls.Add(this.txtUpdateCapLimit);
            this.Controls.Add(this.txtUpdateTempLimit);
            this.Controls.Add(this.lblUpdateCapLimit);
            this.Controls.Add(this.lblUpdateTempLimit);
            this.Controls.Add(this.cbThresID);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblThresID);
            this.Controls.Add(this.dgUpdateThres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateThreshold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Threshold";
            this.Load += new System.EventHandler(this.frmUpdateThreshold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUpdateThres;
        private System.Windows.Forms.Label lblThresID;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ComboBox cbThresID;
        private System.Windows.Forms.Label lblUpdateTempLimit;
        private System.Windows.Forms.Label lblUpdateCapLimit;
        private System.Windows.Forms.TextBox txtUpdateTempLimit;
        private System.Windows.Forms.TextBox txtUpdateCapLimit;
        private System.Windows.Forms.Button btnUpdateThres;
        private System.Windows.Forms.Button btnUpdateTemp;
        private System.Windows.Forms.Button btnUpdateCap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox cbHelp;
    }
}