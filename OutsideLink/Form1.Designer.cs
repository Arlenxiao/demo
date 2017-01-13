namespace OutsideLink
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Interval = new System.Windows.Forms.ComboBox();
            this.pb_action = new System.Windows.Forms.ProgressBar();
            this.btn_action = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.rtb_msg = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_dn);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_Interval);
            this.splitContainer1.Panel1.Controls.Add(this.pb_action);
            this.splitContainer1.Panel1.Controls.Add(this.btn_action);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtb_msg);
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(722, 522);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "网站域名";
            // 
            // txt_dn
            // 
            this.txt_dn.Location = new System.Drawing.Point(76, 19);
            this.txt_dn.Name = "txt_dn";
            this.txt_dn.Size = new System.Drawing.Size(212, 21);
            this.txt_dn.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "间隔时间";
            // 
            // cmb_Interval
            // 
            this.cmb_Interval.FormattingEnabled = true;
            this.cmb_Interval.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "5000",
            "10000",
            "20000",
            "30000",
            "60000",
            "120000",
            "180000",
            "300000"});
            this.cmb_Interval.Location = new System.Drawing.Point(363, 19);
            this.cmb_Interval.Name = "cmb_Interval";
            this.cmb_Interval.Size = new System.Drawing.Size(68, 20);
            this.cmb_Interval.TabIndex = 3;
            this.cmb_Interval.Text = "2000";
            // 
            // pb_action
            // 
            this.pb_action.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_action.Location = new System.Drawing.Point(0, 58);
            this.pb_action.Name = "pb_action";
            this.pb_action.Size = new System.Drawing.Size(722, 10);
            this.pb_action.TabIndex = 1;
            // 
            // btn_action
            // 
            this.btn_action.Location = new System.Drawing.Point(635, 15);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(63, 28);
            this.btn_action.TabIndex = 0;
            this.btn_action.Text = "开始";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(722, 348);
            this.webBrowser1.TabIndex = 0;
            // 
            // rtb_msg
            // 
            this.rtb_msg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_msg.Location = new System.Drawing.Point(3, 354);
            this.rtb_msg.Name = "rtb_msg";
            this.rtb_msg.Size = new System.Drawing.Size(719, 96);
            this.rtb_msg.TabIndex = 1;
            this.rtb_msg.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 522);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网站外链添加工具";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ProgressBar pb_action;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Interval;
        private System.Windows.Forms.TextBox txt_dn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_msg;
    }
}

