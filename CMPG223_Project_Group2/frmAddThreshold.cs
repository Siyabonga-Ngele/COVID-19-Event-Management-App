using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.IO;

namespace CMPG223_Project_Group2
{
    public partial class frmAddThreshold : Form
    {

        public frmMainMenu main = new frmMainMenu();
        
        public int thresID;
        public double tempLimit;
        public double capLimit;

        public const int threshRef = 11000;
        
        
        public frmAddThreshold()
        {
            InitializeComponent();
        }

        private void frmAddThreshold_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
            pictureBox2.Hide();
            pictureBox3.Hide();

        }


        public void addThresh()
        {
            //thresID = generateID(threshRef);


            string addNew = $"INSERT INTO THRESHOLD_CRITERIA(Temp_Limit, Capacity_Limit) VALUES ({tempLimit},{capLimit})";
            try
            {
                main.conn.Open();

                main.command = new SqlCommand(addNew, main.conn);
                main.adapter = new SqlDataAdapter();

                main.adapter.InsertCommand = main.command;
                main.adapter.InsertCommand.ExecuteNonQuery();

                main.conn.Close();

                MessageBox.Show("Succesfully added new threshold");

                
                txtTempLimit.Clear();

                frmRemoveThreshold formRemove = new frmRemoveThreshold();
                formRemove.ViewAll();

            }
            catch(SqlException)
            {
                MessageBox.Show("Error adding new threshold");
            }
        }


        private void btnAddThres_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtTempLimit.Text, out tempLimit))
            {
                if(spinbCap.Value != 0)
                {
                    capLimit = Convert.ToDouble(spinbCap.Value);
                    addThresh();
                }
                else
                {
                    lblErrorMessage.Show();
                    lblErrorMessage.Text = "Incorrect data input format for capacity limit";
                    spinbCap.Focus();
                }
            }
            else
            {
                lblErrorMessage.Show();
                lblErrorMessage.Text = "Incorrect data input format for temperature limit";
                txtTempLimit.Clear();
                txtTempLimit.Focus();
            }

        }

        private void cbHelp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHelp.Checked == true)
            {
                pictureBox2.Show();
                pictureBox3.Show();

            }
            else
            {
                pictureBox2.Hide();
                pictureBox3.Hide();

            }
        }
    }
}
