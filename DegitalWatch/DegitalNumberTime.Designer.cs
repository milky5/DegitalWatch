namespace DegitalWatch
{
    partial class DegitalNumberTime
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dnmHour10 = new DegitalWatch.DegitalNumber();
            this.dnmHour1 = new DegitalWatch.DegitalNumber();
            this.dnmMin10 = new DegitalWatch.DegitalNumber();
            this.dnmMin1 = new DegitalWatch.DegitalNumber();
            this.dnmSec10 = new DegitalWatch.DegitalNumber();
            this.dnmSec1 = new DegitalWatch.DegitalNumber();
            this.dclHourAndMin = new DegitalWatch.DegitalColon();
            this.dclMinAndSec = new DegitalWatch.DegitalColon();
            this.SuspendLayout();
            // 
            // dnmHour10
            // 
            this.dnmHour10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmHour10.Location = new System.Drawing.Point(3, 3);
            this.dnmHour10.Name = "dnmHour10";
            this.dnmHour10.Size = new System.Drawing.Size(50, 95);
            this.dnmHour10.TabIndex = 0;
            // 
            // dnmHour1
            // 
            this.dnmHour1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmHour1.Location = new System.Drawing.Point(59, 3);
            this.dnmHour1.Name = "dnmHour1";
            this.dnmHour1.Size = new System.Drawing.Size(50, 95);
            this.dnmHour1.TabIndex = 1;
            // 
            // dnmMin10
            // 
            this.dnmMin10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmMin10.Location = new System.Drawing.Point(151, 3);
            this.dnmMin10.Name = "dnmMin10";
            this.dnmMin10.Size = new System.Drawing.Size(50, 95);
            this.dnmMin10.TabIndex = 2;
            // 
            // dnmMin1
            // 
            this.dnmMin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmMin1.Location = new System.Drawing.Point(207, 3);
            this.dnmMin1.Name = "dnmMin1";
            this.dnmMin1.Size = new System.Drawing.Size(50, 95);
            this.dnmMin1.TabIndex = 3;
            // 
            // dnmSec10
            // 
            this.dnmSec10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmSec10.Location = new System.Drawing.Point(299, 4);
            this.dnmSec10.Name = "dnmSec10";
            this.dnmSec10.Size = new System.Drawing.Size(50, 95);
            this.dnmSec10.TabIndex = 4;
            // 
            // dnmSec1
            // 
            this.dnmSec1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dnmSec1.Location = new System.Drawing.Point(355, 4);
            this.dnmSec1.Name = "dnmSec1";
            this.dnmSec1.Size = new System.Drawing.Size(50, 95);
            this.dnmSec1.TabIndex = 5;
            // 
            // dclHourAndMin
            // 
            this.dclHourAndMin.Location = new System.Drawing.Point(115, 3);
            this.dclHourAndMin.Name = "dclHourAndMin";
            this.dclHourAndMin.Size = new System.Drawing.Size(30, 96);
            this.dclHourAndMin.TabIndex = 6;
            // 
            // dclMinAndSec
            // 
            this.dclMinAndSec.Location = new System.Drawing.Point(263, 3);
            this.dclMinAndSec.Name = "dclMinAndSec";
            this.dclMinAndSec.Size = new System.Drawing.Size(30, 96);
            this.dclMinAndSec.TabIndex = 7;
            // 
            // DegitalNumberTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dclMinAndSec);
            this.Controls.Add(this.dclHourAndMin);
            this.Controls.Add(this.dnmSec1);
            this.Controls.Add(this.dnmSec10);
            this.Controls.Add(this.dnmMin1);
            this.Controls.Add(this.dnmMin10);
            this.Controls.Add(this.dnmHour1);
            this.Controls.Add(this.dnmHour10);
            this.Name = "DegitalNumberTime";
            this.Size = new System.Drawing.Size(408, 102);
            this.ResumeLayout(false);

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
    }
}
