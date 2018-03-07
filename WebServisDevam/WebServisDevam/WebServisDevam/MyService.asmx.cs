using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace WebServisDevam
{
    /// <summary>
    /// Summary description for MyService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public double Pisagor(int sayi1, int sayi2)
        {
            return Math.Sqrt(Math.Pow(sayi1, 2) + Math.Pow(sayi2, 2));
        }
        [WebMethod]
        public string GetRssData(string url)
        {
            WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };
            return wc.DownloadString(url);
        }

        [WebMethod]
        public string GetRssDataWithJsonFormat(string Url)
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            string data = wc.DownloadString(Url);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(data);
            return JsonConvert.SerializeXmlNode(doc);
        }

        AtesDBEntities ate = new AtesDBEntities();
        [WebMethod]
        public List<Menu> GetAllMenu()
        {

            return ate.Menus.ToList();

        }
        [WebMethod]
        public string GetJsonFormat()
        {
            return JsonConvert.SerializeObject(ate.Menus.ToList());
        }

        public class Tweet
        {
            public string UserName { get; set; }
            public string Twit { get; set; }
            
        }

        //https://twitrss.me/

        [WebMethod]
        public List<Tweet> GetTweets(string UserName)
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            string data = wc.DownloadString("http://twitrss.me/twitter_user_to_rss/?user=" + UserName);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(data);
            XmlNodeList docList = doc.DocumentElement.SelectNodes("channel/item");
            List<Tweet> TweetListesi = new List<Tweet>();

            foreach (XmlNode item in docList)
            {
                Tweet t = new Tweet();
                t.UserName = UserName;
                t.Twit = item.SelectSingleNode("title").InnerText;

                TweetListesi.Add(t);

            }
            return TweetListesi;
        }

        [WebMethod]
        public string GetTweetsJson(string userName)
        {
            var result = GetTweets(userName);
            return JsonConvert.SerializeObject(result);
        }

        
    }
}
