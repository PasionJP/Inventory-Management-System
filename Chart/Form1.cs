using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet.Revenue' table. You can move, or remove it, as needed.
            this.revenueTableAdapter.Fill(this.salesDataSet.Revenue);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                revenueBindingSource.EndEdit();
                revenueTableAdapter.Update(salesDataSet.Revenue);
                MessageBox.Show("Your data is successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception except)
            {
                MessageBox.Show(except.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            chart1.Series["Date"].XValueMember = "Date";
            chart1.Series["Date"].YValueMembers = "Revenue";
            chart1.DataSource = salesDataSet.Revenue;
            chart1.DataBind();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
