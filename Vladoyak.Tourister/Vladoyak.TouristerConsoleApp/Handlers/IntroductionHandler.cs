using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    public class IntroductionHandler : IHandler
    {
        public void Handle()
        {
            Console.WriteLine("TOURISTER APP");
            Console.WriteLine();
            Console.WriteLine("Possible commands:");
            Console.WriteLine("\thelp - writes this help");
            Console.WriteLine("\t\thelp [command]- writes command help, e. g. help trailpoint");
            Console.WriteLine("\texit - exits app");
            Console.WriteLine("\ttrailpoint - information about trailpoints");
            Console.WriteLine("\ttrip - information about trips");
            Console.WriteLine("\t\ttrip -add [code] [year] [month] [day] - adds new trip");
            Console.WriteLine();
        }
    }
}
