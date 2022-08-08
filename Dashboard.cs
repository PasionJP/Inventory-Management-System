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
        DatabaseConnection dbCon = new DatabaseConnection();
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
        }
        public void getTotalSales()
        {
            var query = "SELECT SUM(CAST(total as decimal(18, 2))) FROM cartTbl";
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con)){
                cmd.ExecuteNonQuery();
                object result = cmd.ExecuteScalar();
                salesLbl.Text = Convert.ToString(result);
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
    }
}
