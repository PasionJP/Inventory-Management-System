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
    public partial class dateSelectForm : Form
    {
        IMS f;
        private bool isCollapsed = true;
        public dateSelectForm(IMS frm)
        {
            InitializeComponent();
            f = frm;
            f.yLoc += 30;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(f.xLoc, f.yLoc) ;
        }

        private void dateSelectForm_Load(object sender, EventArgs e)
        {
        }

        private void todayBtn_Click(object sender, EventArgs e)
        {
            f.currdate1 = DateTime.Now;
            f.currdate2 = DateTime.Now;
            f.dateRange = "today";
            this.Dispose();
            f.getDate();
        }

        private void yesterdayBtn_Click(object sender, EventArgs e)
        {
            f.currdate1 = DateTime.Now;
            f.currdate1 = f.currdate1.AddDays(-1);
            f.currdate2 = f.currdate1;
            f.dateRange = "yesterday";
            this.Dispose();
            f.getDate();
        }

        private void last7DaysBtn_Click(object sender, EventArgs e)
        {
            f.currdate1 = DateTime.Now;
            f.currdate1 = f.currdate1.AddDays(-7);
            f.currdate2 = DateTime.Now;
            f.dateRange = "last 7 days";
            this.Dispose();
            f.getDate();
        }

        private void last30DaysBtn_Click(object sender, EventArgs e)
        {
            f.currdate1 = DateTime.Now;
            f.currdate1 = f.currdate1.AddDays(-30);
            f.currdate2 = DateTime.Now;
            f.dateRange = "last 30 days";
            this.Dispose();
            f.getDate();
        }

        private void thisMonthBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            f.currdate1 = new DateTime(date.Year, date.Month, 1);
            f.currdate2 = f.currdate1.AddMonths(1).AddDays(-1);
            f.dateRange = "this month";
            this.Dispose();
            f.getDate();
        }

        private void lastMonthBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            f.currdate1 = new DateTime(date.Year, date.Month, 1);
            f.currdate1 = f.currdate1.AddMonths(-1);
            f.currdate2 = f.currdate1.AddMonths(1).AddDays(-1);
            f.dateRange = "last month";
            this.Dispose();
            f.getDate();
        }

        private void customBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                f.dateSelectBtn.Image = Resources.collapse_arrow;
                this.Height += 10;
                if (this.Size == this.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                f.dateSelectBtn.Image = Resources.expand_arrow;
                this.Height -= 10;
                if (this.Size == this.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            f.currdate1 = dateTimePicker1.Value;
            f.currdate2 = dateTimePicker2.Value;
            f.dateRange = f.currdate1.ToString("MM/dd/yyyy") + " - " + f.currdate2.ToString("MM/dd/yyyy");
            this.Dispose();
            f.getDate();
        }

        private void dateSelectForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
