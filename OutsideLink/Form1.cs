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

namespace OutsideLink
{
    public partial class Form1 : Form
    {
        Timer timer;
        Int32 interval = 20000;
        Int32 COUNT = 0;//总计数
        Int32 NUM = 1;//单次计数


        public Form1()
        {
            InitializeComponent();
            btn_action.Text = "开始";
            txt_dn.Text = "www.wslink.cn";
            cmb_Interval.Text = interval.ToString();
            timer = new Timer { Interval = interval, Enabled = false };
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ExceAction();
        }

        string dn = "www.wslink.cn";
        string[] link = {
            "http://tool.lusongsong.com/seo/data.php?p={0}&dn={1}",
            "http://www.iacoo.com/wailian/data.php?p={0}&dn={1}",
            "http://seo.addpv.com/AddSuperLink?p={0}&dn={1}" };

        private void btn_action_Click(object sender, EventArgs e)
        {
            interval = Convert.ToInt32(cmb_Interval.Text);
            timer.Interval = interval;
            dn = txt_dn.Text.Trim();
            var b = btn_action.Text;
            if (b == "开始")
            {
                btn_action.Text = "停止";
                SetPB();
                timer.Enabled = true;
            }
            else
            {
                btn_action.Text = "开始";
                timer.Enabled = false;
            }
        }

        private void ExceAction()
        {
            interval = Convert.ToInt32(cmb_Interval.Text);
            timer.Interval = interval;
            var url = string.Format(link[COUNT], NUM, dn);
            GetWebContent(url);
            NUM++;

            this.BeginInvoke((MethodInvoker)(() =>
            {
                rtb_msg.AppendText(url + "\r\n");
            }));
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

        private void GetWebContent(string Url)
        {
            SetPB();
            string strResult = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                //声明一个HttpWebRequest请求
                request.Timeout = 30000;
                //设置连接超时时间
                request.Headers.Set("Pragma", "no-cache");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream streamReceive = response.GetResponseStream())
                {
                    StreamReader streamReader = new StreamReader(streamReceive, Encoding.UTF8);
                    strResult = streamReader.ReadToEnd();
                }

                var html = Regex.Replace(strResult, @"<script[\s\S]*?</script\s*>", "", RegexOptions.None);
                this.BeginInvoke((MethodInvoker)(() =>
                {
                    webBrowser1.DocumentText = html;
                }));

                if (html.Contains(">（") || html.Contains(">("))
                {
                    var index = html.IndexOf(">（");
                    if (index < 0) index = html.IndexOf(">(");
                    index = index + 2;

                    var temp = html.Substring(index, 20);
                    var i = temp.IndexOf("）");
                    if (i < 0) i = temp.IndexOf(")");

                    var t1 = temp.Substring(0, i);
                    var v = t1.Split('/');
                    if (v.Length >= 2)
                    {
                        var v0 = Convert.ToInt32(v[0]);
                        var v1 = Convert.ToInt32(v[1]);
                        this.BeginInvoke((MethodInvoker)(() =>
                        {
                            rtb_msg.AppendText(t1 + "\t");
                        }));
                        if (v0 > v1) { End(); return; }
                    }
                }
                //判断是否结束
                if (html.Contains("工作完毕") || html.Contains("完成") || html.Contains("恭喜"))
                {
                    End();
                }
            }
            catch (Exception ex)
            {
                this.BeginInvoke((MethodInvoker)(() =>
                {
                    rtb_msg.AppendText(ex.Message + "\r\n");
                }));
            }
        }

        private void End()
        {
            NUM = 1;
            COUNT++;
            if (link.Count() <= COUNT)
            {
                timer.Enabled = false;
                btn_action.Text = "开始";
            }
        }


    }
}
