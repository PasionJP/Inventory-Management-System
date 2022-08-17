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
        public DateTime currdate1;
        public DateTime currdate2;
        public int xLoc;
        public int yLoc;
        public string dateRange = "last 30 days";
        public string userAccess;
        public IMS(Login frm)
        {
            InitializeComponent();
            con = new SqlConnection(dbCon.DBConnection());
            f = frm;
            currdate1 = DateTime.Now;
            currdate1 = currdate1.AddDays(-30);
            currdate2 = DateTime.Now;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            if (f.showDashB)
            {
                getDate();
            } else if (userAccess == "Stock Clerk")
            {
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
            else if (userAccess == "Cashier")
            {
                openNewWindow(new POS(this));
            }
            
            if (isCollapsed)
            {
                Products.Image = Resources.collapse_arrow;
                analyticsBtn.Image = Resources.collapse_arrow;
                isCollapsed = false;
            }
            else
            {
                Products.Image = Resources.expand_arrow;
                analyticsBtn.Image = Resources.expand_arrow;
                isCollapsed = true;
            }
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
            Dashboard dashB = new Dashboard(this);
            dashB.TopLevel = false;
            panelMenu.Controls.Add(dashB);
            dashB.Dock = DockStyle.Fill;
            dashB.BringToFront();
            dashB.Show();
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

        public void getDate()
        {
            dateSelectBtn.Text = currdate1.ToString("MM/dd/yyyy") + " - " + currdate2.ToString("MM/dd/yyyy");

            Dashboard dashB = new Dashboard(this);
            dashB.TopLevel = false;
            panelMenu.Controls.Add(dashB);
            dashB.Dock = DockStyle.Fill;
            dashB.dateRangeLbl.Text = dateRange;
            dashB.BringToFront();
            dashB.Show();
        }

        private void dateSelectBtn_Click(object sender, EventArgs e)
        {
            Point location = PointToScreen(panel3.Location);
            yLoc = Convert.ToInt32(location.Y);
            xLoc = Convert.ToInt32(location.X);
            dateSelectForm dateSel = new dateSelectForm(this);
            dateSel.Show(this);
        }
    }
}
