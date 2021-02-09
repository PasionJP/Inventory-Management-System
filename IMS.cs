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
  
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            openNewWinow(new Dashboard());
        }

        private Form activeForm = null;
        private void openNewWinow(Form openMenu)
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
    }
}
