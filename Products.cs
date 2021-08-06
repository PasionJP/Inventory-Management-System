using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Login_Form
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EVOGUQ1J\SQLEXPRESS;Initial Catalog=Products;Integrated Security=True");
        string photoLocation = "";
        public int productID { get; set; }
        private void button4_Click(object sender, EventArgs e)
        {
            if (productID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Products SET productName = @productName, barcode = @barcode, category = @category, quantity = @quantity, price = @price, productPhoto = @productPhoto WHERE productId = @ID", con);
                cmd.CommandType = CommandType.Text;
                if (string.IsNullOrEmpty(photoLocation))
                {
                    photoLocation = @"D:\JP\Software\Inventory Management System\Github\Login Form\image\no image available.jpg";
                }
                byte[] images = null;
                FileStream fstream = new FileStream(photoLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(fstream);
                images = brs.ReadBytes((int)fstream.Length);

                cmd.Parameters.AddWithValue("@ID", this.productID);
                cmd.Parameters.AddWithValue("@productName", productBox.Text);
                cmd.Parameters.AddWithValue("@barcode", barcodeBox.Text);
                cmd.Parameters.AddWithValue("@category", categoryBox.Text);
                cmd.Parameters.AddWithValue("@quantity", quantityBox.Text);
                cmd.Parameters.AddWithValue("@price", priceBox.Text);
                cmd.Parameters.Add(new SqlParameter("@productPhoto", images));

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
            for (var i = 0; i < productsDataGridView.Rows.Count-1; i++)
            {
                DataGridViewRow r = productsDataGridView.Rows[i];
                r.Height = 100;
            }
            var imageColumn = (DataGridViewImageColumn)productsDataGridView.Columns["productPhoto"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Products VALUES (@productName,@barcode,@category,@quantity,@price,@productPhoto)", con);
                cmd.CommandType = CommandType.Text;
                if (string.IsNullOrEmpty(photoLocation))
                {
                    photoLocation = @"D:\JP\Software\Inventory Management System\Github\Login Form\image\no image available.jpg";
                }

                byte[] images = null;
                FileStream fstream = new FileStream(photoLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(fstream);
                images = brs.ReadBytes((int)fstream.Length);

                cmd.Parameters.AddWithValue("@productName", productBox.Text);
                cmd.Parameters.AddWithValue("@barcode", barcodeBox.Text);
                cmd.Parameters.AddWithValue("@category", categoryBox.Text);
                cmd.Parameters.AddWithValue("@quantity", quantityBox.Text);
                cmd.Parameters.AddWithValue("@price", priceBox.Text);
                cmd.Parameters.Add(new SqlParameter("@productPhoto", images));


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
            productPhoto1.Image = null;
            photoLocation = "";
            productBox.Focus();
        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearFields();
            if (productsDataGridView.SelectedRows[0].Cells[1].Value != null)
            {
                productID = Convert.ToInt32(productsDataGridView.SelectedRows[0].Cells[0].Value);
                productBox.Text = productsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                barcodeBox.Text = productsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                categoryBox.Text = productsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                quantityBox.Text = productsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                priceBox.Text = productsDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                if (!Convert.IsDBNull(productsDataGridView.SelectedRows[0].Cells[6].Value))
                {
                    byte[] bytes = (byte[])productsDataGridView.SelectedRows[0].Cells[6].Value;
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    productPhoto1.Image = img;
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                photoLocation = opf.FileName.ToString();
                productPhoto1.ImageLocation = photoLocation;
            }
        }

        private void productBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            photoLocation = "";
            productPhoto1.Image = null;
        }
    }
}
