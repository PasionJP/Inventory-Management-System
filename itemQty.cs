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
    public partial class itemQty : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        private String pcode;
        private double price;
        private String transno;
        POS pos;
        public itemQty(POS posfrm)
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            pos = posfrm;
        }

        private void itemQty_Load(object sender, EventArgs e)
        {
            
        }

        public void ProductDetails(String pcode, double price, String transno)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
        }

        private void itmQtyTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void itmQtyTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (itmQtyTB.Text != String.Empty))
            {
                int prodQty;
                con.Open();
                cmd = new SqlCommand("SELECT qty FROM Products WHERE pcode like '"+ pcode +"'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                prodQty = int.Parse(dr["qty"].ToString());
                con.Close();
                if (prodQty < int.Parse(itmQtyTB.Text))
                {
                    MessageBox.Show("Sorry, we don't have enough stock. Remaining quantity on hand is only " + prodQty + ".", "Product Availability", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    itmQtyTB.Text = prodQty.ToString();
                }
                con.Open();
                cmd = new SqlCommand("INSERT into cartTbl (transno, pcode, price, qty, sdate, cashier) VALUES (@transno, @pcode, @price, @qty, @sdate, @cashier)", con);
                cmd.Parameters.AddWithValue("@transno", transno);
                cmd.Parameters.AddWithValue("@pcode", pcode);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@qty", int.Parse(itmQtyTB.Text));
                cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@cashier", pos.cashierName.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                pos.searchBox.Clear();
                pos.searchBox.Focus();
                pos.LoadCart();
                this.Dispose();
            }
        }
    }
}
