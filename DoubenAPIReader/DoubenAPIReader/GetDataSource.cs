using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace DoubenAPIReader
{
    public class GetDataSource
    {
        /// <summary>
        /// 通过http协议从网络上获取json文件内容
        /// </summary>
        /// <param name="url">API地址</param>
        /// <returns>将json内容以string类型返回</returns>
        public string GetJsonFile(string url)
        {
            HttpWebRequest myRequest = null;
            HttpWebResponse myHttpResponse = null;
            string getUrl = url.Replace(@"\", "").ToString().Trim();
            myRequest = (HttpWebRequest)WebRequest.Create(getUrl);
            myHttpResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myHttpResponse.GetResponseStream(), Encoding.UTF8);
            string jsonFile = reader.ReadToEnd();
            reader.Close();
            myHttpResponse.Close();
            return jsonFile;
        }

        /// <summary>
        /// 通过标签获得图书信息
        /// </summary>
        /// <param name="tags">标签</param>
        /// <returns>将json内容以string类型返回</returns>
        public string GetTagsInfo(string tags)
        {
            string temp = "https://api.douban.com/v2/book/search?q=" + tags + "&start=0&count=100";
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(temp);
            HttpWebResponse myHttpResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myHttpResponse.GetResponseStream(), Encoding.UTF8);
            string tagsFile = reader.ReadToEnd();
            reader.Close();
            myHttpResponse.Close();
            return tagsFile;
        }
    }
}
