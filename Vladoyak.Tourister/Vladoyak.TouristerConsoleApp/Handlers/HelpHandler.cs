using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    public class HelpHandler : IHandler
    {
        private string[] _words;

        public HelpHandler(string[] words)
        {
            _words = words;
        }

        public void Handle()
        {
            if (_words.Length > 1)
            {
                string command = _words[1];
                switch (command)
                {
                    case "trailpoint":
                        Console.WriteLine("------------------");
                        Console.WriteLine("trailpoint command");
                        Console.WriteLine("------------------");
                        Console.WriteLine();
                        Console.WriteLine("description:");
                        Console.WriteLine("------------");
                        Console.WriteLine("gets information about trailpoints, adding new trailpoints, removing trailpoints");
                        Console.WriteLine();
                        Console.WriteLine("usage:");
                        Console.WriteLine("------");
                        Console.WriteLine("trailpoint");
                        Console.WriteLine("trailpoint -add [code] [name]");
                        Console.WriteLine("trailpoint -remove [code]");
                        break;
                }
            }
            else
            {
                new IntroductionHandler().Handle();
            }
        }
    }
}
