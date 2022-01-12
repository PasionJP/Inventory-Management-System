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

        readonly SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EVOGUQ1J\SQLEXPRESS;Initial Catalog=Products;Integrated Security=True");
        string photoLocation = "";
        public int ProductID { get; set; }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (ProductID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Products SET productName = @productName, barcode = @barcode, category = @category, quantity = @quantity, price = @price, productPhoto = @productPhoto WHERE productId = @ID", con)
                {
                    CommandType = CommandType.Text
                };
                if (string.IsNullOrEmpty(photoLocation))
                {
                    photoLocation = @"D:\JP\Software\Inventory Management System\Github\Login Form\image\no image available.jpg";
                }

                FileStream fstream = new FileStream(photoLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(fstream);
                byte[] images = brs.ReadBytes((int)fstream.Length);

                cmd.Parameters.AddWithValue("@ID", this.ProductID);
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

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
        private void Button2_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Products VALUES (@productName,@barcode,@category,@quantity,@price,@productPhoto)", con)
                {
                    CommandType = CommandType.Text
                };
                if (string.IsNullOrEmpty(photoLocation))
                {
                    photoLocation = @"D:\JP\Software\Inventory Management System\Github\Login Form\image\no image available.jpg";
                }

                byte[] images;
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

        private bool IsValid()
        {
            if (productBox.Text == string.Empty)
            {
                MessageBox.Show("Product name is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            ProductID = 0;
            productBox.Clear();
            barcodeBox.Clear();
            categoryBox.Clear();
            quantityBox.Clear();
            priceBox.Clear();
            productPhoto1.Image = null;
            photoLocation = "";
            productBox.Focus();
        }

        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearFields();
            if (productsDataGridView.SelectedRows[0].Cells[1].Value != null)
            {
                ProductID = Convert.ToInt32(productsDataGridView.SelectedRows[0].Cells[0].Value);
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

        private void Button5_Click(object sender, EventArgs e)
        {
            if (ProductID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE productId = @ID", con)
                {
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@ID", this.ProductID);

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

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog
            {
                Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif"
            };
            if (opf.ShowDialog() == DialogResult.OK)
            {
                photoLocation = opf.FileName.ToString();
                productPhoto1.ImageLocation = photoLocation;
            }
        }

        private void ProductBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {
            photoLocation = "";
            productPhoto1.Image = null;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void ComboBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(searchBox.Text))
                    GetProductsRecord();
                else
                {
                    string rowFilter = string.Format("[{0}] = '{1}'", comboBox1.Text, searchBox.Text);
                    (productsDataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                }
            }
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
