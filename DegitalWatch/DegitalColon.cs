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
    public partial class DegitalColon : UserControl
    {
        #region メンバメソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DegitalColon()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コロンの点灯・消灯を切り替えるメソッド
        /// </summary>
        public void SwitchOnOff()
        {
            if (IsLightUp)
            {
                lblTopPeriod.BackColor = LightUpColor;
                lblBottomPeriod.BackColor = LightUpColor;
            }
            else
            {
                lblTopPeriod.BackColor = DefaultBackColor;
                lblBottomPeriod.BackColor = DefaultBackColor;
            }

            IsLightUp = !IsLightUp;
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// コロンが点灯中か
        /// </summary>
        private bool IsLightUp { get; set; }
        /// <summary>
        /// 点灯時の色
        /// </summary>
        public Color LightUpColor { get; set; }
        #endregion
    }
}
