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
    public partial class DegitalNumberTime : UserControl
    {
        public DegitalNumberTime()
        {
            InitializeComponent();
        }

        public void DisplayTime(DateTime time,Color color)
        {
            dnmHour10.DisplayNumber(time.Hour % 100,color);
            dnmHour1.DisplayNumber(time.Hour % 10, color);
            dnmMin10.DisplayNumber(time.Minute % 100, color);
            dnmMin1.DisplayNumber(time.Minute % 10, color);
            dnmSec10.DisplayNumber(time.Second % 100, color);
            dnmSec1.DisplayNumber(time.Second % 10, color);
        }
        public void DisplayTime(string time, Color color)
        {
            DateTime _time;
            var _result = DateTime.TryParse(time, out _time);
            if (_result)
            {
                DisplayTime(_time, color);
            }
        }

        public void SwitchOnOff()
        {
            dclHourAndMin.SwitchOnOff();
            dclMinAndSec.SwitchOnOff();
        }

    }
}
