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
using System.Data.OleDb;

namespace Login_Form
{
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "POS System";
        public Dashboard()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            getTotalSales();
            getTotalProducts();
            getTotalEmployees();
            getSalesChart();
            displayTopSellingItems();
        }
        public void getTotalSales()
        {
            var query = "SELECT SUM(CAST(total as decimal(18, 2))) FROM cartTbl WHERE status = 'Sold'";
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.ExecuteNonQuery();
                object result = cmd.ExecuteScalar();
                salesLbl.Text = Double.Parse(Convert.ToString(result)).ToString("₱#,##0.00");
            }
            con.Close();
        }
        public void getTotalProducts()
        {
            var query = "SELECT COUNT(pcode) FROM Products";
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.ExecuteNonQuery();
                object result = cmd.ExecuteScalar();
                productsLbl.Text = Convert.ToString(result);
            }
            con.Close();
        }
        public void getTotalEmployees()
        {
            var query = "SELECT COUNT(EmployeeID) FROM Employees";
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.ExecuteNonQuery();
                object result = cmd.ExecuteScalar();
                employeeLbl.Text = Convert.ToString(result);
            }
            con.Close();
        }

        private void productsLbl_Click(object sender, EventArgs e)
        {

        }
        public void getSalesChart()
        {
            SalesChart sc = new SalesChart();
            sc.TopLevel = false;
            salesChartPanel.Controls.Add(sc);
            sc.Dock = DockStyle.Fill;
            sc.BringToFront();
            sc.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void displayTopSellingItems()
        {
            DateTime currdate = DateTime.Now;
            currdate = currdate.AddDays(-30);
            DateTime currdate1 = DateTime.Now;

            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT TOP 10 pcode, productName, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total, price from soldItemsView WHERE sdate BETWEEN '" + currdate.ToString("MM/dd/yyyy") + "' AND '" + currdate1.ToString("MM/dd/yyyy") + "' AND status like 'Sold' GROUP BY pcode, productName, price ORDER BY qty DESC", con);
            dr = cmd.ExecuteReader();
            TopSellingControl[] tsControl = new TopSellingControl[10];

            while (dr.Read())
            {
                i++;
                tsControl[i] = new TopSellingControl();
                tsControl[i].ProdName = dr["productName"].ToString();
                tsControl[i].Price = Double.Parse(dr["price"].ToString()).ToString("₱#,##0.00");
                tsControl[i].Units = dr["qty"].ToString();
                panelTopSellingItems.Controls.Add(tsControl[i]);
            }
            dr.Close();
            con.Close();
        }

        private void salesChartPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTopSellingItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
