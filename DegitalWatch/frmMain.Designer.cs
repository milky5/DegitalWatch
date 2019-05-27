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
            this.btnDebug = new System.Windows.Forms.Button();
            this.lblDebug = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.degitalColon2 = new DegitalWatch.DegitalColon();
            this.degitalColon1 = new DegitalWatch.DegitalColon();
            this.degitalNumber6 = new DegitalWatch.DegitalNumber();
            this.degitalNumber5 = new DegitalWatch.DegitalNumber();
            this.degitalNumber4 = new DegitalWatch.DegitalNumber();
            this.degitalNumber3 = new DegitalWatch.DegitalNumber();
            this.degitalNumber2 = new DegitalWatch.DegitalNumber();
            this.degitalNumber1 = new DegitalWatch.DegitalNumber();
            this.SuspendLayout();
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(44, 3);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(55, 32);
            this.btnDebug.TabIndex = 8;
            this.btnDebug.Text = "button1";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDebug.Location = new System.Drawing.Point(131, 9);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(353, 25);
            this.lblDebug.TabIndex = 9;
            this.lblDebug.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // degitalColon2
            // 
            this.degitalColon2.Location = new System.Drawing.Point(317, 123);
            this.degitalColon2.Name = "degitalColon2";
            this.degitalColon2.Size = new System.Drawing.Size(30, 96);
            this.degitalColon2.TabIndex = 7;
            // 
            // degitalColon1
            // 
            this.degitalColon1.Location = new System.Drawing.Point(167, 123);
            this.degitalColon1.Name = "degitalColon1";
            this.degitalColon1.Size = new System.Drawing.Size(30, 96);
            this.degitalColon1.TabIndex = 6;
            // 
            // degitalNumber6
            // 
            this.degitalNumber6.AutoSize = true;
            this.degitalNumber6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.degitalNumber6.Location = new System.Drawing.Point(409, 123);
            this.degitalNumber6.Name = "degitalNumber6";
            this.degitalNumber6.Size = new System.Drawing.Size(53, 94);
            this.degitalNumber6.TabIndex = 5;
            // 
            // degitalNumber5
            // 
            this.degitalNumber5.AutoSize = true;
            this.degitalNumber5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.degitalNumber5.Location = new System.Drawing.Point(352, 123);
            this.degitalNumber5.Name = "degitalNumber5";
            this.degitalNumber5.Size = new System.Drawing.Size(53, 94);
            this.degitalNumber5.TabIndex = 4;
            // 
            // degitalNumber4
            // 
            this.degitalNumber4.AutoSize = true;
            this.degitalNumber4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.degitalNumber4.Location = new System.Drawing.Point(260, 123);
            this.degitalNumber4.Name = "degitalNumber4";
            this.degitalNumber4.Size = new System.Drawing.Size(53, 94);
            this.degitalNumber4.TabIndex = 3;
            // 
            // degitalNumber3
            // 
            this.degitalNumber3.AutoSize = true;
            this.degitalNumber3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.degitalNumber3.Location = new System.Drawing.Point(203, 123);
            this.degitalNumber3.Name = "degitalNumber3";
            this.degitalNumber3.Size = new System.Drawing.Size(53, 94);
            this.degitalNumber3.TabIndex = 2;
            // 
            // degitalNumber2
            // 
            this.degitalNumber2.AutoSize = true;
            this.degitalNumber2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.degitalNumber2.Location = new System.Drawing.Point(105, 123);
            this.degitalNumber2.Name = "degitalNumber2";
            this.degitalNumber2.Size = new System.Drawing.Size(53, 94);
            this.degitalNumber2.TabIndex = 1;
            // 
            // degitalNumber1
            // 
            this.degitalNumber1.AutoSize = true;
            this.degitalNumber1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.degitalNumber1.Location = new System.Drawing.Point(48, 123);
            this.degitalNumber1.Name = "degitalNumber1";
            this.degitalNumber1.Size = new System.Drawing.Size(53, 94);
            this.degitalNumber1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.degitalColon2);
            this.Controls.Add(this.degitalColon1);
            this.Controls.Add(this.degitalNumber6);
            this.Controls.Add(this.degitalNumber5);
            this.Controls.Add(this.degitalNumber4);
            this.Controls.Add(this.degitalNumber3);
            this.Controls.Add(this.degitalNumber2);
            this.Controls.Add(this.degitalNumber1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DegitalNumber degitalNumber1;
        private DegitalNumber degitalNumber2;
        private DegitalNumber degitalNumber3;
        private DegitalNumber degitalNumber4;
        private DegitalNumber degitalNumber5;
        private DegitalNumber degitalNumber6;
        private DegitalColon degitalColon1;
        private DegitalColon degitalColon2;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Timer timer1;
    }
}

