using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BDWD
{
    public class BaiduSearch
    {
        protected string uri = "http://www.baidu.com/s?wd=";
        protected Encoding queryEncoding = Encoding.GetEncoding("gb2312");
        protected Encoding pageEncoding = Encoding.GetEncoding("gb2312");
        protected string resultPattern = @"(?<=找到相关结果[约]?)[0-9,]*?(?=个)";
        public int GetSearchCount(string html)
        {
            int result = 0;
            string searchcount = string.Empty;

            Regex regex = new Regex(resultPattern);
            Match match = regex.Match(html);

            if (match.Success)
            {
                searchcount = match.Value;
            }
            else
            {
                searchcount = "0";
            }

            if (searchcount.IndexOf(",") > 0)
            {
                searchcount = searchcount.Replace(",", string.Empty);
            }

            int.TryParse(searchcount, out result);

            return result;
        }

        public List<Keyword> GetKeywords(string html, string word)
        {
            int i = 1;
            List<Keyword> keywords = new List<Keyword>();
            try
            {
                string ss = "<h3 class=\"t\"><a.*?href=\"(?<url>.*?)\".*?>(?<content>.*?)<a class=\"c-tip-icon\">";
                //string ss = "<h3 class=\"t\"><a(.*?)href=\"(?<url>.*?)\".*?target=\"_blank\"        >(?<content>.*?)</a>(?<filter>.*?)";
                MatchCollection mcTable = Regex.Matches(html, ss);
                foreach (Match mTable in mcTable)
                {
                    if (mTable.Success)
                    {
                        Keyword keyword = new Keyword();
                        keyword.ID = i++;
                        keyword.Title = mTable.Groups["content"].Value; //Regex.Replace(mTable.Groups["content"].Value, "<[^>]*>", string.Empty);
                        keyword.Link = mTable.Groups["url"].Value;
                        //var str = mTable.Groups["filter"].Value;
                        //keyword.Filter = GetFilter(str);
                        //keyword.Filter = mTable.Groups["filter"].Value.Replace("&nbsp;", "");
                        keywords.Add(keyword);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return keywords;

        }

        private string GetFilter(string html)
        {
            try
            {
                string f = "<div class=\"f13\"><a.*?>(?<filter_key>.*?)</a>";
                var mc = Regex.Matches(html, f);

                foreach (Match mTable in mc)
                {
                    if (mTable.Success)
                    {
                        return mTable.Groups["filter_key"].Value.Replace("&nbsp;", "");
                    }
                }
            }
            catch { }

            return "";
        }
    }
}
