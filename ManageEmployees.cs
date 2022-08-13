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
        public int EmployeeID { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string EmpSex { get; set; }
        public string Bday { get; set; }
        public string EmpAddress { get; set; }
        public string EmpEmail { get; set; }
        public string EmpContact { get; set; }
        public string EmpUsertype { get; set; }
        public string EmpUsername { get; set; }
        public string EmpPassword { get; set; }
        public Image EmpPhoto { get; set; }
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "POS System";
        string pwViewState = "Hide";
        public string InsertOrUpdate;
        new bool MouseDown;
        private Point offset;
        public ManageEmployees()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
        }
        string photoLocation = "";
        string sex = "Undefined";
            private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (InsertOrUpdate == "insert")
            {
                if (isValid())
                {
                    if (password.Text == confirmPassword.Text)
                    {
                        con.Open();
                        cmd = new SqlCommand("INSERT INTO Employees (FirstName,MiddleName,LastName,Sex,Birthday,Address,Email,ContactNumber,EmployeePhoto,UserType,UserName,Password) VALUES (@FirstName,@MiddleName,@LastName,@Sex,@Birthday,@Address,@Email,@ContactNumber,@EmployeePhoto,@UserType,@UserName,@Password)", con);
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

                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password does not match!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        password.Clear();
                        confirmPassword.Clear();
                    }
                }
            }
            else if (InsertOrUpdate == "update")
            {
                if (EmployeeID > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Employees SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Sex = @Sex, Address = @Address, Email = @Email, ContactNumber = @ContactNumber, UserName = @UserName, Password = @Password, Birthday = @Birthday, UserType = @UserType, EmployeePhoto = @EmployeePhoto WHERE EmployeeID = @ID", con);
                    cmd.CommandType = CommandType.Text;
                    if (string.IsNullOrEmpty(photoLocation))
                    {
                        photoLocation = @"D:\JP\Software\Inventory Management System\Github\Login Form\image\no profile.png";
                    }
                    byte[] images = null;
                    FileStream fstream = new FileStream(photoLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(fstream);
                    images = brs.ReadBytes((int)fstream.Length);

                    cmd.Parameters.AddWithValue("@ID", this.EmployeeID);
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
                    this.Close();
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
            if (InsertOrUpdate == "update")
            {
                firstName.Text = Fname;
                middleName.Text = Mname;
                lastName.Text = Lname;
                if (EmpSex == "Male")
                {
                    MaleRadioButton.Checked = true;
                }
                else if (EmpSex == "Female")
                {
                    FemaleRadioButton.Checked = true;
                }
                dateTimePicker1.Value = Convert.ToDateTime(Bday);
                address.Text = EmpAddress;
                email.Text = EmpEmail;
                contact.Text = EmpContact;
                userType.Text = EmpUsertype;
                username.Text = EmpUsername;
                password.Text = EmpPassword;
                confirmPassword.Text = EmpPassword;
                employeePhoto.Image = EmpPhoto;
            }
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            MouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if(MouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pwViewState == "Hide")
            {
                pwViewState = "Unhide";
                password.PasswordChar = '\0';
                confirmPassword.PasswordChar = '\0';
                pictureBox1.Image = Properties.Resources.eye_show;
            } else if (pwViewState == "Unhide")
            {
                pwViewState = "Hide";
                password.PasswordChar = '*';
                confirmPassword.PasswordChar = '*';
                pictureBox1.Image = Properties.Resources.eye_unshow;
            }
            
        }
    }
}
