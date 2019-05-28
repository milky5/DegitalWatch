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
    /// <summary>
    /// Mainフォーム
    /// </summary>
    public partial class frmMain : Form
    {
        #region メソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            LightUpColor = SystemColors.ControlDarkDark;
            //LightUpColor = Color.Orange;

            SetDate();
            tmrUpdateTime.Start();
        }

        /// <summary>
        /// 本日の日付をデジタル表示する
        /// </summary>
        private void SetDate()
        {
            degitalNumberDate.DisplayDate(DateTime.Now,LightUpColor);
        }

        /// <summary>
        /// TimerのIntervalごとに呼ばれる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrUpdateTime_Tick(object sender, EventArgs e)
        {
            degitalNumberTime.SwitchOnOff();

            UpdateTime();
        }

        /// <summary>
        /// 現在の時刻をデジタル表示する
        /// </summary>
        private void UpdateTime()
        {
            degitalNumberTime.DisplayTime(DateTime.Now,LightUpColor);
        }

        #endregion

        #region プロパティ
        public Color LightUpColor { get; set; }
        #endregion
    }
}
