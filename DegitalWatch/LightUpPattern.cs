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
    public class LightUpPattern
    {
        public static readonly LightUpPattern[] m_numberPatterns =
    {
                new LightUpPattern(true,true,true,
                                   false,true,true,true),
                new LightUpPattern(false,false,true,
                                   false,false,true,false),
                new LightUpPattern(true,false,true,
                                   true,true,false,true),
                new LightUpPattern(true,false,true,
                                   true,false,true,true),
                new LightUpPattern(false,true,true,
                                   true,false,true,false),
                new LightUpPattern(true,true,false,
                                   true,false,true,true),
                new LightUpPattern(true,true,false,
                                   true,true,true,true),
                new LightUpPattern(true,true,true,
                                   false,false,true,false),
                new LightUpPattern(true,true,true,
                                   true,true,true,true),
                new LightUpPattern(true,true,true,
                                   true,false,true,true)
    };



        #region メンバメソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="lightUpColor"> 光らせる場合の色 </param>
        /// <param name="TopCenter"> 最上部を光らせるか </param>
        /// <param name="TopLeft"> 上部左側を光らせるか </param>
        /// <param name="TopRight"> 上部右側を光らせるか </param>
        /// <param name="MiddleCenter"> 中央部を光らせるか </param>
        /// <param name="BottomLeft"> 下部左側を光らせるか </param>
        /// <param name="BottomRight"> 下部右側を光らせるか </param>
        /// <param name="BottomCenter"> 最下部を光らせるか </param>
        public LightUpPattern(bool TopCenter, bool TopLeft,
                              bool TopRight, bool MiddleCenter, bool BottomLeft, 
                              bool BottomRight, bool BottomCenter)
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

        #region プロパティ
        /// <summary>
        /// 最上部を光らせるか
        /// </summary>
        public bool TopCenter { get; private set; }
        /// <summary>
        /// 上部左側を光らせるか
        /// </summary>
        public bool TopLeft { get; private set; }
        /// <summary>
        /// 上部右側を光らせるか
        /// </summary>
        public bool TopRight { get; private set; }
        /// <summary>
        /// 中央部を光らせるか
        /// </summary>
        public bool MiddleCenter { get; private set; }
        /// <summary>
        /// 下部左側を光らせるか
        /// </summary>
        public bool BottomLeft { get; private set; }
        /// <summary>
        /// 下部右側を光らせるか
        /// </summary>
        public bool BottomRight { get; private set; }
        /// <summary>
        /// 最下部を光らせるか
        /// </summary>
        public bool BottomCenter { get; private set; }
        #endregion

    }
}
