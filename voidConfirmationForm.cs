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

namespace Login_Form
{
    public partial class voidConfirmationForm : Form
    {
        voidForm v;
        SqlConnection con = new SqlConnection();
        DatabaseConnection dbCon = new DatabaseConnection();
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        string title = "Inventory Management System";
        public voidConfirmationForm(voidForm vf)
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            v = vf;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTB_Enter(object sender, EventArgs e)
        {
            if (usernameTB.Text == "Username")
            {
                usernameTB.Text = "";
                usernameTB.ForeColor = Color.FromArgb(238, 238, 238);
            }
        }

        private void usernameTB_Leave(object sender, EventArgs e)
        {
            if (usernameTB.Text == "")
            {
                usernameTB.Text = "Username";
                usernameTB.ForeColor = Color.FromArgb(150,150,150);
            }
        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            if (passwordTB.Text == "Password")
            {
                passwordTB.Text = "";
                passwordTB.ForeColor = Color.FromArgb(238, 238, 238);
                passwordTB.PasswordChar = '*';
            }
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (usernameTB.Text == "")
            {
                usernameTB.Text = "Password";
                usernameTB.ForeColor = Color.FromArgb(150, 150, 150);
                passwordTB.PasswordChar = '*';
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("Please enter both username and password");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Employees WHERE Username = @Username AND Password = @Password AND UserType = 'Admin' OR UserType = 'Manager'", con);
                cmd.Parameters.AddWithValue("@Username", usernameTB.Text);
                cmd.Parameters.AddWithValue("@Password", passwordTB.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    v.voidConfirmation = true;
                    this.Dispose();
                }else
                {
                    MessageBox.Show("Invalid username and/or password! Please try again.");
                }
                con.Close();
                dr.Close();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
