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
            degitalNumberDate.ShowNumber(DateTime.Now);

            //dnmYear1000.ShowNumber(_numberList[0]);
            //dnmYear100.ShowNumber(_numberList[1]);
            //dnmYear10.ShowNumber(_numberList[2]);
            //dnmYear1.ShowNumber(_numberList[3]);
            //dnmMonth10.ShowNumber(_numberList[4]);
            //dnmMonth1.ShowNumber(_numberList[5]);
            //dnmDay10.ShowNumber(_numberList[6]);
            //dnmDay1.ShowNumber(_numberList[7]);
        }

        /// <summary>
        /// TimerのIntervalごとに呼ばれる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrUpdateTime_Tick(object sender, EventArgs e)
        {
            //dclHourAndMin.SwitchOnOff();
            //dclMinAndSec.SwitchOnOff();

            UpdateTime();
        }

        /// <summary>
        /// 現在の時刻をデジタル表示する
        /// </summary>
        private void UpdateTime()
        {
            degitalNumberTime.ShowNumber(DateTime.Now);

            //dnmHour10.ShowNumber(_numberList[0]);
            //dnmHour1.ShowNumber(_numberList[1]);
            //dnmMin10.ShowNumber(_numberList[2]);
            //dnmMin1.ShowNumber(_numberList[3]);
            //dnmSec10.ShowNumber(_numberList[4]);
            //dnmSec1.ShowNumber(_numberList[5]);
        }

        #endregion

    }
}
