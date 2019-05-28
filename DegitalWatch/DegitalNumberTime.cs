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
    /// <summary>
    /// ユーザコントロール。hh:mm:ssの形式でデジタル表示する
    /// </summary>
    public partial class DegitalNumberTime : UserControl
    {
        #region メソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DegitalNumberTime()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 時間をデジタル表示する
        /// </summary>
        /// <param name="time"> 時間 </param>
        /// <param name="color"> 光らせる際の色 </param>
        public void DisplayTime(DateTime time,Color color)
        {
            var _separatedNumber = SeparateToTimeStr(time);

            dnmHour10.DisplayNumber(_separatedNumber[0], color);
            dnmHour1.DisplayNumber(_separatedNumber[1], color);
            dnmMin10.DisplayNumber(_separatedNumber[2], color);
            dnmMin1.DisplayNumber(_separatedNumber[3], color);
            dnmSec10.DisplayNumber(_separatedNumber[4], color);
            dnmSec1.DisplayNumber(_separatedNumber[5], color);

            dclHourAndMin.LightUpColor = color;
            dclMinAndSec.LightUpColor = color;
        }

        /// <summary>
        /// 時間をデジタル表示する
        /// </summary>
        /// <param name="time"> DateTime型に変換できる時間 </param>
        /// <param name="color"> 光らせる際の色 </param>
        public void DisplayTime(string time, Color color)
        {
            DateTime _time;
            var _result = DateTime.TryParse(time, out _time);
            if (_result)
            {
                DisplayTime(_time, color);
            }
            else
            {
                throw new Exception("DateTime型に変換できませんでした");
            }
        }

        /// <summary>
        /// DateTime型の時間部分を1桁ずつに分ける
        /// </summary>
        /// <param name="time"> 時間データ </param>
        /// <returns> 1桁ずつ格納された string型リスト </returns>
        private List<string> SeparateToTimeStr(DateTime time)
        {
            var _datetimeStr = time.ToString("HHmmss");
            var _charStr = _datetimeStr.ToCharArray();
            var _returnList = new List<string>();
            foreach (var cs in _charStr)
            {
                _returnList.Add(cs.ToString());
            }
            return _returnList;
        }

        /// <summary>
        /// コロン2つの点灯・消灯を切り替える
        /// </summary>
        public void SwitchOnOff()
        {
            dclHourAndMin.SwitchOnOff();
            dclMinAndSec.SwitchOnOff();
        }
        #endregion
    }
}
