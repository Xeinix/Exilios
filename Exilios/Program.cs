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
        public static double progVer = 0.1;
        #endregion

        static void Main(string[] args)
        {
            TwitcChatBot bot = new TwitchChatBot();
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
