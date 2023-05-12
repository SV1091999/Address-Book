using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage__
{
    public partial class RegistrationForm : Form
    {
        private string dbConnectionString;
        ErrorProvider errorProvider = new ErrorProvider();


        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["LoginPage().Properties.Settings.Final_Project_RapidConnectionString"].ConnectionString;



            cmb.Items.Add("Male");
            cmb.Items.Add("Female");
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update update = new Update();
            update.Show();
        }

        private void insert_click_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" && txtfirstname.Text != "" && txtlastname.Text != "" && txtcontact.Text != "" && txtemail.Text != ""
              && cmb.Text != "" && txtnote.Text != "")
            {
                string queryString = "INSERT INTO Registration1 ([FirstName],[LastName],[ID],[Contact],[Email],[Gender],[Note]) VALUES ('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtid.Text + "','" + txtcontact.Text + "'," + "'" + txtemail.Text + "','" + cmb.Text + "','" + txtnote.Text + "')";
                using (SqlConnection connection = new SqlConnection(dbConnectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    //MessageBox.Show("Insert successfully!!!!!");
                    if (MessageBox.Show("Insert successfully!!!!!", "Success", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        txtid.Clear();
                        txtfirstname.Clear();
                        txtlastname.Clear();
                        txtcontact.Clear();
                        txtemail.Clear();
                        txtnote.Clear();
                        this.Hide();
                        RegistrationForm Registration = new RegistrationForm();
                        Registration.Show();
                    }

                }
            }
            else
            {
               MessageBox.Show(" Attention!! Please fill all textboxes ");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_click_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete delete = new delete();
            delete.Show();
        }

        private void find_click_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtnote_TextChanged(object sender, EventArgs e)
        {

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
