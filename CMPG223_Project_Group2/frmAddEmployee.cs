using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CMPG223_Project_Group2
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }
        public frmMainMenu main = new frmMainMenu();
        private void btnAddNewEmp_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add this employee?", "Add", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                addNewEmp();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Add an other employee");
            }
        }
        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            clearLbl();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
        }
        // A method that ensures a valid email address has been entered
        public static bool IsValidEmail(string Email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);
            if (match.Success)
                return true;
            else
                return false;
        }
        public void clearLbl()
        {
            lblEEmail.Text = "";
            lblEFname.Text = "";
            lblELname.Text = "";
            lblEPass.Text = "";
            lblEPay.Text = "";
        }
        //A method to add new employees
        public void addNewEmp()
        {
            String fName = txtEmpFName.Text;
            String lName = txtEmpLName.Text;
            String Email = txtEmpEmail.Text;
            String empPass = txtEmpPassword.Text;
            decimal sal;

            lblEFname.Hide();
            lblELname.Hide();
            lblEPass.Hide();
            lblEEmail.Hide();
            lblEPay.Hide();



            // Tests to see if no textboxes are empty
            if (fName != "")
            {
                if (lName != "")
                {
                    if (IsValidEmail(Email) == true)
                    {
                        //validates the email
                        if (empPass != "")
                        {
                            //tests if the payment value entered is of correct format
                            if (decimal.TryParse(txtEmpPay.Text, out sal))
                            {
                                try
                                {
                                    main.conn.Open();
                                    main.command = new SqlCommand($"INSERT INTO EMPLOYEE (Emp_PayRate,Emp_FName,Emp_LName,Emp_Email,Emp_Password) VALUES ('{sal}','{fName}','{lName}','{Email}','{empPass}')", main.conn);
                                    main.adapter = new SqlDataAdapter();

                                    main.adapter.InsertCommand = main.command;
                                    main.adapter.InsertCommand.ExecuteNonQuery();

                                    main.conn.Close();


                                    MessageBox.Show("You have successfully added a new employee");

                                    txtEmpEmail.Clear();
                                    txtEmpFName.Clear();
                                    txtEmpLName.Clear();
                                    txtEmpPassword.Clear();
                                    txtEmpPay.Clear();
                                    txtEmpFName.Focus();
                                    clearLbl();
                                }
                                catch (SqlException error)
                                {
                                    MessageBox.Show(error.Message);
                                }
                            }
                            else
                            {
                                lblEPay.Text = "Please enter a valid pay rate";
                                lblEPay.Show();
                            }
                        }
                        else
                        {
                            lblEEmail.Text = "Please enter password";
                            lblEEmail.Show();
                        }
                    }
                    else
                    {
                        lblEPass.Text = "Enter a valid email";
                        lblEPass.Show();
                    }
                }
                else
                {
                    lblELname.Text = "Please enter a last name";
                    lblELname.Show();
                }
            }
            else
            {
                lblEFname.Text = "Please add a first name";
                lblEFname.Show();
            }
        }

        private void cbHelp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHelp.Checked == true)
            {
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
                pictureBox6.Show();

            }
            else
            {
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();

            }
        }
    }
}
