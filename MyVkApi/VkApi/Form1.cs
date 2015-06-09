using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VkApi
{
    public partial class Form1 : Form
    {
        public class Item
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string nickname { get; set; }
            public string deactivated { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }

        public class RootObject
        {
            public Response response { get; set; }
        }

        public string AccessToken;
        public Form1()
        {
            InitializeComponent();
            WebBrowser.Navigate("https://oauth.vk.com/authorize?client_id=4935016&scope=friends,wall&redirect_uri=https://oauth.vk.com/blank.html&display=popup&v=5.33&response_type=token");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = WebBrowser.Url.ToString();
            int start = temp.IndexOf("=");
            int finish = temp.IndexOf("&");
            for (int i = start + 1; i < finish; i++)
                AccessToken += temp[i];
        }

        public String getres(string Site)
        {
            string nav = Site + AccessToken;
            WebRequest webreq = WebRequest.Create(nav);
            WebResponse webres = webreq.GetResponse();
            String sResponse = new StreamReader(webres.GetResponseStream()).ReadToEnd();
            return sResponse;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RootObject VK = JsonConvert.DeserializeObject<RootObject>
                (getres("https://api.vk.com/method/users.getFollowers?user_id=55048629&fields=nickname&count=1000&v=5.33&access_token="));
                for (int i = 0; i < VK.response.count; i++)
                    listBox2.Items.Add("Name : " + VK.response.items[i].first_name + "\t\tSurname : " + VK.response.items[i].last_name);
        }


      

        private void button1_Click_1(object sender, EventArgs e)
        {
            RootObject VK = JsonConvert.DeserializeObject<RootObject>
              (getres("https://api.vk.com/method/friends.get?user_id=55048629&fields=nickname&count=1000&v=5.33&access_token="));
            for (int i = 0; i < VK.response.count; i++)
                listBox1.Items.Add("Name : " + VK.response.items[i].first_name + "\t\tSurname : " + VK.response.items[i].last_name);
        }

        private void Like_Click(object sender, EventArgs e)
        {
            WebRequest webreq = WebRequest.Create("https://api.vk.com/method/likes.add?type=photo&owner_id=55048629&item_id=336313266&count=1000&v=5.33&access_token=" + AccessToken);
            WebResponse webres = webreq.GetResponse();
        }
    }
}
