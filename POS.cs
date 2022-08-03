﻿using System;
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
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "POS System";
        public POS()
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
        }
        private void GetTransactNo()
        {
            try
            {
                string currDate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM cartTbl WHERE transno LIKE '" + currDate + "%' order by id desc", cn);
                dr = cm.ExecuteReader();
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
                cn.Close();
            } catch (Exception ex)
            {
                cn.Close();
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
                    cn.Open();
                    cm = new SqlCommand("SELECT * from Products WHERE Barcode like '" + searchBox.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        itemQty frm = new itemQty(this);
                        frm.ProductDetails(dr["pcode"].ToString(), double.Parse(dr["price"].ToString()), TransactNo.Text);
                        dr.Close();
                        cn.Close();
                        frm.ShowDialog();
                    }
                    dr.Close();
                    cn.Close();
                }
            }catch (Exception ex)
            {
                cn.Close();
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
                    cn.Open();
                    cm = new SqlCommand("DELETE from cartTbl where id like '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been removed from the cart successfuly", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
        }

        public void LoadCart()
        {
            try
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT c.id, c.pcode, p.ProductName, c.price, c.qty, c.disc, c.total FROM cartTbl as c inner join Products as p on c.pcode = p.pcode WHERE transno like '" + TransactNo.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(dr["id"].ToString(), dr["ProductName"].ToString(),  dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString()) ;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdvSearchButton_Click(object sender, EventArgs e)
        {
            if (TransactNo.Text == "000000000000") { return; }
            SearchItem frm = new SearchItem();
            frm.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
