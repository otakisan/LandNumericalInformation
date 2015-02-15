namespace LandNumericalInformationApp.Interactive
{
    partial class LandNumericalInformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lniRailwayControl1 = new LandNumericalInformationApp.Interactive.LNIRailwayControl();
            this.SuspendLayout();
            // 
            // lniRailwayControl1
            // 
            this.lniRailwayControl1.Location = new System.Drawing.Point(19, 12);
            this.lniRailwayControl1.Name = "lniRailwayControl1";
            this.lniRailwayControl1.Size = new System.Drawing.Size(2096, 776);
            this.lniRailwayControl1.TabIndex = 0;
            // 
            // LandNumericalInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2158, 925);
            this.Controls.Add(this.lniRailwayControl1);
            this.Name = "LandNumericalInformationForm";
            this.Text = "LandNumericalInformationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LNIRailwayControl lniRailwayControl1;
    }
}