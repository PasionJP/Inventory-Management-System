using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Login_Form
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EVOGUQ1J\SQLEXPRESS;Initial Catalog=Products;Integrated Security=True");
        public int productID { get; set; }
        private void button4_Click(object sender, EventArgs e)
        {
            if (productID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Products SET productName = @productName, barcode = @barcode, category = @category, quantity = @quantity, price = @price WHERE productId = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@productName", productBox.Text);
                cmd.Parameters.AddWithValue("@barcode", barcodeBox.Text);
                cmd.Parameters.AddWithValue("@category", categoryBox.Text);
                cmd.Parameters.AddWithValue("@quantity", quantityBox.Text);
                cmd.Parameters.AddWithValue("@price", priceBox.Text);
                cmd.Parameters.AddWithValue("@ID", this.productID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product is successfully updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetProductsRecord();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a product to be updated", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            GetProductsRecord();
        }

        private void GetProductsRecord()
        {
            
            SqlCommand cmd = new SqlCommand("Select * from Products", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            productsDataGridView.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Products VALUES (@productName,@barcode,@category,@quantity,@price)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@productName", productBox.Text);
                cmd.Parameters.AddWithValue("@barcode", barcodeBox.Text);
                cmd.Parameters.AddWithValue("@category", categoryBox.Text);
                cmd.Parameters.AddWithValue("@quantity", quantityBox.Text);
                cmd.Parameters.AddWithValue("@price", priceBox.Text);

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

        private void button3_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            productID = 0;
            productBox.Clear();
            barcodeBox.Clear();
            categoryBox.Clear();
            quantityBox.Clear();
            priceBox.Clear();

            productBox.Focus();
        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productID =Convert.ToInt32(productsDataGridView.SelectedRows[0].Cells[0].Value);
            productBox.Text = productsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            barcodeBox.Text = productsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            categoryBox.Text = productsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            quantityBox.Text = productsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            priceBox.Text = productsDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (productID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE productId = @ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", this.productID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product is successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetProductsRecord();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a product to be deleted", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

