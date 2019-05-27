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
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            SetDate();
            timer1.Start();
        }

        /// <summary>
        /// 本日の日付をデジタル表示する
        /// </summary>
        private void SetDate()
        {
            var _now = DateTime.Now;
            var _list = new List<int>();
            _list = SeparateToFourNumber(_now.Year);
            _list.AddRange(SeparateToTwoNumber(_now.Month));
            _list.AddRange(SeparateToTwoNumber(_now.Day));

            degitalNumber7.ShowNumber(_list[0]);
            degitalNumber8.ShowNumber(_list[1]);
            degitalNumber9.ShowNumber(_list[2]);
            degitalNumber10.ShowNumber(_list[3]);
            degitalNumber11.ShowNumber(_list[4]);
            degitalNumber12.ShowNumber(_list[5]);
            degitalNumber13.ShowNumber(_list[6]);
            degitalNumber14.ShowNumber(_list[7]);
        }

        /// <summary>
        /// 現在の時刻をデジタル表示する
        /// </summary>
        private void TimeUpdate()
        {
            var _now = DateTime.Now;
            var _list = new List<int>();
            _list = SeparateToTwoNumber(_now.Hour);
            _list.AddRange(SeparateToTwoNumber(_now.Minute));
            _list.AddRange(SeparateToTwoNumber(_now.Second));

            degitalNumber1.ShowNumber(_list[0]);
            degitalNumber2.ShowNumber(_list[1]);
            degitalNumber3.ShowNumber(_list[2]);
            degitalNumber4.ShowNumber(_list[3]);
            degitalNumber5.ShowNumber(_list[4]);
            degitalNumber6.ShowNumber(_list[5]);
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
        /// TimerのIntervalごとに呼ばれる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            degitalColon1.SwitchOnOff();
            degitalColon2.SwitchOnOff();

            TimeUpdate();
        }
    }
}
