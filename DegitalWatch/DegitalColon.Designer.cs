namespace DegitalWatch
{
    partial class DegitalColon
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
            this.lblTopPeriod = new System.Windows.Forms.Label();
            this.lblBottomPeriod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTopPeriod
            // 
            this.lblTopPeriod.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTopPeriod.Location = new System.Drawing.Point(12, 24);
            this.lblTopPeriod.Name = "lblTopPeriod";
            this.lblTopPeriod.Size = new System.Drawing.Size(5, 5);
            this.lblTopPeriod.TabIndex = 0;
            // 
            // lblBottomPeriod
            // 
            this.lblBottomPeriod.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBottomPeriod.Location = new System.Drawing.Point(12, 72);
            this.lblBottomPeriod.Name = "lblBottomPeriod";
            this.lblBottomPeriod.Size = new System.Drawing.Size(5, 5);
            this.lblBottomPeriod.TabIndex = 1;
            // 
            // DegitalColon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBottomPeriod);
            this.Controls.Add(this.lblTopPeriod);
            this.Name = "DegitalColon";
            this.Size = new System.Drawing.Size(30, 96);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTopPeriod;
        private System.Windows.Forms.Label lblBottomPeriod;
    }
}
