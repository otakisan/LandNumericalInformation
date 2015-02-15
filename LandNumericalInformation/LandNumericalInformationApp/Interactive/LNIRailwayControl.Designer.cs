namespace LandNumericalInformationApp.Interactive
{
    partial class LNIRailwayControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.filepathLabel = new System.Windows.Forms.Label();
            this.filepathTextBox = new System.Windows.Forms.TextBox();
            this.extractButton = new System.Windows.Forms.Button();
            this.traceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filepathLabel
            // 
            this.filepathLabel.AutoSize = true;
            this.filepathLabel.Location = new System.Drawing.Point(17, 19);
            this.filepathLabel.Name = "filepathLabel";
            this.filepathLabel.Size = new System.Drawing.Size(93, 24);
            this.filepathLabel.TabIndex = 0;
            this.filepathLabel.Text = "Filepath:";
            // 
            // filepathTextBox
            // 
            this.filepathTextBox.Location = new System.Drawing.Point(116, 16);
            this.filepathTextBox.Name = "filepathTextBox";
            this.filepathTextBox.Size = new System.Drawing.Size(573, 31);
            this.filepathTextBox.TabIndex = 1;
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(116, 72);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(172, 51);
            this.extractButton.TabIndex = 2;
            this.extractButton.Text = "extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // traceTextBox
            // 
            this.traceTextBox.Location = new System.Drawing.Point(21, 156);
            this.traceTextBox.Multiline = true;
            this.traceTextBox.Name = "traceTextBox";
            this.traceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.traceTextBox.Size = new System.Drawing.Size(2000, 560);
            this.traceTextBox.TabIndex = 3;
            // 
            // LNIRailwayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.traceTextBox);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.filepathTextBox);
            this.Controls.Add(this.filepathLabel);
            this.Name = "LNIRailwayControl";
            this.Size = new System.Drawing.Size(2051, 776);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filepathLabel;
        private System.Windows.Forms.TextBox filepathTextBox;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.TextBox traceTextBox;
    }
}
