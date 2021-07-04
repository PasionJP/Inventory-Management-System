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
        SqlConnection salesCon = new SqlConnection(@"Data Source=LAPTOP-EVOGUQ1J\SQLEXPRESS;Initial Catalog=Sales;Integrated Security=True");
        private void SalesChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet2.Revenue' table. You can move, or remove it, as needed.
            this.revenueTableAdapter1.Fill(this.salesDataSet2.Revenue);
            chart1.ChartAreas["ChartArea1"].BackColor = Color.FromArgb(51, 52, 54);
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.FromArgb(238, 238, 238);
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.FromArgb(238, 238, 238);
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(238, 238, 238);
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(238, 238, 238);
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineColor = Color.FromArgb(238, 238, 238);
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineColor = Color.FromArgb(238, 238, 238);
            chart1.Series["Date"].XValueMember = "Date";
            chart1.Series["Date"].YValueMembers = "Revenue";
            chart1.DataSource = salesDataSet2.Revenue;
            chart1.DataBind();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int last = 0;
            Cursor.Current = Cursors.WaitCursor;
            while (dataGridView1.Rows[last].Cells[0].Value != null)
            {
                last++;
            }
            try
            {
                revenueBindingSource1.EndEdit();
                revenueTableAdapter1.Update(this.salesDataSet2.Revenue);
                
                for (int i = last; i < dataGridView1.Rows.Count-1; i++)
                {
                    SqlCommand salesCmd = new SqlCommand("INSERT INTO Revenue (Day,Date,Revenue) VALUES('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "')", salesCon);
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
            chart1.DataSource = salesDataSet2.Revenue;
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
            this.revenueTableAdapter1.Fill(this.salesDataSet2.Revenue);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void revenueBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
