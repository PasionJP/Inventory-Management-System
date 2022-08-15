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
    public partial class analyticsUserLog : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "User Log Analytics";
        public analyticsUserLog()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
        }

        private void AdvSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(columnSelect.Text))
                {
                    if (string.IsNullOrEmpty(searchBox.Text))
                        userlogDB();
                    else
                    {
                        string rowFilter = "[" + columnSelect.Text + "] LIKE '%" + searchBox.Text + "%'";
                        (userLogDataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void userlogDB()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT RTRIM(LTRIM(CONCAT(COALESCE(Lastname, ''), ', ', COALESCE(Firstname + ' ', '')))) AS Fullname, ISNULL(SUM(idLog), 0) AS idLog, EmployeeID, Usertype, username, dateLog, timeLog, status FROM userLog GROUP BY Firstname, Lastname, EmployeeID, Usertype, username, dateLog, timeLog, status ORDER BY idLog DESC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                userLogDataGridView.AutoGenerateColumns = false;
                userLogDataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            columnSelect.SelectionLength = 0;
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(columnSelect.Text))
                    {
                        if (string.IsNullOrEmpty(searchBox.Text))
                            userlogDB();
                        else
                        {
                            string rowFilter = "[" + columnSelect.Text + "] LIKE '%" + searchBox.Text + "%'";
                            (userLogDataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void analyticsUserLog_Load(object sender, EventArgs e)
        {
            columnSelect.SelectedIndex = 1;
            DateTime currdate = DateTime.Now;
            currdate = currdate.AddDays(-30);
            DateTime currdate1 = DateTime.Now;
            datePicker1.Value = currdate;
            datePicker2.Value = currdate1;
            userlogDB();
        }
    }
}
