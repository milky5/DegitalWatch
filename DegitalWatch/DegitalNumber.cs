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
        /// <summary>
        /// 0～9のパーツの組み合わせ方を保持する配列
        /// </summary>
        private NumberPattern[] numberPatterns;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DegitalNumber()
        {
            InitializeComponent();

            First();
        }

        /// <summary>
        /// 0～9のパーツの組み合わせ方を配列に代入する
        /// </summary>
        private void First()
        {
            var _lightOn = SystemColors.ControlDarkDark;
            var _lightOff = DefaultBackColor;

             numberPatterns = new NumberPattern[10]
            {
                new NumberPattern(_lightOn,_lightOn,_lightOn,_lightOff,_lightOn,_lightOn,_lightOn),
                new NumberPattern(_lightOff,_lightOff,_lightOn,_lightOff,_lightOff,_lightOn,_lightOff),
                new NumberPattern(_lightOn,_lightOff,_lightOn,_lightOn,_lightOn,_lightOff,_lightOn),
                new NumberPattern(_lightOn,_lightOff,_lightOn,_lightOn,_lightOff,_lightOn,_lightOn),
                new NumberPattern(_lightOff,_lightOn,_lightOn,_lightOn,_lightOff,_lightOn,_lightOff),
                new NumberPattern(_lightOn,_lightOn,_lightOff,_lightOn,_lightOff,_lightOn,_lightOn),
                new NumberPattern(_lightOn,_lightOn,_lightOff,_lightOn,_lightOn,_lightOn,_lightOn),
                new NumberPattern(_lightOn,_lightOn,_lightOn,_lightOff,_lightOff,_lightOn,_lightOff),
                new NumberPattern(_lightOn,_lightOn,_lightOn,_lightOn,_lightOn,_lightOn,_lightOn),
                new NumberPattern(_lightOn,_lightOn,_lightOn,_lightOn,_lightOff,_lightOn,_lightOn)
            };
        }

        /// <summary>
        /// 受け取った数字をデジタル表示する
        /// </summary>
        /// <param name="number"> デジタル表示したい数字 </param>
        public void Show(int number)
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
                    DisplayNumber(numberPatterns[number]);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 数字をデジタル表示する
        /// </summary>
        /// <param name="number"></param>
        private void DisplayNumber(NumberPattern number)
        {
            lblTopCenter.BackColor = number.TopCenter;
            lblTopLeft.BackColor = number.TopLeft;
            lblTopRight.BackColor =  number.TopRight;
            lblMiddleCenter.BackColor =  number.MiddleCenter;
            lblBottomRight.BackColor =  number.BottomRight;
            lblBottomLeft.BackColor =  number.BottomLeft;
            lblBottomCenter.BackColor =  number.BottomCenter;
        }

        private void DegitalNumber_Resize(object sender, EventArgs e)
        {
        }
    }

    /// <summary>
    /// デジタル数字表示の際の、光るパーツの組み合わせ
    /// </summary>
    public struct NumberPattern
    {
        public Color TopCenter;
        public Color TopLeft;
        public Color TopRight;
        public Color MiddleCenter;
        public Color BottomLeft;
        public Color BottomRight;
        public Color BottomCenter;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="TopCenter"> 最上部のパーツの色 </param>
        /// <param name="TopLeft"> 上部左側のパーツの色 </param>
        /// <param name="TopRight"> 上部右側のパーツの色 </param>
        /// <param name="MiddleCenter"> 中央部のパーツの色 </param>
        /// <param name="BottomLeft"> 下部左側のパーツの色 </param>
        /// <param name="BottomRight"> 下部右側のパーツの色 </param>
        /// <param name="BottomCenter"> 最下部のパーツの色 </param>
        public NumberPattern(Color TopCenter, Color TopLeft,Color TopRight,Color MiddleCenter,Color BottomLeft,Color BottomRight,Color BottomCenter)
        {
            this.TopCenter = TopCenter;
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.MiddleCenter = MiddleCenter;
            this.BottomLeft = BottomLeft;
            this.BottomRight = BottomRight;
            this.BottomCenter = BottomCenter;
        }
    }
}
