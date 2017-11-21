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
        public static string progName = "Exilios";
        public static double progVer = 0.2;
        #endregion

        static void Main(string[] args)
        {
            msgGood(progName + " is alive! Version: v." + progVer);
            
            TwitchChatBot bot = new TwitchChatBot();
            bot.Connect();
            Console.ReadLine(); // Replace with a built in console system later for interesting with twitch chat.
            bot.Disconnect();
            



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
