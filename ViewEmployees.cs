using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class ViewEmployees : Form
    {
        SqlConnection con = new SqlConnection();
        DatabaseConnection dbCon = new DatabaseConnection();
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        string title = "Inventory Management System";
        public ViewEmployees()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
        }
        public int EmpID { get; set; }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            GetEmployeesRecord();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GetEmployeesRecord()
        {
            try
            {
                con.Open();
                //cmd = new SqlCommand("SELECT FirstName+' '+MiddleName+' '+LastName as FullName FROM Employees'", con);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT RTRIM(LTRIM(CONCAT(COALESCE(Lastname, ''), ', ', COALESCE(FirstName + ' ', ''), COALESCE(MiddleName + ' ', '')))) AS Fullname, EmployeeID, FirstName, MiddleName, LastName, Sex, Birthday, Address, Email, ContactNumber, Usertype, EmployeePhoto FROM Employees", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                employeesDataGridView.AutoGenerateColumns = false;
                employeesDataGridView.DataSource = dt;
                for (var i = 0; i < employeesDataGridView.Rows.Count; i++)
                {
                    DataGridViewRow r = employeesDataGridView.Rows[i];
                    r.Height = 60;
                }
                var imageColumn = (DataGridViewImageColumn)employeesDataGridView.Columns["EmployeePhoto"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //SqlCommand cmd = new SqlCommand("Select * from Employees", con);
            //DataTable dt = new DataTable();

            //con.Open();

            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            //con.Close();

            //employeesDataGridView.DataSource = dt;
            //for (var i = 0; i < employeesDataGridView.Rows.Count; i++)
            //{
            //    DataGridViewRow r = employeesDataGridView.Rows[i];
            //    this.employeesDataGridView.Columns["Password"].Visible = false;
            //    this.employeesDataGridView.Columns["UserName"].Visible = false;
            //    r.Height = 60;
            //}
            //var imageColumn = (DataGridViewImageColumn)employeesDataGridView.Columns["EmployeePhoto"];
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageEmployees mngEmployee = new ManageEmployees();
            mngEmployee.InsertOrUpdate = "update";
            if (employeesDataGridView.SelectedRows[0].Cells[1].Value != null)
            {
                mngEmployee.EmployeeID = Convert.ToInt32(employeesDataGridView.SelectedRows[0].Cells[0].Value);
                mngEmployee.Fname = employeesDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                mngEmployee.Mname = employeesDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                mngEmployee.Lname = employeesDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                mngEmployee.EmpSex = employeesDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                mngEmployee.Bday = employeesDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                mngEmployee.EmpAddress = employeesDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                mngEmployee.EmpEmail = employeesDataGridView.SelectedRows[0].Cells[7].Value.ToString();
                mngEmployee.EmpContact = employeesDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                mngEmployee.EmpUsertype = employeesDataGridView.SelectedRows[0].Cells[9].Value.ToString();
                mngEmployee.EmpUsername = employeesDataGridView.SelectedRows[0].Cells[11].Value.ToString();
                mngEmployee.EmpPassword = employeesDataGridView.SelectedRows[0].Cells[12].Value.ToString();
                if (!Convert.IsDBNull(employeesDataGridView.SelectedRows[0].Cells[6].Value))
                {
                    byte[] photoBytes = (byte[])employeesDataGridView.SelectedRows[0].Cells[10].Value;
                    MemoryStream ms = new MemoryStream(photoBytes);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    mngEmployee.EmpPhoto = img;
                }

            }
            else
            {
                MessageBox.Show("Please select a product to be updated", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mngEmployee.ShowDialog();
            GetEmployeesRecord();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (employeesDataGridView.SelectedRows[0].Cells[1].Value != null)
            //{
            //    EmployeeID = Convert.ToInt32(employeesDataGridView.SelectedRows[0].Cells[0].Value);
            //}
        }

        private void Insert_Click(object sender, EventArgs e)
        {
                ManageEmployees mngEmployee = new ManageEmployees();
                mngEmployee.InsertOrUpdate = "insert";
                mngEmployee.ShowDialog();
                GetEmployeesRecord();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (EmpID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = @ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", this.EmpID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product is successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEmployeesRecord();
            }
            else
            {
                MessageBox.Show("Please select a product to be deleted", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(searchBox.Text))
                    GetEmployeesRecord();
                else
                {
                    string rowFilter = string.Format("[{0}] = '{1}'", comboBox1.Text, searchBox.Text);
                    (employeesDataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
