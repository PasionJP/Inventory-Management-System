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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            title.Parent = bgPicture;
            title.BackColor = Color.Transparent;
            this.AcceptButton = signin;
        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Please enter both username and password");
            }
            else
            {
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johnp\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "Select * From [Table] where username = '" + usernameBox.Text.Trim() + "' and password = '" + passwordBox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    IMS ss = new IMS();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username and password! Please try again.");
                }
            }
        }
    }
}
