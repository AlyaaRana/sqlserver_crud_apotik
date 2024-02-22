using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlserver_crud_apotik
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar ? ", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=loginapp;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            string query = "SELECT COUNT(*) FROM loginapp WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            int count = (int)cmd.ExecuteScalar();

            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();  
            }
            else
            {
                MessageBox.Show("Error Login");
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbPassword.Checked ? '\0' : '*';
        }
    }
}
