using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegitalWatch
{
    public partial class DegitalNumberDate : UserControl
    {
        public DegitalNumberDate()
        {
            InitializeComponent();
        }

        public void DisplayDate(DateTime date, Color color)
        {
            dnmYear1000.DisplayNumber(date.Year % 10000, color);
            dnmYear100.DisplayNumber(date.Year % 1000, color);
            dnmYear10.DisplayNumber(date.Year % 100, color);
            dnmYear1.DisplayNumber(date.Year % 10, color);
            dnmMonth10.DisplayNumber(date.Month % 100, color);
            dnmMonth1.DisplayNumber(date.Month % 10, color);
            dnmDay10.DisplayNumber(date.Day % 100, color);
            dnmDay1.DisplayNumber(date.Day % 10, color);
        }
        public void DisplayDate(string date,Color color)
        {
            DateTime _date;
            var _result = DateTime.TryParse(date,out _date);
            if (_result)
            {
                DisplayDate(_date,color);
            }
        }
    }
}
