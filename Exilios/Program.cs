#region Default using tags.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion
#region TwitchLib using tags.
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
#endregion

namespace Exilios
{
    class Program
    {
        #region Program Management Variables
        public static string progName = "Exilios";
        public static double progVer = 0.1;
        #endregion

        #region TwitchLib Variables

        static string twitchUsername = "ExiliosBot";
        static string twitchAccessToken = "PUT SOMTHING HERE WHEN YOU GO TO TEST THIS OUT OR THERE WILL BE PROBLEMS!"; // Hey! Notice me! You will have problems if you don't fix this!
        static string twitchChannel = "XeinixOfficial";

        static TwitchClient client;
        static ConnectionCredentials credentials = new ConnectionCredentials(twitchUsername, twitchAccessToken);

        #endregion

        #region Loop Variables

        static bool isLoggedIn = false;
        static bool isRunning = true;

        #endregion

        static void Main(string[] args)
        {
            msgGood(progName + " is alive! Current Version: v." + progVer);
            msg("Setting up Twitch Connections.");

            client = new TwitchClient(credentials, twitchChannel);
            client.OnJoinedChannel += onJoinedChannel;
            client.OnMessageReceived += onMessageReceived;
            client.OnUserJoined += onUserJoined;
            client.OnIncorrectLogin += onIncorrectLogin;
            client.OnConnected += onConnected;

            while (isRunning)
            {
                if (!isLoggedIn)
                {
                    msgError("Exilios is not logged in. Aborting run.");
                    msg("Press Any Key To Exit.");
                    Console.ReadKey();
                    isRunning = false;
                    return;
                }
                if (isLoggedIn)
                {

                }
            }
        }

        private static void onConnected(object sender, OnConnectedArgs e)
        {
            isLoggedIn = true;
            msgGood("Connected to Twitch Chat");            
        }

        private static void onIncorrectLogin(object sender, OnIncorrectLoginArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            msgError("Inncorrect Login Used! Please Check Your Variables!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void onUserJoined(object sender, OnUserJoinedArgs e)
        {

        }

        private static void onMessageReceived(object sender, OnMessageReceivedArgs e)
        {

        }

        private static void onJoinedChannel(object sender, OnJoinedChannelArgs e)
        {

        }

        #region Message Methods
        static void msgWarn(string m)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(m);
        }

        static void msgError(string m)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(m);
        }

        static void msg(string m)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(m);
        }

        static void msgGood(string m)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(m);
        }
        #endregion
    }
}
