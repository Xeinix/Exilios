#region Default using tags.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Exilios.Resources;
using Exilios.Windows_Forms;
#endregion

namespace Exilios
{
    class Program
    {

        #region Registry Stuff.
        static RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Exilios");

        static String regIsConfig = "isConfig";
        static String regBotToken = "botToken";
        static String regClientId = "clientId";
        static String regBotUsername = "botUsername";
        static String regChannelName = "botChannelName";
        static String regConnectOL = "connectOnLaunch";
        #endregion

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

        [STAThread]
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            msgGood(progName + " is running. Version: v." + progVer);
            msg("For list of availiable commands, please check github.com/xeinix/exilios");         
            while (isRunning)
            {
                command = prompt(":> ");
                command = command.ToLower();
                if (command == "istwitchrunning") isTwitchBotRunning();
                else if (command == "twitchrun") twitchRun();
                else if (command == "twitchconnect") twitchConnect();
                else if (command == "twitchdisconnect") twitchDisconnect();
                else if (command == "exit") exit();
                else if (command == "clear") clear();
                else if (command == "twitchchat") twitchChat();
                else if (command == "config") config();

                // Remove before release
                else if (command == "regreset") regReset();
                else if (command == "regset") regSet();

                else msgError("No command found! Please try again.");
            } // Console Command Window


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

            if (reg.GetValue(regIsConfig, null) != null)
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
            else msgError("You have not configured Exilios yet. Please run 'config'.");
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
        static void clear()
        {
            Console.Clear();
        }
        static void exit()
        {
            if (isBotCreated) bot.Disconnect();
            isRunning = false;
        }
        static void twitchChat()
        {
            if (isBotRunning)
            {
                clear();
                msgGood("In Chat Mode. To send a message to chat press 't' to get out, press any other key.");
                bool chatEnabled = true;
                while (chatEnabled)
                {
                    bot.setChatEnabled(true);
                    ConsoleKeyInfo d = Console.ReadKey();
                    if (d.KeyChar == 't')
                    {
                        bot.SendMessage(prompt("\n Enter Message: "));

                    }
                    else chatEnabled = false;
                    bot.setChatEnabled(false);
                }
            }
            else msgError("Twitch bot not enabled. Can't access chat.");
        }
        static void config()
        {
            msgError("Config Window Not Created! isConfig=" + reg.GetValue("isConfig", null));
            Application.Run(new Configuration());
        }
#endregion

        static void regReset()
        {
            reg.SetValue("isConfig", false);
        }
        static void regSet()
        {
            reg.SetValue("isConfig", true);
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
