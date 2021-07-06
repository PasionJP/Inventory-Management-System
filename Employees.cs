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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EVOGUQ1J\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True");
        string photoLocation = "";
        public int productID { get; set; }
        private void productBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                photoLocation = opf.FileName.ToString();
                employeePhoto.ImageLocation = photoLocation;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Employees VALUES (@Employee_ID,@Name,@category,@quantity,@price,@productPhoto)", con);
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

