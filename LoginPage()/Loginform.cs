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
    public partial class Loginform : Form
    {
        private string dbConnectionString;

        Signupform signupform = new Signupform();
        

        public Loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;

            btn_Minimize.FlatStyle = FlatStyle.Flat;
            btn_Close.FlatStyle = FlatStyle.Flat;

            btn_Minimize.FlatAppearance.BorderSize = 0;
            btn_Close.FlatAppearance.BorderSize = 0;

            txtusernamelogin.BackColor = Color.Beige;
            txtpasswordlogin.BackColor = Color.Beige;


            txtusernamelogin.ForeColor = Color.Red;
            txtpasswordlogin.ForeColor = Color.Red;

            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.BackColor = Color.FromArgb(25, 60, 90);
            btnlogin.ForeColor = Color.Gold;

            dbConnectionString = ConfigurationManager.ConnectionStrings["LoginPage().Properties.Settings.Final_Project_RapidConnectionString"].ConnectionString;


        }

        private void btn_Minimize_MouseHover(object sender, EventArgs e)
        {
            btn_Minimize.FlatAppearance.BorderSize = 1;
            btn_Minimize.FlatAppearance.BorderColor = Color.DarkGreen;
        }

        private void btn_Minimize_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btn_Minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimize.FlatAppearance.BorderSize = 0;
        }

        private void btn_Close_MouseHover(object sender, EventArgs e)
        {
            btn_Close.FlatAppearance.BorderSize = 1;
            btn_Close.FlatAppearance.BorderColor = Color.DarkGreen;


        }

        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.FlatAppearance.BorderSize = 0;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();

            signupform.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(dbConnectionString);

            connection.Open();

            string query = "Select * from ProjectValues where Username = '" + txtusernamelogin.Text + "' and password = '" + txtpasswordlogin.Text + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();

            adapter.Fill(data);

            if (data.Rows.Count > 0)
            {
                this.Hide();

                RegistrationForm registration = new RegistrationForm();
                registration.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username and Password");
            }

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
