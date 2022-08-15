using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;

namespace Login_Form
{
    public partial class ProductsV1 : Form
    {
        readonly SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "POS System";
        public int stockQty { get; set; }
        public ProductsV1()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
        }

        public int ProductID { get; set; }

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
            LoadProducts();
        }

        private void ProductBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void ComboBox1_KeyDown(object sender, KeyEventArgs e)
        {

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
            try
            {
                if (searchBox.Text == String.Empty)
                {
                    LoadProducts();
                    return;
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter ("SELECT * from Products WHERE productName like '%" + searchBox.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    productsDataGridView.AutoGenerateColumns = false;
                    productsDataGridView.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = productsDataGridView.Columns[e.ColumnIndex].Name;
            if (colName == "Remove")
            {
                if (MessageBox.Show("Are you sure you want to remove this item in your cart?", "Remove item from cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE from Products where id like '" + productsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item has been removed from the cart successfuly", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
            }
            else if (colName == "Edit")
            {
                CreateUpdateProducts CUPfrm = new CreateUpdateProducts();
                CUPfrm.CreateOrUpdate = "update";
                if (productsDataGridView.SelectedRows[0].Cells[0].Value != null)
                {
                    CUPfrm.id = int.Parse(productsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    CUPfrm.pcodeNew = productsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    CUPfrm.productName = productsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    CUPfrm.barcode = productsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    CUPfrm.category = productsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    CUPfrm.quantity = productsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    CUPfrm.price = productsDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

                    byte[] photoBytes = (byte[])productsDataGridView.SelectedRows[0].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(photoBytes);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    CUPfrm.productPhoto.Image = img;
                }
                CUPfrm.ShowDialog();
                LoadProducts();
            }
        }
        public void LoadProducts()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Products WHERE qty > '" + stockQty.ToString() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                productsDataGridView.AutoGenerateColumns = false;
                productsDataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CreateUpdateProducts CUPfrm = new CreateUpdateProducts();
            CUPfrm.CreateOrUpdate = "insert";
            CUPfrm.ShowDialog();
            LoadProducts();
        }
    }
}
