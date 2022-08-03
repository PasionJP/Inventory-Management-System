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
    public partial class CreateUpdateProducts : Form
    {
        public string CreateOrUpdate { get; set; }
        public int pcode { get; set; }
        public string productName { get; set; }
        public string barcode { get; set; }
        public string category { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
        new bool MouseDown;
        private Point offset;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DatabaseConnection dbCon = new DatabaseConnection();
        public CreateUpdateProducts()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateUpdateProducts_Load(object sender, EventArgs e)
        {
            if (CreateOrUpdate == "update")
            {
                pNameTB.Text = productName;
                bCodeTB.Text = barcode;
                quantityTB.Text = quantity;
                priceTB.Text = price;
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (CreateOrUpdate == "update")
            {
                if (pcode > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Products SET productName = @pName, barcode = @bCode, qty = @quantity, price = @price WHERE pcode = @pcode", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@pCode", this.pcode);
                    cmd.Parameters.AddWithValue("@pName", pNameTB.Text);
                    cmd.Parameters.AddWithValue("@bCode", bCodeTB.Text);
                    cmd.Parameters.AddWithValue("@category", categoryCB.Text.ToString());
                    cmd.Parameters.AddWithValue("@quantity", quantityTB.Text);
                    cmd.Parameters.AddWithValue("@price", priceTB.Text);
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }   
            } else if (CreateOrUpdate == "insert")
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Products (productName, barcode, category, qty, price) VALUES (@pName, @bCode, @category, @quantity, @price)", con);
                cmd.Parameters.AddWithValue("@pName", pNameTB.Text);
                cmd.Parameters.AddWithValue("@bCode", bCodeTB.Text);
                cmd.Parameters.AddWithValue("@category", categoryCB.Text.ToString());
                cmd.Parameters.AddWithValue("@quantity", quantityTB.Text);
                cmd.Parameters.AddWithValue("@price", priceTB.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
        }
    }
}
