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
    public partial class ViewCategories : Form
    {
        readonly SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "Inventory Management System";
        public ViewCategories()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            GetCategories();
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            ManageCategories MCfrm = new ManageCategories();
            MCfrm.InsertOrUpdate = "insert";
            MCfrm.ShowDialog();
            GetCategories();
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = categoriesDataGridView.Columns[e.ColumnIndex].Name;
            if (colName == "Remove")
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM prodCategory WHERE Id like '" + categoriesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                GetCategories();
            }
            else if (colName == "Edit")
            {
                ManageCategories MCfrm = new ManageCategories();
                MCfrm.InsertOrUpdate = "update";
                if (categoriesDataGridView.SelectedRows[0].Cells[1].Value != null)
                {
                    MCfrm.id = Convert.ToInt32(categoriesDataGridView.Rows[e.RowIndex].Cells[1].Value);
                    MCfrm.category = categoriesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                MCfrm.ShowDialog();
                GetCategories();
            }
        }
        public void GetCategories()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM prodCategory", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categoriesDataGridView.AutoGenerateColumns = false;
                categoriesDataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void categoriesDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.categoriesDataGridView.Rows[e.RowIndex].Cells["row"].Value = (e.RowIndex + 1).ToString();
        }

        private void categoriesDataGridView_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (searchBox.Text == String.Empty)
                {
                    GetCategories();
                    return;
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from prodCategory WHERE prodCategory like '%" + searchBox.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    categoriesDataGridView.AutoGenerateColumns = false;
                    categoriesDataGridView.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
