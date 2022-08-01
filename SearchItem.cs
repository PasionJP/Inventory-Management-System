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
    public partial class SearchItem : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "POS System";
        public SearchItem()
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.DBConnection());
        }

        private void SearchItem_Load(object sender, EventArgs e)
        {

        }
        private void GetProductsRecord()
        {

            SqlCommand cmd = new SqlCommand("Select * from Products", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();

            dataGridView1.DataSource = dt;
            for (var i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow r = dataGridView1.Rows[i];
                r.Height = 50;
            }
            var imageColumn = (DataGridViewImageColumn)dataGridView1.Columns["productPhoto"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            GetProductsRecord();
        }
    }
}
