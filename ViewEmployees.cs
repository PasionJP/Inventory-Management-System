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

namespace Login_Form
{
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EVOGUQ1J\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True");
        public int EmployeeID { get; set; }
        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            GetEmployeesRecord();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GetEmployeesRecord()
        {

            SqlCommand cmd = new SqlCommand("Select * from Employees", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            employeesDataGridView.DataSource = dt;
            for (var i = 0; i < employeesDataGridView.Rows.Count - 1; i++)
            {
                DataGridViewRow r = employeesDataGridView.Rows[i];
                this.employeesDataGridView.Columns["Password"].Visible = false;
                this.employeesDataGridView.Columns["UserName"].Visible = false;
                r.Height = 100;
            }
            var imageColumn = (DataGridViewImageColumn)employeesDataGridView.Columns["EmployeePhoto"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageEmployees mngEmployee = new ManageEmployees();
            if (employeesDataGridView.SelectedRows[0].Cells[1].Value != null)
            {
                mngEmployee.insertOrUpdate = "update";
                mngEmployee.employeeID = Convert.ToInt32(employeesDataGridView.SelectedRows[0].Cells[0].Value);
                mngEmployee.fname = employeesDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                mngEmployee.mname = employeesDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                mngEmployee.lname = employeesDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                mngEmployee.empSex = employeesDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                mngEmployee.bday = employeesDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                mngEmployee.empAddress = employeesDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                mngEmployee.empEmail = employeesDataGridView.SelectedRows[0].Cells[7].Value.ToString();
                mngEmployee.empContact = employeesDataGridView.SelectedRows[0].Cells[8].Value.ToString();

            }
            mngEmployee.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (productsDataGridView.SelectedRows[0].Cells[1].Value != null)
            //{
            //    productID = Convert.ToInt32(productsDataGridView.SelectedRows[0].Cells[0].Value);
            //    productBox.Text = productsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            //    barcodeBox.Text = productsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            //    categoryBox.Text = productsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            //    quantityBox.Text = productsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            //    priceBox.Text = productsDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            //    if (!Convert.IsDBNull(productsDataGridView.SelectedRows[0].Cells[6].Value))
            //    {
            //        byte[] bytes = (byte[])productsDataGridView.SelectedRows[0].Cells[6].Value;
            //        MemoryStream ms = new MemoryStream(bytes);
            //        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            //        productPhoto1.Image = img;
            //    }
            //}
        }

        private void Insert_Click(object sender, EventArgs e)
        {
                ManageEmployees mngEmployee = new ManageEmployees();
                mngEmployee.ShowDialog();   
        }
    }
}
