﻿using System;
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
        #region メンバ変数
        /// <summary>
        /// コロンが点灯中か
        /// </summary>
        private bool m_isLightUp;
        #endregion

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
            if (m_isLightUp)
            {
                lblTopPeriod.BackColor = SystemColors.ControlDarkDark;
                lblBottomPeriod.BackColor = SystemColors.ControlDarkDark;
            }
            else
            {
                lblTopPeriod.BackColor = DefaultBackColor;
                lblBottomPeriod.BackColor = DefaultBackColor;
            }

            m_isLightUp = !m_isLightUp;
        }
        #endregion
    }
}
