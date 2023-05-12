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
    public partial class UpdateInfo : Form
    {
        private string dbConnectionString;
        ErrorProvider errorProvider = new ErrorProvider();


        public UpdateInfo()
        {
            InitializeComponent();
        }

        private void txtlastname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfirstname_Click(object sender, EventArgs e)
        {

        }

        private void txtcontact_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtfirstname.Text != "")
            {
                SqlConnection connection = new SqlConnection(dbConnectionString);


                SqlCommand command = new SqlCommand(@"UPDATE [Registration1]
               SET[ID]='" + Int32.Parse(txtid.Text) + "',[FirstName] ='" + txtfname.Text + "', [LastName]='" + txtlname.Text + "', " + "[Email]='" + txtmail.Text + "',[Contact]='" + txtcon.Text + "',[Gender]='" + cmb.Text + "' WHERE[ID]='" + txtid.Text + "' ", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Updated successfully!!!!!");
                if (MessageBox.Show("Updated successfully!!!!!", "Success", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    txtid.Clear();
                    txtfname.Clear();
                    txtlname.Clear();
                    txtmail.Clear();
                    txtcon.Clear();

                    this.Hide();
                    Update update= new Update();
                    update.Show();
                }
            }
            else
            {
                MessageBox.Show("Sorry");
            }


        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["LoginPage().Properties.Settings.Final_Project_RapidConnectionString"].ConnectionString;
            cmb.Items.Add("Male");
            cmb.Items.Add("Female");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update update = new Update();
            update.Show();

        }

        private void txtmail_Validating(object sender, CancelEventArgs e)
        {

            Regex regex = new Regex(@"^([a-zA-Z]([-\.\w]*[a-zA-Z0-9])*@[a-zA-Z]*[-\w]*[a-zA-Z]\.)+[a-zA-Z]{2,10}$");

            if (regex.IsMatch(txtmail.Text))
            {
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(this.txtmail, "Put like sv1234@gmail.com!!!");
                return;
            }
        }
    }
}
            

        

    

