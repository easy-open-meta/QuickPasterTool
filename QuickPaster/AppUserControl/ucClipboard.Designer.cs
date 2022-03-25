namespace QuickPaster
{
    partial class ucClipboard
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tpFromSoft = new Sunny.UI.UITitlePanel();
            this.txtClipbordRecord = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // tpFromSoft
            // 
            this.tpFromSoft.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpFromSoft.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpFromSoft.Location = new System.Drawing.Point(0, 0);
            this.tpFromSoft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpFromSoft.MinimumSize = new System.Drawing.Size(1, 1);
            this.tpFromSoft.Name = "tpFromSoft";
            this.tpFromSoft.Padding = new System.Windows.Forms.Padding(0, 23, 0, 0);
            this.tpFromSoft.Size = new System.Drawing.Size(455, 22);
            this.tpFromSoft.TabIndex = 0;
            this.tpFromSoft.Text = null;
            this.tpFromSoft.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.tpFromSoft.TitleHeight = 23;
            // 
            // txtClipbordRecord
            // 
            this.txtClipbordRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClipbordRecord.AutoScroll = true;
            this.txtClipbordRecord.ButtonSymbol = 61761;
            this.txtClipbordRecord.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtClipbordRecord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClipbordRecord.Location = new System.Drawing.Point(0, 23);
            this.txtClipbordRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClipbordRecord.Maximum = 2147483647D;
            this.txtClipbordRecord.Minimum = -2147483648D;
            this.txtClipbordRecord.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtClipbordRecord.Multiline = true;
            this.txtClipbordRecord.Name = "txtClipbordRecord";
            this.txtClipbordRecord.Size = new System.Drawing.Size(455, 75);
            this.txtClipbordRecord.Style = Sunny.UI.UIStyle.Custom;
            this.txtClipbordRecord.TabIndex = 1;
            this.txtClipbordRecord.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // ucClipboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.txtClipbordRecord);
            this.Controls.Add(this.tpFromSoft);
            this.Name = "ucClipboard";
            this.Size = new System.Drawing.Size(455, 99);
            this.Load += new System.EventHandler(this.ucClipboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Sunny.UI.UITitlePanel tpFromSoft;
        public Sunny.UI.UITextBox txtClipbordRecord;
    }
}
