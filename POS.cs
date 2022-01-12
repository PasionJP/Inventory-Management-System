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
                string transNo;
                int count;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transactNo FROM [Transaction] WHERE transactNo LIKE '%" + currDate + "'",cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transNo = dr[0].ToString();
                    count = int.Parse(transNo.Substring(8, 4));
                    TransactNo.Text = currDate + (count + 1);
                }
                else
                {
                    transNo = currDate + "1001";
                    TransactNo.Text = transNo;
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

        }
    }
}
