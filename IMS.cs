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


namespace Login_Form
{
    public partial class IMS : Form
    {
        private bool isCollapsed;
        public IMS()
        {
            InitializeComponent();
            openNewWindow(new Dashboard());
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Orders_Click(object sender, EventArgs e)
        {
            
        }

        private void orders_Click_1(object sender, EventArgs e)
        {
            openNewWindow(new POS());
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        { 
            openNewWindow(new Dashboard());
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

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openNewWindow(new ViewEmployees());
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            openNewWindow(new ViewCategories());
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

        private void Products_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void prodInStock_Click_1(object sender, EventArgs e)
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

        private void topSellingBtn_Click_1(object sender, EventArgs e)
        {
            openNewWindow(new TopSellingForm());
        }

        private void salesOverviewBtn_Click_1(object sender, EventArgs e)
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
    }
}
