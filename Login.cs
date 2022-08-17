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
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        public int empID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string usertype { get; set; }
        public string username { get; set; }
        public string dateLog { get; set; }
        public string timeLog { get; set; }
        public string status { get; set; }
        public bool showDashB = true;
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
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
                string query = "SELECT RTRIM(LTRIM(CONCAT(COALESCE(Lastname, ''), ', ', COALESCE(FirstName + ' ', ''), COALESCE(MiddleName + ' ', '')))) AS Fullname, EmployeeID, FirstName, MiddleName, LastName, Sex, Birthday, Address, Email, ContactNumber, UserType, EmployeePhoto, UserName, Password FROM Employees WHERE UserName = '" + usernameBox.Text.Trim() + "' and Password = '" + passwordBox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.empID = int.Parse(dt.Rows[0]["EmployeeID"].ToString());
                    firstname = dt.Rows[0]["FirstName"].ToString();
                    lastname = dt.Rows[0]["LastName"].ToString();
                    usertype = dt.Rows[0]["UserType"].ToString();
                    username = dt.Rows[0]["UserName"].ToString();
                    dateLog = DateTime.Now.ToString("MM/dd/yyyy");
                    timeLog = DateTime.Now.ToString("HH:mm:ss");
                    status = "Logged in";
                    userLoginSave(empID, firstname, lastname, usertype, username, dateLog, timeLog, status);

                    this.Hide();
                    IMS ss = new IMS(this);

                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(dt.Rows[0]["EmployeePhoto"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    ss.employeePhoto.Image = Image.FromStream(stmBLOBData);

                    ss.nameEmployeeLbl.Text = dt.Rows[0]["Fullname"].ToString();
                    ss.userTypeLbl.Text = dt.Rows[0]["Usertype"].ToString();
                    ss.userID.Text = dt.Rows[0]["EmployeeID"].ToString();

                    if (dt.Rows[0]["Usertype"].ToString() == "Admin")
                    {
                        showDashB = true;
                        ss.Show();
                    } else if (dt.Rows[0]["Usertype"].ToString() == "Manager")
                    {
                        showDashB = true;
                        ss.employeesBtn.Visible = false;
                        ss.Show();
                    } else if (dt.Rows[0]["Usertype"].ToString() == "Stock Clerk")
                    {
                        ss.userAccess = "Stock Clerk";
                        ss.dateTLP.Visible = false;
                        ss.Dashboard.Visible = false;
                        ss.posBtn.Visible = false;
                        ss.employeesBtn.Visible = false;
                        ss.panelAnalytics.Visible = false;
                        ss.Show();
                    } else if (dt.Rows[0]["Usertype"].ToString() == "Cashier")
                    {
                        ss.userAccess = "Cashier";
                        ss.posBtn.Visible = false;
                        ss.dateTLP.Visible = false;
                        ss.Dashboard.Visible = false;
                        ss.productsPanel.Visible = false;
                        ss.employeesBtn.Visible = false;
                        ss.panelAnalytics.Visible = false;
                        showDashB = false;
                        ss.Show(this);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username and password! Please try again.");
                }
                con.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void userLoginSave(int id, string fname, string lname, string usertype, string username, string userlog, string datelog, string status)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO userLog (EmployeeID, FirstName, Lastname, Usertype, username, dateLog, timeLog, status) VALUES (@EmployeeID, @FirstName, @Lastname, @Usertype, @username, @dateLog, @timeLog, @status)", con);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@EmployeeID", id.ToString());
            cmd.Parameters.AddWithValue("@Firstname", fname);
            cmd.Parameters.AddWithValue("@Lastname", lname);
            cmd.Parameters.AddWithValue("@Usertype", usertype);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@dateLog", userlog);
            cmd.Parameters.AddWithValue("@timeLog", datelog);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
