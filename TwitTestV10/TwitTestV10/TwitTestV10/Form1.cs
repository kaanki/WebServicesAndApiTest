using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;

namespace TwitTestV10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TwitterService twitService = new TwitterService("NstKZt5MFoJQFIvlcX6aLwmej", "PnngGPCpJZApmulS8L9hd3bcIx1CAxvWvHpgLJOeJDYNMWSYJq", "225922198-CN8iRlsct4eGbounPjW5DrRUTaWDore9EBso0XsW", "VlK6iGxC2lUIs8ZMyaJJ66PpHUWHwWmxNYnxkolsZPkxh");
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            lstTweet.Items.Clear();
            lstTweetId.Items.Clear();
            var veriler = twitService.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions() { Count = 5 });

            foreach (var item in veriler)
            {
                lstTweet.Items.Add(item.Text);
                lstTweetId.Items.Add(item.Id);
            }
        }

        private void btnMyTweet_Click(object sender, EventArgs e)
        {
            lstTweet.Items.Clear();
            lstTweetId.Items.Clear();

            var veriler1 = twitService.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions { Count = 10 });
            foreach (var item in veriler1)
            {
                lstTweet.Items.Add(item.User.Name + " " + item.Text);
                lstTweetId.Items.Add(item.Id);
            }
        }

        private void btnTweetGonder_Click(object sender, EventArgs e)
        {
            try
            {
                twitService.SendTweet(new SendTweetOptions() { Status = txtTweet.Text });
                lblError.ForeColor = Color.Green;
                lblError.Text = "islem basarili";
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            try
            {
                twitService.DeleteTweet(new DeleteTweetOptions() { Id = long.Parse(lstTweetId.SelectedItem.ToString()) });
                lblError.ForeColor = Color.Green;
                lblError.Text ="silme basarili";
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }

        private void lstTweet_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTweetId.SelectedIndex = lstTweet.SelectedIndex;
        }

        private void btnMention_Click(object sender, EventArgs e)
        {
            var veriler = twitService.ListTweetsMentioningMe(new ListTweetsMentioningMeOptions() { Count = 10 });
            foreach (var item in veriler)
            {
                lstTweet.Items.Add(item.User.Name + " " + item.Text);
                lstTweetId.Items.Add(item.Id);

                
            }
        }

      
    }
}
