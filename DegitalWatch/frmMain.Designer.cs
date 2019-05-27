namespace DegitalWatch
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrUpdateTime = new System.Windows.Forms.Timer(this.components);
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.dnmDay1 = new DegitalWatch.DegitalNumber();
            this.dnmDay10 = new DegitalWatch.DegitalNumber();
            this.dnmMonth1 = new DegitalWatch.DegitalNumber();
            this.dnmMonth10 = new DegitalWatch.DegitalNumber();
            this.dnmYear1 = new DegitalWatch.DegitalNumber();
            this.dnmYear10 = new DegitalWatch.DegitalNumber();
            this.dnmYear100 = new DegitalWatch.DegitalNumber();
            this.dnmYear1000 = new DegitalWatch.DegitalNumber();
            this.dclMinAndSec = new DegitalWatch.DegitalColon();
            this.dclHourAndMin = new DegitalWatch.DegitalColon();
            this.dnmSec1 = new DegitalWatch.DegitalNumber();
            this.dnmSec10 = new DegitalWatch.DegitalNumber();
            this.dnmMin1 = new DegitalWatch.DegitalNumber();
            this.dnmMin10 = new DegitalWatch.DegitalNumber();
            this.dnmHour1 = new DegitalWatch.DegitalNumber();
            this.dnmHour10 = new DegitalWatch.DegitalNumber();
            this.SuspendLayout();
            // 
            // tmrUpdateTime
            // 
            this.tmrUpdateTime.Interval = 500;
            this.tmrUpdateTime.Tick += new System.EventHandler(this.tmrUpdateTime_Tick);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblYear.Location = new System.Drawing.Point(196, 71);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(24, 16);
            this.lblYear.TabIndex = 18;
            this.lblYear.Text = "年";
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMonth.Location = new System.Drawing.Point(306, 71);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(24, 16);
            this.lblMonth.TabIndex = 19;
            this.lblMonth.Text = "月";
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDay.Location = new System.Drawing.Point(421, 71);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(24, 16);
            this.lblDay.TabIndex = 20;
            this.lblDay.Text = "日";
            // 
            // dnmDay1
            // 
            this.dnmDay1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dnmDay1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmDay1.Location = new System.Drawing.Point(374, 12);
            this.dnmDay1.Name = "dnmDay1";
            this.dnmDay1.Size = new System.Drawing.Size(41, 75);
            this.dnmDay1.TabIndex = 28;
            // 
            // dnmDay10
            // 
            this.dnmDay10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dnmDay10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmDay10.Location = new System.Drawing.Point(329, 12);
            this.dnmDay10.Name = "dnmDay10";
            this.dnmDay10.Size = new System.Drawing.Size(41, 75);
            this.dnmDay10.TabIndex = 27;
            // 
            // dnmMonth1
            // 
            this.dnmMonth1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dnmMonth1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmMonth1.Location = new System.Drawing.Point(263, 12);
            this.dnmMonth1.Name = "dnmMonth1";
            this.dnmMonth1.Size = new System.Drawing.Size(41, 75);
            this.dnmMonth1.TabIndex = 26;
            // 
            // dnmMonth10
            // 
            this.dnmMonth10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dnmMonth10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmMonth10.Location = new System.Drawing.Point(216, 12);
            this.dnmMonth10.Name = "dnmMonth10";
            this.dnmMonth10.Size = new System.Drawing.Size(41, 75);
            this.dnmMonth10.TabIndex = 25;
            // 
            // dnmYear1
            // 
            this.dnmYear1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmYear1.Location = new System.Drawing.Point(156, 12);
            this.dnmYear1.Name = "dnmYear1";
            this.dnmYear1.Size = new System.Drawing.Size(41, 75);
            this.dnmYear1.TabIndex = 24;
            // 
            // dnmYear10
            // 
            this.dnmYear10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmYear10.Location = new System.Drawing.Point(109, 12);
            this.dnmYear10.Name = "dnmYear10";
            this.dnmYear10.Size = new System.Drawing.Size(41, 75);
            this.dnmYear10.TabIndex = 23;
            // 
            // dnmYear100
            // 
            this.dnmYear100.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmYear100.Location = new System.Drawing.Point(62, 12);
            this.dnmYear100.Name = "dnmYear100";
            this.dnmYear100.Size = new System.Drawing.Size(41, 75);
            this.dnmYear100.TabIndex = 22;
            // 
            // dnmYear1000
            // 
            this.dnmYear1000.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmYear1000.Location = new System.Drawing.Point(13, 12);
            this.dnmYear1000.Name = "dnmYear1000";
            this.dnmYear1000.Size = new System.Drawing.Size(41, 75);
            this.dnmYear1000.TabIndex = 21;
            // 
            // dclMinAndSec
            // 
            this.dclMinAndSec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dclMinAndSec.Location = new System.Drawing.Point(282, 116);
            this.dclMinAndSec.Name = "dclMinAndSec";
            this.dclMinAndSec.Size = new System.Drawing.Size(30, 96);
            this.dclMinAndSec.TabIndex = 7;
            // 
            // dclHourAndMin
            // 
            this.dclHourAndMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dclHourAndMin.Location = new System.Drawing.Point(132, 116);
            this.dclHourAndMin.Name = "dclHourAndMin";
            this.dclHourAndMin.Size = new System.Drawing.Size(30, 96);
            this.dclHourAndMin.TabIndex = 6;
            // 
            // dnmSec1
            // 
            this.dnmSec1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dnmSec1.AutoSize = true;
            this.dnmSec1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmSec1.Location = new System.Drawing.Point(374, 116);
            this.dnmSec1.Name = "dnmSec1";
            this.dnmSec1.Size = new System.Drawing.Size(53, 95);
            this.dnmSec1.TabIndex = 5;
            // 
            // dnmSec10
            // 
            this.dnmSec10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dnmSec10.AutoSize = true;
            this.dnmSec10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmSec10.Location = new System.Drawing.Point(317, 116);
            this.dnmSec10.Name = "dnmSec10";
            this.dnmSec10.Size = new System.Drawing.Size(53, 95);
            this.dnmSec10.TabIndex = 4;
            // 
            // dnmMin1
            // 
            this.dnmMin1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dnmMin1.AutoSize = true;
            this.dnmMin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmMin1.Location = new System.Drawing.Point(225, 116);
            this.dnmMin1.Name = "dnmMin1";
            this.dnmMin1.Size = new System.Drawing.Size(53, 95);
            this.dnmMin1.TabIndex = 3;
            // 
            // dnmMin10
            // 
            this.dnmMin10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dnmMin10.AutoSize = true;
            this.dnmMin10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmMin10.Location = new System.Drawing.Point(168, 116);
            this.dnmMin10.Name = "dnmMin10";
            this.dnmMin10.Size = new System.Drawing.Size(53, 95);
            this.dnmMin10.TabIndex = 2;
            // 
            // dnmHour1
            // 
            this.dnmHour1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dnmHour1.AutoSize = true;
            this.dnmHour1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmHour1.Location = new System.Drawing.Point(70, 116);
            this.dnmHour1.Name = "dnmHour1";
            this.dnmHour1.Size = new System.Drawing.Size(53, 95);
            this.dnmHour1.TabIndex = 1;
            // 
            // dnmHour10
            // 
            this.dnmHour10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dnmHour10.AutoSize = true;
            this.dnmHour10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmHour10.Location = new System.Drawing.Point(13, 116);
            this.dnmHour10.Name = "dnmHour10";
            this.dnmHour10.Size = new System.Drawing.Size(53, 95);
            this.dnmHour10.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 225);
            this.Controls.Add(this.dnmDay1);
            this.Controls.Add(this.dnmDay10);
            this.Controls.Add(this.dnmMonth1);
            this.Controls.Add(this.dnmMonth10);
            this.Controls.Add(this.dnmYear1);
            this.Controls.Add(this.dnmYear10);
            this.Controls.Add(this.dnmYear100);
            this.Controls.Add(this.dnmYear1000);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.dclMinAndSec);
            this.Controls.Add(this.dclHourAndMin);
            this.Controls.Add(this.dnmSec1);
            this.Controls.Add(this.dnmSec10);
            this.Controls.Add(this.dnmMin1);
            this.Controls.Add(this.dnmMin10);
            this.Controls.Add(this.dnmHour1);
            this.Controls.Add(this.dnmHour10);
            this.Name = "frmMain";
            this.Text = "デジタル時計";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DegitalNumber dnmHour10;
        private DegitalNumber dnmHour1;
        private DegitalNumber dnmMin10;
        private DegitalNumber dnmMin1;
        private DegitalNumber dnmSec10;
        private DegitalNumber dnmSec1;
        private DegitalColon dclHourAndMin;
        private DegitalColon dclMinAndSec;
        private System.Windows.Forms.Timer tmrUpdateTime;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private DegitalNumber dnmYear1000;
        private DegitalNumber dnmYear100;
        private DegitalNumber dnmYear10;
        private DegitalNumber dnmYear1;
        private DegitalNumber dnmMonth10;
        private DegitalNumber dnmMonth1;
        private DegitalNumber dnmDay10;
        private DegitalNumber dnmDay1;
    }
}

