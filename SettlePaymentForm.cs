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
    public partial class SettlePaymentForm : Form
    {
        POS f;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        public SettlePaymentForm(POS frm)
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            f = frm;
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cashTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double amount = double.Parse(amountTB.Text);
                double cash = double.Parse(cashTB.Text);
                double change = cash - amount;
                changeTB.Text = change.ToString("#,##0.00");
            } catch (Exception ex)
            {
                changeTB.Text = "0.00";
            }
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            cashTB.Text += oneBtn.Text;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            cashTB.Text += twoBtn.Text;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            cashTB.Text += threeBtn.Text;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            cashTB.Text += fourBtn.Text;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            cashTB.Text += fiveBtn.Text;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            cashTB.Text += sixBtn.Text;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            cashTB.Text += sevenBtn.Text;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            cashTB.Text += eightBtn.Text;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            cashTB.Text += nineBtn.Text;
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            cashTB.Text += zeroBtn.Text;
        }

        private void zeroZeroBtn_Click(object sender, EventArgs e)
        {
            cashTB.Text += zeroZeroBtn.Text;
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            cashTB.Clear();
            cashTB.Focus();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double.Parse(changeTB.Text) < 0) || (cashTB.Text == String.Empty))
                {
                    MessageBox.Show("Insufficient amount.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for (int i = 0; i<f.dataGridView1.Rows.Count; i++) 
                    {
                        con.Open();
                        cmd = new SqlCommand("UPDATE Products  SET qty = qty - " + int.Parse(f.dataGridView1.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode = '" + f.dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        cmd = new SqlCommand("UPDATE cartTbl  SET status = 'Sold' WHERE id = '" + f.dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    ReceiptForm frm = new ReceiptForm(f);
                    String.Format("#,##0.00", cashTB.Text);
                    frm.LoadReport(cashTB.Text, changeTB.Text);
                    frm.ShowDialog();

                    MessageBox.Show("Payment successfully saved!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.GetTransactNo();
                    f.LoadCart();
                    this.Dispose();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Insufficient amount.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
