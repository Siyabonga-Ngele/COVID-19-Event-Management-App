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

namespace CMPG223_Project_Group2
{
    public partial class frmUpdateThreshold : Form
    {

        public frmMainMenu main = new frmMainMenu();

        public double tempLimit;
        public int capLimit;

        public frmUpdateThreshold()
        {
            InitializeComponent();
        }

        private void frmUpdateThreshold_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Hide();
            ViewAll();
            fillComboBoxes();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        public void ViewAll()
        {
            string selectAll = "SELECT Thres_ID, Temp_Limit, Capacity_Limit FROM THRESHOLD_CRITERIA";

            try
            {
                main.conn.Open();
                main.command = new SqlCommand(selectAll, main.conn);

                main.data = new DataSet();
                main.adapter = new SqlDataAdapter();
                main.adapter.SelectCommand = main.command;

                main.adapter.Fill(main.data, "THRESHOLD_CRITERIA");
                dgUpdateThres.DataSource = main.data;
                dgUpdateThres.DataMember = "THRESHOLD_CRITERIA";

                main.conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error loading Threshold database");
            }
        }

        public void fillComboBoxes()
        {
            string selectID = "SELECT Thres_ID FROM THRESHOLD_CRITERIA";

            try
            {
                main.conn.Open();
                main.command = new SqlCommand(selectID, main.conn);
                main.data = new DataSet();
                main.adapter = new SqlDataAdapter();

                main.adapter.SelectCommand = main.command;
                main.adapter.Fill(main.data, "THRESHOLD_CRITERIA");

                cbThresID.DataSource = main.data.Tables["THRESHOLD_CRITERIA"];
                cbThresID.DisplayMember = "Thres_ID";
                cbThresID.ValueMember = "Thres_ID";
                cbThresID.SelectedIndex = -1;

                main.conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not populate combo box");
            }
        }

        private void btnUpdateThres_Click(object sender, EventArgs e)
        {

            if (cbThresID.SelectedValue != null)
            {
                
                if(txtUpdateCapLimit.Text == "")
                {
                    MessageBox.Show("Please enter a capacity limit");
                }
                else if(txtUpdateTempLimit.Text == "")
                {
                    MessageBox.Show("Please enter a temperature limit");
                }
                else if(double.TryParse(txtUpdateTempLimit.Text, out double tempLimit))
                {
                    if(int.TryParse(txtUpdateCapLimit.Text, out int capLimit))
                    {
                        try
                        {
                            string updateThres = $"UPDATE THRESHOLD_CRITERIA SET Temp_Limit = {double.Parse(txtUpdateTempLimit.Text)}, Capacity_Limit = {int.Parse(txtUpdateCapLimit.Text)} WHERE Thres_ID = '" + cbThresID.SelectedValue + "'";

                            main.conn.Open();
                            main.command = new SqlCommand(updateThres, main.conn);

                            main.command.ExecuteNonQuery();
                            main.conn.Close();

                            ViewAll();
                        }
                        catch(SqlException)
                        {
                            MessageBox.Show("Error updating both limits");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid capcity limit integer");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid temperature limit digit");
                }
                
            }
            else
            {
                MessageBox.Show("Please select a Threshold ID to update its data");
            }
            
        }

        private void btnUpdateTemp_Click(object sender, EventArgs e)
        {

            if (cbThresID.SelectedValue != null)
            {
                if(txtUpdateTempLimit.Text != "")
                {
                    
                    if (double.TryParse(txtUpdateTempLimit.Text, out double tempLimit))
                    {
                        try
                        {
                            string updateThres = $"UPDATE THRESHOLD_CRITERIA SET Temp_Limit = {double.Parse(txtUpdateTempLimit.Text)} WHERE Thres_ID = '" + cbThresID.SelectedValue + "'";

                            main.conn.Open();
                            main.command = new SqlCommand(updateThres, main.conn);

                            main.command.ExecuteNonQuery();
                            main.conn.Close();

                            ViewAll();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error updating threshold");
                        }
                    }
                    else
                    {
                        lblErrorMessage.Visible = true;
                        lblErrorMessage.Text = "Please enter a valid number to be updated";
                        txtUpdateTempLimit.Clear();
                        txtUpdateTempLimit.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please eneter a temperature value");
                }
            }
            else
            {
                MessageBox.Show("Please select a threshold ID to update its limits");
                cbThresID.Focus();
            }
        }

        private void btnUpdateCap_Click(object sender, EventArgs e)
        {

            if (cbThresID.SelectedValue != null)
            {
                if (txtUpdateCapLimit.Text != "")
                {
                    
                    if (int.TryParse(txtUpdateCapLimit.Text, out int capLimit))
                    {
                        try
                        {
                            string updateThres = $"UPDATE THRESHOLD_CRITERIA SET Capacity_Limit = {int.Parse(txtUpdateCapLimit.Text)} WHERE Thres_ID = '" + cbThresID.SelectedValue + "'";

                            main.conn.Open();
                            main.command = new SqlCommand(updateThres, main.conn);

                            main.command.ExecuteNonQuery();
                            main.conn.Close();

                            ViewAll();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Error updating threshold");
                        }
                    }
                    else
                    {
                        lblErrorMessage.Visible = true;
                        lblErrorMessage.Text = "Please enter a valid integer to be updated";
                        txtUpdateTempLimit.Clear();
                        txtUpdateTempLimit.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please eneter a capacity limit value");
                }
            }
            else
            {
                MessageBox.Show("Please select a threshold ID to update its limits");
                cbThresID.Focus();
            }
        }

        private void cbHelp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHelp.Checked == true)
            {
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();

            }
            else
            {
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();

            }
        }
    }
}
