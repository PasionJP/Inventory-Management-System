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
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        private String pcode;
        private double price;
        private String transno;
        POS pos;
        public itemQty(POS posfrm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.DBConnection());
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
                cn.Open();
                cm = new SqlCommand("SELECT qty FROM Products WHERE pcode like '"+ pcode +"'", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                prodQty = int.Parse(dr["qty"].ToString());
                cn.Close();
                if (prodQty < int.Parse(itmQtyTB.Text))
                {
                    MessageBox.Show("Sorry, we don't have enough stock. Remaining quantity on hand is only " + prodQty + ".", "Product Availability", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    itmQtyTB.Text = prodQty.ToString();
                }
                cn.Open();
                cm = new SqlCommand("INSERT into cartTbl (transno, pcode, price, qty, sdate) VALUES (@transno, @pcode, @price, @qty, @sdate)", cn);
                cm.Parameters.AddWithValue("@transno", transno);
                cm.Parameters.AddWithValue("@pcode", pcode);
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@qty", int.Parse(itmQtyTB.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.ExecuteNonQuery();
                cn.Close();

                pos.searchBox.Clear();
                pos.searchBox.Focus();
                pos.LoadCart();
                this.Dispose();
            }
        }
    }
}
