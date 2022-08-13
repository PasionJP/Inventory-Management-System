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
    public partial class SalesAnalyticsForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "POS System";
        public SalesAnalyticsForm()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            DateTime currdate = DateTime.Now;
            currdate = currdate.AddDays(-30);
            DateTime currdate1 = DateTime.Now;
            datePicker1.Value = currdate;
            datePicker2.Value = currdate1;
        }

        private void SalesAnalyticsForm_Load(object sender, EventArgs e)
        {
            LoadSalesOverview();
            salesTotalOverviewText();
        }

        private void soldItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = salesOverviewDataGridView.Columns[e.ColumnIndex].Name;
            if (colName == "cancel")
            {
                voidForm voidF = new voidForm();
                voidF.idTB.Text = salesOverviewDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                voidF.transacnoTB.Text = salesOverviewDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                voidF.pcodeTB.Text = salesOverviewDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                voidF.pNameTB.Text = salesOverviewDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                voidF.priceTB.Text = salesOverviewDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                voidF.qtyTB.Text = salesOverviewDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                voidF.discTB.Text = salesOverviewDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                voidF.totalTB.Text = salesOverviewDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                voidF.ShowDialog();
                LoadSalesOverview();
            }
        }
        public void LoadSalesOverview()
        {
            try
            {
                int i = 0;
                salesOverviewDataGridView.Rows.Clear();
                con.Open();
                cmd = new SqlCommand("SELECT ISNULL(SUM(id),0) as id, transno, pcode, productName, price, qty, disc, total FROM salesAnalyticsView WHERE sdate BETWEEN '" + datePicker1.Value.ToString("MM/dd/yyyy") + "' AND '" + datePicker2.Value.ToString("MM/dd/yyyy") + "' AND status = 'Sold' GROUP BY transno, pcode, productName, price, qty, disc, total, status ORDER BY id DESC;", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    salesOverviewDataGridView.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["productName"].ToString(), double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["qty"].ToString(), double.Parse(dr["disc"].ToString()).ToString("#,##0.00"), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void salesTotalOverviewText()
        {
            var query = "SELECT ISNULL(SUM(CAST(total as decimal(18, 2))), 0) FROM cartTbl WHERE sdate BETWEEN '" + datePicker1.Value.ToString("MM/dd/yyyy") + "' AND '" + datePicker2.Value.ToString("MM/dd/yyyy") + "' AND status = 'Sold'";
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.ExecuteNonQuery();
                object result = cmd.ExecuteScalar();
                totalSalesOverview.Text = Double.Parse(Convert.ToString(result)).ToString("₱#,##0.00");
            }
            con.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesOverview();
            salesTotalOverviewText();
        }

        private void datePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesOverview();
            salesTotalOverviewText();
        }
    }
}
