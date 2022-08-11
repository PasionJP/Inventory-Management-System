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
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        POS f;
        new bool MouseDown;
        private Point offset;
        string stitle = "Point-of-Sale";
        public decimal selectedItemCost;
        public string totalItemsCost { get; set; }
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
                double discount = Double.Parse(priceTB.Text) * Double.Parse(discountTB.Text) * .01;
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
                if (selectDiscount.Text == "Selected Item")
                {
                        con.Open();
                        cmd = new SqlCommand("UPDATE cartTbl SET disc = @disc WHERE id = @id", con);
                        cmd.Parameters.AddWithValue("@disc", Double.Parse(dcAmountTB.Text));
                        cmd.Parameters.AddWithValue("@id", int.Parse(idLbl.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                } else if (selectDiscount.Text == "All Items")
                {
                    for (int i = 0; i < f.dataGridView1.Rows.Count; i++)
                    {
                        con.Open();
                        double discount = (Double.Parse(f.dataGridView1.Rows[i].Cells[7].Value.ToString()) + Double.Parse(f.dataGridView1.Rows[i].Cells[6].Value.ToString())) * Double.Parse(discountTB.Text) * .01;
                        cmd = new SqlCommand("UPDATE cartTbl  SET disc = " + discount + " WHERE id like '" + int.Parse(f.dataGridView1.Rows[i].Cells[1].Value.ToString()) + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }     
                }
                this.Dispose();
            }catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void idLbl_Click(object sender, EventArgs e)
        {

        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            MouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (MouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void selectDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectDiscount.Text == "All Items")
            {
                priceTB.Text = totalItemsCost.ToString();
            } else if (selectDiscount.Text == "Selected Item")
            {
                priceTB.Text = selectedItemCost.ToString();
            }
        }

        private void DiscountForm_Load(object sender, EventArgs e)
        {
            selectDiscount.SelectedText = "Selected Item";
            priceTB.Text = selectedItemCost.ToString();
        }
    }
}
