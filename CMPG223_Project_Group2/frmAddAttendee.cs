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
using System.Text.RegularExpressions;

namespace CMPG223_Project_Group2
{
    public partial class frmAddAttendee : Form
    {
        public frmMainMenu main = new frmMainMenu();
        
        public frmAddAttendee()
        {
            InitializeComponent();
        }

        private void frmAddAttendee_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Hide();
        }


        public static bool IsValidEmail(string Email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);
            if (match.Success)
                return true;
            else
                return false;
        }


        private void btnAddAttendee_Click_1(object sender, EventArgs e)
        {
            if (txtAttFName.Text == "")
            {
                MessageBox.Show("Please enter the attendee's first name");
            }
            else if (txtAttLName.Text == "")
            {
                MessageBox.Show("Please enter the attendee's last name");
            }
            else if (txtAttEmail.Text == "")
            {
                MessageBox.Show("Please enter the attendee's email address");
            }
            else
            {
                String Email = txtAttEmail.Text;
                String AttFName = txtAttFName.Text;
                String AttLName = txtAttLName.Text;
                if (IsValidEmail(Email) == true)
                {
                    try
                    {
                        string addEmp = $"INSERT INTO ATENDEE (Att_FName, Att_LName, Att_Email) VALUES ('{AttFName}','{AttLName}','{Email}')";

                        main.conn.Open();
                        main.command = new SqlCommand(addEmp, main.conn);
                        main.adapter = new SqlDataAdapter();

                        main.adapter.InsertCommand = main.command;
                        main.adapter.InsertCommand.ExecuteNonQuery();

                        main.conn.Close();

                        MessageBox.Show("You have successfully added a new attendee");

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error connecting to database");
                    }
                }
                else
                {
                    lblErrorMessage.Show();
                    lblErrorMessage.Text = "Please enter a valid e-mail address";
                }
            }
        }

        private void frmAddAttendee_Load_1(object sender, EventArgs e)
        {
            lblErrorMessage.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void cbHelp_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHelp.Checked == true)
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
