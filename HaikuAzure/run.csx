#r "HaikuGen.dll"

using System;
using Tweetinvi;
using HaikuGen;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    log.Info($"Haiku monster function executed at: {DateTime.Now}"); 
    Haiku haiku = new Haiku();
    string tweetBody = haiku.Lines[0] + "; " + haiku.Lines[1] + "; " + haiku.Lines[2] + ".";
    Auth.SetUserCredentials(
        "CUSTOMER KEY GOES HERE", 
        "CUSTOMER SECRET GOES HERE",
        "AUTHORIZATION KEY GOES HERE",
        "AUTHORIZATION SECRET GOES HERE"
    );
    Tweet.PublishTweet(tweetBody);    
}
