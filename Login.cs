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
using System.IO;
using System.Drawing.Imaging;


namespace Login_Form
{
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
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
                string query = "SELECT RTRIM(LTRIM(CONCAT(COALESCE(Lastname, ''), ', ', COALESCE(FirstName + ' ', ''), COALESCE(MiddleName + ' ', '')))) AS Fullname, EmployeeID, FirstName, MiddleName, LastName, Sex, Birthday, Address, Email, ContactNumber, Usertype, EmployeePhoto, UserName, Password FROM Employees WHERE UserName = '" + usernameBox.Text.Trim() + "' and Password = '" + passwordBox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    IMS ss = new IMS();

                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(dt.Rows[0]["EmployeePhoto"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    ss.employeePhoto.Image = Image.FromStream(stmBLOBData);

                    ss.nameEmployeeLbl.Text = dt.Rows[0]["Fullname"].ToString();
                    ss.userTypeLbl.Text = dt.Rows[0]["Usertype"].ToString();

                    if (dt.Rows[0]["Usertype"].ToString() == "Admin")
                    {
                        ss.Show();
                    } else if (dt.Rows[0]["Usertype"].ToString() == "Employee")
                    {
                        ss.employeesBtn.Visible = false;
                        ss.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid username and password! Please try again.");
                }
                cn.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
