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
        public IMS()
        {
            InitializeComponent();
            dropDown();
        }

        private void dropDown()
        {
            ordersDropdown.Visible = false;
        }

        private void hideDropdown()
        {
            if (ordersDropdown.Visible == false)
                ordersDropdown.Visible = true;
        }
        private void showDropdown(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideDropdown();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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
            showDropdown(ordersDropdown);
        }
    }
}
