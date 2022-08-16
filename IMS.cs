using Login_Form.Properties;
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
    public partial class IMS : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbCon = new DatabaseConnection();
        private bool isCollapsed;
        public static string cashierFullname = "";
        Login f;
        public IMS(Login frm)
        {
            InitializeComponent();
            openNewWindow(new Dashboard());
            con = new SqlConnection(dbCon.DBConnection());
            f = frm;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            getDate();
        }

        private Form activeForm = null;
        private void openNewWindow(Form openMenu)
        {
            if (this.activeForm!=null)
                activeForm.Close();
            activeForm = openMenu;
            openMenu.TopLevel = false;
            openMenu.FormBorderStyle = FormBorderStyle.None;
            openMenu.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(openMenu);
            panelMenu.Tag = openMenu;
            openMenu.BringToFront();
            openMenu.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Products.Image = Resources.collapse_arrow;
                productsPanel.Height += 10;
                if (productsPanel.Size == productsPanel.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            } else
            {
                Products.Image = Resources.expand_arrow;
                productsPanel.Height -= 10;
                if (productsPanel.Size == productsPanel.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void prodCategories_Click(object sender, EventArgs e)
        {
            openNewWindow(new ViewCategories());
        }

        private void topSellingBtn_Click(object sender, EventArgs e)
        {
            openNewWindow(new TopSellingForm());
        }

        private void allProducts_Click(object sender, EventArgs e)
        {
            ProductsV1 products = new ProductsV1();
            products.stockQty = -1;
            products.TopLevel = false;
            panelMenu.Controls.Add(products);
            products.Dock = DockStyle.Fill;
            products.BringToFront();
            products.Show();
        }

        private void salesOverviewBtn_Click(object sender, EventArgs e)
        {
            openNewWindow(new SalesAnalyticsForm());
        }

        private void analyticsBtn_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                analyticsBtn.Image = Resources.collapse_arrow;
                panelAnalytics.Height += 10;
                if (panelAnalytics.Size == panelAnalytics.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                analyticsBtn.Image = Resources.expand_arrow;
                panelAnalytics.Height -= 10;
                if (panelAnalytics.Size == panelAnalytics.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void salesChartBtn_Click(object sender, EventArgs e)
        {
            openNewWindow(new SalesChart());
        }

        private void mouseHover_Event(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(61, 62, 64);
        }

        private void mouseLeave_Event(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(51, 52, 54);
        }
        private void employeesBtn_Click(object sender, EventArgs e)
        {
            dateTLP.Visible = false;
            openNewWindow(new ViewEmployees());
        }

        private void orders_Click_2(object sender, EventArgs e)
        {
            dateTLP.Visible = false;
            openNewWindow(new POS(this));
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            dateTLP.Visible = true;
            openNewWindow(new Dashboard());
        }

        private void analyticsBtn_Click_1(object sender, EventArgs e)
        {
            dateTLP.Visible = false;
            timer2.Start();
        }

        private void Products_Click_1(object sender, EventArgs e)
        {
            dateTLP.Visible = false;
            timer1.Start();
        }

        private void prodInStock_Click(object sender, EventArgs e)
        {
            dateTLP.Visible = false;
            ProductsV1 products = new ProductsV1();
            products.productsDataGridView.Columns["Remove"].Visible = false;
            products.productsDataGridView.Columns["Edit"].Visible = false;
            products.addProduct.Visible = false;
            products.stockQty = 0;
            products.TopLevel = false;
            panelMenu.Controls.Add(products);
            products.Dock = DockStyle.Fill;
            products.BringToFront();
            products.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            f.dateLog = DateTime.Now.ToString("MM/dd/yyyy");
            f.timeLog = DateTime.Now.ToString("HH:mm:ss");
            f.status = "Logged out";
            f.userLoginSave(f.empID, f.firstname, f.lastname, f.usertype, f.username, f.dateLog, f.timeLog, f.status);
            Application.Exit();
        }

        private void userLogBtn_Click(object sender, EventArgs e)
        {
            dateTLP.Visible = false;
            openNewWindow(new analyticsUserLog());
        }

        private void dateSelectBtn_Click(object sender, EventArgs e)
        {

        }

        private void getDate()
        {
            DateTime currdate = DateTime.Now;
            currdate = currdate.AddDays(-30);
            DateTime currdate1 = DateTime.Now;
            dateSelectBtn.Text = currdate.ToString("MM/dd/yyyy") + " - " + currdate1.ToString("MM/dd/yyyy");
        }

        private void datePicture_Click(object sender, EventArgs e)
        {

        }
    }
}
