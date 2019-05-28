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

        private Color m_lightUpColor = SystemColors.ControlDarkDark;

        #region メンバメソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            SetDate();
            tmrUpdateTime.Start();
        }

        /// <summary>
        /// 本日の日付をデジタル表示する
        /// </summary>
        private void SetDate()
        {
            degitalNumberDate.DisplayDate(DateTime.Now,m_lightUpColor);
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
            degitalNumberTime.DisplayTime(DateTime.Now,m_lightUpColor);

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("mm");
        }
    }
}
