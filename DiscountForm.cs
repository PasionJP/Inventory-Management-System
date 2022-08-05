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
    public partial class DiscountForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        POS f;
        string stitle = "Point-of-Sale";
        public DiscountForm(POS frm)
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
            f = frm;
        }

        private void Insert_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void discountTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double discount = Double.Parse(priceTB.Text) * Double.Parse(discountTB.Text) * .01 ;
                dcAmountTB.Text = discount.ToString("#,##0.00");
            } catch (Exception ex)
            {
                dcAmountTB.Text = "0.00";
            }
        }

        private void Insert_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Add discount?", stitle, MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("UPDATE cartTbl SET disc = @disc WHERE id = @id", con);
                    cm.Parameters.AddWithValue("@disc", Double.Parse(dcAmountTB.Text));
                    cm.Parameters.AddWithValue("@id", int.Parse(idLbl.Text));
                    cm.ExecuteNonQuery();
                    con.Close();
                    f.LoadCart();
                    this.Dispose();
                }
            }catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void idLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
