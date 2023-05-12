using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage__
{
    public partial class Update : Form
    {
        private string dbConnectionString;

        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["LoginPage().Properties.Settings.Final_Project_RapidConnectionString"].ConnectionString;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { if (txtid.Text != "")
            {
                SqlConnection connection = new SqlConnection(dbConnectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select FirstName,LastName,Contact,Email,Gender,Note from Registration1 Where ID =@ID",connection);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtid.Text));
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    //txtid.Text = dataReader.GetValue(0).ToString(); 
                    txtfirstname.Text = dataReader.GetValue(0). ToString();
                    txtlastname.Text = dataReader.GetValue(1).ToString();
                    txtcontact.Text = dataReader.GetValue(2).ToString();
                    txtemail.Text = dataReader.GetValue(3).ToString();
                    txtgender.Text = dataReader.GetValue(4).ToString();

                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateInfo updateInfo = new UpdateInfo();
            updateInfo.Show();
        }

        private void cmbgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegistrationForm registrationform = new RegistrationForm();
            registrationform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete Delete = new delete();
            Delete.Show();
        }

        
    }
}
