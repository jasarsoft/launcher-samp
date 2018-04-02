using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Query.Query sQuery = new Query.Query("127.0.0.1", 7777);

            sQuery.Send('p');

            int count = sQuery.Receive();

            string[] info = sQuery.Store(count);

            foreach (string i in info)
                Console.WriteLine(i);

            Console.ReadKey();
            /* 
             * Variable 'info' might now contain:   
             *   Password   Players     Max. players    Hostname                Gamemode    Language
             * { "0",       "12",       "500",          "Query test server",    "LVDM",     "English" }
             */

            //-------------------------

            Query.RCONQuery sRCONQuery = new Query.RCONQuery("127.0.0.1", 7777, "123");

            sRCONQuery.Send("myriad");

            count = sRCONQuery.Rceive();

            string[] infoRCON = sQuery.Store(count);
            foreach (string i in infoRCON)
                Console.WriteLine(i);

            Console.ReadKey();

            /* 
             * Variable 'info' might now contain:
             * { "Hello from C#" }
             */
        }
    }
}
