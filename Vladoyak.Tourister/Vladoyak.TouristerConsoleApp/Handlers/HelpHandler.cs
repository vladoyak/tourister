using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    public class HelpHandler : IHandler
    {
        public void Handle()
        {
            Console.WriteLine("Tourister App");
            Console.WriteLine();
            Console.WriteLine("Possible commands:");
            Console.WriteLine("");
            Console.WriteLine("help - writes this help");
            Console.WriteLine("exit - exists app");
        }
    }
}
