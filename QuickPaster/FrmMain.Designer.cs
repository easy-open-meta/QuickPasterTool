namespace QuickPaster
{
    partial class FrmMain
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
            this.flpClipboardArea = new Sunny.UI.UIFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpClipboardArea
            // 
            this.flpClipboardArea.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.flpClipboardArea.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpClipboardArea.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flpClipboardArea.Location = new System.Drawing.Point(4, 40);
            this.flpClipboardArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpClipboardArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.flpClipboardArea.Name = "flpClipboardArea";
            this.flpClipboardArea.Padding = new System.Windows.Forms.Padding(2);
            this.flpClipboardArea.Size = new System.Drawing.Size(465, 405);
            this.flpClipboardArea.TabIndex = 0;
            this.flpClipboardArea.Text = null;
            this.flpClipboardArea.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.flpClipboardArea.WrapContents = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpClipboardArea);
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.ShowTitleIcon = true;
            this.Text = "简切QuickPaster";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel flpClipboardArea;
    }
}