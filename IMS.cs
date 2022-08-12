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

        private void button3_Click(object sender, EventArgs e)
        {
            openNewWindow(new SalesChart());
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            openNewWindow(new ProductsV1());
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
            openNewWindow(new ProductsV1());
        }

        private void prodInStock_Click_1(object sender, EventArgs e)
        {
            openNewWindow(new ProductsV1());
        }

        private void prodCategories_Click(object sender, EventArgs e)
        {
            openNewWindow(new ViewCategories());
        }

        private void topSellingBtn_Click(object sender, EventArgs e)
        {
            openNewWindow(new SoldItemsForm());
        }
    }
}
