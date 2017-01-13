using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDWD
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://www.baidu.com");
            webBrowser2.Navigate("http://www.wslink.cn");
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            index = 0;
            var str = txt_key.Text;
            keys = str.Split(new string[] { "", ",", ";", "|" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (keys.Count <= 0) { MessageBox.Show("请输入关键词"); return; }

            if (chk_num.Checked) num = 0;
            timer1.Enabled = true;
            Action();
        }

        /// <summary>
        /// 执行定时动作
        /// </summary>
        private void Action()
        {
            //临界判断
            if (keys.Count <= 0 || index >= keys.Count) return;

            this.BeginInvoke((MethodInvoker)(() => { lbl_page.Text = num.ToString(); }));

            index = index < keys.Count ? index : 0;
            key = keys[index];
            filter = txt_filter.Text;
            string url = string.Format("http://www.baidu.com/s?wd={0}&pn={1}&usm=2", key, pn * num);
            GetWebContent(url);

            //百度没有收录情况跳转下一个关键词
            if (num > 75)
            {
                if (index < keys.Count) { index++; num = 0; }
                else EndSearch();
            }
        }

        /// <summary>
        /// 进度显示,让人知道程序是活着的
        /// </summary>
        private void SetPB()
        {
            this.BeginInvoke((MethodInvoker)(() =>
            {
                var v = pb_action.Value + 5;
                if (v > 100) v = 0;
                pb_action.Value = v;
            }));
        }

        /// <summary>关键词集合</summary>
        List<string> keys = new List<string>();
        /// <summary>当前使用关键词</summary>
        string key = string.Empty;
        /// <summary>匹配条件</summary>
        string filter = string.Empty;
        /// <summary>百度查询每页数据</summary>
        int pn = 10;
        /// <summary>百度查询索引</summary>
        int num = 0;
        /// <summary>关键词索引</summary>
        int index = 0;

        /// <summary>
        /// 百度查询界面内容
        /// </summary>
        /// <param name="Url"></param>
        private void GetWebContent(string Url)
        {
            SetPB();
            string strResult = "";
            try
            {
                //网页请求
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream streamReceive = response.GetResponseStream())
                {
                    StreamReader streamReader = new StreamReader(streamReceive, Encoding.UTF8);
                    strResult = streamReader.ReadToEnd();
                }

                //过滤页面脚本
                var str = Regex.Replace(strResult, @"<script[\s\S]*?</script\s*>", "", RegexOptions.None);
                var html = str.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                this.BeginInvoke((MethodInvoker)(() =>
                {
                    try { webBrowser1.DocumentText = html; } catch { }
                }));

                //百度查询结果处理
                List<Keyword> keywords = new BaiduSearch().GetKeywords(html, key);

                //查询结果匹配
                if (html.Contains(filter))
                {
                    index++;
                    if (index >= keys.Count) timer1.Enabled = false;

                    foreach (var item in keywords)
                    {
                        string k = string.Format("{0}  {1}  {2}  {3}\r\n", item.ID, item.Title, item.Link, item.Filter);
                        //rtb_msg.AppendText(k);
                    }
                    var entity = keywords.FirstOrDefault(m => m.Title.Contains(filter));
                    if (entity != null)
                    {
                        //lbl_msg.Text = entity.Link;
                        webBrowser2.Navigate(entity.Link);
                    }
                    num = 0;
                }
                else { num++; }
            }
            catch (Exception ex)
            {
                this.BeginInvoke((MethodInvoker)(() =>
                {
                    //rtb_msg.AppendText(ex.Message + "\r\n");
                }));
            }
        }

        /// <summary>
        /// 定时事件
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Action();
        }

        /// <summary>
        /// 停止方法
        /// </summary>
        private void btn_stop_Click(object sender, EventArgs e)
        {
            EndSearch();
        }

        /// <summary>
        /// 方法结束
        /// </summary>
        private void EndSearch()
        {
            timer1.Enabled = false;
            num = 0;
        }

        /// <summary>
        /// 下一个关键词
        /// </summary>
        private void btn_next_Click(object sender, EventArgs e)
        {
            index++;
            timer1.Enabled = true;
            Action();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            //页面脚本设置
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser2.ScriptErrorsSuppressed = true;
        }
    }
}
