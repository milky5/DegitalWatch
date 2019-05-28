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
    /// ユーザコントロール。yyyyMMddの形式でデジタル表示する。
    /// </summary>
    public partial class DegitalNumberDate : UserControl
    {

        #region メソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DegitalNumberDate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 日付をデジタル表示する
        /// </summary>
        /// <param name="date"> 日付 </param>
        /// <param name="color"> 光らせる際の色 </param>
        public void DisplayDate(DateTime date, Color color)
        {
            var _separatedNumber = SeparateToDateStr(date);

            dnmYear1000.DisplayNumber(_separatedNumber[0], color);
            dnmYear100.DisplayNumber(_separatedNumber[1], color);
            dnmYear10.DisplayNumber(_separatedNumber[2], color);
            dnmYear1.DisplayNumber(_separatedNumber[3], color);
            dnmMonth10.DisplayNumber(_separatedNumber[4], color);
            dnmMonth1.DisplayNumber(_separatedNumber[5], color);
            dnmDay10.DisplayNumber(_separatedNumber[6], color);
            dnmDay1.DisplayNumber(_separatedNumber[7], color);
        }

        /// <summary>
        /// 日付をデジタル表示する
        /// </summary>
        /// <param name="date"> DateTime型に変換できる日付 </param>
        /// <param name="color"> 光らせる際の色 </param>
        public void DisplayDate(string date,Color color)
        {
            DateTime _date;
            var _result = DateTime.TryParse(date,out _date);
            if (_result)
            {
                DisplayDate(_date,color);
            }
        }

        /// <summary>
        /// DateTime型の日付部分を1桁ずつに分ける
        /// </summary>
        /// <param name="date"> 日付データ </param>
        /// <returns> 1桁ずつ格納された string型リスト </returns>
        private List<string> SeparateToDateStr(DateTime date)
        {
            var _datetimeStr = date.ToString("yyyyMMdd");
            var _charStr = _datetimeStr.ToCharArray();
            var _returnList = new List<string>();
            foreach (var cs in _charStr)
            {
                _returnList.Add(cs.ToString());
            }
            return _returnList;
        }

        #endregion
    }
}
