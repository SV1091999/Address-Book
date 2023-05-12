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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Configuration;
using System.Text.RegularExpressions;

namespace LoginPage__
{
    public partial class Signupform : Form
    {
        private string dbConnectionString;
        ErrorProvider errorProvider = new ErrorProvider();



        public Signupform()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();

            Loginform loginform = new Loginform();
            loginform.Show();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {

            if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && txtusername.Text != ""
                && txtpassword.Text != "" && txtphonenumber.Text != "")
            {
                string queryString = "INSERT INTO ProjectValues ([FirstName],[LastName],[Email],[Username],[Password],[PhoneNumber]) VALUES ('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtemail.Text + "'," + "'" + txtusername.Text + "','" + txtpassword.Text + "','" + txtphonenumber.Text + "')";
                using (SqlConnection connection = new SqlConnection(dbConnectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                   
                    if (MessageBox.Show("Insert successfully!!!!!", "Success", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        txtfirstname.Clear();
                        txtlastname.Clear();
                        txtemail.Clear();
                        txtusername.Clear();
                        txtphonenumber.Clear();
                        txtpassword.Clear();

                        this.Hide();
                        Loginform loginform = new Loginform();
                        loginform.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show(" Attention!! Please fill all textboxes ");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Signupform_Load(object sender, EventArgs e)
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["LoginPage().Properties.Settings.Final_Project_RapidConnectionString"].ConnectionString;
        }

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([a-zA-Z]([-\.\w]*[a-zA-Z0-9])*@[a-zA-Z]*[-\w]*[a-zA-Z]\.)+[a-zA-Z]{2,10}$");

            if (regex.IsMatch(txtemail.Text))
            {
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(this.txtemail, "Put like sv1234@gmail.com!!!");
                return;
            }
        }
    }
}
