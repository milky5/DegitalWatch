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
        #endregion






        #region メンバメソッド

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
        public void DisplayNumber(LightUpPattern number,Color color)
        {
            if (number.TopCenter)
            {
                lblTopCenter.BackColor = color;
            }
            else
            {
                lblTopCenter.BackColor = DefaultBackColor;
            }

            if (number.TopLeft)
            {
                lblTopLeft.BackColor = color;
            }
            else
            {
                lblTopLeft.BackColor = DefaultBackColor;
            }

            if (number.TopRight)
            {
                lblTopRight.BackColor = color;
            }
            else
            {
                lblTopRight.BackColor = DefaultBackColor;
            }

            if (number.MiddleCenter)
            {
                lblMiddleCenter.BackColor = color;
            }
            else
            {
                lblMiddleCenter.BackColor = DefaultBackColor;
            }

            if (number.BottomRight)
            {
                lblBottomRight.BackColor = color;
            }
            else
            {
                lblBottomRight.BackColor = DefaultBackColor;
            }

            if (number.BottomLeft)
            {
                lblBottomLeft.BackColor = color;
            }
            else
            {
                lblBottomLeft.BackColor = DefaultBackColor;
            }

            if (number.BottomCenter)
            {
                lblBottomCenter.BackColor = color;
            }
            else
            {
                lblBottomCenter.BackColor = DefaultBackColor;
            }
            
            
        }

        public Color ConvertBoolToColor(LightUpPattern number,Color color)
        {
            return color;
        }

        public void DisplayNumber(int number,Color color)
        {
            if (0 <= number && number <= 9)
            {
                DisplayNumber(LightUpPattern.m_numberPatterns[number], color);
            }
        }

        public void DisplayNumber(string number,Color color)
        {
            var _convertedNumber = 10;
            var _result = int.TryParse(number, out _convertedNumber);
            if (_result)
            {
                DisplayNumber(_convertedNumber, color);
            }
        }
        #endregion


    }
}
