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
    public partial class TopSellingControl : UserControl
    {
        public TopSellingControl()
        {
            InitializeComponent();
        }

        private string _prodName;
        private string _price;
        private string _units;
        private string _pcode;

        [Category("Custom Props")]
        public string ProdName
        {
            get { return _prodName; }
            set { _prodName = value; prodNameLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; prodPriceLbl.Text = value; }
        }

        [Category("Custom Props")]
        public string Units
        {
            get { return _units; }
            set { _units = value; unitsSoldLbl.Text = value; }
        }

        [Category("Custom Props")]
        public string Pcode
        {
            get { return _pcode; }
            set { _pcode = value; }
        }

        private void prodNameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
