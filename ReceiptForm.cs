using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace Login_Form
{
    public partial class ReceiptForm : Form
    {
        POS f;
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        public ReceiptForm(POS frm)
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            f = frm;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        public void LoadReport(string pcash, string pchange)
        {
            ReportDataSource reportDS;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report1.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                ReceiptDataSet ds = new ReceiptDataSet();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand("SELECT c.id, c.transno, c.pcode, c.price, c.qty, c.disc, c.total, c.sdate, c.status, c.cashier, p.productName from cartTbl as c INNER JOIN Products AS p ON p.pcode = c.pcode WHERE  transno like '" + f.TransactNo.Text + "'", con);
                da.Fill(ds.Tables["dtSold"]);
                con.Close();
                
                ReportParameter pStore = new ReportParameter("pStore", dbCon.storeName);
                ReportParameter pAddress = new ReportParameter("pAddress", dbCon.storeAddress);
                ReportParameter pTransaction = new ReportParameter("pTransaction", "Invoice #: " + f.TransactNo.Text);
                ReportParameter pVatable = new ReportParameter("pVatable", f.vatableLblValue.Text);
                ReportParameter pVat = new ReportParameter("pVat", f.vatLblValue.Text);
                ReportParameter pDiscount = new ReportParameter("pDiscount", f.discountLblValue.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", f.totalLblValue.Text);
                ReportParameter pCash = new ReportParameter("pCash", pcash);
                ReportParameter pChange = new ReportParameter("pChange", pchange);

                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);
                reportViewer1.LocalReport.SetParameters(pTransaction);
                reportViewer1.LocalReport.SetParameters(pVatable);
                reportViewer1.LocalReport.SetParameters(pVat);
                reportViewer1.LocalReport.SetParameters(pDiscount);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pCash);
                reportViewer1.LocalReport.SetParameters(pChange);

                reportDS = new ReportDataSource("ReceiptDataSet", ds.Tables["dtSold"]);
                reportViewer1.LocalReport.DataSources.Add(reportDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            } catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
        public string getCashierName()
        {
            string cashierName = "";
            string query = "SELECT RTRIM(LTRIM(CONCAT(COALESCE(Lastname, ''), ', ', COALESCE(FirstName + ' ', ''), COALESCE(MiddleName + ' ', '')))) AS Fullname, EmployeeID FROM Employees WHERE EmployeeID = '" + f.cashierName.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                cashierName = dt.Rows[0]["Fullname"].ToString();
            }
            return cashierName;
        }
    }
}
