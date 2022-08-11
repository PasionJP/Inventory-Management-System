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
    public partial class POS : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "POS System";
        string id;
        public decimal price;
        public POS()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
        }
        public void GetTransactNo()
        {
            try
            {
                string currDate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                con.Open();
                cmd = new SqlCommand("SELECT TOP 1 transno FROM cartTbl WHERE transno LIKE '" + currDate + "%' order by id desc", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows) 
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    TransactNo.Text = currDate + (count + 1);
                }
                else
                {
                    transno = currDate + "1001";
                    TransactNo.Text = transno;
                }
                dr.Close();
                con.Close();
            } catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void NewTransactButton_Click(object sender, EventArgs e)
        {
            GetTransactNo();
            searchBox.Enabled = true;
            searchBox.Focus();
        }

        private void TransactNo_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            try{
                if (searchBox.Text == String.Empty)
                {
                    return;
                } else {
                    con.Open();
                    cmd = new SqlCommand("SELECT * from Products WHERE Barcode like '" + searchBox.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        itemQty frm = new itemQty(this);
                        frm.ProductDetails(dr["pcode"].ToString(), double.Parse(dr["price"].ToString()), TransactNo.Text);
                        dr.Close();
                        con.Close();
                        frm.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        con.Close();
                    }
                    
                }
            }catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Remove")
            {
                if(MessageBox.Show("Are you sure you want to remove this item in your cart?", "Remove item from cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE from cartTbl where id like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item has been removed from the cart successfuly", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            } else if (colName == "removeQty")
            {
                if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()) == 1) return;
                else
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE cartTbl SET qty = (qty - " + 1 + ") WHERE id LIKE '" + int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadCart();
                }
            } else if (colName == "addQty")
            {
                int prodQty;
                con.Open();
                cmd = new SqlCommand("SELECT qty FROM Products WHERE pcode like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                prodQty = int.Parse(dr["qty"].ToString());
                con.Close();
                if (prodQty <= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()))
                {
                    MessageBox.Show("Sorry, we don't have enough stock. Remaining quantity on hand is only " + prodQty + ".", "Product Availability", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE cartTbl SET qty = (qty + " + 1 + ") WHERE id LIKE '" + int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadCart();
                }
            }
        }

        public void LoadCart()
        {
            try
            {
                Boolean hasRecord = false;
                dataGridView1.Rows.Clear();
                int i = 0;
                double total = 0;
                double disc = 0;
                con.Open();
                cmd = new SqlCommand("SELECT c.id, c.pcode, p.ProductName, c.price, c.qty, c.disc, c.total FROM cartTbl as c inner join Products as p on c.pcode = p.pcode WHERE transno like '" + TransactNo.Text + "' AND status like 'Pending'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += Double.Parse(dr["total"].ToString());
                    disc += Double.Parse(dr["disc"].ToString());
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["ProductName"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                    hasRecord = true;
                }
                dr.Close();
                con.Close();
                subtotalLblValue.Text = (total+disc).ToString("#,##0.00");
                discountLblValue.Text = disc.ToString("#,##0.00");
                cartTotal();
                if (hasRecord == true) 
                { 
                    PaymentButton.Enabled = true;
                } else
                {
                    PaymentButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdvSearchButton_Click(object sender, EventArgs e)
        {
            if (TransactNo.Text == "000000000000") { return; }
            SearchItem frm = new SearchItem(this);
            frm.LoadProducts();
            frm.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void cartTotal()
        {
            double total = double.Parse(totalLblValue.Text);
            double discount = Double.Parse(discountLblValue.Text);
            double sales = Double.Parse(subtotalLblValue.Text) - discount;
            double vat = sales * dbCon.getVal();
            double vatable = sales - vat;
            totalLblValue.Text = sales.ToString("#,##0.00");
            vatLblValue.Text = vat.ToString("#,##0.00");
            vatableLblValue.Text = vatable.ToString("#,##0.00");
            
        }

        private void DiscountButton_Click(object sender, EventArgs e)
        {
            DiscountForm frm = new DiscountForm(this);
            frm.idLbl.Text = id;
            frm.selectedItemCost = price;
            frm.totalItemsCost = subtotalLblValue.Text;
            frm.ShowDialog();
            LoadCart();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1[1, i].Value.ToString();
            price = Decimal.Parse(dataGridView1[7, i].Value.ToString());
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            SettlePaymentForm frm = new SettlePaymentForm(this);
            frm.amountTB.Text = totalLblValue.Text;
            frm.ShowDialog();
        }
    }
}
