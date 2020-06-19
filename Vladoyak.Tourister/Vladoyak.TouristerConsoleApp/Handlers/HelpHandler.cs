using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    public class HelpHandler : IHandler
    {
        public void Handle()
        {
            Console.WriteLine("TOURISTER APP");
            Console.WriteLine();
            Console.WriteLine("Possible commands:");
            Console.WriteLine("\thelp - writes this help");
            Console.WriteLine("\texit - exits app");
            Console.WriteLine();
        }
    }
}
