using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class salesChart : Form
    {
        public salesChart()
        {
            InitializeComponent();
        }

        private void enterData_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in chartBindingSource.DataSource as List<Chart>
                         select new { Year = o.Year }).Distinct();
            foreach (var year in years)
            {
                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in chartBindingSource.DataSource as List<Chart>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Sales, o.Month };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().Sales;
                    values.Add(value);
                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChart1.Series = series;
        }
        private void salesChart_Load(object sender, EventArgs e)
        {
            chartBindingSource.DataSource = new List<Chart>();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Sales",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }
    }
}
