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
    public partial class DegitalNumber : UserControl
    {
        #region メンバ変数
        /// <summary>
        /// 0～9の数字表示のパーツの組み合わせ方を保持
        /// </summary>
        private LightUpPattern[] m_numberPatterns;
        #endregion

        #region メンバメソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DegitalNumber()
        {
            InitializeComponent();

            First();
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
        private void DisplayNumber(LightUpPattern number)
        {
            lblTopCenter.BackColor = number.TopCenter;
            lblTopLeft.BackColor = number.TopLeft;
            lblTopRight.BackColor = number.TopRight;
            lblMiddleCenter.BackColor = number.MiddleCenter;
            lblBottomRight.BackColor = number.BottomRight;
            lblBottomLeft.BackColor = number.BottomLeft;
            lblBottomCenter.BackColor = number.BottomCenter;
        }

        /// <summary>
        /// 0～9のパーツの組み合わせ方を配列に代入する
        /// </summary>
        private void First()
        {
            var _lightOn = SystemColors.ControlDarkDark;
            var _lightOff = DefaultBackColor;

             m_numberPatterns = new LightUpPattern[10]
            {
                new LightUpPattern(_lightOn,_lightOn,_lightOn,_lightOff,_lightOn,_lightOn,_lightOn),
                new LightUpPattern(_lightOff,_lightOff,_lightOn,_lightOff,_lightOff,_lightOn,_lightOff),
                new LightUpPattern(_lightOn,_lightOff,_lightOn,_lightOn,_lightOn,_lightOff,_lightOn),
                new LightUpPattern(_lightOn,_lightOff,_lightOn,_lightOn,_lightOff,_lightOn,_lightOn),
                new LightUpPattern(_lightOff,_lightOn,_lightOn,_lightOn,_lightOff,_lightOn,_lightOff),
                new LightUpPattern(_lightOn,_lightOn,_lightOff,_lightOn,_lightOff,_lightOn,_lightOn),
                new LightUpPattern(_lightOn,_lightOn,_lightOff,_lightOn,_lightOn,_lightOn,_lightOn),
                new LightUpPattern(_lightOn,_lightOn,_lightOn,_lightOff,_lightOff,_lightOn,_lightOff),
                new LightUpPattern(_lightOn,_lightOn,_lightOn,_lightOn,_lightOn,_lightOn,_lightOn),
                new LightUpPattern(_lightOn,_lightOn,_lightOn,_lightOn,_lightOff,_lightOn,_lightOn)
            };
        }

        /// <summary>
        /// 受け取った数字をデジタル表示する
        /// </summary>
        /// <param name="number"> デジタル表示したい数字 </param>
        public void ShowNumber(int number)
        {
            switch (number)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    DisplayNumber(m_numberPatterns[number]);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
