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
            this.degitalNumberTime = new DegitalWatch.DegitalNumberTime();
            this.degitalNumberDate = new DegitalWatch.DegitalNumberDate();
            this.SuspendLayout();
            // 
            // tmrUpdateTime
            // 
            this.tmrUpdateTime.Interval = 500;
            this.tmrUpdateTime.Tick += new System.EventHandler(this.tmrUpdateTime_Tick);
            // 
            // degitalNumberTime
            // 
            this.degitalNumberTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.degitalNumberTime.Location = new System.Drawing.Point(59, 168);
            this.degitalNumberTime.Name = "degitalNumberTime";
            this.degitalNumberTime.Size = new System.Drawing.Size(408, 102);
            this.degitalNumberTime.TabIndex = 1;
            // 
            // degitalNumberDate
            // 
            this.degitalNumberDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.degitalNumberDate.Location = new System.Drawing.Point(12, 12);
            this.degitalNumberDate.Name = "degitalNumberDate";
            this.degitalNumberDate.Size = new System.Drawing.Size(525, 104);
            this.degitalNumberDate.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 282);
            this.Controls.Add(this.degitalNumberTime);
            this.Controls.Add(this.degitalNumberDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "デジタル時計";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrUpdateTime;
        private DegitalNumberDate degitalNumberDate;
        private DegitalNumberTime degitalNumberTime;
    }
}

