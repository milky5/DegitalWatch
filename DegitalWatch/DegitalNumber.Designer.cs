namespace DegitalWatch
{
    partial class DegitalNumber
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
            this.lblTopCenter = new System.Windows.Forms.Label();
            this.lblTopLeft = new System.Windows.Forms.Label();
            this.lblBottomLeft = new System.Windows.Forms.Label();
            this.lblMiddleCenter = new System.Windows.Forms.Label();
            this.lblBottomCenter = new System.Windows.Forms.Label();
            this.lblTopRight = new System.Windows.Forms.Label();
            this.lblBottomRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTopCenter
            // 
            this.lblTopCenter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTopCenter.Location = new System.Drawing.Point(5, 0);
            this.lblTopCenter.Name = "lblTopCenter";
            this.lblTopCenter.Size = new System.Drawing.Size(40, 5);
            this.lblTopCenter.TabIndex = 0;
            // 
            // lblTopLeft
            // 
            this.lblTopLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTopLeft.Location = new System.Drawing.Point(0, 5);
            this.lblTopLeft.Name = "lblTopLeft";
            this.lblTopLeft.Size = new System.Drawing.Size(5, 40);
            this.lblTopLeft.TabIndex = 3;
            // 
            // lblBottomLeft
            // 
            this.lblBottomLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBottomLeft.Location = new System.Drawing.Point(0, 49);
            this.lblBottomLeft.Name = "lblBottomLeft";
            this.lblBottomLeft.Size = new System.Drawing.Size(5, 40);
            this.lblBottomLeft.TabIndex = 6;
            // 
            // lblMiddleCenter
            // 
            this.lblMiddleCenter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMiddleCenter.Location = new System.Drawing.Point(5, 44);
            this.lblMiddleCenter.Name = "lblMiddleCenter";
            this.lblMiddleCenter.Size = new System.Drawing.Size(40, 5);
            this.lblMiddleCenter.TabIndex = 1;
            // 
            // lblBottomCenter
            // 
            this.lblBottomCenter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBottomCenter.Location = new System.Drawing.Point(5, 89);
            this.lblBottomCenter.Name = "lblBottomCenter";
            this.lblBottomCenter.Size = new System.Drawing.Size(40, 5);
            this.lblBottomCenter.TabIndex = 2;
            // 
            // lblTopRight
            // 
            this.lblTopRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTopRight.Location = new System.Drawing.Point(45, 5);
            this.lblTopRight.Name = "lblTopRight";
            this.lblTopRight.Size = new System.Drawing.Size(5, 40);
            this.lblTopRight.TabIndex = 4;
            // 
            // lblBottomRight
            // 
            this.lblBottomRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBottomRight.Location = new System.Drawing.Point(45, 49);
            this.lblBottomRight.Name = "lblBottomRight";
            this.lblBottomRight.Size = new System.Drawing.Size(5, 40);
            this.lblBottomRight.TabIndex = 5;
            // 
            // DegitalNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lblBottomLeft);
            this.Controls.Add(this.lblBottomRight);
            this.Controls.Add(this.lblTopRight);
            this.Controls.Add(this.lblTopLeft);
            this.Controls.Add(this.lblBottomCenter);
            this.Controls.Add(this.lblMiddleCenter);
            this.Controls.Add(this.lblTopCenter);
            this.Name = "DegitalNumber";
            this.Size = new System.Drawing.Size(50, 95);
            this.Resize += new System.EventHandler(this.DegitalNumber_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTopCenter;
        private System.Windows.Forms.Label lblTopLeft;
        private System.Windows.Forms.Label lblBottomLeft;
        private System.Windows.Forms.Label lblMiddleCenter;
        private System.Windows.Forms.Label lblBottomCenter;
        private System.Windows.Forms.Label lblTopRight;
        private System.Windows.Forms.Label lblBottomRight;
    }
}
