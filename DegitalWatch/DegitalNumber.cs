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
    /// ユーザコントロール。1つの文字を表示する
    /// </summary>
    public partial class DegitalNumber : UserControl
    {

        #region メソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DegitalNumber()
        {
            InitializeComponent();
        }

        /// <summary>
        /// サイズを最適化する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DegitalNumber_Resize(object sender, EventArgs e)
        {
            // ラベルの初期サイズ 5 * 40
            // コントロールの幅は 5 + 40 + 5、比率なら 1:8:1  = 10
            var _oneUnit = Width / 10;

            lblTopCenter.Location = new Point(_oneUnit, 0);
            lblTopLeft.Location = new Point(0, _oneUnit);
            lblTopRight.Location = new Point(9 * _oneUnit, _oneUnit);
            lblMiddleCenter.Location = new Point(_oneUnit, 9 * _oneUnit);
            lblBottomLeft.Location = new Point(0, 10 * _oneUnit);
            lblBottomRight.Location = new Point(9 * _oneUnit, 10 * _oneUnit);
            lblBottomCenter.Location = new Point(_oneUnit, 18 * _oneUnit);

            lblTopCenter.Size = new Size(_oneUnit * 8, _oneUnit);
            lblTopLeft.Size = new Size(_oneUnit, _oneUnit * 8);
            lblTopRight.Size = new Size(_oneUnit, _oneUnit * 8);
            lblMiddleCenter.Size = new Size(_oneUnit * 8, _oneUnit);
            lblBottomLeft.Size = new Size(_oneUnit, _oneUnit * 8);
            lblBottomRight.Size = new Size(_oneUnit, _oneUnit * 8);
            lblBottomCenter.Size = new Size(_oneUnit * 8, _oneUnit);
        }

        /// <summary>
        /// 数字をデジタル表示する
        /// </summary>
        /// <param name="number"> デジタル表示したい数字 </param>
        /// <param name="color"> 光らせる際の色 </param>
        public void DisplayNumber(int number, Color color)
        {
            if (0 <= number && number <= 9)
            {
                DisplayPattern(LightUpPattern.g_numberPatterns[number], color);
            }
            else
            {
                throw new Exception("0～9以外の数字が入力されています");
            }
        }

        /// <summary>
        /// 数字をデジタル表示する
        /// </summary>
        /// <param name="number"> デジタル表示したい数字 </param>
        /// <param name="color"> 光らせる際の色 </param>
        public void DisplayNumber(string number, Color color)
        {
            int _convertedNumber;
            var _result = int.TryParse(number, out _convertedNumber);
            if (_result)
            {
                DisplayNumber(_convertedNumber, color);
            }
            else
            {
                throw new Exception("数字と認識できませんでした");
            }
        }

        /// <summary>
        /// パターンをデジタル表示する
        /// </summary>
        /// <param name="pattern"> 光るパーツの組み合わせ </param>
        /// <param name="color"> 光らせる際の色 </param>
        public void DisplayPattern(LightUpPattern pattern, Color color)
        {
            var _lightDownColor = DefaultBackColor;

            lblTopCenter.BackColor = JudgeColor(pattern.TopCenter, color, _lightDownColor);
            lblTopLeft.BackColor = JudgeColor(pattern.TopLeft, color, _lightDownColor);
            lblTopRight.BackColor = JudgeColor(pattern.TopRight, color, _lightDownColor);
            lblMiddleCenter.BackColor = JudgeColor(pattern.MiddleCenter, color, _lightDownColor);
            lblBottomRight.BackColor = JudgeColor(pattern.BottomRight, color, _lightDownColor);
            lblBottomLeft.BackColor = JudgeColor(pattern.BottomLeft, color, _lightDownColor);
            lblBottomCenter.BackColor = JudgeColor(pattern.BottomCenter, color, _lightDownColor);
        }

        /// <summary>
        /// boolを判定し、colorを返す
        /// </summary>
        /// <param name="lightOn"> 光らせるかどうか </param>
        /// <param name="lightUp"> 光る場合の色 </param>
        /// <param name="lightDown"> 光らない場合の色 </param>
        /// <returns> 判定結果の色 </returns>
        private Color JudgeColor(bool lightOn, Color lightUp, Color lightDown)
        {
            if (lightOn)
            {
                return lightUp;
            }
            return lightDown;
        }
        #endregion


    }
}
