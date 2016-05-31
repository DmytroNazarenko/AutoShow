using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseProject.View
{
    public partial class StatisticForm : Form
    {
        public StatisticForm(double[] a)
        {
            InitializeComponent();
          
            
            this.chart.Titles.Add("Стоимость");
            int curMonth = DateTime.Now.Month;
            //chart.Series[0].Points[0].Color = Color.Red;
            //chart.Char
            for (int i = 0; i < a.Length; i++)
            {
                //Series series = chart.Series.Add( DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName((12+curMonth - i)%12 + 1));
                Series series = chart.Series.Add(DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName((12 + curMonth - (a.Length - i - 1)) % 12) + " " + (int)a[i]);
                chart.Series[0].Points.AddXY(2*i,a[i]);
                if (12 + curMonth - (a.Length - i - 1) % 12 != 0)
                chart.Series[0].Points[i].Label = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName((12 + curMonth - (a.Length-i-1)) % 12);
                else chart.Series[0].Points[i].Label = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName((12 + curMonth - (a.Length - i - 1)) % 12);
            }
        }
    }
}
