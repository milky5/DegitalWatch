using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DegitalWatch
{
    /// <summary>
    /// デジタル表示の際の、光るパーツの組み合わせ
    /// </summary>
    public struct LightUpPattern
    {
        #region メンバ変数
        public Color TopCenter;
        public Color TopLeft;
        public Color TopRight;
        public Color MiddleCenter;
        public Color BottomLeft;
        public Color BottomRight;
        public Color BottomCenter;
        #endregion

        #region メンバメソッド
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
        public LightUpPattern(Color TopCenter, Color TopLeft, Color TopRight, 
                              Color MiddleCenter, Color BottomLeft, 
                              Color BottomRight, Color BottomCenter)
        {
            this.TopCenter = TopCenter;
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.MiddleCenter = MiddleCenter;
            this.BottomLeft = BottomLeft;
            this.BottomRight = BottomRight;
            this.BottomCenter = BottomCenter;
        }
        #endregion
    }
}
