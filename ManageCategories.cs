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
    public partial class ManageCategories : Form
    {
        SqlConnection con = new SqlConnection();
        DatabaseConnection dbCon = new DatabaseConnection();
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        string title = "Inventory Management System";
        public int id { get; set; }
        public string category { get; set; }
        public string InsertOrUpdate;
        new bool MouseDown;
        private Point offset;
        public ManageCategories()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (InsertOrUpdate == "update")
            {
                if (id > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE prodCategory SET prodCategory = @prodCategory WHERE id = @id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@prodCategory", pCategoryTB.Text.ToString());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }
            }
            else if (InsertOrUpdate == "insert")
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO prodCategory (prodCategory) VALUES (@prodCategory)", con);
                cmd.Parameters.AddWithValue("@prodCategory", pCategoryTB.Text.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == "update")
            {
                pCategoryTB.Text = category;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pCategoryTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageCategories_Activated(object sender, EventArgs e)
        {
            pCategoryTB.Focus();
        }
        private void label1_Click(object sender, EventArgs e)
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
    }
}
