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

namespace Login_Form
{
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EVOGUQ1J\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True");
        public int EmployeeID;
        string photoLocation = "";
        string sex;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Employees VALUES (@FirstName,@MiddleName,@LastName,@Sex,@Birthday,@Address,@Email,@ContactNumber,@EmployeePhoto,@UserType,@UserName,@Password)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", firstName.Text);
                cmd.Parameters.AddWithValue("@MiddleName", middleName.Text);
                cmd.Parameters.AddWithValue("@LastName", lastName.Text);
                cmd.Parameters.AddWithValue("@Address", address.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", email.Text);
                cmd.Parameters.AddWithValue("@UserName", username.Text);
                cmd.Parameters.AddWithValue("@Sex", sex);
                cmd.Parameters.AddWithValue("@Birthday", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@UserType", userType.Text.ToString());
                if (password.Text == confirmPassword.Text)
                {
                    cmd.Parameters.AddWithValue("@Password", password.Text);
                }
                else
                {
                    MessageBox.Show("Password does not match!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (employeePhoto.Image != null)
                {
                    byte[] images = null;
                    FileStream fstream = new FileStream(photoLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(fstream);
                    images = brs.ReadBytes((int)fstream.Length);
                    cmd.Parameters.Add(new SqlParameter("@employeePhoto", images));
                }

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee successfully registered.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
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
            EmployeeID = 0;
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
    }
}
