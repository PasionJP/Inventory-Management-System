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
    public partial class voidForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        string title = "POS System";
        new bool MouseDown;
        private Point offset;
        public voidForm()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
        }

        private void voidForm_Load(object sender, EventArgs e)
        {
            restockCB.SelectedItem = "Yes";
            ActiveControl = cancelQtyTB;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(51, 52, 54);
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

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(29, 30, 32);
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                if ((restockCB.Text != String.Empty) && (cancelQtyTB.Text != String.Empty) && (reasonTB.Text != String.Empty))
                {
                    if (int.Parse(qtyTB.Text) >= int.Parse(cancelQtyTB.Text))
                    {
                        if (restockCB.Text == "Yes")
                        {
                            updateDatabase("UPDATE Products SET qty = qty + " + int.Parse(cancelQtyTB.Text) + " WHERE pcode = '" + pcodeTB.Text + "'");
                        }
                        updateDatabase("UPDATE cartTbl SET qty = qty - " + int.Parse(cancelQtyTB.Text) + " WHERE id like '" + idTB.Text + "'");
                        saveVoidOrder();
                        MessageBox.Show("Item void successful!", "Void Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            //} catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
}

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void saveVoidOrder()
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO voidTbl (transno, pcode, price, qty, sdate, voidBy, cancelledBy, reason, action) VALUES (@transno, @pcode, @price, @qty, @sdate, @voidBy, @cancelledBy, @reason, @action)", con);
            cmd.Parameters.AddWithValue("@transno", transacnoTB.Text);
            cmd.Parameters.AddWithValue("@pcode", pcodeTB.Text);
            cmd.Parameters.AddWithValue("@price", double.Parse(priceTB.Text));
            cmd.Parameters.AddWithValue("@qty", int.Parse(cancelQtyTB.Text));
            cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
            cmd.Parameters.AddWithValue("@voidBy", voidByTB.Text);
            cmd.Parameters.AddWithValue("@cancelledBy", cancelledByTB.Text);
            cmd.Parameters.AddWithValue("@reason", reasonTB.Text);
            cmd.Parameters.AddWithValue("@action", restockCB.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateDatabase(string sql)
        {
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
