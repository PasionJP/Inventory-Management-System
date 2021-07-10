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
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EVOGUQ1J\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True");
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Employees VALUES (@EmployeeID,@FirstName,@category,@quantity,@price,@productPhoto)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@productName", productBox.Text);
                cmd.Parameters.AddWithValue("@barcode", barcodeBox.Text);
                cmd.Parameters.AddWithValue("@category", categoryBox.Text);
                cmd.Parameters.AddWithValue("@quantity", quantityBox.Text);
                cmd.Parameters.AddWithValue("@price", priceBox.Text);
                if (productPhoto1.Image != null)
                {
                    byte[] images = null;
                    FileStream streem = new FileStream(photoLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(streem);
                    images = brs.ReadBytes((int)streem.Length);
                    cmd.Parameters.Add(new SqlParameter("@productPhoto", images));
                }

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product is saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetProductsRecord();
                ClearFields();
            }
        }
        private bool isValid()
        {
            if (productBox.Text == string.Empty)
            {
                MessageBox.Show("Product name is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
