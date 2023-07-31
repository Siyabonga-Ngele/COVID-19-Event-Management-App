using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Data.SqlClient;

namespace CMPG223_Project_Group2
{
    public partial class frmAddEvent : Form
    {
        public frmAddEvent()
        {
            InitializeComponent();
        }

        public frmMainMenu main = new frmMainMenu();


        //method to populate province combobox
        public void populateProvince()
        {
            cbProvince.Items.Clear();

            try
            {
                main.conn.Open();

                //select sql
                string selectSql = $"SELECT DISTINCT LProvince FROM LOCATION";
                main.command = new SqlCommand(selectSql, main.conn);
                main.reader = main.command.ExecuteReader();

                while (main.reader.Read())
                {
                    cbProvince.Items.Add(main.reader.GetValue(0));
                }

                main.conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Reset location GroupBox
        public void resetLocation()
        {
            //Hide city combobox
            txtCity.Clear();
            txtCity.Hide();
            lblCity.Hide();

            //Reset selection
            cbProvince.SelectedIndex = -1;
        }

        //Method used to chech validity of email address
        public static bool isValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }

            catch
            {
                valid = false;
            }

            return valid;
        }

        private void frmAddEvent_Load(object sender, EventArgs e)
        {
            //populate the province combo box
            populateProvince();

            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();


            //Populate threshold id combobox
            try
            {
                main.conn.Open();

                //select sql
                string selectSql = $"SELECT Thres_ID FROM THRESHOLD_CRITERIA";
                main.adapter = new SqlDataAdapter(selectSql, main.conn);
                main.data = new DataSet();

                main.adapter.Fill(main.data, "THRESHOLD_CRITERIA");

                cbThresID.DisplayMember = "Thres_ID";
                cbThresID.ValueMember = "Thres_ID";
                cbThresID.DataSource = main.data.Tables["THRESHOLD_CRITERIA"];

                main.conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Automatically select the latest threshold criteria
            int indexOfLast = cbThresID.Items.Count - 1;
            cbThresID.SelectedIndex = indexOfLast;

            //Hide city combobox selection until province is selected
            txtCity.Hide();
            lblCity.Hide();

        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Do this only if it is not a reset sequence
            if (cbProvince.SelectedIndex != -1)
            {
                //Show city combobox and label
                txtCity.Show();
                lblCity.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetLocation();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            //Assign inputs to variables

            string name = txtEventName.Text;
            string newDate = dateTimePicker1.Value.ToString("yyyy/MM/dd");

            int capacity = (int)spnboxCapacity.Value;
            double duration = (double)numDuration.Value;
            string email = txtEmail.Text;



            //Retrieves thresholdID
            int threshold = (int)cbThresID.SelectedValue;

            //Test if email is valid
            //Test if Location has been selected
            if (cbProvince.SelectedIndex != -1 && txtCity.Text != "")
            {
                ////Assign valueas to the variables
                string province = cbProvince.SelectedItem.ToString();
                string city = txtCity.Text;

                //Determine Location ID based on cbProvince and cbCity selection 

                int location = 0;

                try
                {
                    main.conn.Close();
                    main.conn.Open();

                    //select sql
                    string selectSql = $"SELECT Location_ID FROM LOCATION WHERE LProvince = '{province}' AND LCity = '{city}'";
                    main.command = new SqlCommand(selectSql, main.conn);
                    main.reader = main.command.ExecuteReader();

                    if (main.reader.Read())
                    {
                        location = Convert.ToInt32(main.reader.GetValue(0));
                    }

                    main.conn.Close();

                    //If location not found add to database
                    if (location == 0)
                    {
                        string insertLocation = $"INSERT INTO LOCATION (LProvince,LCity) VALUES ('{province}','{city}')";
                        try
                        {
                            main.conn.Open();

                            main.adapter = new SqlDataAdapter();
                            main.command = new SqlCommand(insertLocation, main.conn);
                            main.adapter.InsertCommand = main.command;
                            main.adapter.InsertCommand.ExecuteNonQuery();

                            main.conn.Close();

                            //Select the primary key of the new location
                            try
                            {
                                main.conn.Open();

                                //select sql
                                selectSql = $"SELECT Location_ID FROM LOCATION WHERE LProvince = '{province}' AND LCity = '{city}'";
                                main.command = new SqlCommand(selectSql, main.conn);
                                main.reader = main.command.ExecuteReader();

                                if (main.reader.Read())
                                {
                                    location = Convert.ToInt32(main.reader.GetValue(0));
                                }

                                main.conn.Close();
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Insert Data into EVENT table
                //insert sql
                
                if(name != "")
                {
                    if(isValid(email))
                    {
                        if(capacity != 0)
                        {
                            if (duration != 0.0)
                            {
                                string insertSql = $"INSERT INTO EVENT (Event_Name,Event_Date,Event_Duration,Event_Capacity,Event_Email,Location_ID,Thres_ID) VALUES ('{name}','{newDate}',{duration},{capacity},'{email}',{location},{threshold})";

                                try
                                {
                                    main.conn.Open();

                                    main.adapter = new SqlDataAdapter();
                                    main.command = new SqlCommand(insertSql, main.conn);
                                    main.adapter.InsertCommand = main.command;
                                    main.adapter.InsertCommand.ExecuteNonQuery();

                                    main.conn.Close();

                                    //Display Sucesss Message
                                    MessageBox.Show("Event: " + name + " was succesfully booked for " + newDate);

                                    //Reset all input
                                    txtEventName.Text = "";
                                    txtEmail.Text = "";
                                    txtCity.Text = "";
                                    numDuration.Value = 0;
                                    spnboxCapacity.Value = 0;
                                    resetLocation();
                                    cbThresID.SelectedIndex = cbThresID.Items.Count - 1;
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please indicate the duration of the event");
                                numDuration.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter the event's expected capacity");
                            spnboxCapacity.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid email address");
                        txtEmail.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the event name");
                    txtEventName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Select a Location");
            }


        }

        private void cbHelp_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHelp.Checked == true)
            {
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
                pictureBox6.Show();
                pictureBox7.Show();
                pictureBox8.Show();
                pictureBox9.Show();
            }
            else
            {
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                pictureBox7.Hide();
                pictureBox8.Hide();
                pictureBox9.Hide();
            }
        }
    }
}
