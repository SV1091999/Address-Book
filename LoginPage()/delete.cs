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
    public partial class delete : Form
    {
        private string dbConnectionString;

        public delete()
        {
            InitializeComponent();
        }

        private void delete_Load(object sender, EventArgs e)
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["LoginPage().Properties.Settings.Final_Project_RapidConnectionString"].ConnectionString;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {

                SqlConnection connection = new SqlConnection(dbConnectionString);
                SqlCommand command = new SqlCommand(@"DELETE FROM [Registration1]
              WHERE [ID]='" + txtid.Text + "'", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Deleted successfully!!!!!");
                if (MessageBox.Show("Deleted successfully!!!!!", "Success", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    txtid.Clear();
                    txtFName.Clear();
                    txtLName.Clear();
                    txtMail.Clear();
                    txtCon.Clear();

                    this.Hide();
                    Update update = new Update();
                    update.Show();
                 }
            
        
            else
            {
                MessageBox.Show("Sorry");
            }



        }
           

}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontact_Click(object sender, EventArgs e)
        {

        }

        private void txtlastname_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update update= new Update();
            update.Show();
        }
    }
}

