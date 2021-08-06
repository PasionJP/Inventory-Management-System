using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Login_Form
{
    public partial class ManageEmployees : Form
    {
        public string insertOrUpdate { get; set; }
        public int employeeID { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }
        public string empSex { get; set; }
        public string bday { get; set; }
        public string empAddress { get; set; }
        public string empEmail { get; set; }
        public string empContact { get; set; }

        public ManageEmployees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EVOGUQ1J\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True");
        string photoLocation = "";
        string sex = "Undefined";
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (password.Text == confirmPassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Employees VALUES (@FirstName,@MiddleName,@LastName,@Sex,@Birthday,@Address,@Email,@ContactNumber,@EmployeePhoto,@UserType,@UserName,@Password)", con);
                    cmd.CommandType = CommandType.Text;
                    if (string.IsNullOrEmpty(photoLocation))
                    {
                        photoLocation = @"D:\JP\Software\Inventory Management System\Github\Login Form\image\no profile.png";
                    }

                    byte[] images = null;
                    FileStream fstream = new FileStream(photoLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(fstream);
                    images = brs.ReadBytes((int)fstream.Length);

                    cmd.Parameters.AddWithValue("@FirstName", firstName.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", middleName.Text);
                    cmd.Parameters.AddWithValue("@LastName", lastName.Text);
                    cmd.Parameters.AddWithValue("@Sex", sex);
                    cmd.Parameters.AddWithValue("@Address", address.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", contact.Text);
                    cmd.Parameters.AddWithValue("@UserName", username.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Text);
                    cmd.Parameters.AddWithValue("@Birthday", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@UserType", userType.Text.ToString());
                    cmd.Parameters.Add(new SqlParameter("@EmployeePhoto", images));


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee successfully registered.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Password does not match!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password.Clear();
                    confirmPassword.Clear();
                }
            }
        }
        private bool isValid()
        {
            if (firstName.Text == string.Empty && lastName.Text == string.Empty)
            {
                MessageBox.Show("First and last name is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ClearFields()
        {
            employeeID = 0;
            firstName.Clear();
            middleName.Clear();
            lastName.Clear();
            address.Clear();
            email.Clear();
            contact.Clear();
            username.Clear();
            password.Clear();
            confirmPassword.Clear();
            userType.Items.Clear();
            MaleRadioButton.Checked = false;
            FemaleRadioButton.Checked = false;
            photoLocation = "";
            employeePhoto.Image = null;
            firstName.Focus();
        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Male";
        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Female";
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                photoLocation = opf.FileName.ToString();
                employeePhoto.ImageLocation = photoLocation;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            photoLocation = "";
            employeePhoto.Image = null;
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void userType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void employeePhoto_Click(object sender, EventArgs e)
        {

        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            if (insertOrUpdate == "update")
            {
                firstName.Text = fname;
                middleName.Text = mname;
                lastName.Text = lname;
                if (empSex == "Male")
                {
                    MaleRadioButton.Checked = true;
                }
                else if (empSex == "Female")
                {
                    FemaleRadioButton.Checked = true;
                }
                dateTimePicker1.Value = Convert.ToDateTime(bday);
                address.Text = empAddress;
                email.Text = empEmail;
                contact.Text = empContact;
            }
        }
    }
}
