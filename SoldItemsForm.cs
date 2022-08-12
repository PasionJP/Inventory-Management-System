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
    public partial class SoldItemsForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "POS System";
        public SoldItemsForm()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            //datePicker1.Value = DateTime.Now;
            //datePicker2.Value = DateTime.Now;
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadTopSold()
        {
            soldItemsDataGridView.Rows.Clear();
            int i = 0;
            con.Open();
            if (sortSelect.Text == "Sort by Sales Total")
            {
                cmd = new SqlCommand("SELECT TOP 10 pcode, productName, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total from soldItemsView WHERE sdate BETWEEN '" + datePicker1.Value.ToString("MM/dd/yyyy") + "' AND '" + datePicker2.Value.ToString("MM/dd/yyyy") + "' AND status like 'Sold' GROUP BY pcode, productName ORDER BY total DESC", con);
            } else if (sortSelect.Text == "Sort by Sales Quantity")
            {
                cmd = new SqlCommand("SELECT TOP 10 pcode, productName, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total from soldItemsView WHERE sdate BETWEEN '" + datePicker1.Value.ToString("MM/dd/yyyy") + "' AND '" + datePicker2.Value.ToString("MM/dd/yyyy") + "' AND status like 'Sold' GROUP BY pcode, productName ORDER BY qty DESC", con);
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                soldItemsDataGridView.Rows.Add(i, dr["pcode"].ToString(), dr["productName"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
            }
            dr.Close();
            con.Close();
        }

        private void AdvSearchButton_Click(object sender, EventArgs e)
        {
            LoadTopSold();
        }

        private void sortSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SoldItemsForm_Load(object sender, EventArgs e)
        {
            sortSelect.SelectedIndex = 1;
        }
    }
}
