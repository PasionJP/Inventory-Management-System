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
    public partial class SearchItem : Form
    {
        POS f;
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "POS System";
        new bool MouseDown;
        private Point offset;
        public SearchItem(POS frm)
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
            f = frm;
        }

        private void SearchItem_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        public void LoadProducts()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Products WHERE qty > 0", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                searchProductsView.AutoGenerateColumns = false;
                searchProductsView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Products WHERE productName like '%" + searchBox.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    searchProductsView.AutoGenerateColumns = false;
                    searchProductsView.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchProductsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = searchProductsView.Columns[e.ColumnIndex].Name;
            if (colName == "Add")
            {
                itemQty frm = new itemQty(f);
                frm.ProductDetails(searchProductsView.Rows[e.RowIndex].Cells[0].Value.ToString(), Double.Parse(searchProductsView.Rows[e.RowIndex].Cells[5].Value.ToString()), f.TransactNo.Text);
                frm.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            if (MouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }
    }
}
