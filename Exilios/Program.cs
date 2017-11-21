#region Default using tags.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace Exilios
{
    class Program
    {
        #region Program Management Variables
        public static string progName = "Exilios Bot Suite";
        public static double progVer = 0.3;
        #endregion

        #region Console Vars
        static bool isRunning = true;
        static string command;
        #endregion

        #region Twitch Bot Vars
        static bool isBotCreated = false;
        static bool isBotRunning = false;
        static TwitchChatBot bot;
        #endregion

        static void Main(string[] args)
        {
            msgGood(progName + " is running. Version: v." + progVer);
            msg("For list of availiable commands, please check github.com/xeinix/exilios");
            /* Put back in after the console is written.
            bot = new TwitchChatBot();
            bot.Connect();
            Console.ReadLine(); // Replace with a built in console system later for interesting with twitch chat.
            bot.Disconnect();
            */             
            while (isRunning)
            {
                command = prompt(":> ");
                command = command.ToLower();
                if (command == "istwitchrunning") isTwitchBotRunning();
                else if (command == "twitchrun") twitchRun();
                else if (command == "twitchconnect") twitchConnect();
                else if (command == "twitchdisconnect") twitchDisconnect();
                else if (command == "exit") exit();
                else msgError("No command found! Please try again.");
            }


        }

        #region Command Methods
        static string prompt(string m)
        {
            Console.Write(m);
            return Console.ReadLine();
        }
        static void isTwitchBotRunning()
        {
            if (isBotCreated)
            {
                if (isBotRunning == true)
                {
                    msgGood("The Twitch bot is currently running.");
                }
                else
                {
                    msgError("The Twitch Bot is not currently running");
                }
            }
            else msgError("Please create the bot first using 'twitchRun'.");
        }
        static void twitchRun()
        {
            if (!isBotCreated)
            {
                bot = new TwitchChatBot();
                isBotCreated = true;
                bot.Connect();
                isBotRunning = true;
                System.Threading.Thread.Sleep(1200);
            }
            else msgError("The bot is already created. Please run 'twitchConnect' to connect to Twitch.");
        }
        static void twitchConnect()
        {
            if (!isBotRunning && isBotCreated)
            {
                bot.Connect();
                isBotRunning = true;
                System.Threading.Thread.Sleep(1200);
            }
            else msgError("Either the bot is already running or has not been created yet.");
        }
        static void twitchDisconnect()
        {
            if (isBotRunning && isBotCreated)
            {
                bot.Disconnect();
                System.Threading.Thread.Sleep(1200);
                isBotRunning = false;
            }
            else msgError("Either the bot is already stopped or has not been created yet.");
        }
        static void exit()
        {
            isRunning = false;
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
