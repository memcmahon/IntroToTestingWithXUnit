using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToTesting
{
    public class User
    {
        public string Name { get; private set; }
        public string Username { get; set; }
        public List<String> Tweets { get; } = new List<String>();

        public User(string name)
        {
            Name = name;
        }

        public void Tweet(string message)
        {
            Tweets.Add(message);
        }

        public string MostRecentTweet()
        {
            var lastIndex = Tweets.Count - 1;
            return Tweets[lastIndex];
        }
    }
}
