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

            keys = str.Split(',').ToList();

            if (keys.Count <= 0) { MessageBox.Show("请输入关键词"); return; }

            if (chk_num.Checked) num = 0;
            timer1.Enabled = true;
            Action();
        }

        private void Action()
        {
            if (keys.Count <= 0) return;

            index = index <= keys.Count ? index : 0;
            key = keys[index];
            filter = txt_filter.Text;
            string url = string.Format("http://www.baidu.com/s?wd={0}&pn={1}&usm=2", key, pn * num);

            this.BeginInvoke((MethodInvoker)(() => { lbl_page.Text = num.ToString(); }));

            GetWebContent(url);
            if (num > 75)
            {
                if (index < keys.Count) { index++; num = 0; }
                else EndSearch();
            }
        }

        private void SetPB()
        {
            this.BeginInvoke((MethodInvoker)(() =>
            {
                var v = pb_action.Value + 5;
                if (v > 100) v = 0;
                pb_action.Value = v;
            }));
        }

        List<string> keys = new List<string>();
        string key = string.Empty;
        string filter = string.Empty;
        int pn = 10;
        int num = 0;
        int index = 0;
        private void GetWebContent(string Url)
        {
            SetPB();
            string strResult = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream streamReceive = response.GetResponseStream())
                {
                    StreamReader streamReader = new StreamReader(streamReceive, Encoding.UTF8);
                    strResult = streamReader.ReadToEnd();
                }

                var str = Regex.Replace(strResult, @"<script[\s\S]*?</script\s*>", "", RegexOptions.None);
                var html = str.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                this.BeginInvoke((MethodInvoker)(() =>
                {
                    try
                    {
                        webBrowser1.DocumentText = html;
                    }
                    catch { }
                }));

                List<Keyword> keywords = new BaiduSearch().GetKeywords(html, key);

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



        private void timer1_Tick(object sender, EventArgs e)
        {
            Action();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            EndSearch();
        }

        private void EndSearch()
        {
            timer1.Enabled = false;
            num = 0;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            index++;
            timer1.Enabled = true;
            Action();
            //webBrowser2.Navigate("http://www.wslink.cn/h-index.html");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser2.ScriptErrorsSuppressed = true;
        }
    }
}
