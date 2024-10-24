using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McLaughingHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string username = "admin";
        string password = "1234";
        MainMenu mm = new MainMenu();
        PasswordHash phs = new PasswordHash();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*string pass = phs.Passhash(txtPassword.Text);
            string user = txtUsername.Text;*/
            string user = "admin";
            string pass = "1234";
            if (username == user && password == pass)
            {
                this.Hide();
                mm.Show();
            }
            else
            {
                MessageBox.Show("Login or Password incorrect", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
