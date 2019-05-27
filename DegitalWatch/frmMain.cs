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

        private void SetDate()
        {
            var _now = DateTime.Now;
            var _list = new List<int>();
            _list = SeparateToFourNumber(_now.Year);
            _list.AddRange(SeparateToTwoNumber(_now.Month));
            _list.AddRange(SeparateToTwoNumber(_now.Day));

            degitalNumberMinics1.Show(_list[0]);
            degitalNumberMinics2.Show(_list[1]);
            degitalNumberMinics3.Show(_list[2]);
            degitalNumberMinics4.Show(_list[3]);
            degitalNumberMinics5.Show(_list[4]);
            degitalNumberMinics6.Show(_list[5]);
            degitalNumberMinics7.Show(_list[6]);
            degitalNumberMinics8.Show(_list[7]);
        }


        private void TimeUpdate()
        {
            var _now = DateTime.Now;
            var _list = new List<int>();
            _list = SeparateToTwoNumber(_now.Hour);
            _list.AddRange(SeparateToTwoNumber(_now.Minute));
            _list.AddRange(SeparateToTwoNumber(_now.Second));

            degitalNumber1.Show(_list[0]);
            degitalNumber2.Show(_list[1]);
            degitalNumber3.Show(_list[2]);
            degitalNumber4.Show(_list[3]);
            degitalNumber5.Show(_list[4]);
            degitalNumber6.Show(_list[5]);
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
        /// デバッグ用
        /// ボタンクリック時に呼ばれるメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDebug_Click(object sender, EventArgs e)
        {
            TimeUpdate();
        }

        /// <summary>
        /// 0.5秒ごとに呼ばれる
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
