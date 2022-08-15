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
using System.IO;

namespace Login_Form
{
    public partial class CreateUpdateProducts : Form
    {
        public int id { get; set; }
        public string CreateOrUpdate { get; set; }
        public string productName { get; set; }
        public string barcode { get; set; }
        public string category { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
        new bool MouseDown;
        private Point offset;
        public string pcodeNew = "";
        string photoLocation = "";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        public CreateUpdateProducts()
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            this.KeyPreview = true;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateUpdateProducts_Load(object sender, EventArgs e)
        {
            if (CreateOrUpdate == "update")
            {
                pNameTB.Text = productName;
                bCodeTB.Text = barcode;
                quantityTB.Text = quantity;
                priceTB.Text = price;
            }
            categoryBoxFill();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (CreateOrUpdate == "update")
            {
                if (id > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Products SET productName = @pName, barcode = @bCode, qty = @quantity, price = @price, productPhoto = @productPhoto WHERE id = @id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@pCode", pcodeNew);
                    cmd.Parameters.AddWithValue("@pName", pNameTB.Text);
                    cmd.Parameters.AddWithValue("@bCode", bCodeTB.Text);
                    cmd.Parameters.AddWithValue("@category", categoryCB.Text.ToString());
                    cmd.Parameters.AddWithValue("@quantity", quantityTB.Text);
                    cmd.Parameters.AddWithValue("@price", priceTB.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    if (string.IsNullOrEmpty(photoLocation))
                    {
                        photoLocation = Application.StartupPath + @"\images\no image available.jpg";
                    }
                    byte[] images = null;
                    FileStream fstream = new FileStream(photoLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(fstream);
                    images = brs.ReadBytes((int)fstream.Length);
                    cmd.Parameters.Add(new SqlParameter("@productPhoto", images));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }
            } else if (CreateOrUpdate == "insert")
            {
                GenerateNewPcode();
                con.Open();
                cmd = new SqlCommand("INSERT INTO Products (productName, pcode, barcode, category, qty, price, productPhoto) VALUES (@pName, @pcode, @bCode, @category, @quantity, @price, @productPhoto)", con);
                cmd.Parameters.AddWithValue("@pName", pNameTB.Text);
                cmd.Parameters.AddWithValue("@pcode", pcodeNew);
                cmd.Parameters.AddWithValue("@bCode", bCodeTB.Text);
                cmd.Parameters.AddWithValue("@category", categoryCB.Text.ToString());
                cmd.Parameters.AddWithValue("@quantity", quantityTB.Text);
                cmd.Parameters.AddWithValue("@price", priceTB.Text);

                if (string.IsNullOrEmpty(photoLocation))
                {
                    photoLocation = Application.StartupPath + @"\images\no image available.jpg";
                }
                byte[] images = null;
                FileStream fstream = new FileStream(photoLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(fstream);
                images = brs.ReadBytes((int)fstream.Length);
                cmd.Parameters.Add(new SqlParameter("@productPhoto", images));

                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
        }
        public void categoryBoxFill()
        {
            con.Open();
            cmd = new SqlCommand("SELECT Id, prodCategory FROM prodCategory", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow item = dt.NewRow();
            item[1] = "Select a Category";
            dt.Rows.InsertAt(item, 0);

            categoryCB.DataSource = dt;
            categoryCB.DisplayMember = "prodCategory";
            categoryCB.ValueMember = "Id";

        }

        private void categoryCB_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { categoryCB.Select(0, 0); }));
        }
        public string GenerateNewPcode()
        {
            int pID;
            con.Open();
            cmd = new SqlCommand("SELECT max(id) FROM Products", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (string.IsNullOrEmpty(dr[0].ToString()))
                {
                    pcodeNew = "P001";
                    MessageBox.Show(pcodeNew);
                }
                else
                {
                    pID = int.Parse(dr[0].ToString());
                    pcodeNew = "P00" + (pID + 1).ToString();
                }
            }
            con.Close();
            return pcodeNew;
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                photoLocation = opf.FileName.ToString();
                productPhoto.ImageLocation = photoLocation;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            photoLocation = "";
            productPhoto.Image = null;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
