using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegitalWatch
{
    public partial class frmMain : Form
    {

        #region メンバメソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            MinimumSize = new Size(Width, Height);
            SetDate();
            tmrUpdateTime.Start();
        }

        /// <summary>
        /// 4桁の数字をそれぞれの位に分ける
        /// </summary>
        /// <param name="number"> 4桁の数字 </param>
        /// <returns> 位毎の数字が格納されたリスト </returns>
        private List<int> SeparateToFourNumber(int number)
        {
            var _charNumbers = number.ToString().ToCharArray();
            var _numbers = new List<int>();
            foreach (var n in _charNumbers)
            {
                _numbers.Add(int.Parse(n.ToString()));
            }

            return _numbers;
        }

        /// <summary>
        /// 2桁の数字を10の位と1の位に分ける
        /// </summary>
        /// <param name="number"> 2桁の数字 </param>
        /// <returns> 10の位と1の位がそれぞれ格納されたリスト </returns>
        private List<int> SeparateToTwoNumber(int number)
        {
            var _numbers = new List<int>();
            var _digit10 = number / 10;
            _numbers.Add(_digit10);
            _numbers.Add(number - (_digit10 * 10));
            return _numbers;
        }

        /// <summary>
        /// 本日の日付をデジタル表示する
        /// </summary>
        private void SetDate()
        {
            var _nowDate = DateTime.Now;
            var _numberList = new List<int>();
            _numberList = SeparateToFourNumber(_nowDate.Year);
            _numberList.AddRange(SeparateToTwoNumber(_nowDate.Month));
            _numberList.AddRange(SeparateToTwoNumber(_nowDate.Day));

            dnmYear1000.ShowNumber(_numberList[0]);
            dnmYear100.ShowNumber(_numberList[1]);
            dnmYear10.ShowNumber(_numberList[2]);
            dnmYear1.ShowNumber(_numberList[3]);
            dnmMonth10.ShowNumber(_numberList[4]);
            dnmMonth1.ShowNumber(_numberList[5]);
            dnmDay10.ShowNumber(_numberList[6]);
            dnmDay1.ShowNumber(_numberList[7]);
        }

        /// <summary>
        /// TimerのIntervalごとに呼ばれる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrUpdateTime_Tick(object sender, EventArgs e)
        {
            dclHourAndMin.SwitchOnOff();
            dclMinAndSec.SwitchOnOff();

            UpdateTime();
        }

        /// <summary>
        /// 現在の時刻をデジタル表示する
        /// </summary>
        private void UpdateTime()
        {
            var _nowTime = DateTime.Now;
            var _numberList = new List<int>();
            _numberList = SeparateToTwoNumber(_nowTime.Hour);
            _numberList.AddRange(SeparateToTwoNumber(_nowTime.Minute));
            _numberList.AddRange(SeparateToTwoNumber(_nowTime.Second));

            dnmHour10.ShowNumber(_numberList[0]);
            dnmHour1.ShowNumber(_numberList[1]);
            dnmMin10.ShowNumber(_numberList[2]);
            dnmMin1.ShowNumber(_numberList[3]);
            dnmSec10.ShowNumber(_numberList[4]);
            dnmSec1.ShowNumber(_numberList[5]);
        }

        #endregion


    }
}
