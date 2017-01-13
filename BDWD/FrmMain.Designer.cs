namespace BDWD
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chk_num = new System.Windows.Forms.CheckBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.pb_action = new System.Windows.Forms.ProgressBar();
            this.btn_action = new System.Windows.Forms.Button();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lbl_page = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lbl_page);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_msg);
            this.splitContainer1.Panel1.Controls.Add(this.btn_next);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.chk_num);
            this.splitContainer1.Panel1.Controls.Add(this.btn_stop);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_filter);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_key);
            this.splitContainer1.Panel1.Controls.Add(this.pb_action);
            this.splitContainer1.Panel1.Controls.Add(this.btn_action);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(790, 638);
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.TabIndex = 1;
            // 
            // chk_num
            // 
            this.chk_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_num.AutoSize = true;
            this.chk_num.Checked = true;
            this.chk_num.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_num.Location = new System.Drawing.Point(542, 20);
            this.chk_num.Name = "chk_num";
            this.chk_num.Size = new System.Drawing.Size(72, 16);
            this.chk_num.TabIndex = 10;
            this.chk_num.Text = "重新计数";
            this.chk_num.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stop.Location = new System.Drawing.Point(715, 12);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(63, 28);
            this.btn_stop.TabIndex = 9;
            this.btn_stop.Text = "停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "目标";
            // 
            // txt_filter
            // 
            this.txt_filter.Location = new System.Drawing.Point(76, 46);
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(212, 21);
            this.txt_filter.TabIndex = 7;
            this.txt_filter.Text = "yuewusheng.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "关键词";
            // 
            // txt_key
            // 
            this.txt_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_key.Location = new System.Drawing.Point(76, 19);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(441, 21);
            this.txt_key.TabIndex = 5;
            this.txt_key.Text = "混合管,ab胶筒,点胶针筒,点胶机,灌胶机,ab胶枪,月无声";
            // 
            // pb_action
            // 
            this.pb_action.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_action.Location = new System.Drawing.Point(0, 73);
            this.pb_action.Name = "pb_action";
            this.pb_action.Size = new System.Drawing.Size(790, 10);
            this.pb_action.TabIndex = 1;
            // 
            // btn_action
            // 
            this.btn_action.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_action.Location = new System.Drawing.Point(635, 12);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(63, 28);
            this.btn_action.TabIndex = 0;
            this.btn_action.Text = "开始";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(790, 271);
            this.webBrowser2.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(790, 276);
            this.webBrowser1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "多个关键词使用,分割";
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.Location = new System.Drawing.Point(635, 46);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(63, 23);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = "下一个";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.webBrowser1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.webBrowser2);
            this.splitContainer2.Size = new System.Drawing.Size(790, 551);
            this.splitContainer2.SplitterDistance = 276;
            this.splitContainer2.TabIndex = 3;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(295, 51);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 12);
            this.lbl_msg.TabIndex = 13;
            // 
            // lbl_page
            // 
            this.lbl_page.AutoSize = true;
            this.lbl_page.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_page.ForeColor = System.Drawing.Color.Green;
            this.lbl_page.Location = new System.Drawing.Point(728, 48);
            this.lbl_page.Name = "lbl_page";
            this.lbl_page.Size = new System.Drawing.Size(34, 21);
            this.lbl_page.TabIndex = 14;
            this.lbl_page.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 638);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "搜索";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.ProgressBar pb_action;
        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_filter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.CheckBox chk_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label lbl_page;
    }
}

