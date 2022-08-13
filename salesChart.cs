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
using System.Windows.Forms.DataVisualization.Charting;

namespace Login_Form
{
    public partial class SalesChart : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        public SalesChart()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
        }
        private void SalesChart_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CAST(MONTH(sdate) AS VARCHAR(2)) + '-' + CAST(YEAR(sdate) AS VARCHAR(4)) AS IMSsales, ISNULL(SUM(total), 0.00) as total from cartTbl WHERE status = 'Sold' GROUP BY CAST(MONTH(sdate) AS VARCHAR(2)) + '-' + CAST(YEAR(sdate) AS VARCHAR(4))", con);
            DataSet ds = new DataSet();

            da.Fill(ds, "Sales");
            chart1.DataSource = ds.Tables["Sales"];
            Series series1 = chart1.Series["Date"];

            series1.Name = "SALES";

            var chart = chart1;
            chart1.ChartAreas["ChartArea1"].BackColor = Color.FromArgb(51, 52, 54);
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.FromArgb(238, 238, 238);
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.FromArgb(238, 238, 238);
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(238, 238, 238);
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(238, 238, 238);
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineColor = Color.FromArgb(238, 238, 238);
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineColor = Color.FromArgb(238, 238, 238);
            chart1.Series[series1.Name].XValueMember = "IMSsales";
            chart1.Series[series1.Name].YValueMembers = "total";
            con.Close();

        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void revenueBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
