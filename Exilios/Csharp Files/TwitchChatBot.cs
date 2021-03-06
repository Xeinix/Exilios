﻿#region System Using Tags
using System;
using Microsoft.Win32;
using System.Threading;
#endregion
#region TwitchLib using tags.
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
using TwitchLib.Models.API.v5.Users;
#endregion

namespace Exilios
{
    internal class TwitchChatBot
    {
        #region Variables
        #region Registry Stuff
        static RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Exilios");

        static String regIsConfig = "isConfig";
        static String regBotToken = "botToken";
        static String regClientId = "clientId";
        static String regBotUsername = "botUsername";
        static String regChannelName = "botChannelName";
        static String regConnectOL = "connectOnLaunch";
        #endregion

        #region Twitch Connection Variables
        readonly ConnectionCredentials credentials = new ConnectionCredentials(reg.GetValue(regBotUsername, null).ToString(), reg.GetValue(regBotToken, null).ToString());
        TwitchClient client;
        #endregion

        #region Chat Mode Variables
        static bool isChatEnabled = false;
        #endregion
        #endregion

        #region Threading Stuff.
        static Thread threadRepeatMessage;
        static bool isThreadCreated = false;
        static bool isThreadRunning = false;



        #endregion

        #region Event Handlers
        private void clientOnConnected(object sender, OnConnectedArgs e)
        {
            msgGood("Connected To Twitch Chat!");
            Console.Title = "Exilios State: Connected";
            client.SendMessage("ExiliosBot is alive! Muhahaha");
        }
        private void clientOnDisconnected(object sender, OnDisconnectedArgs e)
        {
            msgError("Disconnected from Twitch chat!");
            Console.Title = "Exilios State: Disconnected";
        }
        private void clientOnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (isChatEnabled) msg(e.ChatMessage.DisplayName + ": " +e.ChatMessage.Message);
            if(e.ChatMessage.Message.StartsWith("hi", StringComparison.InvariantCultureIgnoreCase))
            {
                client.SendMessage($"Hey there {e.ChatMessage.DisplayName}.");
            }
            if(e.ChatMessage.Message.Equals("!itch", StringComparison.InvariantCultureIgnoreCase))
            {
                if (isChatEnabled) msgGood("Sending Itch.io information");
                client.SendMessage($"Itch.io: itch.xeinix.me");
            }
            if (e.ChatMessage.Message.Equals("!twitter", StringComparison.InvariantCultureIgnoreCase))
            {
                if (isChatEnabled) msgGood("Sending Twitter information");
                client.SendMessage($"Twitter: @Xeinix twitter.xeinix.me");
            }
            if (e.ChatMessage.Message.Equals("!insta", StringComparison.InvariantCultureIgnoreCase))
            {
                if (isChatEnabled) msgGood("Sending Instagram information");
                client.SendMessage($"Instagram: @XeinixOfficial insta.xeinix.me");
            }
            if (e.ChatMessage.Message.Equals("!donate", StringComparison.InvariantCultureIgnoreCase))
            {
                if (isChatEnabled) msgGood("Sending Donation information");
                client.SendMessage($"Donate: http://donate.xeinix.me");
            }
            if (e.ChatMessage.Message.Equals("!site", StringComparison.InvariantCultureIgnoreCase) || e.ChatMessage.Message.Equals("!website", StringComparison.InvariantCultureIgnoreCase))
            {
                if (isChatEnabled) msgGood("Sending Site information");
                client.SendMessage($"Website: http://xeinix.me");
            }
            if (e.ChatMessage.Message.Equals("!youtube", StringComparison.InvariantCultureIgnoreCase) || e.ChatMessage.Message.Equals("!website", StringComparison.InvariantCultureIgnoreCase))
            {
                if (isChatEnabled) msgGood("Sending YouTube information");
                client.SendMessage($"Youtube: http://yt.xeinix.me");
            }
            if (e.ChatMessage.Message.Equals("!commands", StringComparison.InvariantCultureIgnoreCase))
            {
                if (isChatEnabled) msgGood($"Whispering to: {e.ChatMessage.DisplayName} commands.");
                client.SendMessage($"Please check your whispers.");
                client.SendWhisper(e.ChatMessage.Username, "!itch, !twitter, !instagram, !commands, !help");
            }
            if (e.ChatMessage.Message.Equals("!help", StringComparison.InvariantCultureIgnoreCase))
            {
                if (isChatEnabled) msgGood($"Whispering to: {e.ChatMessage.DisplayName} commands.");
                client.SendMessage($"Please check your whispers.");
                client.SendWhisper(e.ChatMessage.Username, "!itch, !twitter, !instagram, !commands, !help");
            }
        }
        private void clientOnConnectionError(object sender, OnConnectionErrorArgs e)
        {
            msgError($"Error!! {e.Error}");
        }
        private void clientOnLog(object sender, OnLogArgs e)
        {
            // msg(e.Data);
        }
        public void setChatEnabled(bool e)
        {
            isChatEnabled = e;
        }
        private void clientOnUserJoined(object sender, OnUserJoinedArgs e)
        {
            if (isChatEnabled) msgGood($"User {e.Username} joined chat!");
            client.SendMessage($"Welcome {e.Username} to the channel!");
        }
        #endregion



        #region Command Methods


        internal void Connect()
        {
            msg("Connecting");
            try
            {
                client = new TwitchClient(credentials, reg.GetValue(regChannelName, null).ToString(), logging: false);

                client.OnLog += clientOnLog;
                client.OnConnectionError += clientOnConnectionError;
                client.OnMessageReceived += clientOnMessageReceived;
                client.OnConnected += clientOnConnected;
                client.OnUserJoined += clientOnUserJoined;
                client.OnDisconnected += clientOnDisconnected;
                 /*
                if (!isThreadCreated)
                {
                    threadRepeatMessage = new Thread(new ThreadStart(RepeatMessage));
                }
                if (!isThreadRunning)
                {
                    threadRepeatMessage.Start();
                }
                */
            }
            catch (Exception h)
            {
                msgError($"{h.Message} Thrown while trying to connect to Twitch.");
                return;
            }
            client.Connect();

        }
        internal void Disconnect()
        {
            client.SendMessage("Exilios is leaving. Goodbye.");
            msg("Disconnecting");
            client.Disconnect();
        }
        public void SendMessage(string m)
        {
            client.SendMessage(m);
        }
        #endregion

        #region Message Methods
        static void msgWarn(string m)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(m);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void msgError(string m)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(m);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void msg(string m)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(m);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void msgGood(string m)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(m);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion


    }

}