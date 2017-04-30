using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaikuGen;
using Tweetinvi;
using System.Threading;

namespace HaikuTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Haiku haiku = new Haiku();
                foreach(Line line in haiku.Lines)
                {
                    Console.WriteLine(line.ToString());
                }
                string tweetBody = haiku.Lines[0] + "; " + haiku.Lines[1] + "; " + haiku.Lines[2] + ".";
                Auth.SetUserCredentials(
                    "CUSTOMER KEY GOES HERE",
                    "CUSTOMER SECRET GOES HERE",
                    "AUTHORIZATION KEY GOES HERE",
                    "AUTHORIZATION SECRET GOES HERE"
                );
                Tweet.PublishTweet(tweetBody);
                Thread.Sleep(300000);
            }
        }
    }
}
