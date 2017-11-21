using System;
using Microsoft.Win32;
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
        static RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Exilios");
        readonly ConnectionCredentials credentials = new ConnectionCredentials(TwitchCredentials.botUsername, TwitchCredentials.botToken);
        TwitchClient client;
        static bool isChatEnabled = false;

        internal void Connect()
        {
            msg("Connecting");

            client = new TwitchClient(credentials, TwitchCredentials.channelName, logging: false);

            client.OnLog += clientOnLog;
            client.OnConnectionError += clientOnConnectionError;
            client.OnMessageReceived += clientOnMessageReceived;
            client.OnConnected += clientOnConnected;

            client.Connect();

        }

        private void clientOnConnected(object sender, OnConnectedArgs e)
        {
            msgGood("Connected To Twitch Chat!");
            client.SendMessage("EiliosBot is alive! Muhahaha");
        }

        private void clientOnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (isChatEnabled) msg(e.ChatMessage.DisplayName + ": " +e.ChatMessage.Message);
            if(e.ChatMessage.Message.StartsWith("hi", StringComparison.InvariantCultureIgnoreCase))
            {
                client.SendMessage($"Hey there {e.ChatMessage.DisplayName}.");
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

        internal void Disconnect()
        {
            msg("Disconnecting");
        }

        public void setChatEnabled(bool e)
        {
            isChatEnabled = e;
        }

        public void SendMessage(string m)
        {
            client.SendMessage(m);
        }

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