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
    public partial class SalesChart : Form
    {
        public SalesChart()
        {
            InitializeComponent();
        }
        SqlConnection salesCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\JP\Software\Inventory Management System\Github\Login Form\Sales.mdf;Integrated Security=True");
        private void SalesChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet.Revenue' table. You can move, or remove it, as needed.
            this.revenueTableAdapter.Fill(this.salesDataSet.Revenue);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                revenueBindingSource.EndEdit();
                revenueTableAdapter.Update(this.salesDataSet.Revenue);
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    SqlCommand salesCmd = new SqlCommand ("INSERT INTO Revenue (Day,Date,Revenue) VALUES('"+dataGridView1.Rows[i].Cells[0].Value+"','"+dataGridView1.Rows[i].Cells[1].Value+ "','" + dataGridView1.Rows[i].Cells[2].Value + "')",salesCon);
                    salesCon.Open();
                    salesCmd.ExecuteNonQuery();
                    salesCon.Close();
                }
                MessageBox.Show("Your data is successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            chart1.Series["Date"].XValueMember = "Date";
            chart1.Series["Date"].YValueMembers = "Revenue";
            chart1.DataSource = salesDataSet.Revenue;
            chart1.DataBind();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet.Revenue' table. You can move, or remove it, as needed.
            this.revenueTableAdapter.Fill(this.salesDataSet.Revenue);
        }
    }
}
