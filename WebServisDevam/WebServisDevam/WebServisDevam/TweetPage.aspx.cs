using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServisDevam
{
    public partial class TweetPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ServiceReference1.MyServiceSoapClient servis = new ServiceReference1.MyServiceSoapClient();
        protected void btnGetir_Click(object sender, EventArgs e)
        {
            Listbox1.Items.Clear();
            foreach (var item in servis.GetTweets(txtUserName.Text))
            {
                Listbox1.Items.Add(String.Format("{0}---->{1}", item.UserName, item.Twit));
            }

        }

        protected void btnJsonGetir_Click(object sender, EventArgs e)
        {
            var result = servis.GetTweetsJson(txtUserName.Text);
            List<ServiceReference1.Tweet> tweets = (List<ServiceReference1.Tweet>)JsonConvert.DeserializeObject(result, typeof(List<ServiceReference1.Tweet>));
            foreach (var item in tweets)
            {
                Listbox1.Items.Add(String.Format("{0}------->{1}", item.UserName, item.Twit));
            }
        }
    }
}